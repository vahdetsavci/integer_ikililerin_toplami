namespace integer_ikililerin_toplami;

class PozitifDegil : System.Exception
{
    internal PozitifDegil() : base ("Pozitif olmayan sayı girdiniz!"){}
}

class CiftDegil : System.Exception
{
    internal CiftDegil() : base ("Çift olmayan sayı girdiniz!"){}
}