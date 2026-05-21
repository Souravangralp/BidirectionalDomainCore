namespace Bidirectional.DomainCore.BidOnboard.Entities.Assets;

public class MotorVehicleAsset : BaseAsset
{
    public int MotorVehicleAsset_UserID { get; set; }

    public int? VehicleType_CoreDB_GeneralLookUpID { get; set; } // Car, Motorcycle, Truck

    public string? OtherVehicleType { get; set; }

    public string? Brand { get; set; } // e.g., Toyota, Ford

    public string? Model { get; set; } // e.g., Camry, Civic

    public int Year { get; set; } // e.g., 2020, 2021

    public string? VIN { get; set; } // Vehicle Identification Number

    public DateOnly? PurchaseDate { get; set; }

    public double PurchasePrice { get; set; }

    public bool ISFinanced { get; set; }

    public bool ISUsedForBusiness { get; set; }

    public User? MotorVehicleAsset_User { get; set; }
}
