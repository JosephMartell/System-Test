using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Linq;
using System.Xml.XPath;

namespace System_Test.Test
{
    public static class XMLTranslator
    {
        public static XElement TranslateDefinition(Definition def)
        {
            return new XElement("TestDefinition", 
                new XAttribute("name", def.Name), 
                new XAttribute("interval", def.TickInterval), 
                def.TestSteps.Select(ts => TranslateStep(ts)).ToArray());
        }

        private static XElement TranslateStep(Step step)
        {
            return new XElement("TestStep",
                step.TagActions.Select(a => TranslateWriteTag(a)).ToArray(),
                step.Asserts.Select(t => TranslateAssert(t)).ToArray());
        }

        private static object TranslateAssert(AssertTagEqual t)
        {
            return new XElement("AssertTagEqual"
                , new XAttribute("tagName", t.TagName)
                , new XAttribute("expectedValue", t.ExpectedValue));
        }

        private static object TranslateWriteTag(WriteTag a)
        {
            return new XElement("WriteTag", new XAttribute("tagName", a.TagName), new XAttribute("value", a.Value));
        }

        private static XElement TranslateTest(AssertEqual t)
        {
            return new XElement("AssertEqual", new XAttribute("Register", t.StartRegister), new XAttribute("ExpectedValue", t.ExpectedValue));
        }

        public static IEnumerable<Definition> TranslateXML(XDocument doc)
        {
            List<Definition> defs = new List<Definition>();
            foreach (var node in doc.DescendantNodes())
            {
                if (node.NodeType == XmlNodeType.Element)
                {
                    var el = (XElement)node;
                    if (el.Name == "TestDefinition")
                    {
                        Definition def = new Definition()
                        {
                            Name = el.Attribute("name").Value,
                            TickInterval = Convert.ToInt32(el.Attribute("interval").Value)
                        };
                        var xmlSteps = el.Descendants("TestStep");
                        foreach (var xmlStep in xmlSteps)
                        {
                            Step s = new Step();
                            var xmlActions = xmlStep.Descendants("WriteTag");
                            var xmlTests = xmlStep.Descendants("AssertEqual");
                            var xmlAsserts = xmlStep.Descendants("AssertTagEqual");
                            s.TagActions = s.TagActions.Concat(xmlActions.Select(
                                x => new WriteTag()
                                {
                                    TagName = x.Attribute("tagName").Value,
                                    Value = x.Attribute("value").Value
                                }));
                            s.Asserts = s.Asserts.Concat(
                                xmlAsserts.Select(
                                    t => new AssertTagEqual()
                                    {
                                        TagName = t.Attribute("tagName").Value,
                                        ExpectedValue = t.Attribute("expectedValue").Value
                                    }
                                ));
                            def.TestSteps.Add(s);
                        }
                        defs.Add(def);
                    }
                }
            }
            return defs;
        }
    }

}
