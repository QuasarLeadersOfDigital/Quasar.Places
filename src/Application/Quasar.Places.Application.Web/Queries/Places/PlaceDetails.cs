using System;

namespace Quasar.Places.Application.Web.Queries.Places
{
    public class PlaceDetails
    {
        public Guid Id { get; set; }
		
        public string Name { get; set; }

        public PlaceDetailsMember Member { get; set; }
    }
}