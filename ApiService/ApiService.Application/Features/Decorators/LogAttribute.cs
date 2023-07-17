using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApiService.Application.Features.Decorators;

[AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = true)]
public class LogAttribute : Attribute
{
    public LogAttribute()
    {
        
    }
}
