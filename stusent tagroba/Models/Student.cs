namespace stusent_tagroba.Models
{
    public class Student
    {
        // Model as a class will map on table in future
        public int Id { get; set; }
        public string Name { get; set; }
        public string Address { get; set; }
        public string ImageUrl { get; set; }
        public int DeptId { get; set; }
    }
}
