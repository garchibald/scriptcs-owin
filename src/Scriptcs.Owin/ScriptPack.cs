using System.Linq;
using ScriptCs.Contracts;

namespace ScriptCs.Owin
{
    public class ScriptPack : IScriptPack
    {
        IScriptPackContext IScriptPack.GetContext()
        {
            return new OwinSelfHost();
        }

        void IScriptPack.Initialize(IScriptPackSession session)
        {
            var namespaces = new[]
                {
                    "Microsoft.Owin.Hosting",
                    "Owin",
                }.ToList();

            namespaces.ForEach(session.ImportNamespace);
        }

        void IScriptPack.Terminate()
        {
        }
    }
}
