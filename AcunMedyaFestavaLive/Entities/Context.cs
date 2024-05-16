using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace AcunMedyaFestavaLive.Entities
{
	public class Context: DbContext
	{
		public DbSet<Artist> Artist { get; set; }
		public DbSet<Ticket> Tickets { get; set; }
	}
}