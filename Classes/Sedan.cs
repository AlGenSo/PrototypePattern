namespace PrototypePattern.Classes
{
    /// <summary>
    /// Класс для седанов (Второй уровень наследования)
    /// </summary>
    public class Sedan : Car, ICloneable
    {
        public int NumberOfDoors { get; set; }

        public Sedan(string brand, string model, int year, string color, int numberOfDoors)
            : base(brand, model, year, color)
        {
            NumberOfDoors = numberOfDoors;
        }

        public new Sedan Clone()
        {
            return (Sedan)MemberwiseClone();
        }

        object ICloneable.Clone()
        {
            return Clone();
        }
    }
}
