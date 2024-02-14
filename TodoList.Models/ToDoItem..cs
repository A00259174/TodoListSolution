namespace TodoList.Models
    {
        public class ToDoItem
        {
            public int Id { get; set; }
            public string Title { get; set; }
            public string Description { get; set; }
            public DateTime DueDate { get; set; }
            public DateTime? CompletedDate { get; set; } // Nullable DateTime

            // Additional properties or methods as needed
        }
    }


