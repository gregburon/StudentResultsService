using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ResultsService.Controllers
{
    public class StudentResults
    {
        public DateTime Date;
        public string StudentLastName = "";
        public string StudentFirstName = "";
        public string StudentId = "";
        public string SummaryNotes = "";
        public List<ClassResults> ClassResults = new List<ClassResults>();
    }

    public class ClassResults
    {
        public DateTime Date;
        public string StudentId = "";
        public string ClassName = "";
        public float GPA = 4.0f;

        public ClassResults(DateTime date, string id, string className, float gpa)
        {
            Date = date;
            StudentId = id;
            ClassName = className;
            GPA = gpa;
        }
    }

    [ApiController]
    [Route("[controller]")]
    public class StudentResultsController : ControllerBase
    {
        private readonly ILogger<StudentResultsController> _logger;

        public StudentResultsController(ILogger<StudentResultsController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IEnumerable<StudentResults> Get()
        {
            // Note - this is just for illustrative purposes.  Normally we'd go to a database to fetch these results.
            // This is to demonstrate a RESTful API in dotnet and its results.
            List<StudentResults> studentResultsList = new List<StudentResults>();

            StudentResults studentResultsClark = new StudentResults();
            studentResultsClark.Date = DateTime.Now;
            studentResultsClark.StudentFirstName = "Super";
            studentResultsClark.StudentLastName = "Man";
            studentResultsClark.StudentId = "1243454";
            studentResultsClark.SummaryNotes = "Your student is a pleasure to have in class";
            studentResultsClark.ClassResults.Add(new ClassResults(DateTime.Now, studentResultsClark.StudentId, "Flying", 4.0f));
            studentResultsClark.ClassResults.Add(new ClassResults(DateTime.Now, studentResultsClark.StudentId, "Laser beam vision", 3.1f));
            studentResultsClark.ClassResults.Add(new ClassResults(DateTime.Now, studentResultsClark.StudentId, "Kryptonite Resistance", 0.1f));
            studentResultsList.Add(studentResultsClark);

            StudentResults studentResultsLois = new StudentResults();
            studentResultsLois.Date = DateTime.Now;
            studentResultsLois.StudentFirstName = "Lois";
            studentResultsLois.StudentLastName = "Lane";
            studentResultsLois.StudentId = "9834543";
            studentResultsLois.SummaryNotes = "Lois is smart and resourceful.";
            studentResultsLois.ClassResults.Add(new ClassResults(DateTime.Now, studentResultsLois.StudentId, "Flying", 0.0f));
            studentResultsLois.ClassResults.Add(new ClassResults(DateTime.Now, studentResultsLois.StudentId, "Journalism", 4.0f));
            studentResultsLois.ClassResults.Add(new ClassResults(DateTime.Now, studentResultsLois.StudentId, "Establishing personal boundaries", 2.4f));
            studentResultsList.Add(studentResultsLois);

            return studentResultsList;
        }
    }
}
