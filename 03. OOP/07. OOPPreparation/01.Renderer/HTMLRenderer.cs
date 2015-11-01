using System;
using System.Linq;
using System.Text;
using System.CodeDom.Compiler;
using Microsoft.CSharp;
using System.Reflection;
using System.Collections.Generic;
using System.IO;

namespace HTMLRenderer
{
	public interface IElement
	{
		string Name { get; }
		string TextContent { get; set; }
		IEnumerable<IElement> ChildElements { get; }
		void AddElement(IElement element);
		void Render(StringBuilder output);
		string ToString();
	}

	public interface ITable : IElement
	{
		int Rows { get; }
		int Cols { get; }
		IElement this[int row, int col] { get; set; }
	}

    public interface IElementFactory
    {
		IElement CreateElement(string name);
		IElement CreateElement(string name, string content);
		ITable CreateTable(int rows, int cols);
    }



    public class HTMLElementFactory : IElementFactory
    {
    	public IElement CreateElement(string name)
		{
            return new ElementТ(name);
		}

		public IElement CreateElement(string name, string content)
		{
            return new ElementТ(name, content);
		}

		public ITable CreateTable(int rows, int cols)
		{
            return new Table(rows, cols);
		}
	}

    public class ElementТ : IElement
    {
        private readonly string name;
        IEnumerable<IElement> childElements;

        public ElementТ(string name)
        {
            this.name = name;
            this.ChildElements = new List<IElement>();
        }

        public ElementТ(string name, string textContent)
            : this(name)
        {
            this.TextContent = textContent;
        }

        public string Name
        {
            get
            {
                return this.name;
            }
        }

        public virtual string TextContent { get; set; }


        public virtual IEnumerable<IElement> ChildElements
        {
            get
            {
                return this.childElements;
            }
            private set
            {
                this.childElements = value;
            }
        }

        public virtual void AddElement(IElement element)
        {
            ((IList<IElement>)this.ChildElements).Add(element);
        }

        public virtual void Render(StringBuilder output)
        {
            if (!string.IsNullOrWhiteSpace(this.Name))
            {
                output.AppendFormat("<{0}>", this.Name);
            }

            if (!string.IsNullOrWhiteSpace(this.TextContent))
            {
                for (int i = 0; i < this.TextContent.Length; i++)
                {
                    char symbol = this.TextContent[i];
                    switch (symbol)
                    {
                        case '<':
                            output.Append("&lt;");
                            break;
                        case '>':
                            output.Append("&gt;");
                            break;
                        case '&':
                            output.Append("&amp;");
                            break;
                        default:
                            output.Append(symbol);
                            break;
                    }

                }
            }

            foreach (var child in this.childElements)
            {
                output.Append(child.ToString());
            }

            if (!string.IsNullOrWhiteSpace(this.Name))
            {
                output.AppendFormat("</{0}>", this.Name);
            }
        }

        public override string ToString()
        {
            StringBuilder output = new StringBuilder();

            this.Render(output);
            return output.ToString();
        }
    }

    public class Table : ElementТ, ITable
    {
        private const string TableName = "table";
        private const string TableRowOpenTag = "<tr>";
        private const string TableRowCloseTag = "</tr>";
        private const string TableCellOpenTag = "<td>";
        private const string TableCellCloseTag = "</td>";

        private int rows;
        private int cols;
        private IElement[,] cells;

        public Table(int rows, int cols)
            : base(TableName)
        {
            this.Rows = rows;
            this.Cols = cols;
            this.cells = new IElement[this.Rows, this.Cols];
        }

        public int Rows
        {
            get
            {
                return this.rows;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException();
                }

                this.rows = value;
            }
        }

        public int Cols
        {
            get
            {
                return this.cols;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException();
                }

                this.cols = value;
            }
        }

        public IElement this[int row, int col]
        {
            get
            {
                if (row < 0 || row >= this.Rows || col < 0 || col >= this.Cols)
                {
                    throw new ArgumentOutOfRangeException();
                }
                return this.cells[row, col];
            }
            set
            {
                if (row < 0 || row >= this.Rows || col < 0 || col >= this.Cols)
                {
                    throw new ArgumentOutOfRangeException();
                }
                if (value == null)
                {
                    throw new ArgumentNullException();
                }
                this.cells[row, col] = value;
            }
        }

        public override string TextContent
        {
            get
            {
                throw new InvalidOperationException();
            }
            set
            {
                throw new InvalidOperationException();
            }
        }


        public override IEnumerable<IElement> ChildElements
        {
            get { throw new InvalidOperationException(); }
        }

        public override void AddElement(IElement element)
        {
            throw new InvalidOperationException();
        }

        public override void Render(StringBuilder output)
        {
            output.AppendFormat("<{0}>", this.Name);
            for (int row = 0; row < this.Rows; row++)
            {
                output.Append(TableRowOpenTag);
                for (int col = 0; col < this.Cols; col++)
                {
                    output.Append(TableCellOpenTag);

                    output.Append(this.cells[row, col]);

                    output.Append(TableCellCloseTag);
                }
                output.Append(TableRowCloseTag);
            }
            output.AppendFormat("</{0}>", this.Name);
        }
    }

    public class HTMLRendererCommandExecutor
    {
        static void Main()
        {
            string csharpCode = ReadInputCSharpCode();
            CompileAndRun(csharpCode);
        }

        private static string ReadInputCSharpCode()
        {
            StringBuilder result = new StringBuilder();
            StreamReader reader = new StreamReader("input.txt");
            Console.SetIn(reader);
            string line;
            while ((line = reader.ReadLine()) != "")
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
                  using HTMLRenderer;

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
