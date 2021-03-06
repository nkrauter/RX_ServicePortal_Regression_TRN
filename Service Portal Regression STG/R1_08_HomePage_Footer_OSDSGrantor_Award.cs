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
    ///The R1_08_HomePage_Footer_OSDSGrantor_Award recording.
    /// </summary>
    [TestModule("4111adbf-d1bd-4ef3-b1b4-dd2a792d9940", ModuleType.Recording, 1)]
    public partial class R1_08_HomePage_Footer_OSDSGrantor_Award : ITestModule
    {
        /// <summary>
        /// Holds an instance of the Service_Portal_Regression_STGRepository repository.
        /// </summary>
        public static Service_Portal_Regression_STGRepository repo = Service_Portal_Regression_STGRepository.Instance;

        static R1_08_HomePage_Footer_OSDSGrantor_Award instance = new R1_08_HomePage_Footer_OSDSGrantor_Award();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public R1_08_HomePage_Footer_OSDSGrantor_Award()
        {
            OSDS_Grantor_WM = "Hi, Mike Hannigan!";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static R1_08_HomePage_Footer_OSDSGrantor_Award Instance
        {
            get { return instance; }
        }

#region Variables

        string _OSDS_Grantor_WM;

        /// <summary>
        /// Gets or sets the value of variable OSDS_Grantor_WM.
        /// </summary>
        [TestVariable("378b6aea-a1d3-4353-a1ba-408be89c7f6d")]
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

            // Footer Links
            Report.Log(ReportLevel.Info, "Section", "Footer Links", new RecordItemIndex(0));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -840 units.", new RecordItemIndex(1));
            Mouse.ScrollWheel(-840);
            Delay.Milliseconds(500);
            
            // Footer - Award
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nFooter - Award\r\nValidating AttributeEqual (InnerText='Award') on item 'Login1.NgScope2.Award'.", repo.Login1.NgScope2.AwardInfo, new RecordItemIndex(2));
                Validate.AttributeEqual(repo.Login1.NgScope2.AwardInfo, "InnerText", "Award", null, new Validate.Options(){ReportScreenshot=Validate.ResultOption.OnFail});
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(2)); }
            
            // Footer - Award1
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nFooter - Award1\r\nValidating AttributeEqual (InnerText='Award') on item 'Login1.NgScope2.Award1'.", repo.Login1.NgScope2.Award1Info, new RecordItemIndex(3));
                Validate.AttributeEqual(repo.Login1.NgScope2.Award1Info, "InnerText", "Award", null, new Validate.Options(){ReportScreenshot=Validate.ResultOption.OnFail});
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(3)); }
            
            // Footer - PAA
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nFooter - PAA\r\nValidating AttributeEqual (InnerText='Post Award Activities') on item 'Login1.NgScope2.PostAwardActivities'.", repo.Login1.NgScope2.PostAwardActivitiesInfo, new RecordItemIndex(4));
                Validate.AttributeEqual(repo.Login1.NgScope2.PostAwardActivitiesInfo, "InnerText", "Post Award Activities", null, new Validate.Options(){ReportScreenshot=Validate.ResultOption.OnFail});
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(4)); }
            
            // Footer - Awards Dashboard
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nFooter - Awards Dashboard\r\nValidating AttributeEqual (InnerText='Awards Dashboard') on item 'Login1.NgScope2.AwardsDashboard'.", repo.Login1.NgScope2.AwardsDashboardInfo, new RecordItemIndex(5));
                Validate.AttributeEqual(repo.Login1.NgScope2.AwardsDashboardInfo, "InnerText", "Awards Dashboard", null, new Validate.Options(){ReportScreenshot=Validate.ResultOption.OnFail});
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(5)); }
            
            // Footer - eFiling
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nFooter - eFiling\r\nValidating AttributeEqual (InnerText='Navigate to Ariba') on item 'Login1.NgScope2.NavigateToAriba'.", repo.Login1.NgScope2.NavigateToAribaInfo, new RecordItemIndex(6));
                Validate.AttributeEqual(repo.Login1.NgScope2.NavigateToAribaInfo, "InnerText", "Navigate to Ariba", null, new Validate.Options(){ReportScreenshot=Validate.ResultOption.OnFail});
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(6)); }
            
            // Footer - Ariba
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nFooter - Ariba\r\nValidating AttributeEqual (InnerText='Navigate to eFiling') on item 'Login1.NgScope2.NavigateToEFiling'.", repo.Login1.NgScope2.NavigateToEFilingInfo, new RecordItemIndex(7));
                Validate.AttributeEqual(repo.Login1.NgScope2.NavigateToEFilingInfo, "InnerText", "Navigate to eFiling", null, new Validate.Options(){ReportScreenshot=Validate.ResultOption.OnFail});
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(7)); }
            
            // Pre-Award Screenshot
            Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(8));
            
            // Award
            Report.Log(ReportLevel.Info, "Section", "Award", new RecordItemIndex(9));
            
            // Footer - Award1
            Report.Log(ReportLevel.Info, "Mouse", "Footer - Award1\r\nMouse Left Click item 'Login1.NgScope2.Award1' at 34;7.", repo.Login1.NgScope2.Award1Info, new RecordItemIndex(10));
            repo.Login1.NgScope2.Award1.Click("34;7");
            Delay.Milliseconds(200);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (InnerText='Notice of Awards') on item 'Login1.FormInlinePanelHeading.NoticeOfAwards'.", repo.Login1.FormInlinePanelHeading.NoticeOfAwardsInfo, new RecordItemIndex(11));
                Validate.AttributeEqual(repo.Login1.FormInlinePanelHeading.NoticeOfAwardsInfo, "InnerText", "Notice of Awards", null, new Validate.Options(){ReportScreenshot=Validate.ResultOption.OnFail});
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(11)); }
            
            // Awards Table Screenshot
            Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(12));
            
            // Home Button
            Report.Log(ReportLevel.Info, "Mouse", "Home Button\r\nMouse Left Click item 'Login1.NavNavbarNavSamsNavbarNav.HOME' at 12;9.", repo.Login1.NavNavbarNavSamsNavbarNav.HOMEInfo, new RecordItemIndex(13));
            repo.Login1.NavNavbarNavSamsNavbarNav.HOME.Click("12;9");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s for the attribute 'InnerText' to equal the specified value $OSDS_Grantor_WM. Associated repository item: 'Login1.HiMikeHannigan'", repo.Login1.HiMikeHanniganInfo, new RecordItemIndex(14));
            repo.Login1.HiMikeHanniganInfo.WaitForAttributeEqual(5000, "InnerText", OSDS_Grantor_WM);
            
            // PAA
            Report.Log(ReportLevel.Info, "Section", "PAA", new RecordItemIndex(15));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -840 units.", new RecordItemIndex(16));
            Mouse.ScrollWheel(-840);
            Delay.Milliseconds(500);
            
            // Footer - PAA
            Report.Log(ReportLevel.Info, "Mouse", "Footer - PAA\r\nMouse Left Click item 'Login1.NgScope2.PostAwardActivities' at 70;14.", repo.Login1.NgScope2.PostAwardActivitiesInfo, new RecordItemIndex(17));
            repo.Login1.NgScope2.PostAwardActivities.Click("70;14");
            Delay.Milliseconds(200);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (InnerText='Post Award Activities') on item 'Login1.FormInlinePanelHeading.PostAwardActivities'.", repo.Login1.FormInlinePanelHeading.PostAwardActivitiesInfo, new RecordItemIndex(18));
                Validate.AttributeEqual(repo.Login1.FormInlinePanelHeading.PostAwardActivitiesInfo, "InnerText", "Post Award Activities", null, new Validate.Options(){ReportScreenshot=Validate.ResultOption.OnFail});
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(18)); }
            
            // PAA Table Screenshot
            Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(19));
            
            // Home Button
            Report.Log(ReportLevel.Info, "Mouse", "Home Button\r\nMouse Left Click item 'Login1.NavNavbarNavSamsNavbarNav.HOME' at 12;9.", repo.Login1.NavNavbarNavSamsNavbarNav.HOMEInfo, new RecordItemIndex(20));
            repo.Login1.NavNavbarNavSamsNavbarNav.HOME.Click("12;9");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s for the attribute 'InnerText' to equal the specified value $OSDS_Grantor_WM. Associated repository item: 'Login1.HiMikeHannigan'", repo.Login1.HiMikeHanniganInfo, new RecordItemIndex(21));
            repo.Login1.HiMikeHanniganInfo.WaitForAttributeEqual(5000, "InnerText", OSDS_Grantor_WM);
            
            // Awards Dashboard
            Report.Log(ReportLevel.Info, "Section", "Awards Dashboard", new RecordItemIndex(22));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -840 units.", new RecordItemIndex(23));
            Mouse.ScrollWheel(-840);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.NgScope2.AwardsDashboard' at 70;14.", repo.Login1.NgScope2.AwardsDashboardInfo, new RecordItemIndex(24));
            repo.Login1.NgScope2.AwardsDashboard.Click("70;14");
            Delay.Milliseconds(200);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (InnerText='Notice of Award - Status') on item 'Login1.NoticeOfAwardStatus'.", repo.Login1.NoticeOfAwardStatusInfo, new RecordItemIndex(25));
                Validate.AttributeEqual(repo.Login1.NoticeOfAwardStatusInfo, "InnerText", "Notice of Award - Status", null, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(25)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (InnerText='Post Award Activities - Status') on item 'Login1.PostAwardActivitiesStatus'.", repo.Login1.PostAwardActivitiesStatusInfo, new RecordItemIndex(26));
                Validate.AttributeEqual(repo.Login1.PostAwardActivitiesStatusInfo, "InnerText", "Post Award Activities - Status", null, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(26)); }
            
            // Awards Dashboard Screenshot
            Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(27));
            
            // Home Button
            Report.Log(ReportLevel.Info, "Mouse", "Home Button\r\nMouse Left Click item 'Login1.NavNavbarNavSamsNavbarNav.HOME' at 12;9.", repo.Login1.NavNavbarNavSamsNavbarNav.HOMEInfo, new RecordItemIndex(28));
            repo.Login1.NavNavbarNavSamsNavbarNav.HOME.Click("12;9");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s for the attribute 'InnerText' to equal the specified value $OSDS_Grantor_WM. Associated repository item: 'Login1.HiMikeHannigan'", repo.Login1.HiMikeHanniganInfo, new RecordItemIndex(29));
            repo.Login1.HiMikeHanniganInfo.WaitForAttributeEqual(5000, "InnerText", OSDS_Grantor_WM);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
