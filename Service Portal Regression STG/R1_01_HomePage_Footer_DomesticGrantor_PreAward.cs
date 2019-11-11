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
    ///The R1_01_HomePage_Footer_DomesticGrantor_PreAward recording.
    /// </summary>
    [TestModule("42afc825-6231-4bdf-bad7-2f499f969d9e", ModuleType.Recording, 1)]
    public partial class R1_01_HomePage_Footer_DomesticGrantor_PreAward : ITestModule
    {
        /// <summary>
        /// Holds an instance of the Service_Portal_Regression_TSTRepository repository.
        /// </summary>
        public static Service_Portal_Regression_TSTRepository repo = Service_Portal_Regression_TSTRepository.Instance;

        static R1_01_HomePage_Footer_DomesticGrantor_PreAward instance = new R1_01_HomePage_Footer_DomesticGrantor_PreAward();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public R1_01_HomePage_Footer_DomesticGrantor_PreAward()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static R1_01_HomePage_Footer_DomesticGrantor_PreAward Instance
        {
            get { return instance; }
        }

#region Variables

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
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking WaitForDocumentLoaded() on item 'Login1'.", repo.Login1.SelfInfo, new RecordItemIndex(1));
            repo.Login1.Self.WaitForDocumentLoaded();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -840 units.", new RecordItemIndex(2));
            Mouse.ScrollWheel(-840);
            Delay.Milliseconds(500);
            
            // Footer - Pre-Award
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nFooter - Pre-Award\r\nValidating AttributeEqual (InnerText='Pre-award') on item 'Login1.Footer_Pre_Award.PreAward'.", repo.Login1.Footer_Pre_Award.PreAwardInfo, new RecordItemIndex(3));
                Validate.AttributeEqual(repo.Login1.Footer_Pre_Award.PreAwardInfo, "InnerText", "Pre-award", null, new Validate.Options(){ReportScreenshot=Validate.ResultOption.OnFail});
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(3)); }
            
            // Footer - FO
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nFooter - FO\r\nValidating AttributeEqual (InnerText='Funding Opportunities') on item 'Login1.Footer_Pre_Award.FundingOpportunities'.", repo.Login1.Footer_Pre_Award.FundingOpportunitiesInfo, new RecordItemIndex(4));
                Validate.AttributeEqual(repo.Login1.Footer_Pre_Award.FundingOpportunitiesInfo, "InnerText", "Funding Opportunities", null, new Validate.Options(){ReportScreenshot=Validate.ResultOption.OnFail});
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(4)); }
            
            // Footer - Application
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nFooter - Application\r\nValidating AttributeEqual (InnerText='Applications') on item 'Login1.Footer_Pre_Award.Applications'.", repo.Login1.Footer_Pre_Award.ApplicationsInfo, new RecordItemIndex(5));
                Validate.AttributeEqual(repo.Login1.Footer_Pre_Award.ApplicationsInfo, "InnerText", "Applications", null, new Validate.Options(){ReportScreenshot=Validate.ResultOption.OnFail});
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(5)); }
            
            // Footer - FP
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nFooter - FP\r\nValidating AttributeEqual (InnerText='Funding Packages') on item 'Login1.Footer_Pre_Award.FundingPackages'.", repo.Login1.Footer_Pre_Award.FundingPackagesInfo, new RecordItemIndex(6));
                Validate.AttributeEqual(repo.Login1.Footer_Pre_Award.FundingPackagesInfo, "InnerText", "Funding Packages", null, new Validate.Options(){ReportScreenshot=Validate.ResultOption.OnFail});
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(6)); }
            
            // Pre-Award Screenshot
            Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(7));
            
            // Funding Opportunity
            Report.Log(ReportLevel.Info, "Section", "Funding Opportunity", new RecordItemIndex(8));
            
            // Footer - FO
            Report.Log(ReportLevel.Info, "Mouse", "Footer - FO\r\nMouse Left Click item 'Login1.Footer_Pre_Award.FundingOpportunities' at 34;7.", repo.Login1.Footer_Pre_Award.FundingOpportunitiesInfo, new RecordItemIndex(9));
            repo.Login1.Footer_Pre_Award.FundingOpportunities.Click("34;7");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking WaitForDocumentLoaded() on item 'Login1'.", repo.Login1.SelfInfo, new RecordItemIndex(10));
            repo.Login1.Self.WaitForDocumentLoaded();
            Delay.Milliseconds(0);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (InnerText='Funding Opportunities') on item 'Login1.FormInlinePanelHeading.FundingOpportunities'.", repo.Login1.FormInlinePanelHeading.FundingOpportunitiesInfo, new RecordItemIndex(11));
                Validate.AttributeEqual(repo.Login1.FormInlinePanelHeading.FundingOpportunitiesInfo, "InnerText", "Funding Opportunities", null, new Validate.Options(){ReportScreenshot=Validate.ResultOption.OnFail});
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(11)); }
            
            // FO Table Screenshot
            Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(12));
            
            // Home Button
            Report.Log(ReportLevel.Info, "Mouse", "Home Button\r\nMouse Left Click item 'Login1.NavNavbarNavSamsNavbarNav.HOME' at 12;9.", repo.Login1.NavNavbarNavSamsNavbarNav.HOMEInfo, new RecordItemIndex(13));
            repo.Login1.NavNavbarNavSamsNavbarNav.HOME.Click("12;9");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s for the attribute 'InnerText' to equal the specified value 'Hi, Joey Tribbiani!'. Associated repository item: 'Login1.HiJoeyTribbiani'", repo.Login1.HiJoeyTribbianiInfo, new RecordItemIndex(14));
            repo.Login1.HiJoeyTribbianiInfo.WaitForAttributeEqual(5000, "InnerText", "Hi, Joey Tribbiani!");
            
            // Application
            Report.Log(ReportLevel.Info, "Section", "Application", new RecordItemIndex(15));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -840 units.", new RecordItemIndex(16));
            Mouse.ScrollWheel(-840);
            Delay.Milliseconds(500);
            
            // Footer - Application
            Report.Log(ReportLevel.Info, "Mouse", "Footer - Application\r\nMouse Left Click item 'Login1.Footer_Pre_Award.Applications' at 70;14.", repo.Login1.Footer_Pre_Award.ApplicationsInfo, new RecordItemIndex(17));
            repo.Login1.Footer_Pre_Award.Applications.Click("70;14");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking WaitForDocumentLoaded() on item 'Login1'.", repo.Login1.SelfInfo, new RecordItemIndex(18));
            repo.Login1.Self.WaitForDocumentLoaded();
            Delay.Milliseconds(0);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (InnerText='Applications') on item 'Login1.FormInlinePanelHeading.Applications'.", repo.Login1.FormInlinePanelHeading.ApplicationsInfo, new RecordItemIndex(19));
                Validate.AttributeEqual(repo.Login1.FormInlinePanelHeading.ApplicationsInfo, "InnerText", "Applications", null, new Validate.Options(){ReportScreenshot=Validate.ResultOption.OnFail});
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(19)); }
            
            // Application Table Screenshot
            Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(20));
            
            // Home Button
            Report.Log(ReportLevel.Info, "Mouse", "Home Button\r\nMouse Left Click item 'Login1.NavNavbarNavSamsNavbarNav.HOME' at 12;9.", repo.Login1.NavNavbarNavSamsNavbarNav.HOMEInfo, new RecordItemIndex(21));
            repo.Login1.NavNavbarNavSamsNavbarNav.HOME.Click("12;9");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s for the attribute 'InnerText' to equal the specified value 'Hi, Joey Tribbiani!'. Associated repository item: 'Login1.HiJoeyTribbiani'", repo.Login1.HiJoeyTribbianiInfo, new RecordItemIndex(22));
            repo.Login1.HiJoeyTribbianiInfo.WaitForAttributeEqual(5000, "InnerText", "Hi, Joey Tribbiani!");
            
            // Funding Package
            Report.Log(ReportLevel.Info, "Section", "Funding Package", new RecordItemIndex(23));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -840 units.", new RecordItemIndex(24));
            Mouse.ScrollWheel(-840);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.Footer_Pre_Award.FundingPackages' at 70;14.", repo.Login1.Footer_Pre_Award.FundingPackagesInfo, new RecordItemIndex(25));
            repo.Login1.Footer_Pre_Award.FundingPackages.Click("70;14");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking WaitForDocumentLoaded() on item 'Login1'.", repo.Login1.SelfInfo, new RecordItemIndex(26));
            repo.Login1.Self.WaitForDocumentLoaded();
            Delay.Milliseconds(0);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (InnerText='Funding Packages') on item 'Login1.FormInlinePanelHeading.FundingPackages'.", repo.Login1.FormInlinePanelHeading.FundingPackagesInfo, new RecordItemIndex(27));
                Validate.AttributeEqual(repo.Login1.FormInlinePanelHeading.FundingPackagesInfo, "InnerText", "Funding Packages", null, new Validate.Options(){ReportScreenshot=Validate.ResultOption.OnFail});
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(27)); }
            
            // FP Table Screenshot
            Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(28));
            
            // Home Button
            Report.Log(ReportLevel.Info, "Mouse", "Home Button\r\nMouse Left Click item 'Login1.NavNavbarNavSamsNavbarNav.HOME' at 12;9.", repo.Login1.NavNavbarNavSamsNavbarNav.HOMEInfo, new RecordItemIndex(29));
            repo.Login1.NavNavbarNavSamsNavbarNav.HOME.Click("12;9");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s for the attribute 'InnerText' to equal the specified value 'Hi, Joey Tribbiani!'. Associated repository item: 'Login1.HiJoeyTribbiani'", repo.Login1.HiJoeyTribbianiInfo, new RecordItemIndex(30));
            repo.Login1.HiJoeyTribbianiInfo.WaitForAttributeEqual(5000, "InnerText", "Hi, Joey Tribbiani!");
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -240 units.", new RecordItemIndex(31));
            Mouse.ScrollWheel(-240);
            Delay.Milliseconds(500);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}