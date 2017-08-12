<%@ Page Title="" Language="C#" MasterPageFile="~/UI/PioneerTechMasterPage.Master" AutoEventWireup="true" CodeBehind="EmployeeDetail.aspx.cs" Inherits="PioneerTech.WebApp.UI.EmployeeDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table id="EmployeeDetail">
        <td>Employee Details</td>
        
        <tr id ="FirstName">
            <td style="width: 153px">First Name</td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr id="LastName">
            <td style="width: 153px">Last Name</td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr id="Email">
            <td style="width: 153px">Email</td>
            <td>
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr id="ContactNumber">
            <td style="width: 153px">ContactNumber</td>
            <td>
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
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
            </td>
        </tr>
       
                
    </table>
    

   
    
    


   
    
    

   
    <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Save" />
    <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Edit" />
    <asp:Button ID="Button5" runat="server" OnClick="Button5_Click" Text="Clear" />
    

   
    
    


   
    
    

   
</asp:Content>



