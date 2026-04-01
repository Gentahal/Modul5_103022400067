// See https://aka.ms/new-console-template for more information

class PemrosesData {
    public int DapatkanNilaiTerbesar<T>(T nilai1, T nilai2, T nilai3)
    {
        Console.WriteLine($"Nilai 1: {nilai1}");

        Console.WriteLine($"Nilai 2: {nilai2}");

        Console.WriteLine($"Nilai 3: {nilai3}");

        dynamic max = nilai1;

        if (max <= nilai2)
        {
            max = nilai2;
        }
        if (max <= nilai3)
        {
            max = nilai3;
        }

        return max;
    }
}


class Program
{
    static void Main(string[] args)
    {
        PemrosesData pemroses = new PemrosesData();

        int nim1 = 40;
        int nim2 = 00;
        int nim3 = 67;

        int nilaiTerbesar = pemroses.DapatkanNilaiTerbesar(nim1, nim2, nim3);

        Console.WriteLine($"Nilai terbesar {nilaiTerbesar}");
    }
}