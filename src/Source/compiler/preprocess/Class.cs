using Microsoft.Framework.Runtime;
using Reference;

namespace Source
{
    public class Class : Foo, ICompileModule
    {
        public void BeforeCompile(IBeforeCompileContext context)
        {
            Bar();
        }
        
        public void AfterCompile(IAfterCompileContext context)
        {
        }
    }
}
