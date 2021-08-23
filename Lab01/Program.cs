using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01
{
    class Program
    {
        private static List<Student> NhapDSSV()
        {
            List<Student> listStudents = new List<Student>();
            Console.Write("Nhập tổng số sinh viên N= ");
            int N = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n=======Nhập Danh sách Sinh viên=======");
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("\n - Nhập sinh viên thứ {0}", i + 1);
                Student temp = new Student();
                temp.Input();
                listStudents.Add(temp);
            }
            return listStudents;
        }

        private static void XuatDSSV(List<Student> listStudent)
        {
            Console.WriteLine("\n=======Xuất Danh sách Sinh viên=======");
            foreach (Student sv in listStudent)
            {
                sv.Show();
            }
        }

        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;

            List<Student> listStudent = NhapDSSV();
            XuatDSSV(listStudent);

            int chon;
            do
            {
                Console.WriteLine("====================MENU====================");
                Console.WriteLine("1. Xuất ra thông tin các SV đều thuộc khoa CNTT (nếu có)");
                Console.WriteLine("2. Xuất ra thông tin các sinh viên có điểm TB >=5");
                Console.WriteLine("3. Xuất ra danh sách các sinh viên được sắp xếp theo điểm trung bình tăng dần");
                Console.WriteLine("4. Xuất ra danh sách sinh viên có điểm TB lớn hơn bằng 5 và thuộc khoa “CNTT” (nếu có)");
                Console.WriteLine("5. Xuất ra danh sách sinh viên có điểm trung bình cao nhất và thuộc khoa “CNTT” (nếu có)");
                Console.WriteLine("0. Thoát.");
                Console.Write("Mời bạn lựa chọn chức năng: ");
                chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        Console.WriteLine("Danh sách sinh viên thuộc khoa CNTT");
                        List<Student> listStudentCNTT = listStudent.Where(p => p.Faculty == "CNTT").ToList();
                        if (listStudentCNTT.Count() == 0)
                        {
                            Console.WriteLine("Không có sinh viên thuộc khoa CNTT");
                        }
                        else
                            XuatDSSV(listStudentCNTT);
                        break;
                    case 2:
                        Console.WriteLine("Danh sách sinh viên có điểm TB >=5");
                        List<Student> listStudentResult = listStudent.Where(p => p.AverageScore >= 5).ToList();
                        if (listStudentResult.Count() == 0)
                        {
                            Console.WriteLine("Không có sinh viên điểm TB >=5");
                        }
                        else
                            XuatDSSV(listStudentResult);
                        break;
                    case 3:
                        Console.WriteLine("Danh sách sinh viên có điểm tăng dần");
                        List<Student> listStudentSort = listStudent.OrderBy(p => p.AverageScore).ToList();
                        XuatDSSV(listStudentSort);
                        break;
                    case 4:
                        Console.WriteLine("Danh sách sinh viên có điểm TB >= 5 và thuộc khoa CNTT");
                        List<Student> listStudentSC = listStudent.Where(p => p.AverageScore >= 5 && p.Faculty == "CNTT").ToList();
                        if (listStudentSC.Count() == 0)
                        {
                            Console.WriteLine("Không có sinh viên điểm TB >=5 và thuộc khoa CNTT");
                        }
                        else
                            XuatDSSV(listStudentSC);
                        break;
                    case 5:
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
                        break;
                    default:
                        chon = 0;
                        break;
                }
            } while (chon != 0);
        }
    }
}
