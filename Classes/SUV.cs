namespace PrototypePattern.Classes
{
    /// <summary>
    /// Класс для внедорожников
    /// </summary>
    public class SUV : BaseCar, ICloneable
    {
        public bool HasFourWheelDrive { get; set; }

        public SUV(string brand, string model, int year, bool hasFourWheelDrive)
            : base(brand, model, year)
        {
            HasFourWheelDrive = hasFourWheelDrive;
        }

        public new SUV Clone()
        {
            return (SUV)MemberwiseClone();
        }

        object ICloneable.Clone()
        {
            return Clone();
        }
    }
}
