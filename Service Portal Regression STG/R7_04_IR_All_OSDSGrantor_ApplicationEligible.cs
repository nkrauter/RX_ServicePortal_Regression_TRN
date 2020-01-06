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
    ///The R7_04_IR_All_OSDSGrantor_ApplicationEligible recording.
    /// </summary>
    [TestModule("60e2ef13-d135-4b5e-a9c2-e3f0211f76af", ModuleType.Recording, 1)]
    public partial class R7_04_IR_All_OSDSGrantor_ApplicationEligible : ITestModule
    {
        /// <summary>
        /// Holds an instance of the Service_Portal_Regression_STGRepository repository.
        /// </summary>
        public static Service_Portal_Regression_STGRepository repo = Service_Portal_Regression_STGRepository.Instance;

        static R7_04_IR_All_OSDSGrantor_ApplicationEligible instance = new R7_04_IR_All_OSDSGrantor_ApplicationEligible();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public R7_04_IR_All_OSDSGrantor_ApplicationEligible()
        {
            Application_Eligible = "Eligible";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static R7_04_IR_All_OSDSGrantor_ApplicationEligible Instance
        {
            get { return instance; }
        }

#region Variables

        string _Application_Eligible;

        /// <summary>
        /// Gets or sets the value of variable Application_Eligible.
        /// </summary>
        [TestVariable("373cf1eb-7866-437c-9418-37cdc0d92ebb")]
        public string Application_Eligible
        {
            get { return _Application_Eligible; }
            set { _Application_Eligible = value; }
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

            // Intake Review Additional Action
            Report.Log(ReportLevel.Info, "Section", "Intake Review Additional Action", new RecordItemIndex(0));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.FormInlinePanelHeading.IntakeReviews' at 53;17.", repo.Login1.FormInlinePanelHeading.IntakeReviewsInfo, new RecordItemIndex(1));
            repo.Login1.FormInlinePanelHeading.IntakeReviews.Click("53;17");
            Delay.Milliseconds(200);
            
            // Intake Review Record Select
            Report.Log(ReportLevel.Info, "Section", "Intake Review Record Select", new RecordItemIndex(2));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.C8d73b9a2db393b0016bc300f7c961903NgSco.NMKRanorexInternalTitle' at 87;14.", repo.Login1.C8d73b9a2db393b0016bc300f7c961903NgSco.NMKRanorexInternalTitleInfo, new RecordItemIndex(3));
            repo.Login1.C8d73b9a2db393b0016bc300f7c961903NgSco.NMKRanorexInternalTitle.Click("87;14");
            Delay.Milliseconds(200);
            
            // Intake Review +
            Report.Log(ReportLevel.Info, "Section", "Intake Review +", new RecordItemIndex(4));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.C8d73b9a2db393b0016bc300f7c961903NgSco.FaFaPlusSquareO2' at 13;8.", repo.Login1.C8d73b9a2db393b0016bc300f7c961903NgSco.FaFaPlusSquareO2Info, new RecordItemIndex(5));
            repo.Login1.C8d73b9a2db393b0016bc300f7c961903NgSco.FaFaPlusSquareO2.Click("13;8");
            Delay.Milliseconds(200);
            
            // Application Eligible
            Report.Log(ReportLevel.Info, "Section", "Application Eligible", new RecordItemIndex(6));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.FO_Number' at 182;25.", repo.Login1.FO_NumberInfo, new RecordItemIndex(7));
            repo.Login1.FO_Number.Click("182;25");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LShiftKey down}{Tab 35}{LShiftKey up}' with focus on 'Login1'.", repo.Login1.SelfInfo, new RecordItemIndex(8));
            repo.Login1.Self.EnsureVisible();
            Keyboard.Press("{LShiftKey down}{Tab 35}{LShiftKey up}", 15);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Application_Eligible'.", new RecordItemIndex(9));
            Keyboard.Press(Application_Eligible);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(10));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{enter}'.", new RecordItemIndex(11));
            Keyboard.Press("{enter}");
            Delay.Milliseconds(0);
            
            // Save
            Report.Log(ReportLevel.Info, "Section", "Save", new RecordItemIndex(12));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.C8d73b9a2db393b0016bc300f7c961903NgSco.Save' at 40;26.", repo.Login1.C8d73b9a2db393b0016bc300f7c961903NgSco.SaveInfo, new RecordItemIndex(13));
            repo.Login1.C8d73b9a2db393b0016bc300f7c961903NgSco.Save.Click("40;26");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating Exists on item 'Login1.C8d73b9a2db393b0016bc300f7c961903NgSco.NMKRanorexInternalTitle'.", repo.Login1.C8d73b9a2db393b0016bc300f7c961903NgSco.NMKRanorexInternalTitleInfo, new RecordItemIndex(14));
            Validate.Exists(repo.Login1.C8d73b9a2db393b0016bc300f7c961903NgSco.NMKRanorexInternalTitleInfo);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking WaitForDocumentLoaded() on item 'Login1'.", repo.Login1.SelfInfo, new RecordItemIndex(15));
            repo.Login1.Self.WaitForDocumentLoaded();
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}