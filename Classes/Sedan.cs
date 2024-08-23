namespace PrototypePattern.Classes
{
    /// <summary>
    /// Класс для седанов
    /// </summary>
    public class Sedan : BaseCar, ICloneable
    {
        public int NumberOfDoors { get; set; }

        public Sedan(string brand, string model, int year, int numberOfDoors)
            : base(brand, model, year)
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
