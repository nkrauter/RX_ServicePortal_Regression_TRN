/*
 * Created by Ranorex
 * User: nick.m.krauter
 * Date: 12/4/2019
 * Time: 3:19 PM
 * 
 * To change this template use Tools > Options > Coding > Edit standard headers.
 */
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

namespace Service_Portal_Regression_STG
{
    /// <summary>
    /// Description of R2_02_Prorgram_New_RPMGrantor_FormFill.
    /// </summary>
    [TestModule("7580284A-DEB4-4958-9605-9FC3EE1A5CC7", ModuleType.UserCode, 1)]
    public class R2_02_Prorgram_New_RPMGrantor_FormFill : ITestModule
    {
        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public R2_02_Prorgram_New_RPMGrantor_FormFill()
        {
            // Do not delete - a parameterless constructor is required!
        }

        /// <summary>
        /// Performs the playback of actions in this module.
        /// </summary>
        /// <remarks>You should not call this method directly, instead pass the module
        /// instance to the <see cref="TestModuleRunner.Run(ITestModule)"/> method
        /// that will in turn invoke this method.</remarks>
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.0;
        }
    }
}
