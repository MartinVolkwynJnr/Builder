using System;
using Builder.ConcreteBuilders;
using Builder.Director;

namespace Builder
{
    class MainApp
    {
        static void Main()
        {
            // Create shop
            var shop = new Shop();

            // Construct and display vehicles
            shop.Construct(new ScooterBuilder());
            shop.ShowVehicle();

            shop.Construct(new CarBuilder());
            shop.ShowVehicle();

            shop.Construct(new MotorCycleBuilder());
            shop.ShowVehicle();

            // Wait for user
            Console.ReadKey();
        }
    }
}
