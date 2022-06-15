using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    public static class TypeConversion
    {
        public static TResult Coversion<T, TResult>(T model) where TResult : class, new()
        {
            TResult result = new TResult();
            typeof(T).GetProperties().ToList().ForEach(o =>
            {

                PropertyInfo prop = typeof(TResult).GetProperty(o.Name);
                if (prop != null) prop.SetValue(result, o.GetValue(model));

            });
            return result;
        }
    }
}
