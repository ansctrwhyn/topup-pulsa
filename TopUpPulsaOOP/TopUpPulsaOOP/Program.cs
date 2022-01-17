using System;
using System.Collections.Generic;

namespace TopUpPulsaOOP
{
    public class Program
    {

        static void Main(string[] args)
        {
            MainMenu();
        }

        public static void MainMenu()
        {
            Console.Clear();
            Console.WriteLine("===================================");
            Console.WriteLine("       APLIKASI TOP UP PULSA       ");
            Console.WriteLine("===================================\n");
            Console.WriteLine("1. Menu Customer");
            Console.WriteLine("2. Menu Transaksi");
            Console.WriteLine("0. Keluar");
            Console.WriteLine("===================================");
            Console.WriteLine("\nSilakan Pilih Menu : ");

            string option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    MenuCustomer();
                    break;
                case "2":
                    MenuTransaksi();
                    break;
                case "0":
                    Exit();
                    break;
                default:
                    MainMenu();
                    break;

            }
        }

        public static void MenuCustomer()
        {
            Console.Clear();
            Console.WriteLine("===================================");
            Console.WriteLine("       APLIKASI TOP UP PULSA       ");
            Console.WriteLine("===================================\n");
            Console.WriteLine("1. Tambah Customer");
            Console.WriteLine("2. Lihat Daftar Customer");
            Console.WriteLine("3. Edit Customer");
            Console.WriteLine("4. Hapus Customer");
            Console.WriteLine("0. Keluar");
            Console.WriteLine("===================================");
            Console.WriteLine("\nSilakan Pilih Menu : ");

            string option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    Customer.TambahCustomer();
                    MainMenu();
                    break;
                case "2":
                    Console.Clear();
                    Customer.LihatCustomer();
                    Console.WriteLine("Tekan Enter untuk kembali ke Menu Utama..");
                    Console.ReadKey();
                    MainMenu();
                    break;
                case "3":
                    Customer.EditCustomer();
                    MainMenu();
                    break;
                case "4":
                    Customer.HapusCustomer();
                    MainMenu();
                    break;
                case "0":
                    Exit();
                    break;
                default:
                    MainMenu();
                    break;

            }
        }

        public static void MenuTransaksi()
        {
            Console.Clear();
            Console.WriteLine("===================================");
            Console.WriteLine("       APLIKASI TOP UP PULSA       ");
            Console.WriteLine("===================================\n");
            Console.WriteLine("1. Tambah Transaksi");
            Console.WriteLine("2. Lihat Daftar Transaksi");
            Console.WriteLine("3. Edit Transaksi");
            Console.WriteLine("4. Hapus Transaksi");
            Console.WriteLine("0. Keluar");
            Console.WriteLine("===================================");
            Console.WriteLine("\nSilakan Pilih Menu : ");

            string option = Console.ReadLine();
            switch (option)
            {
                case "1":
                    Transaksi.TambahTransaksi();
                    MainMenu();
                    break;
                case "2":
                    Console.Clear();
                    Transaksi.LihatTransaksi();
                    Console.WriteLine("Tekan Enter untuk kembali ke Menu Utama..");
                    Console.ReadKey();
                    MainMenu();
                    break;
                case "3":
                    Transaksi.EditTransaksi();
                    MainMenu();
                    break;
                case "4":
                    Transaksi.HapusTransaksi();
                    MainMenu();
                    break;
                case "0":
                    Exit();
                    break;
                default:
                    MainMenu();
                    break;

            }
        }

        public static void Exit()
        {
            Console.WriteLine("\nApakah Anda yakin akan keluar? y/n");

            string option = Console.ReadLine();
            switch (option)
            {
                case "y":
                    System.Environment.Exit(1);
                    break;
                case "n":
                    MainMenu();
                    break;
                default:
                    MainMenu();
                    break;
            }
        }

    }
}
