<%@ Page Title="" Language="C#" MasterPageFile="~/业主/SiteYezhu.Master" AutoEventWireup="true" CodeBehind="ShouYeYeZHu.aspx.cs" Inherits="WebApplication1.首页.ShouYeYeZHu" %>

<asp:Content ID="Content1" ContentPlaceHolderID="head" runat="server">
    <style type="text/css">
        /*#BOX {
            background-color:red;
        }
        section {
             background-color:green;
        }
        .container {
            background-color:blue;
        }*/
        .aaaa {
            width:100%;
            height:400px;
            background-color:red;
        }
    </style>
    <!-- Bootstrap Grid -->
<link rel="stylesheet" href="../static/css/bootstrap-grid.min.css">

<!-- General Style -->
<link rel="stylesheet" href="../static/css/general.css">

<!-- Elegant Font Icon -->
<link rel="stylesheet" href="../static/css/elegant-font.css">

<!-- ContentBox Style -->
<link rel="stylesheet" href="../static/css/contentbox.css">

<!-- Google Font -->
<link href="../static/css/css2.css" rel="stylesheet">
</asp:Content>
<asp:Content ID="Content2" ContentPlaceHolderID="header" runat="server">
</asp:Content>
<asp:Content ID="Content3" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    <div id="BOX">
        <!-- START Content Box 1 -->
	<section>
		 <div>
            <!-- START Content Box 6 -->
            <section class="bg-white">
		<div class="container">
			<div class="row">
				<div class="col-md-12">
					<!-- Start Content Box -->
					<div class="content-box-6">
						<div class="content-box-6-bg-blur"></div>
						<div class="content-box-6-bg"></div>
						<div class="content-box-6-content-wrapper">
							<h3 class="content-box-6-title">欢迎使用紫荆物业管理系统</h3>
							<div class="content-box-6-content">Welcome to Bauhinia property management system</div>
							<a class="content-box-6-button" href="#">了解详情</a>
						</div>
					</div>
					<!-- End Content Box -->
				</div>
			</div>
		</div>
	</section>
            <!-- END Content Box 6 -->
           	<!-- START Content Box 24 -->
	<section class="bg-white">
		<div class="container">
			<h2 class="section-title"><span>介绍</span></h2>
			<div class="row">
				<div class="col-md-6">
					<!-- Start Content Box -->
					<div class="content-box-24">
						<div class="content-box-24-icon">
							<i class="icon_adjust-horiz"></i>
						</div>
						<div class="content-box-24-content-wrapper">
							<h3 class="content-box-24-title">系统背景</h3>
							<div class="content-box-24-content">以降本提效和高品质物业服务的管理模式为核心，为物业企业提供更智慧的智慧物管</div>
						</div>
						<a class="content-box-24-button" href="#"></a>
					</div>
					<!-- End Content Box -->
				</div>
				<div class="col-md-6">
					<!-- Start Content Box -->
					<div class="content-box-24 color-2">
						<div class="content-box-24-icon">
							<i class="icon_link_alt"></i>
						</div>
						<div class="content-box-24-content-wrapper">
							<h3 class="content-box-24-title">服务理念</h3>
							<div class="content-box-24-content">提高人居生活品质，建设和谐风尚社区，法诚信管理，竭诚高效服务。</div>
						</div>
						<a class="content-box-24-button" href="#">View Details</a>
					</div>
					<!-- End Content Box -->
				</div>
			</div>
		</div>
	</section>
	<!-- END Content Box 24 -->


        </div>
	</section>
	<!-- END Content Box 1 -->
    
    </div>
</asp:Content>
