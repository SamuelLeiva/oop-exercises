using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP_Vehicle;
    internal interface ILandVehicle : IVehicle
    {
        int NumWheels { get; }
        string NumPlate {  get; }

        //tocar bocina
        void Honk();

        //imprimir detalles
        void PrintDetails();
    }
