using System;

namespace Quasar.Places.Application.Web.Data.Models
{
    public class PlaceData
    {
        public Guid Id { get; set; }

        public MemberData Member { get; set; }

        public string Name { get; set; }
    }
}