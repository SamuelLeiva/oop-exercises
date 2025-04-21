using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Vehicle;
public class Car : ILandVehicle
{
    public int NumWheels {  get; protected set; }
    public string NumPlate {  get; protected set; }
    public string Id {  get; protected set; }
    public string Producer {  get; protected set; }

    public Car(int numWheels, string numPlate, string id, string producer)
    {
        NumWheels = numWheels;
        NumPlate = numPlate;
        Id = id;
        Producer = producer;
    }

    public void Honk()
    {
        Console.WriteLine("Hooonnnnk hooonk!!");
    }

    public void PrintDetails()
    {
        Console.WriteLine("Datos del auto");
        Console.WriteLine($"Id de vehículo: {Id}");
        Console.WriteLine($"Productor: {Producer}");
        Console.WriteLine($"Número de placa: {NumPlate}");
        Console.WriteLine($"Número de ruedas: {NumWheels}");
    }
}

