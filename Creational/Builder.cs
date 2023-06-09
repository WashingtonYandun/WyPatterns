using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WyPatterns.Creational
{
    /// <summary>
    /// Builder class for constructing objects of type T.
    /// </summary>
    /// <typeparam name="T">The type of object to be constructed.</typeparam>
    public class Builder<T> where T : class, new()
    {
        #region Fields

        private readonly T instance;

        #endregion

        #region Constructor

        /// <summary>
        /// Initializes a new instance of the BaseBuilder class.
        /// </summary>
        public Builder()
        {
            instance = new T();
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// Applies an action to the instance of T.
        /// </summary>
        /// <param name="action">The action to be applied.</param>
        /// <returns>The current BaseBuilder instance.</returns>
        public Builder<T> With(Action<T> action)
        {
            action?.Invoke(instance);
            return this;
        }

        /// <summary>
        /// Builds and returns the constructed object of type T.
        /// </summary>
        /// <returns>The constructed object of type T.</returns>
        public T Build()
        {
            return instance;
        }

        #endregion
    }
}
