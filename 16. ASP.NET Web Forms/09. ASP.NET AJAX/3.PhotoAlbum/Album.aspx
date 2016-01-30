<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Album.aspx.cs" Inherits="_3.PhotoAlbum.Album" %>


<%@ Register Assembly="AjaxControlToolkit"
    Namespace="AjaxControlToolkit"
    TagPrefix="ajaxtoolkit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="MainForm" runat="server">
        <asp:ScriptManager runat="Server" />
        <table border="0">
            <tr>
                <td>
                    <asp:Button ID="btnPrevious" runat="server" Text="<<" Font-Size="20" />
                </td>
                <td>
                    <asp:Image ID="Image1" runat="server" Height="300" Width="300" />
                    <ajaxtoolkit:SlideShowExtender ID="SlideShowExtender" runat="server" TargetControlID="Image1"
                        SlideShowServiceMethod="GetImages" ImageTitleLabelID="lblImageTitle" ImageDescriptionLabelID="lblImageDescription"
                        AutoPlay="true" PlayInterval="1000" Loop="true" PlayButtonID="btnPlay" StopButtonText="Stop"
                        PlayButtonText="Play" NextButtonID="btnNext" PreviousButtonID="btnPrevious">
                    </ajaxtoolkit:SlideShowExtender>
                </td>
                <td>
                    <asp:Button ID="btnNext" runat="server" Text=">>" Font-Size="20" />
                </td>
            </tr>
            <tr>
                <td colspan="3">
                    <asp:Button ID="btnPlay" runat="server" Text="Play" Font-Size="20" />
                </td>
            </tr>
            <tr>
                <td colspan="3">
                    <br />
                    <b>Name:</b>
                    <asp:Label ID="lblImageTitle" runat="server" Text="Label" /><br />
                    <b>Description:</b>
                    <asp:Label ID="lblImageDescription" runat="server" Text="Label" />
                </td>
            </tr>
        </table>
    </form>
</body>
</html>
