using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;
using System.Xml.Linq;
using System.Xml.Schema;


//validate the xml document with the corresponding xml schema
namespace xmlvalidation
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("-----Xml Validation----");
            bool validation_errors = false;
            //creating an object of xmlschema set to refer the schema document
            XmlSchemaSet schema = new XmlSchemaSet();
            schema.Add("", @"C:\Users\M1037727\Documents\student_schema.xsd");

            //creatinga n object for xmldocument to specify the path of the xml file

            XDocument document = XDocument.Load(@"C:\Users\M1037727\Documents\student.xml");

            document.Validate(schema,(s, e) =>
                                 {
                                     Console.WriteLine(e.Message);
                                     validation_errors = true;
                                 });

            if(validation_errors)
            {
                Console.WriteLine("Validation failed!!");
            }
            else
            {
                Console.WriteLine("Validation Successfull!");
            }
            Console.ReadKey();                
        }
    }
}
