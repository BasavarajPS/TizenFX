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
using System.Diagnostics;

namespace Tizen.Multimedia
{
    //TODO we need a better name.
    /// <summary>
    /// Represents data for a video frame captured.
    /// </summary>
    public class CapturedFrame
    {
        internal CapturedFrame(byte[] imageBuffer, int width, int height)
        {
            Debug.Assert(imageBuffer != null, "imageBuffer is null!");
            Debug.Assert(width > 0, $"Width is invalid : {width}!");
            Debug.Assert(height > 0, $"height is invalid : {height}!");

            Buffer = imageBuffer;
            Size = new Size(width, height);
        }

        /// <summary>
        /// Gets the raw buffer of the captured image.
        /// </summary>
        /// <remarks>The color space format is RGB888.</remarks>
        public byte[] Buffer { get; }

        /// <summary>
        /// Gets the size.
        /// </summary>
        public Size Size { get; }
    }
}
