<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Login.aspx.cs" Inherits="EZMathStudents.Login" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body dir="rtl">
    <div>
        <form id="LoginForm" runat="server">
            <table align="center">
                   <tr>
                       <td><label for ="uname">שם משתמש:</label></td>
                       <td><asp:TextBox runat="server" id ="uname" name="uname" /></td>
                   </tr> 
                <tr>
                    <td><label for ="uname">סיסמא:</label></td>
                    <td><asp:TextBox runat="server" id ="pass" name="pass" TextMode="Password"/></td>
                </tr>
                <tr>
                    <td>
                        <asp:Button runat="server" name ="submit" id ="submit" Text="התחבר" />
                    </td>
                </tr>
            </table>
        </form>
            <%=errors %>
    </div>

     <div align="center">
        <a href="Register.aspx">אין לך משתמש? הירשם עכשיו</a> 
    </div>
</body>
</html>
