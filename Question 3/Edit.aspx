<%@ Page Title="Edit" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Edit.aspx.cs" Inherits="Question_3.Edit" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <section class="row" aria-labelledby="aspnetTitle">
        <h1 id="title">Edit Student details</h1>            
    </section>            
    <div class="row">
        <div class="col-4 md-offset-4">            
            <div class="form-group">
                <asp:TextBox Visible="false" runat="server" ID="txtId" Text='<%# _currentRow["id"] %>'></asp:TextBox>
                <asp:Label runat="server" ID="lblName" Text='First Name'></asp:Label>
                <asp:TextBox class="form-control" runat="server" ID="txtName" Text='<%# _currentRow["name"] %>'></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label runat="server" ID="lblSurname" Text='Surname'></asp:Label>
                <asp:TextBox class="form-control" runat="server" ID="txtSurname" Text='<%# _currentRow["surname"] %>'></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label runat="server" ID="lblGender" Text='Gender'></asp:Label>
                <asp:TextBox class="form-control" runat="server" ID="txtGender" Text='<%# _currentRow["gender"] %>'></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label runat="server" ID="lblDob" Text='Date Of Birth'></asp:Label>
                <asp:TextBox type="date" class="form-control" runat="server" ID="txtDob" Value='<%# DateTime.Parse(_currentRow["dob"].ToString()).ToString("yyyy-MM-dd")  %>'></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label runat="server" ID="lblAddress" Text='Address'></asp:Label>
                <asp:TextBox class="form-control" runat="server" ID="txtAddress" Value='<%# _currentRow["address"] %>'></asp:TextBox>
            </div>
            <div class="form-group">
                <asp:Label runat="server" ID="lblSubjects" Text='Subjects Enrolled'></asp:Label>
                <asp:TextBox class="form-control" runat="server" ID="txtSubjects" Text='<%# _currentRow["subjects"] %>'></asp:TextBox>
            </div>
            <div class="form-group" style="margin-top: 3%">                
                <asp:Button type="button" class="btn btn-primary" runat="server" OnClick="Update" Text='Save Changes'></asp:Button>
            </div>
        </div>
    </div>
</asp:Content>

