<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="Users.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="RegisterForm" runat="server">
        <asp:Panel ID="PanelLogonInfo" runat="server"
            GroupingText="Logon info">
            <asp:Label Text="Username:" runat="server" ID="LabelUsername"
                AssociatedControlID="TextBoxUsername" />
            <asp:TextBox ID="TextBoxUsername" runat="server" ValidationGroup="ValidationGroupLogon"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidatorUsername"
                ControlToValidate="TextBoxUsername" runat="server" Display="Dynamic"
                Text="Required Field" ErrorMessage="Username field is required!"
                ForeColor="Red" EnableClientScript="False" /><br />

            <asp:Label Text="Password:" runat="server" ID="LabelPassword"
                AssociatedControlID="TextBoxPassword" />
            <asp:TextBox ID="TextBoxPassword" runat="server" ValidationGroup="ValidationGroupLogon" TextMode="Password"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidatorPassword"
                ControlToValidate="TextBoxPassword" runat="server" Display="Dynamic"
                Text="Required Field" ErrorMessage="Password field is required!"
                ForeColor="Red" EnableClientScript="False" /><br />

            <asp:Label Text="Password Repeat:" runat="server" ID="LabelRepeatPassword"
                AssociatedControlID="TextBoxRepeatPassword" />
            <asp:TextBox ID="TextBoxRepeatPassword" runat="server" ValidationGroup="ValidationGroupLogon" TextMode="Password"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidatorRepeatPassword"
                ControlToValidate="TextBoxRepeatPassword" runat="server" Display="Dynamic"
                Text="Required Field" ErrorMessage="Repeat Password field is required!"
                ForeColor="Red" EnableClientScript="False" />
            <br />
            <asp:Button ID="ButtonLogonInfo" runat="server" Text="Check"
                OnClick="ButtonLogonInfo_Click" />
        </asp:Panel>

        <asp:Panel ID="PanelPersonalInfo" runat="server"
            GroupingText="Personal info">
            <asp:Label Text="FirstName:" runat="server" ID="LabelFirstName"
                AssociatedControlID="TextBoxFirstName" />
            <asp:TextBox ID="TextBoxFirstName" runat="server" ValidationGroup="ValidationGroupPersonal"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidatorFirstName"
                ControlToValidate="TextBoxFirstName" runat="server" Display="Dynamic"
                Text="Required Field" ErrorMessage="FirstName field is required!"
                ForeColor="Red" EnableClientScript="False" /><br />

            <asp:Label Text="LastName:" runat="server" ID="LabelLastName"
                AssociatedControlID="TextBoxLastName" />
            <asp:TextBox ID="TextBoxLastName" runat="server" ValidationGroup="ValidationGroupPersonal"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidatorLastName"
                ControlToValidate="TextBoxLastName" runat="server" Display="Dynamic"
                Text="Required Field" ErrorMessage="LastName field is required!"
                ForeColor="Red" EnableClientScript="False" /><br />

            <asp:Label Text="Age:" runat="server" ID="LabelAge"
                AssociatedControlID="TextBoxAge" />
            <asp:TextBox ID="TextBoxAge" runat="server" ValidationGroup="ValidationGroupPersonal"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidatorAge"
                ControlToValidate="TextBoxAge" runat="server" Display="Dynamic"
                Text="Required Field" ErrorMessage="Age field is required!"
                ForeColor="Red" EnableClientScript="False" />
            <asp:RangeValidator
                ControlToValidate="TextBoxAge"
                MinimumValue="18"
                MaximumValue="81"
                Type="Integer"
                ValidationGroup="ValidationGroupPersonal"
                EnableClientScript="false"
                Text="Age must be between 18 and 81 inclusive!"
                ForeColor="Red"
                runat="server" /><br />

            <asp:Label Text="Email:" runat="server" ID="LabelEmail"
                AssociatedControlID="TextBoxEmail" />
            <asp:TextBox ID="TextBoxEmail" runat="server" ValidationGroup="ValidationGroupPersonal"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidatorEmail"
                ControlToValidate="TextBoxEmail" runat="server" Display="Dynamic"
                Text="Required Field" ErrorMessage="Email field is required!"
                ForeColor="Red" EnableClientScript="False" />
            <asp:RegularExpressionValidator
                ID="RegularExpressionValidatorEmail"
                runat="server" ForeColor="Red" Display="Dynamic"
                ErrorMessage="Email address is incorrect!"
                ControlToValidate="TextBoxEmail" EnableClientScript="False"
                ValidationExpression="[a-zA-Z][a-zA-Z0-9\-\.]*[a-zA-Z]@[a-zA-Z][a-zA-Z0-9\-\.]+[a-zA-Z]+\.[a-zA-Z]{2,4}">
            </asp:RegularExpressionValidator><br />

            <asp:RadioButtonList id="RadioButtonGender" runat="server" AutoPostBack="true">
                <asp:ListItem>Male</asp:ListItem>
                <asp:ListItem>Female</asp:ListItem>
            </asp:RadioButtonList>

            <asp:CheckBoxList ID="CheckBoxCars" runat="server" Visible="false">
                <asp:ListItem>BMW</asp:ListItem>
                <asp:ListItem>Toyota</asp:ListItem>
                <asp:ListItem>Audi</asp:ListItem>
            </asp:CheckBoxList>

            <asp:DropDownList ID="DropDownListCoffee" runat="server" Visible="false">
                <asp:ListItem>Lavazza</asp:ListItem>
                <asp:ListItem>New Brazil</asp:ListItem>
                <asp:ListItem>Mocha</asp:ListItem>
            </asp:DropDownList>

            <asp:Button ID="ButtonPersonalInfo" runat="server" Text="Check"
                OnClick="ButtonPersonalInfo_Click" />
        </asp:Panel>

        <asp:Panel ID="PanelAddressInfo" runat="server"
            GroupingText="Address info">
            <asp:Label Text="Address:" runat="server" ID="LabelAddress"
                AssociatedControlID="TextBoxAddress" />
            <asp:TextBox ID="TextBoxAddress" runat="server" ValidationGroup="ValidationGroupAddress"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidatorAddress"
                ControlToValidate="TextBoxAddress" runat="server" Display="Dynamic"
                Text="Required Field" ErrorMessage="Address field is required!"
                ForeColor="Red" EnableClientScript="False" /><br />

            <asp:Label Text="Phone:" runat="server" ID="LabelPhone"
                AssociatedControlID="TextBoxPhone" />
            <asp:TextBox ID="TextBoxPhone" runat="server" ValidationGroup="ValidationGroupAddress"></asp:TextBox>
            <asp:RequiredFieldValidator ID="RequiredFieldValidatorPhone"
                ControlToValidate="TextBoxPhone" runat="server" Display="Dynamic"
                Text="Required Field" ErrorMessage="Phone field is required!"
                ForeColor="Red" EnableClientScript="False" />
            <asp:RegularExpressionValidator
                ID="RegularExpressionValidatorPhone"
                runat="server" ForeColor="Red" Display="Dynamic"
                ErrorMessage="Phone is incorrect!"
                ControlToValidate="TextBoxPhone" EnableClientScript="False"
                ValidationExpression="[0-9]{10,10}">
            </asp:RegularExpressionValidator><br />

            <asp:Button ID="ButtonAddressInfo" runat="server" Text="Check"
                OnClick="ButtonAddressInfo_Click"/>
        </asp:Panel>

        <asp:CheckBox ID="CheckBoxAccept" runat="server" Text="I accept"/>
        <asp:CustomValidator runat="server" ID="CheckBoxRequired"
            OnServerValidate="CheckBoxRequired_ServerValidate" ForeColor="Red">
            Required field.
        </asp:CustomValidator>

        <asp:CompareValidator ID="CompareValidatorPassword" runat="server"
            ControlToCompare="TextBoxPassword"
            ControlToValidate="TextBoxRepeatPassword" Display="Dynamic"
            ErrorMessage="Password doesn't match!" ForeColor="Red" EnableClientScript="False"></asp:CompareValidator>
        <br />
        <asp:Button ID="ButtonSubmit" runat="server" Text="Submit" OnClick="ButtonSubmit_Click" />
        <br />
        <asp:Label ID="LabelIsValid" runat="server"></asp:Label>
        <asp:Label ID="LabelMessage" runat="server" Text="Label" Visible="false"></asp:Label>

        <asp:ValidationSummary runat="server" ForeColor="Red" />
    </form>
</body>
</html>
