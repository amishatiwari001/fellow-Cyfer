<%@ Page Title="" Language="C#" MasterPageFile="~/HomeMaster.master" AutoEventWireup="true" CodeFile="Default.aspx.cs" Inherits="_Default" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">

    <div id="myCarousel" class="carousel slide" data-ride="carousel">
        <ol class="carousel-indicators">
            <li data-target="#myCarousel" data-slide-to="0" class="active"></li>
            <li data-target="#myCarousel" data-slide-to="1" class=""></li>
            <li data-target="#myCarousel" data-slide-to="2" class=""></li>
            <li data-target="#myCarousel" data-slide-to="3" class=""></li>
        </ol>
        <div class="carousel-inner" role="listbox">
            <div class="item active">
                <div class="container">
                    <div class="carousel-caption">
                        <h3>Improving workplace <span>Productivity.-</span></h3>
                        <p>Hire. Train. Retain.</p>
                        <div class="agileits-button top_ban_agile">
                            <a class="btn btn-primary btn-lg" href="ReadMore.aspx">Read More »</a>
                        </div>
                    </div>
                </div>
            </div>
            <div class="item item2">
                <div class="container">
                    <div class="carousel-caption">
                        <h3>Inspiring leadership <span>innovation.</span></h3>
                        <p>Hire. Train. Retain.</p>
                        <div class="agileits-button top_ban_agile">
                            <a class="btn btn-primary btn-lg" href="ReadMore.aspx">Read More »</a>
                        </div>
                    </div>
                </div>
            </div>
            <div class="item item3">
                <div class="container">
                    <div class="carousel-caption">
                        <h3>Improving workplace <span>Productivity.</span></h3>
                        <p>Hire. Train. Retain.</p>
                        <div class="agileits-button top_ban_agile">
                            <a class="btn btn-primary btn-lg" href="ReadMore.aspx">Read More »</a>
                        </div>
                    </div>
                </div>
            </div>
            <div class="item item4">
                <div class="container">
                    <div class="carousel-caption">

                        <h3>Inspiring leadership <span>innovation.</span></h3>
                        <p>Hire. Train. Retain.</p>
                        <div class="agileits-button top_ban_agile">
                            <a class="btn btn-primary btn-lg scroll" href="#welcome" role="button">Read More »</a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <div id="search_form" class="search_top">
        <h2>Start your job search</h2>
        <form runat="server">
            <div class="row">
                <div class="col-lg-4">
                    <asp:TextBox ID="TextBox2" runat="server" placeholder="Location" Width="100%"></asp:TextBox>
                </div>
                <div class="col-lg-4">
                    <asp:DropDownList ID="DropDownList1" runat="server" CssClass="frm-field" Width="100%">
                    </asp:DropDownList>
                </div>
                <div class="col-lg-4">
                    <asp:Button ID="Button1" runat="server" Text="Find Companies" Width="100%" OnClick="Button1_Click" />
                </div>

            </div>


            <div class="clearfix"></div>
        </form>
    </div>
    <div class="banner-bottom">
        <div class="container">
            <div class="tittle_head_w3ls">
                <h3 class="tittle">About Us</h3>
            </div>
            <div class="inner_sec_grids_info_w3ls">
                <div class="col-md-6 banner_bottom_left">
                    <h4>Employment opportunities for <span>Professionals</span></h4>
                    <p>Established in 1990, as a family business, Intership has been at the heart of the Offshore Accommodation Market in the Arabian Gulf, Gulf of Mexico, South East Asia and West Africa for the last 25 years.</p>
                    <p>
                        The company has offices in Singapore and West Africa, key personnel in Europe, running a fleet of 4 vessels utilizing a crew of 200 persons.

