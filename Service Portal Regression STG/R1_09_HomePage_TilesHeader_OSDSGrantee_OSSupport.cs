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
    ///The R1_09_HomePage_TilesHeader_OSDSGrantee_OSSupport recording.
    /// </summary>
    [TestModule("3348e4b3-7503-42ef-8410-4512bcc8d01f", ModuleType.Recording, 1)]
    public partial class R1_09_HomePage_TilesHeader_OSDSGrantee_OSSupport : ITestModule
    {
        /// <summary>
        /// Holds an instance of the Service_Portal_Regression_STGRepository repository.
        /// </summary>
        public static Service_Portal_Regression_STGRepository repo = Service_Portal_Regression_STGRepository.Instance;

        static R1_09_HomePage_TilesHeader_OSDSGrantee_OSSupport instance = new R1_09_HomePage_TilesHeader_OSDSGrantee_OSSupport();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public R1_09_HomePage_TilesHeader_OSDSGrantee_OSSupport()
        {
            OSDS_Grantee_WM = "Hi, Ross Geller!";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static R1_09_HomePage_TilesHeader_OSDSGrantee_OSSupport Instance
        {
            get { return instance; }
        }

#region Variables

        string _OSDS_Grantee_WM;

        /// <summary>
        /// Gets or sets the value of variable OSDS_Grantee_WM.
        /// </summary>
        [TestVariable("c4960af9-6af7-4a9b-8e7e-3bd87a7f2d6b")]
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
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (InnerText=' Support ') on item 'Login1.NavNavbarNavSamsNavbarNav.ATagSupport3'.", repo.Login1.NavNavbarNavSamsNavbarNav.ATagSupport3Info, new RecordItemIndex(1));
                Validate.AttributeEqual(repo.Login1.NavNavbarNavSamsNavbarNav.ATagSupport3Info, "InnerText", " Support ", null, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(1)); }
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.NavNavbarNavSamsNavbarNav.ATagSupport3' at 61;37.", repo.Login1.NavNavbarNavSamsNavbarNav.ATagSupport3Info, new RecordItemIndex(2));
            repo.Login1.NavNavbarNavSamsNavbarNav.ATagSupport3.Click("61;37");
            Delay.Milliseconds(200);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (InnerText='Grantee Training Resources') on item 'Login1.NavNavbarNavSamsNavbarNav.GranteeTrainingResources3'.", repo.Login1.NavNavbarNavSamsNavbarNav.GranteeTrainingResources3Info, new RecordItemIndex(3));
                Validate.AttributeEqual(repo.Login1.NavNavbarNavSamsNavbarNav.GranteeTrainingResources3Info, "InnerText", "Grantee Training Resources", null, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(3)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (InnerText='Support') on item 'Login1.NavNavbarNavSamsNavbarNav.Support4'.", repo.Login1.NavNavbarNavSamsNavbarNav.Support4Info, new RecordItemIndex(4));
                Validate.AttributeEqual(repo.Login1.NavNavbarNavSamsNavbarNav.Support4Info, "InnerText", "Support", null, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(4)); }
            
            // Support Screenshot
            Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(5));
            
            // Grantee Training Resources
            Report.Log(ReportLevel.Info, "Section", "Grantee Training Resources", new RecordItemIndex(6));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.NavNavbarNavSamsNavbarNav.GranteeTrainingResources3' at 61;9.", repo.Login1.NavNavbarNavSamsNavbarNav.GranteeTrainingResources3Info, new RecordItemIndex(7));
            repo.Login1.NavNavbarNavSamsNavbarNav.GranteeTrainingResources3.Click("61;9");
            Delay.Milliseconds(200);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating Exists on item 'Login1.HttpsMygrantstrainServiceNowComDe'.", repo.Login1.HttpsMygrantstrainServiceNowComDeInfo, new RecordItemIndex(8));
                Validate.Exists(repo.Login1.HttpsMygrantstrainServiceNowComDeInfo, null, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(8)); }
            
            // Grantee Training Resources Screenshot
            Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(9));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.NavNavbarNavSamsNavbarNav.HOME' at 14;7.", repo.Login1.NavNavbarNavSamsNavbarNav.HOMEInfo, new RecordItemIndex(10));
            repo.Login1.NavNavbarNavSamsNavbarNav.HOME.Click("14;7");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s for the attribute 'InnerText' to equal the specified value $OSDS_Grantee_WM. Associated repository item: 'Login1.HiRossGeller'", repo.Login1.HiRossGellerInfo, new RecordItemIndex(11));
            repo.Login1.HiRossGellerInfo.WaitForAttributeEqual(5000, "InnerText", OSDS_Grantee_WM);
            
            // Support
            Report.Log(ReportLevel.Info, "Section", "Support", new RecordItemIndex(12));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.NavNavbarNavSamsNavbarNav.ATagSupport3' at 59;37.", repo.Login1.NavNavbarNavSamsNavbarNav.ATagSupport3Info, new RecordItemIndex(13));
            repo.Login1.NavNavbarNavSamsNavbarNav.ATagSupport3.Click("59;37");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.NavNavbarNavSamsNavbarNav.Support4' at 40;10.", repo.Login1.NavNavbarNavSamsNavbarNav.Support4Info, new RecordItemIndex(14));
            repo.Login1.NavNavbarNavSamsNavbarNav.Support4.Click("40;10");
            Delay.Milliseconds(200);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating Exists on item 'Login1.OverseasGranteeSupportPage'.", repo.Login1.OverseasGranteeSupportPageInfo, new RecordItemIndex(15));
                Validate.Exists(repo.Login1.OverseasGranteeSupportPageInfo, null, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(15)); }
            
            // Support Screenshot
            Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(16));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.NavNavbarNavSamsNavbarNav.HOME' at 14;7.", repo.Login1.NavNavbarNavSamsNavbarNav.HOMEInfo, new RecordItemIndex(17));
            repo.Login1.NavNavbarNavSamsNavbarNav.HOME.Click("14;7");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s for the attribute 'InnerText' to equal the specified value $OSDS_Grantee_WM. Associated repository item: 'Login1.HiRossGeller'", repo.Login1.HiRossGellerInfo, new RecordItemIndex(18));
            repo.Login1.HiRossGellerInfo.WaitForAttributeEqual(5000, "InnerText", OSDS_Grantee_WM);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
