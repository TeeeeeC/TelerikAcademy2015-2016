namespace TreesAndTraversals.Tasks
{
    using System.Collections.Generic;

    public class Folder
    {
        public Folder()
        {
            this.Files = new HashSet<File>();
            this.ChildFolders = new HashSet<Folder>();
        }

        public string Name { get; set; }

        public ISet<File> Files { get; set; }

        public ISet<Folder> ChildFolders { get; set; }
    }
}
