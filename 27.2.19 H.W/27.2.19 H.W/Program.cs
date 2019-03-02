using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace _27._2._19_H.W
{
    class Program
    {
        static void Main(string[] args)
        {
            Camp camp1 = new Camp(40, 50, 50, 25, 50);
            Camp camp2 = new Camp(70, 60, 65, 33, 65);
            /*if(camp1.NumberOfPeople>camp2.NumberOfPeople)
            {
                Console.WriteLine("big");
            }
            else if(camp1.NumberOfPeople==camp2.NumberOfPeople)
            {
                Console.WriteLine("the same");
            }
            else
                Console.WriteLine("small");
            Console.WriteLine(camp1 > camp2);
           Camp camp3= camp1 + camp2;
            Console.WriteLine(camp3);
          
            XmlSerializer myXmlSerializer = new XmlSerializer(typeof(Camp));

            using (Stream file = new FileStream(@"c:\temp\xmlfile.xml", FileMode.Create)) // creating new file stream
            {
                myXmlSerializer.Serialize(file, camp1);

            } //closing file stream
            */

            Camp p2;

            XmlSerializer myXmlSerializer = new XmlSerializer(typeof(Camp));

            using (Stream file = new FileStream(@"c:\temp\xmlfile.xml", FileMode.Open)) // creating new file stream
            {
                p2 = myXmlSerializer.Deserialize(file) as Camp;

            }
            Camp camp;

            XmlSerializer XmlSerializer = new XmlSerializer(typeof(Camp));

            using (Stream file = new FileStream(@"c:\temp\xmlfile.xml", FileMode.Open)) // creating new file stream
            {
                camp = XmlSerializer.Deserialize(file) as Camp;

            }
            Console.WriteLine(camp==p2);
            Console.WriteLine( camp.GetHashCode());
            Console.WriteLine(p2.GetHashCode());

        }
    }
}
