<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="training_session.aspx.cs" Inherits="deedback.Admin.training_session" %>

<!DOCTYPE html>
<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8">
  <meta http-equiv="X-UA-Compatible" content="IE=edge">
  <title>Admin|Training_session</title>
  <!-- Tell the browser to be responsive to screen width -->
  <meta content="width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no" name="viewport">
  <!-- Bootstrap 3.3.7 -->
  <link rel="stylesheet" href="bower_components/bootstrap/dist/css/bootstrap.min.css">
  <!-- Font Awesome -->
  <link rel="stylesheet" href="bower_components/font-awesome/css/font-awesome.min.css">
  <!-- Ionicons -->
  <link rel="stylesheet" href="bower_components/Ionicons/css/ionicons.min.css">
  <!-- Theme style -->
  <link rel="stylesheet" href="dist/css/AdminLTE.min.css">
  <!-- AdminLTE Skins. Choose a skin from the css/skins
       folder instead of downloading all of them to reduce the load. -->
  <link rel="stylesheet" href="dist/css/skins/_all-skins.min.css">
  <!-- Morris chart -->
  <link rel="stylesheet" href="bower_components/morris.js/morris.css">
  <!-- jvectormap -->
  <link rel="stylesheet" href="bower_components/jvectormap/jquery-jvectormap.css">
  <!-- Date Picker -->
  <link rel="stylesheet" href="bower_components/bootstrap-datepicker/dist/css/bootstrap-datepicker.min.css">
  <!-- Daterange picker -->
  <link rel="stylesheet" href="bower_components/bootstrap-daterangepicker/daterangepicker.css">
  <!-- bootstrap wysihtml5 - text editor -->
  <link rel="stylesheet" href="plugins/bootstrap-wysihtml5/bootstrap3-wysihtml5.min.css">

  <!-- HTML5 Shim and Respond.js IE8 support of HTML5 elements and media queries -->
  <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
  <!--[if lt IE 9]>
  <script src="https://oss.maxcdn.com/html5shiv/3.7.3/html5shiv.min.js"></script>
  <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
  <![endif]-->

  <!-- Google Font -->
  <link rel="stylesheet" href="https://fonts.googleapis.com/css?family=Source+Sans+Pro:300,400,600,700,300italic,400italic,600italic">
