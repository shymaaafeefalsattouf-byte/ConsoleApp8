using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp8.Entities
{
    public class TaskItem
    {
        public int Id { get; set; }//PK
        public string Title { get; set; } = string.Empty;
        
        public DateTime PlannedDate { get; set; }
        public DateTime DueDate { get; set; }
        public bool IsCompleted { get; set; }

        public int UserId { get; set; }//FK
        public User User { get; set; } = null!;
        public int SectionID {  get; set; }//FK
        public Section section { get; set; } = null!;
        public int  ImportanceLevelId{  get; set; }//FK
        public ImportanceLevel ImportanceLevel { get; set; } = null!;
    }
}
