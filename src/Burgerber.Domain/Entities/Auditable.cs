﻿namespace Burgerber.Domain.Entities
{
    public class Auditable
    {
        public DateTime CreateAt { get; set; }
        public DateTime UpdateAt { get; set; }

    }
}