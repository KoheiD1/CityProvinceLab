using CommunityApp.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;

namespace CommunityApp.Data;

public class ApplicationDbContext : IdentityDbContext
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options) {}
    public DbSet<City>? City { get; set; }
    public DbSet<Province>? Province { get; set; }

    protected override void OnModelCreating(ModelBuilder builder)
{
    base.OnModelCreating(builder);

    builder.Entity<Province>().HasData(GetProvinces());
    builder.Entity<City>().HasData(GetCities());
}

public static List<Province> GetProvinces() {
        List<Province> provinces = new List<Province>() {
            new Province() {    // 1
                ProvinceCode ="BC",
                ProvinceName ="British Columbia"
            },
            new Province() {    // 1
                ProvinceCode ="AB",
                ProvinceName ="Alberta"
            }, 
            new Province() {    // 1
                ProvinceCode ="SK",
                ProvinceName ="Saskatchewan"
            },
        };
        return provinces;
    }

    public static List<City> GetCities() {
        List<City> cities = new List<City>() {
            new City {
                CityId = 123,
                CityName = "Grand Forks",
                Population = 4000,
                ProvinceCode = "BC"
            },
            new City {
                CityId = 72,
                CityName = "Vancouver",
                Population = 1000000,
                ProvinceCode = "BC"
            },
            new City {
                CityId = 12,
                CityName = "Victoria",
                Population = 300000,
                ProvinceCode = "BC"
            },

            new City {
                CityId = 100,
                CityName = "Calgary",
                Population = 500000,
                ProvinceCode = "AB"
            },

            new City {
                CityId = 17,
                CityName = "Edmonton",
                Population = 304400,
                ProvinceCode = "AB"
            },
            new City {
                CityId = 13,
                CityName = "Medicine Hat",
                Population = 300000,
                ProvinceCode = "AB"
            },
            new City {
                CityId = 113,
                CityName = "Regina",
                Population = 444000,
                ProvinceCode = "SK"
            },
            new City {
                CityId = 25,
                CityName = "Saskatoon",
                Population = 100000,
                ProvinceCode = "SK"
            },
            new City {
                CityId = 14,
                CityName = "Moose Jaw",
                Population = 100000,
                ProvinceCode = "SK"
            },
        };

        return cities;
    }

}

