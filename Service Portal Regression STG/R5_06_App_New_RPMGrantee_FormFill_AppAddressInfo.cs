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
    ///The R5_06_App_New_RPMGrantee_FormFill_AppAddressInfo recording.
    /// </summary>
    [TestModule("5cac41c9-7ca1-48c0-9baf-6909e6fb4a04", ModuleType.Recording, 1)]
    public partial class R5_06_App_New_RPMGrantee_FormFill_AppAddressInfo : ITestModule
    {
        /// <summary>
        /// Holds an instance of the Service_Portal_Regression_STGRepository repository.
        /// </summary>
        public static Service_Portal_Regression_STGRepository repo = Service_Portal_Regression_STGRepository.Instance;

        static R5_06_App_New_RPMGrantee_FormFill_AppAddressInfo instance = new R5_06_App_New_RPMGrantee_FormFill_AppAddressInfo();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public R5_06_App_New_RPMGrantee_FormFill_AppAddressInfo()
        {
            Street_Address1 = "123 Fort Lane";
            Street_Address2 = "Apt 12";
            City = "Atlanta";
            County_Parish = "Fulton";
            State = "Texas";
            Province = "None";
            Zip = "30076";
            Country = "United States of America";
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static R5_06_App_New_RPMGrantee_FormFill_AppAddressInfo Instance
        {
            get { return instance; }
        }

#region Variables

        string _Street_Address1;

        /// <summary>
        /// Gets or sets the value of variable Street_Address1.
        /// </summary>
        [TestVariable("179ef01e-261f-4c31-b5d0-15477f3f6db2")]
        public string Street_Address1
        {
            get { return _Street_Address1; }
            set { _Street_Address1 = value; }
        }

        string _Street_Address2;

        /// <summary>
        /// Gets or sets the value of variable Street_Address2.
        /// </summary>
        [TestVariable("c1027e57-8409-4ff4-8195-2da571b71e77")]
        public string Street_Address2
        {
            get { return _Street_Address2; }
            set { _Street_Address2 = value; }
        }

        string _City;

        /// <summary>
        /// Gets or sets the value of variable City.
        /// </summary>
        [TestVariable("fba77462-3b77-414f-8931-af698daaead9")]
        public string City
        {
            get { return _City; }
            set { _City = value; }
        }

        string _County_Parish;

        /// <summary>
        /// Gets or sets the value of variable County_Parish.
        /// </summary>
        [TestVariable("14fea164-8284-4d95-9b3c-0a3e55fa4d10")]
        public string County_Parish
        {
            get { return _County_Parish; }
            set { _County_Parish = value; }
        }

        string _State;

        /// <summary>
        /// Gets or sets the value of variable State.
        /// </summary>
        [TestVariable("d1db7f52-5422-4dfa-b749-b095be8963be")]
        public string State
        {
            get { return _State; }
            set { _State = value; }
        }

        string _Province;

        /// <summary>
        /// Gets or sets the value of variable Province.
        /// </summary>
        [TestVariable("31090d33-0646-4734-8f79-a8ab7ddf4847")]
        public string Province
        {
            get { return _Province; }
            set { _Province = value; }
        }

        string _Zip;

        /// <summary>
        /// Gets or sets the value of variable Zip.
        /// </summary>
        [TestVariable("2497001b-e229-489a-998b-41c237311172")]
        public string Zip
        {
            get { return _Zip; }
            set { _Zip = value; }
        }

        string _Country;

        /// <summary>
        /// Gets or sets the value of variable Country.
        /// </summary>
        [TestVariable("05c16320-1f78-4a5c-8aac-6e9a378fe4d1")]
        public string Country
        {
            get { return _Country; }
            set { _Country = value; }
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

            // Street Address 1
            Report.Log(ReportLevel.Info, "Section", "Street Address 1", new RecordItemIndex(0));
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Street_Address1' with focus on 'Login1.C8d73b9a2db393b0016bc300f7c961903NgSco.UStreetAddress12'.", repo.Login1.C8d73b9a2db393b0016bc300f7c961903NgSco.UStreetAddress12Info, new RecordItemIndex(1));
            repo.Login1.C8d73b9a2db393b0016bc300f7c961903NgSco.UStreetAddress12.PressKeys(Street_Address1);
            Delay.Milliseconds(30);
            
            // Street Address 2
            Report.Log(ReportLevel.Info, "Section", "Street Address 2", new RecordItemIndex(2));
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Street_Address2' with focus on 'Login1.C8d73b9a2db393b0016bc300f7c961903NgSco.UStreetAddress22'.", repo.Login1.C8d73b9a2db393b0016bc300f7c961903NgSco.UStreetAddress22Info, new RecordItemIndex(3));
            repo.Login1.C8d73b9a2db393b0016bc300f7c961903NgSco.UStreetAddress22.PressKeys(Street_Address2);
            Delay.Milliseconds(30);
            
            // City
            Report.Log(ReportLevel.Info, "Section", "City", new RecordItemIndex(4));
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$City' with focus on 'Login1.SpFormfieldUCity'.", repo.Login1.SpFormfieldUCityInfo, new RecordItemIndex(5));
            repo.Login1.SpFormfieldUCity.PressKeys(City);
            Delay.Milliseconds(30);
            
            // County/Parish
            Report.Log(ReportLevel.Info, "Section", "County/Parish", new RecordItemIndex(6));
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$County_Parish' with focus on 'Login1.SpFormfieldUCountyParish'.", repo.Login1.SpFormfieldUCountyParishInfo, new RecordItemIndex(7));
            repo.Login1.SpFormfieldUCountyParish.PressKeys(County_Parish);
            Delay.Milliseconds(30);
            
            // State
            Report.Log(ReportLevel.Info, "Section", "State", new RecordItemIndex(8));
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$State' with focus on 'Login1.SpFormfieldUState'.", repo.Login1.SpFormfieldUStateInfo, new RecordItemIndex(9));
            repo.Login1.SpFormfieldUState.PressKeys(State);
            Delay.Milliseconds(30);
            
            // Province
            Report.Log(ReportLevel.Info, "Section", "Province", new RecordItemIndex(10));
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Province' with focus on 'Login1.SpFormfieldUProvince'.", repo.Login1.SpFormfieldUProvinceInfo, new RecordItemIndex(11));
            repo.Login1.SpFormfieldUProvince.PressKeys(Province);
            Delay.Milliseconds(30);
            
            // Zip/Postal
            Report.Log(ReportLevel.Info, "Section", "Zip/Postal", new RecordItemIndex(12));
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Zip' with focus on 'Login1.SpFormfieldUZipPostalCode'.", repo.Login1.SpFormfieldUZipPostalCodeInfo, new RecordItemIndex(13));
            repo.Login1.SpFormfieldUZipPostalCode.PressKeys(Zip);
            Delay.Milliseconds(30);
            
            // Country
            Report.Log(ReportLevel.Info, "Section", "Country", new RecordItemIndex(14));
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{LShiftKey down}{Tab}{LShiftKey up}' with focus on 'Login1'.", repo.Login1.SelfInfo, new RecordItemIndex(15));
            repo.Login1.Self.EnsureVisible();
            Keyboard.Press("{LShiftKey down}{Tab}{LShiftKey up}");
            Delay.Milliseconds(0);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 300ms.", new RecordItemIndex(16));
            Delay.Duration(300, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence from variable '$Country'.", new RecordItemIndex(17));
            Keyboard.Press(Country);
            Delay.Milliseconds(30);
            
            Report.Log(ReportLevel.Info, "Delay", "Waiting for 1s.", new RecordItemIndex(18));
            Delay.Duration(1000, false);
            
            Report.Log(ReportLevel.Info, "Keyboard", "Key sequence '{enter}'.", new RecordItemIndex(19));
            Keyboard.Press("{enter}");
            Delay.Milliseconds(0);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}
