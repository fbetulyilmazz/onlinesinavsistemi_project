using System;
using System.Collections.Generic;

namespace OnlineSinavUI.Models
{
    public partial class Vehicle
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Engine { get; set; }
        public string FuelType { get; set; }
        public string Gear { get; set; }
        public string VehicleTypeId { get; set; }
        public string Licence { get; set; }
        public string Url { get; set; }
        public int? ColorId { get; set; }
        public bool? IsDeleted { get; set; }
        public DateTime? VehicleProductionDate { get; set; }
        public int? PhotoId { get; set; }
        public bool? IsSalesorRent { get; set; }
        public string Passenger { get; set; }
        public string CasaType { get; set; }
    }
}
