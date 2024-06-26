class Escape{
    static string[] incognitasSalas;
    static int estadoJuego;
    private static void InicializarJuego(){
        incognitasSalas = new string[]{"j"};
        estadoJuego = 1;
    }
    public static int GetEstadoJuego(){
        return estadoJuego;
    }
    public static bool ResolverSala(int Sala, string Incognita){
        if(incognitasSalas[estadoJuego - 1] == Incognita){
            estadoJuego++;
            return true;
        }
        else{
            return false;
        }
    }
}