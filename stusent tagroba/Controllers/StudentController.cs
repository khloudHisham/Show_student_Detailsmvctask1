using Microsoft.AspNetCore.Mvc;
using stusent_tagroba.Models;

namespace stusent_tagroba.Controllers
{
    //created class "StudentController" inhert from "Controller"
    public class StudentController : Controller
    {
        public IActionResult Details(int id)
        {
            StudentBL bl = new StudentBL();
            Student student = bl.GetByID(id);
            if (student == null)
            {
                return NotFound(); // Return a 404 Not Found if the student with the specified ID is not found
            }
            return View(student); // Pass the student data to the Details view
        }
        public IActionResult All()
        {
            // i wanna ask the model  to retrieve all students
            // kda gab L data mn L model
            // Gap L 3arosssaaa

            StudentBL bl = new StudentBL();
          List<Student> StudentsModel= bl.GetAll();
            //send data view :search in view here name is "ShowAll" in studen folder ,send model his type is listt of student
            // Gbt Zarf whtet feh Flos 
            return View("ShowALL",StudentsModel);
            //Lmafrod showall tb3athm ba2a
            // ha Create new view h2f 3la klmet new and right click on it  name the view "ShowAll"


        }
    }
}
