using System;
using System.Collections.Generic;

namespace TopUpPulsaOOP
{
    public class Transaksi : Customer
    {
        public string Waktu { get; set; }
        public string Provider { get; set; }
        public int Nominal { get; set; }
        public int Harga { get; set; }
        public static List<Transaksi> TransaksiList { get; set; } = new List<Transaksi>();

        private static string[] provider = new string[] { "Indosat", "Telkomsel", "3", "XL/Axis", "Smartfren" };
        private static int[] nominal = new int[] { 5000, 10000, 25000, 50000, 100000, 150000, 200000 };


        public void InputProvider() {

            Console.Clear();
            Console.WriteLine("===================================");
            Console.WriteLine("       APLIKASI TOP UP PULSA       ");
            Console.WriteLine("===================================\n");
            for (int i = 0; i < provider.Length; i++)
            {
                int no = i + 1;
                Console.WriteLine($"{no}. {provider[i]}");
            }
            Console.WriteLine("===================================");
            Console.WriteLine("\nSilakan Pilih Provider : ");

            try
            {
                int option = int.Parse(Console.ReadLine());

                if (option <= provider.Length)
                {
                    Provider = provider[option - 1];
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error : " + e.Message);
            }
        }

        public int InputNominal()
        {
            Console.Clear();
            Console.WriteLine("===================================");
            Console.WriteLine("       APLIKASI TOP UP PULSA       ");
            Console.WriteLine("===================================\n");
            for (int i = 0; i < nominal.Length; i++)
            {
                int no = i + 1;
                Console.WriteLine($"{no}. {nominal[i]}");
            }
            Console.WriteLine("===================================");
            Console.WriteLine("\nSilakan Pilih Nominal : ");

            try
            {
                int option = int.Parse(Console.ReadLine());

                if (option <= nominal.Length)
                {
                    Nominal = nominal[option - 1];
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error : " + e.Message);
            }
            return Nominal;

        }

        public override void InputNoTelp()
        {
            try
            {
                Console.Clear();
                LihatCustomer();
                Console.WriteLine("Silakan masukkan nomor urutan data customer : ");
                int option = int.Parse(Console.ReadLine());
                NoTelp = CustomerList[option - 1].NoTelp;               
            }
            catch (Exception e)
            {
                Console.WriteLine("Error :" + e.Message);
            }
        }

        public int HitungHarga(int Nominal)
        {
            Harga = Nominal;
            try
            {
                if (Harga <= 25000)
                {
                    Harga += 2000;
                }
                else if (Harga > 25000 && Harga <= 100000)
                {
                   Harga += 1500;
                }
                else
                {
                    Harga += 1000;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error : " + e.Message);
            }
            return Harga;
        }

        public static void TambahTransaksi()
        {
            try
            {
                Transaksi transaksi = new Transaksi();
                transaksi.InputProvider();
                int temp = transaksi.InputNominal();
                transaksi.InputNoTelp();
                transaksi.HitungHarga(temp);
                transaksi.Waktu = DateTime.Now.ToString("G");
                TransaksiList.Add(transaksi);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error :" + e.Message);
            }
            Console.Clear();
            LihatTransaksi();
            Console.WriteLine("Tekan Enter untuk kembali ke Menu Utama..");
            Console.ReadKey();
        }

        public static void LihatTransaksi()
        {
            Console.WriteLine("===================================");
            Console.WriteLine("       APLIKASI TOP UP PULSA       ");
            Console.WriteLine("===================================\n");
            for (int i = 0; i < TransaksiList.Count; i++)
            {
                int no = i + 1;
                Console.WriteLine($"No. : {no}");
                Console.WriteLine($"Waktu : {TransaksiList[i].Waktu}");
                Console.WriteLine($"Provider : {TransaksiList[i].Provider}");
                Console.WriteLine($"Nominal : {TransaksiList[i].Nominal}");
                Console.WriteLine($"No. Telepon : {TransaksiList[i].NoTelp}");
                Console.WriteLine($"Harga : {TransaksiList[i].Harga}");
                Console.WriteLine("====================================\n");
            }
        }

        public static void UpdateProvider(int option)
        {
            for (int i = 0; i < provider.Length; i++)
            {
                int no = i + 1;
                Console.WriteLine($"{no}. {provider[i]}");
            }
            Console.WriteLine("\n===================================");
            Console.WriteLine("\nSilakan Pilih Provider : ");
            try
            {
                int option1 = int.Parse(Console.ReadLine());

                if (option1 <= provider.Length)
                {
                    TransaksiList[option - 1].Provider = provider[option1 - 1];
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error :" + e.Message);
            }
        }

        public static void UpdateNominal(int option)
        {
            for (int i = 0; i < nominal.Length; i++)
            {
                int no = i + 1;
                Console.WriteLine($"{no}. {nominal[i]}");
            }
            Console.WriteLine("\n===================================");
            Console.WriteLine("\nSilakan Pilih Nominal : ");

            try
            {
                int option2 = int.Parse(Console.ReadLine());

                if (option2 <= nominal.Length)
                {
                    TransaksiList[option - 1].Nominal = nominal[option2 - 1];
                }
            }
            catch (Exception e)
            {
                Console.WriteLine("Error :" + e.Message);
            }

        }

        public static void EditTransaksi()
        {
            try
            {
                Console.Clear();
                LihatTransaksi();
                
                Console.WriteLine("Silakan masukkan nomor urutan data yang akan diubah : ");
                int option = int.Parse(Console.ReadLine());

                Console.WriteLine("\n===================================\n");

                UpdateProvider(option);

                Console.WriteLine("\n===================================\n");

                UpdateNominal(option);

                Console.WriteLine("\n===================================\n");

                LihatCustomer();
                Console.WriteLine("Silakan masukkan nomor urutan data Customer : ");
                int option3 = int.Parse(Console.ReadLine());
                TransaksiList[option - 1].NoTelp = CustomerList[option3 - 1].NoTelp;

                TransaksiList[option - 1].Harga = TransaksiList[option - 1].HitungHarga(TransaksiList[option - 1].Nominal);
                TransaksiList[option - 1].Waktu = DateTime.Now.ToString("G");
            }
            catch (Exception e)
            {
                Console.WriteLine("Error :" + e.Message);
            }

            Console.Clear();
            LihatTransaksi();
            Console.WriteLine("Tekan Enter untuk kembali ke Menu Utama..");
            Console.ReadKey();
        }

        public static void HapusTransaksi()
        {
            Console.Clear();
            LihatTransaksi();
            Console.WriteLine("Silakan masukan nomor urutan data yang akan dihapus : ");
            try
            {
                int option = int.Parse(Console.ReadLine());
                TransaksiList.RemoveAt(option - 1);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error :" + e.Message);
            }

            Console.Clear();
            LihatTransaksi();
            Console.WriteLine("Tekan Enter untuk kembali ke Menu Utama..");
            Console.ReadKey();
        }

    }
}
