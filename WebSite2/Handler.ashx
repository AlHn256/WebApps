<%@ WebHandler Language="C#" Class="Handler" %>

using System;
using System.Web;
using System.Web.Script.Serialization;

public class Handler : IHttpHandler {
    
    public void ProcessRequest (HttpContext context) {
        context.Response.ContentType = "text/plain";
        context.Response.Write("Hello World");

        var result = new
        {
            date ="January 2019",
            CID = 4,
            name= "KSS Energia Oy"
        };


        JavaScriptSerializer js = new JavaScriptSerializer();
        context.Response.Write(js.Serialize(result));
    }
 
    public bool IsReusable {
        get {
            return false;
        }
    }

}