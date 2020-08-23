<%@ Page Title="" Language="C#" MasterPageFile="~/HomeMaster.master" AutoEventWireup="true" CodeFile="JobDescription.aspx.cs" Inherits="JobDescription" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="inner_page_agile">
        <h3>Internships Description</h3>
    </div>
    <div class="services-breadcrumb_w3layouts">
        <div class="inner_breadcrumb">

            <ul class="short_w3ls">
                <li><a href="Default.aspx">Home</a><span>|</span></li>
                <li>Jobs/Internships</li>
            </ul>
        </div>
    </div>
    <div class="inner_content_info_agileits">
        <div class="container">
            <div class="tittle_head_w3ls">
                <h3 class="tittle">Internships </h3>
            </div>
            <div class="inner_sec_grids_info_w3ls">
                <div class="col-md-8 job_info_left">
                    <div class="but_list">
                        <div class="bs-example bs-example-tabs" role="tabpanel" data-example-id="togglable-tabs">
                            <ul id="myTab" class="nav nav-tabs" role="tablist">
                                <li role="presentation" class="active"><a href="#home" id="home-tab" role="tab" data-toggle="tab" aria-controls="home" aria-expanded="true">
                                    <asp:Literal ID="Literal1" runat="server"></asp:Literal>
                                </a></li>
                            </ul>
                            <div id="myTabContent" class="tab-content">
                                <div role="tabpanel" class="tab-pane fade in active" id="home" aria-labelledby="home-tab">
                                    <div class="tab_grid">
                                        <div class="col-lg-12">
                                            <div class="location_box1">
                                                <h6><i class="fa fa-building"></i><b>&nbsp;Company Name: </b>
                                                    <asp:Literal ID="Literal2" runat="server"></asp:Literal></h6>
                                                <p>
                                                    <i class="fa fa-briefcase"></i>&nbsp;<b>Post Name:</b> &nbsp;
                                                    <asp:Literal ID="Literal3" runat="server"></asp:Literal>

                                                </p>
                                                <p>
                                                    <i class="fa fa-calendar"></i>&nbsp;
                                                        <b>Start Date:</b> &nbsp;  
                                                        <asp:Literal ID="Literal4" runat="server"></asp:Literal>
                                                </p>
                                                <p>
                                                    <i class="fa fa-money"></i>&nbsp;<b>Stipend:</b> ₹  
                                                    <asp:Literal ID="Literal5" runat="server"></asp:Literal>&nbsp;&nbsp;
                                                </p>
                                                <p>
                                                    <b><i class="fa fa-clock-o"></i>&nbsp;Duration:</b> &nbsp;  
                                                        <asp:Literal ID="Literal6" runat="server"></asp:Literal>
                                                </p>

                                                <p>
                                                    <i class="fa fa-list"></i>&nbsp;<b>Description:</b>   &nbsp;
                                                        <asp:Literal ID="Literal7" runat="server"></asp:Literal>
                                                </p>
                                                <p>
                                                    <span class="m_2"><i class="fa fa-envelope"></i>&nbsp;<b>Company Email:</b>   &nbsp;
                                                        <asp:Literal ID="Literal8" runat="server"></asp:Literal></span>
                                                </p>
                                                <p>
                                                    <span class="m_2"><i class="fa fa-clock-o"></i>&nbsp;<b>Last Date to Apply:</b>   &nbsp;
                                                       <span class="text-danger">
                                                           <asp:Literal ID="Literal9" runat="server"></asp:Literal></span></span>
                                                </p>
                                                <ul class="links_bottom">
                                                    <li class="last"><a href="ApplyForIntern.aspx"><span class="icon_text">Apply Now <i class="fa fa-caret-right icon_1"></i></span></a></li>
                                                </ul>
                                            </div>
                                        </div>
                                        <div class="clearfix"></div>
                                    </div>
                                    <hr />
                                </div>

                            </div>
                        </div>
                    </div>
                </div>
                <div class="col-md-4 job_info_right">
                    <div class="col_3 permit">
                        <h3>Company Profile</h3>
                        <ul class="list-group">
                            <li class="list-group-item">
                                <b>Name :</b>
                                <asp:Literal ID="Literal10" runat="server"></asp:Literal>
                            </li>

                            <li class="list-group-item">
                                <b>No of Employee :</b>
                                <asp:Literal ID="Literal12" runat="server"></asp:Literal>
                            </li>
                            <li class="list-group-item">
                                <b>Contact :</b>
                                <asp:Literal ID="Literal13" runat="server"></asp:Literal>
                            </li>
                            <li class="list-group-item">
                                <b>Email :</b>
                                <asp:Literal ID="Literal14" runat="server"></asp:Literal>
                            </li>
                            <li class="list-group-item">
                                <b>Website :</b>
                                <asp:Literal ID="Literal15" runat="server"></asp:Literal>
                            </li>
                            <li class="list-group-item">
                                <b><i class="fa fa-map-marker"></i>:</b>
                                <asp:Literal ID="Literal11" runat="server"></asp:Literal>
                            </li>
                        </ul>
                    </div>
                </div>
            </div>
        </div>
        <div class="testimonials_section">
            <div class="container">
                <div class="tittle_head_w3ls">
                    <h3 class="tittle">Employee Reviews</h3>
                </div>
                <div class="inner_sec_grids_info_w3ls">
                    <div id="Carousel" class="carousel slide two">
                        <div class="carousel-inner">
                            <asp:Repeater ID="Repeater1" runat="server">
                                <ItemTemplate>
                                    <div class="item active">
                                        <div class="testimonials_grid_wthree">
                                            <img src='<%# Eval("EmpPic") %>' alt=" " style="height:80px;width:80px" class="img-responsive" />
                                            <h5><%# Eval("EmpployeeName") %></h5>
                                            <h6><%# Eval("JobProfile") %></h6>
                                            <a href="<%# Eval("Linkedlink") %>" target="_blank">
                                                <img src="images/LinkedIn.png" class="img-responsive" style="height: 40px; width: 40px" /></a>
                                            <h4><i class="fa fa-quote-left" aria-hidden="true"></i>
                                                <%# Eval("Review") %>
                                            </h4>
                                        </div>
                                    </div>
                                    <hr />
                                </ItemTemplate>
                            </asp:Repeater>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</asp:Content>


