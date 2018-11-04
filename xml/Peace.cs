using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace xml
{
    public class Peace
    {
        public string Name { get; set; }
        public string Reference { get; set; }
        public string Specification { get; set; }
        public DateTime PublicationDate { get; set; }

        public void Preservation()
        {
            using (StreamWriter author = new StreamWriter("source.txt", true))
            {
                author.WriteLine(Reference);
                author.WriteLine(Name);
                author.WriteLine(Specification);
                author.WriteLine(PublicationDate);
            }
        }
    }
}
