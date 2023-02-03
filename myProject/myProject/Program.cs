using System;
using static System.Console;

namespace myProject
{
    class carSales
    {
        static void Main(string[] args)
        {
            cars carOne= new cars(10,"Ferrari","Testarossa",200000);
            cars carTwo = new cars(20, "Lamborghini", "Aventador", 400000);
            cars carThree = new cars();
            cars carFour = new cars();
            WriteLine("Please enter the Id for the new inventory: ");
            carThree.setCarID(int.Parse(ReadLine()));
            WriteLine("Please enter the car make for the new inventory: ");
            carThree.setCarMake(ReadLine());
            WriteLine("Please enter the model for the new inventory: ");
            carThree.setCarModel(ReadLine());
            WriteLine("Please enter the sale price of the new inventory: ");
            carThree.setCarPrice(double.Parse(ReadLine()));
            WriteLine();
            WriteLine("Please enter the Id for the new inventory: ");
            carFour.setCarID(int.Parse(ReadLine()));
            WriteLine("Please enter the car make for the new inventory: ");
            carFour.setCarMake(ReadLine());
            WriteLine("Please enter the model for the new inventory: ");
            carFour.setCarModel(ReadLine());
            WriteLine("Please enter the sale price of the new inventory: ");
            carFour.setCarPrice(double.Parse(ReadLine()));

            WriteLine($"ID:{carOne.getCarID()} Make:{carOne.getCarMake()} Model:{carOne.getModel()} Price:{carOne.getCarPrice()}");
            WriteLine($"ID:{carTwo.getCarID()} Make:{carTwo.getCarMake()} Model:{carTwo.getModel()} Price:{carTwo.getCarPrice()}");
            WriteLine($"ID:{carThree.getCarID()} Make:{carThree.getCarMake()}  Model:{carThree.getModel()}  Price:{carThree.getCarPrice()}");
            WriteLine($"ID:{carFour.getCarID()} Make:{carFour.getCarMake()}  Model:{carFour.getModel()}  Price:{carFour.getCarPrice()}");
        }
    }
}
class cars
{
    private int _carID;
    private string _carMake;
    private string _carModel;
    private double _carPrice;

    public cars() 
    {
        _carID = 0;
        _carMake = "";
        _carModel = "";
        _carPrice= 0;
    }
    public cars(int carID, string carMake, string carModel, double carPrice) 
    {
        _carID = carID;
        _carMake = carMake;
        _carModel = carModel;
        _carPrice = carPrice;
    }

    public void setCarID(int carID) { _carID = carID; }
    public int getCarID() { return _carID;}
    public void setCarMake(string carMake) { _carMake = carMake; }
    public string getCarMake() { return _carMake;}
    public void setCarModel(string carModel) { _carModel = carModel; }
    public string getModel() { return _carModel; }
    public void setCarPrice(double price) { _carPrice = price;}
    public double getCarPrice() { return _carPrice; }
}