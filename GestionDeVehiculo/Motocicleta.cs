using System;

public sealed class Motocicleta : Vehiculo
{
    public Motocicleta(string marca, string modelo) : base(marca, modelo)
    {
    }

    public override void Moverse()
    {
        Console.WriteLine($"{Marca} {Modelo} se está moviendo la motocicleta.");
    }
}

