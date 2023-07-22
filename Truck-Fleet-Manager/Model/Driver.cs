using System;
namespace Truck_Fleet_Manager.Model
{
	public class Driver
	{
		public int DriverID { get; set; }
		public required string DriverFirstName { get; set; }
		public required string DriverLastName { get; set; }
        public required string LicenseNumber { get; set; }
        public required string ContactNumber { get; set; }

        public int? TruckId { get; set; }
        public virtual Truck? Truck { get; set; }

	}
}

