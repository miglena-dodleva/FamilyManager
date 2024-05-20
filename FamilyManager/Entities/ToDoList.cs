﻿using System.ComponentModel.DataAnnotations.Schema;

namespace FamilyManager.Entities
{
    public class ToDoList : BaseEntity
    {
        public string Name { get; set; }
        public int OwnerId { get; set; }

        [ForeignKey("OwnerId")]
        public virtual User Owner { get; set; }

        public virtual ICollection<Task> Tasks { get; set; }

        public virtual ICollection<UserToToDoList> UserToToDoLists { get; set; }

    }
}
