﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Testing;
using Ranorex.Core.Repository;

namespace Service_Portal_Regression_STG
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The R1_03_HomePage_Footer_RPMGrantor_Award recording.
    /// </summary>
    [TestModule("651966e7-7522-4081-8aa4-484db859120b", ModuleType.Recording, 1)]
    public partial class R1_03_HomePage_Footer_RPMGrantor_Award : ITestModule
    {
        /// <summary>
        /// Holds an instance of the Service_Portal_Regression_TSTRepository repository.
        /// </summary>
        public static Service_Portal_Regression_TSTRepository repo = Service_Portal_Regression_TSTRepository.Instance;

        static R1_03_HomePage_Footer_RPMGrantor_Award instance = new R1_03_HomePage_Footer_RPMGrantor_Award();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public R1_03_HomePage_Footer_RPMGrantor_Award()
        {
            RPM_Grantor_WM = "Hi, Gunther Central-Perk!";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static R1_03_HomePage_Footer_RPMGrantor_Award Instance
        {
            get { return instance; }
        }

#region Variables

        string _RPM_Grantor_WM;

        /// <summary>
        /// Gets or sets the value of variable RPM_Grantor_WM.
        /// </summary>
        [TestVariable("49169773-6420-4f1b-9e9f-fb2b2d3f8f93")]
        public string RPM_Grantor_WM
        {
            get { return _RPM_Grantor_WM; }
            set { _RPM_Grantor_WM = value; }
        }

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        public static void Start()
        {
            TestModuleRunner.Run(Instance);
        }

        /// <summary>
        /// Performs the playback of actions in this recording.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            // Footer Links
            Report.Log(ReportLevel.Info, "Section", "Footer Links", new RecordItemIndex(0));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -840 units.", new RecordItemIndex(1));
            Mouse.ScrollWheel(-840);
            Delay.Milliseconds(500);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (InnerText='Award') on item 'Login1.NgScope1.Award'.", repo.Login1.NgScope1.AwardInfo, new RecordItemIndex(2));
                Validate.AttributeEqual(repo.Login1.NgScope1.AwardInfo, "InnerText", "Award", null, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(2)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (InnerText='Award') on item 'Login1.NgScope1.Award1'.", repo.Login1.NgScope1.Award1Info, new RecordItemIndex(3));
                Validate.AttributeEqual(repo.Login1.NgScope1.Award1Info, "InnerText", "Award", null, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(3)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (InnerText='Post Award Activities') on item 'Login1.NgScope1.PostAwardActivities'.", repo.Login1.NgScope1.PostAwardActivitiesInfo, new RecordItemIndex(4));
                Validate.AttributeEqual(repo.Login1.NgScope1.PostAwardActivitiesInfo, "InnerText", "Post Award Activities", null, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(4)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (InnerText='Performance Reports') on item 'Login1.NgScope1.PerformanceReports'.", repo.Login1.NgScope1.PerformanceReportsInfo, new RecordItemIndex(5));
                Validate.AttributeEqual(repo.Login1.NgScope1.PerformanceReportsInfo, "InnerText", "Performance Reports", null, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(5)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (InnerText='Performance Report Details') on item 'Login1.NgScope1.PerformanceReportDetails'.", repo.Login1.NgScope1.PerformanceReportDetailsInfo, new RecordItemIndex(6));
                Validate.AttributeEqual(repo.Login1.NgScope1.PerformanceReportDetailsInfo, "InnerText", "Performance Report Details", null, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(6)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (InnerText='Performance Dashboard') on item 'Login1.NgScope1.PerformanceDashboard'.", repo.Login1.NgScope1.PerformanceDashboardInfo, new RecordItemIndex(7));
                Validate.AttributeEqual(repo.Login1.NgScope1.PerformanceDashboardInfo, "InnerText", "Performance Dashboard", null, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(7)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (InnerText='Awards Dashboard') on item 'Login1.NgScope1.AwardsDashboard1'.", repo.Login1.NgScope1.AwardsDashboard1Info, new RecordItemIndex(8));
                Validate.AttributeEqual(repo.Login1.NgScope1.AwardsDashboard1Info, "InnerText", "Awards Dashboard", null, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(8)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (InnerText='Navigate to Ariba') on item 'Login1.NgScope1.NavigateToAriba1'.", repo.Login1.NgScope1.NavigateToAriba1Info, new RecordItemIndex(9));
                Validate.AttributeEqual(repo.Login1.NgScope1.NavigateToAriba1Info, "InnerText", "Navigate to Ariba", null, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(9)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (InnerText='Navigate to eFiling') on item 'Login1.NgScope1.NavigateToEFiling1'.", repo.Login1.NgScope1.NavigateToEFiling1Info, new RecordItemIndex(10));
                Validate.AttributeEqual(repo.Login1.NgScope1.NavigateToEFiling1Info, "InnerText", "Navigate to eFiling", null, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(10)); }
            
            // Pre-Award Screenshot
            Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(11));
            
            // Award
            Report.Log(ReportLevel.Info, "Section", "Award", new RecordItemIndex(12));
            
            // Footer - FO
            Report.Log(ReportLevel.Info, "Mouse", "Footer - FO\r\nMouse Left Click item 'Login1.NgScope1.Award1' at 34;7.", repo.Login1.NgScope1.Award1Info, new RecordItemIndex(13));
            repo.Login1.NgScope1.Award1.Click("34;7");
            Delay.Milliseconds(200);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (InnerText='Notice of Awards') on item 'Login1.FormInlinePanelHeading.NoticeOfAwards'.", repo.Login1.FormInlinePanelHeading.NoticeOfAwardsInfo, new RecordItemIndex(14));
                Validate.AttributeEqual(repo.Login1.FormInlinePanelHeading.NoticeOfAwardsInfo, "InnerText", "Notice of Awards", null, new Validate.Options(){ReportScreenshot=Validate.ResultOption.OnFail});
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(14)); }
            
            // Award Table Screenshot
            Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(15));
            
            // Home Button
            Report.Log(ReportLevel.Info, "Mouse", "Home Button\r\nMouse Left Click item 'Login1.NavNavbarNavSamsNavbarNav.HOME' at 12;9.", repo.Login1.NavNavbarNavSamsNavbarNav.HOMEInfo, new RecordItemIndex(16));
            repo.Login1.NavNavbarNavSamsNavbarNav.HOME.Click("12;9");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s for the attribute 'InnerText' to equal the specified value $RPM_Grantor_WM. Associated repository item: 'Login1.HiGuntherCentralPerk'", repo.Login1.HiGuntherCentralPerkInfo, new RecordItemIndex(17));
            repo.Login1.HiGuntherCentralPerkInfo.WaitForAttributeEqual(5000, "InnerText", RPM_Grantor_WM);
            
            // PAA
            Report.Log(ReportLevel.Info, "Section", "PAA", new RecordItemIndex(18));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -840 units.", new RecordItemIndex(19));
            Mouse.ScrollWheel(-840);
            Delay.Milliseconds(500);
            
            // Footer - Application
            Report.Log(ReportLevel.Info, "Mouse", "Footer - Application\r\nMouse Left Click item 'Login1.NgScope1.PostAwardActivities' at 70;14.", repo.Login1.NgScope1.PostAwardActivitiesInfo, new RecordItemIndex(20));
            repo.Login1.NgScope1.PostAwardActivities.Click("70;14");
            Delay.Milliseconds(200);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (InnerText='Post Award Activities') on item 'Login1.FormInlinePanelHeading.PostAwardActivities'.", repo.Login1.FormInlinePanelHeading.PostAwardActivitiesInfo, new RecordItemIndex(21));
                Validate.AttributeEqual(repo.Login1.FormInlinePanelHeading.PostAwardActivitiesInfo, "InnerText", "Post Award Activities", null, new Validate.Options(){ReportScreenshot=Validate.ResultOption.OnFail});
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(21)); }
            
            // PAA Screenshot
            Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(22));
            
            // Home Button
            Report.Log(ReportLevel.Info, "Mouse", "Home Button\r\nMouse Left Click item 'Login1.NavNavbarNavSamsNavbarNav.HOME' at 12;9.", repo.Login1.NavNavbarNavSamsNavbarNav.HOMEInfo, new RecordItemIndex(23));
            repo.Login1.NavNavbarNavSamsNavbarNav.HOME.Click("12;9");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s for the attribute 'InnerText' to equal the specified value $RPM_Grantor_WM. Associated repository item: 'Login1.HiGuntherCentralPerk'", repo.Login1.HiGuntherCentralPerkInfo, new RecordItemIndex(24));
            repo.Login1.HiGuntherCentralPerkInfo.WaitForAttributeEqual(5000, "InnerText", RPM_Grantor_WM);
            
            // Performance Reports
            Report.Log(ReportLevel.Info, "Section", "Performance Reports", new RecordItemIndex(25));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -840 units.", new RecordItemIndex(26));
            Mouse.ScrollWheel(-840);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.NgScope1.PerformanceReports' at 70;14.", repo.Login1.NgScope1.PerformanceReportsInfo, new RecordItemIndex(27));
            repo.Login1.NgScope1.PerformanceReports.Click("70;14");
            Delay.Milliseconds(200);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (InnerText='Performance Reports') on item 'Login1.FormInlinePanelHeading.PerformanceReports'.", repo.Login1.FormInlinePanelHeading.PerformanceReportsInfo, new RecordItemIndex(28));
                Validate.AttributeEqual(repo.Login1.FormInlinePanelHeading.PerformanceReportsInfo, "InnerText", "Performance Reports", null, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(28)); }
            
            // Performance Report Table Screenshot
            Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(29));
            
            // Home Button
            Report.Log(ReportLevel.Info, "Mouse", "Home Button\r\nMouse Left Click item 'Login1.NavNavbarNavSamsNavbarNav.HOME' at 12;9.", repo.Login1.NavNavbarNavSamsNavbarNav.HOMEInfo, new RecordItemIndex(30));
            repo.Login1.NavNavbarNavSamsNavbarNav.HOME.Click("12;9");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s for the attribute 'InnerText' to equal the specified value $RPM_Grantor_WM. Associated repository item: 'Login1.HiGuntherCentralPerk'", repo.Login1.HiGuntherCentralPerkInfo, new RecordItemIndex(31));
            repo.Login1.HiGuntherCentralPerkInfo.WaitForAttributeEqual(5000, "InnerText", RPM_Grantor_WM);
            
            // Performance Report Details
            Report.Log(ReportLevel.Info, "Section", "Performance Report Details", new RecordItemIndex(32));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -840 units.", new RecordItemIndex(33));
            Mouse.ScrollWheel(-840);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.NgScope1.PerformanceReportDetails' at 45;11.", repo.Login1.NgScope1.PerformanceReportDetailsInfo, new RecordItemIndex(34));
            repo.Login1.NgScope1.PerformanceReportDetails.Click("45;11");
            Delay.Milliseconds(200);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (InnerText='Performance Report Details') on item 'Login1.FormInlinePanelHeading.PerformanceReportDetails'.", repo.Login1.FormInlinePanelHeading.PerformanceReportDetailsInfo, new RecordItemIndex(35));
                Validate.AttributeEqual(repo.Login1.FormInlinePanelHeading.PerformanceReportDetailsInfo, "InnerText", "Performance Report Details", null, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(35)); }
            
            // Performance Report Details Table Screenshot
            Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(36));
            
            // Home Button
            Report.Log(ReportLevel.Info, "Mouse", "Home Button\r\nMouse Left Click item 'Login1.NavNavbarNavSamsNavbarNav.HOME' at 12;9.", repo.Login1.NavNavbarNavSamsNavbarNav.HOMEInfo, new RecordItemIndex(37));
            repo.Login1.NavNavbarNavSamsNavbarNav.HOME.Click("12;9");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s for the attribute 'InnerText' to equal the specified value $RPM_Grantor_WM. Associated repository item: 'Login1.HiGuntherCentralPerk'", repo.Login1.HiGuntherCentralPerkInfo, new RecordItemIndex(38));
            repo.Login1.HiGuntherCentralPerkInfo.WaitForAttributeEqual(5000, "InnerText", RPM_Grantor_WM);
            
            // Performance Dashboard
            Report.Log(ReportLevel.Info, "Section", "Performance Dashboard", new RecordItemIndex(39));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -840 units.", new RecordItemIndex(40));
            Mouse.ScrollWheel(-840);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.NgScope1.PerformanceDashboard' at 70;14.", repo.Login1.NgScope1.PerformanceDashboardInfo, new RecordItemIndex(41));
            repo.Login1.NgScope1.PerformanceDashboard.Click("70;14");
            Delay.Milliseconds(200);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (InnerText='Performance Report - Approval Status') on item 'Login1.NoticeOfAwardStatus'.", repo.Login1.NoticeOfAwardStatusInfo, new RecordItemIndex(42));
                Validate.AttributeEqual(repo.Login1.NoticeOfAwardStatusInfo, "InnerText", "Performance Report - Approval Status", null, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(42)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (InnerText='Performance Report - Submission') on item 'Login1.PerformanceReportSubmission'.", repo.Login1.PerformanceReportSubmissionInfo, new RecordItemIndex(43));
                Validate.AttributeEqual(repo.Login1.PerformanceReportSubmissionInfo, "InnerText", "Performance Report - Submission", null, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(43)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (InnerText='Work Plan - Activities Status') on item 'Login1.WorkPlanActivitiesStatus'.", repo.Login1.WorkPlanActivitiesStatusInfo, new RecordItemIndex(44));
                Validate.AttributeEqual(repo.Login1.WorkPlanActivitiesStatusInfo, "InnerText", "Work Plan - Activities Status", null, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(44)); }
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(45));
            Delay.Duration(1000, false);
            
            // Performance Dashboard Screenshot
            Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(46));
            
            // Home Button
            Report.Log(ReportLevel.Info, "Mouse", "Home Button\r\nMouse Left Click item 'Login1.NavNavbarNavSamsNavbarNav.HOME' at 12;9.", repo.Login1.NavNavbarNavSamsNavbarNav.HOMEInfo, new RecordItemIndex(47));
            repo.Login1.NavNavbarNavSamsNavbarNav.HOME.Click("12;9");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s for the attribute 'InnerText' to equal the specified value $RPM_Grantor_WM. Associated repository item: 'Login1.HiGuntherCentralPerk'", repo.Login1.HiGuntherCentralPerkInfo, new RecordItemIndex(48));
            repo.Login1.HiGuntherCentralPerkInfo.WaitForAttributeEqual(5000, "InnerText", RPM_Grantor_WM);
            
            // Awards Dashboard
            Report.Log(ReportLevel.Info, "Section", "Awards Dashboard", new RecordItemIndex(49));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -840 units.", new RecordItemIndex(50));
            Mouse.ScrollWheel(-840);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.NgScope1.AwardsDashboard1' at 70;14.", repo.Login1.NgScope1.AwardsDashboard1Info, new RecordItemIndex(51));
            repo.Login1.NgScope1.AwardsDashboard1.Click("70;14");
            Delay.Milliseconds(200);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (InnerText='Notice of Award - Status') on item 'Login1.NoticeOfAwardStatus'.", repo.Login1.NoticeOfAwardStatusInfo, new RecordItemIndex(52));
                Validate.AttributeEqual(repo.Login1.NoticeOfAwardStatusInfo, "InnerText", "Notice of Award - Status", null, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(52)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (InnerText='Post Award Activities - Status') on item 'Login1.PostAwardActivitiesStatus'.", repo.Login1.PostAwardActivitiesStatusInfo, new RecordItemIndex(53));
                Validate.AttributeEqual(repo.Login1.PostAwardActivitiesStatusInfo, "InnerText", "Post Award Activities - Status", null, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(53)); }
            
            // Awards Dashboard Screenshot
            Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(54));
            
            // Home Button
            Report.Log(ReportLevel.Info, "Mouse", "Home Button\r\nMouse Left Click item 'Login1.NavNavbarNavSamsNavbarNav.HOME' at 12;9.", repo.Login1.NavNavbarNavSamsNavbarNav.HOMEInfo, new RecordItemIndex(55));
            repo.Login1.NavNavbarNavSamsNavbarNav.HOME.Click("12;9");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s for the attribute 'InnerText' to equal the specified value $RPM_Grantor_WM. Associated repository item: 'Login1.HiGuntherCentralPerk'", repo.Login1.HiGuntherCentralPerkInfo, new RecordItemIndex(56));
            repo.Login1.HiGuntherCentralPerkInfo.WaitForAttributeEqual(5000, "InnerText", RPM_Grantor_WM);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
