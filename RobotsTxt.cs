using System.IO;
using System.Web;

namespace ChordsTech.MultiSiteRobots
{
  public class RobotsTxt : IHttpHandler
  {
    public void ProcessRequest(HttpContext context)
    {
      context.Response.ContentType = "text/plain";
            string domain = HttpContext.Current.Request.ServerVariables["HTTP_HOST"];

      string path = HttpContext.Current.Server.MapPath(string.Concat("~/", domain, ".robots.txt"));
      if (File.Exists(path))
      {
        StreamReader streamReader = File.OpenText(path);
        string end = streamReader.ReadToEnd();
        context.Response.Write(end);
        streamReader.Close();
        streamReader.Dispose();
      }
      else
        context.Response.Write("");
    }

    public bool IsReusable
    {
      get
      {
        return true;
      }
    }
  }
}
