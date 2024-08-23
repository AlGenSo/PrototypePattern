namespace PrototypePattern.Classes
{
    /// <summary>
    /// Класс для спортивных автомобилей
    /// </summary>
    public class SportsCar : BaseCar, ICloneable
    {
        public int MaxSpeed { get; set; }

        public SportsCar(string brand, string model, int year, int maxSpeed)
            : base(brand, model, year)
        {
            MaxSpeed = maxSpeed;
        }

        public new SportsCar Clone()
        {
            return (SportsCar)MemberwiseClone();
        }

        object ICloneable.Clone()
        {
            return Clone();
        }
    }
}
