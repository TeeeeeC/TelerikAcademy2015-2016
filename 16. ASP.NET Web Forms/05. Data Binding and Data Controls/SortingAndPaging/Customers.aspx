<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Customers.aspx.cs" Inherits="SortingAndPaging.Employees" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <script src="https://cdnjs.cloudflare.com/ajax/libs/jquery/2.2.0/jquery.min.js"></script>
</head>
<body>
    <form id="MainForm" runat="server">
        <asp:ScriptManager runat="server" EnablePageMethods="true" />
        <asp:GridView ID="GridViewCustomers" runat="server" AutoGenerateColumns="false"
            AllowPaging="True" PageSize="10" onpageindexchanging="GridViewCustomers_PageIndexChanging" 
            AllowSorting="true" OnSorting="GridViewCustomers_Sorting">
	        <Columns>
                <asp:TemplateField>
                    <ItemTemplate>
                        <label class="info">Info</label>
                    </ItemTemplate>
                </asp:TemplateField>
		        <asp:BoundField DataField="Name" 
			        HeaderText="Name" SortExpression="Name" />
		        <asp:BoundField DataField="City"
			        HeaderText="City" SortExpression="City" />
                <asp:BoundField DataField="Country"
			        HeaderText="Country" SortExpression="Country" />
	        </Columns>
        </asp:GridView>
        <div id="current-customer" style="background-color: aquamarine; position:fixed; margin-top: -240px; margin-left: 430px">
        </div>
    </form>

    <script>
        
        $('.info').mouseover(function (ev) {
            var name = ev.target.parentNode.nextSibling.textContent;

            PageMethods.Get(name, function (res) {
                var $name = $('<p>Name: ' + res.Name + '</p>'),
                    $contactName = $('<p>ContactName: ' + res.ContactName + '</p>'),
                    $contactTitle = $('<p>ContactTitle: ' + res.ContactTitle + '</p>'),
                    $address = $('<p>Address: ' + res.Address + '</p>'),
                    $city = $('<p>City: ' + res.City + '</p>'),
                    $country = $('<p>Country: ' + res.Country + '</p>'),
                    $phone = $('<p>Phone: ' + res.Phone + '</p>'),
                    $fax = $('<p>Fax: ' + res.Fax + '</p>');

                $('#current-customer')
                    .append($name)
                    .append($contactName)
                    .append($contactTitle)
                    .append($address)
                    .append($city)
                    .append($country)
                    .append($phone)
                    .append($fax);

            }, function (err) {
                console.log(err);
            });

        });

        $('.info').mouseout(function (ev) {
            $('#current-customer').html('');
        });

    </script>
</body>
</html>
