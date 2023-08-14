﻿using Taht.Core;
using Taht.Infrastructure.Interfaces;

namespace Taht.Application.Interfaces
{
    public interface IReviewsService : IBaseService<int, ReviewDto, ReviewUpsertDto, BaseSearchObject>
    {
    }
}
