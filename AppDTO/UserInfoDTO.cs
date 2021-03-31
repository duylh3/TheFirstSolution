using System;

namespace AppDTO
{
    public class UserInfoDTO
    {
        public int Id { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string CompanyName { get; set; }
        public string ShortName { get; set; }
        public string Description { get; set; }
        public string CreatedDate { get; set; }
        public string DeletedDate { get; set; }
        public string ModifyDate { get; set; }
        public Nullable<int> IsDeleted { get; set; }
        public int Role { get; set; }
    }
}
