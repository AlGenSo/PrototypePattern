namespace PrototypePattern.Classes
{
    /// <summary>
    /// Класс для спортивных автомобилей (Второй уровень наследования)
    /// </summary>
    public class SportsCar : Car, ICloneable
    {
        public int MaxSpeed { get; set; }

        public SportsCar(string brand, string model, int year, string color, int maxSpeed)
            : base(brand, model, year, color)
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
