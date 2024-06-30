<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Register.aspx.cs" Inherits="EZMathStudents.Register" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body dir ="rtl">
    <form id="register" runat="server">
        <div>
               <table>
                   <tr>
                       <td><label for ="uname">שם משתמש:</label></td>
                       <td><input type ="text" id ="uname" name="uname" /></td>
                   </tr> 
                      <tr>
                       <td><label for ="fname">שם פרטי:</label></td>
                       <td><input type ="text" id ="fname" name="fname" /></td>
                   </tr> 
                    <tr>
                       <td><label for ="email">כתובת מייל:</label></td>
                       <td><input type ="text" id ="email" name="email" /></td>
                   </tr> 
                    <tr>
                       <td>מין:</td>
                        <td><label for="male" >זכר</label><input type ="radio" name="gender" value ="1" id ="male"/>
                       <label for="female" >נקבה</label><input type ="radio" name="gender" value ="2" id ="female"/></td>
                   </tr> 
                   <tr>
                       <td>רמת קושי:</td>
                       <td>
                           <label for ="diff3">3 יח"ל</label><input type="radio" name="diff" value="3" id="diff3" />
                           <label for ="diff4">4 יח"ל</label><input type="radio" name="diff" value="4" id="diff4" />
                           <label for ="diff5">5 יח"ל</label><input type="radio" name="diff" value="5" id="diff5" />
                       </td>
                   </tr>
                   <tr>
                       <td>
                           <label for="Class">כיתה:</label>
                           </td>
                       <td>
                           <select name="Class" id ="Class">
                               <%=classesForm %>
                           </select>
                       </td>
                   </tr>
                <tr>
                    <td><label for ="uname">סיסמא:</label></td>
                    <td><input type ="text" id ="pass" name="pass" /></td>
                </tr>
                <tr>
                    <td>
                        <input type="submit" name ="submit" id ="submit" value ="הירשם"/>
                    </td>
                </tr>
            </table>
        </div>
    </form>

    <div>
        <a href="Login.aspx">יש לך משתמש? התחבר עכשיו</a>
    </div>
</body>
</html>
