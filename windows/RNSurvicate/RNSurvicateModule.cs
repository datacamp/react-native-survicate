using ReactNative.Bridge;
using System;
using System.Collections.Generic;
using Windows.ApplicationModel.Core;
using Windows.UI.Core;

namespace Survicate.RNSurvicate
{
    /// <summary>
    /// A module that allows JS to share data.
    /// </summary>
    class RNSurvicateModule : NativeModuleBase
    {
        /// <summary>
        /// Instantiates the <see cref="RNSurvicateModule"/>.
        /// </summary>
        internal RNSurvicateModule()
        {

        }

        /// <summary>
        /// The name of the native module.
        /// </summary>
        public override string Name
        {
            get
            {
                return "RNSurvicate";
            }
        }
    }
}
