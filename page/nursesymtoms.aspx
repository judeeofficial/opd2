<%@ Page Language="C#" AutoEventWireup="true" CodeFile="nursesymtoms.aspx.cs" Inherits="page_nursesymtoms" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <title>งานแพทย์และอนามัย มหาวิทยาลัยรามคำแหง</title>
     
    <!-- Bootstrap Core CSS -->
    <link href="../css/bootstrap.min.css" rel="stylesheet">
    <!-- Custom CSS -->
        <link rel="stylesheet" href="/css/label.css" type="text/css" media="all">
    <link rel="stylesheet" href="/css/font-awesome.min.css" type="text/css" media="all">
    <link rel="stylesheet" href="/css/layout.css" type="text/css" media="all">
    <link rel="stylesheet" href="/css/mediaqueries.css" type="text/css" media="all">
    <link rel="stylesheet" href="/css/contents.css" type="text/css" media="all">
    <link rel="stylesheet" href="../css/jquery-ui.css" />
          <script src="../js/jquery.js" type="text/javascript" ></script>
           <script src="../js/bootstrap.min.js" type="text/javascript" ></script>
    <script src="../js/jquery-1.8.3.js" type="text/javascript" ></script>

    <script src="../js/jquery-ui.js" type="text/javascript" ></script>
  
    <script type="text/javascript" >
    function LoadList()
    {        
        var ds=null;
        ds = <%=listFilter %>;
        $( "#txtsymptomhost" ).autocomplete({
              source: ds
            });
    }
    </script>
      <style type="text/css">
        @import url(fonts/thsarabunnew.css);

        html {
            overflow-y: scroll;
        }

        body {
            font-family: 'THSarabunNew', sans-serif;
            font-size: 1.4em;
            background-color: #f1f1f1;
        }
        .auto-style1 {
            width: 68px;
            height: 79px;
        }
    </style>
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
           <!-- Static navbar -->
    <nav class="navbar navbar-default" style="margin-bottom:10px">
        <div class="container-fluid">
            <div class="navbar-header">
                <button type="button" class="navbar-toggle collapsed" data-toggle="collapse" data-target="#navbar" aria-expanded="false" aria-controls="navbar">
                    <span class="sr-only">Toggle navigation</span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                    <span class="icon-bar"></span>
                </button>

            </div>
            <div id="navbar" class="navbar-collapse collapse">
                <ul class="nav navbar-nav">
                    <li class="active"><a href="../page/index.aspx">Home</a></li>
                    <li><a href="../page/opdlogin.aspx">ระบบงานเวชระเบียน</a></li>
                    <li><a href="../page/nurselogin.aspx">ระบบงานพยาบาล</a></li>
                             <li><a href="../page/bosslogin.aspx">หัวหน้า</a></li>
                     <li><a href="../page/doctorlogin.aspx">แพทย์</a></li>
                 <!--   <li class="dropdown">
                         <a href="#" class="dropdown-toggle" data-toggle="dropdown" role="button" aria-haspopup="true" aria-expanded="false">การจัดการแพทย์<span class="caret"></span></a>
                       <ul class="dropdown-menu">
                            <li><a href="#">จัดตารางการปฏิบัติงานแพทย์</a></li>
                            <li><a href="#">ระบบแพทย์</a></li>
                        
                        </ul>
                    </li> --> 

                </ul> 
                        
                <ul class="nav navbar-nav navbar-right">
               <li class="active"><a href="#">
                   <asp:Label ID="lblLogin" runat="server">ยังไม่เข้าสู่ระบบ</asp:Label></a></li> 
                 
                </ul>
            </div><!--/.nav-collapse -->
        </div><!--/.container-fluid -->
    </nav>
             
              <div class="ui-widget">
        <asp:ScriptManager ID="ScriptManager1" runat="server">
            </asp:ScriptManager>
            <asp:UpdatePanel ID="UpdatePanel1" runat="server">
                <ContentTemplate>
                  
                           
                                    
          <table style="width: 100%;" class="table table-condensed">
        <tr>
           
            <td class="active" style="height: 97px">เลือกหัวข้อการซักประวัติเบื้องต้น<asp:DropDownList ID="DropDownListdiagnose"  ClientIDMode="Static" runat="server" class="form-control input-lg" Height="48px" Width="650px" DataSourceID="SqlDataSource1" DataTextField="Symptom_name" DataValueField="Symptoms_ID"  AutoPostBack="True" AppendDataBoundItems="True" OnSelectedIndexChanged="DropDownListdiagnose_SelectedIndexChanged" >
                      <asp:ListItem>-กรุณาเลือก-</asp:ListItem>
                </asp:DropDownList>
                <asp:SqlDataSource ID="SqlDataSource1" runat="server" ConnectionString="<%$ ConnectionStrings:Connectionstring %>" SelectCommand="SELECT * FROM [Symptoms]"></asp:SqlDataSource>
              
            </td>
       
        
        </tr>
        <tr>
            <td class="active">
                <asp:Panel ID="Panel1" runat="server">

              
  
                        บันทึกอาการหลัก
                        <asp:TextBox ID="txtsymptomhost" class="form-control" runat="server" Height="63px" TextMode="MultiLine" Width="860px" OnTextChanged="txtsymtomhost_TextChanged"  ClientIDMode="Static" ></asp:TextBox>
                </asp:Panel>
            
                <asp:Panel ID="Panel2" runat="server">
                         บันทึกอาการรอง
                          <asp:TextBox ID="txtsubsymtoms" runat="server" class="form-control" Height="63px" TextMode="MultiLine" Width="860px"></asp:TextBox>
                </asp:Panel>
                  
                        
                  
 
                
                     
                        

                
            </td>
        
      
        </tr>
          <tr>
         <td class="active">
               <asp:TextBox ID="txtCheck" runat="server"  class="form-control" disabled TextMode="MultiLine" placeholder="อาการที่ใช้ในการวิเคราะห์"  Height="87px" Width="870px"></asp:TextBox></td>
               
        </tr>
     
    </table>
    


                          
    
                        
                </ContentTemplate>
            </asp:UpdatePanel>
            <asp:UpdateProgress ID="UpdateProgress1" runat="server">
                <ProgressTemplate>
                    <asp:Label ID="lblShow" runat="server" Text="กำลังตรวจสอบ"></asp:Label>
                </ProgressTemplate>
            </asp:UpdateProgress>
                      </div>


    </body>
     
                     
 
                    
    </form>
        <div class="wrapper row4">
        <footer id="footer" class="clear">
            <p class="fl_left">Copyright &copy; 2017 - All Rights Reserved - <a href="#">Ramkhamhaeng University</a></p>

        </footer></div>

</html>
