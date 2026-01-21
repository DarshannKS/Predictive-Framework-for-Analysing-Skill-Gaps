<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="viewdrive.aspx.cs" Inherits="deedback.Current.viewdrive" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
     <meta charset="utf-8">
  <meta http-equiv="X-UA-Compatible" content="IE=edge">
  <title>Admin | Data Tables</title>
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
</head>
<body class="hold-transition skin-blue sidebar-mini">
<div class="wrapper">

  <header class="main-header">
    <!-- Logo -->
    <a href="index2.html" class="logo">
      <!-- mini logo for sidebar mini 50x50 pixels -->
      <span class="logo-mini"><b>A</b>LT</span>
      <!-- logo for regular state and mobile devices -->
      <span class="logo-lg"><b>EduChamp</b></span>
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
                 
                  <small>Member since Nov. 2022</small>
                </p>
              </li>
              <!-- Menu Body -->
          
              <!-- Menu Footer-->
              <li class="user-footer">
              
                <div class="pull-right">
                  <a href="#" class="btn btn-default btn-flat">Sign out</a>
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
                    <li class="active"><a href="default.aspx"><i class="fa fa-dashboard"></i><span>Dashboard</span></a></li>
                    <li class="active treeview"></li>




                    <li class="header">User Option</li>

                    <li class="treeview">
                        <a href="#">
                            <i class="fa fa-files-o"></i>
                            <span>View Drive</span>
                            <span class="pull-right-container">
                                <span class="label label-primary pull-right">2</span>
                            </span>
                        </a>
                        <ul class="treeview-menu">
                            <li><a href="viewdrive.aspx"><i class="fa fa-circle-o"></i>View Drive Details</a></li>



                        </ul>
                    </li>


                    <li class="treeview">
                        <a href="#">
                            <i class="fa fa-files-o"></i>
                            <span>Marks</span>
                            <span class="pull-right-container">
                                <span class="label label-primary pull-right">2</span>
                            </span>
                        </a>
                        <ul class="treeview-menu">
                            <li><a href="viewMarks.aspx"><i class="fa fa-circle-o"></i>View Marks</a></li>

                             <li><a href="addMarks.aspx"><i class="fa fa-circle-o"></i> Add Marks</a></li>

                        </ul>
                    </li>

                     <li><a href="Prediction.aspx"><i class="fa fa-circle-o text-yellow"></i> <span>Prediction</span></a></li>

                    <%--     <li><a href="#"><i class="fa fa-circle-o text-yellow"></i> <span>Warning</span></a></li>--%>
                    <li><a href="../logout.aspx"><i class="fa fa-sign-out text-aqua"></i><span>Logout</span></a></li>
                </ul>
            </section>
            <!-- /.sidebar -->
        </aside>


  <!-- Content Wrapper. Contains page content -->
  <div class="content-wrapper">
    <!-- Content Header (Page header) -->
    <section class="content-header">
      <h1>
        Job Tables
        <small>advanced tables</small>

      </h1>

      <ol class="breadcrumb">
        <li><a href="#"><i class="fa fa-dashboard"></i> Home</a></li>
        <li><a href="#">Tables</a></li>
        <li class="active">Job tables</li>
      </ol>

    </section>

    <!-- Main content -->
      <form id="form1" runat="server">  
    <section class="content">
      <div class="row">
        <div class="col-xs-12">
        
          <!-- /.box -->

          <div class="box">
              <h3 class="box-title">Job Data</h3>
            <div class="box-header">
              
                   <div class="col-xs-3">
    <%--  <a href="UploadJob.aspx" class="btn btn-block btn-success">Upload Job</a>--%>
                       </div>
            </div>
            <!-- /.box-header -->
            <div class="box-body">
              <table id="example1" class="table table-bordered table-striped">
                <thead>
                <tr>
                  <th>Company Name</th>
               <%--   <th>Email</th>--%>
                  <th>Mobile</th>
                  <th>Job Title</th>
                  <th>CreatedOn</th>
                  <th>Drive_In Date</th>
                  <th>Skills</th>
                  <th>No.Post</th>
                     <th>Location</th>
                  <th>Details</th>
                <%--  <th>Status</th>
                  <th>Action</th>--%>
                 
              
                </tr>
                </thead>
                <tbody>
                    <asp:Repeater ID="RepeatInformation" runat="server">  
                         <ItemTemplate>  
                <tr>
                  <td><%# Eval("Cname") %></td>
                 <%-- <td><%# Eval("Cemail") %></td>--%>
                  <td><%# Eval("Mobile") %></td>
                  <td><%# Eval("JobTitle") %></td>
                  <td><%# Eval("CreatedOn") %></td>
                  <td><%# Eval("clsDate") %></td>
                  <td><%# Eval("Skills") %></td>
                  <td><%# Eval("Cavil") %></td>
                  <td><%# Eval("loc") %></td>
                  <td><%# Eval("desc") %></td>
               <%--   <td><%# Eval("Status") %></td>--%>
              
                  <%--<td><button type="button" id="DeleteClaim" class="btn btn-block btn-danger btn-xs" onclick="ClaimDelete(<%# Eval("id") %>)"><i class="fas fa-trash"></i>Delete</button></td>
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
    <strong>Copyright &copy; 2021-2022 <a target="_blank" href="">EduChamp</a>.</strong> All rights
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
     <script type="text/javascript" src="http://ajax.googleapis.com/ajax/libs/jquery/1.4.2/jquery.min.js"></script>


    

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
                           url: "ManageJob.aspx/deleteClaim",
                           success: function (data) {
                               if (data.d == 1) {
                                   toastr.success("Deleted Successfully.");
                                   window.location.href = "ManageJob.aspx";
                               } else {
                                   toastr.error("Error in deleting record.");
                                   window.location.href = "ManageJob.aspx";
                               }

                           }
                     
                   });
               }
    </script>
</body>
</html>

