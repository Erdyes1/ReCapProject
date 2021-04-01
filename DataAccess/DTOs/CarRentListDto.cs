using Core.Entities;
using System;

namespace DataAccess.DTOs
{
    public class CarRentListDto : IDto
    {
        public int RentalId { get; set; }
        public int CarId { get; set; }
        public String BrandName { get; set; }
        public string CarModel { get; set; }
        public string CarColor { get; set; }

        public string CompanyName { get; set; }

        public string UserFirstName { get; set; }
        public string UserLastName { get; set; }

        public DateTime RentDate { get; set; }

        public DateTime ReturnDate { get; set; }



    }
}
