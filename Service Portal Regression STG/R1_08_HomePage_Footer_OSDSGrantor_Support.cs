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
    ///The R1_08_HomePage_Footer_OSDSGrantor_Support recording.
    /// </summary>
    [TestModule("922ca23b-0b37-43e2-86b7-fb7aaf6b2a81", ModuleType.Recording, 1)]
    public partial class R1_08_HomePage_Footer_OSDSGrantor_Support : ITestModule
    {
        /// <summary>
        /// Holds an instance of the Service_Portal_Regression_STGRepository repository.
        /// </summary>
        public static Service_Portal_Regression_STGRepository repo = Service_Portal_Regression_STGRepository.Instance;

        static R1_08_HomePage_Footer_OSDSGrantor_Support instance = new R1_08_HomePage_Footer_OSDSGrantor_Support();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public R1_08_HomePage_Footer_OSDSGrantor_Support()
        {
            OSDS_Grantor_WM = "Hi, Mike Hannigan!";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static R1_08_HomePage_Footer_OSDSGrantor_Support Instance
        {
            get { return instance; }
        }

#region Variables

        string _OSDS_Grantor_WM;

        /// <summary>
        /// Gets or sets the value of variable OSDS_Grantor_WM.
        /// </summary>
        [TestVariable("bead58b5-b407-4605-aa2a-f283e5ffad02")]
        public string OSDS_Grantor_WM
        {
            get { return _OSDS_Grantor_WM; }
            set { _OSDS_Grantor_WM = value; }
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
            Delay.Milliseconds(500);
            
            // Footer - Support
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nFooter - Support\r\nValidating AttributeEqual (InnerText='Support') on item 'Login1.NgScope4.Support'.", repo.Login1.NgScope4.SupportInfo, new RecordItemIndex(2));
                Validate.AttributeEqual(repo.Login1.NgScope4.SupportInfo, "InnerText", "Support", null, new Validate.Options(){ReportScreenshot=Validate.ResultOption.OnFail});
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(2)); }
            
            // Footer - Grantor Training
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nFooter - Grantor Training\r\nValidating AttributeEqual (InnerText='Grantor Training Resources') on item 'Login1.NgScope4.GrantorTrainingResources'.", repo.Login1.NgScope4.GrantorTrainingResourcesInfo, new RecordItemIndex(3));
                Validate.AttributeEqual(repo.Login1.NgScope4.GrantorTrainingResourcesInfo, "InnerText", "Grantor Training Resources", null, new Validate.Options(){ReportScreenshot=Validate.ResultOption.OnFail});
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(3)); }
            
            // Footer - Grantee Training
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nFooter - Grantee Training\r\nValidating AttributeEqual (InnerText='Grantee Training Resources') on item 'Login1.NgScope4.GranteeTrainingResources2'.", repo.Login1.NgScope4.GranteeTrainingResources2Info, new RecordItemIndex(4));
                Validate.AttributeEqual(repo.Login1.NgScope4.GranteeTrainingResources2Info, "InnerText", "Grantee Training Resources", null, new Validate.Options(){ReportScreenshot=Validate.ResultOption.OnFail});
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(4)); }
            
            // Footer - Support
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nFooter - Support\r\nValidating AttributeEqual (InnerText='Support') on item 'Login1.NgScope4.Support1'.", repo.Login1.NgScope4.Support1Info, new RecordItemIndex(5));
                Validate.AttributeEqual(repo.Login1.NgScope4.Support1Info, "InnerText", "Support", null, new Validate.Options(){ReportScreenshot=Validate.ResultOption.OnFail});
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(5)); }
            
            // Grantor Training Resources
            Report.Log(ReportLevel.Info, "Section", "Grantor Training Resources", new RecordItemIndex(6));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.NgScope4.GrantorTrainingResources' at 70;14.", repo.Login1.NgScope4.GrantorTrainingResourcesInfo, new RecordItemIndex(7));
            repo.Login1.NgScope4.GrantorTrainingResources.Click("70;14");
            Delay.Milliseconds(200);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating Exists on item 'Login1.HttpsMygrantstrainServiceNowComDe'.", repo.Login1.HttpsMygrantstrainServiceNowComDeInfo, new RecordItemIndex(8));
                Validate.Exists(repo.Login1.HttpsMygrantstrainServiceNowComDeInfo, null, new Validate.Options(){ReportScreenshot=Validate.ResultOption.OnFail});
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(8)); }
            
            // Grantor Training Resources Screenshot
            Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(9));
            
            // Home Button
            Report.Log(ReportLevel.Info, "Mouse", "Home Button\r\nMouse Left Click item 'Login1.NavNavbarNavSamsNavbarNav.HOME' at 12;9.", repo.Login1.NavNavbarNavSamsNavbarNav.HOMEInfo, new RecordItemIndex(10));
            repo.Login1.NavNavbarNavSamsNavbarNav.HOME.Click("12;9");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s for the attribute 'InnerText' to equal the specified value $OSDS_Grantor_WM. Associated repository item: 'Login1.HiMikeHannigan'", repo.Login1.HiMikeHanniganInfo, new RecordItemIndex(11));
            repo.Login1.HiMikeHanniganInfo.WaitForAttributeEqual(5000, "InnerText", OSDS_Grantor_WM);
            
            // Grantee Training Resources
            Report.Log(ReportLevel.Info, "Section", "Grantee Training Resources", new RecordItemIndex(12));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -840 units.", new RecordItemIndex(13));
            Mouse.ScrollWheel(-840);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.NgScope4.GranteeTrainingResources2' at 70;14.", repo.Login1.NgScope4.GranteeTrainingResources2Info, new RecordItemIndex(14));
            repo.Login1.NgScope4.GranteeTrainingResources2.Click("70;14");
            Delay.Milliseconds(200);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating Exists on item 'Login1.HttpsMygrantstrainServiceNowComDe'.", repo.Login1.HttpsMygrantstrainServiceNowComDeInfo, new RecordItemIndex(15));
                Validate.Exists(repo.Login1.HttpsMygrantstrainServiceNowComDeInfo, null, new Validate.Options(){ReportScreenshot=Validate.ResultOption.OnFail});
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(15)); }
            
            // Grantee Training Resources Screenshot
            Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(16));
            
            // Home Button
            Report.Log(ReportLevel.Info, "Mouse", "Home Button\r\nMouse Left Click item 'Login1.NavNavbarNavSamsNavbarNav.HOME' at 12;9.", repo.Login1.NavNavbarNavSamsNavbarNav.HOMEInfo, new RecordItemIndex(17));
            repo.Login1.NavNavbarNavSamsNavbarNav.HOME.Click("12;9");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s for the attribute 'InnerText' to equal the specified value $OSDS_Grantor_WM. Associated repository item: 'Login1.HiMikeHannigan'", repo.Login1.HiMikeHanniganInfo, new RecordItemIndex(18));
            repo.Login1.HiMikeHanniganInfo.WaitForAttributeEqual(5000, "InnerText", OSDS_Grantor_WM);
            
            // Support
            Report.Log(ReportLevel.Info, "Section", "Support", new RecordItemIndex(19));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse scroll Vertical by -840 units.", new RecordItemIndex(20));
            Mouse.ScrollWheel(-840);
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.NgScope4.Support1' at 70;14.", repo.Login1.NgScope4.Support1Info, new RecordItemIndex(21));
            repo.Login1.NgScope4.Support1.Click("70;14");
            Delay.Milliseconds(200);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (InnerText='Grantor Training Resource') on item 'Login1.GrantorTrainingResource'.", repo.Login1.GrantorTrainingResourceInfo, new RecordItemIndex(22));
                Validate.AttributeEqual(repo.Login1.GrantorTrainingResourceInfo, "InnerText", "Grantor Training Resource", null, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(22)); }
            
            // Support Screenshot
            Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(23));
            
            // Home Button
            Report.Log(ReportLevel.Info, "Mouse", "Home Button\r\nMouse Left Click item 'Login1.NavNavbarNavSamsNavbarNav.HOME' at 12;9.", repo.Login1.NavNavbarNavSamsNavbarNav.HOMEInfo, new RecordItemIndex(24));
            repo.Login1.NavNavbarNavSamsNavbarNav.HOME.Click("12;9");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s for the attribute 'InnerText' to equal the specified value $OSDS_Grantor_WM. Associated repository item: 'Login1.HiMikeHannigan'", repo.Login1.HiMikeHanniganInfo, new RecordItemIndex(25));
            repo.Login1.HiMikeHanniganInfo.WaitForAttributeEqual(5000, "InnerText", OSDS_Grantor_WM);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
