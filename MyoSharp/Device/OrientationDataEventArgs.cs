﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

using MyoSharp.Math;

namespace MyoSharp.Device
{
    public class OrientationDataEventArgs : MyoEventArgs
    {
        #region Constructors
        public OrientationDataEventArgs(Myo myo, DateTime timestamp, QuaternionF orientation)
            : base(myo, timestamp)
        {
            this.Orientation = orientation;
        }
        #endregion

        #region Properties
        public QuaternionF Orientation { get; private set; }
        #endregion
    }
}