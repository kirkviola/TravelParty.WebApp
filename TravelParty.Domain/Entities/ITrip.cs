using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TravelParty.Domain.Entities
{
    public interface ITrip
    {
        public string Id { get; set; }
        public string TripName { get; set; }
        public IEnumerable<IUser>? Travellers { get; set; }
        public IEnumerable<IUser>? Viewers { get; set; }
    }
}
