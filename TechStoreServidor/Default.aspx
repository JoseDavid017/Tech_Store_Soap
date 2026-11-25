<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="TechStoreServidor._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <div class="container mt-5">

        <h1>TechStore</h1>
        <div class="row mt-3">
            <div class="col-md-6 col-sm-12">
                <h2>Consultar productos</h2>
                <p>Ingrese el ID del producto que desea consultar:</p>
                <div class="mb-3">
                    <label>Product ID</label>

                    <asp:TextBox ID="txtProductID"
                        runat="server"
                        CssClass="form-control"
                        TextMode="Number">
                    </asp:TextBox>
                </div>

                <asp:Button ID="btnConsultar"
                    runat="server"
                    Text="Consultar producto"
                    CssClass="btn btn-primary"
                    OnClick="btnConsultar_Click" />

                <hr />

                <asp:Label ID="lblResultado"
                    runat="server"
                    CssClass="text-danger">
                </asp:Label>

                <div class="mt-3">

                    <p>
                        <strong>Nombre:</strong>
                        <asp:Label ID="lblNombre" runat="server" />
                    </p>

                    <p>
                        <strong>Precio:</strong>
                        <asp:Label ID="lblPrecio" runat="server" />
                    </p>

                    <p>
                        <strong>Stock:</strong>
                        <asp:Label ID="lblStock" runat="server" />
                    </p>

                </div>
            </div>
            <div class="col-md-6">
                <h2>Registrar producto</h2>
                <p>Ingrese el producto que desea registrar</p>
                <div class="mb-3">
                    <label class="form-label">Nombre del producto</label>
                    <asp:TextBox ID="txtNombre" runat="server" CssClass="form-control" />
                </div>
                <div class="mb-3">
                    <label class="form-label">Precio</label>
                    <asp:TextBox ID="txtPrecio" runat="server" CssClass="form-control" TextMode="Number" />
                </div>
                <div class="mb-3">
                    <label class="form-label">Categoría</label>
                    <asp:TextBox ID="txtCategoria" runat="server" CssClass="form-control" />
                </div>
                <div class="mb-3">
                    <label class="form-label">Cantidad en stock</label>
                    <asp:TextBox ID="txtStock" runat="server" CssClass="form-control" TextMode="Number" />
                </div>
                <asp:Button ID="btnRegistrar" runat="server" Text="Registrar producto" CssClass="btn btn-success" OnClick="btnRegistrar_Click" />
                <asp:Label ID="lblResultadoRegistrar"
                    runat="server"
                    CssClass="text-danger">
                </asp:Label>
            </div>
                
        </div>

        <div class="row mt-3">
            <div class="col-md-6 col-sm-12">
                <h2>Actualizar producto</h2>
                <p>Modifique los datos del producto que desea actualizar</p>
                <div class="mb-3">
                    <label class="form-label">ID del producto a actualizar</label>
                    <asp:TextBox ID="txtActualizarID" runat="server" CssClass="form-control" TextMode="Number" />
                </div>
                <div class="mb-3">
                    <label class="form-label">Nuevo nombre del producto</label>
                    <asp:TextBox ID="txtActualizarNombre" runat="server" CssClass="form-control" />
                </div>
                <div class="mb-3">
                    <label class="form-label">Nuevo precio</label>
                    <asp:TextBox ID="txtActualizarPrecio" runat="server" CssClass="form-control" TextMode="Number" />   
                </div>
                <div class="mb-3">
                    <label class="form-label">Nueva categoría</label>
                    <asp:TextBox ID="txtActualizarCategoria" runat="server" CssClass="form-control" />
                </div>
                <div class="mb-3">
                    <label class="form-label">Nueva cantidad en stock</label>
                    <asp:TextBox ID="txtActualizarStock" runat="server" CssClass="form-control" TextMode="Number" />
                </div>
                <asp:Button ID="btnActualizar" runat="server" Text="Actualizar producto" CssClass="btn btn-warning" OnClick="btnActualizar_Click" />
                <asp:Label ID="lblResultadoActualizar"
                    runat="server"
                    CssClass="text-danger">
                </asp:Label>
            </div>  
            <div class="col-md-6 col-sm-12">
                <h2>Eliminar producto</h2>
                <p>Ingrese el ID del producto que desea eliminar:</p>
                <div class="mb-3">
                    <label class="form-label">ID del producto a eliminar</label>
                    <asp:TextBox ID="txtEliminarID" runat="server" CssClass="form-control" TextMode="Number" />
                </div>
                <asp:Button ID="btnEliminar" runat="server" Text="Eliminar producto" CssClass="btn btn-danger" OnClick="btnEliminar_Click" />
                <asp:Label ID="lblResultadoEliminar"
                    runat="server"
                    CssClass="text-danger">
                </asp:Label>
            </div>                
        </div>
    </div>

</asp:Content>
