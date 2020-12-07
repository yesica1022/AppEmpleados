<%@ Page Title="" Language="C#" MasterPageFile="~/App/Layout.Master" AutoEventWireup="true" CodeBehind="Listar.aspx.cs" Inherits="AppEmpleadosCrut_2_.App.Listar" %>
<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">

      <!--Contenido html-->

    <h1 class="textoH1"> Crud Básico a una Tabla html  </h1>
    <main class="estiloMain">
    
            <div class="contenedorApp"/> 
    
                <div class="menuApp"> 
                    <div class="contenedorBtnApp">

                       <div>
                            <asp:Button ID="tnListar" runat="server" OnClick="tnListar_Click" Text="Listar Empleados" CssClass="btnApp" Visible="False" />
                       </div>

                        <div>
                            <div class="contenedorText"><asp:TextBox ID="inCodigoBuscar" runat="server"></asp:TextBox> </div>
                        </div>

                        <div>
                            <asp:Button ID="btnBuscarCodigo" runat="server"  Text="Buscar Empleado" CssClass="btnApp" OnClick="btnBuscarCodigo_Click" />
                       </div>

                        <div>
                            <asp:Label ID="LabelBuscar" runat="server" Font-Bold="True"></asp:Label>
                        </div>
                        
                    </div>
            </div>
           
            <div class="contenedorDatos">
           
                   <div class="contenedorGrid">
                      <asp:GridView CssClass="formatoGrid" ID="gvDatos" runat="server" AllowPaging="True" BackColor="#CCCCCC" BorderColor="#999999" BorderStyle="Solid" BorderWidth="3px" CellPadding="4" CellSpacing="2" ForeColor="Black" Height="329px" OnPageIndexChanging="gvDatos_PageIndexChanging" DataKeyNames="Codigo" OnRowCommand="gvDatos_RowCommand">
                          <Columns>
                              <asp:ButtonField CommandName="Select" Text="Seleccionar" />
                          </Columns>
                          <FooterStyle BackColor="#CCCCCC" />
                          <HeaderStyle BackColor="Black" Font-Bold="True" ForeColor="White" />
                          <PagerStyle BackColor="#CCCCCC" ForeColor="Black" HorizontalAlign="Center" />
                          <RowStyle BackColor="White" />
                          <SelectedRowStyle BackColor="#000099" Font-Bold="True" ForeColor="White" />
                          <SortedAscendingCellStyle BackColor="#F1F1F1" />
                          <SortedAscendingHeaderStyle BackColor="#808080" />
                          <SortedDescendingCellStyle BackColor="#CAC9C9" />
                          <SortedDescendingHeaderStyle BackColor="#383838" />
                      </asp:GridView>
	
                   </div>
              </div>
           
     
        </main>
     
     
     
  
     
     
     
      </div>
     
     
     
  
     
     
     
</asp:Content>
