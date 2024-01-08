using System;

namespace integer_ikililerin_toplami;

class Program
{
    static void Main(string[] args)
    {
        Degerlendir degerlendir = new Degerlendir();

        Baslangic:
        Ifade.Yazdir("Pozitif bir çift tam sayı giriniz!");
        int n = Sayi.Cevir(Console.ReadLine());

        if (n > 0)
        {
            SayiAl:
            int[] ints = degerlendir.SayilariAl(n);
            if (ints != null)
            {
                ints = degerlendir.Karsilastir(ints);
                Console.Write("Sonuç: ");

                for (int i = 0; i < ints.Length; i++)
                {
                    Console.Write(ints[i] + " ");
                }
            }
            else
                goto SayiAl;
        };

        goto Baslangic;
    }
}
