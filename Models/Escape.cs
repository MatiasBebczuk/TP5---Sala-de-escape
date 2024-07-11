using System.Timers;
class Escape{
    public static string[] incognitasSalas = new string[4];
    static int estadoJuego;
    static DateTime startTime;
    static TimeSpan gameDuration = TimeSpan.FromMinutes(5);
    private static void InicializarJuego(){
        incognitasSalas = new string[]{"Soy el guardián de la guerra", "QUAKE", "Lorem ipsum dolor sit amet", "hey hey people sseth here"};
        estadoJuego = 1;
        System.Timers.Timer tiempoJugado = new System.Timers.Timer(1000);
        tiempoJugado.Elapsed += Tick;
    }

    public static int GetEstadoJuego()
    {
        return estadoJuego;
    }
    public static bool ResolverSala(int sala, string incognita){
        if(estadoJuego == 0){ InicializarJuego();}
        if(estadoJuego != sala){
            Console.WriteLine("estadoJuego != sala");
            return false;
        }
        else if(incognitasSalas[sala - 1] == incognita){
            Console.WriteLine("incognitasSalas[sala - 1] == incognita");
            estadoJuego++;
            return true;
        }
        else{
            Console.WriteLine("return false;");
            return false;
        }
    }
    public static void Reset(){
        estadoJuego = 0;
    }
    private static void Tick(object sender, ElapsedEventArgs e)
    {
        Console.WriteLine("Tick! The time is {0:HH:mm:ss.fff}", e.SignalTime);
    }
}