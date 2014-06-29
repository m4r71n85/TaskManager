using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TaskManager.Models
{
    public class Comment
    {
        DateTime createdAt;
        public int Id { get; set; }
        public DateTime CreatedAt {
            get
            {
                if (createdAt == null)
                {
                    createdAt = DateTime.Now;
                }
                return createdAt;
            }
        }
        public string Body { get; set; }
        public CommentType CommentType { get; set; }
        public DateTime ReminderDate { get; set; }
        public Issue Issue { get; set; }
        public User User { get; set; }
    }
}
