using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaskManager.Models
{
    public class Issue
    {
        public int Id { get; set; }
        public DateTime RequiredBy { get; set; }
        public DateTime CreatedAt { get; set; }
        public string Description { get; set; }
        public IssueStatus IssueStatus { get; set; }
        public IssueType IssueType { get; set; }
        public User AssignedTo { get; set; }
        public DateTime NextActionDate { get; set; }
        public virtual List<Comment> Comments { get; set; }
    }
}
