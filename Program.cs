using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ProjectMahasiswa
{
    class Program
    {
        
        Mahasiswa Mahasiswa = new Mahasiswa();
        static List<Mahasiswa> daftarMahasiswa = new List<Mahasiswa>();

        static void Main(string[] args)
        {
            Console.Title = "RESPONSI UAS MATAKULIAH PEMROGRAMAN 21.11.4419";


            while (true)
            {
                TampilMenu();

                Console.Write("\nNomor Menu [1..3]: ");
                int nomorMenu = Convert.ToInt32(Console.ReadLine());

                switch (nomorMenu)
                {
                    case 1:
                        TambahMahasiswa();
                        break;

                    case 2:
                        TampilMahasiswa();
                        break;

                    case 3: // keluar dari program
                        return;

                    default:
                        break;
                }
            }
        }

        static void TampilMenu()
        {
            
            Console.Clear();

            Console.WriteLine("P\n");
            Console.WriteLine("1. Tambah Mahasiswa");
            Console.WriteLine("2. Tampilkan Mahasiswa");
            Console.WriteLine("3. Keluar");
        }

        static void TambahMahasiswa()
        {
            
            Console.Clear();

            Mahasiswa Mahasiswa = new Mahasiswa();

            Console.Write("Nama: ");
            Mahasiswa.Nim = Console.ReadLine();
            Console.Write("NIM: ");
            Mahasiswa.Nama = Console.ReadLine();
            Console.Write("Jenis Kelamin [L/P] : ");
            Mahasiswa.Gender = Console.ReadLine();
            if (Mahasiswa.Gender == "L")
            {
                Mahasiswa.Gender = "Laki-Laki";
            }
            else if (Mahasiswa.Gender == "P")
            {
                Mahasiswa.Gender = "Perempuan";
            }
            Console.Write("IPK : ");
            Mahasiswa.Ipk = Console.ReadLine();

            daftarMahasiswa.Add(Mahasiswa);

            Console.WriteLine("\nTekan ENTER untuk kembali ke menu");
            Console.ReadKey();
        }

        static void TampilMahasiswa()
        {
            
            Console.Clear();

            Console.WriteLine("Data Mahasiswa\n");
            int no = 1;

            Console.WriteLine("No   \tNama   \tNim   \tJenis Kelamin   \tIPK");
            foreach (Mahasiswa mahasiswa in daftarMahasiswa)
            {

                Console.WriteLine("{0}.\t{1}\t{2} \t{3}\t{4}", no,mahasiswa.Nim,mahasiswa.Nama,mahasiswa.Gender,mahasiswa.Ipk);
                no++;
            }

            Console.WriteLine("\nTekan enter untuk kembali ke menu");
            Console.ReadKey();
        }
    }
}
