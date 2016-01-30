<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Chat.aspx.cs" Inherits="_2.Chat.Chat" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="MainForm" runat="server">
        <asp:ScriptManager ID="ScriptManager" runat="server" />
        <h1>Chat Room</h1>
        <asp:UpdatePanel runat='server' ID='UpdatePanelTime' UpdateMode="Conditional">
            <Triggers>
                <asp:AsyncPostBackTrigger ControlID="TimerTimeRefresh" EventName="Tick" />
            </Triggers>
            <ContentTemplate>
                <asp:SqlDataSource ID="SqlDataSourceMessages" runat="server" 
                    ConnectionString="<%$ ConnectionStrings:ChatConnectionString %>" 
                    SelectCommand="SELECT TOP 100 * FROM [Messages]" InsertCommand="INSERT INTO Messages VALUES (@content)">
                    <InsertParameters>
                        <asp:Parameter Name="content" />
                    </InsertParameters>
                </asp:SqlDataSource>
                <asp:ListView ID="ListView1" runat="server" DataKeyNames="Id" DataSourceID="SqlDataSourceMessages">
                    <AlternatingItemTemplate>
                        <span style="background-color: #FAFAD2;color: #284775;">Id:
                        <asp:Label ID="IdLabel" runat="server" Text='<%# Eval("Id") %>' />
                        <br />
                        Content:
                        <asp:Label ID="ContentLabel" runat="server" Text='<%# Eval("Content") %>' />
                        <br />
                        <br />
                        </span>
                    </AlternatingItemTemplate>
                    <EditItemTemplate>
                        <span style="background-color: #FFCC66;color: #000080;">Id:
                        <asp:Label ID="IdLabel1" runat="server" Text='<%# Eval("Id") %>' />
                        <br />
                        Content:
                        <asp:TextBox ID="ContentTextBox" runat="server" Text='<%# Bind("Content") %>' />
                        <br />
                        <asp:Button ID="UpdateButton" runat="server" CommandName="Update" Text="Update" />
                        <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Cancel" />
                        <br />
                        <br />
                        </span>
                    </EditItemTemplate>
                    <EmptyDataTemplate>
                        <span>No data was returned.</span>
                    </EmptyDataTemplate>
                    <ItemTemplate>
                        <span style="background-color: #FFFBD6;color: #333333;">Id:
                        <asp:Label ID="IdLabel" runat="server" Text='<%# Eval("Id") %>' />
                        <br />
                        Content:
                        <asp:Label ID="ContentLabel" runat="server" Text='<%# Eval("Content") %>' />
                        <br />
                        <br />
                        </span>
                    </ItemTemplate>
                    <LayoutTemplate>
                        <div id="itemPlaceholderContainer" runat="server" style="font-family: Verdana, Arial, Helvetica, sans-serif;">
                            <span runat="server" id="itemPlaceholder" />
                        </div>
                        <div style="text-align: center;background-color: #FFCC66;font-family: Verdana, Arial, Helvetica, sans-serif;color: #333333;">
                            <asp:DataPager ID="DataPager1" runat="server">
                                <Fields>
                                    <asp:NextPreviousPagerField ButtonType="Button" ShowFirstPageButton="True" ShowNextPageButton="False" ShowPreviousPageButton="False" />
                                    <asp:NumericPagerField />
                                    <asp:NextPreviousPagerField ButtonType="Button" ShowLastPageButton="True" ShowNextPageButton="False" ShowPreviousPageButton="False" />
                                </Fields>
                            </asp:DataPager>
                        </div>
                    </LayoutTemplate>
                    <SelectedItemTemplate>
                        <span style="background-color: #FFCC66;font-weight: bold;color: #000080;">Id:
                        <asp:Label ID="IdLabel" runat="server" Text='<%# Eval("Id") %>' />
                        <br />
                        Content:
                        <asp:Label ID="ContentLabel" runat="server" Text='<%# Eval("Content") %>' />
                        <br />
                        <br />
                        </span>
                    </SelectedItemTemplate>
                </asp:ListView>
            </ContentTemplate>
        </asp:UpdatePanel>
        <asp:Timer ID="TimerTimeRefresh" runat="Server" Interval="500" />
        <asp:ListView ID="ListView2" runat="server" DataKeyNames="Id" DataSourceID="SqlDataSourceMessages" InsertItemPosition="LastItem">
            <ItemTemplate>
                    </ItemTemplate>
            <InsertItemTemplate>
                        <span style="">Content:
                        <asp:TextBox ID="ContentTextBox" runat="server" Text='<%# Bind("Content") %>' />
                        <br />
                        <asp:Button ID="InsertButton" runat="server" CommandName="Insert" Text="Insert" />
                        <asp:Button ID="CancelButton" runat="server" CommandName="Cancel" Text="Clear" />
                        <br />
                        <br />
                        </span>
                    </InsertItemTemplate>
        </asp:ListView>
    </form>
</body>
</html>
