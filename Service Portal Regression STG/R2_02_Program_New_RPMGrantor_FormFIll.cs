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
    ///The R2_02_Program_New_RPMGrantor_FormFIll recording.
    /// </summary>
    [TestModule("643edf6b-a7c9-4f97-b441-8b55b0ec9877", ModuleType.Recording, 1)]
    public partial class R2_02_Program_New_RPMGrantor_FormFIll : ITestModule
    {
        /// <summary>
        /// Holds an instance of the Service_Portal_Regression_STGRepository repository.
        /// </summary>
        public static Service_Portal_Regression_STGRepository repo = Service_Portal_Regression_STGRepository.Instance;

        static R2_02_Program_New_RPMGrantor_FormFIll instance = new R2_02_Program_New_RPMGrantor_FormFIll();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public R2_02_Program_New_RPMGrantor_FormFIll()
        {
            Program_Period_From = "2022-02-05 14:57:28";
            Program_Period_To = "2023-02-05 14:57:28";
            Program_Title = "NMK Ranorex Program Test";
            Program_Description = "Ranorex Program Description";
            Primary_Requesting_Office = "BUREAU OF POPULATION, REFUGEES AND MIGRATION (PRM)";
            Awarding_Office = "CONTRACT ADMIN AND PROCUREMENT BRANCH (DS/EX/OA/ASD/CAP)";
            CFDA1_Number = "19.010";
            Planned_Program_Spend = "1000";
            Additional_Comments = "Ranorex Test Comment";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static R2_02_Program_New_RPMGrantor_FormFIll Instance
        {
            get { return instance; }
        }

#region Variables

        string _Program_Period_From;

        /// <summary>
        /// Gets or sets the value of variable Program_Period_From.
        /// </summary>
        [TestVariable("d91e7f24-142d-429c-8f2f-ddb4bb2f42e2")]
        public string Program_Period_From
        {
            get { return _Program_Period_From; }
            set { _Program_Period_From = value; }
        }

        string _Program_Period_To;

        /// <summary>
        /// Gets or sets the value of variable Program_Period_To.
        /// </summary>
        [TestVariable("5ef81dba-5ad5-417e-92a2-65906cbd8ac0")]
        public string Program_Period_To
        {
            get { return _Program_Period_To; }
            set { _Program_Period_To = value; }
        }

        string _Program_Title;

        /// <summary>
        /// Gets or sets the value of variable Program_Title.
        /// </summary>
        [TestVariable("1bffcdff-a4e5-4a21-9615-7ba0eef3aa0b")]
        public string Program_Title
        {
            get { return _Program_Title; }
            set { _Program_Title = value; }
        }

        string _Program_Description;

        /// <summary>
        /// Gets or sets the value of variable Program_Description.
        /// </summary>
        [TestVariable("61e3c6a3-44a3-4807-a9c2-f29b016b0c1a")]
        public string Program_Description
        {
            get { return _Program_Description; }
            set { _Program_Description = value; }
        }

        string _Primary_Requesting_Office;

        /// <summary>
        /// Gets or sets the value of variable Primary_Requesting_Office.
        /// </summary>
        [TestVariable("e97857c2-6c88-440f-89ec-f1ae267ceff3")]
        public string Primary_Requesting_Office
        {
            get { return _Primary_Requesting_Office; }
            set { _Primary_Requesting_Office = value; }
        }

        string _Awarding_Office;

        /// <summary>
        /// Gets or sets the value of variable Awarding_Office.
        /// </summary>
        [TestVariable("12d1adb4-5a9f-483d-a7f0-e607e925a2c5")]
        public string Awarding_Office
        {
            get { return _Awarding_Office; }
            set { _Awarding_Office = value; }
        }

        string _CFDA1_Number;

        /// <summary>
        /// Gets or sets the value of variable CFDA1_Number.
        /// </summary>
        [TestVariable("ae0edcb2-070e-47ac-b4f7-391226dc7d41")]
        public string CFDA1_Number
        {
            get { return _CFDA1_Number; }
            set { _CFDA1_Number = value; }
        }

        string _Planned_Program_Spend;

        /// <summary>
        /// Gets or sets the value of variable Planned_Program_Spend.
        /// </summary>
        [TestVariable("21c5c594-3e09-430f-b998-81584c36caaf")]
        public string Planned_Program_Spend
        {
            get { return _Planned_Program_Spend; }
            set { _Planned_Program_Spend = value; }
        }

        string _Additional_Comments;

        /// <summary>
        /// Gets or sets the value of variable Additional_Comments.
        /// </summary>
        [TestVariable("5471a77b-875d-45b3-be9e-3b54e34f531d")]
        public string Additional_Comments
        {
            get { return _Additional_Comments; }
            set { _Additional_Comments = value; }
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

            // Program Period From/To
            Report.Log(ReportLevel.Info, "Section", "Program Period From/To", new RecordItemIndex(0));
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Program_Period_From' with focus on 'Login1.Project___Project_Period_From'.", repo.Login1.Project___Project_Period_FromInfo, new RecordItemIndex(1));
            repo.Login1.Project___Project_Period_From.PressKeys(Program_Period_From);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Program_Period_To' with focus on 'Login1.Project___Project_Period_To'.", repo.Login1.Project___Project_Period_ToInfo, new RecordItemIndex(2));
            repo.Login1.Project___Project_Period_To.PressKeys(Program_Period_To);
            Delay.Milliseconds(100);
            
            // Program Title
            Report.Log(ReportLevel.Info, "Section", "Program Title", new RecordItemIndex(3));
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Program_Title' with focus on 'Login1.Internal_Opportunity_Title'.", repo.Login1.Internal_Opportunity_TitleInfo, new RecordItemIndex(4));
            repo.Login1.Internal_Opportunity_Title.PressKeys(Program_Title);
            Delay.Milliseconds(100);
            
            // Program Description
            Report.Log(ReportLevel.Info, "Section", "Program Description", new RecordItemIndex(5));
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Program_Description' with focus on 'Login1.Project_Project_Description'.", repo.Login1.Project_Project_DescriptionInfo, new RecordItemIndex(6));
            repo.Login1.Project_Project_Description.PressKeys(Program_Description);
            Delay.Milliseconds(100);
            
            // Primary Requesting Office
            Report.Log(ReportLevel.Info, "Section", "Primary Requesting Office", new RecordItemIndex(7));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.Project___Primary_Requesting_Office' at Center.", repo.Login1.Project___Primary_Requesting_OfficeInfo, new RecordItemIndex(8));
            repo.Login1.Project___Primary_Requesting_Office.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Primary_Requesting_Office' with focus on 'Login1.Project___Primary_Requesting_Office'.", repo.Login1.Project___Primary_Requesting_OfficeInfo, new RecordItemIndex(9));
            repo.Login1.Project___Primary_Requesting_Office.PressKeys(Primary_Requesting_Office);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{enter}' with focus on 'Login1.Project___Primary_Requesting_Office'.", repo.Login1.Project___Primary_Requesting_OfficeInfo, new RecordItemIndex(10));
            repo.Login1.Project___Primary_Requesting_Office.PressKeys("{enter}");
            Delay.Milliseconds(70);
            
            // Awarding Office
            Report.Log(ReportLevel.Info, "Section", "Awarding Office", new RecordItemIndex(11));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.Project___Awarding_Office' at Center.", repo.Login1.Project___Awarding_OfficeInfo, new RecordItemIndex(12));
            repo.Login1.Project___Awarding_Office.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Awarding_Office' with focus on 'Login1.Project___Awarding_Office'.", repo.Login1.Project___Awarding_OfficeInfo, new RecordItemIndex(13));
            repo.Login1.Project___Awarding_Office.PressKeys(Awarding_Office);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{enter}' with focus on 'Login1.Project___Awarding_Office'.", repo.Login1.Project___Awarding_OfficeInfo, new RecordItemIndex(14));
            repo.Login1.Project___Awarding_Office.PressKeys("{enter}");
            Delay.Milliseconds(70);
            
            // CFDA Number
            Report.Log(ReportLevel.Info, "Section", "CFDA Number", new RecordItemIndex(15));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.C8d73b9a2db393b0016bc300f7c961903NgSco.Project___Associated_Program_Number' at Center.", repo.Login1.C8d73b9a2db393b0016bc300f7c961903NgSco.Project___Associated_Program_NumberInfo, new RecordItemIndex(16));
            repo.Login1.C8d73b9a2db393b0016bc300f7c961903NgSco.Project___Associated_Program_Number.Click();
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$CFDA1_Number' with focus on 'Login1.C8d73b9a2db393b0016bc300f7c961903NgSco.Project___Associated_Program_Number'.", repo.Login1.C8d73b9a2db393b0016bc300f7c961903NgSco.Project___Associated_Program_NumberInfo, new RecordItemIndex(17));
            repo.Login1.C8d73b9a2db393b0016bc300f7c961903NgSco.Project___Associated_Program_Number.PressKeys(CFDA1_Number);
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{enter}' with focus on 'Login1.C8d73b9a2db393b0016bc300f7c961903NgSco.Project___Associated_Program_Number'.", repo.Login1.C8d73b9a2db393b0016bc300f7c961903NgSco.Project___Associated_Program_NumberInfo, new RecordItemIndex(18));
            repo.Login1.C8d73b9a2db393b0016bc300f7c961903NgSco.Project___Associated_Program_Number.PressKeys("{enter}");
            Delay.Milliseconds(70);
            
            // Planned Program Spend
            Report.Log(ReportLevel.Info, "Section", "Planned Program Spend", new RecordItemIndex(19));
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key 'Ctrl+A' Press with focus on 'Login1.Project___Planned_Project_Spend'.", repo.Login1.Project___Planned_Project_SpendInfo, new RecordItemIndex(20));
            Keyboard.PrepareFocus(repo.Login1.Project___Planned_Project_Spend);
            Keyboard.Press(System.Windows.Forms.Keys.A | System.Windows.Forms.Keys.Control, Keyboard.DefaultScanCode, 100, 1, true);
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{delete}' with focus on 'Login1.Project___Planned_Project_Spend'.", repo.Login1.Project___Planned_Project_SpendInfo, new RecordItemIndex(21));
            repo.Login1.Project___Planned_Project_Spend.PressKeys("{delete}");
            Delay.Milliseconds(70);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Planned_Program_Spend' with focus on 'Login1.Project___Planned_Project_Spend'.", repo.Login1.Project___Planned_Project_SpendInfo, new RecordItemIndex(22));
            repo.Login1.Project___Planned_Project_Spend.PressKeys(Planned_Program_Spend);
            Delay.Milliseconds(70);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.C8d73b9a2db393b0016bc300f7c961903NgSco.DivTagRow1' at 837;188.", repo.Login1.C8d73b9a2db393b0016bc300f7c961903NgSco.DivTagRow1Info, new RecordItemIndex(23));
            repo.Login1.C8d73b9a2db393b0016bc300f7c961903NgSco.DivTagRow1.Click("837;188");
            Delay.Milliseconds(200);
            
            // Comments
            Report.Log(ReportLevel.Info, "Section", "Comments", new RecordItemIndex(24));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.C8d73b9a2db393b0016bc300f7c961903NgSco.FaFaPlusSquareO' at 10;6.", repo.Login1.C8d73b9a2db393b0016bc300f7c961903NgSco.FaFaPlusSquareOInfo, new RecordItemIndex(25));
            repo.Login1.C8d73b9a2db393b0016bc300f7c961903NgSco.FaFaPlusSquareO.Click("10;6");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Additional_Comments' with focus on 'Login1.Project___Additional_Comments'.", repo.Login1.Project___Additional_CommentsInfo, new RecordItemIndex(26));
            repo.Login1.Project___Additional_Comments.PressKeys(Additional_Comments);
            Delay.Milliseconds(100);
            
            // Save
            Report.Log(ReportLevel.Info, "Section", "Save", new RecordItemIndex(27));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.C8d73b9a2db393b0016bc300f7c961903NgSco.Save' at 37;14.", repo.Login1.C8d73b9a2db393b0016bc300f7c961903NgSco.SaveInfo, new RecordItemIndex(28));
            repo.Login1.C8d73b9a2db393b0016bc300f7c961903NgSco.Save.Click("37;14");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'Login1.C8d73b9a2db393b0016bc300f7c961903NgSco.Copy'", repo.Login1.C8d73b9a2db393b0016bc300f7c961903NgSco.CopyInfo, new ActionTimeout(30000), new RecordItemIndex(29));
            repo.Login1.C8d73b9a2db393b0016bc300f7c961903NgSco.CopyInfo.WaitForExists(30000);
            
            // Home
            Report.Log(ReportLevel.Info, "Section", "Home", new RecordItemIndex(30));
            
            // Home
            Report.Log(ReportLevel.Info, "Mouse", "Home\r\nMouse Left Click item 'Login1.NavNavbarNavSamsNavbarNav.ATagHome' at 54;38.", repo.Login1.NavNavbarNavSamsNavbarNav.ATagHomeInfo, new RecordItemIndex(31));
            repo.Login1.NavNavbarNavSamsNavbarNav.ATagHome.Click("54;38");
            Delay.Milliseconds(200);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
