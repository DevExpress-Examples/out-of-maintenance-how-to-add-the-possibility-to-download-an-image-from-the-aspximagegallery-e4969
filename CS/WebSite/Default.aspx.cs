using DevExpress.Web;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    protected void ASPxImageGallery1_ItemDataBound(object source, DevExpress.Web.ImageGalleryItemEventArgs e)
    {
       e.Item.Text = "Download";
    }

}