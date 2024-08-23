// Программа для демонстрации функции клонирования
using PrototypePattern.Classes;

class Program
{
    static void Main()
    {
        Sedan sedan = new Sedan("Toyota", "Camry", 2020, 4);
        Sedan clonedSedan = sedan.Clone();
        Console.WriteLine($"Original Sedan: {sedan.Brand} {sedan.Model} {sedan.Year} {sedan.NumberOfDoors}");
        Console.WriteLine($"Cloned Sedan: {clonedSedan.Brand} {clonedSedan.Model} {clonedSedan.Year} {clonedSedan.NumberOfDoors}");

        SUV suv = new SUV("Jeep", "Wrangler", 2021, true);
        SUV clonedSUV = suv.Clone();
        Console.WriteLine($"Original SUV: {suv.Brand} {suv.Model} {suv.Year} {suv.HasFourWheelDrive}");
        Console.WriteLine($"Cloned SUV: {clonedSUV.Brand} {clonedSUV.Model} {clonedSUV.Year} {clonedSUV.HasFourWheelDrive}");

        SportsCar sportsCar = new SportsCar("Ferrari", "F8", 2022, 340);
        SportsCar clonedSportsCar = sportsCar.Clone();
        Console.WriteLine($"Original SportsCar: {sportsCar.Brand} {sportsCar.Model} {sportsCar.Year} {sportsCar.MaxSpeed}");
        Console.WriteLine($"Cloned SportsCar: {clonedSportsCar.Brand} {clonedSportsCar.Model} {clonedSportsCar.Year} {clonedSportsCar.MaxSpeed}");
    }
}
