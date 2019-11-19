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
    ///The R1_07_HomePage_Footer_OSGrantee_Support recording.
    /// </summary>
    [TestModule("350225ff-7caf-4e7d-b389-3ef17c85dff9", ModuleType.Recording, 1)]
    public partial class R1_07_HomePage_Footer_OSGrantee_Support : ITestModule
    {
        /// <summary>
        /// Holds an instance of the Service_Portal_Regression_STGRepository repository.
        /// </summary>
        public static Service_Portal_Regression_STGRepository repo = Service_Portal_Regression_STGRepository.Instance;

        static R1_07_HomePage_Footer_OSGrantee_Support instance = new R1_07_HomePage_Footer_OSGrantee_Support();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public R1_07_HomePage_Footer_OSGrantee_Support()
        {
            OSGrantee_WM = "Hi, Phoebe Buffay!";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static R1_07_HomePage_Footer_OSGrantee_Support Instance
        {
            get { return instance; }
        }

#region Variables

        string _OSGrantee_WM;

        /// <summary>
        /// Gets or sets the value of variable OSGrantee_WM.
        /// </summary>
        [TestVariable("b1098710-af37-4b57-98e4-ca70b52f8fc0")]
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
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            // Header Links
            Report.Log(ReportLevel.Info, "Section", "Header Links", new RecordItemIndex(0));
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (InnerText='Support') on item 'Login1.NgScope1.Support'.", repo.Login1.NgScope1.SupportInfo, new RecordItemIndex(1));
                Validate.AttributeEqual(repo.Login1.NgScope1.SupportInfo, "InnerText", "Support", null, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(1)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (InnerText='Grantee Training Resources') on item 'Login1.NgScope1.GranteeTrainingResources'.", repo.Login1.NgScope1.GranteeTrainingResourcesInfo, new RecordItemIndex(2));
                Validate.AttributeEqual(repo.Login1.NgScope1.GranteeTrainingResourcesInfo, "InnerText", "Grantee Training Resources", null, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(2)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (InnerText='Support') on item 'Login1.NgScope1.Support1'.", repo.Login1.NgScope1.Support1Info, new RecordItemIndex(3));
                Validate.AttributeEqual(repo.Login1.NgScope1.Support1Info, "InnerText", "Support", null, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(3)); }
            
            // Support Screenshot
            Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(4));
            
            // Grantee Training Resources
            Report.Log(ReportLevel.Info, "Section", "Grantee Training Resources", new RecordItemIndex(5));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.NgScope1.GranteeTrainingResources' at 15;16.", repo.Login1.NgScope1.GranteeTrainingResourcesInfo, new RecordItemIndex(6));
            repo.Login1.NgScope1.GranteeTrainingResources.Click("15;16");
            Delay.Milliseconds(200);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating Exists on item 'Login1.HttpsMygrantstrainServiceNowComDe'.", repo.Login1.HttpsMygrantstrainServiceNowComDeInfo, new RecordItemIndex(7));
                Validate.Exists(repo.Login1.HttpsMygrantstrainServiceNowComDeInfo, null, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(7)); }
            
            // Grantee Training Resources Screenshot
            Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(8));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.NavNavbarNavSamsNavbarNav.HOME' at 14;7.", repo.Login1.NavNavbarNavSamsNavbarNav.HOMEInfo, new RecordItemIndex(9));
            repo.Login1.NavNavbarNavSamsNavbarNav.HOME.Click("14;7");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 10s for the attribute 'InnerText' to equal the specified value $OSGrantee_WM. Associated repository item: 'Login1.HiPhoebeBuffay'", repo.Login1.HiPhoebeBuffayInfo, new RecordItemIndex(10));
            repo.Login1.HiPhoebeBuffayInfo.WaitForAttributeEqual(10000, "InnerText", OSGrantee_WM);
            
            // Support
            Report.Log(ReportLevel.Info, "Section", "Support", new RecordItemIndex(11));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -720 units.", new RecordItemIndex(12));
            Mouse.ScrollWheel(-720);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.NgScope1.Support1' at 29;8.", repo.Login1.NgScope1.Support1Info, new RecordItemIndex(13));
            repo.Login1.NgScope1.Support1.Click("29;8");
            Delay.Milliseconds(200);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating Exists on item 'Login1.OverseasGranteeSupportPage'.", repo.Login1.OverseasGranteeSupportPageInfo, new RecordItemIndex(14));
                Validate.Exists(repo.Login1.OverseasGranteeSupportPageInfo, null, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(14)); }
            
            // Support Screenshot
            Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(15));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.NavNavbarNavSamsNavbarNav.HOME' at 14;7.", repo.Login1.NavNavbarNavSamsNavbarNav.HOMEInfo, new RecordItemIndex(16));
            repo.Login1.NavNavbarNavSamsNavbarNav.HOME.Click("14;7");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 10s for the attribute 'InnerText' to equal the specified value $OSGrantee_WM. Associated repository item: 'Login1.HiPhoebeBuffay'", repo.Login1.HiPhoebeBuffayInfo, new RecordItemIndex(17));
            repo.Login1.HiPhoebeBuffayInfo.WaitForAttributeEqual(10000, "InnerText", OSGrantee_WM);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}