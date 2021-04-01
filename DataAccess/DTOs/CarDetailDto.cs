using Core.Entities;
using System;

namespace DataAccess.DTOs
{
    public class CarDetailDto : IDto
    {
        public int CarId { get; set; }
        public String BrandName { get; set; }
        public String ColorName { get; set; }
        public int ModelYear { get; set; }
        public int DailyPrice { get; set; }
        public string Description { get; set; }
        public string CarModel { get; set; }
    }
}
