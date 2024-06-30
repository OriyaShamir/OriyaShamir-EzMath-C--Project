<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MainScreen.aspx.cs" Inherits="EZMathStudents.MainScreen" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body dir="rtl">
    <form id="form1" runat="server">
        <table align="center">

            <tr>
               <td><h3><%= helloMsg %> </h3></td>
            </tr>
                
            <tr>
                <td><asp:Button ID="Exercise" CommandName="btnExercise" runat="server" Text="תרגול" OnClick="Exercise_Click"/></td>
            </tr>
             <tr>
                <td><asp:Button ID="Grades" CommandName="btnExercise" runat="server" Text="הציונים שלי" OnClick="Grades_Click"/></td>
            </tr>
             <tr>
                <td><asp:Button ID="Edit" CommandName="btnEdit" runat="server" Text="עריכת פרטים אישיים" OnClick="Edit_Click"/></td>
            </tr>
            <tr>
                <td><asp:Button ID="LogOut" CommandName="btnLogOut" runat="server" Text="התנתק" OnClick="LogOut_Click"/></td>
            </tr>
        </table>
    </form>
</body>
</html>
