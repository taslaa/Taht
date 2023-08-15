﻿using Taht.Core;

namespace Taht.Infrastructure.Interfaces
{
    public interface IAppointmentsRepository : IBaseRepository<Appointment, int, BaseSearchObject>
    {
    }
}