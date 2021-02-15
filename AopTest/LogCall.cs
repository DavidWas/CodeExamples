using System;
using AspectInjector.Broker;

namespace AopTest
{
    [Aspect(Scope.Global)]
    [Injection(typeof(LogCall))]
    public class LogCall : Attribute
    {
        [Advice(Kind.Around)]
        public object Log([Argument(Source.Name)] string name,
            [Argument(Source.Target)] Func<object[], object> methodDelegate, [Argument(Source.Arguments)] object[] args)
        {
            Console.WriteLine($"Called {name}.");
            var result = methodDelegate(args);
            Console.WriteLine($"Finished...");
            return result;
        }
    }
}