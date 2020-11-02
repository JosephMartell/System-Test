using System;
using System.Collections.Generic;
using System.Text;
using System.Xml.Linq;

namespace System_Test.Comms
{
    public static class XMLTranslator
    {
        public static XElement TranslateTag(SingleTag tag)
        {
            return new XElement("SingleTag"
                , new XAttribute("name", tag.Name)
                , new XAttribute("itemPath", tag.ItemPath));
        }

        public static XElement TranslateTag(IntegerTag tag)
        {
            return new XElement("IntegerTag"
                , new XAttribute("name", tag.Name)
                , new XAttribute("itemPath", tag.ItemPath));
        }

        public static XElement TranslateTag(BoolTag tag)
        {
            return new XElement("BoolTag"
                , new XAttribute("name", tag.Name)
                , new XAttribute("itemPath", tag.ItemPath));
        }

        public static XElement TranslateTag(LongTag tag)
        {
            return new XElement("LongTag"
                , new XAttribute("name", tag.Name)
                , new XAttribute("itemPath", tag.ItemPath));
        }

        public static void AddTagsToDevice(Device device, XDocument doc)
        {
            var intTags = new List<IntegerTag>();
            var intTagXML = doc.Descendants("IntegerTag");
            var singleTagXML = doc.Descendants("SingleTag");
            var boolTagXML = doc.Descendants("BoolTag");
            var longTagXML = doc.Descendants("LongTag");
            foreach (var tag in intTagXML)
            {
                device.CreateIntegerTag(tag.Attribute("name").Value, tag.Attribute("itemPath").Value);
            }

            foreach (var tag in singleTagXML)
            {
                device.CreateSingleTag(tag.Attribute("name").Value, tag.Attribute("itemPath").Value);
            }

            foreach (var tag in boolTagXML)
            {
                device.CreateBoolTag(tag.Attribute("name").Value, tag.Attribute("itemPath").Value);
            }

            foreach (var tag in longTagXML)
            {
                device.CreateLongTag(tag.Attribute("name").Value, tag.Attribute("itemPath").Value);
            }
        }

    }
}
