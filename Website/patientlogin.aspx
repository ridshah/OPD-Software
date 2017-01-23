<%@ Page Language="VB" AutoEventWireup="false" CodeFile="patientlogin.aspx.vb" Inherits="patientlogin" %>

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
  <form id="form1" runat="server" >
    <div>
    
    </div>
    <asp:Login ID="Login1" runat="server">
    </asp:Login>
    <div style ="color:Red"><asp:Label ID="Label1" runat="server" Text="Label">Your name as registered in hospital is your username. Ex:- FirstName MiddleName LastName.</asp:Label></div> 
    <div style ="color:Red"><asp:Label ID="Label2" runat="server" Text="Label">Your password is your date of birth in format dd/mm/yyyy. Ex:- 01/01/1666</asp:Label></div>
    </form>
     <div class="clear"></div>
    </div> 
    <div id="footer">
    <div class="copyright"> <img src="images/footer_logo.gif" alt="" /></div>
    <div class="center_footer">© Medical Clinic 2008. All Rights Reserved</div>
  </div> 
  </div> 
<div align="center"></div>
</body>
</html>
