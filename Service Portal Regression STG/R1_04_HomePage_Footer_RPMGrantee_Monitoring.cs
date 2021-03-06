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
    ///The R1_04_HomePage_Footer_RPMGrantee_Monitoring recording.
    /// </summary>
    [TestModule("42f79a04-3270-48ef-ba83-06dad57e783c", ModuleType.Recording, 1)]
    public partial class R1_04_HomePage_Footer_RPMGrantee_Monitoring : ITestModule
    {
        /// <summary>
        /// Holds an instance of the Service_Portal_Regression_STGRepository repository.
        /// </summary>
        public static Service_Portal_Regression_STGRepository repo = Service_Portal_Regression_STGRepository.Instance;

        static R1_04_HomePage_Footer_RPMGrantee_Monitoring instance = new R1_04_HomePage_Footer_RPMGrantee_Monitoring();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public R1_04_HomePage_Footer_RPMGrantee_Monitoring()
        {
            RPM_Grantee_WM = "Hi, Monica Geller!";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static R1_04_HomePage_Footer_RPMGrantee_Monitoring Instance
        {
            get { return instance; }
        }

#region Variables

        string _RPM_Grantee_WM;

        /// <summary>
        /// Gets or sets the value of variable RPM_Grantee_WM.
        /// </summary>
        [TestVariable("0058cbc9-3ede-4331-b6fc-2e205dc4ac02")]
        public string RPM_Grantee_WM
        {
            get { return _RPM_Grantee_WM; }
            set { _RPM_Grantee_WM = value; }
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
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Monitoring') on item 'Login1.NgScope2.Monitoring'.", repo.Login1.NgScope2.MonitoringInfo, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.Login1.NgScope2.MonitoringInfo, "InnerText", "Monitoring");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Proposals') on item 'Login1.NgScope2.Proposals'.", repo.Login1.NgScope2.ProposalsInfo, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.Login1.NgScope2.ProposalsInfo, "InnerText", "Proposals");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Performance Reports') on item 'Login1.NgScope2.PerformanceReports'.", repo.Login1.NgScope2.PerformanceReportsInfo, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.Login1.NgScope2.PerformanceReportsInfo, "InnerText", "Performance Reports");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Performance Report Details') on item 'Login1.NgScope2.PerformanceReportDetails'.", repo.Login1.NgScope2.PerformanceReportDetailsInfo, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.Login1.NgScope2.PerformanceReportDetailsInfo, "InnerText", "Performance Report Details");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Performance Dashboard') on item 'Login1.NgScope2.PerformanceDashboard'.", repo.Login1.NgScope2.PerformanceDashboardInfo, new RecordItemIndex(5));
            Validate.AttributeEqual(repo.Login1.NgScope2.PerformanceDashboardInfo, "InnerText", "Performance Dashboard");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.NgScope2.Monitoring' at 38;2.", repo.Login1.NgScope2.MonitoringInfo, new RecordItemIndex(6));
            repo.Login1.NgScope2.Monitoring.Click("38;2");
            Delay.Milliseconds(200);
            
            // Monitoring Screenshot
            Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(7));
            
            // Proposals
            Report.Log(ReportLevel.Info, "Section", "Proposals", new RecordItemIndex(8));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.NgScope2.Proposals' at 41;11.", repo.Login1.NgScope2.ProposalsInfo, new RecordItemIndex(9));
            repo.Login1.NgScope2.Proposals.Click("41;11");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Proposals') on item 'Login1.FormInlinePanelHeading.Proposals'.", repo.Login1.FormInlinePanelHeading.ProposalsInfo, new RecordItemIndex(10));
            Validate.AttributeEqual(repo.Login1.FormInlinePanelHeading.ProposalsInfo, "InnerText", "Proposals");
            Delay.Milliseconds(100);
            
            // Proposals Table Screenshot
            Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(11));
            
            // Home Button
            Report.Log(ReportLevel.Info, "Mouse", "Home Button\r\nMouse Left Click item 'Login1.NavNavbarNavSamsNavbarNav.HOME' at 12;9.", repo.Login1.NavNavbarNavSamsNavbarNav.HOMEInfo, new RecordItemIndex(12));
            repo.Login1.NavNavbarNavSamsNavbarNav.HOME.Click("12;9");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s for the attribute 'InnerText' to equal the specified value $RPM_Grantee_WM. Associated repository item: 'Login1.HiMonicaGeller'", repo.Login1.HiMonicaGellerInfo, new RecordItemIndex(13));
            repo.Login1.HiMonicaGellerInfo.WaitForAttributeEqual(5000, "InnerText", RPM_Grantee_WM);
            
            // Performance Reports
            Report.Log(ReportLevel.Info, "Section", "Performance Reports", new RecordItemIndex(14));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.NgScope2.PerformanceReports' at 41;11.", repo.Login1.NgScope2.PerformanceReportsInfo, new RecordItemIndex(15));
            repo.Login1.NgScope2.PerformanceReports.Click("41;11");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Performance Reports') on item 'Login1.FormInlinePanelHeading.PerformanceReports'.", repo.Login1.FormInlinePanelHeading.PerformanceReportsInfo, new RecordItemIndex(16));
            Validate.AttributeEqual(repo.Login1.FormInlinePanelHeading.PerformanceReportsInfo, "InnerText", "Performance Reports");
            Delay.Milliseconds(100);
            
            // Performance Report Table Screenshot
            Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(17));
            
            // Home Button
            Report.Log(ReportLevel.Info, "Mouse", "Home Button\r\nMouse Left Click item 'Login1.NavNavbarNavSamsNavbarNav.HOME' at 12;9.", repo.Login1.NavNavbarNavSamsNavbarNav.HOMEInfo, new RecordItemIndex(18));
            repo.Login1.NavNavbarNavSamsNavbarNav.HOME.Click("12;9");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s for the attribute 'InnerText' to equal the specified value $RPM_Grantee_WM. Associated repository item: 'Login1.HiMonicaGeller'", repo.Login1.HiMonicaGellerInfo, new RecordItemIndex(19));
            repo.Login1.HiMonicaGellerInfo.WaitForAttributeEqual(5000, "InnerText", RPM_Grantee_WM);
            
            // Performance Report Details
            Report.Log(ReportLevel.Info, "Section", "Performance Report Details", new RecordItemIndex(20));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.NgScope2.PerformanceReportDetails' at 41;11.", repo.Login1.NgScope2.PerformanceReportDetailsInfo, new RecordItemIndex(21));
            repo.Login1.NgScope2.PerformanceReportDetails.Click("41;11");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Performance Report Details') on item 'Login1.FormInlinePanelHeading.PerformanceReportDetails'.", repo.Login1.FormInlinePanelHeading.PerformanceReportDetailsInfo, new RecordItemIndex(22));
            Validate.AttributeEqual(repo.Login1.FormInlinePanelHeading.PerformanceReportDetailsInfo, "InnerText", "Performance Report Details");
            Delay.Milliseconds(100);
            
            // Performance Report Details Table Screenshot
            Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(23));
            
            // Home Button
            Report.Log(ReportLevel.Info, "Mouse", "Home Button\r\nMouse Left Click item 'Login1.NavNavbarNavSamsNavbarNav.HOME' at 12;9.", repo.Login1.NavNavbarNavSamsNavbarNav.HOMEInfo, new RecordItemIndex(24));
            repo.Login1.NavNavbarNavSamsNavbarNav.HOME.Click("12;9");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s for the attribute 'InnerText' to equal the specified value $RPM_Grantee_WM. Associated repository item: 'Login1.HiMonicaGeller'", repo.Login1.HiMonicaGellerInfo, new RecordItemIndex(25));
            repo.Login1.HiMonicaGellerInfo.WaitForAttributeEqual(5000, "InnerText", RPM_Grantee_WM);
            
            // Performance Dashboard
            Report.Log(ReportLevel.Info, "Section", "Performance Dashboard", new RecordItemIndex(26));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.NgScope2.PerformanceDashboard' at 41;11.", repo.Login1.NgScope2.PerformanceDashboardInfo, new RecordItemIndex(27));
            repo.Login1.NgScope2.PerformanceDashboard.Click("41;11");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Performance Report - Submission Status') on item 'Login1.PerformanceReportSubmissionStatus'.", repo.Login1.PerformanceReportSubmissionStatusInfo, new RecordItemIndex(28));
            Validate.AttributeEqual(repo.Login1.PerformanceReportSubmissionStatusInfo, "InnerText", "Performance Report - Submission Status");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Work Plan - Activities Status') on item 'Login1.WorkPlanActivitiesStatus'.", repo.Login1.WorkPlanActivitiesStatusInfo, new RecordItemIndex(29));
            Validate.AttributeEqual(repo.Login1.WorkPlanActivitiesStatusInfo, "InnerText", "Work Plan - Activities Status");
            Delay.Milliseconds(100);
            
            // Performance Dashboard Screenshot
            Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(30));
            
            // Home Button
            Report.Log(ReportLevel.Info, "Mouse", "Home Button\r\nMouse Left Click item 'Login1.NavNavbarNavSamsNavbarNav.HOME' at 12;9.", repo.Login1.NavNavbarNavSamsNavbarNav.HOMEInfo, new RecordItemIndex(31));
            repo.Login1.NavNavbarNavSamsNavbarNav.HOME.Click("12;9");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s for the attribute 'InnerText' to equal the specified value $RPM_Grantee_WM. Associated repository item: 'Login1.HiMonicaGeller'", repo.Login1.HiMonicaGellerInfo, new RecordItemIndex(32));
            repo.Login1.HiMonicaGellerInfo.WaitForAttributeEqual(5000, "InnerText", RPM_Grantee_WM);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
