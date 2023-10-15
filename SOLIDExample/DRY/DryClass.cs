namespace SOLIDExample.DRY
{
    #region BAD
    public class Car1
    {
        public int Year { set; get; }
        public string Model { set; get; } = string.Empty;
        public string Make { set; get; } = string.Empty;
        public int Type { set; get; }
    }

    public class Truck1
    {
        public int Year { set; get; }
        public string Model { set; get; } = string.Empty;
        public string Make { set; get; } = string.Empty;
        public int Type { set; get; }
    }
    #endregion

    #region GOOD
    public class Vehicle
    {
        public int Year { set; get; }
        public string Model { set; get; } = string.Empty;
        public string Make { set; get; } = string.Empty;
        public int Type { set; get; }
    }
    public class Car : Vehicle
    {
        public int NumDoor { set; get; }
        public string EngineType { set; get; } = string.Empty;
    }
    public class Truck: Vehicle
    {
        public bool HasForWheelDrive { set; get; }
        public double PayloadCapacity { set; get;}
    }
    #endregion
}
