using System;

public class AccionesVehiculos
{
    public void MoverVehiculo(Vehiculo vehiculo)
    {
        vehiculo.Moverse();
    }

    public void IniciarVehiculo(Vehiculo vehiculo)
    {
        vehiculo.Iniciar();
    }

    public void DetenerVehiculo(Vehiculo vehiculo)
    {
        vehiculo.Detener();
    }

    public void CargarBateria(Vehiculo vehiculo)
    {
        if (vehiculo is IElectrico electrico)
        {
            electrico.CargarBateria();
        }
        else
        {
            throw new InvalidOperationException("Este vehículo no es eléctrico.");
        }
    }
}

