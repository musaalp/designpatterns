using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateMethodDesignPattern
{
    public class AuditTrail
    {
        public void Record()
        {
            Console.WriteLine("Audit");
        }
    }
}
