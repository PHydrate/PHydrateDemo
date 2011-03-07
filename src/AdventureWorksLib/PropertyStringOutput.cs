using System.Reflection;
using System.Text;

namespace AdventureWorksLib
{
    public class PropertyStringOutput
    {
        public override string ToString()
        {
            var sb = new StringBuilder();

            foreach (PropertyInfo pi in GetType().GetProperties())
            {
                sb.AppendFormat(pi.PropertyType.IsValueType || pi.PropertyType.Name == "String" ? "{0} = {1}\n" : "{0} = {{\n{1}\n}}\n", pi.Name,
                                pi.GetValue(this, BindingFlags.Instance | BindingFlags.Public | BindingFlags.NonPublic,
                                            null, null, null));
            }

            return sb.ToString();
        }
    }
}