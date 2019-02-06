//Grant Downs
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF1
{
    public class Application1
    {
        public string Name;
        public string Address;
        public int ZipCode;

        public Application1()
        {
            Name = "";
            Address = "";
            ZipCode = 0;

        }

        public Application1(string name, string address, int zipCode)
        {
            name = Name;
            address = Address;
            zipCode = ZipCode;

        }
        public override string ToString()
        {
            return $"{Name} {Address} {ZipCode}";
        }
    }
}
