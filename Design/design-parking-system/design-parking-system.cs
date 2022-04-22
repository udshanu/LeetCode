public class ParkingSystem {

    public ParkingSystem(int big, int medium, int small) {
        this.Big = big;
        this.Medium = medium;
        this.Small = small;
    }
    
    public int Big { get; set; }
    public int Medium { get; set; }
    public int Small { get; set; }
    
    public bool AddCar(int carType) {
        if (carType == 1) //Big
        {
            if (this.Big > 0)
            {
                this.Big--;
                return true;
            }

            return false;
        }
        else if (carType == 2) //Medium
        {
            if (this.Medium > 0)
            {
                this.Medium--;
                return true;
            }

            return false;
        }
        else if (carType == 3) //Small
        {
            if (this.Small > 0)
            {
                this.Small--;
                return true;
            }

            return false;
        }

        return false;
    }
}

/**
 * Your ParkingSystem object will be instantiated and called as such:
 * ParkingSystem obj = new ParkingSystem(big, medium, small);
 * bool param_1 = obj.AddCar(carType);
 */
