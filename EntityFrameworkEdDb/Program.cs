//static void Main() { }

using EntityFrameworkEdDb.Models;
using Microsoft.EntityFrameworkCore;

var _context = new EdDbContext();

var inst = await _context.Instructors.ToListAsync();

foreach(var instructor in inst) {
    Console.WriteLine($"{instructor.Firstname}, {instructor.Lastname}, {instructor.YearsExperience}");
}



//AddClassAndRelateToMajor(_context);

//async void AddClassAndRelateToMajor(EdDbContext _context) {

//    var auwbw = await _context.Majors.SingleOrDefaultAsync(m => m.Code == "AUWB");

//    var uwbw101 = new Class() {
//        Id = 0, Code = "UWB101", Section = 101, Subject = "Underwater Basket Weaving 101",
//        Instructor = null, Assignments = null!
//    };
//    _context.Classes.Add(uwbw101);
//    await _context.SaveChangesAsync();

//    var majorclass = new MajorClass() {
//        Id = 0,
//        ClassId = (await _context.Classes.SingleOrDefaultAsync(c => c.Subject == uwbw101.Subject))!.Id,
//        MajorId = _context.Majors.SingleOrDefault(m => m.Code == auwbw!.Code)!.Id
//    };
//    _context.MajorClasses.Add(majorclass);
//    await _context.SaveChangesAsync();
//}


//var newStudent = new Student {
//    Id = 0, Firstname = "Andy", Lastname = "Baldwin",
//    Gpa = 3.7m, Sat = 1200, MajorId = null
//};

//if (!_context.Students.Any(s => s.Firstname == newStudent.Firstname && s.Lastname == newStudent.Lastname)) {
//    _context.Students.Add(newStudent);
//    _context.SaveChanges();
//}

//var studentToRemove = _context.Students
//                            .SingleOrDefault(s => s.Firstname == "Andy" && s.Lastname == "Baldwin");

//if (studentToRemove != null) {
//    _context.Students.Remove(studentToRemove);
//    _context.SaveChanges();
//}


//_context.Students.ToList().ForEach(s => global::System.Console.WriteLine($"{s.Firstname} {s.Lastname}"));


//var studentsMajors = from s in _context.Students
//                     join m in _context.Majors
//                       on s.MajorId equals m.Id
//                     where s.StateCode == "OH"
//                     orderby s.Lastname descending
//                     select new {
//                         FullName = $"{s.Firstname} {s.Lastname}",
//                         Major = m.Description
//                     };

//studentsMajors.ToList().ForEach(sm => {
//    global::System.Console.WriteLine($"{sm.FullName} | {sm.Major}");
//});

//Console.WriteLine("+++++");


//var code = _context.Majors.SingleOrDefault(m => m.Code == "Math");

//if(code is not null) {
//    Console.WriteLine($"{code.Id} | {code.Description}");
//}

//var major = _context.Majors.Find(1);

//Console.WriteLine($"{major.Id}  | { major.Description}");

//var newMajor = new Major() {
//    Id = 0, Code = "AUWB", Description = "Advanced Underwater Basket Weaving", MinSat = 1599
//};

//_context.Majors.Add(newMajor);

//_context.SaveChanges();

//var majors = _context.Majors.ToList();

//foreach (var m in majors) {
//    Console.WriteLine($"{m.Id} | {m.Description}");
//}