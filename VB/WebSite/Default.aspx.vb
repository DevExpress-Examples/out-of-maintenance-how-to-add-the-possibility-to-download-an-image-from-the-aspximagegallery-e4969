Imports Microsoft.VisualBasic
Imports DevExpress.Web
Imports System
Imports System.Collections.Generic
Imports System.IO
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls

Partial Public Class _Default
	Inherits System.Web.UI.Page
	Protected Sub ASPxImageGallery1_ItemDataBound(ByVal source As Object, ByVal e As DevExpress.Web.ImageGalleryItemEventArgs)
	   e.Item.Text = "Download"
	End Sub

End Class