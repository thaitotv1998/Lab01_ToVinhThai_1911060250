using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_3_4
{
    class NhaPho : ChungCu
    {
        private int namXD;

        public int NamXD { get => namXD; set => namXD = value; }

        public NhaPho() : base() { }
        public NhaPho(string dd, double gia, float dt, int sotang, int namxd) : base(dd, gia, dt, sotang)
        {
            NamXD = namxd;
        }

        public override void Input()
        {
            base.Input();
            string isNumb;
            do
            {
                Console.Write("Nhập năm xây dụng: ");
                isNumb = Console.ReadLine();
            } while (isNumber(isNumb));
            NamXD = int.Parse(isNumb);
        }

        public override void Output()
        {
            base.Output();
            Console.WriteLine($" - Năm xây dựng: {NamXD}");
        }
    }
}
