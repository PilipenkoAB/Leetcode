//https://leetcode.com/problems/design-parking-system/
public class ParkingSystem {
    
    private int[] slot = new int[3];
    
    public ParkingSystem(int big, int medium, int small) {  
        slot[0] = big;
        slot[1] = medium;
        slot[2] = small;
    }
    
    public bool AddCar(int carType) {
        
        return --slot[carType - 1] >= 0;
    }
}

/**
 * Your ParkingSystem object will be instantiated and called as such:
 * ParkingSystem obj = new ParkingSystem(big, medium, small);
 * bool param_1 = obj.AddCar(carType);
 */