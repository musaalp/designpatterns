using System;

namespace ChainOfResponsibilityDesignPattern
{
    class HumanResourceResponsible : RequestPermissionResponsible
    {
        protected override void Approve(object sender, RequestPermissionArgs args)
        {
            Console.WriteLine($"Approved by {this.GetType().Name}");

            NextResponsible?.RequestPermission(args);
        }
    }
}
