using System;

namespace Orders
{
    public static class Maybe
    {
        public static TResult With<TInput, TResult>(this TInput o, Func<TInput, TResult> evaluator)
            where TInput:class
            where TResult:class
        {
            return o == null ? null : evaluator(o);
        }

        public static TResult Return<TInput, TResult>(this TInput o, Func<TInput, TResult> evaluator, TResult faultResult)
            where TInput : class
        {
            return o == null ? faultResult : evaluator(o);
        }

        public static void Do<TInput>(this TInput o, Action<TInput> evaluator)
        {
            if (o == null) return;
            evaluator(o);
        }
    }
}
