using System;
using System.Collections.Generic;
using System.Text;
namespace _4._1._1
{
    abstract class Transport
    {

        private bool open;
        private int wheels;
        private int speed;

        public bool Open
        {
            get { return open; }
            set { open = value; }
        }
        public int Wheels
        {
            get { return wheels; }
            set { if (value < 0) Console.WriteLine("Error wheelse"); else wheels = value; }
        }
        public int Speed
        {
            get { return speed; }
            set { if (value < 0) Console.WriteLine("Error speed"); else speed = value; }
        }
        public Transport(int speed)
        {
            this.speed = speed;
        }
    }
    class MotoBike : Transport, ITransport
    {
        public MotoBike(int wheels, int speed) : base(speed)
        {
            Wheels = wheels;
        }
        public void OpenDoor()
        {
            Console.WriteLine("Not door motobike");
        }
        public void CountWheels()
        {
            Console.WriteLine($"Count wheels={Wheels} motobike");
        }
    }
    class Scooter : Transport, ITransport
    {
        public Scooter(int wheels, int speed) : base(speed)
        {
            Wheels = wheels;
        }
        public void OpenDoor()
        {
            Console.WriteLine("Not door scooter");
        }
        public void CountWheels()
        {
            Console.WriteLine($"Count wheels={Wheels} scooter");
        }
    }
    class Car : Transport, ITransport
    {
        public Car(bool open, int wheels, int speed) : base(speed)
        {
            Open = open;
            Wheels = wheels;
        }
        public void OpenDoor()
        {
            if (Open)
            {
                Console.WriteLine("Open door car");
            }
            else
            {
                Console.WriteLine("Close door car");
            }
        }
        public void CountWheels()
        {
            Console.WriteLine($"Count wheels={Wheels} car");
        }
    }
    class Train : Transport, ITransport
    {
        public Train(bool open, int wheels, int speed) : base(speed)
        {
            Open = open;
            Wheels = wheels;
        }
        public void OpenDoor()
        {
            if (Open)
            {
                Console.WriteLine("Open door train");
            }
            else
            {
                Console.WriteLine("Close door train");
            }
        }
        public void CountWheels()
        {
            Console.WriteLine($"Count wheels={Wheels} train");
        }
    }
}



