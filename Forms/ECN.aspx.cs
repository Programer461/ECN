using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace Forms
{
    public partial class WebForm1 : System.Web.UI.Page
    {

        protected void Page_Load(object sender, EventArgs e)
        {
            TodaysDate1.Text = DateTime.Now.ToString("yyyy/MM/dd");



        }

        protected void Submit_Click(object sender, EventArgs e)
        {
            string ECNNO = ECNNO1.Text.Trim();
            string TodaysDate = TodaysDate1.Text.Trim();
            string DrawingNo = DrawingNo1.Text.Trim();
            string FilePath = FilePath1.Text.Trim();
            string RevNo = RevNo1.Text.Trim();
            string ECN_By = ECN_By1.SelectedItem.Text.Trim();
            string ProjectLeader = ProjectLeader1.SelectedItem.Text.Trim();
            string JobNo = JobNo1.Text.Trim();
            string SONo = SONo1.Text.Trim();
            string Customer = Customer1.Text.Trim();
            string CurrentJobAffect = CurrentJobAffect1.Checked ? "1" : "0";
            string ReasonforECN = ReasonforECN1.Text.Trim();
            string MFGParts = MFGParts1.Text.Trim();
            string PurchParts = PurchParts1.Text.Trim();
            string M2MRouting = M2MRouting1.Checked ? "1" : "0";
            string MachShop = MachShop1.Checked ? "1" : "0";
            string Fabrication = Fabrication1.Checked ? "1" : "0";
            string Assembly = Assembly1.Checked ? "1" : "0";
            string Purchasing = Purchasing1.Checked ? "1" : "0";
            string EngineeringLabor = EngineeringLabor1.Text.Trim();
            string ShopLabor = ShopLabor1.Text.Trim();
            string Materials = Materials1.Text.Trim();
            string TotalDirectCost = TotalDirectCost1.Text.Trim();
            string ShopComplete = ShopComplete1.Checked ? "1" : "0";
            string ShopStarted = ShopStarted1.Checked ? "1" : "0";
            string FutureWarranty = FutureWarranty1.Checked ? "1" : "0";
            string PurchAware = PurchAware1.Checked ? "1" : "0";
            string SEApproved = SEApproved1.Checked ? "1" : "0";
            string TDApproved = TDApproved1.Checked ? "1" : "0";
            string RootCause = RootCause1.Text.Trim();
            string PurchaseCost = PurchaseCost1.Text.Trim();

            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["M2Mdata03ConnectionString"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("exec usp_ECNjsInsert '" + ECNNO + "','" + TodaysDate + "','" + DrawingNo + "','" + FilePath + "','" + RevNo + "','" + ECN_By + "','" + ProjectLeader + "','" + JobNo + "','" + SONo + "','" + Customer + "','" + CurrentJobAffect + "','" + ReasonforECN + "','" + MFGParts + "','" + PurchParts + "','" + M2MRouting + "','" + MachShop + "','" + Fabrication + "','" + Assembly + "','" + Purchasing + "','" + EngineeringLabor + "','" + ShopLabor + "','" + Materials + "','" + TotalDirectCost + "','" + ShopComplete + "','" + ShopStarted + "','" + FutureWarranty + "','" + PurchAware + "','" + SEApproved + "','" + TDApproved + "','" + RootCause + "','" + PurchaseCost + "'", con))
                {
                    cmd.Connection = con;
                    cmd.Parameters.AddWithValue("@ECNNO", ECNNO1.Text);
                    cmd.Parameters.AddWithValue("@TodaysDate", TodaysDate1.Text);
                    cmd.Parameters.AddWithValue("@DrawingNo", DrawingNo1.Text);
                    cmd.Parameters.AddWithValue("@FilePath", FilePath1.Text);
                    cmd.Parameters.AddWithValue("@RevNo", RevNo1.Text);
                    cmd.Parameters.AddWithValue("@ECN_By", ECN_By1.Text);
                    cmd.Parameters.AddWithValue("@ProjectLeader", ProjectLeader1.Text);
                    cmd.Parameters.AddWithValue("@JobNo", JobNo1.Text);
                    cmd.Parameters.AddWithValue("@SONo", SONo1.Text);
                    cmd.Parameters.AddWithValue("@Customer", Customer1.Text);
                    cmd.Parameters.AddWithValue("@CurrentJobAffect", CurrentJobAffect1.Checked);
                    cmd.Parameters.AddWithValue("@ReasonforECN", ReasonforECN1.Text);
                    cmd.Parameters.AddWithValue("@MFGParts", MFGParts1.Text);
                    cmd.Parameters.AddWithValue("@PurchParts", PurchParts1.Text);
                    cmd.Parameters.AddWithValue("@M2MRouting", M2MRouting1.Checked);
                    cmd.Parameters.AddWithValue("@MachShop", MachShop1.Checked);
                    cmd.Parameters.AddWithValue("@Fabrication", Fabrication1.Checked);
                    cmd.Parameters.AddWithValue("@Assembly", Assembly1.Checked);
                    cmd.Parameters.AddWithValue("@Purchasing", Purchasing1.Checked);
                    cmd.Parameters.AddWithValue("@EngineeringLabor", EngineeringLabor1.Text);
                    cmd.Parameters.AddWithValue("@ShopLabor", ShopLabor1.Text);
                    cmd.Parameters.AddWithValue("@Materials", Materials1.Text);
                    cmd.Parameters.AddWithValue("@TotalDirectCost", TotalDirectCost1.Text);
                    cmd.Parameters.AddWithValue("@ShopComplete", ShopComplete1.Checked);
                    cmd.Parameters.AddWithValue("@ShopStarted", ShopStarted1.Checked);
                    cmd.Parameters.AddWithValue("@FutureWarranty", FutureWarranty1.Checked);
                    cmd.Parameters.AddWithValue("@PurchAware", PurchAware1.Checked);
                    cmd.Parameters.AddWithValue("@SEApproved", SEApproved1.Checked);
                    cmd.Parameters.AddWithValue("@TDApproved", TDApproved1.Checked);
                    cmd.Parameters.AddWithValue("@RootCause", RootCause1.Text);
                    cmd.Parameters.AddWithValue("@PurchaseCost", PurchaseCost1.Text);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
        }

        protected void Search_Click(object sender, EventArgs e)
        {
            string ECNNO = ECNNO1.Text.Trim();
            string CurrentJobAffect = CurrentJobAffect1.Checked ? "1" : "0";

            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["M2Mdata03ConnectionString"].ConnectionString))
            {
                con.Open();
                //using (SqlCommand ddl1 = new SqlCommand("Select * from engtimeempl")) 
                using (SqlCommand cmd = new SqlCommand("exec usp_ECNjsSelect '" + ECNNO + "'", con))
                using (SqlDataReader reader = cmd.ExecuteReader())
                   
                {
                  /*  ddl1.Connection.Open();
                   using (SqlDataReader ddlValues = ddl1.ExecuteReader()) 
                    {
                                                   
                        ECN_By1.DataSource = ddlValues;
                        ECN_By1.DataValueField = "fullname";
                        ECN_By1.DataTextField = "fullname";
                        ECN_By1.DataBind();
                        ProjectLeader1.DataSource = ddlValues;
                        ProjectLeader1.DataValueField = "ClockName";
                        ProjectLeader1.DataTextField = "ClockName";
                        ProjectLeader1.DataBind();

                        ddl1.Connection.Close();
                    }
                  */
                    while (reader.Read())
                    {
                        ECNNO1.Text = reader.GetValue(0).ToString();
                        TodaysDate1.Text = reader.GetValue(1).ToString();
                        DrawingNo1.Text = reader.GetValue(2).ToString();
                        FilePath1.Text = reader.GetValue(3).ToString();
                        RevNo1.Text = reader.GetValue(4).ToString();
                        ECN_By1.SelectedValue = reader.GetValue(5).ToString();
                        ProjectLeader1.SelectedValue = reader.GetValue(6).ToString();
                        JobNo1.Text = reader.GetValue(7).ToString();
                        SONo1.Text = reader.GetValue(8).ToString();
                        Customer1.Text = reader.GetValue(9).ToString();
                        CurrentJobAffect1.Text = reader.GetValue(10).ToString();
                        ReasonforECN1.Text = reader.GetValue(11).ToString();
                        MFGParts1.Text = reader.GetValue(12).ToString();
                        PurchParts1.Text = reader.GetValue(13).ToString();
                        M2MRouting1.Text = reader.GetValue(14).ToString();
                        MachShop1.Text = reader.GetValue(15).ToString();
                        Fabrication1.Text = reader.GetValue(16).ToString();
                        Assembly1.Text = reader.GetValue(17).ToString();
                        Purchasing1.Text = reader.GetValue(18).ToString();
                        EngineeringLabor1.Text = reader.GetValue(19).ToString();
                        ShopLabor1.Text= reader.GetValue(20).ToString();
                        Materials1.Text = reader.GetValue(21).ToString();
                        TotalDirectCost1.Text = reader.GetValue(22).ToString();
                        ShopComplete1.Text = reader.GetValue(23).ToString();
                        ShopStarted1.Text = reader.GetValue(24).ToString();
                        FutureWarranty1.Text = reader.GetValue(25).ToString();
                        PurchAware1.Text = reader.GetValue(26).ToString();
                        SEApproved1.Text = reader.GetValue(27).ToString();
                        TDApproved1.Text = reader.GetValue(28).ToString();
                        RootCause1.Text = reader.GetValue(29).ToString();
                        PurchaseCost1.Text = reader.GetValue(30).ToString();

                    }
                    con.Close();
                }
            }
        }
        protected void Update_Click(object sender, EventArgs e)
        {
            string ECNNO = ECNNO1.Text.Trim();
            string TodaysDate = TodaysDate1.Text.Trim();
            string DrawingNo = DrawingNo1.Text.Trim();
            string FilePath = FilePath1.Text.Trim();
            string RevNo = RevNo1.Text.Trim();
            string ECN_By = ECN_By1.SelectedItem.Text.Trim();
            string ProjectLeader = ProjectLeader1.SelectedItem.Text.Trim();
            string JobNo = JobNo1.Text.Trim();
            string SONo = SONo1.Text.Trim();
            string Customer = Customer1.Text.Trim();
            string CurrentJobAffect = CurrentJobAffect1.Checked ? "1" : "0";
            string ReasonforECN = ReasonforECN1.Text.Trim();
            string MFGParts = MFGParts1.Text.Trim();
            string PurchParts = PurchParts1.Text.Trim();
            string M2MRouting = M2MRouting1.Checked ? "1" : "0";
            string MachShop = MachShop1.Checked ? "1" : "0";
            string Fabrication = Fabrication1.Checked ? "1" : "0";
            string Assembly = Assembly1.Checked ? "1" : "0";
            string Purchasing = Purchasing1.Checked ? "1" : "0";
            string EngineeringLabor = EngineeringLabor1.Text.Trim();
            string ShopLabor = ShopLabor1.Text.Trim();
            string Materials = Materials1.Text.Trim();
            string TotalDirectCost = TotalDirectCost1.Text.Trim();
            string ShopComplete = ShopComplete1.Checked ? "1" : "0";
            string ShopStarted = ShopStarted1.Checked ? "1" : "0";
            string FutureWarranty = FutureWarranty1.Checked ? "1" : "0";
            string PurchAware = PurchAware1.Checked ? "1" : "0";
            string SEApproved = SEApproved1.Checked ? "1" : "0";
            string TDApproved = TDApproved1.Checked ? "1" : "0";
            string RootCause = RootCause1.Text.Trim();
            string PurchaseCost = PurchaseCost1.Text.Trim();

            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["M2Mdata03ConnectionString"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("exec usp_ECNjsUpdate '" + ECNNO + "','" + TodaysDate + "','" + DrawingNo + "','" + FilePath + "','" + RevNo + "','" + ECN_By + "','" + ProjectLeader + "','" + JobNo + "','" + SONo + "','" + Customer + "','" + CurrentJobAffect + "','" + ReasonforECN + "','" + MFGParts + "','" + PurchParts + "','" + M2MRouting + "','" + MachShop + "','" + Fabrication + "','" + Assembly + "','" + Purchasing + "','" + EngineeringLabor + "','" + ShopLabor + "','" + Materials + "','" + TotalDirectCost + "','" + ShopComplete + "','" + ShopStarted + "','" + FutureWarranty + "','" + PurchAware + "','" + SEApproved + "','" + TDApproved + "','" + RootCause + "','" + PurchaseCost + "'", con))
                {
                    cmd.Connection = con;
                    cmd.Parameters.AddWithValue("@ECNNO", ECNNO1.Text);
                    cmd.Parameters.AddWithValue("@TodaysDate", TodaysDate1.Text);
                    cmd.Parameters.AddWithValue("@DrawingNo", DrawingNo1.Text);
                    cmd.Parameters.AddWithValue("@FilePath", FilePath1.Text);
                    cmd.Parameters.AddWithValue("@RevNo", RevNo1.Text);
                    cmd.Parameters.AddWithValue("@ECN_By", ECN_By1.Text);
                    cmd.Parameters.AddWithValue("@ProjectLeader", ProjectLeader1.Text);
                    cmd.Parameters.AddWithValue("@JobNo", JobNo1.Text);
                    cmd.Parameters.AddWithValue("@SONo", SONo1.Text);
                    cmd.Parameters.AddWithValue("@Customer", Customer1.Text);
                    cmd.Parameters.AddWithValue("@CurrentJobAffect", CurrentJobAffect1.Checked);
                    cmd.Parameters.AddWithValue("@ReasonforECN", ReasonforECN1.Text);
                    cmd.Parameters.AddWithValue("@MFGParts", MFGParts1.Text);
                    cmd.Parameters.AddWithValue("@PurchParts", PurchParts1.Text);
                    cmd.Parameters.AddWithValue("@M2MRouting", M2MRouting1.Checked);
                    cmd.Parameters.AddWithValue("@MachShop", MachShop1.Checked);
                    cmd.Parameters.AddWithValue("@Fabrication", Fabrication1.Checked);
                    cmd.Parameters.AddWithValue("@Assembly", Assembly1.Checked);
                    cmd.Parameters.AddWithValue("@Purchasing", Purchasing1.Checked);
                    cmd.Parameters.AddWithValue("@EngineeringLabor", EngineeringLabor1.Text);
                    cmd.Parameters.AddWithValue("@ShopLabor", ShopLabor1.Text);
                    cmd.Parameters.AddWithValue("@Materials", Materials1.Text);
                    cmd.Parameters.AddWithValue("@TotalDirectCost", TotalDirectCost1.Text);
                    cmd.Parameters.AddWithValue("@ShopComplete", ShopComplete1.Checked);
                    cmd.Parameters.AddWithValue("@ShopStarted", ShopStarted1.Checked);
                    cmd.Parameters.AddWithValue("@FutureWarranty", FutureWarranty1.Checked);
                    cmd.Parameters.AddWithValue("@PurchAware", PurchAware1.Checked);
                    cmd.Parameters.AddWithValue("@SEApproved", SEApproved1.Checked);
                    cmd.Parameters.AddWithValue("@TDApproved", TDApproved1.Checked);
                    cmd.Parameters.AddWithValue("@RootCause", RootCause1.Text);
                    cmd.Parameters.AddWithValue("@PurchaseCost", PurchaseCost1.Text);

                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();

                }
            }
        }
        protected void Delete_Click(object sender, EventArgs e)
        {
            string ECNNO = ECNNO1.Text.Trim();
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["M2Mdata03ConnectionString"].ConnectionString))
            {
                using (SqlCommand cmd = new SqlCommand("delete from ECNjs where ECNNO ='" + ECNNO + "'", con))
                {
                    cmd.Connection = con;
                    cmd.Parameters.AddWithValue("@ECNNO", ECNNO1.Text);
                    
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
            }
        }
        
    } 
}


       