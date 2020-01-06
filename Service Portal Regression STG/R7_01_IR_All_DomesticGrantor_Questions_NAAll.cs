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
    ///The R7_01_IR_All_DomesticGrantor_Questions_NAAll recording.
    /// </summary>
    [TestModule("1346667f-c82b-4b9b-90eb-1d961c7e5510", ModuleType.Recording, 1)]
    public partial class R7_01_IR_All_DomesticGrantor_Questions_NAAll : ITestModule
    {
        /// <summary>
        /// Holds an instance of the Service_Portal_Regression_STGRepository repository.
        /// </summary>
        public static Service_Portal_Regression_STGRepository repo = Service_Portal_Regression_STGRepository.Instance;

        static R7_01_IR_All_DomesticGrantor_Questions_NAAll instance = new R7_01_IR_All_DomesticGrantor_Questions_NAAll();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public R7_01_IR_All_DomesticGrantor_Questions_NAAll()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static R7_01_IR_All_DomesticGrantor_Questions_NAAll Instance
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

            // N/A All
            Report.Log(ReportLevel.Info, "Section", "N/A All", new RecordItemIndex(0));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.FormInlinePanelHeading.NAAll' at 27;20.", repo.Login1.FormInlinePanelHeading.NAAllInfo, new RecordItemIndex(1));
            repo.Login1.FormInlinePanelHeading.NAAll.Click("27;20");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{enter}'.", new RecordItemIndex(2));
            Keyboard.Press("{enter}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 25s.", new RecordItemIndex(3));
            Delay.Duration(25000, false);
            
            Report.Log(ReportLevel.Info, "Invoke action", "Invoking WaitForDocumentLoaded('120000ms') on item 'Login1'.", repo.Login1.SelfInfo, new RecordItemIndex(4));
            repo.Login1.Self.WaitForDocumentLoaded(ValueConverter.ArgumentFromString<Ranorex.Duration>("timeout", "120000ms"));
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 3s.", new RecordItemIndex(5));
            Delay.Duration(3000, false);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}