using System;
using System.Collections.Generic;
using Builder.Enums;

namespace Builder.Product
{
    class Vehicle
    {
        VehicleType vehicleType;
        Dictionary<PartType, string> parts = new Dictionary<PartType, string>();

        // Constructor
        public Vehicle(VehicleType vehicleType)
        {
            this.vehicleType = vehicleType;
        }

        public string this[PartType key]
        {
            get { return parts[key]; }
            set { parts[key] = value; }
        }

        public void Show()
        {
            Console.WriteLine("\n---------------------------");
            Console.WriteLine("Vehicle Type: {0}", vehicleType);
            Console.WriteLine(" Frame  : {0}",
                this[PartType.Frame]);
            Console.WriteLine(" Engine : {0}",
                this[PartType.Engine]);
            Console.WriteLine(" #Wheels: {0}",
                this[PartType.Wheel]);
            Console.WriteLine(" #Doors : {0}",
                this[PartType.Door]);
        }
    }
}
