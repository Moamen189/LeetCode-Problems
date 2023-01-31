public class ParkingSystem {

   public int[] CarSpace { get; set; } = new int[3];

    public ParkingSystem(int big, int medium, int small) {
        CarSpace[0] = big;
        CarSpace[1] = medium;
        CarSpace[2] = small;
    }
    
    public bool AddCar(int carType) {
        var isAvailable = false;

        if (CarSpace[carType - 1] > 0) 
            isAvailable = true;
            
        CarSpace[carType - 1]--;

        return isAvailable;
    }
}

/**
 * Your ParkingSystem object will be instantiated and called as such:
 * ParkingSystem obj = new ParkingSystem(big, medium, small);
 * bool param_1 = obj.AddCar(carType);
 */