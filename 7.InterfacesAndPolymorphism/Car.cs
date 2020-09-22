using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace InterfacesAndPolymorphism
{
   /// <summary>
   /// Class that represents a car
   /// </summary>
    public class Car : Vehicle
   {
      public Car() : base(200, 5, 100) { }
      
      /// <summary>
      /// Method for addig the maximum amount of fuel the driver has with him/her
      /// </summary>
      /// <param name="maxRefuelingAmount"></param>
      public void AddMaxFuel(float maxRefuelingAmount)
      {
         this.maxRefuelingAmount = maxRefuelingAmount;
      }

      /// <summary>
      /// Main function to drive a car
      /// </summary>
      /// <param name="km"></param>
      public void Drive(float km)
      {
         if (maxDistanceToDrive <= 0.0F) {
            Console.WriteLine("You cant drive further");
         } else { 
            if (fuelInTank >= fuelConsumption * km) {
               Console.WriteLine($"You drove {km} kilometers");
               fuelInTank -= fuelConsumption * km;
               maxDistanceToDrive -= km;
               DisplayDetails();
            } else {
               Console.WriteLine("Car needs refueling");
               float fuel = 0;
               UserInputValidator.UserInputValidation.ValidateUserInput(ref fuel, "How much liter you want to refuel?");
               Refuel(fuel);
               DisplayDetails();
               Drive(km);
            }
         }
      }

      /// <summary>
      /// Function to refuel the car
      /// </summary>
      /// <param name="fuel"></param>
      public void Refuel(float fuel)
      {
         if (fuel > maxRefuelingAmount) {
            Console.WriteLine("There is not enough fuel available to refuel the car");
         } else {
            fuelInTank = fuel;
            maxRefuelingAmount -= fuel;
         }
      }

   }
}