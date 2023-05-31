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
    public class StudentMainViewModel
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

        #endregion

        #region SET-UP

        void setupGrades(User user)
        {
            Student student = SchoolContext.Students.FirstOrDefault(s => s.User.Username == user.Username);

            if (student.Grades != null)
            {
                foreach (Grade grade in student.Grades)
                {
                    OBGrades.Add(grade);
                }
            }
            else
            {
                OBGrades = new ObservableCollection<Grade>();
            }
        }

        void setupAbsences(User user)
        {
            Student student = SchoolContext.Students.FirstOrDefault(s => s.User.Username == user.Username);

            if (student.Absences != null)
            {
                foreach (Absence absence in student.Absences)
                {
                    OBAbsences.Add(absence);
                }
            }
            else
            {
                OBAbsences = new ObservableCollection<Absence>();
            }
        }

        void setupCourses(User user)
        {
            Student student = SchoolContext.Students.FirstOrDefault(s => s.User.Username == user.Username);
            Class studentClass;

            //Go to each teacher, if the tacher has a course with the student's class, add it to the list
            foreach (Teacher teacher in Teachers)
            {
                studentClass = Classes.FirstOrDefault(c => c.Id == student.Class.Id);
                if (teacher.Classes != null)
                {
                    foreach (Class teacherClass in teacher.Classes)
                    {
                        if (teacherClass.Id == studentClass.Id)
                        {

                            if (teacher.Subjects != null)
                            {
                                foreach (Subject subject in teacher.Subjects)
                                {
                                    if (subject.Courses != null)
                                    {
                                        foreach (Course course in subject.Courses)
                                        {

                                            OBCourses.Add(course);

                                        }
                                    }
                                }
                            }
                        }

                    }
                }
                
            }
        }

            #endregion

            public StudentMainViewModel(User user)
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
                OBSubjects = new ObservableCollection<Subject>();
                OBAbsences = new ObservableCollection<Absence>();
                OBGrades = new ObservableCollection<Grade>();
                OBCourses = new ObservableCollection<Course>();

                //Observable collections setup
                setupGrades(user);
                setupAbsences(user);
                setupCourses(user);

            }
        }

    }
