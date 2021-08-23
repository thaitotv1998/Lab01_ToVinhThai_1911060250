using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_02
{
    class Program
    {
        static List<Teacher> listTeacher = new List<Teacher>();
        static List<Student> listStudent = new List<Student>();

        //Hàm main
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            ChoosePerson();
            if (listStudent.Count != 0)
            {
                MenuSV(listStudent);
            }
            else if (listTeacher.Count != 0)
                MenuGV(listTeacher);
        }

        //Xuất danh sách giảng viên có địa chỉ chứa thông tin Quận 9
        private static void ListTeacherQ9(List<Teacher> listTeacher)
        {
            Console.WriteLine("---Danh sách giảng viên có địa chỉ chứa thông tin Quận 9");
            List<Teacher> listTeacherQ9 = (from s in listTeacher where s.DiaChi.Contains("Quận 9") select s).ToList();
            if (listTeacherQ9.Count == 0)
            {
                Console.WriteLine("Không có giảng viên nào ở Quận 9");
            }
            else
                XuatDSGV(listTeacherQ9);
        }

        //Tìm giảng viên có mã số CHN060286
        private static void ListTeacherMS(List<Teacher> listTeacher)
        {
            Console.WriteLine("Giảng viên có mã CHN060286:");
            List<Teacher> listTeacherMS = (from s in listTeacher where s.Id == "CHN060286" select s).ToList();
            if (listTeacherMS.Count == 0)
                Console.WriteLine("Không có giảng viên nào có mã là CHN060286");
            else
                XuatDSGV(listTeacherMS);
        }

        //Menu giảng viên
        private static void MenuGV(List<Teacher> listTeacher)
        {
            int chon;
            do
            {
                Console.Clear();
                Console.WriteLine("-------------------MENU SINH VIÊN-------------------");
                Console.WriteLine("1. Danh sách giảng viên có địa chỉ chứa thông tin Quận 9.");
                Console.WriteLine("2. Tìm giảng viên có mã là CHN060286.");
                Console.WriteLine("Chọn chức năng : ");
                chon = Convert.ToInt32(Console.ReadLine());
            } while (chon > 2 && chon <= 0);
            switch (chon)
            {
                case 1:
                    ListTeacherQ9(listTeacher);
                    break;
                case 2:
                    ListTeacherMS(listTeacher);
                    break;
                default:
                    Console.Write("Vui lòng nhập đúng.");
                    break;
            }
            int temp;
            do
            {
                Console.WriteLine("Bạn có muốn tiếp tục");
                Console.WriteLine("1. Có");
                Console.WriteLine("2. Thoát");
                temp = Convert.ToInt32(Console.ReadLine());
            } while (temp > 2 && temp < 0);
            switch (temp)
            {
                case 1:
                    MenuGV(listTeacher);
                    break;
                case 2:
                    return;
                default:
                    Console.WriteLine("Vui lòng nhập đúng");
                    break;
            }
        }

        //Xuất danh sách các sinh viên thuộc khoa CNTT
        private static void ListStudentCNTT(List<Student> listStudent)
        {
            Console.WriteLine("Danh sách sinh viên thuộc khoa CNTT");
            List<Student> listStudentCNTT = (from s in listStudent where s.Faculty == "CNTT" select s).ToList();
            if (listStudentCNTT.Count == 0)
            {
                Console.WriteLine("Không có sinh viên thuộc khoa CNTT");
            }
            else
                XuatDSSV(listStudentCNTT);
        }

        //Xuất danh sách sinh viên điểm TB<5 thuộc khoa CNTT
        private static void ListStudent5CNTT(List<Student> listStudent)
        {
            Console.WriteLine("Danh sách sinh viên có điểm TB < 5 và thuộc khoa CNTT");
            List<Student> listStudent5CNTT = (from s in listStudent where s.AverageScore < 5 && s.Faculty == "CNTT" select s).ToList();
            if (listStudent5CNTT.Count == 0)
                Console.WriteLine("Không có sinh viên CNTT nào có điểm TB < 5");
            else
                XuatDSSV(listStudent5CNTT);
        }

        //Xuất danh sách sinh viên điểm Tb cao nhất thuộc khoa CNTT
        private static void ListStudenMaxCNTT(List<Student> listStudent)
        {
            Console.WriteLine("Danh sách sinh viên có điểm TB cao nhất và thuộc khoa CNTT");
            List<Student> listStudentMax = listStudent.Where(p => p.Faculty == "CNTT").ToList();
            List<Student> itemList = new List<Student>();
            float Max = 0;
            foreach (var item in listStudentMax)
            {
                if (item.AverageScore > Max)
                {
                    Max = item.AverageScore;
                    itemList.Clear();
                    itemList.Add(item);
                }
            }
            if (listStudentMax.Count() == 0)
            {
                Console.WriteLine("Không có sinh viên điểm TB cao nhất và thuộc khoa CNTT");
            }
            else
                XuatDSSV(itemList);
        }

        //Meunu sinh viên
        private static void MenuSV(List<Student> listStudent)
        {
            int chon;
            do
            {
                Console.Clear();
                Console.WriteLine("-------------------MENU SINH VIÊN-------------------");
                Console.WriteLine("1. Danh sách sinh viên thuộc khoa CNTT.");
                Console.WriteLine("2. Danh sách sinh viên có điểm TB < 5  và thuộc khoa CNTT.");
                Console.WriteLine("3. Danh sách sinh viên điểm TB cao nhất và thuộc khoa CNTT.");
                Console.WriteLine("Chọn chức năng : ");
                chon = Convert.ToInt32(Console.ReadLine());
            } while (chon > 3 && chon <= 0);
            switch (chon)
                {
                    case 1:
                        ListStudentCNTT(listStudent);
                        break;
                    case 2:
                        ListStudent5CNTT(listStudent);
                        break;
                    case 3:
                        ListStudenMaxCNTT(listStudent);
                        break;
                    default:
                        Console.WriteLine("Vui lòng nhập đúng.");
                        break;
                }
            int temp;
            do
            {
                Console.WriteLine("Bạn có muốn tiếp tục");
                Console.WriteLine("1. Có");
                Console.WriteLine("2. Thoát");
                temp = Convert.ToInt32(Console.ReadLine());
            } while (temp>3 && temp <0);
            switch (temp)
            {
                case 1:
                    MenuSV(listStudent);
                    break;
                case 2:
                    return;
                default:
                    Console.WriteLine("Vui lòng nhập đúng");
                    break;
            }
        }

        //Chọn đối tượng cần nhập
        private static void ChoosePerson()
        {
            int ketQua; string soNg;
            bool isSuccess;
            do
            {
                Console.Write("Nhập số lượng thành viên: ");
                soNg = Console.ReadLine();
                isSuccess = int.TryParse(soNg, out ketQua);
            } while (!isSuccess);
            Console.WriteLine("Bạn muốn nhập thông tin giảng viên hay sinh viên: ");
            Console.WriteLine("1. Giảng viên");
            Console.WriteLine("2. Sinh viên");
            int temp = Convert.ToInt32(Console.ReadLine());
            switch (temp)
            {
                case 1:
                    listTeacher = NhapGV(ketQua);
                    break;
                case 2:
                    listStudent = NhapSV(ketQua);
                    break;
                default:
                    Console.WriteLine("Vui lòng nhập đúng.");
                    break;
            }
        }

        //Nhập danh sách sinh viên
        private static List<Student> NhapSV(int n)
        {
            List<Student> listStudents = new List<Student>();
            Console.WriteLine("\n-----Nhập thông tin sinh viên-----");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\n - Nhập sinh viên thứ {i+1}");
                Student temp = new Student();
                temp.Input();
                listStudents.Add(temp);
            }
            return listStudents;
        }

        //Xuất danh sách sinh viên
        private static void XuatDSSV(List<Student> listStudent)
        {
            Console.WriteLine("\n=======Xuất Danh sách Sinh viên=======");
            foreach (Student sv in listStudent)
            {
                sv.Show();
            }
        }

        //Nhập danh sách giảng viên
        private static List<Teacher> NhapGV(int n)
        {
            List<Teacher> listTeacher = new List<Teacher>();
            Console.WriteLine("\n-----Nhập thông tin giảng viên-----");
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine($"\n - Nhập giảng viên thứ {i + 1}");
                Teacher temp = new Teacher();
                temp.Input();
                listTeacher.Add(temp);
            }
            return listTeacher;
        }

        //Xuất danh sách giảng viên
        private static void XuatDSGV(List<Teacher> listTeacher)
        {
            Console.WriteLine("\n=======Xuất Danh sách Sinh viên=======");
            foreach (Teacher sv in listTeacher)
            {
                sv.Show();
            }
        }
    }
}
