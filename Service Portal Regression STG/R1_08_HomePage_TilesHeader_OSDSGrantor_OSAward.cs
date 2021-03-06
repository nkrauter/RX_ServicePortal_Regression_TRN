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
    ///The R1_08_HomePage_TilesHeader_OSDSGrantor_OSAward recording.
    /// </summary>
    [TestModule("4f68437b-a3db-43a9-b97b-c0f92b5004e7", ModuleType.Recording, 1)]
    public partial class R1_08_HomePage_TilesHeader_OSDSGrantor_OSAward : ITestModule
    {
        /// <summary>
        /// Holds an instance of the Service_Portal_Regression_STGRepository repository.
        /// </summary>
        public static Service_Portal_Regression_STGRepository repo = Service_Portal_Regression_STGRepository.Instance;

        static R1_08_HomePage_TilesHeader_OSDSGrantor_OSAward instance = new R1_08_HomePage_TilesHeader_OSDSGrantor_OSAward();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public R1_08_HomePage_TilesHeader_OSDSGrantor_OSAward()
        {
            OSDS_Grantor_WM = "Hi, Mike Hannigan!";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static R1_08_HomePage_TilesHeader_OSDSGrantor_OSAward Instance
        {
            get { return instance; }
        }

#region Variables

        string _OSDS_Grantor_WM;

        /// <summary>
        /// Gets or sets the value of variable OSDS_Grantor_WM.
        /// </summary>
        [TestVariable("f4764709-5463-4135-968f-fac212c4398e")]
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
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (InnerText=' Award ') on item 'Login1.NavNavbarNavSamsNavbarNav.ATagAward2'.", repo.Login1.NavNavbarNavSamsNavbarNav.ATagAward2Info, new RecordItemIndex(1));
                Validate.AttributeEqual(repo.Login1.NavNavbarNavSamsNavbarNav.ATagAward2Info, "InnerText", " Award ", null, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(1)); }
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.NavNavbarNavSamsNavbarNav.ATagAward2' at 53;29.", repo.Login1.NavNavbarNavSamsNavbarNav.ATagAward2Info, new RecordItemIndex(2));
            repo.Login1.NavNavbarNavSamsNavbarNav.ATagAward2.Click("53;29");
            Delay.Milliseconds(200);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (InnerText='Awards') on item 'Login1.NavNavbarNavSamsNavbarNav.Awards'.", repo.Login1.NavNavbarNavSamsNavbarNav.AwardsInfo, new RecordItemIndex(3));
                Validate.AttributeEqual(repo.Login1.NavNavbarNavSamsNavbarNav.AwardsInfo, "InnerText", "Awards", null, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(3)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (InnerText='View Payment Requests') on item 'Login1.NavNavbarNavSamsNavbarNav.ViewPaymentRequests'.", repo.Login1.NavNavbarNavSamsNavbarNav.ViewPaymentRequestsInfo, new RecordItemIndex(4));
                Validate.AttributeEqual(repo.Login1.NavNavbarNavSamsNavbarNav.ViewPaymentRequestsInfo, "InnerText", "View Payment Requests", null, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(4)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (InnerText='Navigate to Ariba') on item 'Login1.NavNavbarNavSamsNavbarNav.NavigateToAriba1'.", repo.Login1.NavNavbarNavSamsNavbarNav.NavigateToAriba1Info, new RecordItemIndex(5));
                Validate.AttributeEqual(repo.Login1.NavNavbarNavSamsNavbarNav.NavigateToAriba1Info, "InnerText", "Navigate to Ariba", null, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(5)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (InnerText='Navigate to eFiling') on item 'Login1.NavNavbarNavSamsNavbarNav.NavigateToEFiling1'.", repo.Login1.NavNavbarNavSamsNavbarNav.NavigateToEFiling1Info, new RecordItemIndex(6));
                Validate.AttributeEqual(repo.Login1.NavNavbarNavSamsNavbarNav.NavigateToEFiling1Info, "InnerText", "Navigate to eFiling", null, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(6)); }
            
            // Award Tile Screenshot
            Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(7));
            
            // Award
            Report.Log(ReportLevel.Info, "Section", "Award", new RecordItemIndex(8));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.NavNavbarNavSamsNavbarNav.Awards' at 42;14.", repo.Login1.NavNavbarNavSamsNavbarNav.AwardsInfo, new RecordItemIndex(9));
            repo.Login1.NavNavbarNavSamsNavbarNav.Awards.Click("42;14");
            Delay.Milliseconds(200);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating Exists on item 'Login1.FormInlinePanelHeading.NoticeOfAwards'.", repo.Login1.FormInlinePanelHeading.NoticeOfAwardsInfo, new RecordItemIndex(10));
                Validate.Exists(repo.Login1.FormInlinePanelHeading.NoticeOfAwardsInfo, null, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(10)); }
            
            // Awards Table Screenshot
            Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(11));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.NavNavbarNavSamsNavbarNav.HOME' at 14;7.", repo.Login1.NavNavbarNavSamsNavbarNav.HOMEInfo, new RecordItemIndex(12));
            repo.Login1.NavNavbarNavSamsNavbarNav.HOME.Click("14;7");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s for the attribute 'InnerText' to equal the specified value $OSDS_Grantor_WM. Associated repository item: 'Login1.HiMikeHannigan'", repo.Login1.HiMikeHanniganInfo, new RecordItemIndex(13));
            repo.Login1.HiMikeHanniganInfo.WaitForAttributeEqual(5000, "InnerText", OSDS_Grantor_WM);
            
            // View Payment Requests
            Report.Log(ReportLevel.Info, "Section", "View Payment Requests", new RecordItemIndex(14));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.NavNavbarNavSamsNavbarNav.ATagAward2' at 59;36.", repo.Login1.NavNavbarNavSamsNavbarNav.ATagAward2Info, new RecordItemIndex(15));
            repo.Login1.NavNavbarNavSamsNavbarNav.ATagAward2.Click("59;36");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.NavNavbarNavSamsNavbarNav.ViewPaymentRequests' at 74;12.", repo.Login1.NavNavbarNavSamsNavbarNav.ViewPaymentRequestsInfo, new RecordItemIndex(16));
            repo.Login1.NavNavbarNavSamsNavbarNav.ViewPaymentRequests.Click("74;12");
            Delay.Milliseconds(200);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (InnerText='Payments') on item 'Login1.FormInlinePanelHeading.Payments'.", repo.Login1.FormInlinePanelHeading.PaymentsInfo, new RecordItemIndex(17));
                Validate.AttributeEqual(repo.Login1.FormInlinePanelHeading.PaymentsInfo, "InnerText", "Payments", null, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(17)); }
            
            // Payment Requests Table Screenshot
            Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(18));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.NavNavbarNavSamsNavbarNav.HOME' at 14;7.", repo.Login1.NavNavbarNavSamsNavbarNav.HOMEInfo, new RecordItemIndex(19));
            repo.Login1.NavNavbarNavSamsNavbarNav.HOME.Click("14;7");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s for the attribute 'InnerText' to equal the specified value $OSDS_Grantor_WM. Associated repository item: 'Login1.HiMikeHannigan'", repo.Login1.HiMikeHanniganInfo, new RecordItemIndex(20));
            repo.Login1.HiMikeHanniganInfo.WaitForAttributeEqual(5000, "InnerText", OSDS_Grantor_WM);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
