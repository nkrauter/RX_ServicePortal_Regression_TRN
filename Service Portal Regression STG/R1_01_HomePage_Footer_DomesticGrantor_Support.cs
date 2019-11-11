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
    ///The R1_01_HomePage_Footer_DomesticGrantor_Support recording.
    /// </summary>
    [TestModule("81f3395c-00a6-445c-9216-cc28d35ccf96", ModuleType.Recording, 1)]
    public partial class R1_01_HomePage_Footer_DomesticGrantor_Support : ITestModule
    {
        /// <summary>
        /// Holds an instance of the Service_Portal_Regression_TSTRepository repository.
        /// </summary>
        public static Service_Portal_Regression_TSTRepository repo = Service_Portal_Regression_TSTRepository.Instance;

        static R1_01_HomePage_Footer_DomesticGrantor_Support instance = new R1_01_HomePage_Footer_DomesticGrantor_Support();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public R1_01_HomePage_Footer_DomesticGrantor_Support()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static R1_01_HomePage_Footer_DomesticGrantor_Support Instance
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
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -840 units.", new RecordItemIndex(1));
            Mouse.ScrollWheel(-840);
            Delay.Milliseconds(500);
            
            // Footer - Support
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nFooter - Support\r\nValidating AttributeEqual (InnerText='Support') on item 'Login.NgScope4.Support'.", repo.Login.NgScope4.SupportInfo, new RecordItemIndex(2));
                Validate.AttributeEqual(repo.Login.NgScope4.SupportInfo, "InnerText", "Support", null, new Validate.Options(){ReportScreenshot=Validate.ResultOption.OnFail});
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(2)); }
            
            // Footer - Grantor Training
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nFooter - Grantor Training\r\nValidating AttributeEqual (InnerText='Grantor Training Resources') on item 'Login.NgScope4.GrantorTrainingResources'.", repo.Login.NgScope4.GrantorTrainingResourcesInfo, new RecordItemIndex(3));
                Validate.AttributeEqual(repo.Login.NgScope4.GrantorTrainingResourcesInfo, "InnerText", "Grantor Training Resources", null, new Validate.Options(){ReportScreenshot=Validate.ResultOption.OnFail});
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(3)); }
            
            // Footer - Grantee Training
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nFooter - Grantee Training\r\nValidating AttributeEqual (InnerText='Grantee Training Resources') on item 'Login.NgScope4.GranteeTrainingResources'.", repo.Login.NgScope4.GranteeTrainingResourcesInfo, new RecordItemIndex(4));
                Validate.AttributeEqual(repo.Login.NgScope4.GranteeTrainingResourcesInfo, "InnerText", "Grantee Training Resources", null, new Validate.Options(){ReportScreenshot=Validate.ResultOption.OnFail});
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(4)); }
            
            // Footer - Support
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nFooter - Support\r\nValidating AttributeEqual (InnerText='Support') on item 'Login.NgScope4.Support1'.", repo.Login.NgScope4.Support1Info, new RecordItemIndex(5));
                Validate.AttributeEqual(repo.Login.NgScope4.Support1Info, "InnerText", "Support", null, new Validate.Options(){ReportScreenshot=Validate.ResultOption.OnFail});
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(5)); }
            
            // Grantor Training Resources
            Report.Log(ReportLevel.Info, "Section", "Grantor Training Resources", new RecordItemIndex(6));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login.NgScope4.GrantorTrainingResources' at 70;14.", repo.Login.NgScope4.GrantorTrainingResourcesInfo, new RecordItemIndex(7));
            repo.Login.NgScope4.GrantorTrainingResources.Click("70;14");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking WaitForDocumentLoaded() on item 'Login'.", repo.Login.SelfInfo, new RecordItemIndex(8));
            repo.Login.Self.WaitForDocumentLoaded();
            Delay.Milliseconds(0);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating Exists on item 'Login.HttpsMygrantstestServiceNowComDef'.", repo.Login.HttpsMygrantstestServiceNowComDefInfo, new RecordItemIndex(9));
                Validate.Exists(repo.Login.HttpsMygrantstestServiceNowComDefInfo, null, new Validate.Options(){ReportScreenshot=Validate.ResultOption.OnFail});
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(9)); }
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking WaitForDocumentLoaded() on item 'Login'.", repo.Login.SelfInfo, new RecordItemIndex(10));
            repo.Login.Self.WaitForDocumentLoaded();
            Delay.Milliseconds(0);
            
            // Grantor Training Resources Screenshot
            Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(11));
            
            // Home Button
            Report.Log(ReportLevel.Info, "Mouse", "Home Button\r\nMouse Left Click item 'Login.NavNavbarNavSamsNavbarNav.ATagHome' at 71;63.", repo.Login.NavNavbarNavSamsNavbarNav.ATagHomeInfo, new RecordItemIndex(12));
            repo.Login.NavNavbarNavSamsNavbarNav.ATagHome.Click("71;63");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s for the attribute 'InnerText' to equal the specified value 'Hi, Joey Tribbiani!'. Associated repository item: 'Login.HiJoeyTribbiani'", repo.Login.HiJoeyTribbianiInfo, new RecordItemIndex(13));
            repo.Login.HiJoeyTribbianiInfo.WaitForAttributeEqual(5000, "InnerText", "Hi, Joey Tribbiani!");
            
            // Grantee Training Resources
            Report.Log(ReportLevel.Info, "Section", "Grantee Training Resources", new RecordItemIndex(14));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -840 units.", new RecordItemIndex(15));
            Mouse.ScrollWheel(-840);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login.NgScope4.GranteeTrainingResources' at 70;14.", repo.Login.NgScope4.GranteeTrainingResourcesInfo, new RecordItemIndex(16));
            repo.Login.NgScope4.GranteeTrainingResources.Click("70;14");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking WaitForDocumentLoaded() on item 'Login'.", repo.Login.SelfInfo, new RecordItemIndex(17));
            repo.Login.Self.WaitForDocumentLoaded();
            Delay.Milliseconds(0);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating Exists on item 'Login.HttpsMygrantstestServiceNowComDef'.", repo.Login.HttpsMygrantstestServiceNowComDefInfo, new RecordItemIndex(18));
                Validate.Exists(repo.Login.HttpsMygrantstestServiceNowComDefInfo, null, new Validate.Options(){ReportScreenshot=Validate.ResultOption.OnFail});
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(18)); }
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking WaitForDocumentLoaded() on item 'Login'.", repo.Login.SelfInfo, new RecordItemIndex(19));
            repo.Login.Self.WaitForDocumentLoaded();
            Delay.Milliseconds(0);
            
            // Grantee Training Resources Screenshot
            Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(20));
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking WaitForDocumentLoaded() on item 'Login'.", repo.Login.SelfInfo, new RecordItemIndex(21));
            repo.Login.Self.WaitForDocumentLoaded();
            Delay.Milliseconds(0);
            
            // Home Button
            Report.Log(ReportLevel.Info, "Mouse", "Home Button\r\nMouse Left Click item 'Login.NavNavbarNavSamsNavbarNav.ATagHome' at 62;63.", repo.Login.NavNavbarNavSamsNavbarNav.ATagHomeInfo, new RecordItemIndex(22));
            repo.Login.NavNavbarNavSamsNavbarNav.ATagHome.Click("62;63");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s for the attribute 'InnerText' to equal the specified value 'Hi, Joey Tribbiani!'. Associated repository item: 'Login.HiJoeyTribbiani'", repo.Login.HiJoeyTribbianiInfo, new RecordItemIndex(23));
            repo.Login.HiJoeyTribbianiInfo.WaitForAttributeEqual(5000, "InnerText", "Hi, Joey Tribbiani!");
            
            // Support
            Report.Log(ReportLevel.Info, "Section", "Support", new RecordItemIndex(24));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -840 units.", new RecordItemIndex(25));
            Mouse.ScrollWheel(-840);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login.NgScope4.Support1' at 70;14.", repo.Login.NgScope4.Support1Info, new RecordItemIndex(26));
            repo.Login.NgScope4.Support1.Click("70;14");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking WaitForDocumentLoaded() on item 'Login'.", repo.Login.SelfInfo, new RecordItemIndex(27));
            repo.Login.Self.WaitForDocumentLoaded();
            Delay.Milliseconds(0);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (InnerText='Grantee Support Page') on item 'Login.GranteeSupportPage'.", repo.Login.GranteeSupportPageInfo, new RecordItemIndex(28));
                Validate.AttributeEqual(repo.Login.GranteeSupportPageInfo, "InnerText", "Grantee Support Page", null, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(28)); }
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking WaitForDocumentLoaded() on item 'Login'.", repo.Login.SelfInfo, new RecordItemIndex(29));
            repo.Login.Self.WaitForDocumentLoaded();
            Delay.Milliseconds(0);
            
            // Support Screenshot
            Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(30));
            
            // Home Button
            Report.Log(ReportLevel.Info, "Mouse", "Home Button\r\nMouse Left Click item 'Login.NavNavbarNavSamsNavbarNav.ATagHome' at 62;63.", repo.Login.NavNavbarNavSamsNavbarNav.ATagHomeInfo, new RecordItemIndex(31));
            repo.Login.NavNavbarNavSamsNavbarNav.ATagHome.Click("62;63");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s for the attribute 'InnerText' to equal the specified value 'Hi, Joey Tribbiani!'. Associated repository item: 'Login.HiJoeyTribbiani'", repo.Login.HiJoeyTribbianiInfo, new RecordItemIndex(32));
            repo.Login.HiJoeyTribbianiInfo.WaitForAttributeEqual(5000, "InnerText", "Hi, Joey Tribbiani!");
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
