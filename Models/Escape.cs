static class Escape
{
private static string[] incognitasSalas {get; set;} = new string[4]; 
private static int estadoJuego{get; set;}
public static int vidas{get; private set;}


public static void InicializarJuego()
{
    
    incognitasSalas = new string[]{"Arbol", "Lobo", "Pinocho", "Mosquito"};
    estadoJuego=1;
}

public static int GetEstadoJuego()
{
    
    return estadoJuego;
}

public static bool ResolverSala(int Sala, string Incognita)
    {


    if(incognitasSalas[Sala-1] == Incognita)
        {
            estadoJuego=estadoJuego+1;
            return true;
        }
    else
    
        {

            return false;

        }

    }
}

