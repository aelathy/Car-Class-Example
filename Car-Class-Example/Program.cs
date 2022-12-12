#nullable disable
Console.Clear();


// Task 2
Car car1 = new Car(2018, "FS", "asasd");
Car car2 = new Car(2222, "SG", "gfhvx");
Car car3 = new Car(0000, "ch", "lkj");

//3
car1.turnOn();
Console.WriteLine($"Running: {car1.Running}");
car1.changeSpeed(50);
Console.WriteLine($"Speed: {car1.Speed}km/hr");
car1.changeSpeed(30);
Console.WriteLine($"Speed: {car1.Speed}km/hr");
car1.changeSpeed(-80);
Console.WriteLine($"Speed: {car1.Speed}km/hr");
car1.turnOff();
Console.WriteLine($"Running: {car1.Running}");



class Car
{
    public int Year { get; set; }
    public string Make { get; set; }
    public string Model { get; set; }
    public bool Running { get; set; }
    public int Speed { get; set; }

    public Car(int year, string make, string model)
    {
        this.Year = year;
        this.Make = make;
        this.Model = model;
        this.Running = false;
        this.Speed = 0;
    }
    public void turnOn()
    {
        this.Running = true;
    }

    public void turnOff()
    {
        this.Running = false;
    }

    public int changeSpeed(int accel)
    {
        return this.Speed += accel;
    }
}
