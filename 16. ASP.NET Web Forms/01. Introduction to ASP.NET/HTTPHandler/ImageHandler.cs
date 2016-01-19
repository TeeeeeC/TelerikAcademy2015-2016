using System;
using System.Drawing;
using System.Drawing.Imaging;
using System.Web;

namespace HTTPHandler
{
    public class ImageHandler : IHttpHandler
    {
        public bool IsReusable
        {
            get
            {
                return false;
            }
        }

        public void ProcessRequest(HttpContext context)
        {
            Bitmap bmp = new Bitmap(1000, 800);
            Graphics g = Graphics.FromImage(bmp);
            g.DrawString(context.Request.Url.ToString(), new Font("Arial", 30), new SolidBrush(Color.Yellow), new PointF(10f, 10f));

            context.Response.ContentType = "image/png";
            bmp.Save(context.Response.OutputStream, ImageFormat.Png);
        }
    }
}
