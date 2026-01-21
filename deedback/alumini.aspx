<%@ Page Language="C#" AutoEventWireup="true" CodeBehind="alumini.aspx.cs" Inherits="deedback.alumini" %>

<!DOCTYPE html>

<html xmlns="http://www.w3.org/1999/xhtml">
<head runat="server">
    <!-- META ============================================= -->
    <meta charset="utf-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="keywords" content="" />
    <meta name="author" content="" />
    <meta name="robots" content="" />

    <!-- DESCRIPTION -->
    <meta name="description" content="VTU Mysore" />

    <!-- OG -->
    <meta property="og:title" content="VTU Mysore" />
    <meta property="og:description" content="VTU Mysore" />
    <meta property="og:image" content="" />
    <meta name="format-detection" content="telephone=no">

    <!-- FAVICONS ICON ============================================= -->
    <link rel="icon" href="assets/images/favicon.ico" type="image/x-icon" />
    <link rel="shortcut icon" type="image/x-icon" href="assets/images/favicon.png" />

    <!-- PAGE TITLE HERE ============================================= -->
    <title>VTU Mysore </title>

    <!-- MOBILE SPECIFIC ============================================= -->
    <meta name="viewport" content="width=device-width, initial-scale=1">

    <!--[if lt IE 9]>
    <script src="assets/js/html5shiv.min.js"></script>
    <script src="assets/js/respond.min.js"></script>
    <![endif]-->
    <!-- All PLUGINS CSS ============================================= -->
    <link rel="stylesheet" type="text/css" href="assets/css/assets.css">

    <!-- TYPOGRAPHY ============================================= -->
    <link rel="stylesheet" type="text/css" href="assets/css/typography.css">

    <!-- SHORTCODES ============================================= -->
    <link rel="stylesheet" type="text/css" href="assets/css/shortcodes/shortcodes.css">

    <!-- STYLESHEETS ============================================= -->
    <link rel="stylesheet" type="text/css" href="assets/css/style.css">
    <link class="skin" rel="stylesheet" type="text/css" href="assets/css/color/color-1.css">

</head>
<body id="bg">
    <div class="page-wraper">
        <div id="loading-icon-bx"></div>
        <div class="account-form">
            <div class="account-head" style="background-image:url(assets/images/background/bg2.jpg);">
                <a href="index.aspx"><img src="assets/images/logo-white-2.png" alt=""></a>
            </div>
            <div class="account-form-inner">
                <div class="account-container">
                    <div class="heading-bx left">
                        <h2 class="title-head">Sign Up <span>Now</span></h2>
                        <p>Login Your Account <a href="login.aspx">Click here</a></p>
                    </div>
                  <form class="contact-bx" runat="server">
  <div class="row placeani">
    <!-- Name -->
    <div class="col-lg-12">
      <div class="form-group">
        <div class="input-group">
          <label>Your Name</label>
          <input name="dzName" type="text" id="uname" runat="server" class="form-control" 
                 required pattern="^[A-Za-z\s]{3,}$" 
                 title="Enter at least 3 letters. Only alphabets and spaces allowed.">
        </div>
      </div>
    </div>

    <!-- Email -->
    <div class="col-lg-12">
      <div class="form-group">
        <div class="input-group">
          <label>Your Email Address</label>
          <input name="dzName" type="email" id="email" runat="server" class="form-control" 
                 required pattern="^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[A-Za-z]{2,}$"
                 title="Enter a valid email address.">
        </div>
      </div>
    </div>

    <!-- Company -->
    <div class="col-lg-12">
      <div class="form-group">
        <div class="input-group">
          <label>Company</label>
          <input name="dzName" type="text" id="industray" runat="server" class="form-control" 
                 required pattern="^[A-Za-z\s]{2,}$" 
                 title="Enter a valid company name (letters and spaces only).">
        </div>
      </div>
    </div>

    <!-- Branch -->
    <div class="col-lg-12">
      <div class="form-group">
        <div class="input-group">
          <label>Branch</label>
          <input name="dzName" type="text" id="branch" runat="server" class="form-control" 
                 required pattern="^[A-Za-z\s]{2,}$"
                 title="Branch name should only contain letters and spaces.">
        </div>
      </div>
    </div>

    <!-- Passed out year -->
    <div class="col-lg-12">
      <div class="form-group">
        <div class="input-group">
          <label>Passed out year</label>
          <input name="dzName" type="text" id="pot" runat="server" class="form-control" 
                 required pattern="^(19|20)\d{2}$" 
                 title="Enter a valid year like 2022.">
        </div>
      </div>
    </div>

    <!-- Phone Number -->
    <div class="col-lg-12">
      <div class="form-group">
        <div class="input-group">
          <label>Ph.no</label>
          <input name="dzName" type="text" id="phn" runat="server" class="form-control" 
                 required pattern="^[6-9]\d{9}$" 
                 title="Enter a 10-digit phone number starting with 6, 7, 8, or 9.">
        </div>
      </div>
    </div>

    <!-- Address -->
    <div class="col-lg-12">
      <div class="form-group">
        <div class="input-group">
          <label>Addresses</label>
          <input name="dzName" type="text" id="ads" runat="server" class="form-control" 
                 required pattern=".{5,}" 
                 title="Address must be at least 5 characters long.">
        </div>
      </div>
    </div>

    <!-- Password -->
    <div class="col-lg-12">
      <div class="form-group">
        <div class="input-group">
          <label>Your Password</label>
          <input name="dzEmail" type="password" id="pswd" runat="server" class="form-control" 
                 required pattern="^(?=.*[0-9]).{6,}$" 
                 title="Password must be at least 6 characters long and include at least one number.">
        </div>
      </div>
    </div>

    <!-- Submit -->
    <div class="col-lg-12 m-b30">
      <button name="submit" type="submit" value="Submit" runat="server" 
              class="btn button-md" onserverclick="Unnamed_ServerClick">Sign Up</button>
    </div>
  </div>
</form>

                </div>
            </div>
        </div>
    </div>
    <!-- External JavaScripts -->
    <script src="assets/js/jquery.min.js"></script>
    <script src="assets/vendors/bootstrap/js/popper.min.js"></script>
    <script src="assets/vendors/bootstrap/js/bootstrap.min.js"></script>
    <script src="assets/vendors/bootstrap-select/bootstrap-select.min.js"></script>
    <script src="assets/vendors/bootstrap-touchspin/jquery.bootstrap-touchspin.js"></script>
    <script src="assets/vendors/magnific-popup/magnific-popup.js"></script>
    <script src="assets/vendors/counter/waypoints-min.js"></script>
    <script src="assets/vendors/counter/counterup.min.js"></script>
    <script src="assets/vendors/imagesloaded/imagesloaded.js"></script>
    <script src="assets/vendors/masonry/masonry.js"></script>
    <script src="assets/vendors/masonry/filter.js"></script>
    <script src="assets/vendors/owl-carousel/owl.carousel.js"></script>
    <script src="assets/js/functions.js"></script>
    <script src="assets/js/contact.js"></script>
    <script src='assets/vendors/switcher/switcher.js'></script>
</body>

</html>
<!DOCTYPE html>

<html lang="en" xmlns="http://www.w3.org/1999/xhtml">
<head>
    <meta charset="utf-8" />
    <title></title>
</head>
<body>

</body>
</html>