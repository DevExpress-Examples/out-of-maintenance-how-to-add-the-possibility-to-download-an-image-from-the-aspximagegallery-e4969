Imports Microsoft.VisualBasic
Imports System
Imports System.Collections.Generic
Imports System.Linq
Imports System.Web
Imports System.Web.UI
Imports System.Web.UI.WebControls

Partial Public Class LoadImage
	Inherits System.Web.UI.Page
	Protected Sub Page_Load(ByVal sender As Object, ByVal e As EventArgs)
		If Request.Params("ID") IsNot Nothing Then
			Dim fileName As String = Request.Params("ID").Split("?"c)(0)
			Dim filePath As String = Server.MapPath("Images/" & fileName)
			Response.AddHeader("Content-Disposition", "attachment; filename=" & fileName)
			Response.ContentType = "image/x-jpg"
			Response.TransmitFile(filePath)
			Response.End()
		End If
	End Sub
End Class