using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace MyPolicies.Models
{
    public enum PolicyType
    {
        [Description("Car Policy")]
        Car =1,

        [Description("Motorcycle Policy")]
        Motorcycle = 2,


    }
}
