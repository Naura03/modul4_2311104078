using System;

class Program
{
    static void Main()
    {
        Console.Write("Masukkan NIM Anda: ");
        long nim = Convert.ToInt64(Console.ReadLine()); // Menggunakan long untuk menghindari overflow

        PosisiKarakterGame karakter = new PosisiKarakterGame();

        Console.WriteLine("Menekan tombol W:");
        karakter.TombolW(nim);

        Console.WriteLine("Menekan tombol S:");
        karakter.TombolS(nim);
    }
}
