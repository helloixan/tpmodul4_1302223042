public class Program
{
    public static void Main(string[] args)
    {
        KodePos obj_kodepos = new KodePos();
        int kodepos = obj_kodepos.getKodePos(KodePos.Kelurahan.Jatisari);
        Console.WriteLine("Kode pos dari " + KodePos.Kelurahan.Jatisari + " adalah " + kodepos);
    }
}
