<%@ Page Async="true" EnableEventValidation="false" Title="" Language="C#" MasterPageFile="~/Site1.Master" AutoEventWireup="true" CodeBehind="EmployerPage.aspx.cs" Inherits="IlanTakip.EmployerPage" %>

<asp:Content ID="Content1" ContentPlaceHolderID="ContentPlaceHolder1" runat="server">
    
    <main id="main">
        <section class="inner-page">
            <div class="container">
                <form class="row g-3 needs-validation" novalidate>
                    <div class="col-md-4">
                        <label for="validationCustom01" class="form-label">Job Title</label>
                        <input type="text" class="form-control" id="validationJobTitle" value="" placeholder="Job Title" required runat="server">
                    </div>
                    <div class="col-md-4">
                        <label for="validationCustom01" class="form-label">Job Description</label>
                        <input type="text" class="form-control" id="validationJobDescription"
                            placeholder="Enter a description about the job advert" required runat="server">
                    </div>
                    <div class="col-md-4">
                        <label for="validationCustom01" class="form-label">Open Position</label>
                        <input type="text" class="form-control" id="validationOpenPosition" value="" placeholder="Open Position" required runat="server">
                    </div>
                    <div class="col-md-3">
                        <label for="validationCustom04" class="form-label">State</label>
                        <select class="form-select" id="validationCustom04" required runat="server">
                            <option selected disabled value="" runat="server">Seçim yapınız...</option>
                            <option >...</option>
                        </select>
                        <div class="invalid-feedback">
                            Please select a valid state.
                        </div>  
                    </div>
                    <div class="col-12 mt-3">
                        <asp:Button ID="jobAdvertAdd" OnClick="jobAdvertAdd_Click" class="btn btn-primary" runat="server" Text="Add Job Advert" />
                    </div>
                        <asp:Label ID="LabelMessage" Text="" runat="server" />
                </form>
            </div>
        </section>

    </main>
    <!-- End #main -->



    <!-- ======= Footer ======= -->
    <footer id="footer">

        <div class="footer-top">
            <div class="container">
                <div class="row">

                    <div class="col-lg-3 col-md-6 footer-contact">
                        <h3>Ninestars</h3>
                        <p>
                            A108 Adam Street
                            <br>
                            New York, NY 535022<br>
                            United States
                            <br>
                            <br>
                            <strong>Phone:</strong> +1 5589 55488 55<br>
                            <strong>Email:</strong> info@example.com<br>
                        </p>
                    </div>

                    <div class="col-lg-3 col-md-6 footer-links">
                        <h4>Useful Links</h4>
                        <ul>
                            <li><i class="bx bx-chevron-right"></i><a href="#">Home</a></li>
                            <li><i class="bx bx-chevron-right"></i><a href="#">About us</a></li>
                            <li><i class="bx bx-chevron-right"></i><a href="#">Services</a></li>
                            <li><i class="bx bx-chevron-right"></i><a href="#">Terms of service</a></li>
                            <li><i class="bx bx-chevron-right"></i><a href="#">Privacy policy</a></li>
                        </ul>
                    </div>

                    <div class="col-lg-3 col-md-6 footer-links">
                        <h4>Our Services</h4>
                        <ul>
                            <li><i class="bx bx-chevron-right"></i><a href="#">Web Design</a></li>
                            <li><i class="bx bx-chevron-right"></i><a href="#">Web Development</a></li>
                            <li><i class="bx bx-chevron-right"></i><a href="#">Product Management</a></li>
                            <li><i class="bx bx-chevron-right"></i><a href="#">Marketing</a></li>
                            <li><i class="bx bx-chevron-right"></i><a href="#">Graphic Design</a></li>
                        </ul>
                    </div>

                    <div class="col-lg-3 col-md-6 footer-links">
                        <h4>Our Social Networks</h4>
                        <p>Cras fermentum odio eu feugiat lide par naso tierra videa magna derita valies</p>
                        <div class="social-links mt-3">
                            <a href="#" class="twitter"><i class="bx bxl-twitter"></i></a>
                            <a href="#" class="facebook"><i class="bx bxl-facebook"></i></a>
                            <a href="#" class="instagram"><i class="bx bxl-instagram"></i></a>
                            <a href="#" class="google-plus"><i class="bx bxl-skype"></i></a>
                            <a href="#" class="linkedin"><i class="bx bxl-linkedin"></i></a>
                        </div>
                    </div>

                </div>
            </div>
        </div>

        <div class="container py-4">
            <div class="copyright">
                &copy; Copyright <strong><span>Ninestars</span></strong>. All Rights Reserved
            </div>
            <div class="credits">
                <!-- All the links in the footer should remain intact. -->
                <!-- You can delete the links only if you purchased the pro version. -->
                <!-- Licensing information: https://bootstrapmade.com/license/ -->
                <!-- Purchase the pro version with working PHP/AJAX contact form: https://bootstrapmade.com/ninestars-free-bootstrap-3-theme-for-creative/ -->
                Designed by <a href="https://bootstrapmade.com/">BootstrapMade</a>
            </div>
        </div>
    </footer>
    <!-- End Footer -->


</asp:Content>

