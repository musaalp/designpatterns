using System;

namespace ChainOfResponsibilityDesignPattern
{
    public class RequestPermissionArgs
    {
        public int Days { get; set; }
        public string Department { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }
    }
}
