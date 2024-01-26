<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Question2._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <section class="row" aria-labelledby="aspnetTitle">
            <h1 id="aspnetTitle">Question 2</h1>
            <h3>Description</h3>
            <p class="lead">Question 2 
                2.1	Using the database, you previously created in 1.1. 
                2.2	Create a new form in web form (asp.net and html) named “Employer Classes”. The form should have two drop down menus labelled “Class” and “Sub Class”.
                •	The first drop down must allow the user to select an employer class.
                •	The second drop down must display only the subclasses that fall under the selected employer class.
                •	The data to populate the Class and Sub Class menus will be found in the tables you created in 1.2.
                •	Only display the EmployerClassName in the Class drop down menu and the EmployerSubclassShortDescription in the Sub Classes drop down menu.

            </p>
            <p><a href="EmployerClasses.aspx" class="btn btn-primary btn-md">See Question 2 &raquo;</a></p>
        </section>
        
    </main>

</asp:Content>
