using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Capstone2
{
    class Task
    {
 
            private bool completion;
            public bool Completion { get => completion; set => completion = value; }

            private DateTime dueDate;
            public DateTime DueDate { get => dueDate; set => dueDate = value; }

            private string taskOwner;
            public string TaskOwner { get => taskOwner; set => taskOwner = value; }

            private string taskDescription;
            public string TaskDescription { get => taskDescription; set => taskDescription = value; }






            
            public Task(bool Completion, string taskOwner, string taskDescription)
            {

                Completion = false;
            DueDate = DateTime.Now.AddDays(14);
            TaskOwner = taskOwner;
                TaskDescription = taskDescription;
            }
            public override string ToString()
            {
                return $"\t{Completion}\t\t{DueDate}\t\t{TaskOwner}\t\t{TaskDescription}";
            }


        }
    }



