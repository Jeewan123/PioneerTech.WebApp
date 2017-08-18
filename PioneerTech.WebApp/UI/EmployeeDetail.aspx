<%@ Page Title="" Language="C#" MasterPageFile="~/UI/PioneerTechMasterPage.Master" AutoEventWireup="true" CodeBehind="EmployeeDetail.aspx.cs" Inherits="PioneerTech.WebApp.UI.EmployeeDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table id="EmployeeDetail">
        <td>Employee Details</td>
        
        <tr id ="FirstName">
            <td style="width: 153px">First Name</td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Please enter the name!"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr id="LastName">
            <td style="width: 153px">Last Name</td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="Enter the last name!"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr id="Email">
            <td style="width: 153px">Email</td>
            <td>
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator1" runat="server" ControlToValidate="TextBox3" ErrorMessage="Enter the email in correct format!" ValidationExpression="^(?(“”)(“”.+?””@)|(([0-9a-zA-Z]((\.(?!\.))|[-!#\$%&amp;’\*\+/=\?\^`\{\}\|~\w])*)(?&lt;=[0-9a-zA-Z])@))(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-zA-Z][-\w]*[0-9a-zA-Z]\.)+[a-zA-Z]{2,6}))$"></asp:RegularExpressionValidator>
            </td>
        </tr>
        <tr id="ContactNumber">
            <td style="width: 153px">ContactNumber</td>
            <td>
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator4" runat="server" ControlToValidate="TextBox4" ErrorMessage="Please enter your number!"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr id="AlternateContactNumber">
            <td style="width: 153px">Alternate Contact Number</td>
            <td>
                <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
            </td>
        </tr>
         <tr id ="Address">
             <td style="width: 153px">Address</td>
             <td>
                 <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
             </td>
         </tr>
        <tr id ="AlternateAddress">
            <td style="width: 153px">Alternate Address</td>
            <td>
                <asp:TextBox ID="TextBox7" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr id="CurrentCountry">
            <td style="width: 153px">Current Country</td>
            <td>
                <asp:TextBox ID="TextBox8" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox8" ErrorMessage="You need to enter your current country!"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr id="HomeCountry">
            <td style="width: 153px">Home Country</td>
            <td>
                <asp:TextBox ID="TextBox9" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr id="ZipCode">
            <td style="width: 153px">Zip Code</td>
            <td>
                <asp:TextBox ID="TextBox10" runat="server"></asp:TextBox>
                <asp:RegularExpressionValidator ID="RegularExpressionValidator3" runat="server" ControlToValidate="TextBox10" ErrorMessage="Please enter zip in correct form!" ValidationExpression="\d{5}(-\d{4})?"></asp:RegularExpressionValidator>
            </td>
        </tr>
        
       
                
    </table>
    

   
    
    


   
    
    

   
    <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Save" />
    <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Edit" />
    <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Clear" />
    

   
    
    


   
    
    

   
</asp:Content>



