<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="Calculadora.aspx.cs" Inherits="INF0_104_Grupo03_Proyecto1.Calculadora" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title></title>
    <link rel="stylesheet" href="css/botones.css"/>
    </head>
<body>
    <form id="form1" runat="server">
        <h1 class="texto" style="text-align: center">Proyecto 01: Calculadora</h1>
        <h3 class="texto" style="text-align: center">Curso: INFO-104</h3>
    <div>
        <table align="center">
            <tr>
                <td>
                        <asp:Label ID="tFormula" runat="server" CssClass="valores" Font-Size="28px" ></asp:Label>
                    </td>
            </tr>
            <tr>
                <td>
                        <asp:Label ID="tConsola" runat="server" CssClass="valores" Font-Size="28px" ></asp:Label>
                    &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp; &nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;&nbsp;
                        <asp:Label ID="tDato" runat="server" CssClass="valores" Font-Size="28px" ></asp:Label>
                    </td>
            </tr>
        </table>
    </div>

    <div>

        <table align="center">
            <tr>
                <td>
                        <asp:Button ID="bttRaiz" runat="server" OnClick="bttRaiz_Click" Text="√ " Height="60px" Width="100px" CssClass="button button1" />
                    </td>
                <td>
                        <asp:Button ID="bttBorrar" runat="server" OnClick="bttBorrar_Click" Text="C"  Height="60px" Width="100px" CssClass="button button1" />
                    </td>
                <td>
                        <asp:Button ID="bttRemover" runat="server" OnClick="bttRemover_Click" Text="&lt;" Height="60px" Width="100px" CssClass="button button1" />
                    </td>
                <td>
                        <asp:Button ID="bttFactorial" runat="server" OnClick="bttFactorial_Click" Text="n!" Height="60px" Width="100px" CssClass="button button1" />
                    </td>
                <td>
                        <asp:Button ID="bttDiv" runat="server" OnClick="bttDiv_Click" Text="/" Height="60px" Width="100px" CssClass="button button1" />
                    </td>
            </tr>
            <tr>
                <td>
                        <asp:Button ID="bttElevarXY" runat="server" OnClick="bttElevarXY_Click" Text="xⁿ" Height="60px" Width="100px" CssClass="button button1" />
                    </td>
                <td>
                        <asp:Button ID="btt7" runat="server" OnClick="btt7_Click" Text="7" Height="60px" Width="100px" CssClass="button button1"/>
                    </td>
                <td>
                        <asp:Button ID="btt8" runat="server" OnClick="btt8_Click" Text="8" Height="60px" Width="100px" CssClass="button button1"/>
                    </td>
                <td>
                        <asp:Button ID="btt9" runat="server" OnClick="btt9_Click" Text="9" Height="60px" Width="100px" CssClass="button button1"/>
                    </td>
                <td>
                        <asp:Button ID="bttMult" runat="server" OnClick="bttMult_Click" Text="*" Height="60px" Width="100px" CssClass="button button1"/>
                    </td>
            </tr>
            <tr>
                <td>
                        <asp:Button ID="bttElevar10" runat="server" OnClick="bttElevar10_Click" Text="10ⁿ" Height="60px" Width="100px" CssClass="button button1"/>
                    </td>
                <td>
                        <asp:Button ID="btt4" runat="server" OnClick="btt4_Click" Text="4" Height="60px" Width="100px" CssClass="button button1"/>
                    </td>
                <td>
                        <asp:Button ID="btt5" runat="server" OnClick="btt5_Click" Text="5" Height="60px" Width="100px" CssClass="button button1"/>
                    </td>
                <td>
                        <asp:Button ID="btt6" runat="server" OnClick="btt6_Click" Text="6" Height="60px" Width="100px" CssClass="button button1"/>
                    </td>
                <td>
                        <asp:Button ID="bttRest" runat="server" OnClick="bttRest_Click" Text="-" Height="60px" Width="100px" CssClass="button button1"/>
                    </td>
            </tr>
            <tr>
                <td>
                        <asp:Button ID="bttLog" runat="server" OnClick="bttLog_Click" Text="Log" Height="60px" Width="100px" CssClass="button button1"/>
                    </td>
                <td>
                        <asp:Button ID="btt1" runat="server" OnClick="btt1_Click" Text="1" Height="60px" Width="100px" CssClass="button button1"/>
                    </td>
                <td>
                        <asp:Button ID="btt2" runat="server" OnClick="btt2_Click" Text="2" Height="60px" Width="100px" CssClass="button button1"/>
                    </td>
                <td>
                        <asp:Button ID="btt3" runat="server" OnClick="btt3_Click" Text="3" Height="60px" Width="100px" CssClass="button button1"/>
                    </td>
                <td>
                        <asp:Button ID="bttSuma" runat="server" OnClick="bttSuma_Click" Text="+" Height="60px" Width="100px" CssClass="button button1"/>
                    </td>
            </tr>
            <tr>
                <td>
                        <asp:Button ID="bttElevar2" runat="server" OnClick="bttElevar2_Click" Text="x²" Height="60px" Width="100px" CssClass="button button1"/>
                    </td>
                <td>
                        <asp:Button ID="bttMasMenos" runat="server" OnClick="bttMasMenos_Click" Text="+/-" Height="60px" Width="100px" CssClass="button button1"/>
                    </td>
                <td>
                        <asp:Button ID="btt0" runat="server" OnClick="btt0_Click" Text="0" Height="60px" Width="100px" CssClass="button button1"/>
                    </td>
                <td>
                        <asp:Button ID="bttcomma" runat="server" OnClick="bttcomma_Click" Text="," Height="60px" Width="100px" CssClass="button button1"/>
                    </td>
                <td>
                        <asp:Button ID="bttIgual" runat="server" OnClick="bttIgual_Click" Text="=" Height="60px" Width="100px" CssClass="button button1"/>
                    </td>
            </tr>
        </table>

    </div>
    </form>

    <footer>
        <p style="text-align: center; font-weight: bold;">-Integrantes- </p>
        <p style="text-align: center">-Jose David Alvarez Vargas- </p>
        <p style="text-align: center">-Jose Pablo Arroyo Villalta- </p>
        <p style="text-align: center">-Wilton Ignacio Benedict Castillo- </p>
        <p style="text-align: center">-Gerardo Jonas Ugarte Navarro- </p>
        <p style="text-align: center">-Prof: Alexander Benjamin Curling- </p>
    </footer>
    </body>
</html>
