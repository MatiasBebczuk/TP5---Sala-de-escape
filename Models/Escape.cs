
class Escape{
    public static string[] incognitasSalas = new string[4];
    static int estadoJuego;
    static DateTime startTime;
    static TimeSpan gameDuration = TimeSpan.FromMinutes(5);
    private static void InicializarJuego(){
        incognitasSalas = new string[]{"Soy el guardián de la guerra", "Lorem ipsum dolor sit amet", "QUAKE", "hey hey people sseth here"};
        estadoJuego = 1;
        startTime = DateTime.Now;
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
     public static TimeSpan GetRemainingTime()
    {
        return gameDuration - (DateTime.Now - startTime);
    }

    public static bool IsGameOver()
    {
         
        Console.WriteLine(TimeSpan.Zero);
        Console.WriteLine(GetRemainingTime() );
        
        return GetRemainingTime() <= TimeSpan.Zero;
    }

    public static void StopGame()
    {
        gameDuration = TimeSpan.Zero;
    }
}