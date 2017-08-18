<%@ Page Title="" Language="C#" MasterPageFile="~/UI/PioneerTechMasterPage.Master" AutoEventWireup="true" CodeBehind="ProjectDetail.aspx.cs" Inherits="PioneerTech.WebApp.UI.ProjectDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table id="ProjectDetail">
        <td>Project Details</td>
        
        <tr id="ProjectName">
            <td>Project Name</td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr id="ClientName">
            <td>Client Name</td>
            <td>
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr id="Location">
            <td>Location</td>
            <td>
                <asp:TextBox ID="TextBox6" runat="server"></asp:TextBox>
            </td>
        </tr>
        <tr id="Roles">
            <td>Roles</td>
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
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Save" />
            </td>
            <td>
                <asp:Button ID="Button2" runat="server" Text="Edit" OnClick="Button2_Click" />
                <asp:Button ID="Button3" runat="server" Text="Clear" OnClick="Button3_Click" />
            </td>
        </tr>
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        

    </table>
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    

</asp:Content>
