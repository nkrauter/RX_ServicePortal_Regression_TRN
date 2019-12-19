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
    ///The R1_08_HomePage_TilesHeader_OSDSGrantor_OSAdministration recording.
    /// </summary>
    [TestModule("91c0b35e-ccb4-433f-9e68-0ae9adf3fb7e", ModuleType.Recording, 1)]
    public partial class R1_08_HomePage_TilesHeader_OSDSGrantor_OSAdministration : ITestModule
    {
        /// <summary>
        /// Holds an instance of the Service_Portal_Regression_STGRepository repository.
        /// </summary>
        public static Service_Portal_Regression_STGRepository repo = Service_Portal_Regression_STGRepository.Instance;

        static R1_08_HomePage_TilesHeader_OSDSGrantor_OSAdministration instance = new R1_08_HomePage_TilesHeader_OSDSGrantor_OSAdministration();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public R1_08_HomePage_TilesHeader_OSDSGrantor_OSAdministration()
        {
            OSDS_Grantor_WM = "Hi, Mike Hannigan!";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static R1_08_HomePage_TilesHeader_OSDSGrantor_OSAdministration Instance
        {
            get { return instance; }
        }

#region Variables

        string _OSDS_Grantor_WM;

        /// <summary>
        /// Gets or sets the value of variable OSDS_Grantor_WM.
        /// </summary>
        [TestVariable("fb754658-176e-4701-a6e6-5fcc960a71e5")]
        public string OSDS_Grantor_WM
        {
            get { return _OSDS_Grantor_WM; }
            set { _OSDS_Grantor_WM = value; }
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
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Explorer.RunningApplications' at 1378;1.", repo.Explorer.RunningApplicationsInfo, new RecordItemIndex(1));
            repo.Explorer.RunningApplications.Click("1378;1");
            Delay.Milliseconds(200);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (InnerText=' Administration ') on item 'Login1.NavNavbarNavSamsNavbarNav.ATagAdministration1'.", repo.Login1.NavNavbarNavSamsNavbarNav.ATagAdministration1Info, new RecordItemIndex(2));
                Validate.AttributeEqual(repo.Login1.NavNavbarNavSamsNavbarNav.ATagAdministration1Info, "InnerText", " Administration ", null, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(2)); }
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.NavNavbarNavSamsNavbarNav.ATagAdministration1' at 80;44.", repo.Login1.NavNavbarNavSamsNavbarNav.ATagAdministration1Info, new RecordItemIndex(3));
            repo.Login1.NavNavbarNavSamsNavbarNav.ATagAdministration1.Click("80;44");
            Delay.Milliseconds(200);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (InnerText='Grantee Accounts') on item 'Login1.NavNavbarNavSamsNavbarNav.GranteeAccounts1'.", repo.Login1.NavNavbarNavSamsNavbarNav.GranteeAccounts1Info, new RecordItemIndex(4));
                Validate.AttributeEqual(repo.Login1.NavNavbarNavSamsNavbarNav.GranteeAccounts1Info, "InnerText", "Grantee Accounts", null, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(4)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (InnerText='Organizations Records') on item 'Login1.NavNavbarNavSamsNavbarNav.OrganizationsRecords'.", repo.Login1.NavNavbarNavSamsNavbarNav.OrganizationsRecordsInfo, new RecordItemIndex(5));
                Validate.AttributeEqual(repo.Login1.NavNavbarNavSamsNavbarNav.OrganizationsRecordsInfo, "InnerText", "Organizations Records", null, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(5)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (InnerText='Pending User Registrations') on item 'Login1.NavNavbarNavSamsNavbarNav.PendingUserRegistrations1'.", repo.Login1.NavNavbarNavSamsNavbarNav.PendingUserRegistrations1Info, new RecordItemIndex(6));
                Validate.AttributeEqual(repo.Login1.NavNavbarNavSamsNavbarNav.PendingUserRegistrations1Info, "InnerText", "Pending User Registrations", null, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(6)); }
            
            // Grantee Accounts
            Report.Log(ReportLevel.Info, "Section", "Grantee Accounts", new RecordItemIndex(7));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.NavNavbarNavSamsNavbarNav.GranteeAccounts1' at 40;14.", repo.Login1.NavNavbarNavSamsNavbarNav.GranteeAccounts1Info, new RecordItemIndex(8));
            repo.Login1.NavNavbarNavSamsNavbarNav.GranteeAccounts1.Click("40;14");
            Delay.Milliseconds(200);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating Exists on item 'Login1.FormInlinePanelHeading.Users'.", repo.Login1.FormInlinePanelHeading.UsersInfo, new RecordItemIndex(9));
                Validate.Exists(repo.Login1.FormInlinePanelHeading.UsersInfo, null, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(9)); }
            
            // Grantee Accounts Table Screenshot
            Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(10));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.NavNavbarNavSamsNavbarNav.HOME' at 14;7.", repo.Login1.NavNavbarNavSamsNavbarNav.HOMEInfo, new RecordItemIndex(11));
            repo.Login1.NavNavbarNavSamsNavbarNav.HOME.Click("14;7");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s for the attribute 'InnerText' to equal the specified value $OSDS_Grantor_WM. Associated repository item: 'Login1.HiMikeHannigan'", repo.Login1.HiMikeHanniganInfo, new RecordItemIndex(12));
            repo.Login1.HiMikeHanniganInfo.WaitForAttributeEqual(5000, "InnerText", OSDS_Grantor_WM);
            
            // Organization Records
            Report.Log(ReportLevel.Info, "Section", "Organization Records", new RecordItemIndex(13));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.NavNavbarNavSamsNavbarNav.ATagAdministration1' at 75;36.", repo.Login1.NavNavbarNavSamsNavbarNav.ATagAdministration1Info, new RecordItemIndex(14));
            repo.Login1.NavNavbarNavSamsNavbarNav.ATagAdministration1.Click("75;36");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.NavNavbarNavSamsNavbarNav.OrganizationsRecords' at 76;9.", repo.Login1.NavNavbarNavSamsNavbarNav.OrganizationsRecordsInfo, new RecordItemIndex(15));
            repo.Login1.NavNavbarNavSamsNavbarNav.OrganizationsRecords.Click("76;9");
            Delay.Milliseconds(200);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (InnerText='Companies') on item 'Login1.FormInlinePanelHeading.Companies'.", repo.Login1.FormInlinePanelHeading.CompaniesInfo, new RecordItemIndex(16));
                Validate.AttributeEqual(repo.Login1.FormInlinePanelHeading.CompaniesInfo, "InnerText", "Companies", null, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(16)); }
            
            // Companies Table Screenshot
            Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(17));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.NavNavbarNavSamsNavbarNav.HOME' at 14;7.", repo.Login1.NavNavbarNavSamsNavbarNav.HOMEInfo, new RecordItemIndex(18));
            repo.Login1.NavNavbarNavSamsNavbarNav.HOME.Click("14;7");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s for the attribute 'InnerText' to equal the specified value $OSDS_Grantor_WM. Associated repository item: 'Login1.HiMikeHannigan'", repo.Login1.HiMikeHanniganInfo, new RecordItemIndex(19));
            repo.Login1.HiMikeHanniganInfo.WaitForAttributeEqual(5000, "InnerText", OSDS_Grantor_WM);
            
            // Pending User Registration
            Report.Log(ReportLevel.Info, "Section", "Pending User Registration", new RecordItemIndex(20));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.NavNavbarNavSamsNavbarNav.ATagAdministration1' at 66;45.", repo.Login1.NavNavbarNavSamsNavbarNav.ATagAdministration1Info, new RecordItemIndex(21));
            repo.Login1.NavNavbarNavSamsNavbarNav.ATagAdministration1.Click("66;45");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.NavNavbarNavSamsNavbarNav.PendingUserRegistrations1' at 61;9.", repo.Login1.NavNavbarNavSamsNavbarNav.PendingUserRegistrations1Info, new RecordItemIndex(22));
            repo.Login1.NavNavbarNavSamsNavbarNav.PendingUserRegistrations1.Click("61;9");
            Delay.Milliseconds(200);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating Exists on item 'Login1.FormInlinePanelHeading.UserRegistrationRequests'.", repo.Login1.FormInlinePanelHeading.UserRegistrationRequestsInfo, new RecordItemIndex(23));
                Validate.Exists(repo.Login1.FormInlinePanelHeading.UserRegistrationRequestsInfo, null, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(23)); }
            
            // User Registration Requets Table Screenshot
            Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(24));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.NavNavbarNavSamsNavbarNav.HOME' at 14;7.", repo.Login1.NavNavbarNavSamsNavbarNav.HOMEInfo, new RecordItemIndex(25));
            repo.Login1.NavNavbarNavSamsNavbarNav.HOME.Click("14;7");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s for the attribute 'InnerText' to equal the specified value $OSDS_Grantor_WM. Associated repository item: 'Login1.HiMikeHannigan'", repo.Login1.HiMikeHanniganInfo, new RecordItemIndex(26));
            repo.Login1.HiMikeHanniganInfo.WaitForAttributeEqual(5000, "InnerText", OSDS_Grantor_WM);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
