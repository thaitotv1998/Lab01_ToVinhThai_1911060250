using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_02
{
    class Student : Person
    {
        private float averageScore;
        private string faculty;

        public float AverageScore
        {
            get { return averageScore; }
            set { averageScore = value; }
        }

        public string Faculty
        {
            get { return faculty; }
            set { faculty = value; }
        }

        public Student() { }
        public Student(string id, string name, float dtb, string faculty) : base(id,name)
        {
            AverageScore = dtb;
            Faculty = faculty;
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

        public void Input()
        {
            Console.Write("Nhập MSSV: ");
            Id = Console.ReadLine();

            Console.Write("Nhập Họ tên sinh viên: ");
            HoTen = Console.ReadLine();
            string isScore;
            do
            {
                Console.Write("Nhập Điểm TB: ");
                isScore = Console.ReadLine();
            } while (isNumber(isScore));
            
            AverageScore = float.Parse(isScore);

            Console.Write("Nhập Khoa: ");
            Faculty = Console.ReadLine();
        }

        public void Show()
        {
            Console.WriteLine($"MSSV:{Id} Họ tên: {HoTen} Khoa: {Faculty} Điểm TB: {AverageScore}");
        }
    }
}
