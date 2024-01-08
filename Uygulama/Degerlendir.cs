using System;

namespace integer_ikililerin_toplami;

class Degerlendir
{
    internal int[] SayilariAl(int adet)
    {
        Ifade.Yazdir($"Arada boşuk olacak şekilde {adet} sayı giriniz!");
        string[] dizi = Console.ReadLine().Split(' ');

        if (dizi.Length == adet)
            return Sayi.Cevir(dizi);
        else
            Console.WriteLine($"Değerler okunamadı!");
        
        return null;
    }

    internal int[] Karsilastir(int[] ints)
    {
        int[] sum = new int[ints.Length / 2];
        int x = 0;
        for (int i = 0; i < ints.Length; i += 2)
        {
            sum[x] = Karsilastir(ints[i], ints[i+1]);
            x++;
        }
        return sum;
    }

    private int Karsilastir(int num1, int num2)
    {
        return num1 != num2 ? Topla(num1, num2) : ToplamKare(num1);
    }

    private int Topla(int num1, int num2)
    {
        return num1 + num2;
    }

    private int ToplamKare(int num)
    {
        int sum = Topla(num, num);
        return sum * sum;
    }
}