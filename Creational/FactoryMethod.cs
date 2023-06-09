namespace WyPatterns.Creational
{
    /// <summary>
    /// Abstract base class for the Creator pattern.
    /// </summary>
    /// <typeparam name="T">The type of object to create.</typeparam>
    public abstract class Creator<T> where T : class
    {
        /// <summary>
        /// Creates a new instance of the object.
        /// </summary>
        /// <returns>A new instance of the object.</returns>
        public abstract T Create();
    }

    /// <summary>
    /// Concrete implementation of the Creator pattern.
    /// </summary>
    /// <typeparam name="T">The type of object to create.</typeparam>
    public class ConcreteCreator<T> : Creator<T> where T : class, new()
    {
        /// <summary>
        /// Creates a new instance of the object using the new operator.
        /// </summary>
        /// <returns>A new instance of the object.</returns>
        public override T Create()
        {
            return new T();
        }
    }
}
