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
    ///The R1_07_HomePage_TilesHeader_OSGrantee_Support recording.
    /// </summary>
    [TestModule("9e44cf18-6016-43ae-97a9-5ee97472f99d", ModuleType.Recording, 1)]
    public partial class R1_07_HomePage_TilesHeader_OSGrantee_Support : ITestModule
    {
        /// <summary>
        /// Holds an instance of the Service_Portal_Regression_STGRepository repository.
        /// </summary>
        public static Service_Portal_Regression_STGRepository repo = Service_Portal_Regression_STGRepository.Instance;

        static R1_07_HomePage_TilesHeader_OSGrantee_Support instance = new R1_07_HomePage_TilesHeader_OSGrantee_Support();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public R1_07_HomePage_TilesHeader_OSGrantee_Support()
        {
            OSGrantee_WM = "Hi, Phoebe Buffay!";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static R1_07_HomePage_TilesHeader_OSGrantee_Support Instance
        {
            get { return instance; }
        }

#region Variables

        string _OSGrantee_WM;

        /// <summary>
        /// Gets or sets the value of variable OSGrantee_WM.
        /// </summary>
        [TestVariable("ae38aab9-0543-4c39-91f6-99f5dd9ec4f7")]
        public string OSGrantee_WM
        {
            get { return _OSGrantee_WM; }
            set { _OSGrantee_WM = value; }
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
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 10s for the attribute 'InnerText' to equal the specified value $OSGrantee_WM. Associated repository item: 'Login1.HiPhoebeBuffay'", repo.Login1.HiPhoebeBuffayInfo, new RecordItemIndex(11));
            repo.Login1.HiPhoebeBuffayInfo.WaitForAttributeEqual(10000, "InnerText", OSGrantee_WM);
            
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
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 10s for the attribute 'InnerText' to equal the specified value $OSGrantee_WM. Associated repository item: 'Login1.HiPhoebeBuffay'", repo.Login1.HiPhoebeBuffayInfo, new RecordItemIndex(18));
            repo.Login1.HiPhoebeBuffayInfo.WaitForAttributeEqual(10000, "InnerText", OSGrantee_WM);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
