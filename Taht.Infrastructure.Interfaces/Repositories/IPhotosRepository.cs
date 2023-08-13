﻿using Taht.Core;

namespace Taht.Infrastructure.Interfaces
{
    public interface IPhotosRepository : IBaseRepository<Photo, int, BaseSearchObject>
    {
    }
}