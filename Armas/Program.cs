using static System.Runtime.InteropServices.JavaScript.JSType;

class Program
{
    public static void Main()
    {
        try
        {
            Console.WriteLine("Práctica 1 - Armas intercambiables");
            var armaEspada = new Arma("Espada", 20);
            var armaBaston = new Arma("Bastón", 8);
            Personaje personajePrincipal = new Personaje("Ada", 100, armaEspada);
            Personaje personajeSecundario = new Personaje("Bruno", 100, armaBaston);
            Console.WriteLine($"{personajePrincipal} vs {personajeSecundario}");
            personajePrincipal.Atacar(personajeSecundario);
            Console.WriteLine($"{personajePrincipal.Nombre} ataca a {personajeSecundario.Nombre}: {personajeSecundario}");
            personajePrincipal.Equipar(armaBaston);
            Console.WriteLine($"{personajePrincipal.Nombre} cambia a {armaBaston.Nombre}: {personajePrincipal}");
            personajePrincipal.Atacar(personajeSecundario);
            Console.WriteLine($"{personajePrincipal.Nombre} ataca a {personajeSecundario.Nombre}: {personajeSecundario}");

            Console.WriteLine("\n\nPráctica 2 - Pociones");
            personajePrincipal = new Personaje("Ana", 100, armaEspada);
            Console.WriteLine($"Personaje -> {personajePrincipal}");
            personajePrincipal.RecibirDanyo(60);
            Console.WriteLine($"Recibe daño: {personajePrincipal.Vida} de {personajePrincipal.VidaMaxima}");

            IUsable pocionA = new Pocion(30);
            Console.WriteLine($"Creamos la Poción A -> {pocionA}");
            personajePrincipal.Aplicar(pocionA);
            Console.WriteLine($"Se toma la poción A: {personajePrincipal.Vida} de {personajePrincipal.VidaMaxima}, Poción -> {pocionA}");
            personajePrincipal.Aplicar(pocionA);
            Console.WriteLine($"Se toma de nuevo la poción A: {personajePrincipal.Vida} de {personajePrincipal.VidaMaxima}, Poción -> {pocionA}");
            
            IUsable pocionB = new Pocion(200);
            Console.WriteLine($"Creamos la Poción B -> {pocionB}");
            personajePrincipal.Aplicar(pocionB);
            Console.WriteLine($"Se toma la poción B: {personajePrincipal.Vida} de {personajePrincipal.VidaMaxima}, Poción -> {pocionB}");
            
            IUsable pocionC = new Pocion(10);
            Console.WriteLine($"Poción C -> {pocionC}");
            personajePrincipal.Aplicar(pocionC);
            Console.WriteLine($"Se toma la poción C: {personajePrincipal.Vida} de {personajePrincipal.VidaMaxima}, Poción -> {pocionC}");

            personajePrincipal.RecibirDanyo(15);
            Console.WriteLine($"Recibe daño: {personajePrincipal.Vida} de {personajePrincipal.VidaMaxima}");
            personajePrincipal.Aplicar(pocionC);
            Console.WriteLine($"Se toma de nuevo la poción C: {personajePrincipal.Vida} de {personajePrincipal.VidaMaxima}, Poción -> {pocionC}");

            IUsable venda = new Venda();
            Console.WriteLine($"Creamos la Venda -> {venda}");
            personajePrincipal.Aplicar(venda);
            Console.WriteLine($"Se pone la venda: {personajePrincipal.Vida} de {personajePrincipal.VidaMaxima}, Venda -> {venda}");
            
            personajePrincipal.RecibirDanyo(10);
            Console.WriteLine($"Recibe daño: {personajePrincipal.Vida} de {personajePrincipal.VidaMaxima}");
            personajePrincipal.Aplicar(venda);
            Console.WriteLine($"Se pone la venda: {personajePrincipal.Vida} de {personajePrincipal.VidaMaxima}, Venda -> {venda}");

        }        
        catch (ArgumentOutOfRangeException error)
        {
            Console.WriteLine($"Cantidad errónea: {error.Message}");
        }
        catch (InvalidOperationException error)
        {
            Console.WriteLine($"Operación inválida: {error.Message}");
        }
        catch (ArgumentException error)
        {
            Console.WriteLine($"Alerta: {error.Message}");
        }
        catch (Exception error)
        {
            Console.WriteLine($"Se ha producido el siguiente error: {error.Message}");
        }
    }

}