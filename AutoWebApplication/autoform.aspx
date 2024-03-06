<%@ Page Title="" Language="C#" MasterPageFile="~/MasterPage.Master" AutoEventWireup="true" CodeBehind="autoform.aspx.cs" Inherits="AutoWebApplication.autoform" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <hr />
    <div class="d-block p-2 text-bg-dark font-monospace border-light col-4">
        <h5>Ingrese el Vehiculo</h5>
    </div>
    <hr />
    <div class="row col-6">

        <div class="col-6">
            <asp:Label Text="Id" CssClass="form-label" runat="server" />
            <asp:TextBox runat="server" ID="txbId" CssClass="form-control" />
            <asp:Label Text="Modelo" CssClass="form-label" runat="server" />
            <asp:TextBox runat="server" ID="txbModelo" CssClass="form-control" />
            <asp:Label Text="Descripcion" CssClass="form-label" runat="server" />
            <asp:TextBox runat="server" ID="txbDescripcion" CssClass="form-control" TextMode="MultiLine" />
            <asp:Label Text="Color" CssClass="form-label" runat="server" />
            <asp:DropDownList ID="ddlColor" runat="server" CssClass="form-control"></asp:DropDownList>
            <asp:Label Text="Fecha" ID="lblFecha" CssClass="col-form-label" runat="server" />
            <asp:TextBox runat="server" ID="TxbFecha" CssClass="form-control" TextMode="Date" />
            <asp:Label Text="Usado" runat="server" />
            <asp:CheckBox ID="chkUsado" runat="server" CcsClass="form-check-input" />
            <div>
                <asp:RadioButton ID="RadioButtonNacional" runat="server" Text="Nacional" GroupName="Nacional" />
                <asp:RadioButton ID="RadioButtonImportado" runat="server" Text="Importado" GroupName="Nacional" Checked="true" />
            </div>

        </div>
        
    
        <div>

            <asp:Button ID="btnAgregar" OnClick="btnAgregar_Click" runat="server" Text="Agregar" CssClass="btn btn-primary text-bg-primary" />
            <asp:Button ID="btnEliminar" runat="server" Text="Eliminar" CssClass="btn btn-primary text-bg-primary" OnClick="btnEliminar_Click" OnClientClick="return confirm('¿Está seguro que quiere eliminar este auto?');" />
            <asp:Button ID="btnModificar" CssClass="btn btn-primary text-bg-primary" Text="Modificar" runat="server" onclick="btnModificar_Click" />     
        </div>



    </div>


</asp:Content>
