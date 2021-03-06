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
    ///The R1_03_HomePage_TilesHeader_RPMGrantor_Support recording.
    /// </summary>
    [TestModule("40367529-267b-4309-83c8-352c3e2f8303", ModuleType.Recording, 1)]
    public partial class R1_03_HomePage_TilesHeader_RPMGrantor_Support : ITestModule
    {
        /// <summary>
        /// Holds an instance of the Service_Portal_Regression_TSTRepository repository.
        /// </summary>
        public static Service_Portal_Regression_TSTRepository repo = Service_Portal_Regression_TSTRepository.Instance;

        static R1_03_HomePage_TilesHeader_RPMGrantor_Support instance = new R1_03_HomePage_TilesHeader_RPMGrantor_Support();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public R1_03_HomePage_TilesHeader_RPMGrantor_Support()
        {
            RPM_Grantor_WM = "Hi, Gunther Central-Perk!";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static R1_03_HomePage_TilesHeader_RPMGrantor_Support Instance
        {
            get { return instance; }
        }

#region Variables

        string _RPM_Grantor_WM;

        /// <summary>
        /// Gets or sets the value of variable RPM_Grantor_WM.
        /// </summary>
        [TestVariable("e2f28ddc-5a0f-4dc6-b68e-7e938e1c4631")]
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

            // Header Links
            Report.Log(ReportLevel.Info, "Section", "Header Links", new RecordItemIndex(0));
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating Exists on item 'Login1.NavNavbarNavSamsNavbarNav.ATagSupport'.", repo.Login1.NavNavbarNavSamsNavbarNav.ATagSupportInfo, new RecordItemIndex(1));
                Validate.Exists(repo.Login1.NavNavbarNavSamsNavbarNav.ATagSupportInfo, null, new Validate.Options(){ReportScreenshot=Validate.ResultOption.OnFail});
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(1)); }
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.NavNavbarNavSamsNavbarNav.ATagSupport' at 113;67.", repo.Login1.NavNavbarNavSamsNavbarNav.ATagSupportInfo, new RecordItemIndex(2));
            repo.Login1.NavNavbarNavSamsNavbarNav.ATagSupport.Click("113;67");
            Delay.Milliseconds(200);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (InnerText='Grantor Training Resources') on item 'Login1.NavNavbarNavSamsNavbarNav.GrantorTrainingResources'.", repo.Login1.NavNavbarNavSamsNavbarNav.GrantorTrainingResourcesInfo, new RecordItemIndex(3));
                Validate.AttributeEqual(repo.Login1.NavNavbarNavSamsNavbarNav.GrantorTrainingResourcesInfo, "InnerText", "Grantor Training Resources", null, new Validate.Options(){ReportScreenshot=Validate.ResultOption.OnFail});
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(3)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (InnerText='Grantee Training Resources') on item 'Login1.NavNavbarNavSamsNavbarNav.GranteeTrainingResources'.", repo.Login1.NavNavbarNavSamsNavbarNav.GranteeTrainingResourcesInfo, new RecordItemIndex(4));
                Validate.AttributeEqual(repo.Login1.NavNavbarNavSamsNavbarNav.GranteeTrainingResourcesInfo, "InnerText", "Grantee Training Resources", null, new Validate.Options(){ReportScreenshot=Validate.ResultOption.OnFail});
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(4)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (InnerText='Results Performance Monitoring Grantor Training Resources') on item 'Login1.NavNavbarNavSamsNavbarNav.ResultsPerformanceMonitoringGrantorT'.", repo.Login1.NavNavbarNavSamsNavbarNav.ResultsPerformanceMonitoringGrantorTInfo, new RecordItemIndex(5));
                Validate.AttributeEqual(repo.Login1.NavNavbarNavSamsNavbarNav.ResultsPerformanceMonitoringGrantorTInfo, "InnerText", "Results Performance Monitoring Grantor Training Resources", null, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(5)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating Exists on item 'Login1.NavNavbarNavSamsNavbarNav.ResultsPerformanceMonitoringGranteeT'.", repo.Login1.NavNavbarNavSamsNavbarNav.ResultsPerformanceMonitoringGranteeTInfo, new RecordItemIndex(6));
                Validate.Exists(repo.Login1.NavNavbarNavSamsNavbarNav.ResultsPerformanceMonitoringGranteeTInfo, null, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(6)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating Exists on item 'Login1.NavNavbarNavSamsNavbarNav.Support2'.", repo.Login1.NavNavbarNavSamsNavbarNav.Support2Info, new RecordItemIndex(7));
                Validate.Exists(repo.Login1.NavNavbarNavSamsNavbarNav.Support2Info, null, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(7)); }
            
            // Grantor Training
            Report.Log(ReportLevel.Info, "Section", "Grantor Training", new RecordItemIndex(8));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.NavNavbarNavSamsNavbarNav.GrantorTrainingResources' at 85;24.", repo.Login1.NavNavbarNavSamsNavbarNav.GrantorTrainingResourcesInfo, new RecordItemIndex(9));
            repo.Login1.NavNavbarNavSamsNavbarNav.GrantorTrainingResources.Click("85;24");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking WaitForDocumentLoaded() on item 'Login1'.", repo.Login1.SelfInfo, new RecordItemIndex(10));
            repo.Login1.Self.WaitForDocumentLoaded();
            Delay.Milliseconds(0);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (InnerText='') on item 'Login1.HttpsMygrantstrainServiceNowComDe'.", repo.Login1.HttpsMygrantstrainServiceNowComDeInfo, new RecordItemIndex(11));
                Validate.AttributeEqual(repo.Login1.HttpsMygrantstrainServiceNowComDeInfo, "InnerText", "", null, new Validate.Options(){ReportScreenshot=Validate.ResultOption.OnFail});
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(11)); }
            
            // Grantor Training Screenshot
            Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(12));
            
            // Home Button
            Report.Log(ReportLevel.Info, "Mouse", "Home Button\r\nMouse Left Click item 'Login1.NavNavbarNavSamsNavbarNav.HOME' at 12;9.", repo.Login1.NavNavbarNavSamsNavbarNav.HOMEInfo, new RecordItemIndex(13));
            repo.Login1.NavNavbarNavSamsNavbarNav.HOME.Click("12;9");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s for the attribute 'InnerText' to equal the specified value $RPM_Grantor_WM. Associated repository item: 'Login1.HiGuntherCentralPerk'", repo.Login1.HiGuntherCentralPerkInfo, new RecordItemIndex(14));
            repo.Login1.HiGuntherCentralPerkInfo.WaitForAttributeEqual(5000, "InnerText", RPM_Grantor_WM);
            
            // Grantee Training
            Report.Log(ReportLevel.Info, "Section", "Grantee Training", new RecordItemIndex(15));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.NavNavbarNavSamsNavbarNav.ATagSupport' at 89;66.", repo.Login1.NavNavbarNavSamsNavbarNav.ATagSupportInfo, new RecordItemIndex(16));
            repo.Login1.NavNavbarNavSamsNavbarNav.ATagSupport.Click("89;66");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.NavNavbarNavSamsNavbarNav.GranteeTrainingResources' at 90;23.", repo.Login1.NavNavbarNavSamsNavbarNav.GranteeTrainingResourcesInfo, new RecordItemIndex(17));
            repo.Login1.NavNavbarNavSamsNavbarNav.GranteeTrainingResources.Click("90;23");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking WaitForDocumentLoaded() on item 'Login1'.", repo.Login1.SelfInfo, new RecordItemIndex(18));
            repo.Login1.Self.WaitForDocumentLoaded();
            Delay.Milliseconds(0);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (InnerText='') on item 'Login1.HttpsMygrantstrainServiceNowComDe'.", repo.Login1.HttpsMygrantstrainServiceNowComDeInfo, new RecordItemIndex(19));
                Validate.AttributeEqual(repo.Login1.HttpsMygrantstrainServiceNowComDeInfo, "InnerText", "", null, new Validate.Options(){ReportScreenshot=Validate.ResultOption.OnFail});
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(19)); }
            
            // Grantee Training Screenshot
            Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(20));
            
            // Home Button
            Report.Log(ReportLevel.Info, "Mouse", "Home Button\r\nMouse Left Click item 'Login1.NavNavbarNavSamsNavbarNav.HOME' at 12;9.", repo.Login1.NavNavbarNavSamsNavbarNav.HOMEInfo, new RecordItemIndex(21));
            repo.Login1.NavNavbarNavSamsNavbarNav.HOME.Click("12;9");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s for the attribute 'InnerText' to equal the specified value $RPM_Grantor_WM. Associated repository item: 'Login1.HiGuntherCentralPerk'", repo.Login1.HiGuntherCentralPerkInfo, new RecordItemIndex(22));
            repo.Login1.HiGuntherCentralPerkInfo.WaitForAttributeEqual(5000, "InnerText", RPM_Grantor_WM);
            
            // RPM Grantor Training Resources
            Report.Log(ReportLevel.Info, "Section", "RPM Grantor Training Resources", new RecordItemIndex(23));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.NavNavbarNavSamsNavbarNav.ATagSupport' at 53;38.", repo.Login1.NavNavbarNavSamsNavbarNav.ATagSupportInfo, new RecordItemIndex(24));
            repo.Login1.NavNavbarNavSamsNavbarNav.ATagSupport.Click("53;38");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.NavNavbarNavSamsNavbarNav.ResultsPerformanceMonitoringGrantorT' at 97;14.", repo.Login1.NavNavbarNavSamsNavbarNav.ResultsPerformanceMonitoringGrantorTInfo, new RecordItemIndex(25));
            repo.Login1.NavNavbarNavSamsNavbarNav.ResultsPerformanceMonitoringGrantorT.Click("97;14");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking WaitForDocumentLoaded() on item 'Login1'.", repo.Login1.SelfInfo, new RecordItemIndex(26));
            repo.Login1.Self.WaitForDocumentLoaded();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'Login1.HttpsMygrantstrainServiceNowComDe'.", repo.Login1.HttpsMygrantstrainServiceNowComDeInfo, new RecordItemIndex(27));
            Validate.Exists(repo.Login1.HttpsMygrantstrainServiceNowComDeInfo);
            Delay.Milliseconds(100);
            
            // RPM Grantor Training Screenshot
            Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(28));
            
            // Home Button
            Report.Log(ReportLevel.Info, "Mouse", "Home Button\r\nMouse Left Click item 'Login1.NavNavbarNavSamsNavbarNav.HOME' at 12;9.", repo.Login1.NavNavbarNavSamsNavbarNav.HOMEInfo, new RecordItemIndex(29));
            repo.Login1.NavNavbarNavSamsNavbarNav.HOME.Click("12;9");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s for the attribute 'InnerText' to equal the specified value $RPM_Grantor_WM. Associated repository item: 'Login1.HiGuntherCentralPerk'", repo.Login1.HiGuntherCentralPerkInfo, new RecordItemIndex(30));
            repo.Login1.HiGuntherCentralPerkInfo.WaitForAttributeEqual(5000, "InnerText", RPM_Grantor_WM);
            
            // RPM Grantee Training Resources
            Report.Log(ReportLevel.Info, "Section", "RPM Grantee Training Resources", new RecordItemIndex(31));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.NavNavbarNavSamsNavbarNav.ATagSupport' at 67;46.", repo.Login1.NavNavbarNavSamsNavbarNav.ATagSupportInfo, new RecordItemIndex(32));
            repo.Login1.NavNavbarNavSamsNavbarNav.ATagSupport.Click("67;46");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.NavNavbarNavSamsNavbarNav.ResultsPerformanceMonitoringGranteeT' at 84;15.", repo.Login1.NavNavbarNavSamsNavbarNav.ResultsPerformanceMonitoringGranteeTInfo, new RecordItemIndex(33));
            repo.Login1.NavNavbarNavSamsNavbarNav.ResultsPerformanceMonitoringGranteeT.Click("84;15");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking WaitForDocumentLoaded() on item 'Login1'.", repo.Login1.SelfInfo, new RecordItemIndex(34));
            repo.Login1.Self.WaitForDocumentLoaded();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'Login1.HttpsMygrantstrainServiceNowComDe'.", repo.Login1.HttpsMygrantstrainServiceNowComDeInfo, new RecordItemIndex(35));
            Validate.Exists(repo.Login1.HttpsMygrantstrainServiceNowComDeInfo);
            Delay.Milliseconds(100);
            
            // RPM Grantee Training Screenshot
            Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(36));
            
            // Home Button
            Report.Log(ReportLevel.Info, "Mouse", "Home Button\r\nMouse Left Click item 'Login1.NavNavbarNavSamsNavbarNav.HOME' at 12;9.", repo.Login1.NavNavbarNavSamsNavbarNav.HOMEInfo, new RecordItemIndex(37));
            repo.Login1.NavNavbarNavSamsNavbarNav.HOME.Click("12;9");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s for the attribute 'InnerText' to equal the specified value $RPM_Grantor_WM. Associated repository item: 'Login1.HiGuntherCentralPerk'", repo.Login1.HiGuntherCentralPerkInfo, new RecordItemIndex(38));
            repo.Login1.HiGuntherCentralPerkInfo.WaitForAttributeEqual(5000, "InnerText", RPM_Grantor_WM);
            
            // Support
            Report.Log(ReportLevel.Info, "Section", "Support", new RecordItemIndex(39));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.NavNavbarNavSamsNavbarNav.ATagSupport' at 104;39.", repo.Login1.NavNavbarNavSamsNavbarNav.ATagSupportInfo, new RecordItemIndex(40));
            repo.Login1.NavNavbarNavSamsNavbarNav.ATagSupport.Click("104;39");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.NavNavbarNavSamsNavbarNav.Support2' at 73;21.", repo.Login1.NavNavbarNavSamsNavbarNav.Support2Info, new RecordItemIndex(41));
            repo.Login1.NavNavbarNavSamsNavbarNav.Support2.Click("73;21");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking WaitForDocumentLoaded() on item 'Login1'.", repo.Login1.SelfInfo, new RecordItemIndex(42));
            repo.Login1.Self.WaitForDocumentLoaded();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'Login1.GrantorTrainingResource'.", repo.Login1.GrantorTrainingResourceInfo, new RecordItemIndex(43));
            Validate.Exists(repo.Login1.GrantorTrainingResourceInfo);
            Delay.Milliseconds(0);
            
            // Support Screenshot
            Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(44));
            
            // Home Button
            Report.Log(ReportLevel.Info, "Mouse", "Home Button\r\nMouse Left Click item 'Login1.NavNavbarNavSamsNavbarNav.HOME' at 12;9.", repo.Login1.NavNavbarNavSamsNavbarNav.HOMEInfo, new RecordItemIndex(45));
            repo.Login1.NavNavbarNavSamsNavbarNav.HOME.Click("12;9");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s for the attribute 'InnerText' to equal the specified value $RPM_Grantor_WM. Associated repository item: 'Login1.HiGuntherCentralPerk'", repo.Login1.HiGuntherCentralPerkInfo, new RecordItemIndex(46));
            repo.Login1.HiGuntherCentralPerkInfo.WaitForAttributeEqual(5000, "InnerText", RPM_Grantor_WM);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
