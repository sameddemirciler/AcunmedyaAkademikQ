using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Custom_Attribute_Ödevi.Attributes
{
    [AttributeUsage(AttributeTargets.Property, AllowMultiple = false)] 
    public class RequiredFieldAttribute : Attribute
    {
        public string ErrorMessage { get; set; } 

        public RequiredFieldAttribute(string errorMessage)
        {
            ErrorMessage = errorMessage; 
        }
    }
}
