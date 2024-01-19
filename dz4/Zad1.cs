using System;
using System.Collections.Generic;
/*Radi se o obrascu metoda tvornica*/
namespace Zad1
{
    public abstract class Car{
        public abstract void Drive();
    }
    public class Ford : Car{
        public Ford(){Drive();}
        public override void Drive(){
            Console.WriteLine("Ford Drives! Wroom Wroom");
        }
    }
    public class Hyundai : Car{
        public Hyundai(){Drive();}
        public override void Drive(){
            Console.WriteLine("Hyundai Drives! Women Beware!");
        }
    }
    public abstract class CarFactory{
        public abstract Car CreateCar();

    }
    public class FordFactory : CarFactory{
        public override Car CreateCar(){
            return new Ford();
        }
    }

    public class HyundaiFactory : CarFactory{
        public override Car CreateCar(){
            return new Hyundai();
        }
    }
    public class Wroom{
        Car car;
        public void DriveCar(CarFactory factory){
            car= factory.CreateCar();
        }
    }
    public class App
    {
        Wroom wroom= new Wroom();

        public void Run()
        {
         wroom.DriveCar(new FordFactory());
         wroom.DriveCar(new HyundaiFactory());
        }
    }
    class Program
    {
        static void Main()
        {
            App app = new App();
            app.Run();
        }
    }
}