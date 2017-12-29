using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleSharpZip
{
    class AttrExt
    {
    }

    public class ValidationResult
    {
    }


    [AttributeUsage(AttributeTargets.Property, AllowMultiple = true)]
    public abstract class ValidationAttribute : Attribute
    {
        public abstract ValidationResult Validate(object value);
    }

    //public class RangeAttribute :RangeAttribute
    //{
    //    public int Max { get; set; }
    //    public int Min { get; set; }
    //    public override ValidationResult Validate(object value)
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
}
