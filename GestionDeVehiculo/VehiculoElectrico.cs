using System;

public class VehiculoElectrico : Vehiculo, IElectrico
{
    public double CapacidadBateria { get; }

    public VehiculoElectrico(string marca, string modelo, double capacidadBateria) : base(marca, modelo)
    {
        CapacidadBateria = capacidadBateria;
    }

    public void CargarBateria()
    {
        Console.WriteLine($"{Marca} {Modelo} está cargando su batería de {CapacidadBateria} kWh.");
    }

    public override void Moverse()
    {
        Console.WriteLine($"{Marca} {Modelo} se está moviendo el vehículo eléctrico.");
    }
}
