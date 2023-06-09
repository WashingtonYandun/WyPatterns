namespace WyPatterns.Creational
{
    /// <summary>
    /// Base Singleton class.
    /// </summary>
    /// <typeparam name="T">Type of the singleton instance.</typeparam>
    public abstract class Singleton<T> where T : class
    {
        #region Instance

        private static readonly Lazy<T> instance = new Lazy<T>(() => CreateInstance());

        /// <summary>
        /// Gets the singleton instance.
        /// </summary>
        public static T Instance => instance.Value;

        protected Singleton()
        {
        }
        #endregion

        #region Public Methods
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        private static T CreateInstance()
        {
            return Activator.CreateInstance(typeof(T), nonPublic: true) as T;
        }
        #endregion
    }
}
