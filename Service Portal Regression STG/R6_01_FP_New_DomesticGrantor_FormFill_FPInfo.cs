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
    ///The R6_01_FP_New_DomesticGrantor_FormFill_FPInfo recording.
    /// </summary>
    [TestModule("87ef619f-40ba-4e64-9116-5f2e6eb36c5d", ModuleType.Recording, 1)]
    public partial class R6_01_FP_New_DomesticGrantor_FormFill_FPInfo : ITestModule
    {
        /// <summary>
        /// Holds an instance of the Service_Portal_Regression_STGRepository repository.
        /// </summary>
        public static Service_Portal_Regression_STGRepository repo = Service_Portal_Regression_STGRepository.Instance;

        static R6_01_FP_New_DomesticGrantor_FormFill_FPInfo instance = new R6_01_FP_New_DomesticGrantor_FormFill_FPInfo();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public R6_01_FP_New_DomesticGrantor_FormFill_FPInfo()
        {
            Title = "NMK FP";
            Award_Purpose = "NMK Award Purpose";
            Associated_Program_Number = "SPRG0001851";
            Associated_Project_Number = "SPRJ0001842";
            Period_of_Performance_From = "2020-08-14 09:49:35";
            Period_of_Performance_To = "2020-11-25 09:49:35";
            Awarding_Office = "AMERICAN CONSULATE GENERAL FRANKFURT";
            Opportunity_Type = "Full and Open Competition - Notice of Funding Opportunity";
            Funding_Instrument_Type = "Grant";
            Sensitive = "No";
            Primary_Country = "United States of America";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static R6_01_FP_New_DomesticGrantor_FormFill_FPInfo Instance
        {
            get { return instance; }
        }

#region Variables

        string _Title;

        /// <summary>
        /// Gets or sets the value of variable Title.
        /// </summary>
        [TestVariable("c4b00197-e33a-49f1-9e72-d9761eb3d153")]
        public string Title
        {
            get { return _Title; }
            set { _Title = value; }
        }

        string _Award_Purpose;

        /// <summary>
        /// Gets or sets the value of variable Award_Purpose.
        /// </summary>
        [TestVariable("ed2f9f2f-d77d-4e64-8dd2-5b11363cd567")]
        public string Award_Purpose
        {
            get { return _Award_Purpose; }
            set { _Award_Purpose = value; }
        }

        string _Associated_Program_Number;

        /// <summary>
        /// Gets or sets the value of variable Associated_Program_Number.
        /// </summary>
        [TestVariable("44e65e54-3ea2-445c-94bf-6dce1e9b0836")]
        public string Associated_Program_Number
        {
            get { return _Associated_Program_Number; }
            set { _Associated_Program_Number = value; }
        }

        string _Associated_Project_Number;

        /// <summary>
        /// Gets or sets the value of variable Associated_Project_Number.
        /// </summary>
        [TestVariable("ea321f08-6090-4aba-946b-ebfce0a34346")]
        public string Associated_Project_Number
        {
            get { return _Associated_Project_Number; }
            set { _Associated_Project_Number = value; }
        }

        string _Period_of_Performance_From;

        /// <summary>
        /// Gets or sets the value of variable Period_of_Performance_From.
        /// </summary>
        [TestVariable("3f1c15a2-d8b3-4b2d-b817-0f46258bed1d")]
        public string Period_of_Performance_From
        {
            get { return _Period_of_Performance_From; }
            set { _Period_of_Performance_From = value; }
        }

        string _Period_of_Performance_To;

        /// <summary>
        /// Gets or sets the value of variable Period_of_Performance_To.
        /// </summary>
        [TestVariable("b6648fc8-dc9a-4b35-99e7-3d6c802b621b")]
        public string Period_of_Performance_To
        {
            get { return _Period_of_Performance_To; }
            set { _Period_of_Performance_To = value; }
        }

        string _Awarding_Office;

        /// <summary>
        /// Gets or sets the value of variable Awarding_Office.
        /// </summary>
        [TestVariable("432976b5-5302-4207-826f-425ca84c0534")]
        public string Awarding_Office
        {
            get { return _Awarding_Office; }
            set { _Awarding_Office = value; }
        }

        string _Opportunity_Type;

        /// <summary>
        /// Gets or sets the value of variable Opportunity_Type.
        /// </summary>
        [TestVariable("3b46c7ae-6fd5-40a0-8121-2737387c4a17")]
        public string Opportunity_Type
        {
            get { return _Opportunity_Type; }
            set { _Opportunity_Type = value; }
        }

        string _Funding_Instrument_Type;

        /// <summary>
        /// Gets or sets the value of variable Funding_Instrument_Type.
        /// </summary>
        [TestVariable("c2a774de-839f-4d18-a450-1ab616a5225f")]
        public string Funding_Instrument_Type
        {
            get { return _Funding_Instrument_Type; }
            set { _Funding_Instrument_Type = value; }
        }

        string _Sensitive;

        /// <summary>
        /// Gets or sets the value of variable Sensitive.
        /// </summary>
        [TestVariable("62a243fc-bb0a-4ad3-b003-836ee3f43070")]
        public string Sensitive
        {
            get { return _Sensitive; }
            set { _Sensitive = value; }
        }

        string _Primary_Country;

        /// <summary>
        /// Gets or sets the value of variable Primary_Country.
        /// </summary>
        [TestVariable("3f1b6b79-d56c-414c-a0dd-d30af576e346")]
        public string Primary_Country
        {
            get { return _Primary_Country; }
            set { _Primary_Country = value; }
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

            // Title
            Report.Log(ReportLevel.Info, "Section", "Title", new RecordItemIndex(0));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.Internal_Opportunity_Title' at 95;18.", repo.Login1.Internal_Opportunity_TitleInfo, new RecordItemIndex(1));
            repo.Login1.Internal_Opportunity_Title.Click("95;18");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Title' with focus on 'Login1.Internal_Opportunity_Title'.", repo.Login1.Internal_Opportunity_TitleInfo, new RecordItemIndex(2));
            repo.Login1.Internal_Opportunity_Title.PressKeys(Title);
            Delay.Milliseconds(30);
            
            // Award Purpose
            Report.Log(ReportLevel.Info, "Section", "Award Purpose", new RecordItemIndex(3));
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{tab 9}'.", new RecordItemIndex(4));
            Keyboard.Press("{tab 9}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Award_Purpose'.", new RecordItemIndex(5));
            Keyboard.Press(Award_Purpose);
            Delay.Milliseconds(30);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(6));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{enter}'.", new RecordItemIndex(7));
            Keyboard.Press("{enter}");
            Delay.Milliseconds(0);
            
            // Associated Program Number
            Report.Log(ReportLevel.Info, "Section", "Associated Program Number", new RecordItemIndex(8));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.Internal_Opportunity_Title' at 95;18.", repo.Login1.Internal_Opportunity_TitleInfo, new RecordItemIndex(9));
            repo.Login1.Internal_Opportunity_Title.Click("95;18");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{tab}'.", new RecordItemIndex(10));
            Keyboard.Press("{tab}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Associated_Program_Number'.", new RecordItemIndex(11));
            Keyboard.Press(Associated_Program_Number);
            Delay.Milliseconds(30);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(12));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{enter}'.", new RecordItemIndex(13));
            Keyboard.Press("{enter}");
            Delay.Milliseconds(0);
            
            // Associated Project Number
            Report.Log(ReportLevel.Info, "Section", "Associated Project Number", new RecordItemIndex(14));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.Internal_Opportunity_Title' at 95;18.", repo.Login1.Internal_Opportunity_TitleInfo, new RecordItemIndex(15));
            repo.Login1.Internal_Opportunity_Title.Click("95;18");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{tab 13}'.", new RecordItemIndex(16));
            Keyboard.Press("{tab 13}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Associated_Project_Number'.", new RecordItemIndex(17));
            Keyboard.Press(Associated_Project_Number);
            Delay.Milliseconds(30);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(18));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{enter}'.", new RecordItemIndex(19));
            Keyboard.Press("{enter}");
            Delay.Milliseconds(0);
            
            // Period of Performance From
            Report.Log(ReportLevel.Info, "Section", "Period of Performance From", new RecordItemIndex(20));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.Project___Project_Period_From' at 245;27.", repo.Login1.Project___Project_Period_FromInfo, new RecordItemIndex(21));
            repo.Login1.Project___Project_Period_From.Click("245;27");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Period_of_Performance_From' with focus on 'Login1.Project___Project_Period_From'.", repo.Login1.Project___Project_Period_FromInfo, new RecordItemIndex(22));
            repo.Login1.Project___Project_Period_From.PressKeys(Period_of_Performance_From);
            Delay.Milliseconds(0);
            
            // Period of Performance To
            Report.Log(ReportLevel.Info, "Section", "Period of Performance To", new RecordItemIndex(23));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.Project___Project_Period_To' at 94;25.", repo.Login1.Project___Project_Period_ToInfo, new RecordItemIndex(24));
            repo.Login1.Project___Project_Period_To.Click("94;25");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Period_of_Performance_To' with focus on 'Login1.Project___Project_Period_To'.", repo.Login1.Project___Project_Period_ToInfo, new RecordItemIndex(25));
            repo.Login1.Project___Project_Period_To.PressKeys(Period_of_Performance_To);
            Delay.Milliseconds(0);
            
            // Awarding Office
            Report.Log(ReportLevel.Info, "Section", "Awarding Office", new RecordItemIndex(26));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.Project___Project_Period_To' at 94;25.", repo.Login1.Project___Project_Period_ToInfo, new RecordItemIndex(27));
            repo.Login1.Project___Project_Period_To.Click("94;25");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{tab 1}'.", new RecordItemIndex(28));
            Keyboard.Press("{tab 1}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Awarding_Office'.", new RecordItemIndex(29));
            Keyboard.Press(Awarding_Office);
            Delay.Milliseconds(30);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(30));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{enter}'.", new RecordItemIndex(31));
            Keyboard.Press("{enter}");
            Delay.Milliseconds(0);
            
            // Opportunity Type
            Report.Log(ReportLevel.Info, "Section", "Opportunity Type", new RecordItemIndex(32));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.Project___Project_Period_To' at 94;25.", repo.Login1.Project___Project_Period_ToInfo, new RecordItemIndex(33));
            repo.Login1.Project___Project_Period_To.Click("94;25");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{tab 3}'.", new RecordItemIndex(34));
            Keyboard.Press("{tab 3}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Opportunity_Type'.", new RecordItemIndex(35));
            Keyboard.Press(Opportunity_Type);
            Delay.Milliseconds(30);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(36));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{enter}'.", new RecordItemIndex(37));
            Keyboard.Press("{enter}");
            Delay.Milliseconds(0);
            
            // Funding Instrument Type
            Report.Log(ReportLevel.Info, "Section", "Funding Instrument Type", new RecordItemIndex(38));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.Project___Project_Period_To' at 94;25.", repo.Login1.Project___Project_Period_ToInfo, new RecordItemIndex(39));
            repo.Login1.Project___Project_Period_To.Click("94;25");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{tab 4}'.", new RecordItemIndex(40));
            Keyboard.Press("{tab 4}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Funding_Instrument_Type'.", new RecordItemIndex(41));
            Keyboard.Press(Funding_Instrument_Type);
            Delay.Milliseconds(30);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(42));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{enter}'.", new RecordItemIndex(43));
            Keyboard.Press("{enter}");
            Delay.Milliseconds(0);
            
            // Sensitive
            Report.Log(ReportLevel.Info, "Section", "Sensitive", new RecordItemIndex(44));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.Project___Project_Period_To' at 94;25.", repo.Login1.Project___Project_Period_ToInfo, new RecordItemIndex(45));
            repo.Login1.Project___Project_Period_To.Click("94;25");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{tab 5}'.", new RecordItemIndex(46));
            Keyboard.Press("{tab 5}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Sensitive'.", new RecordItemIndex(47));
            Keyboard.Press(Sensitive);
            Delay.Milliseconds(30);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(48));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Down}{enter}'.", new RecordItemIndex(49));
            Keyboard.Press("{Down}{enter}");
            Delay.Milliseconds(0);
            
            // Primary Country
            Report.Log(ReportLevel.Info, "Section", "Primary Country", new RecordItemIndex(50));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.Internal_Opportunity_Title' at 95;18.", repo.Login1.Internal_Opportunity_TitleInfo, new RecordItemIndex(51));
            repo.Login1.Internal_Opportunity_Title.Click("95;18");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{tab 10}'.", new RecordItemIndex(52));
            Keyboard.Press("{tab 10}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Primary_Country'.", new RecordItemIndex(53));
            Keyboard.Press(Primary_Country);
            Delay.Milliseconds(30);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(54));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{Down}{enter}'.", new RecordItemIndex(55));
            Keyboard.Press("{Down}{enter}");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
