using System;

namespace _4._1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            MotoBike mb = new MotoBike(2, 100);
            Scooter sc = new Scooter(2, 50);
            Car c = new Car(true, 4, 200);
            Train t = new Train(false, 20, 70);
        
        mb.OpenDoor();
        sc.OpenDoor();
        c.OpenDoor();
        t.OpenDoor();
        mb.CountWheels();
        sc.CountWheels();
        c.CountWheels();
        t.CountWheels();
        }
    }
}
