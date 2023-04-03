using System;
namespace Mvc_Project1.Models
{
	public class Category
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public string Description { get; set; }
		List<MyTask> MyTasks { get; set; }

	}
}

