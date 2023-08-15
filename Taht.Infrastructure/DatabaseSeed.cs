using Microsoft.EntityFrameworkCore;

using Taht.Core;

namespace Taht.Infrastructure
{
    public partial class DatabaseContext
    {
        private readonly DateTime _dateTime = new(2023, 2, 1, 0, 0, 0, 0, DateTimeKind.Local);

        private void SeedData(ModelBuilder modelBuilder)
        {
            SeedUsers(modelBuilder);
            SeedAppointments(modelBuilder);
        }


        private void SeedUsers(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>().HasData(
                new User
                {
                    Id = 1,
                    FirstName = "Site",
                    LastName = "Admin",
                    Email = "site.admin@ridewithme.com",
                    Role = Role.Administrator,
                    PasswordHash = "b4I5yA4Mp+0Pg1C3EsKU17sS13eDExGtBjjI07Vh/JM=", 
                    PasswordSalt = "1wQEjdSFeZttx6dlvEDjOg==",
                    PhoneNumber = "38761123456",
                    CreatedAt = _dateTime,
                    ModifiedAt = null
                });
        }

        private void SeedAppointments(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Appointment>().HasData(
                new Appointment
                {
                    Id = 1,
                    AppointmentDate = _dateTime,
                    AppointmentTime = "12:00",
                    IsBooked= true,
                    CreatedAt = _dateTime,
                    ModifiedAt = null
                });
        }
    }
}