Senior Management have over 4 decades of operational experience in the marine and offshore sectors. The company has positioned itself as a provider of high quality, cost efficient customized accommodation solution.
                    </p>
                    <ul class="some_agile_facts">
                        <li><span class="fa fa-briefcase" aria-hidden="true"></span>
                            <label>80</label>
                            Corporate Programs</li>
                        <li><span class="fa fa-graduation-cap" aria-hidden="true"></span>
                            <label>49</label>
                            Training Courses</li>
                        <li><span class="fa fa-user" aria-hidden="true"></span>
                            <label>88</label>
                            Strategic Partners</li>
                        <li><span class="fa fa-line-chart" aria-hidden="true"></span>
                            <label>436</label>
                            Companies We Helped</li>
                    </ul>
                    <div class="clearfix"></div>
                </div>
                <div class="col-md-6 banner_bottom_right">
                    <div class="agileits_w3layouts_banner_bottom_grid">
                        <img src="images/ab.png" alt=" " class="img-responsive" />
                    </div>
                </div>
                <div class="clearfix"></div>
            </div>

        </div>
    </div>
    <div class="team_work_agile">
        <h4>Whether we play a large or small role, by working together we achieve our objectives.</h4>
    </div>
    <div class="services" id="services">
        <div class="container">
            <div class="tittle_head_w3ls">
                <h3 class="tittle">Selection Process</h3>
            </div>
            <div class="inner_sec_grids_info_w3ls">
                <div class="col-md-3 services-left">
                    <div class="services-left-top">

                        <h5>Identify Need & Develop Position Description</h5>

                    </div>
                    <div class="services-left-top services-left-top1">

                        <h5>Recruitment Planning</h5>

                    </div>
                </div>
                <div class="col-md-6 services-middle">
                    <div class="services-middle-img">
                        <img src="images/process.jpg" alt="" />
                    </div>
                    <div class="services-middle-grids">
                        <div class="col-md-6 services-middle-left">
                            <div class="services-left-top">

                                <h5>Sourcing & Advertising</h5>

                            </div>
                        </div>
                        <div class="col-md-6 services-middle-left">
                            <div class="services-left-top">

                                <h5>Assess & Interview Candidates</h5>

                            </div>
                        </div>
                        <div class="clearfix"></div>
                    </div>
                </div>
                <div class="col-md-3 services-left">
                    <div class="services-left-top">

                        <h5>Offer for Student Employment</h5>

                    </div>
                    <div class="services-left-top services-left-top1">

                        <h5>Onboarding for Success</h5>

                    </div>
                </div>
                <div class="clearfix"></div>
            </div>
        </div>
    </div>
    <div class="mid_services">

        <div class="col-md-6 according_inner_grids">
            <h3 class="agile_heading two">Receiving a Job offer</h3>
            <div class="according_info">
                <div class="panel-group about_panel" id="accordion" role="tablist" aria-multiselectable="true">
                    <div class="panel panel-default">
                        <div class="panel-heading" role="tab" id="headingOne">
                            <h4 class="panel-title asd">
                                <a class="pa_italic" role="button" data-toggle="collapse" data-parent="#accordion" href="#collapseOne" aria-expanded="true"
                                    aria-controls="collapseOne">
                                    <span class="glyphicon glyphicon-plus" aria-hidden="true"></span><i class="glyphicon glyphicon-minus" aria-hidden="true"></i>Get it in Written job offer.
                                </a>
                                </a>
                            </h4>
                        </div>
                        <div id="collapseOne" class="panel-collapse collapse in" role="tabpanel" aria-labelledby="headingOne">
                            <div class="panel-body panel_text">
                                First thing is to ask for the job offer in writing .
                                It is always advisable to convert a verbal offer 
                                in formal written job offer.
                            </div>
                        </div>
                    </div>
                    <div class="panel panel-default">
                        <div class="panel-heading" role="tab" id="headingTwo">
                            <h4 class="panel-title asd">
                                <a class="pa_italic collapsed" role="button" data-toggle="collapse" data-parent="#accordion" href="#collapseTwo" aria-expanded="false"
                                    aria-controls="collapseTwo">
                                    <span class="glyphicon glyphicon-plus" aria-hidden="true"></span><i class="glyphicon glyphicon-minus" aria-hidden="true"></i>Ask For The Decision Date
							  
                                </a>
                            </h4>
                        </div>
                        <div id="collapseTwo" class="panel-collapse collapse" role="tabpanel" aria-labelledby="headingTwo">
                            <div class="panel-body panel_text">
                                After you have requested a written job offer, 
                                ask the company for the decision date when 
                                they need your final answer.
                            </div>
                        </div>
                    </div>
                    <div class="panel panel-default">
                        <div class="panel-heading" role="tab" id="headingThree">
                            <h4 class="panel-title asd">
                                <a class="pa_italic collapsed" role="button" data-toggle="collapse" data-parent="#accordion" href="#collapseThree" aria-expanded="false"
                                    aria-controls="collapseThree">
                                    <span class="glyphicon glyphicon-plus" aria-hidden="true"></span><i class="glyphicon glyphicon-minus" aria-hidden="true"></i>Evaluate The Job Offer.
                                </a>
                            </h4>
                        </div>
                        <div id="collapseThree" class="panel-collapse collapse" role="tabpanel" aria-labelledby="headingThree">
                            <div class="panel-body panel_text">
                                Evaluate the offer and judge whether this is the right job
                                for you before sending a letter accepting the job. 
                                Use the sample job offer acceptance letter to 
                                accept the job in the right way.

                            </div>
                        </div>
                    </div>
                    <div class="panel panel-default">
                        <div class="panel-heading" role="tab" id="headingThree">
                            <h4 class="panel-title asd">
                                <a class="pa_italic collapsed" role="button" data-toggle="collapse" data-parent="#accordion" href="#collapseThree" aria-expanded="false"
                                    aria-controls="collapseThree">
                                    <span class="glyphicon glyphicon-plus" aria-hidden="true"></span><i class="glyphicon glyphicon-minus" aria-hidden="true"></i>Accept or Decline the offer in writing.
                                </a>
                                </a>
                            </h4>
                        </div>
                        <div id="collapseThree" class="panel-collapse collapse" role="tabpanel" aria-labelledby="headingThree">
                            <div class="panel-body panel_text">
                                Use our sample job offer acceptance email or decline the job
                                email to help you with this.

                            </div>
                        </div>
                    </div>
                </div>
            </div>

        </div>
        <div class="col-md-6 mid_services_img">
        </div>
        <div class="clearfix"></div>
    </div>

    

</asp:Content>

