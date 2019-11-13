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
    ///The R1_04_HomePage_Footer_RPMGrantee_Support recording.
    /// </summary>
    [TestModule("95cb517b-c8a1-4199-8827-7a2c49c58c21", ModuleType.Recording, 1)]
    public partial class R1_04_HomePage_Footer_RPMGrantee_Support : ITestModule
    {
        /// <summary>
        /// Holds an instance of the Service_Portal_Regression_STGRepository repository.
        /// </summary>
        public static Service_Portal_Regression_STGRepository repo = Service_Portal_Regression_STGRepository.Instance;

        static R1_04_HomePage_Footer_RPMGrantee_Support instance = new R1_04_HomePage_Footer_RPMGrantee_Support();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public R1_04_HomePage_Footer_RPMGrantee_Support()
        {
            RPM_Grantee_WM = "Hi, Monica Geller!";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static R1_04_HomePage_Footer_RPMGrantee_Support Instance
        {
            get { return instance; }
        }

#region Variables

        string _RPM_Grantee_WM;

        /// <summary>
        /// Gets or sets the value of variable RPM_Grantee_WM.
        /// </summary>
        [TestVariable("21e1797b-a9fa-4163-b70e-542b277e0ba7")]
        public string RPM_Grantee_WM
        {
            get { return _RPM_Grantee_WM; }
            set { _RPM_Grantee_WM = value; }
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
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Support') on item 'Login1.NgScope4.Support'.", repo.Login1.NgScope4.SupportInfo, new RecordItemIndex(1));
            Validate.AttributeEqual(repo.Login1.NgScope4.SupportInfo, "InnerText", "Support");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Grantee Training Resources') on item 'Login1.NgScope4.GranteeTrainingResources'.", repo.Login1.NgScope4.GranteeTrainingResourcesInfo, new RecordItemIndex(2));
            Validate.AttributeEqual(repo.Login1.NgScope4.GranteeTrainingResourcesInfo, "InnerText", "Grantee Training Resources");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Results Performance Monitoring Grantee Training Resources') on item 'Login1.NgScope4.ResultsPerformanceMonitoringGranteeT'.", repo.Login1.NgScope4.ResultsPerformanceMonitoringGranteeTInfo, new RecordItemIndex(3));
            Validate.AttributeEqual(repo.Login1.NgScope4.ResultsPerformanceMonitoringGranteeTInfo, "InnerText", "Results Performance Monitoring Grantee Training Resources");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (InnerText='Support') on item 'Login1.NgScope4.Support1'.", repo.Login1.NgScope4.Support1Info, new RecordItemIndex(4));
            Validate.AttributeEqual(repo.Login1.NgScope4.Support1Info, "InnerText", "Support");
            Delay.Milliseconds(100);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.NgScope4.Support' at 31;4.", repo.Login1.NgScope4.SupportInfo, new RecordItemIndex(5));
            repo.Login1.NgScope4.Support.Click("31;4");
            Delay.Milliseconds(200);
            
            // Support Screenshot
            Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(6));
            
            // Grantee Training Resources
            Report.Log(ReportLevel.Info, "Section", "Grantee Training Resources", new RecordItemIndex(7));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.NgScope4.GranteeTrainingResources' at 49;14.", repo.Login1.NgScope4.GranteeTrainingResourcesInfo, new RecordItemIndex(8));
            repo.Login1.NgScope4.GranteeTrainingResources.Click("49;14");
            Delay.Milliseconds(200);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating Exists on item 'Login1.HttpsMygrantstrainServiceNowComDe'.", repo.Login1.HttpsMygrantstrainServiceNowComDeInfo, new RecordItemIndex(9));
                Validate.Exists(repo.Login1.HttpsMygrantstrainServiceNowComDeInfo, null, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(9)); }
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'Login1.HttpsMygrantstrainServiceNowComDe'", repo.Login1.HttpsMygrantstrainServiceNowComDeInfo, new ActionTimeout(30000), new RecordItemIndex(10));
            repo.Login1.HttpsMygrantstrainServiceNowComDeInfo.WaitForExists(30000);
            
            // Grantee Training Resources Screenshot
            Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(11));
            
            // Home Button
            Report.Log(ReportLevel.Info, "Mouse", "Home Button\r\nMouse Left Click item 'Login1.NavNavbarNavSamsNavbarNav.HOME' at 12;9.", repo.Login1.NavNavbarNavSamsNavbarNav.HOMEInfo, new RecordItemIndex(12));
            repo.Login1.NavNavbarNavSamsNavbarNav.HOME.Click("12;9");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s for the attribute 'InnerText' to equal the specified value $RPM_Grantee_WM. Associated repository item: 'Login1.HiMonicaGeller'", repo.Login1.HiMonicaGellerInfo, new RecordItemIndex(13));
            repo.Login1.HiMonicaGellerInfo.WaitForAttributeEqual(5000, "InnerText", RPM_Grantee_WM);
            
            // RPM Grantee Training Resources
            Report.Log(ReportLevel.Info, "Section", "RPM Grantee Training Resources", new RecordItemIndex(14));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.NgScope4.ResultsPerformanceMonitoringGranteeT' at 76;24.", repo.Login1.NgScope4.ResultsPerformanceMonitoringGranteeTInfo, new RecordItemIndex(15));
            repo.Login1.NgScope4.ResultsPerformanceMonitoringGranteeT.Click("76;24");
            Delay.Milliseconds(200);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating Exists on item 'Login1.HttpsMygrantstrainServiceNowComDe'.", repo.Login1.HttpsMygrantstrainServiceNowComDeInfo, new RecordItemIndex(16));
                Validate.Exists(repo.Login1.HttpsMygrantstrainServiceNowComDeInfo, null, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(16)); }
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 30s to exist. Associated repository item: 'Login1.HttpsMygrantstrainServiceNowComDe'", repo.Login1.HttpsMygrantstrainServiceNowComDeInfo, new ActionTimeout(30000), new RecordItemIndex(17));
            repo.Login1.HttpsMygrantstrainServiceNowComDeInfo.WaitForExists(30000);
            
            // Grantee Training Resources Screenshot
            Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(18));
            
            // Home Button
            Report.Log(ReportLevel.Info, "Mouse", "Home Button\r\nMouse Left Click item 'Login1.NavNavbarNavSamsNavbarNav.HOME' at 12;9.", repo.Login1.NavNavbarNavSamsNavbarNav.HOMEInfo, new RecordItemIndex(19));
            repo.Login1.NavNavbarNavSamsNavbarNav.HOME.Click("12;9");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s for the attribute 'InnerText' to equal the specified value $RPM_Grantee_WM. Associated repository item: 'Login1.HiMonicaGeller'", repo.Login1.HiMonicaGellerInfo, new RecordItemIndex(20));
            repo.Login1.HiMonicaGellerInfo.WaitForAttributeEqual(5000, "InnerText", RPM_Grantee_WM);
            
            // Support TO BE CONTINUED
            Report.Log(ReportLevel.Info, "Section", "Support TO BE CONTINUED", new RecordItemIndex(21));
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
