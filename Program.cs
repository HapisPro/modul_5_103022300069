using System;
using System.ComponentModel.Design;

class PemrosesData
{
    public T DapatkanNilaiTerbesar<T>(T digit1, T digit2, T digit3)
    {
        dynamic max = (dynamic) digit1;

        if (max < digit2)
        {
            max = digit2;
            if (max < digit3)
            {
                max = digit3;
            }
        } else if (max < digit3)
        {
            max = digit3;
            if(max < digit2)
            {
                max = digit2;
            }
        }

        return max;
    }
}

class Program
{
    static void Main(string[] args)
    {
        PemrosesData p = new PemrosesData();
        long nilaiTerbesar = p.DapatkanNilaiTerbesar(30, 00, 69);
        Console.WriteLine("Nilai terbesar adalah : " + nilaiTerbesar);

    }
    
}