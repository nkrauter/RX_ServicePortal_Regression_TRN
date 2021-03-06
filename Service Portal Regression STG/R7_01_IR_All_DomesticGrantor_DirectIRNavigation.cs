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
    ///The R7_01_IR_All_DomesticGrantor_DirectIRNavigation recording.
    /// </summary>
    [TestModule("1fe7bbdd-9dcf-4f6e-b776-89caf1808f55", ModuleType.Recording, 1)]
    public partial class R7_01_IR_All_DomesticGrantor_DirectIRNavigation : ITestModule
    {
        /// <summary>
        /// Holds an instance of the Service_Portal_Regression_STGRepository repository.
        /// </summary>
        public static Service_Portal_Regression_STGRepository repo = Service_Portal_Regression_STGRepository.Instance;

        static R7_01_IR_All_DomesticGrantor_DirectIRNavigation instance = new R7_01_IR_All_DomesticGrantor_DirectIRNavigation();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public R7_01_IR_All_DomesticGrantor_DirectIRNavigation()
        {
            Application_Number = "SAPP0048104";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static R7_01_IR_All_DomesticGrantor_DirectIRNavigation Instance
        {
            get { return instance; }
        }

#region Variables

        string _Application_Number;

        /// <summary>
        /// Gets or sets the value of variable Application_Number.
        /// </summary>
        [TestVariable("8c77f830-9aaf-44a8-9666-1a7efd569ff8")]
        public string Application_Number
        {
            get { return _Application_Number; }
            set { _Application_Number = value; }
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

            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.NavNavbarNavSamsNavbarNav.ATagHome' at 84;50.", repo.Login1.NavNavbarNavSamsNavbarNav.ATagHomeInfo, new RecordItemIndex(0));
            repo.Login1.NavNavbarNavSamsNavbarNav.ATagHome.Click("84;50");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking WaitForDocumentLoaded() on item 'Login1'.", repo.Login1.SelfInfo, new RecordItemIndex(1));
            repo.Login1.Self.WaitForDocumentLoaded();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.NavNavbarNavSamsNavbarNav.ATagPreAward' at 104;53.", repo.Login1.NavNavbarNavSamsNavbarNav.ATagPreAwardInfo, new RecordItemIndex(2));
            repo.Login1.NavNavbarNavSamsNavbarNav.ATagPreAward.Click("104;53");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.NavNavbarNavSamsNavbarNav.Applications' at 90;10.", repo.Login1.NavNavbarNavSamsNavbarNav.ApplicationsInfo, new RecordItemIndex(3));
            repo.Login1.NavNavbarNavSamsNavbarNav.Applications.Click("90;10");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.FormInlinePanelHeading.DatatableSearch5' at 81;25.", repo.Login1.FormInlinePanelHeading.DatatableSearch5Info, new RecordItemIndex(4));
            repo.Login1.FormInlinePanelHeading.DatatableSearch5.Click("81;25");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Application_Number'.", new RecordItemIndex(5));
            Keyboard.Press(Application_Number);
            Delay.Milliseconds(30);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{tab}{enter}'.", new RecordItemIndex(6));
            Keyboard.Press("{tab}{enter}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking WaitForDocumentLoaded() on item 'Login1'.", repo.Login1.SelfInfo, new RecordItemIndex(7));
            repo.Login1.Self.WaitForDocumentLoaded();
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(8));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.C8d73b9a2db393b0016bc300f7c961903NgSco.NMKRanorexInternalTitle' at 145;18.", repo.Login1.C8d73b9a2db393b0016bc300f7c961903NgSco.NMKRanorexInternalTitleInfo, new RecordItemIndex(9));
            repo.Login1.C8d73b9a2db393b0016bc300f7c961903NgSco.NMKRanorexInternalTitle.Click("145;18");
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
