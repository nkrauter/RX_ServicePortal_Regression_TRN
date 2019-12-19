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
    ///The R1_04_HomePage_Footer_RPMGrantee_MyApplications recording.
    /// </summary>
    [TestModule("53b75efd-db30-4678-b828-e059b85fa9e0", ModuleType.Recording, 1)]
    public partial class R1_04_HomePage_Footer_RPMGrantee_MyApplications : ITestModule
    {
        /// <summary>
        /// Holds an instance of the Service_Portal_Regression_STGRepository repository.
        /// </summary>
        public static Service_Portal_Regression_STGRepository repo = Service_Portal_Regression_STGRepository.Instance;

        static R1_04_HomePage_Footer_RPMGrantee_MyApplications instance = new R1_04_HomePage_Footer_RPMGrantee_MyApplications();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public R1_04_HomePage_Footer_RPMGrantee_MyApplications()
        {
            RPM_Grantee_WM = "Hi, Monica Geller!";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static R1_04_HomePage_Footer_RPMGrantee_MyApplications Instance
        {
            get { return instance; }
        }

#region Variables

        string _RPM_Grantee_WM;

        /// <summary>
        /// Gets or sets the value of variable RPM_Grantee_WM.
        /// </summary>
        [TestVariable("cbdfce38-a051-4b36-84ed-f22a22906045")]
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
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='My Applications') on item 'Login1.NgScope1.MyApplications'.", repo.Login1.NgScope1.MyApplicationsInfo, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.Login1.NgScope1.MyApplicationsInfo, "InnerText", "My Applications");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='My Applications') on item 'Login1.NgScope1.MyApplications1'.", repo.Login1.NgScope1.MyApplications1Info, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.Login1.NgScope1.MyApplications1Info, "InnerText", "My Applications");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='My Organizations Applications') on item 'Login1.NgScope1.MyOrganizationsApplications'.", repo.Login1.NgScope1.MyOrganizationsApplicationsInfo, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.Login1.NgScope1.MyOrganizationsApplicationsInfo, "InnerText", "My Organizations Applications");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.NgScope1.MyApplications' at Center.", repo.Login1.NgScope1.MyApplicationsInfo, new RecordItemIndex(4));
            repo.Login1.NgScope1.MyApplications.Click();
            Delay.Milliseconds(200);
            
            // MyApplication Screenshot
            Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(5));
            
            // My Applications
            Report.Log(ReportLevel.Info, "Section", "My Applications", new RecordItemIndex(6));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.NgScope1.MyApplications1' at 74;3.", repo.Login1.NgScope1.MyApplications1Info, new RecordItemIndex(7));
            repo.Login1.NgScope1.MyApplications1.Click("74;3");
            Delay.Milliseconds(200);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (InnerText='Applications') on item 'Login1.FormInlinePanelHeading.Applications'.", repo.Login1.FormInlinePanelHeading.ApplicationsInfo, new RecordItemIndex(8));
                Validate.AttributeEqual(repo.Login1.FormInlinePanelHeading.ApplicationsInfo, "InnerText", "Applications", null, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(8)); }
            
            // My Application Table Screenshot
            Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(9));
            
            // Home Button
            Report.Log(ReportLevel.Info, "Mouse", "Home Button\r\nMouse Left Click item 'Login1.NavNavbarNavSamsNavbarNav.HOME' at 12;9.", repo.Login1.NavNavbarNavSamsNavbarNav.HOMEInfo, new RecordItemIndex(10));
            repo.Login1.NavNavbarNavSamsNavbarNav.HOME.Click("12;9");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s for the attribute 'InnerText' to equal the specified value $RPM_Grantee_WM. Associated repository item: 'Login1.HiMonicaGeller'", repo.Login1.HiMonicaGellerInfo, new RecordItemIndex(11));
            repo.Login1.HiMonicaGellerInfo.WaitForAttributeEqual(5000, "InnerText", RPM_Grantee_WM);
            
            // My Organizations Applications
            Report.Log(ReportLevel.Info, "Section", "My Organizations Applications", new RecordItemIndex(12));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.NgScope1.MyOrganizationsApplications' at 98;15.", repo.Login1.NgScope1.MyOrganizationsApplicationsInfo, new RecordItemIndex(13));
            repo.Login1.NgScope1.MyOrganizationsApplications.Click("98;15");
            Delay.Milliseconds(200);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (InnerText='Applications') on item 'Login1.FormInlinePanelHeading.Applications'.", repo.Login1.FormInlinePanelHeading.ApplicationsInfo, new RecordItemIndex(14));
                Validate.AttributeEqual(repo.Login1.FormInlinePanelHeading.ApplicationsInfo, "InnerText", "Applications", null, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(14)); }
            
            // My Organizations Applications Table Screenshot
            Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(15));
            
            // Home Button
            Report.Log(ReportLevel.Info, "Mouse", "Home Button\r\nMouse Left Click item 'Login1.NavNavbarNavSamsNavbarNav.HOME' at 12;9.", repo.Login1.NavNavbarNavSamsNavbarNav.HOMEInfo, new RecordItemIndex(16));
            repo.Login1.NavNavbarNavSamsNavbarNav.HOME.Click("12;9");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s for the attribute 'InnerText' to equal the specified value $RPM_Grantee_WM. Associated repository item: 'Login1.HiMonicaGeller'", repo.Login1.HiMonicaGellerInfo, new RecordItemIndex(17));
            repo.Login1.HiMonicaGellerInfo.WaitForAttributeEqual(5000, "InnerText", RPM_Grantee_WM);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
