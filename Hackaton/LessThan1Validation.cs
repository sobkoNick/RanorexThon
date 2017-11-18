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

namespace Hackaton
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    ///The LessThan1Validation recording.
    /// </summary>
    [TestModule("2118b2a8-2062-4437-a38d-b3fcf2bd1bdb", ModuleType.Recording, 1)]
    public partial class LessThan1Validation : ITestModule
    {
        /// <summary>
        /// Holds an instance of the HackatonRepository repository.
        /// </summary>
        public static HackatonRepository repo = HackatonRepository.Instance;

        static LessThan1Validation instance = new LessThan1Validation();

        /// <summary>
        /// Constructs a new instance.
        /// </summary>
        public LessThan1Validation()
        {
        }

        /// <summary>
        /// Gets a static instance of this recording.
        /// </summary>
        public static LessThan1Validation Instance
        {
            get { return instance; }
        }

#region Variables

#endregion

        /// <summary>
        /// Starts the replay of the static recording <see cref="Instance"/>.
        /// </summary>
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "7.2")]
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
        [System.CodeDom.Compiler.GeneratedCode("Ranorex", "7.2")]
        void ITestModule.Run()
        {
            Mouse.DefaultMoveTime = 300;
            Keyboard.DefaultKeyPressTime = 100;
            Delay.SpeedFactor = 1.00;

            Init();

            Report.Log(ReportLevel.Info, "Touch", "Touch item 'ComHackatonEpamTahackaton.CartMinus' at 39;49", repo.ComHackatonEpamTahackaton.CartMinusInfo, new RecordItemIndex(0));
            repo.ComHackatonEpamTahackaton.CartMinus.Touch("39;49");
            Delay.Milliseconds(500);
            
            Report.Log(ReportLevel.Info, "Validation", "Validating AttributeEqual (Text='Yeah! Like you can have less!') on item 'ComHackatonEpamTahackaton.ErrorCount'.", repo.ComHackatonEpamTahackaton.ErrorCountInfo, new RecordItemIndex(1));
            Validate.Attribute(repo.ComHackatonEpamTahackaton.ErrorCountInfo, "Text", "Yeah! Like you can have less!");
            Delay.Milliseconds(100);
            
        }

#region Image Feature Data
#endregion
    }
#pragma warning restore 0436
}