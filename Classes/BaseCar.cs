using PrototypePattern.Inerfaces;

namespace PrototypePattern.Classes
{
    /// <summary>
    /// Базовый класс для всех автомобилей
    /// </summary>
    public abstract class BaseCar : IMyCloneable<BaseCar>, ICloneable
    {
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }

        public BaseCar(string brand, string model, int year)
        {
            Brand = brand;
            Model = model;
            Year = year;
        }

        public BaseCar Clone()
        {
            return (BaseCar)MemberwiseClone();
        }

        object ICloneable.Clone()
        {
            return Clone();
        }
    }
}
