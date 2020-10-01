using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ManagerTask.Models
{
    public class TaskModel
    {

        public int TaskId { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public bool Done { get; set; }
            
    }
}
