class Escape{
    public static string[] incognitasSalas;
    static int estadoJuego;
    private static void InicializarJuego(){
        incognitasSalas = new string[]{"Soy el guardián de la guerra"};
        estadoJuego = 1;
    }
    public static int GetEstadoJuego(){
        return estadoJuego;
    }
    public static bool ResolverSala(int Sala, string Incognita){
        if(Escape.incognitasSalas == null){ Escape.InicializarJuego(); }
        if(incognitasSalas[estadoJuego - 1] == Incognita){
            estadoJuego++;
            return true;
        }
        else{
            return false;
        }
    }
}