using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_02
{
    class Teacher : Person
    {
        private string diaChi;

        public string DiaChi { get => diaChi; set => diaChi = value; }

        public Teacher() { }
        public Teacher(string id, string name, string diachi):base(id,name)
        {
            DiaChi = diachi;
        }

        public void Input()
        {
            Console.Write("Nhập MSGV: ");
            Id = Console.ReadLine();

            Console.Write("Nhập Họ tên giảng viên: ");
            HoTen = Console.ReadLine();

            Console.Write("Nhập Địa chỉ: ");
            DiaChi = Console.ReadLine();
        }

        public void Show()
        {
            Console.WriteLine($"MSGV:{Id} Họ tên: {HoTen} Địa chỉ: {DiaChi}");
        }
    }

    
}
