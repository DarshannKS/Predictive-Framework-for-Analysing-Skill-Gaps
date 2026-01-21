<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="TView.aspx.cs" Inherits="deedback.Faculty.TView" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <meta charset="utf-8">
  <meta http-equiv="X-UA-Compatible" content="IE=edge">
  <title>Admin|Training_session Data Tables</title>
  <!-- Tell the browser to be responsive to screen width -->
  <meta content="width=device-width, initial-scale=1, maximum-scale=1, user-scalable=no" name="viewport">
  <!-- Bootstrap 3.3.7 -->
  <link rel="stylesheet" href=" bower_components/bootstrap/dist/css/bootstrap.min.css">
  <!-- Font Awesome -->
  <link rel="stylesheet" href=" bower_components/font-awesome/css/font-awesome.min.css">
  <!-- Ionicons -->
  <link rel="stylesheet" href=" bower_components/Ionicons/css/ionicons.min.css">
  <!-- DataTables -->
  <link rel="stylesheet" href=" bower_components/datatables.net-bs/css/dataTables.bootstrap.min.css">
  <!-- Theme style -->
  <link rel="stylesheet" href=" dist/css/AdminLTE.min.css">
  <!-- AdminLTE Skins. Choose a skin from the css/skins
       folder instead of downloading all of them to reduce the load. -->
  <link rel="stylesheet" href=" dist/css/skins/_all-skins.min.css">

  <!-- HTML5 Shim and Respond.js IE8 support of HTML5 elements and media queries -->
  <!-- WARNING: Respond.js doesn't work if you view the page via file:// -->
  <!--[if lt IE 9]>
  <script src="https://oss.maxcdn.com/html5shiv/3.7.3/html5shiv.min.js"></script>
  <script src="https://oss.maxcdn.com/respond/1.4.2/respond.min.js"></script>
  <![endif]-->

  <!-- Google Font -->
  <link rel="stylesheet"
        href="https://fonts.googleapis.com/css?family=Source+Sans+Pro:300,400,600,700,300italic,400italic,600italic">
     <link rel="stylesheet" href="https://cdnjs.cloudflare.com/ajax/libs/toastr.js/latest/toastr.min.css" integrity="sha512-vKMx8UnXk60zUwyUnUPM3HbQo8QfmNx7+ltw8Pm5zLusl1XIfwcxo8DbWCqMGKaWeNxWA8yrx5v3SaVpMvR3CA==" crossorigin="anonymous" />

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
            <li><a href="Alumini.aspx"><i class="fa fa-circle-o"></i> Alumini</a></li>
            <li><a href="Faculty.aspx"><i class="fa fa-circle-o"></i> Faculty</a></li>
            <li><a href="Current.aspx"><i class="fa fa-circle-o"></i> Current Students</a></li>
             <li><a href="ManageJob.aspx"><i class="fa fa-circle-o"></i> Manage Job_Drive</a></li>
         
          </ul>
        </li>
     
       <%--<li><a href="courses.aspx"><i class="fa fa-circle-o text-yellow"></i> <span>Courses</span></a></li>--%>
          <li><a href="funds_view.aspx"><i class="fa fa-circle-o text-yellow"></i> <span>Funds</span></a></li>
        <li><a href="view_courses.aspx"><i class="fa fa-circle-o text-yellow"></i> <span>View Courses</span></a></li>
       <li><a href="view_training.aspx"><i class="fa fa-circle-o text-yellow"></i> <span>Training Session</span></a></li>
       <li><a href="view_alumuni_meet.aspx"><i class="fa fa-circle-o text-yellow"></i> <span>Alumini meet</span></a></li>
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
        
        <small></small>
        <small></small>

      </h1>

      <ol class="breadcrumb">
        <li><a href="index.aspx"><i class="fa fa-dashboard"></i> Home</a></li>
        <li><a href="#">Tables</a></li>
        <li class="active">training_session_table</li>
      </ol>

    </section>

    <!-- Main content -->
      <form id="form1" runat="server">  
    <section class="content">
      <div class="row">
        <div class="col-xs-12">
        
          <!-- /.box -->

          <div class="box">
              <h3 class="box-title">Training_session</h3>
            <div class="box-header">
              
                   <div class="col-xs-3">
       <%--   <a href="training_session.aspx" class="btn btn-block btn-success">Add Training_session</a>--%>
                       </div>
            </div>
            <!-- /.box-header -->
            <div class="box-body">
              <table id="example1" class="table table-bordered table-striped">
                <thead>
                <tr>
                  <th>Training_Concept</th>
                     <th>Training_Details</th>
                  <th>Trainer_name</th>
                  <th> Training_Starts_from  </th>
                  <th> Contact_number  </th>
      
                 
             <%--     <th>Action</th>--%>
                 
              
                </tr>
                </thead>
                <tbody>
                    <asp:Repeater ID="RepeatInformation" runat="server">  
                         <ItemTemplate>  
                <tr>
                  <td><%# Eval("Training_Concept") %></td>
                 <td><%# Eval("Training_Details") %></td>
                  <td><%# Eval("Trainer_name") %></td>
                  <td><%# Eval("Training_Starts_from") %></td>
                  <td><%# Eval("Contact_number") %></td>
                  <%--<td><%# Eval("CropDetails") %></td>--%>
                 
              
                 <%-- <td><button type="button" id="DeleteClaim" class="btn btn-block btn-danger btn-xs" onclick="ClaimDelete(<%# Eval("id") %>)"><i class="fas fa-trash"></i>End_Training_session</button></td>
       --%>         </tr>
               
                </ItemTemplate>  
                        </asp:Repeater>
                </tbody>
           
              </table>
            </div>
            <!-- /.box-body -->
          </div>
          <!-- /.box -->
        </div>
        <!-- /.col -->
      </div>
      <!-- /.row -->
    </section>
          </form>
    <!-- /.content -->
  </div>
  <!-- /.content-wrapper -->
  <footer class="main-footer">
    <div class="pull-right hidden-xs">
      <b>Version</b> 2.4.0
    </div>
    <strong>Copyright &copy; 2021-2022 <a target="_blank" href="">admin@2022</a>.</strong> All rights
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
<script src=" bower_components/jquery/dist/jquery.min.js"></script>
<!-- Bootstrap 3.3.7 -->
<script src=" bower_components/bootstrap/dist/js/bootstrap.min.js"></script>
<!-- DataTables -->
<script src=" bower_components/datatables.net/js/jquery.dataTables.min.js"></script>
<script src=" bower_components/datatables.net-bs/js/dataTables.bootstrap.min.js"></script>
<!-- SlimScroll -->
<script src=" bower_components/jquery-slimscroll/jquery.slimscroll.min.js"></script>
<!-- FastClick -->
<script src=" bower_components/fastclick/lib/fastclick.js"></script>
<!-- AdminLTE App -->
<script src=" dist/js/adminlte.min.js"></script>
<!-- AdminLTE for demo purposes -->
<script src=" dist/js/demo.js"></script>


         <script type="text/javascript" src="https://cdnjs.cloudflare.com/ajax/libs/toastr.js/latest/js/toastr.min.js"></script>
    <script src="https://cdn.yz.events/js/jquery.rwdImageMaps.js"></script>
    <script src="https://cdn.yz.events/js/custom.js"></script>
    

<%--    <script src="https://unpkg.com/sweetalert/dist/sweetalert.min.js"></script>--%>
<!-- page script -->
<script>
    $(function () {
        $('#example1').DataTable()
        $('#example2').DataTable({
            'paging': true,
            'lengthChange': false,
            'searching': false,
            'ordering': true,
            'info': true,
            'autoWidth': false
        })
    })
</script>

    <script>
    
               function ClaimDelete(id) {
                   
                       //alert(id);
                       $.ajax({
                           type: 'POST',
                           contentType: "application/json; charset=utf-8",
                           dataType: "json",
                           data: JSON.stringify({ ID: id }),
                           url: "view_training.aspx/deleteClaim",
                           success: function (data) {
                               if (data.d == 1) {

                                   alert("Training sesiion deleted");
                                   //toastr.success("Image Requested.");
                                   window.location.reload();

                               } else {
                                   toastr.error("Error in deleting record.");
                               }

                           }
                     
                   });
               }
    </script>
</body>
</html>
