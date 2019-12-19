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
    ///The R1_09_HomePage_TilesHeader_OSDSGrantee_Award recording.
    /// </summary>
    [TestModule("082d3ab9-1eae-49c9-8dd4-8574aab707af", ModuleType.Recording, 1)]
    public partial class R1_09_HomePage_TilesHeader_OSDSGrantee_Award : ITestModule
    {
        /// <summary>
        /// Holds an instance of the Service_Portal_Regression_STGRepository repository.
        /// </summary>
        public static Service_Portal_Regression_STGRepository repo = Service_Portal_Regression_STGRepository.Instance;

        static R1_09_HomePage_TilesHeader_OSDSGrantee_Award instance = new R1_09_HomePage_TilesHeader_OSDSGrantee_Award();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public R1_09_HomePage_TilesHeader_OSDSGrantee_Award()
        {
            OSDS_Grantee_WM = "Hi, Ross Geller!";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static R1_09_HomePage_TilesHeader_OSDSGrantee_Award Instance
        {
            get { return instance; }
        }

#region Variables

        string _OSDS_Grantee_WM;

        /// <summary>
        /// Gets or sets the value of variable OSDS_Grantee_WM.
        /// </summary>
        [TestVariable("351b688e-b767-4c2a-b5f3-0e81714b79f9")]
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
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (InnerText=' Award ') on item 'Login1.NavNavbarNavSamsNavbarNav.ATagAward'.", repo.Login1.NavNavbarNavSamsNavbarNav.ATagAwardInfo, new RecordItemIndex(1));
                Validate.AttributeEqual(repo.Login1.NavNavbarNavSamsNavbarNav.ATagAwardInfo, "InnerText", " Award ", null, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(1)); }
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.NavNavbarNavSamsNavbarNav.ATagAward' at 106;60.", repo.Login1.NavNavbarNavSamsNavbarNav.ATagAwardInfo, new RecordItemIndex(2));
            repo.Login1.NavNavbarNavSamsNavbarNav.ATagAward.Click("106;60");
            Delay.Milliseconds(200);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (InnerText='View Awards') on item 'Login1.NavNavbarNavSamsNavbarNav.ViewAwards'.", repo.Login1.NavNavbarNavSamsNavbarNav.ViewAwardsInfo, new RecordItemIndex(3));
                Validate.AttributeEqual(repo.Login1.NavNavbarNavSamsNavbarNav.ViewAwardsInfo, "InnerText", "View Awards", null, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(3)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (InnerText='Post Award Activities') on item 'Login1.NavNavbarNavSamsNavbarNav.PostAwardActivities'.", repo.Login1.NavNavbarNavSamsNavbarNav.PostAwardActivitiesInfo, new RecordItemIndex(4));
                Validate.AttributeEqual(repo.Login1.NavNavbarNavSamsNavbarNav.PostAwardActivitiesInfo, "InnerText", "Post Award Activities", null, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(4)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (InnerText='Awards Dashboard') on item 'Login1.NavNavbarNavSamsNavbarNav.AwardsDashboard'.", repo.Login1.NavNavbarNavSamsNavbarNav.AwardsDashboardInfo, new RecordItemIndex(5));
                Validate.AttributeEqual(repo.Login1.NavNavbarNavSamsNavbarNav.AwardsDashboardInfo, "InnerText", "Awards Dashboard", null, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(5)); }
            
            // Award Screenshot
            Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(6));
            
            // View Awards
            Report.Log(ReportLevel.Info, "Section", "View Awards", new RecordItemIndex(7));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.NavNavbarNavSamsNavbarNav.ViewAwards' at 84;17.", repo.Login1.NavNavbarNavSamsNavbarNav.ViewAwardsInfo, new RecordItemIndex(8));
            repo.Login1.NavNavbarNavSamsNavbarNav.ViewAwards.Click("84;17");
            Delay.Milliseconds(200);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (InnerText='Notice of Awards') on item 'Login1.FormInlinePanelHeading.NoticeOfAwards'.", repo.Login1.FormInlinePanelHeading.NoticeOfAwardsInfo, new RecordItemIndex(9));
                Validate.AttributeEqual(repo.Login1.FormInlinePanelHeading.NoticeOfAwardsInfo, "InnerText", "Notice of Awards", null, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(9)); }
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking WaitForDocumentLoaded() on item 'Login1'.", repo.Login1.SelfInfo, new RecordItemIndex(10));
            repo.Login1.Self.WaitForDocumentLoaded();
            Delay.Milliseconds(0);
            
            // Awards Table Screenshot
            Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(11));
            
            // Home Button
            Report.Log(ReportLevel.Info, "Mouse", "Home Button\r\nMouse Left Click item 'Login1.NavNavbarNavSamsNavbarNav.HOME' at 12;9.", repo.Login1.NavNavbarNavSamsNavbarNav.HOMEInfo, new RecordItemIndex(12));
            repo.Login1.NavNavbarNavSamsNavbarNav.HOME.Click("12;9");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s for the attribute 'InnerText' to equal the specified value $OSDS_Grantee_WM. Associated repository item: 'Login1.HiRossGeller'", repo.Login1.HiRossGellerInfo, new RecordItemIndex(13));
            repo.Login1.HiRossGellerInfo.WaitForAttributeEqual(5000, "InnerText", OSDS_Grantee_WM);
            
            // Post Award Activities
            Report.Log(ReportLevel.Info, "Section", "Post Award Activities", new RecordItemIndex(14));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.NavNavbarNavSamsNavbarNav.ATagAward' at 71;57.", repo.Login1.NavNavbarNavSamsNavbarNav.ATagAwardInfo, new RecordItemIndex(15));
            repo.Login1.NavNavbarNavSamsNavbarNav.ATagAward.Click("71;57");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.NavNavbarNavSamsNavbarNav.PostAwardActivities' at 96;23.", repo.Login1.NavNavbarNavSamsNavbarNav.PostAwardActivitiesInfo, new RecordItemIndex(16));
            repo.Login1.NavNavbarNavSamsNavbarNav.PostAwardActivities.Click("96;23");
            Delay.Milliseconds(200);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (InnerText='Post Award Activities') on item 'Login1.FormInlinePanelHeading.PostAwardActivities'.", repo.Login1.FormInlinePanelHeading.PostAwardActivitiesInfo, new RecordItemIndex(17));
                Validate.AttributeEqual(repo.Login1.FormInlinePanelHeading.PostAwardActivitiesInfo, "InnerText", "Post Award Activities", null, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(17)); }
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking WaitForDocumentLoaded() on item 'Login1'.", repo.Login1.SelfInfo, new RecordItemIndex(18));
            repo.Login1.Self.WaitForDocumentLoaded();
            Delay.Milliseconds(0);
            
            // PAA Table Screenshot
            Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(19));
            
            // Home Button
            Report.Log(ReportLevel.Info, "Mouse", "Home Button\r\nMouse Left Click item 'Login1.NavNavbarNavSamsNavbarNav.HOME' at 12;9.", repo.Login1.NavNavbarNavSamsNavbarNav.HOMEInfo, new RecordItemIndex(20));
            repo.Login1.NavNavbarNavSamsNavbarNav.HOME.Click("12;9");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s for the attribute 'InnerText' to equal the specified value $OSDS_Grantee_WM. Associated repository item: 'Login1.HiRossGeller'", repo.Login1.HiRossGellerInfo, new RecordItemIndex(21));
            repo.Login1.HiRossGellerInfo.WaitForAttributeEqual(5000, "InnerText", OSDS_Grantee_WM);
            
            // Awards Dashboard
            Report.Log(ReportLevel.Info, "Section", "Awards Dashboard", new RecordItemIndex(22));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.NavNavbarNavSamsNavbarNav.ATagAward' at 92;67.", repo.Login1.NavNavbarNavSamsNavbarNav.ATagAwardInfo, new RecordItemIndex(23));
            repo.Login1.NavNavbarNavSamsNavbarNav.ATagAward.Click("92;67");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.NavNavbarNavSamsNavbarNav.AwardsDashboard' at 109;21.", repo.Login1.NavNavbarNavSamsNavbarNav.AwardsDashboardInfo, new RecordItemIndex(24));
            repo.Login1.NavNavbarNavSamsNavbarNav.AwardsDashboard.Click("109;21");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking WaitForDocumentLoaded() on item 'Login1'.", repo.Login1.SelfInfo, new RecordItemIndex(25));
            repo.Login1.Self.WaitForDocumentLoaded();
            Delay.Milliseconds(0);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (InnerText='Post Award Activities - Status') on item 'Login1.PostAwardActivitiesStatus'.", repo.Login1.PostAwardActivitiesStatusInfo, new RecordItemIndex(26));
                Validate.AttributeEqual(repo.Login1.PostAwardActivitiesStatusInfo, "InnerText", "Post Award Activities - Status", null, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(26)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (InnerText='Notice of Award - Status') on item 'Login1.NoticeOfAwardStatus'.", repo.Login1.NoticeOfAwardStatusInfo, new RecordItemIndex(27));
                Validate.AttributeEqual(repo.Login1.NoticeOfAwardStatusInfo, "InnerText", "Notice of Award - Status", null, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(27)); }
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking WaitForDocumentLoaded() on item 'Login1'.", repo.Login1.SelfInfo, new RecordItemIndex(28));
            repo.Login1.Self.WaitForDocumentLoaded();
            Delay.Milliseconds(0);
            
            // Awards Dashboard Screenshot
            Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(29));
            
            // Home Button
            Report.Log(ReportLevel.Info, "Mouse", "Home Button\r\nMouse Left Click item 'Login1.NavNavbarNavSamsNavbarNav.HOME' at 12;9.", repo.Login1.NavNavbarNavSamsNavbarNav.HOMEInfo, new RecordItemIndex(30));
            repo.Login1.NavNavbarNavSamsNavbarNav.HOME.Click("12;9");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s for the attribute 'InnerText' to equal the specified value $OSDS_Grantee_WM. Associated repository item: 'Login1.HiRossGeller'", repo.Login1.HiRossGellerInfo, new RecordItemIndex(31));
            repo.Login1.HiRossGellerInfo.WaitForAttributeEqual(5000, "InnerText", OSDS_Grantee_WM);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
