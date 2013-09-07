using Owin;

namespace ScriptCs.Owin
{
    /// <summary>
    /// Common interface to allow OWIN components to be setup in the start of a OWIN middleware
    /// </summary>
    public interface IOwinStartup
    {
        /// <summary>
        /// Provides an instance of the <seealso cref="IAppBuilder"/> to use the component on
        /// </summary>
        /// <param name="app">The application builder instance provides by startup</param>
        void Use(IAppBuilder app);
    }
}
