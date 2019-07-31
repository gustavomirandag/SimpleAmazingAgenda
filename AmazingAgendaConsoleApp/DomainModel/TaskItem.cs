using System;
using System.Collections.Generic;
using System.Text;

namespace AmazingAgendaConsoleApp.DomainModel
{
    public class TaskItem
    {
        public Guid id;
        public string title;
        public string description;
        public DateTime dateTime;
        public bool done;
    }
}
