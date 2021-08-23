using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab01_3_4
{
    class Program
    {
        static List<KhuDat> listKhuDat = new List<KhuDat>();
        static List<ChungCu> listChungCu = new List<ChungCu>();
        static List<NhaPho> listNhaPho = new List<NhaPho>();
        //Hàm main
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            Menu();
        }

        private static void Menu()
        {
            int chon;
            do
            {
                Console.Clear();
                Console.WriteLine("------------MENU------------");
                Console.WriteLine("1. Nhập danh sách khu đất.");
                Console.WriteLine("2. Nhập danh sách chung cư.");
                Console.WriteLine("3. Nhập danh sách nhà phố.");
                Console.WriteLine("4. Xuất danh sách khu đất.");
                Console.WriteLine("5. Xuất danh sách chung cư.");
                Console.WriteLine("6. Xuất danh sách nhà phố.");
                Console.WriteLine("7. Xuất danh sách khu đất tăng dần theo diện tích.");
                Console.WriteLine("8. Xuất danh sách khu đất dưới 1 tỷ có diện tích >= 60m2.");
                Console.WriteLine("9. Tính đơn giá/1m2 của tất cả khu đất >1000m2.");
                Console.WriteLine("10.Tổng giá bán của 3 loại.");
                Console.WriteLine("11.Xuất danh sách khu đất >100m2 hoặc nhà phố >60m2 và năm xây dựng >=2020.");
                Console.WriteLine("12.Tìm kiếm thông tin chung cư, nhà phố.");
                Console.Write("Chọn chức năng: ");
                chon = Convert.ToInt32(Console.ReadLine());
            } while (chon > 12 && chon < 0);

            switch (chon)
            {
                case 1:
                    NhapDSKD(listKhuDat);
                    break;
                case 2:

                    NhapDSCC(listChungCu);
                    break;
                case 3:
                    NhapDSNP(listNhaPho);
                    break;
                case 4:
                    Console.WriteLine("\n=======Xuất Danh sách Khu đất=======");
                    XuatDSKD(listKhuDat);
                    break;
                case 5:
                    Console.WriteLine("\n=======Xuất Danh sách Chung cư=======");
                    XuatDSCC(listChungCu);
                    break;
                case 6:
                    Console.WriteLine("\n=======Xuất Danh sách Nhà phố=======");
                    XuatDSNP(listNhaPho);
                    break;
                case 7:
                    ListKDSort(listKhuDat);
                    break;
                case 8:
                    ListKD1B60m2(listKhuDat);
                    break;
                case 9:
                    DonGia1m2(listKhuDat);
                    break;
                case 10:
                    TongGiaBan(listKhuDat, listChungCu, listNhaPho);
                    break;
                case 11:
                    int tam;
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("1. Xuất danh sách khu đất >100m2.");
                        Console.WriteLine("2. Xuất danh sách nhà phố >60m2 và năm xây dựng >=2020");
                        Console.WriteLine("0. Thoát ra menu.");
                        Console.Write("Lựa chọn của bạn: ");
                        tam = Convert.ToInt32(Console.ReadLine());
                    } while (tam > 2 && tam < 0);
                    switch (tam)
                    {
                        case 1:
                            List4_4_1(listKhuDat);
                            break;
                        case 2:
                            List4_4_2(listNhaPho);
                            break;
                        default:
                            tam = 0;
                            break;
                    }
                    break;
                case 12:
                    int tam2;
                    do
                    {
                        Console.Clear();
                        Console.WriteLine("1. Tìm kiếm thông tin chung cư.");
                        Console.WriteLine("2. Tìm kiếm thông tin nhà phố");
                        Console.WriteLine("0. Thoát ra menu.");
                        Console.Write("Lựa chọn của bạn: ");
                        tam2 = Convert.ToInt32(Console.ReadLine());
                    } while (tam2 > 2 && tam2 < 0);
                    switch (tam2)
                    {
                        case 1:
                            SearchCC(listChungCu);
                            break;
                        case 2:
                            SearchNP(listNhaPho);
                            break;
                        default:
                            tam2 = 0;
                            break;
                    }
                    break;
                default:
                    Console.WriteLine("Vui lòng nhập đúng");
                    break;
            }

            int temp;
            do
            {
                Console.WriteLine("---------------------------");
                Console.WriteLine("Bạn có muốn tiếp tục không?");
                Console.WriteLine("1. Tiếp tục menu.");
                Console.WriteLine("2. Thoát.");
                Console.Write("Mời chọn chức năng: ");
                temp = Convert.ToInt32(Console.ReadLine());
            } while (temp > 2 || temp <= 0);
            switch (temp)
            {
                case 1:
                    Menu();
                    break;
                case 2:
                    Console.WriteLine("Press any key to turn off...");
                    Console.ReadKey();
                    return;
                default:
                    Console.WriteLine("Vui lòng nhập đúng");
                    break;
            }
        }

        //Nhập danh sách khu đất
        private static List<KhuDat> NhapDSKD(List<KhuDat> listKhuDats)
        {
            Console.Write("Nhập so khu dat N= ");
            int N = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n=======Nhập Danh sách Khu đất=======");
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine($"\n - Nhập khu đất {i + 1}");
                KhuDat temp = new KhuDat();
                temp.Input();
                listKhuDats.Add(temp);
            }
            return listKhuDats;
        }

        //Xuất danh sách tất cả khu đất
        private static void XuatDSKD(List<KhuDat> listKhuDat)
        {
            foreach (KhuDat kd in listKhuDat)
            {
                kd.Output();
                Console.Write("\n");
            }
        }

        //Nhập danh sách chung cư
        private static List<ChungCu> NhapDSCC(List<ChungCu> listChungcus)
        {
            Console.Write("Nhập so chung cu N= ");
            int N = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n=======Nhập Danh sách Chung cư=======");
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine($"\n - Nhập chung cư {i + 1}");
                ChungCu temp = new ChungCu();
                temp.Input();
                listChungcus.Add(temp);
            }
            return listChungcus;
        }

        //Xuất danh sách tất cả các chung cư
        private static void XuatDSCC(List<ChungCu> listChungCu)
        {
            foreach (ChungCu cc in listChungCu)
            {
                cc.Output();
                Console.Write("\n");
            }
        }

        //Nhập danh sách nhà phố
        private static List<NhaPho> NhapDSNP(List<NhaPho> listNhaPhos)
        {
            Console.Write("Nhập số nhà phố N= ");
            int N = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\n=======Nhập Danh sách Nhà phố=======");
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine($"\n - Nhập nhà thứ {i + 1}");
                NhaPho temp = new NhaPho();
                temp.Input();
                listNhaPhos.Add(temp);
            }
            return listNhaPhos;
        }

        //Xuất danh sách tất cả các nhà phố
        private static void XuatDSNP(List<NhaPho> listNhaPho)
        {
            foreach (NhaPho np in listNhaPho)
            {
                np.Output();
            }
        }

        //Xuất danh sách các khu đất dưới 1 tỷ và có diện tích >= 60m2
        private static void ListKD1B60m2(List<KhuDat> listKhuDat)
        {
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Danh sách khu đất dưới 1 tỷ có diện tích >= 60m2");
            List<KhuDat> listKD1B60m2 = (from s in listKhuDat where s.GiaBan < 1000000000 && s.DienTich >= 60 select s).ToList();
            if (listKD1B60m2.Count == 0)
                Console.WriteLine("Không có khu đất dưới 1 tỷ và diện tích >= 60m2");
            else
                XuatDSKD(listKD1B60m2);
        }

        //Xuất danh sách khu đất tăng dần theo diện tích
        private static void ListKDSort(List<KhuDat> listKhuDat)
        {
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Danh sách khu đất tăng dần theo diện tích");
            List<KhuDat> listKDSort = (from s in listKhuDat orderby s.DienTich select s).ToList();
            if (listKDSort.Count == 0)
                Console.WriteLine("Chưa có khu đất nào");
            else
                XuatDSKD(listKDSort);
        }

        //Tính đơn giá trên 1m2 của tất cả khu đất có diện tích lớn hơn 1000m2
        private static void DonGia1m2(List<KhuDat> listKhuDat)
        {
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine("Đơn giá 1m2 của các khu đất diện tích hơn 1000m2");
            List<KhuDat> listKD1000m2 = (from s in listKhuDat where s.DienTich > 1000 select s).ToList();
            if (listKD1000m2.Count == 0)
                Console.WriteLine("Không có khu đất nào có diện tích hơn 1000m2");
            else
            {
                foreach (var item in listKD1000m2)
                {
                    Console.WriteLine($"Địa điểm: {item.DiaDiem}, Diện tích: {item.DienTich}, Đơn giá(/m2): {item.GiaBan / item.DienTich}");
                }
            }
        }

        //Tính tổng giá bán của 3 loại 
        private static void TongGiaBan(List<KhuDat> khuDats, List<ChungCu> chungCus, List<NhaPho> nhaPhos)
        {
            double sumKD = 0, sumCC = 0, sumNP = 0;
            foreach (var item in khuDats)
                sumKD += item.GiaBan;

            foreach (var item in chungCus)
                sumCC += item.GiaBan;

            foreach (var item in nhaPhos)
                sumNP += item.GiaBan;
            Console.WriteLine("----------------------------------------------");
            Console.WriteLine($"Tổng giá bán của khu đất: {sumKD}");
            Console.WriteLine($"Tổng giá bán của chung cư: {sumCC}");
            Console.WriteLine($"Tổng giá bán của nhà phố: {sumNP}");
        }

        //Xuất danh sách khu đất có diện tích > 100m2
        private static void List4_4_1(List<KhuDat> khuDats)
        {
            Console.WriteLine("---- Danh sách khu đất trên 100m2 ----");
            List<KhuDat> listKD100m2 = (from s in khuDats where s.DienTich > 100 select s).ToList();
            if (listKD100m2.Count == 0)
                Console.WriteLine("Không có khu đất nào > 100m2");
            else
                XuatDSKD(listKD100m2);
        }

        //Xuất danh sách nhà phố có diện tích > 60m2 và năm xây dựng >=2020
        private static void List4_4_2(List<NhaPho> nhaPhos)
        {
            Console.WriteLine("---- Danh sách nhà phố >60m2 và năm xây dựng >=2020 ----");
            List<NhaPho> listNP60m2 = (from s in nhaPhos where s.DienTich > 60 && s.NamXD >= 2020 select s).ToList();
            if (listNP60m2.Count == 0)
                Console.WriteLine("Không có nhà phố nào");
            else
                XuatDSNP(listNP60m2);
        }

        //Tìm kiếm thông tin chung cư
        private static void SearchCC(List<ChungCu> chungCus)
        {
            string dd;
            double gia;
            float dt;
            Console.WriteLine("Nhập các thông tin cần tìm kiếm: ");
            Console.Write("\t-Địa điểm: ");
            dd = Console.ReadLine();
            Console.Write("\t-Giá bán: ");
            gia = double.Parse(Console.ReadLine());
            Console.Write("\t-Diện tích: ");
            dt = float.Parse(Console.ReadLine());
            Console.WriteLine("------- Kết quả tìm kiếm -------");
            List<ChungCu> listSearchCC = (from s in chungCus where s.GiaBan <= gia && s.DienTich >= dt && s.DiaDiem.ToLower().Contains(dd.ToLower()) select s).ToList();
            if (listSearchCC.Count == 0)
                Console.WriteLine("Không tìm thấy!");
            else
                XuatDSCC(listSearchCC);
        }

        //Tìm kiếm thông tin nhà phố
        private static void SearchNP(List<NhaPho> nhaPhos)
        {
            string dd;
            double gia;
            float dt;
            Console.WriteLine("Nhập các thông tin cần tìm kiếm: ");
            Console.Write("\t-Địa điểm: ");
            dd = Console.ReadLine();
            Console.Write("\t-Giá bán: ");
            gia = double.Parse(Console.ReadLine());
            Console.Write("\t-Diện tích: ");
            dt = float.Parse(Console.ReadLine());
            Console.WriteLine("------- Kết quả tìm kiếm -------");
            List<NhaPho> listSearchNP = (from s in nhaPhos where s.GiaBan <= gia && s.DienTich >= dt && s.DiaDiem.ToLower().Contains(dd.ToLower()) select s).ToList();
            if (listSearchNP.Count == 0)
                Console.WriteLine("Không tìm thấy!");
            else
                XuatDSNP(listSearchNP);
        }
    }
}
