using Microsoft.Win32;
using ModbusTCP;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace System_Test.Comms
{
    public class TagFactory
    {
        protected MBTCPClient Client { get; }
        public TagFactory(MBTCPClient client)
        {
            Client = client;
        }
        public IntegerTag CreateIntegerTag(string name, string itemPath)
        {
            return new IntegerTag(Client, name, itemPath);
        }
        public SingleTag CreateSingleTag(string name, string itemPath)
        {
            return new SingleTag(Client, name, itemPath);
        }
        public BoolTag CreateBoolTag(string name, string itemPath)
        {
            return new BoolTag(Client, name, itemPath);
        }
        public LongTag CreateLongTag(string name, string itemPath)
        {
            return new LongTag(Client, name, itemPath);
        }
    }

    public class IntegerTag
        : Tag<Int16>
    {
        public override Int16 Value
        {
            get
            {
                return Client.ReadHoldingRegisters(Convert.ToInt16(ItemPath.Substring(ItemPath.IndexOf("HR") + 2)), 1).First();
            }
            set
            {
                Client.WriteMultipleRegisters(Convert.ToInt16(ItemPath.Substring(ItemPath.IndexOf("HR") + 2)), new Int16[] { value });
            }            
        }
        public IntegerTag(MBTCPClient client, string name, string itemPath)
            : base(client, name, itemPath)
        {
        }
    }

    public class LongTag
        : Tag<Int32>
    {
        public override Int32 Value
        {
            get
            {
                short[] words = Client.ReadHoldingRegisters(Convert.ToInt16(ItemPath.Substring(ItemPath.IndexOf("HRI") + 3)), 2).Take(2).ToArray();
                List<byte> bytes = new List<byte>();
                foreach (var w in words)
                {
                    bytes.AddRange(w.GetBytes());
                }
                return BitConverter.ToInt32(bytes.ToArray());
            }
            set
            {
                List<byte> bytes = new List<byte>();
                bytes.AddRange(BitConverter.GetBytes(value));
                List<short> words = new List<short>();
                words.Add(BitConverter.ToInt16(bytes.Take(2).ToArray()));
                words.Add(BitConverter.ToInt16(bytes.Skip(2).Take(2).ToArray()));
                Client.WriteMultipleRegisters(Convert.ToInt16(ItemPath.Substring(ItemPath.IndexOf("HRI") + 3)), words);
            }
        }
        public LongTag(MBTCPClient client, string name, string itemPath)
            : base(client, name, itemPath)
        {
        }
    }

    public class SingleTag
        : Tag<float>
    {
        public override float Value
        {
            get
            {
                return FloatExtensions.FromWords(Client.ReadHoldingRegisters(Convert.ToInt16(ItemPath.Substring(ItemPath.IndexOf("HRF") + 3)), 2), 0);
            }
            set
            {
                Client.WriteMultipleRegisters(Convert.ToInt16(ItemPath.Substring(ItemPath.IndexOf("HRF") + 3)), value.GetWordsAsInt16());
            }
        }
        public SingleTag(MBTCPClient client, string name, string itemPath)
            : base(client, name, itemPath)
        {
        }
    }

    public class BoolTag 
        : Tag<bool>
    {
        public Int16 Register { get; }
        public override bool Value 
        { 
            get
            {
                if (ItemPath.StartsWith("HR"))
                {
                    var regNum = ItemPath.Substring(ItemPath.IndexOf("HR") + 2, ItemPath.LastIndexOf(".") - ItemPath.IndexOf("HR") - 2);
                    var word = Client.ReadHoldingRegisters(Convert.ToInt16(regNum), 1).First();
                    var bit = Convert.ToInt32(ItemPath.Substring(ItemPath.LastIndexOf(".") + 1));
                    return word.GetBit(bit);
                }
                else if (ItemPath.StartsWith("C"))
                {
                    var coilNum = Convert.ToInt16(ItemPath.Substring(ItemPath.IndexOf("C") + 1));
                    return Client.ReadCoil(coilNum, 1).First();
                }
                else
                {
                    return false;
                }
            } 
            set
            {
                if (ItemPath.StartsWith("HR"))
                {
                    var regNum = Convert.ToInt16(ItemPath.Substring(ItemPath.IndexOf("HR") + 2, ItemPath.LastIndexOf(".") - ItemPath.IndexOf("HR") - 2));
                    var word = Client.ReadHoldingRegisters(regNum, 1).First();
                    var bit = Convert.ToInt16(ItemPath.Substring(ItemPath.LastIndexOf(".") + 1));
                    var mask = BitConverter.ToInt16( BitConverter.GetBytes(Convert.ToUInt16(Math.Pow(2, bit))));
                    var newWord = Convert.ToInt16(value ? word | mask : word & ~mask);
                    //Client.MaskWriteRegister(regNum, Convert.ToInt16(~mask), Convert.ToInt16(Value ? mask : 0x0000));
                    Client.WriteMultipleRegisters(regNum, new short[] { newWord });
                }
                else if (ItemPath.StartsWith("C"))
                {
                    var coilNum = Convert.ToInt16(ItemPath.Substring(ItemPath.IndexOf("C") + 1));
                    Client.WriteSingleCoil(coilNum, value);
                }
            } 
        }
        public BoolTag(MBTCPClient client, string name, string itemPath)
            : base(client, name, itemPath)
        {

        }
    }

    public abstract class Tag<T>
    {
        public string Name { get; }
        public string ItemPath { get; }
        public abstract T Value
        {
            get;
            set;
        }
        protected MBTCPClient Client { get; }
        public Tag(MBTCPClient client, string name, string itemPath)
        {
            Client = client;
            Name = name;
            ItemPath = itemPath.ToUpper();
        }
        public override string ToString()
        {
            return Name;
        }
    }
}
