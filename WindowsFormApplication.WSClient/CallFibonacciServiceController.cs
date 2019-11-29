using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormApplication.WSClient
{
    /// <summary>
    /// controller to call web service
    /// </summary>
    public class CallFibonacciServiceController
    {
        /// <summary>
        /// Call Fibonacci service method
        /// </summary>
        /// <param name="n">input value</param>
        /// <returns>result value</returns>
        public int CallFibonacci(int n)
        {
            localhost.WebService1 webservice1 = new localhost.WebService1();
            int result = webservice1.Fibonacci(n);
            return result;
        }
    }
}
