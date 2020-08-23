<%@ Page Title="" Language="C#" MasterPageFile="~/HomeMaster.master" AutoEventWireup="true" CodeFile="Jobs.aspx.cs" Inherits="Jobs" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="Server">
    <div class="inner_page_agile">
        <h3>Internships</h3>
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
                <h3 class="tittle">Available Internships </h3>
            </div>
            <div class="inner_sec_grids_info_w3ls">
                <div class="col-md-8 job_info_left">
                    <div class="but_list">
                        <div class="bs-example bs-example-tabs" role="tabpanel" data-example-id="togglable-tabs">
                            <ul id="myTab" class="nav nav-tabs" role="tablist">
                                <li role="presentation" class="active"><a href="#home" id="home-tab" role="tab" data-toggle="tab" aria-controls="home" aria-expanded="true">Top Results</a></li>
                            </ul>
                            <div id="myTabContent" class="tab-content">
                                <div role="tabpanel" class="tab-pane fade in active" id="home" aria-labelledby="home-tab">
                                    <asp:Repeater ID="Repeater1" runat="server">
                                        <ItemTemplate>
                                            <div class="tab_grid">
                                                <div class="col-sm-12">
                                                    <div class="location_box1">
                                                        <h6><i class="fa fa-building"></i><a href="#">&nbsp;<%# Eval("Name") %> </a></h6>
                                                        <p>
                                                            <i class="fa fa-briefcase"></i>&nbsp;<b>Post Name:</b> <%# Eval("Post") %>&nbsp;&nbsp;<span><i class="fa fa-calendar"></i>&nbsp;<b>Start Date:</b> &nbsp;<%# Eval("PublishDate") %></span>
                                                        </p>
                                                        <p>
                                                            <i class="fa fa-money"></i>&nbsp;<b>Stipend:</b> ₹<%# Eval("Stipend") %>&nbsp;&nbsp;<span><i class="fa fa-clock-o"></i>&nbsp;<b>Duration:</b> &nbsp;<%# Eval("Duration") %></span>
                                                        </p>


                                                        <p>
                                                            <span class="m_2">Description : </span><%# Eval("Description") %>
                                                        </p>
                                                        <ul class="links_bottom">
                                                            <li><a href="#"><i class="fa fa-envelope-o icon_1"></i><span class="icon_text">&nbsp;<%# Eval("Email") %></span></a></li>
                                                            <li><a href="JobDescription.aspx?Jid=<%# Eval("Id") %>"><i class="fa fa-eye icon_1"></i><span class="icon_text">View full Description</span></a></li>
                                                            <li class="last"><a href="ApplyForIntern.aspx"><span class="icon_text">Apply Now <i class="fa fa-caret-right icon_1"></i></span></a></li>
                                                        </ul>
                                                    </div>
                                                </div>
                                                <div class="clearfix"></div>
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
            <div class="col-md-4 job_info_right">
                <div class="col_3 permit">
                    <h3>Jobs by Category</h3>
                    <ul class="list_2">
                        <asp:Repeater ID="Repeater2" runat="server">
                            <ItemTemplate>
                                <li><a href="#"><%# Eval("Post") %></a></li>
                            </ItemTemplate>
                        </asp:Repeater>
                    </ul>
                </div>
                
                <div class="col_3 permit">
                    <h3>Work Permit</h3>
                    <table class="table">
                        <tbody>
                            <tr class="unread checked">
                                <td class="hidden-xs">
                                    <input type="checkbox" class="checkbox">
                                </td>
                                <td class="hidden-xs">Full time
                                </td>
                            </tr>
                            <tr class="unread checked">
                                <td class="hidden-xs">
                                    <input type="checkbox" class="checkbox">
                                </td>
                                <td class="hidden-xs">Part time
                                </td>
                            </tr>
                        </tbody>
                    </table>
                </div>

            </div>
            <div class="clearfix"></div>
        </div>
    </div>
</asp:Content>

