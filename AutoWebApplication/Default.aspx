<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="AutoWebApplication.Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <hr />

   

    <div class="row">
        <div class="col">

            <asp:GridView ID="dgwAutos" runat="server" DataKeyNames="Id" OnSelectedIndexChanged="dgwAutos_SelectedIndexChanged" AutoGenerateColumns="false" CssClass="table table-dark table-bordered table-striped-columns">

                <Columns>
                    <asp:BoundField HeaderText="Id" DataField="Id"  />
                    <asp:BoundField HeaderText="Modelo" DataField="Modelo" />
                    <asp:BoundField HeaderText="Descripcion" DataField="Descripcion" />
                    <asp:CheckBoxField HeaderText="Usado" DataField="Usado" />
                    <asp:CheckBoxField HeaderText="Importado" DataField="Importado" />
                    <asp:CommandField ShowSelectButton ="true"  SelectText="Seleccionar" HeaderText="Accion" />

                </Columns>

            </asp:GridView>

        </div>

    </div>

</asp:Content>
