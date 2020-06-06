using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using Quasar.Places.Application.Web.Commands;
using Quasar.Places.Application.Web.Data.Models;
using Quasar.Places.Application.Web.Queries.Places;

namespace Quasar.Places.Application.Web.Data
{
    public class PlacesData : IPlacesData
    {
        private readonly IList<PlaceData> _chatData;

        public PlacesData()
        {
            _chatData = new List<PlaceData>();
        }

        /// <inheritdoc />
        public async Task<IEnumerable<Place>> GetAsync(CancellationToken cancellationToken)
        {
            var chats = _chatData.Select(Mapper.ToPlace);

            return chats;
        }

        /// <inheritdoc />
        public async Task<PlaceDetails> GetByIdAsync(Guid chatId, CancellationToken cancellationToken)
        {
            var chat = _chatData
                .FirstOrDefault(ch => ch.Id == chatId);

            return chat.ToPlaceDetails();
        }

        /// <inheritdoc />
        public async Task AddAsync(CreateDirectPlaceCommand command, CancellationToken cancellationToken)
        {
            var place = new PlaceData
            {
                Id = Guid.NewGuid(),
                Member = new MemberData
                {
                    Id = command.To
                },
                Name = command.To.ToString()
            };

            _chatData.Add(place);
        }

        /// <inheritdoc />
        public async Task UpdateAsync(ChangePlacesInfoCommand command, CancellationToken cancellationToken)
        {
            PlaceData place = _chatData.FirstOrDefault(ch => ch.Id == command.PlaceId);

            if (place == null)
            {
                return;
            }

            place.Name = command.Name;
        }

        /// <inheritdoc />
        public async Task RemoveAsync(Guid placeId, CancellationToken cancellationToken)
        {
            var place = _chatData.FirstOrDefault(pl => pl.Id == placeId);

            _chatData.Remove(place);
        }
    }
}