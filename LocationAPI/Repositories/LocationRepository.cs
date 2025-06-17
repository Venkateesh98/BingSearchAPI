using System.Collections.Generic;
using System.Linq;
using LocationAPI.Controllers;
using LocationAPI.Models;

namespace LocationsApi.Repositories
{
    public class LocationRepository
    {
        private static readonly List<Location> Locations = new()
        {
            new Location { Name = "Pharmacy", Type = "Health", Availability = "10 AM - 1 PM" },
            new Location { Name = "Bakery", Type = "Food", Availability = "9 AM - 12 PM" },
            new Location { Name = "Supermarket", Type = "Retail", Availability = "10 AM - 1 PM" },
            new Location { Name = "Candy Store", Type = "Food", Availability = "10 AM - 2 PM" },
            new Location { Name = "Cinema Complex", Type = "Entertainment", Availability = "11 AM - 4 PM" },
            new Location { Name = "Barber Shop", Type = "Service", Availability = "8 AM - 11 AM" },
            new Location { Name = "Electronics Store", Type = "Retail", Availability = "10 AM - 1 PM" },
            new Location { Name = "Library", Type = "Education", Availability = "9 AM - 3 PM" },
            new Location { Name = "Gym", Type = "Fitness", Availability = "7 AM - 12 PM" },
            new Location { Name = "Coffee Shop", Type = "Food", Availability = "10 AM - 4 PM" }
        };

        public List<Location> GetAvailableLocations()
        {
            return Locations.Where(l => l.Availability.Contains("10 AM") || l.Availability.Contains("11 AM") || l.Availability.Contains("12 PM")).ToList();
        }
    }
}
