<%@ Page Title="" Language="C#" MasterPageFile="~/UI/PioneerTechMasterPage.Master" AutoEventWireup="true" CodeBehind="CompanyDetail.aspx.cs" Inherits="PioneerTech.WebApp.UI.CompanyDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
<table id ="CompanyDetail">
    <td>Company Details</td>
       <tr id ="EmployerName">
           <td>Employer Name</td>
           <td>
               <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
           </td>
       </tr>
    <tr id="ContactNumber">
        <td>Contact Number</td>
        <td>
            <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
        </td>
    </tr>
    
   <tr id ="Location">
       <td>Location</td>
       <td>
           <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
       </td>
   </tr>
    <tr id="Website">
        <td>Website</td>
        <td>
            <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>
        </td>
    </tr>


    <tr id="EmployeeId">
        <td>Employee Id</td>
        <td>
            <asp:TextBox ID="TextBox5" runat="server"></asp:TextBox>
        </td>
    </tr>


    











    <tr id="EmployeeId">
        <td>
            <asp:Button ID="Button4" runat="server" OnClick="Button4_Click" Text="Save" />
        </td>
        <td>
            <asp:Button ID="Button2" runat="server" OnClick="Button2_Click" Text="Edit" />
            <asp:Button ID="Button3" runat="server" OnClick="Button3_Click" Text="Clear" />
        </td>
    </tr>


    











</table>
























</asp:Content>