</head>
<body class="hold-transition skin-blue sidebar-mini">
<div class="wrapper">

  <header class="main-header">
    <!-- Logo -->
    <a href="index2.html" class="logo">
      <!-- mini logo for sidebar mini 50x50 pixels -->
      <span class="logo-mini"><b>A</b>LT</span>
      <!-- logo for regular state and mobile devices -->
      <span class="logo-lg"><b>Admin</b></span>
    </a>
    <!-- Header Navbar: style can be found in header.less -->
    <nav class="navbar navbar-static-top">
      <!-- Sidebar toggle button-->
      <a href="#" class="sidebar-toggle" data-toggle="push-menu" role="button">
        <span class="sr-only">Toggle navigation</span>
      </a>

      <div class="navbar-custom-menu">
        <ul class="nav navbar-nav">
          <!-- Messages: style can be found in dropdown.less-->
      
          <!-- Notifications: style can be found in dropdown.less -->

          <!-- Tasks: style can be found in dropdown.less -->
     
          <!-- User Account: style can be found in dropdown.less -->
          <li class="dropdown user user-menu">
            <a href="#" class="dropdown-toggle" data-toggle="dropdown">
             
              <span class="hidden-xs"></span>
            </a>
            <ul class="dropdown-menu">
              <!-- User image -->
              <li class="user-header">
               

                <p>
                
                  <small>Member since . 2022</small>
                </p>
              </li>
              <!-- Menu Body -->
          
              <!-- Menu Footer-->
              <li class="user-footer">
              
                <div class="pull-right">
                  <a href="../index.aspx" class="btn btn-default btn-flat">Sign out</a>
                </div>
              </li>
            </ul>
          </li>
          <!-- Control Sidebar Toggle Button -->
         <%-- <li>
            <a href="#" data-toggle="control-sidebar"><i class="fa fa-gears"></i></a>
          </li>--%>
        </ul>
      </div>
    </nav>
  </header>
  <!-- Left side column. contains the logo and sidebar -->
  <aside class="main-sidebar">
    <!-- sidebar: style can be found in sidebar.less -->
  <section class="sidebar">
      <!-- Sidebar user panel -->

   
      <!-- /.search form -->
      <!-- sidebar menu: : style can be found in sidebar.less -->
      <ul class="sidebar-menu" data-widget="tree">
        <li class="header">MAIN NAVIGATION</li>
		   <li class="active"><a href="index.aspx"><i class="fa fa-dashboard"></i> <span>Dashboard</span></a></li>
        <li class="active treeview">
		   
        </li>

        <li class="header">User Option</li>
       
             <li class="treeview">
          <a href="#">
            <i class="fa fa-files-o"></i>
            <span>Manage</span>
            <span class="pull-right-container">
              <span class="label label-primary pull-right">4</span>
            </span>
          </a>
           <ul class="treeview-menu">
       <%--     <li><a href="Alumini.aspx"><i class="fa fa-circle-o"></i> Alumini</a></li>--%>
            <li><a href="Faculty.aspx"><i class="fa fa-circle-o"></i> Faculty</a></li>
            <li><a href="Current.aspx"><i class="fa fa-circle-o"></i> Current Students</a></li>
          <%--   <li><a href="ManageJob.aspx"><i class="fa fa-circle-o"></i> Manage Job_Drive</a></li>--%>
         
          </ul>
        </li>
     
       <%--<li><a href="courses.aspx"><i class="fa fa-circle-o text-yellow"></i> <span>Courses</span></a></li>--%>
       <%--   <li><a href="funds_view.aspx"><i class="fa fa-circle-o text-yellow"></i> <span>Funds</span></a></li>--%>
        <li><a href="view_courses.aspx"><i class="fa fa-circle-o text-yellow"></i> <span>View Courses</span></a></li>
       <li><a href="view_training.aspx"><i class="fa fa-circle-o text-yellow"></i> <span>Training Session</span></a></li>
   <%--    <li><a href="view_alumuni_meet.aspx"><i class="fa fa-circle-o text-yellow"></i> <span>Alumini meet</span></a></li>--%>
        <li><a href="../logout.aspx"><i class="fa fa-sign-out text-aqua"></i> <span>Logout</span></a></li>
      </ul>
    </section>
    <!-- /.sidebar -->
  </aside>

  <!-- Content Wrapper. Contains page content -->
  <div class="content-wrapper">
    <!-- Content Header (Page header) -->
    <section class="content-header">
      <h1>
        Upload Training_session Details
        <small>Control panel</small>
      </h1>
      <ol class="breadcrumb">
        <li><a href="index.aspx"><i class="fa fa-dashboard"></i> Home</a></li>
        <li class="active">Dashboard</li>
      </ol>
    </section>

    <!-- Main content -->
      <section class="content">
           <div class="box box-default">
        <div class="box-header with-border">
          <h3 class="box-title"></h3>

          <div class="box-tools pull-right">
            <button type="button" class="btn btn-box-tool" data-widget="collapse"><i class="fa fa-minus"></i></button>
            <button type="button" class="btn btn-box-tool" data-widget="remove"><i class="fa fa-remove"></i></button>
          </div>
        </div>
        <!-- /.box-header -->
                 <form runat="server">
        <div class="box-body">
          <div class="row">
            
            <div class="col-md-6">
             
                <div class="form-group">
                <label>Training_Concept</label>
              <input type="text" class="form-control" id="tc" runat="server" placeholder="Enter ...">
              </div>
            </div>
              <!-- /.form-group -->
             <div class="col-md-6">
           <div class="form-group">
                <label>Training_Details</label>
              <input type="text" class="form-control" id="tdetails" runat="server" placeholder="Enter ...">
              </div>
            </div>
              <!-- /.form-group -->
              <div class="col-md-6">
                <div class="form-group">
                <label>Trainer_name</label>
              <input type="text" class="form-control" id="tname" runat="server" placeholder="Enter ...">
              </div>
             </div>

               <div class="col-md-6">
                <div class="form-group">
                <label>Training_Starts_from</label>
              <input type="text" class="form-control" id="Text1" runat="server" placeholder="Enter date...">
              </div>
             </div>

               <div class="col-md-6">
                <div class="form-group">
                <label>Contact_number</label>
                     <asp:TextBox ID="TextBox1" runat="server"></asp:TextBox>
              <%--<input type="text" class="form-control" id="phno" runat="server" placeholder="Enter contact number...">--%>
              </div>
                  
             </div>


                <div class="col-md-6">
                 <div class="form-group">
                <label>Upload file
                </label>
                  <asp:FileUpload ID="FileUpload1" runat="server" class="form-control"/>
             
              </div>
                 </div>

                 <div class="box-footer">
              
                <button type="submit" class="btn btn-info pull-right" onserverclick="Unnamed_ServerClick1" runat="server">Upload</button>
              </div>
            </div>

                <%-- <div class="col-md-6">
              <div class="form-group">
               <%-- <label>fertilizer Details</label>
              <input type="text" class="form-control" id="ferdet" runat="server" placeholder="Enter ...">--%>
              </div>
              <!-- /.form-group -->
          <%-- <div class="form-group">
                <label>Cost/acre</label>
              <input type="text" class="form-control" id="cost" runat="server" placeholder="Enter ...">
              </div>--%>
              <!-- /.form-group -->
            </div>



        

           
            <!-- /.col -->
                 <%-- <div class="col-md-12">
              <div class="form-group">
                <label>cultivation Details </label>
             <textarea class="form-control" rows="3" id="desc" runat="server" placeholder="Enter ..."></textarea>
              </div>--%>
              <!-- /.form-group -->
         
              <!-- /.form-group -->
            </div>
            <!-- /.col -->
          </div>
          <!-- /.row -->
        </div>
                 <%--<div class="box-footer">
              
                <button type="submit" class="btn btn-info pull-right" onserverclick="Unnamed_ServerClick1" runat="server">Upload</button>
              </div>--%>
               </form>
        <!-- /.box-body -->
    
      </div>
      <!-- /.row -->
    </section>
    <!-- /.content -->
  </div>
  <!-- /.content-wrapper -->
  <footer class="main-footer">
    <div class="pull-right hidden-xs">
      <b>Version</b> 2.4.0
    </div>
    <strong>Copyright &copy; 2022 <a target="_blank" href="">@admin2022</a>.</strong> All rights
    reserved.
  </footer>

  <!-- Control Sidebar -->

  <!-- /.control-sidebar -->
  <!-- Add the sidebar's background. This div must be placed
       immediately after the control sidebar -->
  <div class="control-sidebar-bg"></div>
