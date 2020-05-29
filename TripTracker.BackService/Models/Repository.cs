using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace TripTracker.BackService.Models
{
    public class Repository
    {
        private List<Trip> MyTrips = new List<Trip>()
        {
            new Trip
            {
                Id = 1,
                Name = "Trip to Norway",
                StartDate = new DateTime(2019, 02, 03),
                EndDate = new DateTime(2019, 02, 21)
            },
            new Trip
            {
                Id = 2,
                Name = "Trip to Microsoft",
                StartDate = new DateTime(2019, 10, 03),
                EndDate = new DateTime(2019, 10, 04)
            },
            new Trip
            {
                Id = 1,
                Name = "Trip to Melbourne",
                StartDate = new DateTime(2021, 02, 20),
                EndDate = new DateTime(2022, 02, 21)
            }

        };

        public List<Trip> Get()
        {
            return MyTrips;
        }

        public Trip Get(int id)
        {
            return MyTrips.First(t => t.Id == id);
        }

        public void Add(Trip newTrip)
        {
            MyTrips.Add(newTrip);
        }

        public void Update(Trip tripToUpdate)
        {
            MyTrips.Remove(MyTrips.First(t => t.Id == tripToUpdate.Id));
            MyTrips.Add(tripToUpdate);
        }

        public void Remove(int id)
        {
            MyTrips.Remove(MyTrips.First(t => t.Id == id));
        }
    }
}
