
using System;

class Program
{
    static string[] gudang = {"","","","","",""};

    static void BarangMasuk(string namaBarang)
    {
        for (int i = 0; i < gudang.Length; i++)
        {
            if (gudang[i] == "")
            {
                gudang[i] = namaBarang;
                Console.WriteLine(namaBarang + " berhasil masuk gudang.");
                return;
            }
        }

        Console.WriteLine(namaBarang+ " Tidak masuk, karena gudang penuh!");
    }

    static void BarangKeluar()
    {
        // Cek apakah gudang kosong
        if (gudang[0] == "")
        {
            Console.WriteLine("Gudang kosong!");
            return;
        }
        // Barang pertama keluar dari gudang
        Console.WriteLine(gudang[0] + " keluar dari gudang.");

        // Geser semua barang ke kiri
        for (int i = 0; i < gudang.Length - 1; i++)
        {
            gudang[i] = gudang[i + 1];
        }
        // Kosongkan indeks terakhir
        gudang[gudang.Length - 1] = "";
    }

    static void TampilkanIsiArray()
    {
        Console.WriteLine("\nIsi Gudang:");

        for (int i = 0; i < gudang.Length; i++)
        {
            if (gudang[i] != "")
            {
                Console.WriteLine("Indeks " + i + ": " + gudang[i]);
            }
        }
    }

    static void Main()
    {
        // BarangMasuk("sabun");
        // BarangMasuk("sepeda");
        // BarangMasuk("buku");

        // TampilkanIsiArray();

        // Console.WriteLine("\n--- Barang Keluar ---");
        // BarangKeluar();

        // TampilkanIsiArray();

        // Console.WriteLine("\n--- Barang Masuk ---");
        // BarangMasuk("pensil");

        // TampilkanIsiArray();

        BarangMasuk("0");
        BarangMasuk("1");
        BarangMasuk("2");
        BarangMasuk("3");
        BarangMasuk("4");
        BarangMasuk("5");
        
        BarangKeluar();
        BarangMasuk("0");
        TampilkanIsiArray();
    }
}
