using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class LoadImage : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (Request.Params["ID"] != null)
        {
            string fileName = Request.Params["ID"].Split('?')[0];
            string filePath = Server.MapPath("Images/" + fileName);
            Response.AddHeader("Content-Disposition", "attachment; filename=" + fileName);
            Response.ContentType = "image/x-jpg";
            Response.TransmitFile(filePath);
            Response.End();
        }
    }
}