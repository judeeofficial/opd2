<%@ Page Language="C#" AutoEventWireup="true" CodeFile="bug1.aspx.cs" Inherits="testbug_bug1" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>Database Driven AutoCompleteList Using JQuery</title>
    <link rel="stylesheet" href="../css/jquery-ui.css" />

    <script src="../js/jquery-1.8.3.js" type="text/javascript" ></script>

    <script src="../js/jquery-ui.js" type="text/javascript" ></script>

    <script type="text/javascript" >
    function LoadList()
    {        
        var ds=null;
        ds = <%=listFilter %>;
            $( "#txtCountry1" ).autocomplete({
              source: ds
            });
    }
    </script>

</head>
<body onload="LoadList()">
      <div class="wrapper row1">
        <header id="header" class="clear">
     <div class="navbar-header">
               <img alt="" class="auto-style1" src="../image/image1.jpg" /> 
          
            </div> 
            <div id="hgroup">
           <L1><h1><a href="#">ระบบการบริการ</a></h1></L1> 
                <h2>งานแพทย์และอนามัย มหาวิทยาลัยรามคำแหง</h2>
            </div>
        </header>
    </div>
    <form id="form1" runat="server">
        <h3>
            Database Driven AutoCompleteList Using JQuery</h3>
        <div class="ui-widget">
            <label for="tags">
                Country :
            </label>
     
            <asp:TextBox ID="txtCountry1" ClientIDMode="Static" runat="server"></asp:TextBox>
        </div>
    </form>
</body>
</html>
