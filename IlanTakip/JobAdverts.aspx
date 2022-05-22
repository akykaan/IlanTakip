<%@ Page Async="true" Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="JobAdverts.aspx.cs" Inherits="IlanTakip.JobAdverts" %>


<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <%--<script src="Scripts/jquery-3.4.1.min.js"></script>
    <script type="text/javascript">
        function getProducts() {
            $.ajax({
                type: "GET",
                url:"https://localhost:44321/api/candidate",
                contentType: "json",
                dataType: "json",
                success: function (data) {
                    console.log("girdi:", data);
                    $.each(data, function (key, val) {
                        var jsonData = JSON.stringify(val);
                        var objData = $.parseJSON(jsonData);
                        var row = '<td>' + objData.FirstName + '</td><td>' + objData.LastName+ '</td>';
                        $('<tr/>', { html: row })  // Append the name.
                            .appendTo($('#products'));
                    });
                }
            })
        }

        $(document).ready(getProducts);
    </script>--%>
    <h2>Candidates</h2>

    <asp:GridView ID="candidateGridView" runat="server" CssClass="mt-5">
        <Columns>
            <%--<asp:BoundField ItemStyle-Width="150px" DataField="FirstName" HeaderText="First Name2"/>
            <asp:BoundField ItemStyle-Width="150px" DataField="LastName" HeaderText="Last Name2"/>--%>
        </Columns>
    </asp:GridView>

</asp:Content>
