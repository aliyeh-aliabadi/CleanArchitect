using System;
using System.Collections.Generic;
using System.Text;

namespace CleanArch.Domain.Models.Base
{
    public class Entity
    {
        public Entity()
        {
            Id = System.Guid.NewGuid();
        }
        public System.Guid Id { get; set; }
    }
}
