public class Personaje
{
    public string Nombre { get; }
    public int VidaMaxima { get; }
    public int Vida { get; private set; }
    public Arma ArmaEquipada { get; private set; }


    public Personaje(string nombre, int maxima, Arma arma)
    {
        if (string.IsNullOrWhiteSpace(nombre))
            throw new ArgumentException("Nombre vacío.");
        if (maxima <= 0)
            throw new ArgumentOutOfRangeException(nameof(maxima));
        ArgumentNullException.ThrowIfNull(arma);
        Nombre = nombre.Trim();
        VidaMaxima = Math.Max(0, maxima);
        Vida = VidaMaxima;
        ArmaEquipada = arma;
    }

    public void RecibirDanyo(int cantidad)
    {
        if (cantidad < 0)
            return;
        Vida -= Math.Min(cantidad, Vida);
        if (Vida < 0)
            Vida = 0;
    }

    public void Curar(int cantidad)
    {
        if (cantidad < 0)
            return;
        int mejora = VidaMaxima - Vida;
        Vida += Math.Min(cantidad, mejora);

    }

    public bool EstaVivo()
    {
        return Vida > 0;
    }

    public void Atacar(Personaje objetivo)
    {
        ArgumentNullException.ThrowIfNull(objetivo);
        if (!EstaVivo())
            throw new InvalidOperationException("El atacante está derrotado.");
        int cantidad = ArmaEquipada.Danyo;
        objetivo.RecibirDanyo(cantidad);
    }

    public void Equipar(Arma nueva)
    {
        ArgumentNullException.ThrowIfNull(nueva);
        ArmaEquipada = nueva;
    }

    public bool Aplicar(IUsable objeto)
    {
        return objeto.Usar(this);
    }

    public override string ToString()
    {
        return $"{Nombre} {Vida}/{VidaMaxima} {ArmaEquipada.Nombre}";
    }

}
