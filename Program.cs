// Программа для демонстрации функции клонирования
using PrototypePattern.Classes;

class Program
{
    static void Main()
    {
        /// Создание и клонирование седана
        Console.WriteLine("Создание и клонирование седана");
        Sedan sedan = new("Toyota", "Camry", 2020, "Red", 4);
        Sedan clonedSedan = sedan.Clone();
        Console.WriteLine($"Original Sedan: Brand: {sedan.Brand}, Model: {sedan.Model}, Year: {sedan.Year}, Color: {sedan.Color}, NumberOfDoors: {sedan.NumberOfDoors}");
        Console.WriteLine($"Cloned Sedan: Brand: {clonedSedan.Brand}, Model: {clonedSedan.Model}, Year: {clonedSedan.Year}, Color: {clonedSedan.Color}, NumberOfDoors: {clonedSedan.NumberOfDoors}");

        /// Изменение свойства у клонированного объекта
        Console.WriteLine("Изменение свойства у клонированного объекта");
        clonedSedan.Color = "Blue";
        Console.WriteLine($"After change, Original Sedan: Brand: {sedan.Brand}, Model: {sedan.Model}, Year: {sedan.Year}, Color: {sedan.Color}, NumberOfDoors: {sedan.NumberOfDoors}");
        Console.WriteLine($"After change, Cloned Sedan: Brand: {clonedSedan.Brand}, Model: {clonedSedan.Model}, Year: {clonedSedan.Year}, Color: {clonedSedan.Color}, NumberOfDoors: {clonedSedan.NumberOfDoors}\r\n");

        /// Создание и клонирование внедорожника
        Console.WriteLine("Создание и клонирование внедорожника");
        SUV suv = new("Jeep", "Wrangler", 2021, "Green", true);
        SUV clonedSUV = suv.Clone();
        Console.WriteLine($"Original SUV: Brand: {suv.Brand}, Model: {suv.Model}, Year: {suv.Year}, Color: {suv.Color}, HasFourWheelDrive: {suv.HasFourWheelDrive}");
        Console.WriteLine($"Cloned SUV: Brand: {clonedSUV.Brand}, Model: {clonedSUV.Model}, Year: {clonedSUV.Year}, Color: {clonedSUV.Color}, HasFourWheelDrive: {clonedSUV.HasFourWheelDrive}");

        /// Изменение свойства у клонированного объекта
        Console.WriteLine("Изменение свойства у клонированного объекта");
        clonedSUV.HasFourWheelDrive = false;
        Console.WriteLine($"After change, Original SUV: Brand: {suv.Brand}, Model: {suv.Model}, Year: {suv.Year}, Color: {suv.Color}, HasFourWheelDrive: {suv.HasFourWheelDrive}");
        Console.WriteLine($"After change, Cloned SUV: Brand: {clonedSUV.Brand}, Model: {clonedSUV.Model}, Year: {clonedSUV.Year}, Color: {clonedSUV.Color}, HasFourWheelDrive: {clonedSUV.HasFourWheelDrive}\r\n");

        /// Создание и клонирование спортивного автомобиля
        Console.WriteLine("Создание и клонирование спортивного автомобиля");
        SportsCar sportsCar = new("Ferrari", "F8", 2022, "Yellow", 340);
        SportsCar clonedSportsCar = sportsCar.Clone();
        Console.WriteLine($"Original SportsCar: Brand: {sportsCar.Brand}, Model: {sportsCar.Model}, Year: {sportsCar.Year}, Color: {sportsCar.Color}, MaxSpeed: {sportsCar.MaxSpeed}");
        Console.WriteLine($"Cloned SportsCar: Brand: {clonedSportsCar.Brand}, Model: {clonedSportsCar.Model}, Year: {clonedSportsCar.Year}, Color: {sportsCar.Color}, MaxSpeed: {clonedSportsCar.MaxSpeed}");

        /// Изменение свойства у клонированного объекта
        Console.WriteLine("Изменение свойства у клонированного объекта");
        clonedSportsCar.MaxSpeed = 350;
        Console.WriteLine($"After change, Original SportsCar: Brand: {sportsCar.Brand}, Model: {sportsCar.Model}, Year: {sportsCar.Year}, Color: {sportsCar.Color}, MaxSpeed: {sportsCar.MaxSpeed}");
        Console.WriteLine($"After change, Cloned SportsCar: Brand: {clonedSportsCar.Brand}, Model: {clonedSportsCar.Model}, Year: {clonedSportsCar.Year}, Color: {clonedSportsCar.Color}, MaxSpeed: {clonedSportsCar.MaxSpeed}");
    }
}
