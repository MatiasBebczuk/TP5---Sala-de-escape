class Escape{
    public static string[] incognitasSalas = new string[4];
    static int estadoJuego;
    private static void InicializarJuego(){
        incognitasSalas = new string[]{"Soy el guardián de la guerra"};
        estadoJuego = 1;
    }
    public static int GetEstadoJuego(){
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
}