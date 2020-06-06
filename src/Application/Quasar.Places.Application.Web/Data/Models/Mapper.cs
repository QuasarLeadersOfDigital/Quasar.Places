using System;
using Quasar.Places.Application.Web.Queries.Places;

namespace Quasar.Places.Application.Web.Data.Models
{
    public static class Mapper
    {
        public static Place ToPlace(this PlaceData placeData)
        {
            if (placeData == null)
            {
                return null;
            }
			
            var target = new Place
            {
                Id = placeData.Id,
                Member = new PlaceMember
                {
                    Id = placeData.Member.Id
                }
            };

            return target;
        }

        public static PlaceDetails ToPlaceDetails(this PlaceData placeData)
        {
            if (placeData == null)
            {
                return null;
            }

            var target = new PlaceDetails
            {
                Id = placeData.Id,
                Member = new PlaceDetailsMember
                {
                    Id = placeData.Member.Id
                },
                Name = placeData.Name
            };

            return target;
        }
    }
}