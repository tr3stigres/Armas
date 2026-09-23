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
            Console.WriteLine("");
            Console.WriteLine("\n\nPráctica 2 - Pociones");
            personajePrincipal = new Personaje("Ada", 100, armaEspada);
            personajePrincipal.RecibirDanyo(60);
            Console.WriteLine($"Personaje -> {personajePrincipal}");
            Console.WriteLine("");
            IUsable pocionA = new Pocion(30);
            Console.WriteLine($"Creamos la Poción A -> {pocionA}");
            personajePrincipal.Aplicar(pocionA);
            Console.WriteLine($"Se toma la poción A: {personajePrincipal.Vida} de {personajePrincipal.VidaMaxima}, Poción -> {pocionA}");
            personajePrincipal.Aplicar(pocionA);
            Console.WriteLine($"Se toma de nuevo la poción A: {personajePrincipal.Vida} de {personajePrincipal.VidaMaxima}, Poción -> {pocionA}");
            Console.WriteLine("");
            IUsable pocionB = new Pocion(200);
            Console.WriteLine($"Creamos la Poción B -> {pocionB}");
            personajePrincipal.Aplicar(pocionB);
            Console.WriteLine($"Se toma la poción B: {personajePrincipal.Vida} de {personajePrincipal.VidaMaxima}, Poción -> {pocionB}");
            Console.WriteLine("");
            IUsable pocionC = new Pocion(10);
            Console.WriteLine($"Creamos Poción C -> {pocionC}");
            personajePrincipal.Aplicar(pocionC);
            Console.WriteLine($"Se toma la poción C: {personajePrincipal.Vida} de {personajePrincipal.VidaMaxima}, Poción -> {pocionC}");
            Console.WriteLine("");
            personajePrincipal.RecibirDanyo(15);
            Console.WriteLine($"Recibe daño: {personajePrincipal.Vida} de {personajePrincipal.VidaMaxima}");
            personajePrincipal.Aplicar(pocionC);
            Console.WriteLine($"Se toma de nuevo la poción C: {personajePrincipal.Vida} de {personajePrincipal.VidaMaxima}, Poción -> {pocionC}");
            Console.WriteLine("");
            IUsable venda = new Venda();
            Console.WriteLine($"Creamos la Venda -> {venda}");
            personajePrincipal.Aplicar(venda);
            Console.WriteLine($"Se pone la venda: {personajePrincipal.Vida} de {personajePrincipal.VidaMaxima}, Venda -> {venda}");
            Console.WriteLine("");
            personajePrincipal.RecibirDanyo(10);
            Console.WriteLine($"Recibe daño: {personajePrincipal.Vida} de {personajePrincipal.VidaMaxima}");
            personajePrincipal.Aplicar(venda);
            Console.WriteLine($"Se pone la venda: {personajePrincipal.Vida} de {personajePrincipal.VidaMaxima}, Venda -> {venda}");
            Console.WriteLine("");
            personajePrincipal = new Personaje("Ada", 100, armaEspada);
            personajePrincipal.RecibirDanyo(60);
            Console.WriteLine($"Personaje: {personajePrincipal.Vida} de {personajePrincipal.VidaMaxima}");
            pocionA = new Pocion(30);
            Console.WriteLine($"Creamos poción -> {pocionA}");
            pocionB = pocionA;
            Console.WriteLine($"Clonamos poción -> {pocionB}");
            personajePrincipal.Aplicar(pocionA);
            Console.WriteLine($"Se toma la poción Principal: {personajePrincipal.Vida} de {personajePrincipal.VidaMaxima}, Poción -> {pocionA}");
            personajePrincipal.Aplicar(pocionB);
            Console.WriteLine($"Se toma la poción Clon: {personajePrincipal.Vida} de {personajePrincipal.VidaMaxima}, Poción -> {pocionB}");
            if (ReferenceEquals(pocionA, pocionB))
                Console.WriteLine("Las pociones son la misma instancia");
            else
                Console.WriteLine("Las pociones son instancias diferentes");
            Console.WriteLine("");
            personajePrincipal = new Personaje("Ada", 100, armaEspada);
            personajePrincipal.RecibirDanyo(60);
            Console.WriteLine($"Personaje: {personajePrincipal.Vida} de {personajePrincipal.VidaMaxima}");
            pocionA = new Pocion(30);
            Console.WriteLine($"Creamos Poción A -> {pocionA}");
            pocionB = new Pocion(30);
            Console.WriteLine($"Creamos Poción B -> {pocionB}");
            personajePrincipal.Aplicar(pocionA);
            Console.WriteLine($"Se toma la poción A: {personajePrincipal.Vida} de {personajePrincipal.VidaMaxima}, Poción -> {pocionA}");
            personajePrincipal.Aplicar(pocionB);
            Console.WriteLine($"Se toma la poción B: {personajePrincipal.Vida} de {personajePrincipal.VidaMaxima}, Poción -> {pocionB}");
            if(ReferenceEquals(pocionA, pocionB))
                Console.WriteLine("Las pociones son la misma instancia");
            else
                Console.WriteLine("Las pociones son instancias diferentes");
            


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