using System;

namespace ChainOfResponsibility
{
    class DepartmentResponsible : RequestPermissionResponsible
    {
        protected override void Approve(object sender, RequestPermissionArgs args)
        {
            Console.WriteLine($"Approved by {this.GetType().Name}");

            NextResponsible?.RequestPermission(args);
        }
    }
}
