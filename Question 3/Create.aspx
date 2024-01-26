<%@ Page Title="Create" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Create.aspx.cs" Inherits="Question_3.Create" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main>
        <section class="row" aria-labelledby="aspnetTitle">
            <h1 id="Title">Register New Student</h1>            
        </section>
        <div class="form-group">
            <label>First Name</label>
            <asp:TextBox class="form-control" ID="txtName" runat="server"></asp:TextBox>
        </div>
        <div class="form-group">
            <label>Last Name</label>
            <asp:TextBox class="form-control" ID="txtSurname" runat="server"></asp:TextBox>
        </div>                    
        <div class="form-group">
            <label>Gender</label>
            <asp:TextBox class="form-control" ID="txtGender" runat="server"></asp:TextBox>
        </div>
        <div class="form-group">
            <label>Date of Birth</label>
            <asp:TextBox class="form-control" type="date" ID="txtDob" runat="server"></asp:TextBox>
        </div>
        <div class="form-group">
            <label>Address</label>
            <asp:TextBox class="form-control" ID="txtAddress" runat="server"></asp:TextBox>
        </div>
        <div class="form-group">
            <label>Subjects</label>
            <asp:TextBox class="form-control" ID="txtSubjects" runat="server"></asp:TextBox>
        </div>            
        <div class="form-group">        
            <button style="margin-top: 3%" class="btn btn-primary" type="button" onclick="submit()">Create Student</button>
        </div>    
    </main>
</asp:Content>
