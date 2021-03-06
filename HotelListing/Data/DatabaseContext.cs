using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HotelListing.Data
{
	public class DatabaseContext : DbContext
	{
		public DatabaseContext(DbContextOptions<DatabaseContext> options) : base(options)
		{

		}

		public DbSet<Country> Countries { get; set; }
		public DbSet<Hotel> Hotels { get; set; }

		protected override void OnModelCreating(ModelBuilder builder)
		{
			builder.Entity<Country>().HasData(
				new Country
				{
					Id = 1,
					Name = "Jamaica",
					ShortName = "JM"
				},
				new Country
				{
					Id = 2,
					Name = "Bahamas",
					ShortName = "BS"
				},
				new Country
				{
					Id = 3,
					Name = "Cayman Islands",
					ShortName = "CI"
				}
				);

			builder.Entity<Hotel>().HasData(
				new Hotel
				{
					Id = 1,
					Name = "Hotel 1",
					Address = "Address 1",
					CountryId = 1,
					Rating = 4.5,
				},
				new Hotel
				{
					Id = 2,
					Name = "Hotel 2",
					Address = "Address 2",
					CountryId = 2,
					Rating = 4,
				},
				new Hotel
				{
					Id = 3,
					Name = "Hotel 3",
					Address = "Address 3",
					CountryId = 3,
					Rating = 5
				}
				);
		}
	}
}
