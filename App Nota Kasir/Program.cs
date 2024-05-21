using System;
using System.IO;
using System.Text;

namespace Nota_Kasir
{
    public class Program
    {
        //deklarasi variable
        string kasir, pelanggan;
        int totalHarga, tunai, kembalian;
        //deklarasi array satu dimensi dan menyimpan data dalam array
        string[] menu = { "Rice Bowl", "Steak Ayam", "Pancakes", "Kentang Goreng", "Cappucino", "Americano", "Caramel Latte", "Thai Tea" };
        int[] jumlahpesanan = { 0, 0, 0, 0, 0, 0, 0, 0 };
        int[] hargaMenu = { 15000, 20000, 12000, 10000, 9000, 11000, 12000, 10000 };
        //deklarasi variable dengan tipe data int
        int jmlMenu1, hargaMenu1;
        int jmlMenu2, hargaMenu2;
        int jmlMenu3, hargaMenu3;
        int jmlMenu4, hargaMenu4;
        int jmlMenu5, hargaMenu5;
        int jmlMenu6, hargaMenu6;
        int jmlMenu7, hargaMenu7;
        int jmlMenu8, hargaMenu8;

        public void Input()
        {
            Console.WriteLine("===================================");
            Console.WriteLine("  Selamat Datang Di Cafe Saturnus  ");
            Console.WriteLine("===================================\n");
            //display masukkan nama kasir
            Console.Write("Masukkan Nama Kasir: ");
            //membaca input dari user dan disimpan dalam variable kasir
            kasir = Console.ReadLine();
            //display masukkan nama pelanggan
            Console.Write("Masukkan Nama Pelanggan: ");
            //membaca input dari user dan disimpan dalam variable pelanggan
            pelanggan = Console.ReadLine();
            Console.WriteLine("");
        }

        public void RiceBowl()
        {
            //display jumlah pesanan
            Console.Write("Jumlah Rice Bowl: ");
            jmlMenu1 = Convert.ToInt32(Console.ReadLine());

            //compute hargaMenu1
            hargaMenu1 = jmlMenu1 * hargaMenu[0];
            Console.WriteLine("Pesanan berhasil ditambahkan!");

            //update harga total array setiap menu dengan index 0
            jumlahpesanan[0] += hargaMenu1;
        }
        public void Steak()
        {
            //display jumlah pesanan
            Console.Write("Jumlah Steak Ayam: ");
            jmlMenu2 = Convert.ToInt32(Console.ReadLine());

            //compute hargaMenu2
            hargaMenu2 = jmlMenu2 * hargaMenu[1];
            Console.WriteLine("Pesanan berhasil ditambahkan!");

            //update harga total array setiap menu dengan index 0
            jumlahpesanan[1] += hargaMenu2;
        }
        public void Pancakes()
        {
            //display jumlah pesanan
            Console.Write("Jumlah Pancakes: ");
            jmlMenu3 = Convert.ToInt32(Console.ReadLine());

            //compute hargaMenu3
            hargaMenu3 = jmlMenu3 * hargaMenu[2];
            Console.WriteLine("Pesanan berhasil ditambahkan!");

            //update harga total array setiap menu dengan index 0
            jumlahpesanan[2] += hargaMenu3;
        }
        public void Kentang()
        {
            //display jumlah pesanan
            Console.Write("Jumlah Kentang Goreng: ");
            jmlMenu4 = Convert.ToInt32(Console.ReadLine());

            //compute hargaMenu4
            hargaMenu4 = jmlMenu4 * hargaMenu[3];
            Console.WriteLine("Pesanan berhasil ditambahkan!");

            //update harga total array setiap menu dengan index 0
            jumlahpesanan[3] += hargaMenu4;
        }
        public void Cappucino()
        {
            //display jumlah pesanan
            Console.Write("Jumlah Cappucino: ");
            jmlMenu5 = Convert.ToInt32(Console.ReadLine());

            //compute hargaMenu5
            hargaMenu5 = jmlMenu5 * hargaMenu[4];
            Console.WriteLine("Pesanan berhasil ditambahkan!");

            //update harga total array setiap menu dengan index 0
            jumlahpesanan[4] += hargaMenu5;
        }
        public void Americano()
        {
            //display jumlah pesanan
            Console.Write("Jumlah Americano: ");
            jmlMenu6 = Convert.ToInt32(Console.ReadLine());

            //compute hargaMenu6
            hargaMenu6 = jmlMenu6 * hargaMenu[5];
            Console.WriteLine("Pesanan berhasil ditambahkan!");

            //update harga total array setiap menu dengan index 0
            jumlahpesanan[5] += hargaMenu6;
        }
        public void CaramelLatte()
        {
            //display jumlah pesanan
            Console.Write("Jumlah CaramelLatte: ");
            jmlMenu7 = Convert.ToInt32(Console.ReadLine());

            //compute hargaMenu7
            hargaMenu7 = jmlMenu7 * hargaMenu[6];
            Console.WriteLine("Pesanan berhasil ditambahkan!");

            //update harga total array setiap menu dengan index 0
            jumlahpesanan[6] += hargaMenu7;
        }
        public void ThaiTea()
        {
            //display jumlah pesanan
            Console.Write("Jumlah Thai Tea: ");
            jmlMenu8 = Convert.ToInt32(Console.ReadLine());

            //compute hargaMenu8
            hargaMenu8 = jmlMenu8 * hargaMenu[7];
            Console.WriteLine("Pesanan berhasil ditambahkan!");

            //update harga total array setiap menu dengan index 0
            jumlahpesanan[7] += hargaMenu8;
        }
        public void Pembayaran()
        {
            Console.WriteLine("Receipt");
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Menu\t\tJumlah\t\tTotal Harga");
            Console.WriteLine("===========================================");
            //membaca array dengan perulangan for
            for (int i = 0; i < 8; i++)
            {
                if (jumlahpesanan[i] > 0)
                {
                    int jmlBeli = jumlahpesanan[i] / hargaMenu[i];
                    Console.WriteLine(menu[i] + "\tx" + jmlBeli + "\t\tRp. " + jumlahpesanan[i].ToString());

                    //update harga total
                    totalHarga += jumlahpesanan[i];
                }
            }
            Console.WriteLine("-------------------------------------------");
            Console.WriteLine("Total Harga\t\t\tRp. " + totalHarga);
            Console.Write("Tunai\t\t\t\tRp. ");
            tunai = Convert.ToInt32(Console.ReadLine());
            kembalian = tunai - totalHarga;
            Console.WriteLine("Kembalian\t\t\tRp. {0}", kembalian);
            Console.WriteLine();
            Console.WriteLine("\tTransaksi Berhasil!");
            Console.WriteLine();
        }
        public void Nota()
        {
            //deklarasikan variable untuk memberi nama file
            string namaFile;

            try
            {
                //menuliskan nama file
                Console.Write("Nama File : ");
                namaFile = Convert.ToString(Console.ReadLine());

                //Lewatkan folder dan nama file yang digunakan untuk menyimpan data
                StreamWriter sw = new StreamWriter("D:\\UMY\\TI Sem 2\\Pengembangan Aplikasi Windows\\Nota Kasir\\" + namaFile + ".txt");
                //membuat tampilan nota
                sw.WriteLine("                 Nota Pembayaran                ");
                sw.WriteLine("                  Cafe Saturnus                 ");
                sw.WriteLine("        Jl. Nasional 03, Jawa, Indonesia        ");
                sw.WriteLine("================================================");
                sw.WriteLine("");
                sw.WriteLine("Kasir    : {0}", kasir);
                sw.WriteLine("Pelangan : {0}", pelanggan);
                sw.WriteLine("" + DateTime.Now.ToString("yyyy-mm-dd") + "\t\t\t\t\t" + DateTime.Now.ToString("  HH:mm:ss"));
                sw.WriteLine("------------------------------------------------");
                sw.WriteLine("Menu\t\t\tJumlah\t\tTotal Harga");
                sw.WriteLine("================================================");
                for (int i = 0; i < 8; i++)
                {
                    if (jumlahpesanan[i] > 0)
                    {
                        int jmlBeli = jumlahpesanan[i] / hargaMenu[i];
                        sw.WriteLine(menu[i] + "\t\tx" + jmlBeli + "\t\t\t Rp. " + jumlahpesanan[i].ToString());
                    }
                }
                sw.WriteLine("------------------------------------------------");
                sw.WriteLine("\t\t\t\tTotal Harga\t Rp. {0}", totalHarga);
                sw.WriteLine("\t\t\t\tTunai\t\t Rp. {0}", tunai);
                sw.WriteLine("\t\t\t\tKembalian\t Rp. {0}", kembalian);
                sw.WriteLine();
                sw.WriteLine("================================================");
                sw.WriteLine("                Terima Kasih");
                sw.WriteLine("          Silahkan Datang Kembali");
                sw.WriteLine("================================================");
                //Tutup filenya
                sw.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception : " + e.Message);
            }
            finally
            {
                Console.WriteLine("Executing finally block.");
            }
        }

