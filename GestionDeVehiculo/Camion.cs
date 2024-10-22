using System;

public class Camion : Vehiculo
{
    public double CapacidadCarga { get; set; }

    public Camion(string marca, string modelo, double capacidadCarga) : base(marca, modelo)
    {
        CapacidadCarga = capacidadCarga;
    }

    public override void Moverse()
    {
        Console.WriteLine($"{Marca} {Modelo} se está moviendo el camión con capacidad de {CapacidadCarga} toneladas.");
    }

    public override string ToString()
    {
        return $"{base.ToString()}, Capacidad de carga: {CapacidadCarga} toneladas";
    }
}
