using System.Collections.Generic;
using System.Linq;
using Fixie;
using System.Reflection;
using MarkG1968.RomanNumeralKata.Support;

namespace MarkG1968.RomanNumeralKata
{
    public class CustomConvention : Convention
    {
        public CustomConvention()
        {
            Classes
                .NameEndsWith("Tests");

            Methods
                .Where(method => method.IsVoid());

            Parameters
                .Add<FromInputAttributes>();
        }

        class FromInputAttributes : ParameterSource
        {
            public IEnumerable<object[]> GetParameters(MethodInfo method)
            {
                return method.GetCustomAttributes<TestInputAttribute>(true).Select(input => input.Parameters);
            }
        }
    }
}
