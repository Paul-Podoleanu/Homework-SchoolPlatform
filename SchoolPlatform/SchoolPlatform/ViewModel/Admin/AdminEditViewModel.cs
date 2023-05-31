using GalaSoft.MvvmLight.Command;
using SchoolPlatform.Model;
using SchoolPlatform.Repositories;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace SchoolPlatform.ViewModel
{
    public class AdminEditViewModel : ViewModelBase
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


        //Data sets
        public List<User> Users { get; set; }
        public List<Student> Students { get; set; }
        public List<Teacher> Teachers { get; set; }
        public List<Subject> Subjects { get; set; }
        public List<Class> Classes { get; set; }
        public List<Course> Courses { get; set; }

        #region Observable Collections
        public ObservableCollection<User> OBUsers { get; set; }
        public ObservableCollection<Student> OBStudents { get; set; }
        public ObservableCollection<Teacher> OBTeachers { get; set; }
        public ObservableCollection<Subject> OBSubjects { get; set; }
        public ObservableCollection<Class> OBClasses { get; set; }
        public ObservableCollection<Course> OBCourses { get; set; }
        #endregion


        #region Selectable Objects For Adding/Deleting
        public User SelectedUser { get; set; }
        public Student SelectedStudent { get; set; }
        public Teacher SelectedTeacher { get; set; }
        public Subject SelectedSubject { get; set; }
        public Class SelectedClass { get; set; }
        public Course SelectedCourse { get; set; }
        #endregion

        //Comands
        public RelayCommand? UpdateStudentList;



        public AdminEditViewModel()
        {
            //Context and repositories
            SchoolContext = new SchoolContext();
            UserRepository = new UserRepository(SchoolContext);
            StudentRepository = new StudentRepository(SchoolContext);
            TeacherRepository = new TeacherRepository(SchoolContext);
            SubjectRepository = new SubjectRepository(SchoolContext);
            ClassRepository = new ClassRepository(SchoolContext);
            CourseRepository = new CourseRepository(SchoolContext);

            //Data Lists
            Users = UserRepository.GetAll().ToList();
            Students = StudentRepository.GetAll().ToList();
            Teachers = TeacherRepository.GetAll().ToList();
            Subjects = SubjectRepository.GetAll().ToList();
            Classes = ClassRepository.GetAll().ToList();
            Courses = CourseRepository.GetAll().ToList();

            //Observable Collections
            OBUsers = new ObservableCollection<User>(Users);
            OBStudents = new ObservableCollection<Student>(Students);
            OBTeachers = new ObservableCollection<Teacher>(Teachers);
            OBSubjects = new ObservableCollection<Subject>(Subjects);
            OBClasses = new ObservableCollection<Class>(Classes);
            OBCourses = new ObservableCollection<Course>(Courses);

            //Selectable Objects For Adding/Deleting
            SelectedUser = new User();
            SelectedStudent = new Student();
            SelectedTeacher = new Teacher();
            SelectedSubject = new Subject();
            SelectedCourse = new Course();
            SelectedClass = new Class();


            //Commands
            UpdateStudentList = new RelayCommand(UpdateStudentListExecute);
        }

        private void UpdateStudentListExecute()
        {
            //NEED TO DO
        }



        #region STUDENT MANAGEMENT
        public void AddStudent(string firstName, string lastName, string username, string password)
        {
            //This also creates a brand new user for the added student
            User auxUser = new User();
            auxUser.Username = username;
            auxUser.Password = password;
            auxUser.Role = Role.elev;
            auxUser.FirstName = firstName;
            auxUser.LastName = lastName;

            UserRepository.Insert(auxUser);
            SchoolContext.SaveChanges();
            OBUsers.Add(auxUser);

            Student auxStudent = new Student();
            auxStudent.User = auxUser;
            auxStudent.Nume = lastName;
            auxStudent.Prenume = firstName;

            StudentRepository.Insert(auxStudent);
            OBStudents.Add(auxStudent);


            OnPropertyChanged(nameof(OBUsers));
            OnPropertyChanged(nameof(OBStudents));
            SchoolContext.SaveChanges();
        }


        public void DeleteStudent(Student student)
        {
            User auxUser = student.User;
            Student auxStudent = SchoolContext.Students.Find(student.Id);
            auxUser = SchoolContext.Users.Find(auxUser.Id);

            StudentRepository.Remove(auxStudent);
            OBStudents.Remove(auxStudent);

            UserRepository.Remove(auxUser);
            OBUsers.Remove(auxUser);

            SchoolContext.SaveChanges();
        }


        public void EditStudent(string firstName, string lastName, string username, string password, Student studentToBeEdited)
        {
            Student auxStudent = SchoolContext.Students.Find(studentToBeEdited.Id);
            User auxUser = SchoolContext.Users.FirstOrDefault(u => u.Id == auxStudent.User.Id);


            OBStudents.Remove(auxStudent);
            OBUsers.Remove(auxUser);

            auxUser.FirstName = firstName;
            auxUser.LastName = lastName;
            auxUser.Username = username;
            auxUser.Password = password;

            auxStudent.Nume = lastName;
            auxStudent.Prenume = firstName;

            StudentRepository.Update(auxStudent);
            UserRepository.Update(auxUser);

            OBStudents.Add(auxStudent);
            OBUsers.Add(auxUser);

            SchoolContext.SaveChanges();

        }

        #endregion


        #region TEACHER MANAGEMENT
        public void AddTeacher(string firstName, string lastName, string username, string password)
        {
            //This also creates a brand new user for the added teacher

            //The teacher starts with role "profesor", if he is also a class teacher, the role
            //will be changed to "diriginte" in the class management tab

            User auxUser = new User();
            auxUser.Username = username;
            auxUser.Password = password;
            auxUser.Role = Role.profesor;
            auxUser.FirstName = firstName;
            auxUser.LastName = lastName;


            Teacher auxTeacher = new Teacher();
            auxTeacher.User = auxUser;
            auxTeacher.LastName = lastName;
            auxTeacher.FirstName = firstName;


            UserRepository.Insert(auxUser);
            TeacherRepository.Insert(auxTeacher);
            SchoolContext.SaveChanges();

            OBUsers.Add(auxUser);
            OBTeachers.Add(auxTeacher);
        }

        public void DeleteTeacher(Teacher teacher)
        {
            User auxUser = teacher.User;
            Teacher auxTeacher = SchoolContext.Teachers.Find(teacher.Id);
            auxUser = SchoolContext.Users.Find(auxUser.Id);

            TeacherRepository.Remove(auxTeacher);
            OBTeachers.Remove(auxTeacher);

            UserRepository.Remove(auxUser);
            OBUsers.Remove(auxUser);

            SchoolContext.SaveChanges();
        }

        public void EditTeacher(string firstName, string lastName, string username, string password, Teacher teacherToBeEdited)
        {
            Teacher auxTeacher = SchoolContext.Teachers.Find(teacherToBeEdited.Id);
            User auxUser = SchoolContext.Users.FirstOrDefault(u => u.Id == auxTeacher.User.Id);

            OBUsers.Remove(auxUser);
            OBTeachers.Remove(auxTeacher);


            auxUser.FirstName = firstName;
            auxUser.LastName = lastName;
            auxUser.Username = username;
            auxUser.Password = password;

            auxTeacher.LastName = lastName;
            auxTeacher.FirstName = firstName;

            TeacherRepository.Update(auxTeacher);
            UserRepository.Update(auxUser);

            SchoolContext.SaveChanges();
        }
        #endregion


        #region SUBJECT MANAGEMENT
        public void AddSubject(string Name)
        {
            Subject subject = new Subject();
            subject.Name = Name;
            subject.Courses = new List<Course>();
            subject.Teachers = new List<Teacher>();

            SubjectRepository.Insert(subject);
            SchoolContext.SaveChanges();

            OBSubjects.Add(subject);
        }

        public void DeleteSubject(Subject subject)
        {
            //Delete all the courses that have this subject
            Subject auxSubject = SchoolContext.Subjects.Find(subject.Id);

            if (auxSubject.Courses != null)
            {
                foreach (Course course in auxSubject.Courses)
                {
                    CourseRepository.Remove(course);
                    OBCourses.Remove(course);
                }
            }
            SubjectRepository.Remove(auxSubject);
            OBSubjects.Remove(auxSubject);
            SchoolContext.SaveChanges();
        }
        #endregion


        #region COURSE MANAGEMENT
        public void AddCourse(Subject subject, string CourseName)
        {
            Course course = new Course();
            Subject subjectAux = SchoolContext.Subjects.FirstOrDefault(s => s.Id == subject.Id);

            course.Name = CourseName;
            course.Description = "No description";

            if (subjectAux.Courses == null)
            {
                subjectAux.Courses = new List<Course>();
            }

            //Repo Work
            SubjectRepository.Update(subjectAux);
            CourseRepository.Insert(course);
            SchoolContext.SaveChanges();


            subjectAux.Courses.Add(course);
            OBCourses.Add(course);
        }

        public void DeleteCourse(Course searchedCourse)
        {
            Course course = SchoolContext.Courses.Find(searchedCourse.Id);
            CourseRepository.Remove(course);
            OBCourses.Remove(course);
            SchoolContext.SaveChanges();
        }
        #endregion


        #region CLASS MANAGEMENT
        public void AddClass(string Name, int YearOfStudy)
        {
            Class cls = new Class();
            cls.Name = Name;
            cls.YearOfStudy = YearOfStudy;

            ClassRepository.Insert(cls);
            SchoolContext.SaveChanges();

            OBClasses.Add(cls);


        }

        public void DeleteClass(Class classToBeDeleted)
        {
            //The class should also be removed from the teachers that are class teachers
            //The students should also be removed from the class
            Class cls = SchoolContext.Classes.Find(classToBeDeleted.Id);
            ClassRepository.Remove(cls);
            OBClasses.Remove(cls);

            Teacher teacher = SchoolContext.Teachers.FirstOrDefault(t => t.Class.Id == cls.Id);
            if (teacher != null)
            {
                teacher.Class = null;
                teacher.Classes.Remove(cls);
                TeacherRepository.Update(teacher);
            }

            foreach (Student student in cls.Students)
            {
                if (student.Class == cls)
                {
                    student.Class = null;
                    StudentRepository.Update(student);
                }

            }

            SchoolContext.SaveChanges();
        }

        public void AddStudentToClass(Student searchedStudent, Class searchedClass)
        {
            Class cls = SchoolContext.Classes.Find(searchedClass.Id);
            Student student = SchoolContext.Students.Find(searchedStudent.Id);

            OBStudents.Remove(student);

            //Assign the class as the class of the student
            student.Class = cls;

            //Add the student to the class
            if (cls.Students == null)
            {
                cls.Students = new List<Student>();
            }
            cls.Students.Add(student);

            //Update database

            StudentRepository.Update(student);
            ClassRepository.Update(cls);
            SchoolContext.SaveChanges();

            OBStudents.Add(student);
        }

        internal void RemoveStudentToClass(Student searchedStudent, Class searchedClass)
        {
            Class cls = SchoolContext.Classes.Find(searchedClass.Id);
            Student student = SchoolContext.Students.Find(searchedStudent.Id);

            OBStudents.Remove(student);

            //Remove the class as the class of the student
            student.Class = null;

            //Remove the student from the class
            cls.Students.Remove(student);

            //Update database

            StudentRepository.Update(student);
            ClassRepository.Update(cls);
            SchoolContext.SaveChanges();

            OBStudents.Add(student);

        }

        internal void AssignTeacherToClass(Teacher searchedTeacher, Class searchedClass)
        {
            Class cls = SchoolContext.Classes.Find(searchedClass.Id);
            Teacher tch = SchoolContext.Teachers.Find(searchedTeacher.Id);

            if(tch.Classes == null)
            {
                tch.Classes=new List<Class>();
            }

            tch.Classes.Add(cls);

            TeacherRepository.Update(tch);
            SchoolContext.SaveChanges();


        }

        internal void RemoveTeacherFromClass(Teacher searchedTeacher, Class searchedClass)
        {
            Class cls = SchoolContext.Classes.Find(searchedClass.Id);
            Teacher tch = SchoolContext.Teachers.Find(searchedTeacher.Id);

            tch.Classes.Remove(cls);

            TeacherRepository.Update(tch);
            SchoolContext.SaveChanges();
        }


        internal void AssignClassTeacher(Teacher searchedTeacher, Class searchedClass)
        {
            Class cls = SchoolContext.Classes.Find(searchedClass.Id);
            Teacher tch = SchoolContext.Teachers.Find(searchedTeacher.Id);
            User user = SchoolContext.Users.Find(tch.User.Id);

            OBClasses.Remove(cls);
            OBTeachers.Remove(tch);

            //Assign teacher to class
            cls.Id_teacher=tch.Id;

            //Assign class to teacher
            tch.Class=cls;

            //Change Role
            user.Role=Role.diriginte;

            //Update Observable Lists
            OBClasses.Add(cls);
            OBTeachers.Add(tch);

            //Update database
            TeacherRepository.Update(tch);
            ClassRepository.Update(cls);
            SchoolContext.SaveChanges();
        }

        internal void RemoveClassTeacher(Teacher searchedTeacher, Class searchedClass)
        {
            Class cls = SchoolContext.Classes.Find(searchedClass.Id);
            Teacher tch = SchoolContext.Teachers.Find(searchedTeacher.Id);
            User user = SchoolContext.Users.Find(tch.User.Id);

            OBClasses.Remove(cls);
            OBTeachers.Remove(tch);

            //Remove teacher from class
            cls.Id_teacher = null;

            //Remove class from teacher
            tch.Class = null;

            //Change Role
            user.Role = Role.profesor;

            //Update Observable Lists
            OBClasses.Add(cls);
            OBTeachers.Add(tch);

            //Update database
            TeacherRepository.Update(tch);
            ClassRepository.Update(cls);
            SchoolContext.SaveChanges();

        }


        #endregion
    }
}
