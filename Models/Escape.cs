using System.Timers;
class Escape{
    public static string[] incognitasSalas = new string[4];
    static int estadoJuego;
    public static int cantIntentos, cantPistas;
    private static void InicializarJuego(){
        incognitasSalas = new string[]{"soy el guardian de la guerra", "quake" , "lorem ipsum dolor sit amet", "1101"};
        estadoJuego = 1;
        cantIntentos = 0;
        cantPistas = 0;
    }

    public static int GetEstadoJuego()
    {
        return estadoJuego;
    }
    public static bool ResolverSala(int sala, string incognita){
        if(estadoJuego == 0){ InicializarJuego();}
        if(estadoJuego != sala){
            return false;
        }
        else if(incognitasSalas[sala - 1] == incognita.ToLower()){
            return true;
        }
        else{
            cantIntentos++;
            return false;
        }
    }
    public static void AumentarEstadoJuego(){
        estadoJuego++;
    }
    public static void Reset(){
        estadoJuego = 0;
    }
}