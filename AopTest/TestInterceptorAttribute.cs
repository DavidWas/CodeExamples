using Norns.Urd;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AopTest
{
    public class TestInterceptorAttribute : AbstractInterceptorAttribute
    {
        public override async Task InvokeAsync(AspectContext context, AsyncAspectDelegate next)
        {
            Console.WriteLine("This is the interceptor talking!");
            await next(context);
            Console.WriteLine("This is the interceptor talking again!");
        }
    }
}