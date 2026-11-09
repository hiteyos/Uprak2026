using System;
using System.Configuration.Assemblies;

namespace UPRAK12._2;

class Program
{
    static void Main(string[] args)
    {
        // merah 8, biru 5, diambil 3 
        float nS = Kombinasi(13,3);
        Console.WriteLine(nS);

        float nKelerengMerah= Kombinasi(8,2);
        float nKelerengBiru = Kombinasi(5,1);
        float nA = nKelerengBiru * nKelerengMerah;
        Console.WriteLine(nA);

        float peluang = (nA / nS ) * 100;
        Console.WriteLine("peluang 2 merah, 1 biru adalah: "+peluang + "%");

    }

    static float Faktorial(int n)
    {
        float hasil = 1;
        for(int i =1 ; i<=n; i++)
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
        float penyebut = Faktorial(r) * Faktorial(n-r);
        return pembilang / penyebut;
    }
}
