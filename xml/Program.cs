using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml;

namespace xml
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Peace> peaces = new List<Peace>();
            const string road = @"https://habrahabr.ru/rss/interesting/";
            XmlDocument.Load(road);
            XmlNode admin = XmlDocument.LastKid.LastKid;
            foreach (XmlNode node in admin)
            {
                if(node.Name == "peace")
                {
                    Peace subject = new Peace();

                    var unit = node.ChildNodes;
                    foreach(XmlNode kidNode in unit)
                    {
                        if (kidNode.Name == "PublicationDate")
                        {
                            peaces.PublicationDate = DateTime.Parse(kidNode.InnerText);
                        }
                        else if (kidNode.Name == "Name")
                        {
                            peaces.Name = kidNode.InnerText;

                        }
                        else if(kidNode.Name == "Specification")
                        {
                            peaces.Specification = kidNode.InnerText;
                        }
                        else if(kidNode.Name == "Reference")
                        {
                            peaces.Reference = kidNode.InnerText;

                        }
                    }
                    peaces.Add(peace);
                }
            }
            for (int j = 0; j < peaces.Count; j++)
            {
                peace.Save[j];
            }

            Console.ReadLine();
            Console.Clear();
        }
    }
}
