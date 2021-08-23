using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    class Student
    {
        //1. Tạo thuộc tính
        private string studentID;
        private string fullName;
        private float averageScore;
        private string faculty;

        //2. Tao các Property
        public string StudentID
        {
            get
            {
                return studentID;
            }
            set
            {
                studentID = value;
            }
        }
        public string FullName
        {
            get
            {
                return fullName;
            }
            set
            {
                fullName = value;
            }
        }
        public float AverageScore
        {
            get
            {
                return averageScore;
            }
            set
            {
                averageScore = value;
            }
        }
        public string Faculty
        {
            get
            {
                return faculty;
            }
            set
            {
                faculty = value;
            }
        }
        //3. Constructor không tham số
        public Student()
        {

        }
        //4. Constructor có tham số
        public Student(string id, string name, float score, string faculty)
        {
            StudentID = id;
            FullName = name;
            AverageScore = score;
            Faculty = faculty;
        }
        //5. Phương thức nhập xuất
        public void Input()
        {
            Console.Write("Nhập MSSV: ");
            StudentID = Console.ReadLine();

            Console.Write("Nhập Họ tên sinh viên: ");
            FullName = Console.ReadLine();

            Console.Write("Nhập Điểm TB: ");
            AverageScore = float.Parse(Console.ReadLine());

            Console.Write("Nhập Khoa: ");
            Faculty = Console.ReadLine();
        }
        
        public void Show()
        {
            Console.WriteLine("MSSV:{0} Họ tên: {1} Khoa: {2} Điểm TB: {3}", this.StudentID, this.FullName, this.Faculty, this.AverageScore);
        }
    }
}
