<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="WebForm1.aspx.cs" Inherits="Deneme_Project1.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
</head>
<body>
    <form id="form1" runat="server">
        <div>


            <table>
            <asp:GridView ID="GridView1" runat="server"> </asp:GridView> 

            <asp:Button ID="Button1" runat="server" Text="Laptops" OnClick="Button1_Click" />

                  </table> 


            <table>
                <asp:GridView ID="GridView2" runat="server"></asp:GridView>

                <asp:Button ID="Button2" runat="server" Text="Smart Phones" OnClick="Button2_Click" />

            </table>

            <table>
                <asp:GridView ID="GridView3" runat="server" ></asp:GridView>
                <asp:Button ID ="Button3" runat="server" Text="Acsessories" OnClick="Button3_Click" />


            </table>
            


        </div>
    </form>
</body>
</html>
