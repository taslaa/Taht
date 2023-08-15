using Taht.Core;
using Taht.Infrastructure.Interfaces;

namespace Taht.Infrastructure
{
    public class AppointmentsRepository : BaseRepository<Appointment, int, BaseSearchObject>, IAppointmentsRepository
    {
        public AppointmentsRepository(DatabaseContext databaseContext) : base(databaseContext)
        {

        }
    }
}
