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
    ///The R1_04_HomePage_Footer_RPMGrantee_Award recording.
    /// </summary>
    [TestModule("af31650a-c25c-4cce-913a-875529e418bf", ModuleType.Recording, 1)]
    public partial class R1_04_HomePage_Footer_RPMGrantee_Award : ITestModule
    {
        /// <summary>
        /// Holds an instance of the Service_Portal_Regression_STGRepository repository.
        /// </summary>
        public static Service_Portal_Regression_STGRepository repo = Service_Portal_Regression_STGRepository.Instance;

        static R1_04_HomePage_Footer_RPMGrantee_Award instance = new R1_04_HomePage_Footer_RPMGrantee_Award();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public R1_04_HomePage_Footer_RPMGrantee_Award()
        {
            RPM_Grantee_WM = "Hi, Monica Geller!";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static R1_04_HomePage_Footer_RPMGrantee_Award Instance
        {
            get { return instance; }
        }

#region Variables

        string _RPM_Grantee_WM;

        /// <summary>
        /// Gets or sets the value of variable RPM_Grantee_WM.
        /// </summary>
        [TestVariable("9f23546f-913d-4bc8-8a8f-70b67f48d5b8")]
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
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            // Header Links
            Report.Log(ReportLevel.Info, "Section", "Header Links", new RecordItemIndex(0));
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (Hidden='False') on item 'Login1.NgScope3.Award'.", repo.Login1.NgScope3.AwardInfo, new RecordItemIndex(1));
                Validate.AttributeEqual(repo.Login1.NgScope3.AwardInfo, "Hidden", "False", null, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(1)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (InnerText='View Awards') on item 'Login1.NgScope3.ViewAwards'.", repo.Login1.NgScope3.ViewAwardsInfo, new RecordItemIndex(2));
                Validate.AttributeEqual(repo.Login1.NgScope3.ViewAwardsInfo, "InnerText", "View Awards", null, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(2)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (InnerText='Post Award Activities') on item 'Login1.NgScope3.PostAwardActivities'.", repo.Login1.NgScope3.PostAwardActivitiesInfo, new RecordItemIndex(3));
                Validate.AttributeEqual(repo.Login1.NgScope3.PostAwardActivitiesInfo, "InnerText", "Post Award Activities", null, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(3)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (InnerText='Awards Dashboard') on item 'Login1.NgScope3.AwardsDashboard'.", repo.Login1.NgScope3.AwardsDashboardInfo, new RecordItemIndex(4));
                Validate.AttributeEqual(repo.Login1.NgScope3.AwardsDashboardInfo, "InnerText", "Awards Dashboard", null, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(4)); }
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.NgScope3.Award' at 35;4.", repo.Login1.NgScope3.AwardInfo, new RecordItemIndex(5));
            repo.Login1.NgScope3.Award.Click("35;4");
            Delay.Milliseconds(200);
            
            // Award Screenshot
            Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(6));
            
            // View Awards
            Report.Log(ReportLevel.Info, "Section", "View Awards", new RecordItemIndex(7));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.NgScope3.ViewAwards' at 84;17.", repo.Login1.NgScope3.ViewAwardsInfo, new RecordItemIndex(8));
            repo.Login1.NgScope3.ViewAwards.Click("84;17");
            Delay.Milliseconds(200);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (InnerText='Notice of Awards') on item 'Login1.FormInlinePanelHeading.NoticeOfAwards'.", repo.Login1.FormInlinePanelHeading.NoticeOfAwardsInfo, new RecordItemIndex(9));
                Validate.AttributeEqual(repo.Login1.FormInlinePanelHeading.NoticeOfAwardsInfo, "InnerText", "Notice of Awards", null, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(9)); }
            
            // Awards Table Screenshot
            Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(10));
            
            // Home Button
            Report.Log(ReportLevel.Info, "Mouse", "Home Button\r\nMouse Left Click item 'Login1.NavNavbarNavSamsNavbarNav.HOME' at 12;9.", repo.Login1.NavNavbarNavSamsNavbarNav.HOMEInfo, new RecordItemIndex(11));
            repo.Login1.NavNavbarNavSamsNavbarNav.HOME.Click("12;9");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s for the attribute 'InnerText' to equal the specified value $RPM_Grantee_WM. Associated repository item: 'Login1.HiMonicaGeller'", repo.Login1.HiMonicaGellerInfo, new RecordItemIndex(12));
            repo.Login1.HiMonicaGellerInfo.WaitForAttributeEqual(5000, "InnerText", RPM_Grantee_WM);
            
            // Post Award Activities
            Report.Log(ReportLevel.Info, "Section", "Post Award Activities", new RecordItemIndex(13));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.NgScope3.PostAwardActivities' at 47;11.", repo.Login1.NgScope3.PostAwardActivitiesInfo, new RecordItemIndex(14));
            repo.Login1.NgScope3.PostAwardActivities.Click("47;11");
            Delay.Milliseconds(200);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (InnerText='Post Award Activities') on item 'Login1.FormInlinePanelHeading.PostAwardActivities'.", repo.Login1.FormInlinePanelHeading.PostAwardActivitiesInfo, new RecordItemIndex(15));
                Validate.AttributeEqual(repo.Login1.FormInlinePanelHeading.PostAwardActivitiesInfo, "InnerText", "Post Award Activities", null, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(15)); }
            
            // PAA Table Screenshot
            Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(16));
            
            // Home Button
            Report.Log(ReportLevel.Info, "Mouse", "Home Button\r\nMouse Left Click item 'Login1.NavNavbarNavSamsNavbarNav.HOME' at 12;9.", repo.Login1.NavNavbarNavSamsNavbarNav.HOMEInfo, new RecordItemIndex(17));
            repo.Login1.NavNavbarNavSamsNavbarNav.HOME.Click("12;9");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s for the attribute 'InnerText' to equal the specified value $RPM_Grantee_WM. Associated repository item: 'Login1.HiMonicaGeller'", repo.Login1.HiMonicaGellerInfo, new RecordItemIndex(18));
            repo.Login1.HiMonicaGellerInfo.WaitForAttributeEqual(5000, "InnerText", RPM_Grantee_WM);
            
            // Awards Dashboard
            Report.Log(ReportLevel.Info, "Section", "Awards Dashboard", new RecordItemIndex(19));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.NgScope3.AwardsDashboard' at 92;10.", repo.Login1.NgScope3.AwardsDashboardInfo, new RecordItemIndex(20));
            repo.Login1.NgScope3.AwardsDashboard.Click("92;10");
            Delay.Milliseconds(200);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (InnerText='Post Award Activities - Status') on item 'Login1.PostAwardActivitiesStatus'.", repo.Login1.PostAwardActivitiesStatusInfo, new RecordItemIndex(21));
                Validate.AttributeEqual(repo.Login1.PostAwardActivitiesStatusInfo, "InnerText", "Post Award Activities - Status", null, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(21)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (InnerText='Notice of Award - Status') on item 'Login1.NoticeOfAwardStatus'.", repo.Login1.NoticeOfAwardStatusInfo, new RecordItemIndex(22));
                Validate.AttributeEqual(repo.Login1.NoticeOfAwardStatusInfo, "InnerText", "Notice of Award - Status", null, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(22)); }
            
            // Awards Dashboard Screenshot
            Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(23));
            
            // Home Button
            Report.Log(ReportLevel.Info, "Mouse", "Home Button\r\nMouse Left Click item 'Login1.NavNavbarNavSamsNavbarNav.HOME' at 12;9.", repo.Login1.NavNavbarNavSamsNavbarNav.HOMEInfo, new RecordItemIndex(24));
            repo.Login1.NavNavbarNavSamsNavbarNav.HOME.Click("12;9");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s for the attribute 'InnerText' to equal the specified value $RPM_Grantee_WM. Associated repository item: 'Login1.HiMonicaGeller'", repo.Login1.HiMonicaGellerInfo, new RecordItemIndex(25));
            repo.Login1.HiMonicaGellerInfo.WaitForAttributeEqual(5000, "InnerText", RPM_Grantee_WM);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}