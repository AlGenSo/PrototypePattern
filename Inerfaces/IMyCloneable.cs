namespace PrototypePattern.Inerfaces
{
    /// <summary>
    /// Пользовательский интерфейс для клонирования
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public interface IMyCloneable<T>
    {
        T Clone();
    }
}
