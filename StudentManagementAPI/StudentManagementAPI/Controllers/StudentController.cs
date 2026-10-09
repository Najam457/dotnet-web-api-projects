using Microsoft.AspNetCore.Mvc;
using StudentManagementAPI.Models;

namespace StudentManagementAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentController : ControllerBase
    {

        // Temporary database (in-memory list)
        private static List<Student> students = new List<Student>
        {
            new Student
            {
                Id = 1,
                Name = "Ali",
                Age = 21,
                Department = "Software Engineering",
                Email = "ali@gmail.com"
            },

            new Student
            {
                Id = 2,
                Name = "Ahmed",
                Age = 22,
                Department = "Computer Science",
                Email = "ahmed@gmail.com"
            }
        };


        // GET: api/student
        // Get all students
        [HttpGet]
        public IActionResult GetStudents()
        {
            return Ok(students);
        }



        // GET: api/student/1
        // Get single student by ID
        [HttpGet("{id}")]
        public IActionResult GetStudent(int id)
        {

            var student = students.FirstOrDefault(x => x.Id == id);


            if (student == null)
            {
                return NotFound("Student not found");
            }


            return Ok(student);
        }



        // POST: api/student
        // Add new student
        [HttpPost]
        public IActionResult AddStudent(Student student)
        {

            // Generate new ID automatically
            student.Id = students.Max(x => x.Id) + 1;


            students.Add(student);


            return Ok(students);
        }




        // PUT: api/student/1
        // Update existing student
        [HttpPut("{id}")]
        public IActionResult UpdateStudent(int id, Student request)
        {

            var student = students.FirstOrDefault(x => x.Id == id);


            if (student == null)
            {
                return NotFound("Student not found");
            }



            student.Name = request.Name;
            student.Age = request.Age;
            student.Department = request.Department;
            student.Email = request.Email;



            return Ok(students);
        }




        // DELETE: api/student/1
        // Delete student
        [HttpDelete("{id}")]
        public IActionResult DeleteStudent(int id)
        {

            var student = students.FirstOrDefault(x => x.Id == id);



            if (student == null)
            {
                return NotFound("Student not found");
            }



            students.Remove(student);



            return Ok(students);
        }

    }
}