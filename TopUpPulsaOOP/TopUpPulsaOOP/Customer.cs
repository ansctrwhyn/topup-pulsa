using System;
using System.Collections.Generic;

namespace TopUpPulsaOOP
{
    public class Customer
    {
        public string Nik { get; set; }
        public string Nama { get; set; }
        public string NoTelp { get; set; }

        public static List<Customer> CustomerList { get; set; } = new List<Customer>();

        public void InputNik()
        {
            Console.Clear();
            Console.WriteLine("===================================");
            Console.WriteLine("       APLIKASI TOP UP PULSA       ");
            Console.WriteLine("===================================");
            Console.WriteLine("\nSilakan Masukan NIK : ");
            try
            {
                Nik = Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error :" + e.Message);
            }
        }

        public void InputNama()
        {
            Console.Clear();
            Console.WriteLine("===================================");
            Console.WriteLine("       APLIKASI TOP UP PULSA       ");
            Console.WriteLine("===================================");
            Console.WriteLine("\nSilakan Masukkan Nama : ");
            try
            { 
                Nama = Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error :" + e.Message);
            }
        }

        public virtual void InputNoTelp()
        {
            Console.Clear();
            Console.WriteLine("===================================");
            Console.WriteLine("       APLIKASI TOP UP PULSA       ");
            Console.WriteLine("===================================");
            Console.WriteLine("\nSilakan Masukkan Nomor Telepon: ");
            try
            {
                NoTelp = Console.ReadLine();
            }
            catch (Exception e)
            {
                Console.WriteLine("Error :" + e.Message);
            }
        }

        public static void TambahCustomer()
        {
            try
            {
                Customer customer = new Customer();
                customer.InputNik();
                customer.InputNama();
                customer.InputNoTelp();
                CustomerList.Add(customer);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error :" + e.Message);
            }
            Console.Clear();
            LihatCustomer();
            Console.WriteLine("Tekan Enter untuk kembali ke Menu Utama..");
            Console.ReadKey();
        }

        public static void LihatCustomer()
        {
            Console.WriteLine("===================================");
            Console.WriteLine("       APLIKASI TOP UP PULSA       ");
            Console.WriteLine("===================================\n");
            for (int i = 0; i < CustomerList.Count; i++)
            {
                int no = i + 1;
                Console.WriteLine($"No. : {no}");
                Console.WriteLine($"NIK : {CustomerList[i].Nik}");
                Console.WriteLine($"Nama : {CustomerList[i].Nama}");
                Console.WriteLine($"No. Telepon : {CustomerList[i].NoTelp}");
                Console.WriteLine("====================================\n");
            }
        }

        public static void EditCustomer()
        {
            try
            {
                Console.Clear();
                LihatCustomer();
                Console.WriteLine("Silakan masukkan nomor urutan data yang akan diubah : ");
                int option = int.Parse(Console.ReadLine());

                Console.WriteLine("\nSilakan masukkan NIK : ");
                CustomerList[option - 1].Nik = Console.ReadLine();
                Console.WriteLine("\nSilakan masukkan Nama : ");
                CustomerList[option - 1].Nama = Console.ReadLine();
                Console.WriteLine("\nSilakan masukkan Nomor Telepon : ");
                CustomerList[option - 1].NoTelp = Console.ReadLine();
            }
            catch(Exception e)
            {
                Console.WriteLine("Error :" + e.Message);
            }

            Console.Clear();
            LihatCustomer();
            Console.WriteLine("Tekan Enter untuk kembali ke Menu Utama..");
            Console.ReadKey();
        }

        public static void HapusCustomer()
        {
            Console.Clear();
            LihatCustomer();
            Console.WriteLine("Silakan masukkan nomor urutan data yang akan dihapus : ");
            try
            {
                int option = int.Parse(Console.ReadLine());
                CustomerList.RemoveAt(option - 1);
            }
            catch (Exception e)
            {
                Console.WriteLine("Error :" + e.Message);
            }

            Console.Clear();
            LihatCustomer();
            Console.WriteLine("Tekan Enter untuk kembali ke Menu Utama..");
            Console.ReadKey();
        }


    }
}
