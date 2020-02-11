using System;
using System.Collections.Generic;

namespace OnlineSinavUI.Models
{
    public partial class Customer
    {
        public int Id { get; set; }
        public byte? Age { get; set; }
        public string NameSurname { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string IdentityNo { get; set; }
        public string ActivationCode { get; set; }
        public bool? IsActive { get; set; }
        public bool? IsDelete { get; set; }
    }
}
