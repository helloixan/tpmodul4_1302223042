public class Program
{
    public static void Main(string[] args)
    {
        KodePos obj_kodepos = new KodePos();
        int kodepos = obj_kodepos.getKodePos(KodePos.Kelurahan.Jatisari);
        Console.WriteLine("Kode pos dari " + KodePos.Kelurahan.Jatisari + " adalah " + kodepos);

        DoorMachine obj_doorMachine = new DoorMachine();
        Console.WriteLine("State Awal : " + obj_doorMachine.currentState);
        obj_doorMachine.ActivateTrigger(Trigger.BUKA_PINTU);
    }
}
