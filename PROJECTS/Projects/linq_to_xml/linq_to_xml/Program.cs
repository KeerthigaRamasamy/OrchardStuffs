using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;


//creating an xml document using linq
namespace linq_to_xml
{
    class Program
    {
        static void Main(string[] args)
        {
            XDocument document = new XDocument(
                                    new XDeclaration("1.0", "utf-8", "yes"),
                                    new XElement("Students",
                                        new XElement("Student", new XAttribute("Id", 101),
                                            new XElement("Name", "keerthi"),
                                            new XElement("Gender", "Female"),
                                            new XElement("marks", 900)),
                                        new XElement("Student", new XAttribute("Id", 102),
                                            new XElement("Name", "gangotri"),
                                            new XElement("Gender", "Female"),
                                            new XElement("marks", 980)),
                                        new XElement("Student", new XAttribute("Id", 103),
                                            new XElement("Name", "cibi"),
                                            new XElement("Gender", "male"),
                                            new XElement("marks", 870)),
                                        new XElement("Student", new XAttribute("Id", 104),
                                            new XElement("Name", "karthik"),
                                            new XElement("Gender", "male"),
                                            new XElement("marks", 1000))
                                    ));
            document.Save(@"D:\xml");
            Console.ReadKey();
        }
    }
}
