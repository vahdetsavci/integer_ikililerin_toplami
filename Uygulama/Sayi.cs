using System;

namespace integer_ikililerin_toplami;

static class Sayi
{
    private static bool Kontrol(int i, out Exception exception)
    {
        exception = null;
        bool sonuc = false;

        if (i < 1)
            exception = new PozitifDegil();
        else if (i % 2 != 0)
            exception = new CiftDegil();
        else
            sonuc = true;

        return sonuc;
    }

    internal static int Cevir(string sayiAdet)
    {
        string mesaj;

        try
        {
            int i = int.Parse(sayiAdet);
            if (Kontrol(i, out Exception exception))
                return i;
            else
                throw exception;
        }
        catch (FormatException)
        {
            mesaj = "Tam sayı girmediniz!";
        }
        catch (PozitifDegil pd)
        {
            mesaj = pd.Message;
        }
        catch (CiftDegil cd)
        {
            mesaj = cd.Message;
        }

        Console.WriteLine(mesaj);
        return 0;
    }

    internal static int[] Cevir(string[] sayilarStr)
    {
        int[] sayilarInt = new int[sayilarStr.Length];
        for (int i = 0; i < sayilarStr.Length; i++)
        {
            if (int.TryParse(sayilarStr[i], out int x))
                sayilarInt[i] = x;
            else
            {
                Console.WriteLine("Tam sayı girmediniz!");
                return null;
            }
        }
        return sayilarInt;
    }
}