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
    ///The R1_05_HomePage_TilesHeader_RPMAdmin_PreAward recording.
    /// </summary>
    [TestModule("11b3fca3-b6ae-4001-a7ac-d8935466a5cf", ModuleType.Recording, 1)]
    public partial class R1_05_HomePage_TilesHeader_RPMAdmin_PreAward : ITestModule
    {
        /// <summary>
        /// Holds an instance of the Service_Portal_Regression_STGRepository repository.
        /// </summary>
        public static Service_Portal_Regression_STGRepository repo = Service_Portal_Regression_STGRepository.Instance;

        static R1_05_HomePage_TilesHeader_RPMAdmin_PreAward instance = new R1_05_HomePage_TilesHeader_RPMAdmin_PreAward();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public R1_05_HomePage_TilesHeader_RPMAdmin_PreAward()
        {
            RPM_Admin_WM = "Hi, Chandler Bing!";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static R1_05_HomePage_TilesHeader_RPMAdmin_PreAward Instance
        {
            get { return instance; }
        }

#region Variables

        string _RPM_Admin_WM;

        /// <summary>
        /// Gets or sets the value of variable RPM_Admin_WM.
        /// </summary>
        [TestVariable("7d6e5b50-7963-40e8-a5d0-a1b370e91308")]
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
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (InnerText=' Pre-award ') on item 'Login1.NavNavbarNavSamsNavbarNav.ATagPreAward'.", repo.Login1.NavNavbarNavSamsNavbarNav.ATagPreAwardInfo, new RecordItemIndex(1));
                Validate.AttributeEqual(repo.Login1.NavNavbarNavSamsNavbarNav.ATagPreAwardInfo, "InnerText", " Pre-award ", null, new Validate.Options(){ReportScreenshot=Validate.ResultOption.OnFail});
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(1)); }
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.NavNavbarNavSamsNavbarNav.ATagPreAward' at 89;54.", repo.Login1.NavNavbarNavSamsNavbarNav.ATagPreAwardInfo, new RecordItemIndex(2));
            repo.Login1.NavNavbarNavSamsNavbarNav.ATagPreAward.Click("89;54");
            Delay.Milliseconds(200);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (InnerText='Funding Opportunities') on item 'Login1.NavNavbarNavSamsNavbarNav.FundingOpportunities'.", repo.Login1.NavNavbarNavSamsNavbarNav.FundingOpportunitiesInfo, new RecordItemIndex(3));
                Validate.AttributeEqual(repo.Login1.NavNavbarNavSamsNavbarNav.FundingOpportunitiesInfo, "InnerText", "Funding Opportunities", null, new Validate.Options(){ReportScreenshot=Validate.ResultOption.OnFail});
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(3)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (InnerText='Applications') on item 'Login1.NavNavbarNavSamsNavbarNav.Applications'.", repo.Login1.NavNavbarNavSamsNavbarNav.ApplicationsInfo, new RecordItemIndex(4));
                Validate.AttributeEqual(repo.Login1.NavNavbarNavSamsNavbarNav.ApplicationsInfo, "InnerText", "Applications", null, new Validate.Options(){ReportScreenshot=Validate.ResultOption.OnFail});
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(4)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (InnerText='Funding Packages') on item 'Login1.NavNavbarNavSamsNavbarNav.FundingPackages'.", repo.Login1.NavNavbarNavSamsNavbarNav.FundingPackagesInfo, new RecordItemIndex(5));
                Validate.AttributeEqual(repo.Login1.NavNavbarNavSamsNavbarNav.FundingPackagesInfo, "InnerText", "Funding Packages", null, new Validate.Options(){ReportScreenshot=Validate.ResultOption.OnFail});
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(5)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (InnerText='Proposals') on item 'Login1.NavNavbarNavSamsNavbarNav.Proposals2'.", repo.Login1.NavNavbarNavSamsNavbarNav.Proposals2Info, new RecordItemIndex(6));
                Validate.AttributeEqual(repo.Login1.NavNavbarNavSamsNavbarNav.Proposals2Info, "InnerText", "Proposals", null, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(6)); }
            
            // Pre-Award Screenshot
            Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(7));
            
            // Funding Opportunity
            Report.Log(ReportLevel.Info, "Section", "Funding Opportunity", new RecordItemIndex(8));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.NavNavbarNavSamsNavbarNav.FundingOpportunities' at 93;24.", repo.Login1.NavNavbarNavSamsNavbarNav.FundingOpportunitiesInfo, new RecordItemIndex(9));
            repo.Login1.NavNavbarNavSamsNavbarNav.FundingOpportunities.Click("93;24");
            Delay.Milliseconds(0);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (InnerText='Funding Opportunities') on item 'Login1.FormInlinePanelHeading.FundingOpportunities'.", repo.Login1.FormInlinePanelHeading.FundingOpportunitiesInfo, new RecordItemIndex(10));
                Validate.AttributeEqual(repo.Login1.FormInlinePanelHeading.FundingOpportunitiesInfo, "InnerText", "Funding Opportunities", null, new Validate.Options(){ReportScreenshot=Validate.ResultOption.OnFail});
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(10)); }
            
            // FO Table Screenshot
            Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(11));
            
            // Home Button
            Report.Log(ReportLevel.Info, "Mouse", "Home Button\r\nMouse Left Click item 'Login1.NavNavbarNavSamsNavbarNav.HOME' at 12;9.", repo.Login1.NavNavbarNavSamsNavbarNav.HOMEInfo, new RecordItemIndex(12));
            repo.Login1.NavNavbarNavSamsNavbarNav.HOME.Click("12;9");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s for the attribute 'InnerText' to equal the specified value $RPM_Admin_WM. Associated repository item: 'Login1.HiChandlerBing'", repo.Login1.HiChandlerBingInfo, new RecordItemIndex(13));
            repo.Login1.HiChandlerBingInfo.WaitForAttributeEqual(5000, "InnerText", RPM_Admin_WM);
            
            // Application
            Report.Log(ReportLevel.Info, "Section", "Application", new RecordItemIndex(14));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.NavNavbarNavSamsNavbarNav.ATagPreAward' at 97;57.", repo.Login1.NavNavbarNavSamsNavbarNav.ATagPreAwardInfo, new RecordItemIndex(15));
            repo.Login1.NavNavbarNavSamsNavbarNav.ATagPreAward.Click("97;57");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.NavNavbarNavSamsNavbarNav.Applications' at 112;20.", repo.Login1.NavNavbarNavSamsNavbarNav.ApplicationsInfo, new RecordItemIndex(16));
            repo.Login1.NavNavbarNavSamsNavbarNav.Applications.Click("112;20");
            Delay.Milliseconds(200);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (InnerText='Applications') on item 'Login1.FormInlinePanelHeading.Applications'.", repo.Login1.FormInlinePanelHeading.ApplicationsInfo, new RecordItemIndex(17));
                Validate.AttributeEqual(repo.Login1.FormInlinePanelHeading.ApplicationsInfo, "InnerText", "Applications", null, new Validate.Options(){ReportScreenshot=Validate.ResultOption.OnFail});
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(17)); }
            
            // Application Table Screenshot
            Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(18));
            
            // Home Button
            Report.Log(ReportLevel.Info, "Mouse", "Home Button\r\nMouse Left Click item 'Login1.NavNavbarNavSamsNavbarNav.HOME' at 12;9.", repo.Login1.NavNavbarNavSamsNavbarNav.HOMEInfo, new RecordItemIndex(19));
            repo.Login1.NavNavbarNavSamsNavbarNav.HOME.Click("12;9");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s for the attribute 'InnerText' to equal the specified value $RPM_Admin_WM. Associated repository item: 'Login1.HiChandlerBing'", repo.Login1.HiChandlerBingInfo, new RecordItemIndex(20));
            repo.Login1.HiChandlerBingInfo.WaitForAttributeEqual(5000, "InnerText", RPM_Admin_WM);
            
            // Funding Package
            Report.Log(ReportLevel.Info, "Section", "Funding Package", new RecordItemIndex(21));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.NavNavbarNavSamsNavbarNav.ATagPreAward' at 127;51.", repo.Login1.NavNavbarNavSamsNavbarNav.ATagPreAwardInfo, new RecordItemIndex(22));
            repo.Login1.NavNavbarNavSamsNavbarNav.ATagPreAward.Click("127;51");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.NavNavbarNavSamsNavbarNav.FundingPackages' at 67;10.", repo.Login1.NavNavbarNavSamsNavbarNav.FundingPackagesInfo, new RecordItemIndex(23));
            repo.Login1.NavNavbarNavSamsNavbarNav.FundingPackages.Click("67;10");
            Delay.Milliseconds(200);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (InnerText='Funding Packages') on item 'Login1.FormInlinePanelHeading.FundingPackages'.", repo.Login1.FormInlinePanelHeading.FundingPackagesInfo, new RecordItemIndex(24));
                Validate.AttributeEqual(repo.Login1.FormInlinePanelHeading.FundingPackagesInfo, "InnerText", "Funding Packages", null, new Validate.Options(){ReportScreenshot=Validate.ResultOption.OnFail});
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(24)); }
            
            // FP Table Screenshot
            Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(25));
            
            // Home Button
            Report.Log(ReportLevel.Info, "Mouse", "Home Button\r\nMouse Left Click item 'Login1.NavNavbarNavSamsNavbarNav.HOME' at 12;9.", repo.Login1.NavNavbarNavSamsNavbarNav.HOMEInfo, new RecordItemIndex(26));
            repo.Login1.NavNavbarNavSamsNavbarNav.HOME.Click("12;9");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s for the attribute 'InnerText' to equal the specified value $RPM_Admin_WM. Associated repository item: 'Login1.HiChandlerBing'", repo.Login1.HiChandlerBingInfo, new RecordItemIndex(27));
            repo.Login1.HiChandlerBingInfo.WaitForAttributeEqual(5000, "InnerText", RPM_Admin_WM);
            
            // Proposal
            Report.Log(ReportLevel.Info, "Section", "Proposal", new RecordItemIndex(28));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.NavNavbarNavSamsNavbarNav.ATagPreAward' at 85;48.", repo.Login1.NavNavbarNavSamsNavbarNav.ATagPreAwardInfo, new RecordItemIndex(29));
            repo.Login1.NavNavbarNavSamsNavbarNav.ATagPreAward.Click("85;48");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.NavNavbarNavSamsNavbarNav.Proposals2' at 50;12.", repo.Login1.NavNavbarNavSamsNavbarNav.Proposals2Info, new RecordItemIndex(30));
            repo.Login1.NavNavbarNavSamsNavbarNav.Proposals2.Click("50;12");
            Delay.Milliseconds(200);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (InnerText='Proposals') on item 'Login1.FormInlinePanelHeading.Proposals'.", repo.Login1.FormInlinePanelHeading.ProposalsInfo, new RecordItemIndex(31));
                Validate.AttributeEqual(repo.Login1.FormInlinePanelHeading.ProposalsInfo, "InnerText", "Proposals", null, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(31)); }
            
            // Proposal Table Screenshot
            Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(32));
            
            // Home Button
            Report.Log(ReportLevel.Info, "Mouse", "Home Button\r\nMouse Left Click item 'Login1.NavNavbarNavSamsNavbarNav.HOME' at 12;9.", repo.Login1.NavNavbarNavSamsNavbarNav.HOMEInfo, new RecordItemIndex(33));
            repo.Login1.NavNavbarNavSamsNavbarNav.HOME.Click("12;9");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s for the attribute 'InnerText' to equal the specified value $RPM_Admin_WM. Associated repository item: 'Login1.HiChandlerBing'", repo.Login1.HiChandlerBingInfo, new RecordItemIndex(34));
            repo.Login1.HiChandlerBingInfo.WaitForAttributeEqual(5000, "InnerText", RPM_Admin_WM);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
