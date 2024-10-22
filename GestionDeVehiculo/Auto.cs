using System;


public class Auto : Vehiculo, ITransporte
{
    public Auto(string marca, string modelo) : base(marca, modelo) { }
    public override void Moverse()
    {
        Console.WriteLine($"{Marca} {Modelo} se está moviendo el auto.");
    }

}

