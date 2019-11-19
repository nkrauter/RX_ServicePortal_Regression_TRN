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
    ///The R1_08_HomePage_TilesHeader_OSDSGrantor_OSSupport recording.
    /// </summary>
    [TestModule("bcdf7410-0844-4f32-b42b-ad1e1fdf54cb", ModuleType.Recording, 1)]
    public partial class R1_08_HomePage_TilesHeader_OSDSGrantor_OSSupport : ITestModule
    {
        /// <summary>
        /// Holds an instance of the Service_Portal_Regression_STGRepository repository.
        /// </summary>
        public static Service_Portal_Regression_STGRepository repo = Service_Portal_Regression_STGRepository.Instance;

        static R1_08_HomePage_TilesHeader_OSDSGrantor_OSSupport instance = new R1_08_HomePage_TilesHeader_OSDSGrantor_OSSupport();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public R1_08_HomePage_TilesHeader_OSDSGrantor_OSSupport()
        {
            OSDS_Grantor_WM = "Hi, Mike Hannigan!";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static R1_08_HomePage_TilesHeader_OSDSGrantor_OSSupport Instance
        {
            get { return instance; }
        }

#region Variables

        string _OSDS_Grantor_WM;

        /// <summary>
        /// Gets or sets the value of variable OSDS_Grantor_WM.
        /// </summary>
        [TestVariable("3ea3915c-aab0-4abc-9b4a-658c32c372ce")]
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
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            // Header Links
            Report.Log(ReportLevel.Info, "Section", "Header Links", new RecordItemIndex(0));
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (InnerText=' Support ') on item 'Login1.NavNavbarNavSamsNavbarNav.ATagSupport2'.", repo.Login1.NavNavbarNavSamsNavbarNav.ATagSupport2Info, new RecordItemIndex(1));
                Validate.AttributeEqual(repo.Login1.NavNavbarNavSamsNavbarNav.ATagSupport2Info, "InnerText", " Support ", null, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(1)); }
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.NavNavbarNavSamsNavbarNav.ATagSupport2' at 57;38.", repo.Login1.NavNavbarNavSamsNavbarNav.ATagSupport2Info, new RecordItemIndex(2));
            repo.Login1.NavNavbarNavSamsNavbarNav.ATagSupport2.Click("57;38");
            Delay.Milliseconds(200);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (InnerText='Grantor Training Resources') on item 'Login1.NavNavbarNavSamsNavbarNav.GrantorTrainingResources1'.", repo.Login1.NavNavbarNavSamsNavbarNav.GrantorTrainingResources1Info, new RecordItemIndex(3));
                Validate.AttributeEqual(repo.Login1.NavNavbarNavSamsNavbarNav.GrantorTrainingResources1Info, "InnerText", "Grantor Training Resources", null, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(3)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (InnerText='Grantee Training Resources') on item 'Login1.NavNavbarNavSamsNavbarNav.GranteeTrainingResources2'.", repo.Login1.NavNavbarNavSamsNavbarNav.GranteeTrainingResources2Info, new RecordItemIndex(4));
                Validate.AttributeEqual(repo.Login1.NavNavbarNavSamsNavbarNav.GranteeTrainingResources2Info, "InnerText", "Grantee Training Resources", null, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(4)); }
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (InnerText='Support') on item 'Login1.NavNavbarNavSamsNavbarNav.Support3'.", repo.Login1.NavNavbarNavSamsNavbarNav.Support3Info, new RecordItemIndex(5));
                Validate.AttributeEqual(repo.Login1.NavNavbarNavSamsNavbarNav.Support3Info, "InnerText", "Support", null, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(5)); }
            
            // Support Tile Screenshot
            Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(6));
            
            // Grantor Training Resources
            Report.Log(ReportLevel.Info, "Section", "Grantor Training Resources", new RecordItemIndex(7));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.NavNavbarNavSamsNavbarNav.GrantorTrainingResources1' at 87;14.", repo.Login1.NavNavbarNavSamsNavbarNav.GrantorTrainingResources1Info, new RecordItemIndex(8));
            repo.Login1.NavNavbarNavSamsNavbarNav.GrantorTrainingResources1.Click("87;14");
            Delay.Milliseconds(0);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating Exists on item 'Login1.HttpsMygrantstrainServiceNowComDe'.", repo.Login1.HttpsMygrantstrainServiceNowComDeInfo, new RecordItemIndex(9));
                Validate.Exists(repo.Login1.HttpsMygrantstrainServiceNowComDeInfo, null, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(9)); }
            
            // Grantor Training Resources Screenshot
            Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(10));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.NavNavbarNavSamsNavbarNav.HOME' at 14;7.", repo.Login1.NavNavbarNavSamsNavbarNav.HOMEInfo, new RecordItemIndex(11));
            repo.Login1.NavNavbarNavSamsNavbarNav.HOME.Click("14;7");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s for the attribute 'InnerText' to equal the specified value $OSDS_Grantor_WM. Associated repository item: 'Login1.HiMikeHannigan'", repo.Login1.HiMikeHanniganInfo, new RecordItemIndex(12));
            repo.Login1.HiMikeHanniganInfo.WaitForAttributeEqual(5000, "InnerText", OSDS_Grantor_WM);
            
            // Grantee Training Resources
            Report.Log(ReportLevel.Info, "Section", "Grantee Training Resources", new RecordItemIndex(13));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.NavNavbarNavSamsNavbarNav.ATagSupport2' at 53;38.", repo.Login1.NavNavbarNavSamsNavbarNav.ATagSupport2Info, new RecordItemIndex(14));
            repo.Login1.NavNavbarNavSamsNavbarNav.ATagSupport2.Click("53;38");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.NavNavbarNavSamsNavbarNav.GranteeTrainingResources2' at 89;9.", repo.Login1.NavNavbarNavSamsNavbarNav.GranteeTrainingResources2Info, new RecordItemIndex(15));
            repo.Login1.NavNavbarNavSamsNavbarNav.GranteeTrainingResources2.Click("89;9");
            Delay.Milliseconds(200);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating Exists on item 'Login1.HttpsMygrantstrainServiceNowComDe'.", repo.Login1.HttpsMygrantstrainServiceNowComDeInfo, new RecordItemIndex(16));
                Validate.Exists(repo.Login1.HttpsMygrantstrainServiceNowComDeInfo, null, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(16)); }
            
            // Grantee Training Resources Screenshot
            Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(17));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.NavNavbarNavSamsNavbarNav.HOME' at 14;7.", repo.Login1.NavNavbarNavSamsNavbarNav.HOMEInfo, new RecordItemIndex(18));
            repo.Login1.NavNavbarNavSamsNavbarNav.HOME.Click("14;7");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s for the attribute 'InnerText' to equal the specified value $OSDS_Grantor_WM. Associated repository item: 'Login1.HiMikeHannigan'", repo.Login1.HiMikeHanniganInfo, new RecordItemIndex(19));
            repo.Login1.HiMikeHanniganInfo.WaitForAttributeEqual(5000, "InnerText", OSDS_Grantor_WM);
            
            // Support
            Report.Log(ReportLevel.Info, "Section", "Support", new RecordItemIndex(20));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.NavNavbarNavSamsNavbarNav.ATagSupport2' at 53;38.", repo.Login1.NavNavbarNavSamsNavbarNav.ATagSupport2Info, new RecordItemIndex(21));
            repo.Login1.NavNavbarNavSamsNavbarNav.ATagSupport2.Click("53;38");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.NavNavbarNavSamsNavbarNav.Support3' at 51;6.", repo.Login1.NavNavbarNavSamsNavbarNav.Support3Info, new RecordItemIndex(22));
            repo.Login1.NavNavbarNavSamsNavbarNav.Support3.Click("51;6");
            Delay.Milliseconds(200);
            
            try {
                Report.Log(ReportLevel.Info, "Validation", "(Optional Action)\r\nValidating AttributeEqual (InnerText='Overseas Grantor Support ') on item 'Login1.OverseasGrantorSupport'.", repo.Login1.OverseasGrantorSupportInfo, new RecordItemIndex(23));
                Validate.AttributeEqual(repo.Login1.OverseasGrantorSupportInfo, "InnerText", "Overseas Grantor Support ", null, false);
                Delay.Milliseconds(100);
            } catch(Exception ex) { Report.Log(ReportLevel.Warn, "Module", "(Optional Action) " + ex.Message, new RecordItemIndex(23)); }
            
            // Support Screenshot
            Report.Screenshot(ReportLevel.Success, "User", "", null, false, new RecordItemIndex(24));
            
            Report.Log(ReportLevel.Info, "Mouse", "Mouse Left Click item 'Login1.NavNavbarNavSamsNavbarNav.HOME' at 14;7.", repo.Login1.NavNavbarNavSamsNavbarNav.HOMEInfo, new RecordItemIndex(25));
            repo.Login1.NavNavbarNavSamsNavbarNav.HOME.Click("14;7");
            Delay.Milliseconds(200);
            
            Report.Log(ReportLevel.Info, "Wait", "Waiting 5s for the attribute 'InnerText' to equal the specified value $OSDS_Grantor_WM. Associated repository item: 'Login1.HiMikeHannigan'", repo.Login1.HiMikeHanniganInfo, new RecordItemIndex(26));
            repo.Login1.HiMikeHanniganInfo.WaitForAttributeEqual(5000, "InnerText", OSDS_Grantor_WM);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}