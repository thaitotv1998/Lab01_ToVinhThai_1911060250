using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_02
{
    class Person
    {
        public string maSo;
        public string hoTen;

        public string Id
        {
            get { return maSo; }
            set { maSo = value; }
        }

        public string HoTen
        {
            get { return hoTen; }
            set { hoTen = value; }
        }

        public Person() { }
        public Person(string id, string name)
        {
            Id = id;
            HoTen = name;
        }
    }
}