</div>
<!-- ./wrapper -->

<!-- jQuery 3 -->
<script src="bower_components/jquery/dist/jquery.min.js"></script>
<!-- jQuery UI 1.11.4 -->
<script src="bower_components/jquery-ui/jquery-ui.min.js"></script>
<!-- Resolve conflict in jQuery UI tooltip with Bootstrap tooltip -->
<script>
  $.widget.bridge('uibutton', $.ui.button);
</script>
<!-- Bootstrap 3.3.7 -->
<script src="bower_components/bootstrap/dist/js/bootstrap.min.js"></script>
<!-- Morris.js charts -->
<script src="bower_components/raphael/raphael.min.js"></script>
<script src="bower_components/morris.js/morris.min.js"></script>
<!-- Sparkline -->
<script src="bower_components/jquery-sparkline/dist/jquery.sparkline.min.js"></script>
<!-- jvectormap -->
<script src="plugins/jvectormap/jquery-jvectormap-1.2.2.min.js"></script>
<script src="plugins/jvectormap/jquery-jvectormap-world-mill-en.js"></script>
<!-- jQuery Knob Chart -->
<script src="bower_components/jquery-knob/dist/jquery.knob.min.js"></script>
<!-- daterangepicker -->
<script src="bower_components/moment/min/moment.min.js"></script>
<script src="bower_components/bootstrap-daterangepicker/daterangepicker.js"></script>
<!-- datepicker -->
<script src="bower_components/bootstrap-datepicker/dist/js/bootstrap-datepicker.min.js"></script>
<!-- Bootstrap WYSIHTML5 -->
<script src="plugins/bootstrap-wysihtml5/bootstrap3-wysihtml5.all.min.js"></script>
<!-- Slimscroll -->
<script src="bower_components/jquery-slimscroll/jquery.slimscroll.min.js"></script>
<!-- FastClick -->
<script src="bower_components/fastclick/lib/fastclick.js"></script>
<!-- AdminLTE App -->
<script src="dist/js/adminlte.min.js"></script>
<!-- AdminLTE dashboard demo (This is only for demo purposes) -->
<script src="dist/js/pages/dashboard.js"></script>
<!-- AdminLTE for demo purposes -->
<script src="dist/js/demo.js"></script>
</body>
</html>
