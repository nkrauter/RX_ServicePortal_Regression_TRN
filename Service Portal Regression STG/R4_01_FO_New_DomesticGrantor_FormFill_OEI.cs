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
    ///The R4_01_FO_New_DomesticGrantor_FormFill_OEI recording.
    /// </summary>
    [TestModule("6fb07900-9fc9-4adc-83f8-22d2051341ab", ModuleType.Recording, 1)]
    public partial class R4_01_FO_New_DomesticGrantor_FormFill_OEI : ITestModule
    {
        /// <summary>
        /// Holds an instance of the Service_Portal_Regression_STGRepository repository.
        /// </summary>
        public static Service_Portal_Regression_STGRepository repo = Service_Portal_Regression_STGRepository.Instance;

        static R4_01_FO_New_DomesticGrantor_FormFill_OEI instance = new R4_01_FO_New_DomesticGrantor_FormFill_OEI();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public R4_01_FO_New_DomesticGrantor_FormFill_OEI()
        {
            Applicant_Type = "Both, Organizations and Individuals";
            Primary_Eligible_Applicant = "City or Township Governments";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static R4_01_FO_New_DomesticGrantor_FormFill_OEI Instance
        {
            get { return instance; }
        }

#region Variables

        string _Applicant_Type;

        /// <summary>
        /// Gets or sets the value of variable Applicant_Type.
        /// </summary>
        [TestVariable("29089a7f-93df-4078-b464-2e72817918ed")]
        public string Applicant_Type
        {
            get { return _Applicant_Type; }
            set { _Applicant_Type = value; }
        }

        string _Primary_Eligible_Applicant;

        /// <summary>
        /// Gets or sets the value of variable Primary_Eligible_Applicant.
        /// </summary>
        [TestVariable("d2322e93-9849-4743-9d7e-f6627039fdbd")]
        public string Primary_Eligible_Applicant
        {
            get { return _Primary_Eligible_Applicant; }
            set { _Primary_Eligible_Applicant = value; }
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

            // Applicant Type
            Report.Log(ReportLevel.Info, "Section", "Applicant Type", new RecordItemIndex(0));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'Login1.SpFormfieldUExpectedEnd' at 215;31.", repo.Login1.SpFormfieldUExpectedEndInfo, new RecordItemIndex(1));
            repo.Login1.SpFormfieldUExpectedEnd.DoubleClick("215;31");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{tab 2}'.", new RecordItemIndex(2));
            Keyboard.Press("{tab 2}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Applicant_Type'.", new RecordItemIndex(3));
            Keyboard.Press(Applicant_Type);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(4));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{enter}'.", new RecordItemIndex(5));
            Keyboard.Press("{enter}");
            Delay.Milliseconds(0);
            
            // Primary Eligible Applicant
            Report.Log(ReportLevel.Info, "Section", "Primary Eligible Applicant", new RecordItemIndex(6));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left DoubleClick item 'Login1.SpFormfieldUExpectedEnd' at 215;31.", repo.Login1.SpFormfieldUExpectedEndInfo, new RecordItemIndex(7));
            repo.Login1.SpFormfieldUExpectedEnd.DoubleClick("215;31");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{tab 3}'.", new RecordItemIndex(8));
            Keyboard.Press("{tab 3}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Primary_Eligible_Applicant'.", new RecordItemIndex(9));
            Keyboard.Press(Primary_Eligible_Applicant);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(10));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{enter}'.", new RecordItemIndex(11));
            Keyboard.Press("{enter}");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}