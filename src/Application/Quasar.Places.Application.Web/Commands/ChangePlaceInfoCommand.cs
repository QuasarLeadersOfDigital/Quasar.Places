using System;

namespace Quasar.Places.Application.Web.Commands
{
    public class ChangePlacesInfoCommand
    {
        public Guid PlaceId { get; set; }

        public string Name { get; set; }
    }
}