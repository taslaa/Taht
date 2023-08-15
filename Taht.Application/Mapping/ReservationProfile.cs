using Taht.Core;

namespace Taht.Application
{
    public class ReservationProfile : BaseProfile
    {
        public ReservationProfile()
        {
            CreateMap<ReservationDto, Reservation>().ReverseMap();

            CreateMap<ReservationUpsertDto, Reservation>()
                .ForMember(u => u.Status, o => o.MapFrom(_ => ReservationStatus.Confirmed));
        }
    }
}
