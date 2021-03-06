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
    ///The R1_06_HomePage_Footer_OSGrantor_Support recording.
    /// </summary>
    [TestModule("bc10315f-f5bd-4972-8b7d-1b39369ffdec", ModuleType.Recording, 1)]
    public partial class R1_06_HomePage_Footer_OSGrantor_Support : ITestModule
    {
        /// <summary>
        /// Holds an instance of the Service_Portal_Regression_STGRepository repository.
        /// </summary>
        public static Service_Portal_Regression_STGRepository repo = Service_Portal_Regression_STGRepository.Instance;

        static R1_06_HomePage_Footer_OSGrantor_Support instance = new R1_06_HomePage_Footer_OSGrantor_Support();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public R1_06_HomePage_Footer_OSGrantor_Support()
        {
            OSGrantor_WM = "Hi, Frank Buffay!";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static R1_06_HomePage_Footer_OSGrantor_Support Instance
        {
            get { return instance; }
        }

#region Variables

        string _OSGrantor_WM;

        /// <summary>
        /// Gets or sets the value of variable OSGrantor_WM.
        /// </summary>
        [TestVariable("d6935795-a664-4939-84c9-94ea6f0fcc9c")]
        public string OSGrantor_WM
        {
            get { return _OSGrantor_WM; }
            set { _OSGrantor_WM = value; }
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
            Delay.Milliseconds(100);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (InnerText='Support') on item 'Login1.NgScope2.Support'.", repo.Login1.NgScope2.SupportInfo, new RecordItemIndex(2));
                Validate.AttributeEqual(repo.Login1.NgScope2.SupportInfo, "InnerText", "Support", null, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(2)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (InnerText='Grantor Training Resources') on item 'Login1.NgScope2.GrantorTrainingResources'.", repo.Login1.NgScope2.GrantorTrainingResourcesInfo, new RecordItemIndex(3));
                Validate.AttributeEqual(repo.Login1.NgScope2.GrantorTrainingResourcesInfo, "InnerText", "Grantor Training Resources", null, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(3)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (InnerText='Grantee Training Resources') on item 'Login1.NgScope2.GranteeTrainingResources'.", repo.Login1.NgScope2.GranteeTrainingResourcesInfo, new RecordItemIndex(4));
                Validate.AttributeEqual(repo.Login1.NgScope2.GranteeTrainingResourcesInfo, "InnerText", "Grantee Training Resources", null, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(4)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (InnerText='Support') on item 'Login1.NgScope2.Support1'.", repo.Login1.NgScope2.Support1Info, new RecordItemIndex(5));
                Validate.AttributeEqual(repo.Login1.NgScope2.Support1Info, "InnerText", "Support", null, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(5)); }
            
            // Support Footer Screenshot
            Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(6));
            
            // Grantor Training Resources
            Report.Log(ReportLevel.Info, "Section", "Grantor Training Resources", new RecordItemIndex(7));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.NgScope2.GrantorTrainingResources' at 47;5.", repo.Login1.NgScope2.GrantorTrainingResourcesInfo, new RecordItemIndex(8));
            repo.Login1.NgScope2.GrantorTrainingResources.Click("47;5");
            Delay.Milliseconds(200);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating Exists on item 'Login1.HttpsMygrantstrainServiceNowComDe'.", repo.Login1.HttpsMygrantstrainServiceNowComDeInfo, new RecordItemIndex(9));
                Validate.Exists(repo.Login1.HttpsMygrantstrainServiceNowComDeInfo, null, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(9)); }
            
            // Grantor Training Resources Screenshot
            Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(10));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.NavNavbarNavSamsNavbarNav.HOME' at 14;7.", repo.Login1.NavNavbarNavSamsNavbarNav.HOMEInfo, new RecordItemIndex(11));
            repo.Login1.NavNavbarNavSamsNavbarNav.HOME.Click("14;7");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 10s for the attribute 'InnerText' to equal the specified value $OSGrantor_WM. Associated repository item: 'Login1.HiFrankBuffay'", repo.Login1.HiFrankBuffayInfo, new RecordItemIndex(12));
            repo.Login1.HiFrankBuffayInfo.WaitForAttributeEqual(10000, "InnerText", OSGrantor_WM);
            
            // Grantee Training Resources
            Report.Log(ReportLevel.Info, "Section", "Grantee Training Resources", new RecordItemIndex(13));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -840 units.", new RecordItemIndex(14));
            Mouse.ScrollWheel(-840);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.NgScope2.GranteeTrainingResources' at 29;12.", repo.Login1.NgScope2.GranteeTrainingResourcesInfo, new RecordItemIndex(15));
            repo.Login1.NgScope2.GranteeTrainingResources.Click("29;12");
            Delay.Milliseconds(200);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating Exists on item 'Login1.HttpsMygrantstrainServiceNowComDe'.", repo.Login1.HttpsMygrantstrainServiceNowComDeInfo, new RecordItemIndex(16));
                Validate.Exists(repo.Login1.HttpsMygrantstrainServiceNowComDeInfo, null, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(16)); }
            
            // Grantee Training Resources Screenshot
            Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(17));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.NavNavbarNavSamsNavbarNav.HOME' at 14;7.", repo.Login1.NavNavbarNavSamsNavbarNav.HOMEInfo, new RecordItemIndex(18));
            repo.Login1.NavNavbarNavSamsNavbarNav.HOME.Click("14;7");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 10s for the attribute 'InnerText' to equal the specified value $OSGrantor_WM. Associated repository item: 'Login1.HiFrankBuffay'", repo.Login1.HiFrankBuffayInfo, new RecordItemIndex(19));
            repo.Login1.HiFrankBuffayInfo.WaitForAttributeEqual(10000, "InnerText", OSGrantor_WM);
            
            // Support
            Report.Log(ReportLevel.Info, "Section", "Support", new RecordItemIndex(20));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -840 units.", new RecordItemIndex(21));
            Mouse.ScrollWheel(-840);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.NgScope2.Support1' at 29;10.", repo.Login1.NgScope2.Support1Info, new RecordItemIndex(22));
            repo.Login1.NgScope2.Support1.Click("29;10");
            Delay.Milliseconds(200);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (InnerText='Overseas Grantor Support ') on item 'Login1.OverseasGrantorSupport'.", repo.Login1.OverseasGrantorSupportInfo, new RecordItemIndex(23));
                Validate.AttributeEqual(repo.Login1.OverseasGrantorSupportInfo, "InnerText", "Overseas Grantor Support ", null, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(23)); }
            
            // Support Screenshot
            Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(24));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.NavNavbarNavSamsNavbarNav.HOME' at 14;7.", repo.Login1.NavNavbarNavSamsNavbarNav.HOMEInfo, new RecordItemIndex(25));
            repo.Login1.NavNavbarNavSamsNavbarNav.HOME.Click("14;7");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 10s for the attribute 'InnerText' to equal the specified value $OSGrantor_WM. Associated repository item: 'Login1.HiFrankBuffay'", repo.Login1.HiFrankBuffayInfo, new RecordItemIndex(26));
            repo.Login1.HiFrankBuffayInfo.WaitForAttributeEqual(10000, "InnerText", OSGrantor_WM);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
