using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaskManager.Models
{
    public class User
    {
        public int Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public virtual List<Issue> AssignedIssues { get; set; }
        public virtual List<Comment> Comments { get; set; }
    }
}
