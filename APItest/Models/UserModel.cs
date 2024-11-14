namespace APItest.Models
{
    public class UserRequestModel
    {
        public string Name { get; set; }
        public string Phone {  get; set; }
        public string Email { get; set; }
    }

    public class UserResponseModel
    {
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string Id { get; set; }
    }

    public class UserListResponseModel
    {
        public List<UserRequestModel> Users { get; set; } = new List<UserRequestModel>();
    }
}
