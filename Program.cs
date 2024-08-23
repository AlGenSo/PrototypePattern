// Программа для демонстрации функции клонирования
using PrototypePattern.Classes;

class Program
{
    static void Main()
    {
        Sedan sedan = new("Toyota", "Camry", 2020, 4);
        Sedan clonedSedan = sedan.Clone();
        Console.WriteLine($"Original Sedan: Brand: {sedan.Brand},  Model: {sedan.Model}, Year: {sedan.Year}, NumberOfDoors: {sedan.NumberOfDoors}");
        Console.WriteLine($"Cloned Sedan: Brand: {clonedSedan.Brand},  Model: {clonedSedan.Model}, Year: {clonedSedan.Year}, NumberOfDoors: {clonedSedan.NumberOfDoors}");

        SUV suv = new("Jeep", "Wrangler", 2021, true);
        SUV clonedSUV = suv.Clone();
        Console.WriteLine($"Original SUV: Brand: {suv.Brand},  Model: {suv.Model}, Year: {suv.Year}, HasFourWheelDrive: {suv.HasFourWheelDrive}");
        Console.WriteLine($"Cloned SUV: Brand: {clonedSUV.Brand},  Model: {clonedSUV.Model}, Year: {clonedSUV.Year}, HasFourWheelDrive: {clonedSUV.HasFourWheelDrive}");

        SportsCar sportsCar = new("Ferrari", "F8", 2022, 340);
        SportsCar clonedSportsCar = sportsCar.Clone();
        Console.WriteLine($"Original SportsCar: Brand: {sportsCar.Brand},  Model: {sportsCar.Model}, Year: {sportsCar.Year}, MaxSpeed: {sportsCar.MaxSpeed}");
        Console.WriteLine($"Cloned SportsCar: Brand: {clonedSportsCar.Brand},  Model: {clonedSportsCar.Model}, Year: {clonedSportsCar.Year}, MaxSpeed: {clonedSportsCar.MaxSpeed}");
    }
}
