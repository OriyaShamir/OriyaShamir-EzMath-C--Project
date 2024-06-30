<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Exercise.aspx.cs" Inherits="EZMathStudents.home" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body dir="rtl">
    <form id="form1" runat="server">
        <div>
            <select name="Subject" id ="Subject"> <%--// show subjectForm value--%>
                 <%=subjectForm %>   
            </select>
                <asp:Button ID="submit" CommandName="submit" runat="server" Text="הצג תרגילים" OnClick="submit_Click" />
            <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="חזור" />
        </div>
    <div>
        
        <table>
            <tr>
                  <td  colspan="4"><%= exPath %></td> <%--// show the exercise Image--%>
            </tr>
            <tr>
                <td>
                      <asp:Button ID="btnLeft" CommandName="btnLeft" runat="server" Text="התרגיל הקודם" OnClick="btnLeft_Click" Visible ="false" />
                  
                </td>
                <td>
                    <asp:Button ID="btnLike" CommandName="btnLike" runat="server" Text="Like" OnClick="Like_Click" Visible ="false" />
                </td>
                <td>
                    <asp:Button ID="btnDislike" CommandName="btnDislike" runat="server" Text="Dislike" OnClick="Dislike_Click" Visible ="false"/>
                </td>
                <td>
                     <asp:Button ID="btnRight" CommandName="btnRight" runat="server" Text="התרגיל הבא" OnClick="btnRight_Click" Visible ="false" />
                </td>
            </tr>
            <tr >
                  <td rowspan ="2">
                     <asp:Button ID="ShowAns" CommandName="btnShowAns" runat="server" Text="הצג פתרון" OnClick="ShowAns_Click" Visible ="false"/>
                </td>
                 <td rowspan ="2">                  
                     <%= likes %>  <%--// show the ex likes--%>
                </td>
                <td rowspan ="2">
                    <%= dislikes %>  <%--// show the ex dislikes--%>
                </td>
                <td></td>
            </tr>
            <tr>
                <td colspan="4" >
                    <%= exSolPath %> <%--// show the exercise answers--%>
                </td>
            </tr>
        </table>
  
    </div>
            </form>
</body>
</html>
