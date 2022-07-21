using Microsoft.EntityFrameworkCore;
using University;
using University.Tables;

using (ApplicationContext db = new())
{
    List<Faculty> faculties = new()
    {
        new Faculty {Name="Инженерный факультет"},
        new Faculty {Name="Биотехнологический факультет"},
        new Faculty {Name="Факультет организации здорового образа жизни"},
        new Faculty {Name="Факультет экономики и финансов"},
    };

    List<AcademicDegree> degrees = new()
    {
        new AcademicDegree { Name = "Ассистент" },
        new AcademicDegree { Name = "Преподаватель"},
        new AcademicDegree { Name = "Старший преподаватель"},
        new AcademicDegree { Name = "Доцент"},
        new AcademicDegree { Name = "Профессор" },
    };

    List<Department> departments = new()
    {
        new Department { Name = "Информационные технологии и интеллектуальные системы", Faculty = faculties[0]},
    };

    List<Discipline> disciplines = new()
    {
        new Discipline { Name = "Основы конструирования программ"},
        new Discipline { Name = "Объектно ориентрированное программирование"},
        new Discipline { Name = "Базы данных"},
        new Discipline { Name = "Технологии разработки программных приложений"},
        new Discipline { Name = "Основы алгоритмизации и программирования"},
        new Discipline { Name = "Прикладные системы обработки данных"},
    };

    List<Dormitory> dormitories = new()
    {
        new Dormitory{Address = "ул. Советская, 37", Number = 3},
        new Dormitory{Address = "ул. Пушкина, 4", Number = 2},
    };

    List<EducationForm> educationForms = new()
    {
        new EducationForm { Name = "Очная" },
        new EducationForm { Name = "Заочная"},
    };

    List<Employee> employees = new()
    {
        new Employee { AcademicDegree = degrees[0], Birthday = new DateTime(1900, 1, 12), MobilePhone = "+375296451960", Name = "Володько Людвик Павлович", Salary = 5000},
        new Employee { AcademicDegree = degrees[0], Birthday = new DateTime(2000, 6, 21), MobilePhone = "+375298456154", Name = "Липский Ярослав Николаевич", Salary = 2500},
    };

    List<Group> groups = new()
    {
        new Group { Name = "20ИТ-1"},
        new Group { Name = "20ИТ-2"},
        new Group { Name = "20ИТ-3"},
        new Group { Name = "19ИТ-1"},
        new Group { Name = "19ИТ-2"},
    };

    List<Specialization> specializations = new()
    {
        new Specialization { Name = "Информационные системы и технологии (в финансово-кредитной системе)"},
    };

    List<Scholarship> scholarships = new()
    {
        new Scholarship { ScholarshipAmount = 90},
        new Scholarship { ScholarshipAmount = 110},
        new Scholarship { ScholarshipAmount = 134},
        new Scholarship { ScholarshipAmount = 150},
    };

    List<Student> students = new()
    {
        new Student { Name = "Серга Даниил Денисович", Age = 19, Dormitory=dormitories[0], Group=groups[0],EducationalForm = educationForms[0], Specialization = specializations[0], Scholarship=scholarships[0]},
        new Student { Name = "Коршунов Дмитрий Александрович", Age = 19, Dormitory=dormitories[0], Group=groups[0],EducationalForm = educationForms[1], Specialization = specializations[0], Scholarship=scholarships[1]},
        new Student { Name = "Богушевич Иван Александрович", Age = 19, Dormitory=dormitories[0], Group=groups[0],EducationalForm = educationForms[0], Specialization = specializations[0], Scholarship = scholarships[2]},
        new Student { Name = "Новик Илья Витальевич", Age = 19, Dormitory=dormitories[0], Group=groups[0],EducationalForm = educationForms[1], Specialization = specializations[0], Scholarship = scholarships[3]},
    };

    List<Person> people = new()
    {
        new Person { Name = "Дрык Станислав Вячеславович"},
    };

    List<BlockType> blockTypes = new()
    {
        new BlockType { AmountOfSeats = 4, ChairsAmount = 4, TablesAmount = 2, WardrobesAmount = 4}
    };

    List<Block> blocks = new()
    {
        new Block { Dormitory = dormitories[0], BlockType=blockTypes[0], Number = 513, Students = new List<Student> {students[0], students[1] } }
    };

    List<Parent> parents = new()
    {
        new Parent { Name = "Серга Полина Романовна", Children = new List<Student> {students[0] } },
        new Parent { Name = "Серга Денис Андреевич", Children = new List<Student> {students[0] } },
    };

    db.AcademicDegrees.AddRange(degrees);
    db.Departments.AddRange(departments);
    db.Disciplines.AddRange(disciplines);
    db.Dormitories.AddRange(dormitories);
    db.EducationForms.AddRange(educationForms);
    db.Employees.AddRange(employees);
    db.Faculties.AddRange(faculties);
    db.Groups.AddRange(groups);
    db.Specializations.AddRange(specializations);
    db.Students.AddRange(students);
    db.People.AddRange(people);
    db.BlockTypes.AddRange(blockTypes);
    db.Blocks.AddRange(blocks);
    db.Parents.AddRange(parents);
    db.Scholarships.AddRange(scholarships);

    db.SaveChanges();

    Console.WriteLine("Успех!");

}

using (ApplicationContext db = new ApplicationContext())
{
    var students = db.Students
        .Include(u => u.EducationalForm)
        .ToList();

    Console.WriteLine("Студенты:");
    foreach (Student student in students)
    {
        Console.WriteLine($"{student.Id}. {student.Name} - {student.EducationalForm.Name}");
    }
}