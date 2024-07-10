public class Escape
{
    public static string[] incognitasSalas = new string[]{};
    static int estadoJuego;
    static DateTime startTime;
    static TimeSpan gameDuration = TimeSpan.FromMinutes(5);

    private static void InicializarJuego()
    {
        incognitasSalas = new string[]{"Soy el guardián de la guerra"};
        estadoJuego = 1;
        startTime = DateTime.Now;
    }

    public static int GetEstadoJuego()
    {
        return estadoJuego;
    }

    public static bool ResolverSala(int Sala, string Incognita)
    {
        if (Object.Equals(incognitasSalas, default(string)))
        {
            InicializarJuego();
        }

        if (incognitasSalas[estadoJuego - 1] == Incognita)
        {
            estadoJuego++;
            return true;
        }
        else
        {
            return false;
        }
    }

    public static TimeSpan GetRemainingTime()
    {
        return gameDuration - (DateTime.Now - startTime);
    }

    public static bool IsGameOver()
    {
        return GetRemainingTime() <= TimeSpan.Zero;
    }

    public static void StopGame()
    {
        gameDuration = TimeSpan.Zero;
    }
}
