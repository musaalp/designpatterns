using System;

namespace ChainOfResponsibilityDesignPattern
{
    public class TeamResponsible : RequestPermissionResponsible
    {
        protected override void Approve(object sender, RequestPermissionArgs args)
        {
            Console.WriteLine($"Approved by {this.GetType().Name}");

            NextResponsible?.RequestPermission(args);
        }
    }
}
