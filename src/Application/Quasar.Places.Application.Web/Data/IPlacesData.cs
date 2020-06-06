using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;
using Quasar.Places.Application.Web.Commands;
using Quasar.Places.Application.Web.Queries.Places;

namespace Quasar.Places.Application.Web.Data
{
    public interface IPlacesData
    {
        Task<IEnumerable<Place>> GetAsync(CancellationToken cancellationToken);

        Task<PlaceDetails> GetByIdAsync(Guid placeId, CancellationToken cancellationToken);

        Task AddAsync(CreateDirectPlaceCommand command, CancellationToken cancellationToken);

        Task UpdateAsync(ChangePlacesInfoCommand command, CancellationToken cancellationToken);

        Task RemoveAsync(Guid chatId, CancellationToken cancellationToken);
    }
}