using Microsoft.EntityFrameworkCore.Storage;

using Taht.Infrastructure.Interfaces;

namespace Taht.Infrastructure
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DatabaseContext _databaseContext;

        public readonly IReservationsRepository ReservationsRepository;
        public readonly IReviewsRepository ReviewsRepository;
        public readonly IServicesRepository ServicesRepository;
        public readonly IUsersRepository UsersRepository;

        public UnitOfWork(
            DatabaseContext databaseContext,
            IReservationsRepository reservationsRepository,
            IReviewsRepository reviewsRepository,
            IServicesRepository servicesRepository,
            IUsersRepository usersRepository)
        {
            _databaseContext = databaseContext;

            ReservationsRepository = reservationsRepository;
            ReviewsRepository = reviewsRepository;
            ServicesRepository = servicesRepository;
            UsersRepository = usersRepository;
        }

        public async Task<IDbContextTransaction> BeginTransactionAsync(CancellationToken cancellationToken = default)
        {
            return await _databaseContext.Database.BeginTransactionAsync(cancellationToken);
        }

        public async Task CommitTransactionAsync(CancellationToken cancellationToken = default)
        {
            await _databaseContext.Database.CommitTransactionAsync(cancellationToken);
        }

        public async Task RollbackTransactionAsync(CancellationToken cancellationToken = default)
        {
            await _databaseContext.Database.RollbackTransactionAsync(cancellationToken);
        }

        public async Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            return await _databaseContext.SaveChangesAsync(cancellationToken);
        }
    }
}
