using System;

namespace Quasar.Places.Application.Web.Queries.Places
{
    public class Place
    {
        public Guid Id { get; set; }

        public PlaceMember Member { get; set; }
    }
}