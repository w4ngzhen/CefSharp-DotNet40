using System;
using System.Threading.Tasks;

namespace CefSharp.ExHelper
{
    public class TaskHelper
    {
        public static Task<TResult> FromResult<TResult>(TResult result)
        {
            return TaskEx.FromResult(result);
        }

        public static Task Delay(int timeSpan)
        {
            return TaskEx.Delay(timeSpan);
        }

        public static Task Run(Action action)
        {
            return TaskEx.Run(action);
        }
    }
}