using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Timely.App.Code
{
    public static class Validators
    {
        public static string ValidateTask(Entities.Task task)
        {
            return string.IsNullOrEmpty(task.Name) ? "Please enter a valid task name." : string.Empty;
        }
    }
}
