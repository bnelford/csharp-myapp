using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace myLibrary
{
    [XmlRoot("calc", Namespace="urn:foo")]
    public class Calculator
    {
        public double Sum { get; set; }
        public static int UsageCount { get; private set; }

        static Calculator()
        {
            Console.WriteLine("Static ctor fired");
        }


        public void Add(double a)
        {
            ++UsageCount;
            this.Sum += a;
        }

    }
}
