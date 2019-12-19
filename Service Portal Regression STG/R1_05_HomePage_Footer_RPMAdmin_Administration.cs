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
    ///The R1_05_HomePage_Footer_RPMAdmin_Administration recording.
    /// </summary>
    [TestModule("8fd49483-2b7a-49b7-9492-bedaba0615fd", ModuleType.Recording, 1)]
    public partial class R1_05_HomePage_Footer_RPMAdmin_Administration : ITestModule
    {
        /// <summary>
        /// Holds an instance of the Service_Portal_Regression_STGRepository repository.
        /// </summary>
        public static Service_Portal_Regression_STGRepository repo = Service_Portal_Regression_STGRepository.Instance;

        static R1_05_HomePage_Footer_RPMAdmin_Administration instance = new R1_05_HomePage_Footer_RPMAdmin_Administration();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public R1_05_HomePage_Footer_RPMAdmin_Administration()
        {
            RPM_Admin_WM = "Hi, Chandler Bing!";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static R1_05_HomePage_Footer_RPMAdmin_Administration Instance
        {
            get { return instance; }
        }

#region Variables

        string _RPM_Admin_WM;

        /// <summary>
        /// Gets or sets the value of variable RPM_Admin_WM.
        /// </summary>
        [TestVariable("f180a8ee-ab36-4944-91d3-77c343b477f3")]
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

            // Footer Links
            Report.Log(ReportLevel.Info, "Section", "Footer Links", new RecordItemIndex(0));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -840 units.", new RecordItemIndex(1));
            Mouse.ScrollWheel(-840);
            Delay.Milliseconds(500);
            
            // Footer - Administration
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nFooter - Administration\r\nValidating AttributeEqual (InnerText='Administration') on item 'Login1.NgScope3.Administration'.", repo.Login1.NgScope3.AdministrationInfo, new RecordItemIndex(2));
                Validate.AttributeEqual(repo.Login1.NgScope3.AdministrationInfo, "InnerText", "Administration", null, new Validate.Options(){ReportScreenshot=Validate.ResultOption.OnFail});
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(2)); }
            
            // Footer - Grantee Accounts
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nFooter - Grantee Accounts\r\nValidating AttributeEqual (InnerText='Grantee Accounts') on item 'Login1.NgScope3.GranteeAccounts'.", repo.Login1.NgScope3.GranteeAccountsInfo, new RecordItemIndex(3));
                Validate.AttributeEqual(repo.Login1.NgScope3.GranteeAccountsInfo, "InnerText", "Grantee Accounts", null, new Validate.Options(){ReportScreenshot=Validate.ResultOption.OnFail});
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(3)); }
            
            // Footer - Organization Records
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nFooter - Organization Records\r\nValidating AttributeEqual (InnerText='Organization Records') on item 'Login1.NgScope3.OrganizationRecords'.", repo.Login1.NgScope3.OrganizationRecordsInfo, new RecordItemIndex(4));
                Validate.AttributeEqual(repo.Login1.NgScope3.OrganizationRecordsInfo, "InnerText", "Organization Records", null, new Validate.Options(){ReportScreenshot=Validate.ResultOption.OnFail});
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(4)); }
            
            // Footer - Pending User Registration
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nFooter - Pending User Registration\r\nValidating AttributeEqual (InnerText='Pending User Registrations') on item 'Login1.NgScope3.PendingUserRegistrations'.", repo.Login1.NgScope3.PendingUserRegistrationsInfo, new RecordItemIndex(5));
                Validate.AttributeEqual(repo.Login1.NgScope3.PendingUserRegistrationsInfo, "InnerText", "Pending User Registrations", null, new Validate.Options(){ReportScreenshot=Validate.ResultOption.OnFail});
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(5)); }
            
            // Grantee Accounts
            Report.Log(ReportLevel.Info, "Section", "Grantee Accounts", new RecordItemIndex(6));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.NgScope3.GranteeAccounts' at 70;14.", repo.Login1.NgScope3.GranteeAccountsInfo, new RecordItemIndex(7));
            repo.Login1.NgScope3.GranteeAccounts.Click("70;14");
            Delay.Milliseconds(200);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (InnerText='Users') on item 'Login1.FormInlinePanelHeading.Users'.", repo.Login1.FormInlinePanelHeading.UsersInfo, new RecordItemIndex(8));
                Validate.AttributeEqual(repo.Login1.FormInlinePanelHeading.UsersInfo, "InnerText", "Users", null, new Validate.Options(){ReportScreenshot=Validate.ResultOption.OnFail});
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(8)); }
            
            // Grantee Accounts Table Screenshot
            Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(9));
            
            // Home Button
            Report.Log(ReportLevel.Info, "Mouse", "Home Button\r\nMouse Left Click item 'Login1.NavNavbarNavSamsNavbarNav.HOME' at 12;9.", repo.Login1.NavNavbarNavSamsNavbarNav.HOMEInfo, new RecordItemIndex(10));
            repo.Login1.NavNavbarNavSamsNavbarNav.HOME.Click("12;9");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s for the attribute 'InnerText' to equal the specified value $RPM_Admin_WM. Associated repository item: 'Login1.HiChandlerBing'", repo.Login1.HiChandlerBingInfo, new RecordItemIndex(11));
            repo.Login1.HiChandlerBingInfo.WaitForAttributeEqual(5000, "InnerText", RPM_Admin_WM);
            
            // Organization Records
            Report.Log(ReportLevel.Info, "Section", "Organization Records", new RecordItemIndex(12));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -840 units.", new RecordItemIndex(13));
            Mouse.ScrollWheel(-840);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.NgScope3.OrganizationRecords' at 70;14.", repo.Login1.NgScope3.OrganizationRecordsInfo, new RecordItemIndex(14));
            repo.Login1.NgScope3.OrganizationRecords.Click("70;14");
            Delay.Milliseconds(200);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (InnerText='Companies') on item 'Login1.FormInlinePanelHeading.Companies'.", repo.Login1.FormInlinePanelHeading.CompaniesInfo, new RecordItemIndex(15));
                Validate.AttributeEqual(repo.Login1.FormInlinePanelHeading.CompaniesInfo, "InnerText", "Companies", null, new Validate.Options(){ReportScreenshot=Validate.ResultOption.OnFail});
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(15)); }
            
            // Organization Records Table Screenshot
            Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(16));
            
            // Home Button
            Report.Log(ReportLevel.Info, "Mouse", "Home Button\r\nMouse Left Click item 'Login1.NavNavbarNavSamsNavbarNav.HOME' at 12;9.", repo.Login1.NavNavbarNavSamsNavbarNav.HOMEInfo, new RecordItemIndex(17));
            repo.Login1.NavNavbarNavSamsNavbarNav.HOME.Click("12;9");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s for the attribute 'InnerText' to equal the specified value $RPM_Admin_WM. Associated repository item: 'Login1.HiChandlerBing'", repo.Login1.HiChandlerBingInfo, new RecordItemIndex(18));
            repo.Login1.HiChandlerBingInfo.WaitForAttributeEqual(5000, "InnerText", RPM_Admin_WM);
            
            // Pending User Records
            Report.Log(ReportLevel.Info, "Section", "Pending User Records", new RecordItemIndex(19));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -840 units.", new RecordItemIndex(20));
            Mouse.ScrollWheel(-840);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.NgScope3.PendingUserRegistrations' at 70;14.", repo.Login1.NgScope3.PendingUserRegistrationsInfo, new RecordItemIndex(21));
            repo.Login1.NgScope3.PendingUserRegistrations.Click("70;14");
            Delay.Milliseconds(200);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (InnerText='User Registration Requests') on item 'Login1.FormInlinePanelHeading.UserRegistrationRequests'.", repo.Login1.FormInlinePanelHeading.UserRegistrationRequestsInfo, new RecordItemIndex(22));
                Validate.AttributeEqual(repo.Login1.FormInlinePanelHeading.UserRegistrationRequestsInfo, "InnerText", "User Registration Requests", null, new Validate.Options(){ReportScreenshot=Validate.ResultOption.OnFail});
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(22)); }
            
            // Pending User Records Table Screenshot
            Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(23));
            
            // Home Button
            Report.Log(ReportLevel.Info, "Mouse", "Home Button\r\nMouse Left Click item 'Login1.NavNavbarNavSamsNavbarNav.HOME' at 12;9.", repo.Login1.NavNavbarNavSamsNavbarNav.HOMEInfo, new RecordItemIndex(24));
            repo.Login1.NavNavbarNavSamsNavbarNav.HOME.Click("12;9");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s for the attribute 'InnerText' to equal the specified value $RPM_Admin_WM. Associated repository item: 'Login1.HiChandlerBing'", repo.Login1.HiChandlerBingInfo, new RecordItemIndex(25));
            repo.Login1.HiChandlerBingInfo.WaitForAttributeEqual(5000, "InnerText", RPM_Admin_WM);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
