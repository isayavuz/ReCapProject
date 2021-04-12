using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class Transmission : IEntity
    {
        public int Id { get; set; }
        public string Gearbox { get; set; }
    }
}
