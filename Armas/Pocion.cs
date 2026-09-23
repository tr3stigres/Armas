using static System.Runtime.InteropServices.JavaScript.JSType;

public class Pocion : IUsable
{
    private readonly int cantidad;
    private bool consumida = false;
    public Pocion(int cantidad)
    {
        if (cantidad <= 0)
            throw new ArgumentOutOfRangeException(nameof(cantidad));
        this.cantidad = cantidad;
    }

    public bool Usar(Personaje objetivo)
    {
        ArgumentNullException.ThrowIfNull(objetivo);
        if (consumida || objetivo.Vida == objetivo.VidaMaxima)
            return false;
        objetivo.Curar(cantidad);
        consumida = true;
        return true;
    }

    public override string ToString()
    {
        return $"Poder: {cantidad} y consumida: {consumida}";
    }
}