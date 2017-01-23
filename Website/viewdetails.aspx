<%@ Page Language="VB" AutoEventWireup="false" CodeFile="viewdetails.aspx.vb" Inherits="viewdetails" %>

<!DOCTYPE html PUBLIC "-//W3C//DTD XHTML 1.0 Transitional//EN" "http://www.w3.org/TR/xhtml1/DTD/xhtml1-transitional.dtd">

<html xmlns="http://www.w3.org/1999/xhtml">
<head>
    <title>Medical Clinic</title>
    <meta http-equiv="Content-Type" content="text/html; charset=utf-8" />
<link rel="stylesheet" type="text/css" href="style.css" media="screen" />
<!--[if IE 6]>
<link rel="stylesheet" type="text/css" href="iecss.css" />
<![endif]-->
</head>
<body>
<div id="main_container">
  <div class="header">
    <div id="logo"><img src="images/logo.png" alt="" width="162" height="54" border="0" /></div>
    <div class="right_header">
      <div class="top_menu"> 
        <a href="patientlogin.aspx" class="login">login</a>  
      </div>
      <div id="menu">
        <ul>
          <li><a href="Default.aspx">Home</a></li>
          <li><a href="about.aspx">About Us</a></li>
          <li><a href="services.aspx">Services</a></li>
          <li><a href="contactus.aspx">Contact Us</a></li>
        </ul>
      </div>
    </div>
  </div>
  <div id="middle_box">
    <div class="middle_box_content"><img src="images/banner_content.jpg" alt="" /></div>
  </div>
   <div id="main_content" align="center" >
    <form id="form1" runat="server">
    <asp:GridView ID="GridView1" runat="server" AutoGenerateColumns="False" 
        DataSourceID="SqlDataSource1">
        <Columns>
            <asp:BoundField DataField="patient_id" HeaderText="Patient ID" 
                SortExpression="patient_id"  />
            <asp:BoundField DataField="patient_name" HeaderText="Patient Name" 
                SortExpression="patient_name" />
            <asp:BoundField DataField="patient_dob" HeaderText="Patient DateOfBirth" 
                SortExpression="patient_dob" />
            <asp:BoundField DataField="emp_name" HeaderText="Employee Name" 
                SortExpression="emp_name" />
            <asp:BoundField DataField="appoint_date" HeaderText="Appointment Date" 
                SortExpression="appoint_date" />
            <asp:BoundField DataField="diagnosis_name" HeaderText="Diagnosis Name" 
                SortExpression="diagnosis_name" />
            <asp:BoundField DataField="diagnosis_date" HeaderText="Diagnosis Date" 
                SortExpression="diagnosis_date" />
            <asp:BoundField DataField="advice" HeaderText="Advice" 
                SortExpression="advice" />
            <asp:BoundField DataField="recommendation" HeaderText="Recommendation" 
                SortExpression="recommendation" />
            <asp:BoundField DataField="prescription" HeaderText="Prescription" 
                SortExpression="prescription" />
        </Columns>
    </asp:GridView>
    <asp:SqlDataSource ID="SqlDataSource1" runat="server" 
        ConnectionString="<%$ ConnectionStrings:opdsysConnectionString %>" 
        
        SelectCommand="SELECT [patient_id], [patient_name], [patient_dob], [emp_name], [appoint_date], [diagnosis_name], [diagnosis_date], [advice], [recommendation], [prescription] FROM [viewdetails]"></asp:SqlDataSource>
    </form>
    <div class="clear"></div>
   
    </div> 
     <div id="footer">
    <div class="copyright"> <img src="images/footer_logo.gif" alt="" /> </div>
    <div class="center_footer">© Medical Clinic 2008. All Rights Reserved</div>
    <div class="footer_links"> &nbsp;</div>
  </div>
</div> 
 <div align="center"></div>
</body>
</html>
