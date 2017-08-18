<%@ Page Title="" Language="C#" MasterPageFile="~/UI/PioneerTechMasterPage.Master" AutoEventWireup="true" CodeBehind="TechnicalDetail.aspx.cs" Inherits="PioneerTech.WebApp.UI.TechnicalDetail" %>
<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <table id="TechnicalDetails">
        <td>Technical Details</td>
        <tr id="UI">
            <td>UI</td>
            <td>
                <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator1" runat="server" ControlToValidate="TextBox1" ErrorMessage="Please fill the field!"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr id="ProgrammingLanguage">
            <td>Programming Language</td>
            <td>
                <asp:TextBox ID="TextBox2" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator2" runat="server" ControlToValidate="TextBox2" ErrorMessage="Please fill the field!"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr id="Database">
            <td>Database</td>
            <td>
                <asp:TextBox ID="TextBox3" runat="server"></asp:TextBox>
                <asp:RequiredFieldValidator ID="RequiredFieldValidator3" runat="server" ControlToValidate="TextBox3" ErrorMessage="Please fill the field!!"></asp:RequiredFieldValidator>
            </td>
        </tr>
        <tr id="EmplyeeID">
            <td>Employee Id</td>
            <td>
                <asp:TextBox ID="TextBox4" runat="server"></asp:TextBox>

            </td> 

        </tr>
        <tr id="button">
            <td>
                <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="Save" />
                <asp:Button ID="Button2" runat="server" Text="Edit" OnClick="Button2_Click" />
            </td>
            <td>
                <asp:Button ID="Button3" runat="server" Text="Clear" OnClick="Button3_Click" />
            </td>
        </tr>
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        
        

    </table>
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    
    

</asp:Content>
