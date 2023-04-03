using System;
namespace Mvc_Project1.Models
{
	public class MyTask
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public DateTime Date { get; set; }

		// one to many relation
		public Category Category { get; set; }

        public int CategoryId { get; set; } // foreign key


    }



}

