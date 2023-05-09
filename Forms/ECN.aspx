<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="ECN.aspx.cs" Inherits="Forms.WebForm1" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Engineering Change Notification 
</title>
</head>
<body>
    
    <form id="form1" runat="server">
        <div>
            <table>
                <tr>
                    <td>Engineering Change Notification</td>
                </tr>
            </table>
            <table>
                <tr>
                    <td>ECN #: </td>
                    <td>
                        <asp:TextBox ID="ECNNO1" runat="server" Width="100px"></asp:TextBox></td>
                    <td>Date:</td>
                    <td>
                        <asp:TextBox ID="TodaysDate1" TextMode="Date" runat="server" Width="100px"> </asp:TextBox></td>
                </tr>
                
            </table>
            <hr />
            <table>
                <tr>
                    <td>Drawing #:</td>
                    <td>
                        <asp:TextBox ID="DrawingNo1" runat="server" Width="700px"></asp:TextBox></td>
                    <td>Rev #:</td>
                    <td>
                        <asp:TextBox ID="RevNo1" runat="server" Width="39px"></asp:TextBox></td>
                </tr>
                
            </table>
            <hr />
            <table>
                <tr>
                    <td>File Path:  </td>
                    <td>
                        <asp:TextBox ID="FilePath1" runat="server" Width="800px"></asp:TextBox></td>

                </tr>
            </table>
            <table>
                <tr>
                    <td>By: </td>
                    <td>
                        <asp:DropDownList ID="ECN_By1" runat="server"  DataTextField="fullname" DataValueField="fullname" DataSourceID="M2M2" AppendDataBoundItems="True"></asp:DropDownList></td>
                    <td>Responsible Engineer: </td>
                    <td>
                        <asp:DropDownList ID="ProjectLeader1" runat="server" DataTextField="ClockName" DataValueField="ClockName" DataSourceID="M2M2" AppendDataBoundItems="True"></asp:DropDownList></td>
                </tr>
                
            </table>
            <hr />
            <table>
                <tr>
                    <td>Current Status</td>
                </tr>
            </table>
            <table>
                <tr>
                    <td>
                        <asp:CheckBox ID="M2MRouting1" runat="server" Text="M2M Routing:" /></td>
                   <td>
                        <asp:CheckBox ID="Fabrication1" runat="server" Text="Fabrication:" /></td>
                    <td>
                        <asp:CheckBox ID="MachShop1" runat="server" Text="Machining:" /></td>
                    <td>
                        <asp:CheckBox ID="Assembly1" runat="server" Text="Assembly:" /></td>
                    <td>
                        <asp:CheckBox ID="Purchasing1" runat="server" Text="Purchasing:" /></td>
                </tr>
            </table>
            <table>
                <tr>
                    <td>
                        <asp:CheckBox ID="CurrentJobAffect1" runat="server" Text="No Current Job" /></td>
                   <td>
                        <asp:CheckBox ID="FutureWarranty1" runat="server" Text="Future Warranty" /></td>
                    <td>
                        <asp:CheckBox ID="ShopComplete1" runat="server" Text="Shop Has Already Completed Changes Per This ECN" /></td>
                </tr>
            </table>
             <table>
                <tr>
                    <td>Job #:</td>
                    <td>
                        <asp:TextBox ID="JobNo1" runat="server" Width="100px"></asp:TextBox></td>
                    <td>SO #:</td>
                    <td>
                        <asp:TextBox ID="SONo1" runat="server" Width="100px"></asp:TextBox></td>
                </tr>
             </table>
            <table>
                <tr>
                    <td>Customer #:</td>
                    <td>
                        <asp:TextBox ID="Customer1" runat="server" Width="800px"></asp:TextBox></td>
                </tr>
            </table>
            <hr />
            <table>
                <tr>
                    <td>Changes to be made to Drawing:                                                                                         </td>
                    <td>
                        <asp:CheckBox ID="ShopStarted1" runat="server" Text="Shop has already started changes per this ECN" /></td>
                </tr>
             </table>
             <table>
                <tr>
                    <td>
                        <asp:TextBox ID="MFGParts1" runat="server" Width="880px"></asp:TextBox></td>
                </tr>
             </table>
             <table>   
                    <tr>
                    <td>Details regarding purchase parts:                                                                                         </td>
                    <td>
                        <asp:CheckBox ID="PurchAware1" runat="server" Text="Purchasing is aware of changes" /></td>
                </tr>
             </table>
             <table>
                <tr>
                    <td>    New Parts: Not On Order /On Order /Already In House </td>
                </tr>
            </table>
            <table>
                <tr>
                    <td>     Deleted Parts: Not On Order /On Order /Already In House / Return To Stock /</td>
                </tr>
            </table>
            <table>
                <tr>
                    <td>    Return To Supplier / Scrap /Rework Existing Part (Explain)</td>
                </tr>
            </table>
             <table>
                <tr>
                    <td>
                        <asp:TextBox ID="PurchParts1" runat="server" Width="880px"></asp:TextBox></td>
                </tr>
             </table>
            <table>
                <tr>
                    <td>Root Cause/Reason for ECN:</td>
                    <td>
                        <asp:DropDownList ID="RootCause1" runat="server">
                            <asp:ListItem>Select...</asp:ListItem>
                            <asp:ListItem>Customer Change</asp:ListItem>
                            <asp:ListItem>Planned ECN</asp:ListItem>
                            <asp:ListItem>Shop Error</asp:ListItem>
                            <asp:ListItem>Drafting Error</asp:ListItem>
                            <asp:ListItem>Design Error</asp:ListItem>
                            <asp:ListItem>Legacy Drafting Error</asp:ListItem>
                            <asp:ListItem>Legacy Design Error</asp:ListItem>
                            <asp:ListItem>Missing Information</asp:ListItem>
                            <asp:ListItem>Design Improvement</asp:ListItem>
                            <asp:ListItem>BOM Checking</asp:ListItem>
                            <asp:ListItem>Component/Material Substitution (availability)</asp:ListItem>
                            <asp:ListItem>Vendor Component not to Specification</asp:ListItem>
                            <asp:ListItem>Other</asp:ListItem>
                        </asp:DropDownList></td>
                    </tr>
            </table>
            <hr />
            <table>
                <tr>
                    <td><asp:TextBox ID="ReasonforECN1" runat="server" Width="880px"></asp:TextBox></td>
                </tr>
            </table>
            <table>
                <tr>
                    <td width="200px">
                        <asp:CheckBox ID="SEApproved1" runat="server" Text="System Engineer Approved " /></td>
                   <td width="210px">
                        <asp:CheckBox ID="TDApproved1" runat="server" Text="Technical Director Approved" /></td>
                    <td width="141px"></td>
                    <td width="140px"><u>Estimated Impact</u>
            </td>
                </tr>
            </table>
            <table>
                <tr>
                    <td width="560px"></td>
                    <td width="140px">Engineering Hours:</td>
                    <td>
                        <asp:TextBox ID="EngineeringLabor1" runat="server"></asp:TextBox></td>
                </tr>
            </table>
            <table>
                <tr>
                   <td width="560px"></td>
                    <td width="140px">Shop Labor Hours:</td>
                    <td>
                        <asp:TextBox ID="ShopLabor1" runat="server"></asp:TextBox></td>
                </tr>
            </table>
            <table>
                <tr>
                    <td width="560px"></td>
                    <td width="140px">Raw Materials:</td>
                     <td>
                        <asp:TextBox ID="Materials1" runat="server"></asp:TextBox></td>
                </tr>
            </table>
            <table>
                <tr>
                    <td width="560px"></td>
                    <td width="140px">Purchase Parts:</td>
                    <td>
                        <asp:TextBox ID="PurchaseCost1" runat="server"></asp:TextBox></td>
                </tr>
            </table>
            <table>
                <tr>
                    <td width="560px"></td>
                    <td width="140px">Total Direct Cost:</td>
                    <td>
                        <asp:TextBox ID="TotalDirectCost1" runat="server"></asp:TextBox></td>
                </tr>
            </table>
            <table>
                <tr>
                    <td><asp:Button ID="Submit" runat="server" Text="Submit" OnClick="Submit_Click" /></td>
                    <td><asp:Button ID="Search" runat="server" Text="Search" OnClick="Search_Click" /></td>
                    <td><asp:Button ID="Update" runat="server" Text="Update" OnClick="Update_Click" /></td>
                    <td><asp:Button ID="Delete" runat="server" Text="Delete" OnClick="Delete_Click" /></td>
                
                </tr>
            </table>
        </div>
    </form>
    <asp:SqlDataSource ID="M2M2" runat="server" ConnectionString="<%$ ConnectionStrings:M2Mdata03ConnectionString %>" SelectCommand="SELECT * FROM [ENGTIMEEMPL]"></asp:SqlDataSource>
</body>
</html>
