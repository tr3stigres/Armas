public class Arma
{
    public string Nombre { get; }
    public int Danyo { get; }
    public Arma(string nombre, int danyo)
    {
        if (string.IsNullOrWhiteSpace(nombre) || danyo <= 0)
            throw new ArgumentException("Arma no válida.");
        Nombre = nombre.Trim();
        Danyo = danyo;
    }

    public override string ToString()
    {
        return $"Arma: {Nombre}, Daño causado: {Danyo}";
    }
}