using System;
using System.Collections.Generic;
using System.Text;

namespace WorkerServiceApp
{
    public class TestService : ITestService
    {
        public string Message()
        {
            return "Print Message Method";
        }
    }
}
