using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarkG1968.RomanNumeralKata.Support
{
    [AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
    class TestInputAttribute: Attribute
    {
        public TestInputAttribute(params object[] parameters)
        {
            Parameters = parameters;
        }
 
        public object[] Parameters { get; private set; }
    }
}
