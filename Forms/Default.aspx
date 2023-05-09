<%@ Page Title="Home Page" Language="C#" MasterPageFile="~/Site.Master" AutoEventWireup="true" CodeBehind="Default.aspx.cs" Inherits="Forms._Default" %>

<asp:Content ID="BodyContent" ContentPlaceHolderID="MainContent" runat="server">

    <main>
        <section class="row" aria-labelledby="aspnetTitle">
            <h1 id="aspnetTitle">Engineering Change Notification</h1>
            </section>

        <div class="row">
            <section class="col-md-2" aria-labelledby="ECN">
                
                    ECN #:<asp:TextBox ID="ECNNO" runat="server" Width="100px"></asp:TextBox>
                
            </section>
            <section class="col-md-2" aria-labelledby="Date">
                <p>
                    Date: <asp:TextBox ID="TodaysDate" runat="server" Width="100px"></asp:TextBox>
                </p>
            </section>
         </div>
        <div class="row">
            <section aria-labelledby="Drawing">
                <p>Drawing #: <asp:TextBox ID="DrawingNo" runat="server" Wrap="False" Width="10000px"></asp:TextBox></p>
            </section>
        </div>
    
    </main>

</asp:Content>
