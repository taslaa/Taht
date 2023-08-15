using Taht.Core;

namespace Taht.Application
{
    public class AppointmentProfile : BaseProfile
    {
        public AppointmentProfile()
        {
            CreateMap<AppointmentDto, Appointment>().ReverseMap();

            CreateMap<AppointmentUpsertDto, Appointment>()
                .ForMember(u => u.IsBooked, o => o.MapFrom(_ => true));
        }
    }
}
