﻿namespace Taht.Core
{
    public class PhotoDto : BaseDto
    {
        public byte[] Data { get; set; } = null!;
        public string ContentType { get; set; } = null!;
    }
}
