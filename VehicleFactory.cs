using System;

public static class VehicleFactory
{
	public static IVehicle GetVehicle(int wheel count)
	{
	     switch (wheelCount)
		{
			case 2:
				return new Motorcycle();
				case 3:
				return new ThreeWheeler();
			case 4:
				return new Car();
				default:
				return new Car();
		}
		    var vehicle = VehicleFactory.GetVehicle(numOfWheels);
		vehicle.Drive();
				
				
	}
}
