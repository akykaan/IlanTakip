<%@ Page Async="true" Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="JobAdverts.aspx.cs" Inherits="IlanTakip.JobAdverts" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

    <h2 class="mt-5">İş ilanları</h2>
    <div class="alert alert-danger" role="alert" id="alertdiv">
        <asp:Label ID="labelAlert" runat="server" Text=""></asp:Label>
    </div>

    <asp:GridView ID="jobadvertGridView" runat="server" CssClass="mt-1" AutoGenerateColumns="false" AllowPaging="true" PageSize="12"
        OnPageIndexChanging="jobadvertGridView_PageIndexChanging"
        OnRowCommand="jobadvertGridView_RowCommand">
        <Columns>
            <asp:BoundField ItemStyle-Width="150px" DataField="JobDescription" HeaderText="İş Açıklaması" />
            <asp:BoundField ItemStyle-Width="150px" DataField="JobTitle" HeaderText="Ünvan" />
            <asp:BoundField ItemStyle-Width="150px" DataField="CityName" HeaderText="Şehir" />
            <asp:BoundField ItemStyle-Width="150px" DataField="OpenPosition" HeaderText="Açık pozisyon" />
            <asp:BoundField ItemStyle-Width="150px" DataField="IsActive" HeaderText="Açık/Aktif İlan" />
            <asp:TemplateField HeaderText="">
                <ItemTemplate>
                    <asp:Button ID="btnBasvuru"
                        CommandArgument='<%# Eval("Id") %>'
                        CommandName="Basvuru" runat="server" Text="Başvuru Yap"
                        CssClass="btn btn-success" />
                </ItemTemplate>
            </asp:TemplateField>
        </Columns>
    </asp:GridView>
</asp:Content>
