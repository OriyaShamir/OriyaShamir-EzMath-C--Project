<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="home.aspx.cs" Inherits="EZMathStudents.home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body dir="rtl">
    <form id="form1" runat="server">
        <div>
            <select name="Subject" id ="Subject">
                 <%=subjectForm %>
            </select>
                <asp:Button ID="submit" CommandName="submit" runat="server" Text="הצג תרגילים" OnClick="submit_Click" />
        </div>
    <div>
          <%= exPath %>
        <table>
            <tr>
                <td>
                    <asp:Button ID="btnLeft" CommandName="btnLeft" runat="server" Text="<" OnClick="btnLeft_Click" />
                </td>
                <td>
                    <asp:Button ID="btnRight" CommandName="btnRight" runat="server" Text=">" OnClick="btnRight_Click" />
                </td>
            </tr>
        </table>
  
    </div>
            </form>
</body>
</html>
