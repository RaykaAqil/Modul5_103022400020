using Modul5_103022400020;
public class main
{
    static void Main(string[] args)
    {
        PemrosesData pd = new PemrosesData();

        long hasil = pd.DapatkanNilaiTerbesar(10, 20, 22);
        Console.WriteLine("Nilai terbesaer: " + hasil);
    }
}
