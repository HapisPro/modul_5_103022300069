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

class SimpleDataBase<T>
{
    private List<T> storedData ;
    private List<DateTime> inputDates;

    public SimpleDataBase()
    {
        this.storedData = new List<T>();
        this.inputDates = new List<DateTime>();
    }

    public void AddNewData(T data)
    {
        storedData.Add(data);
        inputDates.Add(DateTime.Now);
    }

    public void PrintAllData()
    {
        for (int i = 0; i < storedData.Count; i++)
        {
            Console.WriteLine("Data " + (i+1) + " berisi: " + storedData[i] + ", yang disimpan pada waktu UTC: " + inputDates[i] );
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("\nSoal 1--------------");
        PemrosesData p = new PemrosesData();
        long nilaiTerbesar = p.DapatkanNilaiTerbesar(30, 00, 69);
        Console.WriteLine("Nilai terbesar adalah : " + nilaiTerbesar);

        Console.WriteLine("\nSoal 2--------------");
        SimpleDataBase<long> db = new SimpleDataBase<long>();
        db.AddNewData(30);
        db.AddNewData(00);
        db.AddNewData(69);
        db.PrintAllData();
    }
    
}