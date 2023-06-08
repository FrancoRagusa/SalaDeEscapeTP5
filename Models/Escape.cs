static class Escape
{
private static string[] incognitasSalas {get; set;}
private static int estadoJuego{get; set;}
public static int vidas{get; private set;}


private static void IniciaLizarJuego()
{

    incognitasSalas = new string[]{"árbol", "lobo", "pinocho", "mosquito"};
    estadoJuego=1;
    vidas=3;
}

public static int GetEstadoJuego()
{
    return estadoJuego;
}

public static bool ResolverSala(int Sala, string Incognita)
{
    if(incognitasSalas[Sala] == Incognita )
    {
        estadoJuego=estadoJuego+1;
        return true;

    }
    else
    {
        vidas=vidas-1;
        return false;
    }
}

}

