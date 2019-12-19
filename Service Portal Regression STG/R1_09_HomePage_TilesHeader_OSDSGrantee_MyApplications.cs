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
    ///The R1_09_HomePage_TilesHeader_OSDSGrantee_MyApplications recording.
    /// </summary>
    [TestModule("689bc44b-c76b-48f4-a059-76647d86bfa0", ModuleType.Recording, 1)]
    public partial class R1_09_HomePage_TilesHeader_OSDSGrantee_MyApplications : ITestModule
    {
        /// <summary>
        /// Holds an instance of the Service_Portal_Regression_STGRepository repository.
        /// </summary>
        public static Service_Portal_Regression_STGRepository repo = Service_Portal_Regression_STGRepository.Instance;

        static R1_09_HomePage_TilesHeader_OSDSGrantee_MyApplications instance = new R1_09_HomePage_TilesHeader_OSDSGrantee_MyApplications();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public R1_09_HomePage_TilesHeader_OSDSGrantee_MyApplications()
        {
            OSDS_Grantee_WM = "Hi, Ross Geller!";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static R1_09_HomePage_TilesHeader_OSDSGrantee_MyApplications Instance
        {
            get { return instance; }
        }

#region Variables

        string _OSDS_Grantee_WM;

        /// <summary>
        /// Gets or sets the value of variable OSDS_Grantee_WM.
        /// </summary>
        [TestVariable("569a0d43-4337-4be4-ba69-e68fb660266a")]
        public string OSDS_Grantee_WM
        {
            get { return _OSDS_Grantee_WM; }
            set { _OSDS_Grantee_WM = value; }
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
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (InnerText=' My Applications ') on item 'Login1.NavNavbarNavSamsNavbarNav.ATagMyApplications'.", repo.Login1.NavNavbarNavSamsNavbarNav.ATagMyApplicationsInfo, new RecordItemIndex(1));
                Validate.AttributeEqual(repo.Login1.NavNavbarNavSamsNavbarNav.ATagMyApplicationsInfo, "InnerText", " My Applications ", null, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(1)); }
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.NavNavbarNavSamsNavbarNav.ATagMyApplications' at 145;60.", repo.Login1.NavNavbarNavSamsNavbarNav.ATagMyApplicationsInfo, new RecordItemIndex(2));
            repo.Login1.NavNavbarNavSamsNavbarNav.ATagMyApplications.Click("145;60");
            Delay.Milliseconds(200);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (InnerText='My Applications') on item 'Login1.NavNavbarNavSamsNavbarNav.MyApplications'.", repo.Login1.NavNavbarNavSamsNavbarNav.MyApplicationsInfo, new RecordItemIndex(3));
                Validate.AttributeEqual(repo.Login1.NavNavbarNavSamsNavbarNav.MyApplicationsInfo, "InnerText", "My Applications", null, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(3)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (InnerText='My Organizations Applications') on item 'Login1.NavNavbarNavSamsNavbarNav.MyOrganizationsApplications'.", repo.Login1.NavNavbarNavSamsNavbarNav.MyOrganizationsApplicationsInfo, new RecordItemIndex(4));
                Validate.AttributeEqual(repo.Login1.NavNavbarNavSamsNavbarNav.MyOrganizationsApplicationsInfo, "InnerText", "My Organizations Applications", null, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(4)); }
            
            // MyApplication Screenshot
            Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(5));
            
            // My Applications
            Report.Log(ReportLevel.Info, "Section", "My Applications", new RecordItemIndex(6));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.NavNavbarNavSamsNavbarNav.MyApplications' at 74;3.", repo.Login1.NavNavbarNavSamsNavbarNav.MyApplicationsInfo, new RecordItemIndex(7));
            repo.Login1.NavNavbarNavSamsNavbarNav.MyApplications.Click("74;3");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking WaitForDocumentLoaded() on item 'Login1'.", repo.Login1.SelfInfo, new RecordItemIndex(8));
            repo.Login1.Self.WaitForDocumentLoaded();
            Delay.Milliseconds(0);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (InnerText='Applications') on item 'Login1.FormInlinePanelHeading.Applications'.", repo.Login1.FormInlinePanelHeading.ApplicationsInfo, new RecordItemIndex(9));
                Validate.AttributeEqual(repo.Login1.FormInlinePanelHeading.ApplicationsInfo, "InnerText", "Applications", null, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(9)); }
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking WaitForDocumentLoaded() on item 'Login1'.", repo.Login1.SelfInfo, new RecordItemIndex(10));
            repo.Login1.Self.WaitForDocumentLoaded();
            Delay.Milliseconds(0);
            
            // My Application Table Screenshot
            Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(11));
            
            // Home Button
            Report.Log(ReportLevel.Info, "Mouse", "Home Button\r\nMouse Left Click item 'Login1.NavNavbarNavSamsNavbarNav.HOME' at 12;9.", repo.Login1.NavNavbarNavSamsNavbarNav.HOMEInfo, new RecordItemIndex(12));
            repo.Login1.NavNavbarNavSamsNavbarNav.HOME.Click("12;9");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s for the attribute 'InnerText' to equal the specified value $OSDS_Grantee_WM. Associated repository item: 'Login1.HiRossGeller'", repo.Login1.HiRossGellerInfo, new RecordItemIndex(13));
            repo.Login1.HiRossGellerInfo.WaitForAttributeEqual(5000, "InnerText", OSDS_Grantee_WM);
            
            // My Organizations Applications
            Report.Log(ReportLevel.Info, "Section", "My Organizations Applications", new RecordItemIndex(14));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.NavNavbarNavSamsNavbarNav.ATagMyApplications' at 147;63.", repo.Login1.NavNavbarNavSamsNavbarNav.ATagMyApplicationsInfo, new RecordItemIndex(15));
            repo.Login1.NavNavbarNavSamsNavbarNav.ATagMyApplications.Click("147;63");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.NavNavbarNavSamsNavbarNav.MyOrganizationsApplications' at 98;15.", repo.Login1.NavNavbarNavSamsNavbarNav.MyOrganizationsApplicationsInfo, new RecordItemIndex(16));
            repo.Login1.NavNavbarNavSamsNavbarNav.MyOrganizationsApplications.Click("98;15");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking WaitForDocumentLoaded() on item 'Login1'.", repo.Login1.SelfInfo, new RecordItemIndex(17));
            repo.Login1.Self.WaitForDocumentLoaded();
            Delay.Milliseconds(0);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (InnerText='Applications') on item 'Login1.FormInlinePanelHeading.Applications'.", repo.Login1.FormInlinePanelHeading.ApplicationsInfo, new RecordItemIndex(18));
                Validate.AttributeEqual(repo.Login1.FormInlinePanelHeading.ApplicationsInfo, "InnerText", "Applications", null, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(18)); }
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking WaitForDocumentLoaded() on item 'Login1'.", repo.Login1.SelfInfo, new RecordItemIndex(19));
            repo.Login1.Self.WaitForDocumentLoaded();
            Delay.Milliseconds(0);
            
            // My Organizations Applications Table Screenshot
            Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(20));
            
            // Home Button
            Report.Log(ReportLevel.Info, "Mouse", "Home Button\r\nMouse Left Click item 'Login1.NavNavbarNavSamsNavbarNav.HOME' at 12;9.", repo.Login1.NavNavbarNavSamsNavbarNav.HOMEInfo, new RecordItemIndex(21));
            repo.Login1.NavNavbarNavSamsNavbarNav.HOME.Click("12;9");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s for the attribute 'InnerText' to equal the specified value $OSDS_Grantee_WM. Associated repository item: 'Login1.HiRossGeller'", repo.Login1.HiRossGellerInfo, new RecordItemIndex(22));
            repo.Login1.HiRossGellerInfo.WaitForAttributeEqual(5000, "InnerText", OSDS_Grantee_WM);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
