using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Server.WebServiceController
{
    /// <summary>
    /// Controller for the service Fibonacci
    /// </summary>
    public class FibonacciServiceController
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(FibonacciServiceController));
        /// <summary>
        /// service of Fibonacci
        /// </summary>
        /// <param name="n">input value</param>
        /// <returns>return value</returns>
        public int Fibonacci(int n)
        {
            log.Info("call Fibonacci with value n => "+n);
            if (n >= 1 && n <= 100)
            {
                if (n == 1 || n == 2)
                    return 1;
                if(n > 2)
                {
                    int returnValue = Fibonacci(n - 1) + Fibonacci(n - 2);
                    return returnValue;
                }
            }
            return -1;
        }
    }
}
