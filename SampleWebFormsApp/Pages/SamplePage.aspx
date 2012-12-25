<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="SamplePage.aspx.cs" Inherits="SampleWebFormsApp.Pages.SamplePage" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
    <div>
	    <h1>Sample page</h1>
		Injected text: <asp:Label runat="server" ID="lblInjectedText"></asp:Label>
		Current time: <asp:Label runat="server" ID="lblCurrentTime"></asp:Label>
    </div>
    </form>
</body>
</html>
