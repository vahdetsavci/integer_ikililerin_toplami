using System;

namespace integer_ikililerin_toplami;

enum Talep
{
    Yildiz,
    Cizgi
}

static class Ifade
{
    static string[] ifadeler;

    static Ifade()
    {
        ifadeler = new string[]
        {
            "***************************************************",
            "---------------------------------------------------"
        };
    }

    internal static void Yazdir(Talep talep)
    {
        Console.WriteLine(ifadeler[(int)talep]);
    }

    internal static void Yazdir(string mesaj)
    {
        Console.WriteLine();
        Yazdir(Talep.Yildiz);
        Console.WriteLine(mesaj);
        Yazdir(Talep.Cizgi);
    }
}