/*
 * Copyright (c) 2016 Samsung Electronics Co., Ltd All Rights Reserved
 *
 * Licensed under the Apache License, Version 2.0 (the License);
 * you may not use this file except in compliance with the License.
 * You may obtain a copy of the License at
 *
 * http://www.apache.org/licenses/LICENSE-2.0
 *
 * Unless required by applicable law or agreed to in writing, software
 * distributed under the License is distributed on an AS IS BASIS,
 * WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
 * See the License for the specific language governing permissions and
 * limitations under the License.
 */

using System;

namespace Tizen.Sensor
{
    /// <summary>
    /// The OrientationSensor changed event arguments class is used for storing the data returned by a orientation sensor.
    /// </summary>
    public class OrientationSensorDataUpdatedEventArgs : EventArgs
    {
        internal OrientationSensorDataUpdatedEventArgs(float[] values)
        {
            Azimuth = values[0];
            Pitch = values[1];
            Roll = values[2];
        }

        /// <summary>
        /// Gets the azimuth component of the orientation.
        /// </summary>
        /// <since_tizen> 3 </since_tizen>
        /// <value> Azimuth </value>
        public float Azimuth { get; private set; }

        /// <summary>
        /// Gets the pitch component of the orientation.
        /// </summary>
        /// <since_tizen> 3 </since_tizen>
        /// <value> Pitch </value>
        public float Pitch { get; private set; }

        /// <summary>
        /// Gets the roll component of the orientation.
        /// </summary>
        /// <since_tizen> 3 </since_tizen>
        /// <value> Roll </value>
        public float Roll { get; private set; }
    }
}
