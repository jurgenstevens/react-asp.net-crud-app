using Microsoft.EntityFrameworkCore;
using System;
namespace aspnetserver.Data
{
	public class AppDBContext
	{
		public AppDBContext()
		{
			public Microsoft.EntityFrameworkCore.DbSet<Post> Posts { get; set; }
			protected override void OnConfiguring(DbContext)
		}
	}
}

