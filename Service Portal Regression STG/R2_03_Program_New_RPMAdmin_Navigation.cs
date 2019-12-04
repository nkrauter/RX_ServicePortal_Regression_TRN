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
    ///The R2_03_Program_New_RPMAdmin_Navigation recording.
    /// </summary>
    [TestModule("4cc5ce2b-8ed9-405a-9e9f-93287b093e81", ModuleType.Recording, 1)]
    public partial class R2_03_Program_New_RPMAdmin_Navigation : ITestModule
    {
        /// <summary>
        /// Holds an instance of the Service_Portal_Regression_STGRepository repository.
        /// </summary>
        public static Service_Portal_Regression_STGRepository repo = Service_Portal_Regression_STGRepository.Instance;

        static R2_03_Program_New_RPMAdmin_Navigation instance = new R2_03_Program_New_RPMAdmin_Navigation();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public R2_03_Program_New_RPMAdmin_Navigation()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static R2_03_Program_New_RPMAdmin_Navigation Instance
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
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            // New Program Navigation
            Report.Log(ReportLevel.Info, "Section", "New Program Navigation", new RecordItemIndex(0));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.NavNavbarNavSamsNavbarNav.ATagPlanning' at 54;36.", repo.Login1.NavNavbarNavSamsNavbarNav.ATagPlanningInfo, new RecordItemIndex(1));
            repo.Login1.NavNavbarNavSamsNavbarNav.ATagPlanning.Click("54;36");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.NavNavbarNavSamsNavbarNav.Programs1' at 46;9.", repo.Login1.NavNavbarNavSamsNavbarNav.Programs1Info, new RecordItemIndex(2));
            repo.Login1.NavNavbarNavSamsNavbarNav.Programs1.Click("46;9");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.FormInlinePanelHeading.ButtonTagNew' at 21;13.", repo.Login1.FormInlinePanelHeading.ButtonTagNewInfo, new RecordItemIndex(3));
            repo.Login1.FormInlinePanelHeading.ButtonTagNew.Click("21;13");
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
