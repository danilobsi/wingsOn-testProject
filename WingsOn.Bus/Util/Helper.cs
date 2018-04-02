using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WingsOn.Bus.Util
{
    public class Helper
    {
        /// <summary>
        /// Executes func and executes finally after that. In case of error, logs it and then executes finally
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <param name="func">Method to be executed</param>
        /// <param name="finallyFunc">Finally method</param>
        /// <returns></returns>
        public static T RunMethod<T>(Func<T> func, Func<T> finallyFunc = null)
        {
            try
            {
                return func();
            }
            catch(Exception e)
            {
                //TODO: Log error


                throw new ExecutionException { InitialException = e };
            }
            finally
            {
                finallyFunc?.Invoke();
            }
        }

        public class ExecutionException : Exception
        {
            public Exception InitialException { get; set; }
        }
    }
}
