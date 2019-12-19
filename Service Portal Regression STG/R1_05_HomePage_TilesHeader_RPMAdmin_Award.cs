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
    ///The R1_05_HomePage_TilesHeader_RPMAdmin_Award recording.
    /// </summary>
    [TestModule("846a2075-05ad-4d0a-a003-d968c1d15c4d", ModuleType.Recording, 1)]
    public partial class R1_05_HomePage_TilesHeader_RPMAdmin_Award : ITestModule
    {
        /// <summary>
        /// Holds an instance of the Service_Portal_Regression_STGRepository repository.
        /// </summary>
        public static Service_Portal_Regression_STGRepository repo = Service_Portal_Regression_STGRepository.Instance;

        static R1_05_HomePage_TilesHeader_RPMAdmin_Award instance = new R1_05_HomePage_TilesHeader_RPMAdmin_Award();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public R1_05_HomePage_TilesHeader_RPMAdmin_Award()
        {
            RPM_Admin_WM = "Hi, Chandler Bing!";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static R1_05_HomePage_TilesHeader_RPMAdmin_Award Instance
        {
            get { return instance; }
        }

#region Variables

        string _RPM_Admin_WM;

        /// <summary>
        /// Gets or sets the value of variable RPM_Admin_WM.
        /// </summary>
        [TestVariable("7d8d4644-d186-4ee8-9ade-4dde732146cf")]
        public string RPM_Admin_WM
        {
            get { return _RPM_Admin_WM; }
            set { _RPM_Admin_WM = value; }
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
            Keyboard.DefaultKeyPressTime = 30;
            Delay.SpeedFactor = 1.00;

            Init();

            // Header Links
            Report.Log(ReportLevel.Info, "Section", "Header Links", new RecordItemIndex(0));
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking WaitForDocumentLoaded() on item 'Login1'.", repo.Login1.SelfInfo, new RecordItemIndex(1));
            repo.Login1.Self.WaitForDocumentLoaded();
            Delay.Milliseconds(0);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (InnerText=' Award ') on item 'Login1.NavNavbarNavSamsNavbarNav.ATagAward'.", repo.Login1.NavNavbarNavSamsNavbarNav.ATagAwardInfo, new RecordItemIndex(2));
                Validate.AttributeEqual(repo.Login1.NavNavbarNavSamsNavbarNav.ATagAwardInfo, "InnerText", " Award ", null, new Validate.Options(){ReportScreenshot=Validate.ResultOption.OnFail});
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(2)); }
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.NavNavbarNavSamsNavbarNav.ATagAward' at 89;54.", repo.Login1.NavNavbarNavSamsNavbarNav.ATagAwardInfo, new RecordItemIndex(3));
            repo.Login1.NavNavbarNavSamsNavbarNav.ATagAward.Click("89;54");
            Delay.Milliseconds(200);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (InnerText='Award') on item 'Login1.NavNavbarNavSamsNavbarNav.Award'.", repo.Login1.NavNavbarNavSamsNavbarNav.AwardInfo, new RecordItemIndex(4));
                Validate.AttributeEqual(repo.Login1.NavNavbarNavSamsNavbarNav.AwardInfo, "InnerText", "Award", null, new Validate.Options(){ReportScreenshot=Validate.ResultOption.OnFail});
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(4)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (InnerText='Post Award Activities') on item 'Login1.NavNavbarNavSamsNavbarNav.PostAwardActivities'.", repo.Login1.NavNavbarNavSamsNavbarNav.PostAwardActivitiesInfo, new RecordItemIndex(5));
                Validate.AttributeEqual(repo.Login1.NavNavbarNavSamsNavbarNav.PostAwardActivitiesInfo, "InnerText", "Post Award Activities", null, new Validate.Options(){ReportScreenshot=Validate.ResultOption.OnFail});
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(5)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (InnerText='Performance Reports') on item 'Login1.NavNavbarNavSamsNavbarNav.PerformanceReports2'.", repo.Login1.NavNavbarNavSamsNavbarNav.PerformanceReports2Info, new RecordItemIndex(6));
                Validate.AttributeEqual(repo.Login1.NavNavbarNavSamsNavbarNav.PerformanceReports2Info, "InnerText", "Performance Reports", null, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(6)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (InnerText='Performance Report Details') on item 'Login1.NavNavbarNavSamsNavbarNav.PerformanceReportDetails2'.", repo.Login1.NavNavbarNavSamsNavbarNav.PerformanceReportDetails2Info, new RecordItemIndex(7));
                Validate.AttributeEqual(repo.Login1.NavNavbarNavSamsNavbarNav.PerformanceReportDetails2Info, "InnerText", "Performance Report Details", null, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(7)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (InnerText='Performance Dashboard') on item 'Login1.NavNavbarNavSamsNavbarNav.PerformanceDashboard2'.", repo.Login1.NavNavbarNavSamsNavbarNav.PerformanceDashboard2Info, new RecordItemIndex(8));
                Validate.AttributeEqual(repo.Login1.NavNavbarNavSamsNavbarNav.PerformanceDashboard2Info, "InnerText", "Performance Dashboard", null, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(8)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (InnerText='Awards Dashboard') on item 'Login1.NavNavbarNavSamsNavbarNav.AwardsDashboard12'.", repo.Login1.NavNavbarNavSamsNavbarNav.AwardsDashboard12Info, new RecordItemIndex(9));
                Validate.AttributeEqual(repo.Login1.NavNavbarNavSamsNavbarNav.AwardsDashboard12Info, "InnerText", "Awards Dashboard", null, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(9)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (InnerText='Navigate to Ariba') on item 'Login1.NavNavbarNavSamsNavbarNav.NavigateToAriba'.", repo.Login1.NavNavbarNavSamsNavbarNav.NavigateToAribaInfo, new RecordItemIndex(10));
                Validate.AttributeEqual(repo.Login1.NavNavbarNavSamsNavbarNav.NavigateToAribaInfo, "InnerText", "Navigate to Ariba", null, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(10)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (InnerText='Navigate to eFiling') on item 'Login1.NavNavbarNavSamsNavbarNav.NavigateToEFiling'.", repo.Login1.NavNavbarNavSamsNavbarNav.NavigateToEFilingInfo, new RecordItemIndex(11));
                Validate.AttributeEqual(repo.Login1.NavNavbarNavSamsNavbarNav.NavigateToEFilingInfo, "InnerText", "Navigate to eFiling", null, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(11)); }
            
            // Awards Screenshot
            Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(12));
            
            // Awards
            Report.Log(ReportLevel.Info, "Section", "Awards", new RecordItemIndex(13));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.NavNavbarNavSamsNavbarNav.Award' at 67;24.", repo.Login1.NavNavbarNavSamsNavbarNav.AwardInfo, new RecordItemIndex(14));
            repo.Login1.NavNavbarNavSamsNavbarNav.Award.Click("67;24");
            Delay.Milliseconds(200);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (InnerText='Notice of Awards') on item 'Login1.FormInlinePanelHeading.NoticeOfAwards'.", repo.Login1.FormInlinePanelHeading.NoticeOfAwardsInfo, new RecordItemIndex(15));
                Validate.AttributeEqual(repo.Login1.FormInlinePanelHeading.NoticeOfAwardsInfo, "InnerText", "Notice of Awards", null, new Validate.Options(){ReportScreenshot=Validate.ResultOption.OnFail});
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(15)); }
            
            // Award Table Screenshot
            Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(16));
            
            // Home Button
            Report.Log(ReportLevel.Info, "Mouse", "Home Button\r\nMouse Left Click item 'Login1.NavNavbarNavSamsNavbarNav.HOME' at 12;9.", repo.Login1.NavNavbarNavSamsNavbarNav.HOMEInfo, new RecordItemIndex(17));
            repo.Login1.NavNavbarNavSamsNavbarNav.HOME.Click("12;9");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s for the attribute 'InnerText' to equal the specified value $RPM_Admin_WM. Associated repository item: 'Login1.HiChandlerBing'", repo.Login1.HiChandlerBingInfo, new RecordItemIndex(18));
            repo.Login1.HiChandlerBingInfo.WaitForAttributeEqual(5000, "InnerText", RPM_Admin_WM);
            
            // PAA
            Report.Log(ReportLevel.Info, "Section", "PAA", new RecordItemIndex(19));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.NavNavbarNavSamsNavbarNav.ATagAward' at 92;45.", repo.Login1.NavNavbarNavSamsNavbarNav.ATagAwardInfo, new RecordItemIndex(20));
            repo.Login1.NavNavbarNavSamsNavbarNav.ATagAward.Click("92;45");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.NavNavbarNavSamsNavbarNav.PostAwardActivities' at 99;21.", repo.Login1.NavNavbarNavSamsNavbarNav.PostAwardActivitiesInfo, new RecordItemIndex(21));
            repo.Login1.NavNavbarNavSamsNavbarNav.PostAwardActivities.Click("99;21");
            Delay.Milliseconds(200);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (InnerText='Post Award Activities') on item 'Login1.FormInlinePanelHeading.PostAwardActivities'.", repo.Login1.FormInlinePanelHeading.PostAwardActivitiesInfo, new RecordItemIndex(22));
                Validate.AttributeEqual(repo.Login1.FormInlinePanelHeading.PostAwardActivitiesInfo, "InnerText", "Post Award Activities", null, new Validate.Options(){ReportScreenshot=Validate.ResultOption.OnFail});
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(22)); }
            
            // PAA Screenshot
            Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(23));
            
            // Home Button
            Report.Log(ReportLevel.Info, "Mouse", "Home Button\r\nMouse Left Click item 'Login1.NavNavbarNavSamsNavbarNav.HOME' at 12;9.", repo.Login1.NavNavbarNavSamsNavbarNav.HOMEInfo, new RecordItemIndex(24));
            repo.Login1.NavNavbarNavSamsNavbarNav.HOME.Click("12;9");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s for the attribute 'InnerText' to equal the specified value $RPM_Admin_WM. Associated repository item: 'Login1.HiChandlerBing'", repo.Login1.HiChandlerBingInfo, new RecordItemIndex(25));
            repo.Login1.HiChandlerBingInfo.WaitForAttributeEqual(5000, "InnerText", RPM_Admin_WM);
            
            // Performance Reports
            Report.Log(ReportLevel.Info, "Section", "Performance Reports", new RecordItemIndex(26));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.NavNavbarNavSamsNavbarNav.ATagAward' at 91;54.", repo.Login1.NavNavbarNavSamsNavbarNav.ATagAwardInfo, new RecordItemIndex(27));
            repo.Login1.NavNavbarNavSamsNavbarNav.ATagAward.Click("91;54");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.NavNavbarNavSamsNavbarNav.PerformanceReports2' at 105;16.", repo.Login1.NavNavbarNavSamsNavbarNav.PerformanceReports2Info, new RecordItemIndex(28));
            repo.Login1.NavNavbarNavSamsNavbarNav.PerformanceReports2.Click("105;16");
            Delay.Milliseconds(200);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (InnerText='Performance Reports') on item 'Login1.FormInlinePanelHeading.PerformanceReports'.", repo.Login1.FormInlinePanelHeading.PerformanceReportsInfo, new RecordItemIndex(29));
                Validate.AttributeEqual(repo.Login1.FormInlinePanelHeading.PerformanceReportsInfo, "InnerText", "Performance Reports", null, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(29)); }
            
            // Performance Report Table Screenshot
            Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(30));
            
            // Home Button
            Report.Log(ReportLevel.Info, "Mouse", "Home Button\r\nMouse Left Click item 'Login1.NavNavbarNavSamsNavbarNav.HOME' at 12;9.", repo.Login1.NavNavbarNavSamsNavbarNav.HOMEInfo, new RecordItemIndex(31));
            repo.Login1.NavNavbarNavSamsNavbarNav.HOME.Click("12;9");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s for the attribute 'InnerText' to equal the specified value $RPM_Admin_WM. Associated repository item: 'Login1.HiChandlerBing'", repo.Login1.HiChandlerBingInfo, new RecordItemIndex(32));
            repo.Login1.HiChandlerBingInfo.WaitForAttributeEqual(5000, "InnerText", RPM_Admin_WM);
            
            // Performance Report Details
            Report.Log(ReportLevel.Info, "Section", "Performance Report Details", new RecordItemIndex(33));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.NavNavbarNavSamsNavbarNav.ATagAward' at 92;45.", repo.Login1.NavNavbarNavSamsNavbarNav.ATagAwardInfo, new RecordItemIndex(34));
            repo.Login1.NavNavbarNavSamsNavbarNav.ATagAward.Click("92;45");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.NavNavbarNavSamsNavbarNav.PerformanceReportDetails2' at 135;18.", repo.Login1.NavNavbarNavSamsNavbarNav.PerformanceReportDetails2Info, new RecordItemIndex(35));
            repo.Login1.NavNavbarNavSamsNavbarNav.PerformanceReportDetails2.Click("135;18");
            Delay.Milliseconds(200);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (InnerText='Performance Report Details') on item 'Login1.FormInlinePanelHeading.PerformanceReportDetails'.", repo.Login1.FormInlinePanelHeading.PerformanceReportDetailsInfo, new RecordItemIndex(36));
                Validate.AttributeEqual(repo.Login1.FormInlinePanelHeading.PerformanceReportDetailsInfo, "InnerText", "Performance Report Details", null, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(36)); }
            
            // Performance Report Details Table Screenshot
            Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(37));
            
            // Home Button
            Report.Log(ReportLevel.Info, "Mouse", "Home Button\r\nMouse Left Click item 'Login1.NavNavbarNavSamsNavbarNav.HOME' at 12;9.", repo.Login1.NavNavbarNavSamsNavbarNav.HOMEInfo, new RecordItemIndex(38));
            repo.Login1.NavNavbarNavSamsNavbarNav.HOME.Click("12;9");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s for the attribute 'InnerText' to equal the specified value $RPM_Admin_WM. Associated repository item: 'Login1.HiChandlerBing'", repo.Login1.HiChandlerBingInfo, new RecordItemIndex(39));
            repo.Login1.HiChandlerBingInfo.WaitForAttributeEqual(5000, "InnerText", RPM_Admin_WM);
            
            // Performance Dashboard
            Report.Log(ReportLevel.Info, "Section", "Performance Dashboard", new RecordItemIndex(40));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.NavNavbarNavSamsNavbarNav.ATagAward' at 92;45.", repo.Login1.NavNavbarNavSamsNavbarNav.ATagAwardInfo, new RecordItemIndex(41));
            repo.Login1.NavNavbarNavSamsNavbarNav.ATagAward.Click("92;45");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.NavNavbarNavSamsNavbarNav.PerformanceDashboard2' at 165;14.", repo.Login1.NavNavbarNavSamsNavbarNav.PerformanceDashboard2Info, new RecordItemIndex(42));
            repo.Login1.NavNavbarNavSamsNavbarNav.PerformanceDashboard2.Click("165;14");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Performance Report - Approval Status') on item 'Login1.NoticeOfAwardStatus'.", repo.Login1.NoticeOfAwardStatusInfo, new RecordItemIndex(43));
            Validate.AttributeEqual(repo.Login1.NoticeOfAwardStatusInfo, "InnerText", "Performance Report - Approval Status");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Performance Report - Submission') on item 'Login1.PerformanceReportSubmission'.", repo.Login1.PerformanceReportSubmissionInfo, new RecordItemIndex(44));
            Validate.AttributeEqual(repo.Login1.PerformanceReportSubmissionInfo, "InnerText", "Performance Report - Submission");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Work Plan - Activities Status') on item 'Login1.WorkPlanActivitiesStatus2'.", repo.Login1.WorkPlanActivitiesStatus2Info, new RecordItemIndex(45));
            Validate.AttributeEqual(repo.Login1.WorkPlanActivitiesStatus2Info, "InnerText", "Work Plan - Activities Status");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(46));
            Delay.Duration(1000, false);
            
            // Performance Dashboard Screenshot
            Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(47));
            
            // Home Button
            Report.Log(ReportLevel.Info, "Mouse", "Home Button\r\nMouse Left Click item 'Login1.NavNavbarNavSamsNavbarNav.HOME' at 12;9.", repo.Login1.NavNavbarNavSamsNavbarNav.HOMEInfo, new RecordItemIndex(48));
            repo.Login1.NavNavbarNavSamsNavbarNav.HOME.Click("12;9");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s for the attribute 'InnerText' to equal the specified value $RPM_Admin_WM. Associated repository item: 'Login1.HiChandlerBing'", repo.Login1.HiChandlerBingInfo, new RecordItemIndex(49));
            repo.Login1.HiChandlerBingInfo.WaitForAttributeEqual(5000, "InnerText", RPM_Admin_WM);
            
            // Awards Dashboard
            Report.Log(ReportLevel.Info, "Section", "Awards Dashboard", new RecordItemIndex(50));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.NavNavbarNavSamsNavbarNav.ATagAward' at 92;45.", repo.Login1.NavNavbarNavSamsNavbarNav.ATagAwardInfo, new RecordItemIndex(51));
            repo.Login1.NavNavbarNavSamsNavbarNav.ATagAward.Click("92;45");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.NavNavbarNavSamsNavbarNav.AwardsDashboard12' at 94;15.", repo.Login1.NavNavbarNavSamsNavbarNav.AwardsDashboard12Info, new RecordItemIndex(52));
            repo.Login1.NavNavbarNavSamsNavbarNav.AwardsDashboard12.Click("94;15");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking WaitForDocumentLoaded() on item 'Login1'.", repo.Login1.SelfInfo, new RecordItemIndex(53));
            repo.Login1.Self.WaitForDocumentLoaded();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Notice of Award - Status') on item 'Login1.NoticeOfAwardStatus'.", repo.Login1.NoticeOfAwardStatusInfo, new RecordItemIndex(54));
            Validate.AttributeEqual(repo.Login1.NoticeOfAwardStatusInfo, "InnerText", "Notice of Award - Status");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Post Award Activities - Status') on item 'Login1.PostAwardActivitiesStatus'.", repo.Login1.PostAwardActivitiesStatusInfo, new RecordItemIndex(55));
            Validate.AttributeEqual(repo.Login1.PostAwardActivitiesStatusInfo, "InnerText", "Post Award Activities - Status");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(56));
            Delay.Duration(1000, false);
            
            // Awards Dashboard Screenshot
            Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(57));
            
            // Home Button
            Report.Log(ReportLevel.Info, "Mouse", "Home Button\r\nMouse Left Click item 'Login1.NavNavbarNavSamsNavbarNav.HOME' at 12;9.", repo.Login1.NavNavbarNavSamsNavbarNav.HOMEInfo, new RecordItemIndex(58));
            repo.Login1.NavNavbarNavSamsNavbarNav.HOME.Click("12;9");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s for the attribute 'InnerText' to equal the specified value $RPM_Admin_WM. Associated repository item: 'Login1.HiChandlerBing'", repo.Login1.HiChandlerBingInfo, new RecordItemIndex(59));
            repo.Login1.HiChandlerBingInfo.WaitForAttributeEqual(5000, "InnerText", RPM_Admin_WM);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
