using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_3_4
{
    class KhuDat
    {
        private string diaDiem;
        private double giaBan;
        private float dienTich;

        //Prpperties
        public string DiaDiem
        {
            get { return diaDiem; }
            set { diaDiem = value; }
        }

        public double GiaBan
        {
            get { return giaBan; }
            set { giaBan = value; }
        }
        public float DienTich
        {
            get { return dienTich; }
            set { dienTich = value; }
        }

        //Constructor
        public KhuDat() { }
        public KhuDat(string dd, double gia, float dt)
        {
            DiaDiem = dd;
            GiaBan = gia;
            DienTich = dt;
        }

        public bool isNumber(string value)
        {
            foreach (var item in value)
            {
                if (char.IsDigit(item))
                    return false;
            }
            return true;
        }

        public virtual void Input()
        {

            Console.Write("Nhập địa điểm: ");
            DiaDiem = Console.ReadLine();

            string isGia, isDT;
            do
            {
                Console.Write("Nhập giá bán: ");
                isGia = Console.ReadLine();
            } while (isNumber(isGia));
            GiaBan = double.Parse(isGia);

            do
            {
                Console.Write("Nhập diện tích: ");
                isDT = Console.ReadLine();
            } while (isNumber(isDT));
            DienTich = float.Parse(isDT);
        }

        public virtual void Output()
        {
            Console.Write($"Địa điêm: {DiaDiem} - Giá Bán: {GiaBan} - Diện tích: {DienTich}");
        }
    }
}
