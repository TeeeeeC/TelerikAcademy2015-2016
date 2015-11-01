using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.CodeDom.Compiler;
using Microsoft.CSharp;
using System.Reflection;

namespace SoftwareAcademy
{
    public interface ITeacher
    {
        string Name { get; set; }
        void AddCourse(ICourse course);
        string ToString();
    }

    public class Teacher : ITeacher
    {
        private string name;
        private IList<ICourse> allCourses;

        public Teacher(string name)
        {
            this.Name = name;
            this.allCourses = new List<ICourse>();
        }

        public string Name 
        { 
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be empty!");
                }
                this.name = value;
            }
        }

        public IList<ICourse> AllCoursesInfo 
        { 
            get
            {
                return this.allCourses;
            }
        }

        public void AddCourse(ICourse course)
        {
            this.allCourses.Add(course);
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();

            output.AppendFormat("Teacher: Name={0}", this.Name);
            if (this.AllCoursesInfo.Count > 0)
            {
                output.Append("; Courses=[");
                for (int i = 0; i < this.AllCoursesInfo.Count; i++)
                {
                    output.Append(this.AllCoursesInfo[i].Name);
                    if (i < this.AllCoursesInfo.Count - 1)
                    {
                        output.Append(", ");
                    }
                }
                output.Append("]");
            }
            return output.ToString();
        }
    }

    public interface ICourse
    {
        string Name { get; set; }
        ITeacher Teacher { get; set; }
        void AddTopic(string topic);
        string ToString();
    }

    public abstract class Course : ICourse
    {
        private string name;
        private ITeacher teacher;
        private IList<string> allTopics;

        public Course(string name, ITeacher teacher)
        {
            this.Name = name;
            this.Teacher = teacher;
            this.allTopics = new List<string>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Name cannot be empty!");
                }
                this.name = value;
            }
        }

        public ITeacher Teacher
        {
            get
            {
                return this.teacher;
            }
            set
            {
                if(value == null)
                {
                    this.teacher = null;
                }
                else
                {
                    this.teacher = value;
                }
            }
        }

        public IList<string> AllTopicsInfo 
        { 
            get
            {
                return this.allTopics;
            }
        }

        public void AddTopic(string topic)
        {
            this.allTopics.Add(topic);
        }
    }

    public interface ILocalCourse : ICourse
    {
        string Lab { get; set; }
    }

    public class LocalCourses : Course, ILocalCourse
    {
        private string lab;

        public LocalCourses(string name, ITeacher teacher, string lab)
            : base(name, teacher)
        {
            this.Lab = lab;
        }

        public string Lab
        {
            get
            {
                return this.lab;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Lab cannot be empty!");
                }
                this.lab = value;
            }
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();

            output.AppendFormat("LocalCourse: Name={0}", this.Name);
            if(this.Teacher.Name != null)
            {
                output.AppendFormat("; Teacher={0}", this.Teacher.Name);
            }
            if (this.AllTopicsInfo.Count > 0)
            {
                output.Append("; Topics=[");
                for (int i = 0; i < this.AllTopicsInfo.Count; i++)
                {
                    output.Append(this.AllTopicsInfo[i]);
                    if (i < this.AllTopicsInfo.Count - 1)
                    {
                        output.Append(", ");
                    }
                }
                output.Append("]");
            }
            output.AppendFormat("; Lab={0}", this.Lab);
            return output.ToString();
        }
    }

    public interface IOffsiteCourse : ICourse
    {
        string Town { get; set; }
    }

    public class OffsiteCourse : Course, IOffsiteCourse
    {
        private string town;

        public OffsiteCourse(string name, ITeacher teacher, string town)
            : base(name, teacher)
        {
            this.Town = town;
        }

        public string Town
        {
            get
            {
                return this.town;
            }
            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Town cannot be empty!");
                }
                this.town = value;
            }
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();

            output.AppendFormat("OffsiteCourse: Name={0}", this.Name);
            if (this.Teacher.Name != null)
            {
                output.AppendFormat("; Teacher={0}", this.Teacher.Name);
            }
            if (this.AllTopicsInfo.Count > 0)
            {
                output.Append("; Topics=[");
                for (int i = 0; i < this.AllTopicsInfo.Count; i++)
                {
                    output.Append(this.AllTopicsInfo[i]);
                    if (i < this.AllTopicsInfo.Count - 1)
                    {
                        output.Append(", ");
                    }
                }
                output.Append("]");
            }
            output.AppendFormat("; Town={0}", this.Town);
            return output.ToString();
        }
    }

    public interface ICourseFactory
    {
        ITeacher CreateTeacher(string name);
        ILocalCourse CreateLocalCourse(string name, ITeacher teacher, string lab);
        IOffsiteCourse CreateOffsiteCourse(string name, ITeacher teacher, string town);
    }

    public class CourseFactory : ICourseFactory
    {
        public ITeacher CreateTeacher(string name)
        {
            return new Teacher(name);
        }

        public ILocalCourse CreateLocalCourse(string name, ITeacher teacher, string lab)
        {
            return new LocalCourses(name, teacher, lab);
        }

        public IOffsiteCourse CreateOffsiteCourse(string name, ITeacher teacher, string town)
        {
            return new OffsiteCourse(name, teacher, town);
        }
    }

    public class SoftwareAcademyCommandExecutor
    {
        static void Main()
        {
            string csharpCode = ReadInputCSharpCode();
            CompileAndRun(csharpCode);
        }

        private static string ReadInputCSharpCode()
        {
            StringBuilder result = new StringBuilder();
            string line;
            while ((line = Console.ReadLine()) != "")
            {
                result.AppendLine(line);
            }
            return result.ToString();
        }

        static void CompileAndRun(string csharpCode)
        {
            // Prepare a C# program for compilation
            string[] csharpClass =
            {
                @"using System;
                  using SoftwareAcademy;

                  public class RuntimeCompiledClass
                  {
                     public static void Main()
                     {"
                        + csharpCode + @"
                     }
                  }"
            };

            // Compile the C# program
            CompilerParameters compilerParams = new CompilerParameters();
            compilerParams.GenerateInMemory = true;
            compilerParams.TempFiles = new TempFileCollection(".");
            compilerParams.ReferencedAssemblies.Add("System.dll");
            compilerParams.ReferencedAssemblies.Add(Assembly.GetExecutingAssembly().Location);
            CSharpCodeProvider csharpProvider = new CSharpCodeProvider();
            CompilerResults compile = csharpProvider.CompileAssemblyFromSource(
                compilerParams, csharpClass);

            // Check for compilation errors
            if (compile.Errors.HasErrors)
            {
                string errorMsg = "Compilation error: ";
                foreach (CompilerError ce in compile.Errors)
                {
                    errorMsg += "\r\n" + ce.ToString();
                }
                throw new Exception(errorMsg);
            }

            // Invoke the Main() method of the compiled class
            Assembly assembly = compile.CompiledAssembly;
            Module module = assembly.GetModules()[0];
            Type type = module.GetType("RuntimeCompiledClass");
            MethodInfo methInfo = type.GetMethod("Main");
            methInfo.Invoke(null, null);
        }
    }
}
