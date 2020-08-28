<%@ Page Language="vb" AutoEventWireup="true" CodeFile="Default.aspx.vb" Inherits="_Default" %>

<%@ Register assembly="DevExpress.Web.v13.1, Version=13.1.14.0, Culture=neutral, PublicKeyToken=b88d1754d700e49a" namespace="DevExpress.Web.ASPxImageGallery" tagprefix="dx" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
	<title>ImageGallery</title>
</head>
<body>
	<form id="form1" runat="server">
		<dx:ASPxImageGallery ID="ASPxImageGallery1" SettingsTableLayout-RowsPerPage="1" ClientInstanceName="img" OnItemDataBound="ASPxImageGallery1_ItemDataBound" 
			runat="server" SettingsFolder-ImageSourceFolder="~/Images" TextVisibility="Always">
			<SettingsFullscreenViewer Visible="true" ShowTextArea="true" ShowCloseButton="true" />
			<SettingsFolder ImageCacheFolder="~\Thumb\" />
			<ItemTextTemplate>
				<asp:HyperLink ID="link" runat="server" ForeColor="White" Text='<%#Container.Item.Text%>' NavigateUrl='<%#"javascript:window.location.href=""LoadImage.aspx?ID=" & System.IO.Path.GetFileName(Container.Item.ImageUrl) & """"%>'></asp:HyperLink>
			</ItemTextTemplate>
			<FullscreenViewerItemTextTemplate>
				<asp:HyperLink ID="link" runat="server" ForeColor="White" Text='<%#Container.Item.Text%>' NavigateUrl='<%#"javascript:window.location.href=""LoadImage.aspx?ID=" & System.IO.Path.GetFileName(Container.Item.ImageUrl) & """"%>'></asp:HyperLink>
			</FullscreenViewerItemTextTemplate>
		</dx:ASPxImageGallery>
	</form>
</body>
</html>