<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Edit.aspx.cs" Inherits="EZMathStudents.Edit" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <style type="text/css">
        .auto-style1 {
            height: 20px;
        }
    </style>
</head>
<body dir="rtl">
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td><h1>עריכת פרטים</h1></td>
                </tr>
                <tr>
                    <td><label for="oldPass">סיסמה ישנה:</label></td>
                    <td><input type ="text" name="oldPass" id ="oldPass" /></td>
                </tr>
                <tr>
                    <td><label for="newPass">סיסמה חדשה:</label></td>
                    <td><input type ="text" name="newPass" id ="newPass" /></td>
                </tr>
                  <tr>
                       <td>רמת קושי:</td> <%--// Update difficulty--%>
                       <td>
                           <label for ="diff3">3 יח"ל</label><input type="radio" name="diff" value="3" id="diff3" />
                           <label for ="diff4">4 יח"ל</label><input type="radio" name="diff" value="4" id="diff4" />
                           <label for ="diff5">5 יח"ל</label><input type="radio" name="diff" value="5" id="diff5" />
                       </td>
                   </tr>
                 <tr>
                    <td>
                        <input type="submit" name ="submit" id ="submit" value ="עדכן"/>
                        <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="חזור" />
                    </td>
                </tr>
                <tr>
                    <td class="auto-style1"><%=error %></td>            <%--// Insert's the string error --%>
                </tr>
            </table>
        </div>
    </form>
</body>
</html>
