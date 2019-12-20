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
    ///The R6_01_FP_New_DomesticGrantor_SaveSubmit recording.
    /// </summary>
    [TestModule("290925aa-333c-42fd-a312-87e16c0c875d", ModuleType.Recording, 1)]
    public partial class R6_01_FP_New_DomesticGrantor_SaveSubmit : ITestModule
    {
        /// <summary>
        /// Holds an instance of the Service_Portal_Regression_STGRepository repository.
        /// </summary>
        public static Service_Portal_Regression_STGRepository repo = Service_Portal_Regression_STGRepository.Instance;

        static R6_01_FP_New_DomesticGrantor_SaveSubmit instance = new R6_01_FP_New_DomesticGrantor_SaveSubmit();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public R6_01_FP_New_DomesticGrantor_SaveSubmit()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static R6_01_FP_New_DomesticGrantor_SaveSubmit Instance
        {
            get { return instance; }
        }

#region Variables

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

            // Save Draft
            Report.Log(ReportLevel.Info, "Section", "Save Draft", new RecordItemIndex(0));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.C8d73b9a2db393b0016bc300f7c961903NgSco.SaveDraft' at 63;21.", repo.Login1.C8d73b9a2db393b0016bc300f7c961903NgSco.SaveDraftInfo, new RecordItemIndex(1));
            repo.Login1.C8d73b9a2db393b0016bc300f7c961903NgSco.SaveDraft.Click("63;21");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 5s.", new RecordItemIndex(2));
            Delay.Duration(5000, false);
            
            // Submit
            Report.Log(ReportLevel.Info, "Section", "Submit", new RecordItemIndex(3));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.FO_Number' at 214;22.", repo.Login1.FO_NumberInfo, new RecordItemIndex(4));
            repo.Login1.FO_Number.Click("214;22");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LShiftKey down}{Tab}{LShiftKey up}{Return}' with focus on 'Login1.FO_Number'.", repo.Login1.FO_NumberInfo, new RecordItemIndex(5));
            repo.Login1.FO_Number.PressKeys("{LShiftKey down}{Tab}{LShiftKey up}{Return}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 500ms.", new RecordItemIndex(6));
            Delay.Duration(500, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{enter}'.", new RecordItemIndex(7));
            Keyboard.Press("{enter}");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
