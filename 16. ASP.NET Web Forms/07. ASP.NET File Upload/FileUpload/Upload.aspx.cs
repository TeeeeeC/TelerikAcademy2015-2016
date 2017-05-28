using System;
using System.IO;

using Ionic.Zip;

namespace FileUpload
{
    public partial class Upload : System.Web.UI.Page
    {
        private FileUploadEntities context = new FileUploadEntities();

        protected void Page_Load(object sender, EventArgs e)
        {
            this.Response.Expires = -1;

            try
            {
                var fileStream = this.Request.Files["uploaded"].InputStream;

                using (var archive = ZipFile.Read(fileStream))
                {
                    foreach (var entry in archive.Entries)
                    {
                        if (entry.FileName.EndsWith(".txt", StringComparison.OrdinalIgnoreCase))
                        {
                            var memoryStream = new MemoryStream();
                            var streamReader = new StreamReader(memoryStream);

                            entry.Extract(memoryStream);
                            memoryStream.Seek(0, SeekOrigin.Begin);

                            var zipFileContent = streamReader.ReadToEnd();
                            this.context.Files.Add(new File()
                            {
                                Content = zipFileContent
                            });

                            this.context.SaveChanges();
                        }
                    }
                }

                this.Response.ContentType = "application/json";
                this.Response.Write("{}");
            }
            catch (Exception ex)
            {
                this.Response.Write(ex.ToString());
            }
        }
    }
}