using Microsoft.Framework.Runtime;
using Reference;

namespace Source
{
    public class Class : ICompileModule
    {
        public void BeforeCompile(IBeforeCompileContext context)
        {
            var foo = new Foo();
            foo.Bar();
        }
        
        public void AfterCompile(IAfterCompileContext context)
        {
        }
    }
}
