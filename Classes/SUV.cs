namespace PrototypePattern.Classes
{
    /// <summary>
    /// Класс для внедорожников (Второй уровень наследования)
    /// </summary>
    public class SUV : Car, ICloneable
    {
        public bool HasFourWheelDrive { get; set; }

        public SUV(string brand, string model, int year, string color, bool hasFourWheelDrive)
            : base(brand, model, year, color)
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
