using System;
using System.Collections.Generic;
using System.Text;

namespace InterfacesAndPolymorphism
{
   /// <summary>
   /// Class for vehicle object
   /// </summary>
   public class Vehicle
   {
      protected float fuelQuantity;    //how much can fit in the car
      protected float fuelInTank;      //how much fuel is in the tank currently
      protected float fuelConsumption;    //in liters per km
      protected float maxDistanceToDrive;
      protected float maxRefuelingAmount;    //how much fuel you have to spare

      public Vehicle(float fuelQuantity, float fuelConsumption, float maxDistanceToDrive)
      {
         this.fuelQuantity = fuelQuantity;
         this.fuelConsumption = fuelConsumption;
         this.maxDistanceToDrive = maxDistanceToDrive;
      }
     
      /// <summary>
      /// Method for displaying vehicle details
      /// </summary>
      public void DisplayDetails()
      {
         Console.WriteLine($"Fuel quantity: {fuelQuantity}, Fuel in tank: {fuelInTank}, Fuel consumption: {fuelConsumption}, MaxDistanceToDrive: {maxDistanceToDrive}, MaxRefuelingAmount: {maxRefuelingAmount} ");
      }
   }
}
