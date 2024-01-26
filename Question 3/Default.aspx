<%@ Page Title="View All Students" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Question_3.Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">
    <main>
        <section class="row" aria-labelledby="aspnetTitle">
            <h1 id="aspnetTitle">View All Students</h1>            
        </section>
        <div class="row">          
            <div class="col-8 md-offset-2">
                <table class="table table-striped">                    
                    <thead>
                        <tr>
                            <th>ID</th>
                            <th>First Name</th>
                            <th>Surname</th>
                            <th>Gender</th>
                            <th>Date of Birth</th>
                            <th>Address</th>
                            <th>Subjects enrolled in</th>
                            <th>Actions</th>
                       </tr>
                    </thead>
                    <asp:Repeater ID="Repeater1" runat="server">
                        <ItemTemplate>
                            <tr id="exp">
                                <td><%# Eval("id") %></td>
                                <td><%# Eval("name") %></td>
                                <td><%# Eval("surname") %></td>
                                <td><%# Eval("gender") %></td>
                                <td><%# Eval("dob") %></td>
                                <td><%# Eval("address") %></td>
                                <td><%# Eval("subjects") %></td>
                                <td><asp:Button runat="server" type="button" CommandArgument='<%# Eval("id")%>' class="btn btn-primary" OnClick="Edit" Text="Edit"></asp:Button></td>
                                <td><asp:Button runat="server" type="button" CommandArgument='<%# Eval("id")%>' class="btn btn-danger" OnClick="Delete" Text="Delete"></asp:Button></td>
                            </tr>
                        </ItemTemplate>
                    </asp:Repeater>
                </table>
            </div>
        </div>
    </main>
</asp:Content>
