using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using System.Xml.Linq;
using System.Data;
using System.Xml.Serialization;
namespace serialize
{
    class Program
    {
        static void Main(string[] args)
        {
            //using (TextReader reader = new StreamReader(@"D:\XML.xml"))
           using (XmlReader reader = XmlReader.Create((@"C:\Users\M1037727\Documents\Visual Studio 2015\Projects\xmlvalidation\XML.xml")))
           // using (XmlReader reader = XmlReader.Create("XML.xml"))
            {
                while (reader.Read())
                {
                    switch (reader.NodeType)
                    {
                        case XmlNodeType.Element:
                            Console.Write("<" + reader.Name);
                            while (reader.MoveToNextAttribute())
                            {
                                Console.Write(" " + reader.Name + "=" + reader.Value + " ");
                            }
                            Console.WriteLine(">");
                            break;
                        case XmlNodeType.Text:
                            Console.WriteLine(reader.Value);
                            break;
                        case XmlNodeType.EndElement:
                            Console.WriteLine("</" + reader.Name + ">");
                            break;
                    }
                }
                Console.ReadKey();
            }
        }
    }
}
