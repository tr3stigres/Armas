public class Venda : IUsable
{
    private bool consumida = false;
    public bool Usar(Personaje objetivo)
    {
        ArgumentNullException.ThrowIfNull(objetivo);
        if (consumida || objetivo.Vida == objetivo.VidaMaxima)
            return false;
        objetivo.Curar(10);
        consumida = true;
        return true;
    }
    public override string ToString()
    {
        return $"consumida: {consumida}";
    }
}