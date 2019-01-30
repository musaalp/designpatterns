using System;

namespace ChainOfResponsibilityDesignPattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var teamResponsible = new TeamResponsible();
            var departmentResponsible = new DepartmentResponsible();
            var humanResourceResponsible = new HumanResourceResponsible();

            teamResponsible.NextResponsible = departmentResponsible;
            departmentResponsible.NextResponsible = humanResourceResponsible;

            teamResponsible.RequestPermission(new RequestPermissionArgs
            {
                Days = 15,
                Department = "IT",
                StartDate = DateTime.Now,
                FinishDate = DateTime.Now.AddDays(15)
            });
        }
    }
}
