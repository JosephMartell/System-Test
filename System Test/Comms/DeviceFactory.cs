using ModbusTCP;
using System;
using System.Collections.Generic;
using System.Net;
using System.Text;

namespace System_Test.Comms
{

    public class Device
    {
        public string Name { get; }
        public MBTCPClient Client { get; }

        public TagFactory TagFactory { get; }

        public Dictionary<string, SingleTag> SingleTags { get; } = new Dictionary<string, SingleTag>();
        public Dictionary<string, IntegerTag> IntegerTags { get; } = new Dictionary<string, IntegerTag>();
        public Dictionary<string, BoolTag> BoolTags { get; } = new Dictionary<string, BoolTag>();
        public Dictionary<string, LongTag> LongTags { get; } = new Dictionary<string, LongTag>();
        public Device(string name, MBTCPClient client)
        {
            Name = name;
            Client = client;
            TagFactory = new TagFactory(client);
        }

        public SingleTag CreateSingleTag(string name, string itemPath)
        {
            var newTag = TagFactory.CreateSingleTag(name, itemPath);
            SingleTags.Add(newTag.Name, newTag);
            return newTag;
        }

        public IntegerTag CreateIntegerTag(string name, string itemPath)
        {
            var newTag = TagFactory.CreateIntegerTag(name, itemPath);
            IntegerTags.Add(newTag.Name, newTag);
            return newTag;
        }
        public LongTag CreateLongTag(string name, string itemPath)
        {
            var newTag = TagFactory.CreateLongTag(name, itemPath);
            LongTags.Add(newTag.Name, newTag);
            return newTag;
        }
        public BoolTag CreateBoolTag(string name, string itemPath)
        {
            BoolTag btag = new BoolTag(Client, name, itemPath);
            BoolTags.Add(name, btag);
            return btag;
        }
        public override string ToString()
        {
            return $"{Name}";
        }
    }
    public static class DeviceFactory
    {
        public static Dictionary<string, Device> Clients = new Dictionary<string, Device>();

        /// <summary>
        /// Returns an existing MB TCP client or, if an existing one cannot be found based
        /// on the provided details name, creates one.
        /// </summary>
        /// <param name="name"></param>
        /// <param name="ipAddress"></param>
        /// <param name="port"></param>
        /// <returns>A MB TCP client</returns>
        public static Device GetOrCreateDevice(string name, IPAddress ipAddress, int port)
        {
            if (Clients.ContainsKey(name))
                return Clients[name];
            else
            {
                var client = new Device(name, new MBTCPClient(ipAddress));
                Clients[name] = client;
                return client;
            }
        }

        public static Device GetDevice(string name)
        {
            if (Clients.ContainsKey(name))
                return Clients[name];
            else
                return null;
        }
    }
}
