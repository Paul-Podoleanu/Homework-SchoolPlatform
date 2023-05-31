using SchoolPlatform.Model;
using SchoolPlatform.Repositories;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolPlatform.ViewModel
{

    public class TeacherMainViewModel : ViewModelBase
    {
        //Context
        public SchoolContext SchoolContext { get; set; }

        //Repositories
        public UserRepository UserRepository { get; set; }
        public StudentRepository StudentRepository { get; set; }
        public TeacherRepository TeacherRepository { get; set; }
        public SubjectRepository SubjectRepository { get; set; }
        public ClassRepository ClassRepository { get; set; }
        public CourseRepository CourseRepository { get; set; }
        public GradeRepository GradeRepository { get; set; }
        public AbsenceRepository AbsenceRepository { get; set; }



        public List<User> Users { get; set; }
        public List<Student> Students { get; set; }
        public List<Teacher> Teachers { get; set; }
        public List<Subject> Subjects { get; set; }
        public List<Class> Classes { get; set; }
        public List<Course> Courses { get; set; }
        public List<Grade> Grades { get; set; }
        public List<Absence> Absences { get; set; }



        #region Observable Collections
        public ObservableCollection<User> OBUsers { get; set; }
        public ObservableCollection<Student> OBStudents { get; set; }
        public ObservableCollection<Teacher> OBTeachers { get; set; }
        public ObservableCollection<Subject> OBSubjects { get; set; }
        public ObservableCollection<Class> OBClasses { get; set; }
        public ObservableCollection<Course> OBCourses { get; set; }
        public ObservableCollection<Grade> OBGrades { get; set; }
        public ObservableCollection<Absence> OBAbsences { get; set; }


        //Observable collections for the class teacher
        public ObservableCollection<Student> OBClassStudents { get; set; }
        public ObservableCollection<Student> OBClassExpelStudents { get; set; }
        public ObservableCollection<Absence> OBStudentAbsences { get; set; }
        public ObservableCollection<StudentGardeAverage> OBStudentGradeAverage { get; set; }
        public ObservableCollection<StudentGardeAverage> OBStudentTopAverage { get; set; }

        #endregion

        //Selected items
        public Subject selectedSubject { get; set; }


        #region Set-up
        public void setupAccesibleSubjects(User user)
        {
            //Will put into the observable collection only the subjects that the teacher is teaching
            //Will be called in the constructor

            
            
            Teacher teacher = SchoolContext.Teachers.FirstOrDefault(t => t.User.Username == user.Username);
            OBSubjects = new ObservableCollection<Subject>(SubjectRepository.GetAll());

            /*
            foreach (Subject subject in SchoolContext.Subjects)
            {
                
                OBSubjects.Add(subject);
            }*/
            
        }
        
        void setupAccesibleStudents(User user)
        {
            //Will put into the observable collection only the students present in classes that the teacher is teaching
            //Will be called in the constructor


            Teacher teacher = SchoolContext.Teachers.FirstOrDefault(t => t.User.Id == user.Id);

            if (teacher.Classes == null)
            {
                return;
            }

            foreach (Class class_ in teacher.Classes)
            {
                foreach (Student student in class_.Students)
                {
                    OBStudents.Add(student);
                }
            }
        }

        void setupAccesibleCourses(User user)
        {
            //Will put into the observable collection only the courses from the subjects that the teacher is teaching
            //Will be called in the constructor

            Teacher teacher = SchoolContext.Teachers.FirstOrDefault(t => t.User.Id == user.Id);

            foreach (Subject subject in teacher.Subjects)
            {
                foreach (Course course in subject.Courses)
                {
                    OBCourses.Add(course);
                }
            }
        }

        void setupClassStudents(User user)
        {
            //Will put into the observable collection only the students present in the class that the teacher is a class teacher of(diriginte)
            Teacher teacher = SchoolContext.Teachers.FirstOrDefault(t => t.User.Id == user.Id);
            Class theClass = SchoolContext.Classes.FirstOrDefault(c => c.Id_teacher == teacher.Id);

            foreach (Student student in theClass.Students)
            {
                OBClassStudents.Add(student);
            }
        }
        public void setupStudentAbsences(Student student)
        {
            //Will put into the observable collection only the absences of the selected student
            //Student student = SchoolContext.Students.FirstOrDefault(s => s.User.Id == user.Id);

            if (student.Absences == null)
            {
                student.Absences = new List<Absence>();
                StudentRepository.Update(student);
                SchoolContext.SaveChanges();
                return;
            }
            foreach (Absence absence in student.Absences)
            {
                OBStudentAbsences.Add(absence);
            }
        }

        void setupClassExpelStudents(User user)
        {
            //Will put into the observable collection only the students present in the class that the teacher is a class teacher of(diriginte)
            //They are add-ed to the list if they have over n number of absences
            Teacher teacher = SchoolContext.Teachers.FirstOrDefault(t => t.User.Id == user.Id);
            Class theClass = SchoolContext.Classes.FirstOrDefault(c => c.Id_teacher == teacher.Id);

            int n = 3;

            foreach (Student student in theClass.Students)
            {
                if (student.Absences == null)
                {
                    student.Absences = new List<Absence>();
                    StudentRepository.Update(student);
                    SchoolContext.SaveChanges();
                }
                else
                {
                    if (student.Absences.Count > n)
                    {
                        OBClassExpelStudents.Add(student);
                    }
                }
            }
        }

        void setupStudentGradeAverage(User user)
        {
            Teacher teacher = SchoolContext.Teachers.FirstOrDefault(t => t.User.Id == user.Id);
            Class theClass = SchoolContext.Classes.FirstOrDefault(c => c.Id_teacher == teacher.Id);
            StudentGardeAverage studentGardeAverage;

            foreach (Student student in theClass.Students)
            {
                if(student.Grades == null)
                {
                    student.Grades = new List<Grade>();
                    StudentRepository.Update(student);
                    SchoolContext.SaveChanges();

                    studentGardeAverage = new StudentGardeAverage(student, 0);
                    OBStudentGradeAverage.Add(studentGardeAverage);
                }
                else
                {
                    OBStudentGradeAverage.Add(new StudentGardeAverage(student));
                }
            }
        }

        #endregion

        public TeacherMainViewModel(User user)
        {
            //Context and repositories
            SchoolContext = new SchoolContext();
            UserRepository = new UserRepository(SchoolContext);
            StudentRepository = new StudentRepository(SchoolContext);
            TeacherRepository = new TeacherRepository(SchoolContext);
            SubjectRepository = new SubjectRepository(SchoolContext);
            ClassRepository = new ClassRepository(SchoolContext);
            CourseRepository = new CourseRepository(SchoolContext);
            GradeRepository = new GradeRepository(SchoolContext);
            AbsenceRepository = new AbsenceRepository(SchoolContext);

            //Data Lists
            Users = UserRepository.GetAll().ToList();
            Students = StudentRepository.GetAll().ToList();
            Teachers = TeacherRepository.GetAll().ToList();
            Subjects = SubjectRepository.GetAll().ToList();
            Classes = ClassRepository.GetAll().ToList();
            Courses = CourseRepository.GetAll().ToList();
            Grades = GradeRepository.GetAll().ToList();
            Absences = SchoolContext.Absences.ToList();

            //Data acces setup
            SchoolContext.Classes.ToList<Class>();
            SchoolContext.Courses.ToList<Course>();
            SchoolContext.Grades.ToList<Grade>();
            SchoolContext.Absences.ToList<Absence>();
            SchoolContext.Students.ToList<Student>();
            SchoolContext.Teachers.ToList<Teacher>();
            SchoolContext.Subjects.ToList<Subject>();
            SchoolContext.Users.ToList<User>();


            
            //Observable collections
            OBStudents = new ObservableCollection<Student>(Students);
            OBSubjects = new ObservableCollection<Subject>(Subjects);
            OBAbsences = new ObservableCollection<Absence>(Absences);
            OBGrades = new ObservableCollection<Grade>(Grades);
            OBCourses = new ObservableCollection<Course>(Courses);

            //Observable collections For Class Teacher
            OBClassStudents = new ObservableCollection<Student>();
            OBClassExpelStudents = new ObservableCollection<Student>();
            OBStudentAbsences = new ObservableCollection<Absence>();
            OBStudentGradeAverage = new ObservableCollection<StudentGardeAverage>();


            setupClassExpelStudents(user);
            setupClassStudents(user);
            setupAccesibleStudents(user);
            setupAccesibleSubjects(user);
            setupStudentGradeAverage(user);

            OBStudentTopAverage= new ObservableCollection<StudentGardeAverage>(OBStudentGradeAverage.OrderByDescending(s => s.GradeAverage).Take(3));

        }

        #region GRADES

        internal void AddGrade(Student? student, Subject? subject, int value)
        {
            Grade newGrade = new();
            Student std = SchoolContext.Students.FirstOrDefault(s => s.Id == student.Id);
            Subject sub = SchoolContext.Subjects.FirstOrDefault(s => s.Id == subject.Id);

            newGrade.Student = std;
            newGrade.Subject = sub;
            newGrade.Value = value;

            if(std.Grades == null)
            {
                std.Grades = new List<Grade>();
            }

            std.Grades.Add(newGrade);

            GradeRepository.Insert(newGrade);
            StudentRepository.Update(std);
            SchoolContext.SaveChanges();

            OBGrades.Add(newGrade);
            
        }

        internal void RemoveGrade(int id)
        {
            Grade grade = SchoolContext.Grades.FirstOrDefault(g => g.Id == id);

            //Remove from the student
            Student student = SchoolContext.Students.FirstOrDefault(s => s.Id == grade.Student.Id);
            student.Grades.Remove(grade);

            GradeRepository.Remove(grade);
            StudentRepository.Update(student);
            SchoolContext.SaveChanges();

            OBGrades.Remove(grade);
        }



        #endregion

        #region ABSENCES
        internal void AddAbsence(Student? student, Subject? subject)
        {
            Absence absence = new();
            Student std = SchoolContext.Students.FirstOrDefault(s => s.Id == student.Id);
            Subject sub = SchoolContext.Subjects.FirstOrDefault(s => s.Id == subject.Id);

            if(std.Absences == null)
            {
                std.Absences = new List<Absence>();
            }

            absence.Student = std;
            absence.Subject = sub;

            std.Absences.Add(absence);

            AbsenceRepository.Insert(absence);
            StudentRepository.Update(std);

            SchoolContext.SaveChanges();

            OBAbsences.Add(absence);
        }

        internal void RemoveAbsence(int id)
        {
              Absence absence = SchoolContext.Absences.FirstOrDefault(a => a.Id == id);

            //Remove from the student
            Student student = SchoolContext.Students.FirstOrDefault(s => s.Id == absence.Student.Id);
            student.Absences.Remove(absence);

            AbsenceRepository.Remove(absence);
            StudentRepository.Update(student);
            SchoolContext.SaveChanges();

            OBAbsences.Remove(absence);
        }


        #endregion

        #region SUBJECTS AND COURSES
        internal void EditCourse(Course courseToBeEdited, string name, string description)
        {
            Course course = SchoolContext.Courses.FirstOrDefault(c => c.Id == courseToBeEdited.Id);
            course.Name = name;
            course.Description = description;

            CourseRepository.Update(course);
            SchoolContext.SaveChanges();

            OBCourses.Remove(courseToBeEdited);
            OBCourses.Add(course);
        }
        #endregion
    }
}
