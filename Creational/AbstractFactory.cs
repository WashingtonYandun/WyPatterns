using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WyPatterns.Creational
{
    /// <summary>
    /// Interfaz que define el método para crear objetos de tipo T.
    /// </summary>
    /// <typeparam name="T">Tipo de objeto a crear.</typeparam>
    public interface IAbstractFactory<T>
    {
        T Create();
    }

    /// <summary>
    /// Fábrica concreta que implementa la interfaz IAbstractFactory para crear objetos de tipo T.
    /// </summary>
    /// <typeparam name="T">Tipo de objeto a crear.</typeparam>
    public class ConcreteAbstractFactory<T> : IAbstractFactory<T> where T : new()
    {
        /// <summary>
        /// Crea y devuelve un objeto de tipo T.
        /// </summary>
        /// <returns>Objeto de tipo T.</returns>
        public T Create()
        {
            return new T();
        }
    }

}
