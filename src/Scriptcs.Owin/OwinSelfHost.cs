using System;
using Microsoft.Owin.Hosting;
using ScriptCs.Contracts;

namespace ScriptCs.Owin
{
    public class OwinSelfHost : IScriptPackContext
    {
        /// <summary>
        /// Creates a new self hosted OWIN server
        /// </summary>
        /// <param name="baseAddress">The base address to use for the OWIN pipeline</param>
        /// <param name="startup">Optional components to be used in the OWIN pipline</param>
        /// <returns>A disposable instance of the server</returns>
        public static IDisposable CreateServer(string baseAddress, params IOwinStartup[] startup)
        {
            return WebApp.Start(baseAddress, ab =>
            {
                if (startup == null)
                {
                    return;
                }

                foreach (var action in startup)
                {
                    action.Use(ab);
                }
            });
        }
    }
}