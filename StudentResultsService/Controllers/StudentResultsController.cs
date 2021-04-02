using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace StudentCourseResults.Controllers
{

    public class StudentResults
    {
        public DateTime Date { get; set; }
        public string StudentLastName { get; set; }
        public string StudentFirstName { get; set; }
        public string StudentId { get; set; }
        public string SummaryNotes { get; set; }

        public List<ClassResults> ClassResults { get; set; }
    }

    public class ClassResults
    {
        public DateTime Date { get; set; }
        public string StudentId { get; set; }
        public string ClassName { get; set; }
        public float GPA { get; set; }

        public static ClassResults BuildClassResults(DateTime date, string id, string className, float GPA)
        {
            ClassResults results = new ClassResults();
            results.Date = date;
            results.StudentId = id;
            results.ClassName = className;
            results.GPA = GPA;
            return results;
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
            studentResultsClark.ClassResults = new List<ClassResults>();
            studentResultsClark.ClassResults.Add(ClassResults.BuildClassResults(DateTime.Now, studentResultsClark.StudentId, "Flying", 4.0f));
            studentResultsClark.ClassResults.Add(ClassResults.BuildClassResults(DateTime.Now, studentResultsClark.StudentId, "Laser beam vision", 3.1f));
            studentResultsClark.ClassResults.Add(ClassResults.BuildClassResults(DateTime.Now, studentResultsClark.StudentId, "Kryptonite Resistance", 0.1f));
            studentResultsList.Add(studentResultsClark);

            StudentResults studentResultsLois = new StudentResults();
            studentResultsLois.Date = DateTime.Now;
            studentResultsLois.StudentFirstName = "Lois";
            studentResultsLois.StudentLastName = "Lane";
            studentResultsLois.StudentId = "9834543";
            studentResultsLois.SummaryNotes = "Lois is smart and resourceful.";
            studentResultsLois.ClassResults = new List<ClassResults>();
            studentResultsLois.ClassResults.Add(ClassResults.BuildClassResults(DateTime.Now, studentResultsLois.StudentId, "Flying", 0.0f));
            studentResultsLois.ClassResults.Add(ClassResults.BuildClassResults(DateTime.Now, studentResultsLois.StudentId, "Journalism", 4.0f));
            studentResultsLois.ClassResults.Add(ClassResults.BuildClassResults(DateTime.Now, studentResultsLois.StudentId, "Establishing personal boundaries", 2.4f));
            studentResultsList.Add(studentResultsLois);

            StudentResults studentResultsGreenLantern = new StudentResults();
            studentResultsGreenLantern.Date = DateTime.Now;
            studentResultsGreenLantern.StudentFirstName = "Green";
            studentResultsGreenLantern.StudentLastName = "Lantern";
            studentResultsGreenLantern.StudentId = "0025214";
            studentResultsGreenLantern.SummaryNotes = "Green Lantern was a pleasure to have in class.  He might be a little too cocky for his own good but in the end he does the right thing.";
            studentResultsGreenLantern.ClassResults = new List<ClassResults>();
            studentResultsGreenLantern.ClassResults.Add(ClassResults.BuildClassResults(DateTime.Now, studentResultsLois.StudentId, "Flying", 3.2f));
            studentResultsGreenLantern.ClassResults.Add(ClassResults.BuildClassResults(DateTime.Now, studentResultsLois.StudentId, "Alter-Ego", 3.9f));
            studentResultsGreenLantern.ClassResults.Add(ClassResults.BuildClassResults(DateTime.Now, studentResultsLois.StudentId, "Green Power Ring", 4.0f));
            studentResultsList.Add(studentResultsGreenLantern);

            StudentResults studentResultsWonderWoman = new StudentResults();
            studentResultsWonderWoman.Date = DateTime.Now;
            studentResultsWonderWoman.StudentFirstName = "Wonder";
            studentResultsWonderWoman.StudentLastName = "Woman";
            studentResultsWonderWoman.StudentId = "0215487";
            studentResultsWonderWoman.SummaryNotes = "Wonder Woman brings true fighting spirit and the feeling of hope and unity to the classroom.";
            studentResultsWonderWoman.ClassResults = new List<ClassResults>();
            studentResultsWonderWoman.ClassResults.Add(ClassResults.BuildClassResults(DateTime.Now, studentResultsLois.StudentId, "Flying", 3.6f));
            studentResultsWonderWoman.ClassResults.Add(ClassResults.BuildClassResults(DateTime.Now, studentResultsLois.StudentId, "Bracers of Themiscyra", 4.0f));
            studentResultsWonderWoman.ClassResults.Add(ClassResults.BuildClassResults(DateTime.Now, studentResultsLois.StudentId, "Lasso of Hestia", 4.0f));
            studentResultsWonderWoman.ClassResults.Add(ClassResults.BuildClassResults(DateTime.Now, studentResultsLois.StudentId, "Sword of the Amazons", 4.0f));
            studentResultsList.Add(studentResultsWonderWoman);

            StudentResults studentResultBatman = new StudentResults();
            studentResultBatman.Date = DateTime.Now;
            studentResultBatman.StudentFirstName = "Bat";
            studentResultBatman.StudentLastName = "Man";
            studentResultBatman.StudentId = "9854758";
            studentResultBatman.SummaryNotes = "Batman is the worlds best detective and a formidible opponent in combat.  I would encourage Batman to let his guard down and allow himself to be vulnerable and build positive, lasting relationships.";
            studentResultBatman.ClassResults = new List<ClassResults>();
            studentResultBatman.ClassResults.Add(ClassResults.BuildClassResults(DateTime.Now, studentResultsLois.StudentId, "Batarang", 3.6f));
            studentResultBatman.ClassResults.Add(ClassResults.BuildClassResults(DateTime.Now, studentResultsLois.StudentId, "Detective Skills - Advanced", 4.0f));
            studentResultBatman.ClassResults.Add(ClassResults.BuildClassResults(DateTime.Now, studentResultsLois.StudentId, "Martial Arts", 3.7f));
            studentResultBatman.ClassResults.Add(ClassResults.BuildClassResults(DateTime.Now, studentResultsLois.StudentId, "Building Loving Relationships", 1.7f));
            studentResultsList.Add(studentResultBatman);

            return studentResultsList;
        }
    }
}
