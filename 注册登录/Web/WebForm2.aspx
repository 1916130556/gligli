<%@ Page Title="" Language="C#" MasterPageFile="~/FootSite.Master" AutoEventWireup="true" CodeBehind="WebForm2.aspx.cs" Inherits="Web.WebForm2" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div>
        收信人地址:<asp:TextBox ID="txtEmailAddress" runat="server" Width="380px"></asp:TextBox><br />
        <br />
        <asp:Button ID="btnSendMail" runat="server" Text="发送邮件" OnClick="btnSendMail_Click" />
    </div>
</asp:Content>
