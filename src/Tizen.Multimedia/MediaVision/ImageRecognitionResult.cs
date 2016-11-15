﻿/*
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
using System.Collections.Generic;

namespace Tizen.Multimedia
{
    /// <summary>
    /// This class represents result of image recognition.
    /// </summary>
    public class ImageRecognitionResult
    {
        internal ImageRecognitionResult()
        {
        }

        /// <summary>
        /// The indexes of recognized image objects and their locations on the source image.
        /// </summary>
        public List<Tuple<int, Quadrangle>> Results { get; internal set; }
    }
}
