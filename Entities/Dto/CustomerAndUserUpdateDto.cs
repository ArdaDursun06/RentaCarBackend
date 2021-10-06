using Core.Entites;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Dto
{
    public class CustomerAndUserUpdateDto : IDto
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string CompanyName { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string ActivePassword { get; set; }
        public string NewPassword { get; set; }
    }
}
