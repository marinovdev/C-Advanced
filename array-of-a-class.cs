using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

public class Car
{
    private  string make = "";
    private  string model;
    private  int year;
    private double fuelQuantity;
    private double fuelConsumption;
    private Engine engine;
    private Tire[] tires;
    public  string Make
    {
        get
        {
            return make;
        }
        set
        {
            make = value;
        }
    }
    public string Model
    {
        get
        {
            return model;
        }
        set
        {
            model = value;
        }
    }
    public int Year
    {
        get
        {
            return year;
        }
        set
        {
            year = value;
        }
    }

    public Car(string make, string model, int year, double fuelQuantity,
       double fuelConsumption, Engine engine, Tire[] tires)
       : this(make, model, year, fuelQuantity,
        fuelConsumption)
    {
        this.Engine = engine;
        this.Tires = tires;
    }
    public Car(string make, string model, int year, double fuelQuantity, double fuelConsumption)
    {
        this.Make = make;
        this.Model = model;
        this.Year = year;
        this.FuelQuantity = fuelQuantity;
        this.FuelConsumption = fuelConsumption;
    }
   
    public double FuelQuantity { get =>   fuelQuantity;  set => fuelQuantity = value; }
    public double FuelConsumption { get => fuelConsumption; set => fuelConsumption = value; }
    public Engine Engine { get => engine; set => engine = value; }
    public Tire[] Tires { get => tires; set => tires = value; }
}
public class Engine
{
    private int horsePower;
    private double cubicCapacity;


    public int HorsePower { get { return horsePower; } set { horsePower = value; } }
    public double CubicCapacity { get { return cubicCapacity; } set { cubicCapacity = value; } }
    public Engine(int horsePower, double cubicCapacity)
    {
        this.HorsePower = horsePower;
        this.CubicCapacity = cubicCapacity;
    }
}
public class Tire
{
    private int year;
    private double pressure;

    public int Year { get; set; }
    public double  Pressure { get; set; }

    public Tire(int year, double pressure)
    {
        this.Year = year;
        this.Pressure = pressure;
    }
}

class startsWithFilterFunc
{

    static void Main()
    {
        var tires = new Tire[4]
        {
            new Tire(1, 2.5),
            new Tire(1, 2.5),
            new Tire(1, 2.5),
            new Tire(1, 2.5),
        };
        var engine = new Engine(4, 90);
        Car car1 = new Car("Toyota", "L50", 2010, 99.9, 20, engine, tires);
    }
}

