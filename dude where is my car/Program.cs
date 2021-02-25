using System;

namespace dude_where_is_my_car
{
    class Program
    {
        /*
         * Create a class Car
The car has a mark name (string), model name (string), registration number (string, no longer than six characters), color (string), odometer (int) and fuel tank (int)
The odometer value equals 0 by default.
The fuel tank value by default is 60.
No car characteristics can be changed after the car object has been created.*
All the car characteristics can be accessed using ‘.’ (E.g. newCar.Model);
The car can drive. Every lap the car passes increases the value of the odometer by 100 and decreases the value of the fuel tank by 5 .
*/
        static void Main(string[] args)
        {
            Car car = new Car("vw", "polo", "konnff", "blue");
            car.Showcar();
            
            car.TankEmpty();
            car.Showcar();

        }
    }
}
