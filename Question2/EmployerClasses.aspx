<%@ Page Title="Question 2" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="EmployerClasses.aspx.cs" Inherits="Question2.EmployerClasses" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">        
   <div class="row">
       <div class="col-2"></div>
       <div class="col-3">
           <asp:DropDownList id="employer_classes"  class="form-control" AutoPostBack="true" runat="server" name="employer_classes" OnSelectedIndexChanged="employerclassChange">
                <asp:ListItem></asp:ListItem>
            </asp:DropDownList>
       </div>
        <div class="col-3">
           <asp:DropDownList class="form-control" id="employer_sub" runat="server" name="employer_sub">
                <asp:ListItem>Select a Class, Note: Fish has no subclasses</asp:ListItem>           
            </asp:DropDownList>
       </div>
   </div>    
</asp:Content>
