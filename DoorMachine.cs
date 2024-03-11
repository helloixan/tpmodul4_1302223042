public enum DoorState { TERKUNCI, TERBUKA };
public enum Trigger { BUKA_PINTU, KUNCI_PINTU };

public class DoorMachine
{
    public class Transition
    {
        public DoorState stateAwal;
        public DoorState stateAkhir;
        public Trigger trigger;

        public Transition(DoorState stateAwal, DoorState stateAkhir, Trigger trigger)
        {
            this.stateAwal = stateAwal;
            this.stateAkhir = stateAkhir;
            this.trigger = trigger;
        }
    }

    Transition[] transisi =
    {
        new Transition(DoorState.TERKUNCI, DoorState.TERBUKA, Trigger.BUKA_PINTU),
        new Transition(DoorState.TERBUKA, DoorState.TERKUNCI, Trigger.KUNCI_PINTU),
    };

    public DoorState currentState = DoorState.TERKUNCI;

    public DoorState GetNextState(DoorState stateAwal, Trigger trigger)
    {
        DoorState stateAkhir = stateAwal;

        for (int i = 0; i < transisi.Length; i++)
        {
            Transition difference = transisi[i];
            if (stateAwal == difference.stateAwal && trigger == difference.trigger)
            {
                stateAkhir = difference.stateAkhir;
            }
        }
        return stateAkhir;
    }

    public void ActivateTrigger(Trigger trigger)
    {
        currentState = GetNextState(currentState, trigger);

        if (currentState == DoorState.TERKUNCI)
        {
            Console.WriteLine("Pintu Terkunci");
        } else
        {
            Console.WriteLine("Pintu Tidak Terkunci");
        }
    }
}