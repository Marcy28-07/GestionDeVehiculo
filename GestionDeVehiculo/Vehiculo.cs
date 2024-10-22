using System;

public abstract class Vehiculo
{
    public string Marca { get; set; }
    public string Modelo { get; set; }

    protected Vehiculo(string marca, string modelo)
    {
        Marca = marca;
        Modelo = modelo;
    }

    public abstract void Moverse();

    public virtual void Iniciar()
    {
        Console.WriteLine($"{Marca} {Modelo} ha iniciado.");
    }

    public virtual void Detener()
    {
        Console.WriteLine($"{Marca} {Modelo} se ha detenido.");
    }

    public override string ToString()
    {
        return $"La marca es: {Marca} y el modelo es: {Modelo}";
    }


}

