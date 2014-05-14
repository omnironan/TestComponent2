using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using TestComponent1;

namespace TestComponent2
{
    public class Class1
    {
        public string GetName()
        {
            //Take advatange of the dependency on TestComponent1 nuget package
            var shape = new MyShape("Test Name");
            shape.ChangeName("New Name");

            return shape.Name;
        }
    }
}
