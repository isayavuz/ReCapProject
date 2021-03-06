using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.DTOs
{
    public class CarDetailDto:IDto
    {
        public int Id { get; set; }
        public string CarName { get; set; }
        public string BrandName { get; set; }
        public string ColorName { get; set; }
        public int ModelYear { get; set; }
        public string Gearbox { get; set; }
        public string FuelType { get; set; }
        public short Passengers { get; set; }
        public decimal DailyPrice { get; set; }
        public string Description { get; set; }
    }
}
