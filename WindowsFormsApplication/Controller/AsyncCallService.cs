using System;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormApplication.WSClient;

namespace WindowsFormsApplication.Controller
{
    /// <summary>
    /// the class to call service using async method
    /// </summary>
    public class AsyncCallService
    {
        /// <summary>
        /// method to call Fibonacci
        /// </summary>
        /// <param name="n">input value</param>
        /// <param name="busyForm">busyform</param>
        /// <returns>return value</returns>
        public async Task<int> CallFibonacci(int n, BusyForm busyForm)
        {
            CallFibonacciServiceController controller = new CallFibonacciServiceController();
            int result = controller.CallFibonacci(n);
            await Task.Delay(2000);
            if (busyForm != null)
            {
                busyForm.FlagGetResponse = true;
                busyForm.Close();
            }
            return result;
        }
    }
}
