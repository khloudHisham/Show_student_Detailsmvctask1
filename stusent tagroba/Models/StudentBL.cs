namespace stusent_tagroba.Models
{
    //Class have list 
    public class StudentBL
    {
        List<Student> students;
        public StudentBL()
        {
            //sample of data  with initialization
            students = new List<Student>();
            students.Add(new Student() { Id = 1, Name = "Khloud", Address = "Alex", ImageUrl = "o.png", DeptId = 1 });
            students.Add(new Student() { Id = 2, Name = "shahy", Address = "Giza", ImageUrl = "r.png", DeptId =1});
            students.Add(new Student() { Id = 3, Name = "Ahmed", Address = "Alex", ImageUrl = "s.png", DeptId = 2 });
            students.Add(new Student() { Id = 4, Name = "Ali", Address = "Menofia", ImageUrl = "m.png", DeptId = 3 });
            students.Add(new Student() { Id = 5, Name = "Fahd", Address = "Cairo", ImageUrl = "n.png", DeptId = 2 });
        }
        //to retrive the data of one student by his id
        public Student GetByID(int id)
        {
            return students.FirstOrDefault(e => e.Id == id);

        }
        //to retrive the data of all sudents
        public List<Student> GetAll() { return students; } 
        //Go to controller file to select end point such this  :student/All
    }
}
