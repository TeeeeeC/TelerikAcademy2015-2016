<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Index.aspx.cs" Inherits="FileUpload.Index" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="http://kendo.cdn.telerik.com/2016.1.112/styles/kendo.common.min.css" rel="stylesheet"/>
    <link href="http://kendo.cdn.telerik.com/2016.1.112/styles/kendo.default.min.css" rel="stylesheet"/>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/2.2.0/jquery.min.js"></script>
    <script src="http://kendo.cdn.telerik.com/2016.1.112/js/kendo.web.min.js"></script>
</head>
<body>
    <input name="uploaded" id="uploaded" type="file" runat="server" />
        
    <script>
        $(document).ready(function () {
            $("#uploaded").kendoUpload({
                async: {
                    saveUrl: "Upload.aspx",
                    autoUpload: true
                }
            });
        });
    </script>
</body>
</html>
