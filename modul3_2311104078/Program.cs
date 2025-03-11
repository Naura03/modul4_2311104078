class Program
{
    static void Main()
    {
        Console.Write("Masukkan nama buah: ");
        string namaBuah = Console.ReadLine();
        string kode = KodeBuah.GetKodeBuah(namaBuah);
        Console.WriteLine($"Kode buah untuk {namaBuah}: {kode}");
    }
}
