<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="MyGrades.aspx.cs" Inherits="EZMathStudents.MyGrades" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link href="StyleSheet.css" type="text/css" rel="stylesheet" />
    <style type="text/css">
        
    </style>
</head>
<body dir="rtl">
    <form id="form1" runat="server">
       <table>
           <tr>
               <td> 
                     <select name="Exam" id ="Exam" class="testSubmit">
                             <%=ExamList %>              <%--//Exam's combobox--%>
                    </select>
               </td>
               
               <td>
                       <asp:Button ID="submit" CommandName="submit" runat="server" Text="הצג ציון" OnClick="submit_Click"  CssClass="ExerBttnStyle" Height="35px" Width="125px"/>
                       <asp:Button ID="Button1" runat="server" OnClick="Button1_Click" Text="חזור" />
               </td>
           </tr>
           <tr>
               <td>
                   <asp:label runat="server" ID="TestGradeShow" CssClass="ExerStyle"></asp:label>
               </td>
           </tr>
           <%=ExamEx %>
       </table>
    </form>
</body>
</html>
