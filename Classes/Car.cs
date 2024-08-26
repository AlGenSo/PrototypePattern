namespace PrototypePattern.Classes
{
    /// <summary>
    /// Промежуточный класс для автомобилей (Первый уровень наследования)
    /// </summary>
    public abstract class Car : BaseCar, ICloneable
    {
        public string Color { get; set; }

        public Car(string brand, string model, int year, string color)
            : base(brand, model, year)
        {
            Color = color;
        }

        public new Car Clone()
        {
            return (Car)MemberwiseClone();
        }

        object ICloneable.Clone()
        {
            return Clone();
        }
    }
}