        static void Main(string[] args)
        {
            //membuat objek baru dari class program
            Program pr = new Program();
            //memanggil method Input() dari class Program
            pr.Input();

            //deklarasi variable "pilih" dengan tipe data int
            int pilih;
            do
            {
                //membuat tampilan menu
                Console.WriteLine("===================================");
                Console.WriteLine("  Selamat Datang Di Cafe Saturnus  ");
                Console.WriteLine("===================================");
                Console.WriteLine("");
                Console.WriteLine("           Menu Pilihan");
                Console.WriteLine("-----------------------------------");
                Console.WriteLine("1. Rice Bowl             Rp. 15.000");
                Console.WriteLine("2. Steak Ayam            Rp. 20.000");
                Console.WriteLine("3. Pancakes              Rp. 12.000");
                Console.WriteLine("4. Kentang Goreng        Rp. 10.000");
                Console.WriteLine("5. Cappucino             Rp.  9.000");
                Console.WriteLine("6. Americano             Rp. 11.000");
                Console.WriteLine("7. Caramel Latte         Rp. 12.000");
                Console.WriteLine("8. Thai Tea              Rp. 10.000");
                Console.WriteLine("9. Selesai");
                Console.WriteLine("");
                Console.Write("Silahkan Pilih Menu: ");
                //memberikan value untuk variable "pilih" dari input user
                pilih = Convert.ToInt32(Console.ReadLine());
                switch (pilih)
                {
                    case 1:
                        pr.RiceBowl();
                        Console.WriteLine();
                        break;
                    case 2:
                        pr.Steak();
                        Console.WriteLine();
                        break;
                    case 3:
                        pr.Pancakes();
                        Console.WriteLine();
                        break;
                    case 4:
                        pr.Kentang();
                        Console.WriteLine();
                        break;
                    case 5:
                        pr.Cappucino();
                        Console.WriteLine();
                        break;
                    case 6:
                        pr.Americano();
                        Console.WriteLine();
                        break;
                    case 7:
                        pr.CaramelLatte();
                        Console.WriteLine();
                        break;
                    case 8:
                        pr.ThaiTea();
                        Console.WriteLine();
                        break;
                    case 9:
                        Console.Clear();
                        pr.Pembayaran();
                        break;
                }
            }
            while (pilih < 9);
            {
                pr.Nota();
            }
        }
    }
}
