using System;
namespace Truck_Fleet_Manager.Model
{
    // Truck.cs (Model)
    public class Truck
    {
        public int TruckId { get; set; }
        public required string TruckNumber { get; set; }
        public required string Model { get; set; }
        public int Capacity { get; set; }
        public int Mileage { get; set; }
        public required string Status { get; set; }

        // Add a foreign key property for the associated Driver
        public int? DriverId { get; set; }
        // Navigation property representing the associated Driver (one-to-one)
        public virtual Driver? Driver { get; set; }
    }

}

