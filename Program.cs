using System;
using System.Configuration.Assemblies;

namespace UPRAK12._2
{

    class Program
    {
        // Deklarasi array
        static string[] kantongKelereng = new string[0];
        static string[] jumlahKelerengMerah = new string[0];
        static string[] JumlahKelerengBiru = new string[0];

        static void Main(string[] args)
        {
            // Soal 1:  merah 8, biru 5, diambil 2 merah 1 biru
            DeklarasikantongKelereng(8, 5);
            float nS = Kombinasi(kantongKelereng.Length, 3);
            Console.WriteLine(nS);

            float nKelerengMerah = Kombinasi(jumlahKelerengMerah.Length, 2);
            float nKelerengBiru = Kombinasi(JumlahKelerengBiru.Length, 1);
            float nA = nKelerengBiru * nKelerengMerah;
            Console.WriteLine(nA);

            float peluang = (nA / nS) * 100;
            Console.WriteLine("peluang 2 merah, 1 biru adalah: " + peluang + "%");

            //// Soal 2:  merah 6, biru 4, diambil 2 biru 1 merah 
            DeklarasikantongKelereng(6, 4);
            nS = Kombinasi(kantongKelereng.Length, 3);
            Console.WriteLine(nS);

            nKelerengMerah = Kombinasi(jumlahKelerengMerah.Length, 1);
            nKelerengBiru = Kombinasi(JumlahKelerengBiru.Length, 2);
            nA = nKelerengBiru * nKelerengMerah;
            Console.WriteLine(nA);
            peluang = (nA / nS) * 100;
            Console.WriteLine("peluang 2 biru, 1 merah adalah: " + peluang + "%");

            ////Soal 3
            //// tambah merah 6, biru 7
            //// merah 7, biru 9, diambil 5 biru 3 merah 
            //DeklarasikantongKelereng(7, 9);
            //nS = Kombinasi(kantongKelereng.Length, 8);
            //Console.WriteLine(nS);

            //nKelerengMerah = Kombinasi(jumlahKelerengMerah.Length, 3);
            //nKelerengBiru = Kombinasi(JumlahKelerengBiru.Length, 5);
            //nA = nKelerengBiru * nKelerengMerah;
            //Console.WriteLine(nA);
            //peluang = (nA / nS) * 100;
            //Console.WriteLine("peluang 5 biru, 3 merah adalah: " + peluang + "%");
        }

        static void DeklarasikantongKelereng(int kelerengMerah, int kelerengBiru)
        {
            jumlahKelerengMerah = new string[kelerengMerah];
            JumlahKelerengBiru = new string[kelerengBiru];

            int totalElemenKelereng = JumlahKelerengBiru.Length + jumlahKelerengMerah.Length;
            kantongKelereng = new string[totalElemenKelereng];

            for (int i = 0; i < kelerengMerah; i++)
            {
                kantongKelereng[i] = "Kelereng Merah";
            }

            for (int i = kelerengMerah; i < kelerengMerah + kelerengBiru; i++)
            {
                kantongKelereng[i] = "Kelereng Biru";
            }

            Console.WriteLine("jumlah kelereng dalam kantong adalah: " + kantongKelereng.Length);
            for (int i = 0; i < kantongKelereng.Length; i++)
            {
                Console.WriteLine("kantongKelereng " + i + ": " + kantongKelereng[i]);
            }
        }

        static float Faktorial(int n)
        {
            float hasil = 1;
            for (int i = 1; i <= n; i++)
            {
                hasil *= i;
            }
            return hasil;
        }

        static float Kombinasi(int n, int r)
        {
            if (r > n)
            {
                return 0;
            }
            float pembilang = Faktorial(n);
            float penyebut = Faktorial(r) * Faktorial(n - r);
            return pembilang / penyebut;
        }
    }
}