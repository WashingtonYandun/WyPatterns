namespace WyPatterns.Creational
{
    /// <summary>
    /// Abstract base class for the Prototype pattern.
    /// </summary>
    /// <typeparam name="T">The type of object to clone.</typeparam>
    public abstract class Prototype<T> where T : class
    {
        /// <summary>
        /// Creates a deep copy of the object.
        /// </summary>
        /// <returns>A cloned instance of the object.</returns>
        public abstract T Clone();
    }

    /// <summary>
    /// Concrete implementation of the Prototype pattern.
    /// </summary>
    /// <typeparam name="T">The type of object to clone.</typeparam>
    public class ConcretePrototype<T> : Prototype<T> where T : class, new()
    {
        /// <summary>
        /// Creates a deep copy of the object using a new instance.
        /// </summary>
        /// <returns>A cloned instance of the object.</returns>
        public override T Clone()
        {
            return new T();
        }
    }
}
