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

namespace Tizen.Multimedia
{
    /// <summary>
    /// Provides the ability to control the audio effects for <see cref="Multimedia.Player"/>.
    /// </summary>
    public class AudioEffect
    {
        private readonly EqualizerBand[] _bands;

        internal AudioEffect(Player owner)
        {
            Player = owner;

            bool available = false;
            int ret = Interop.Player.AudioEffectEqualizerIsAvailable(Player.GetHandle(), out available);
            PlayerErrorConverter.ThrowIfError(ret, "Failed to initialize the AudioEffect");

            int count = 0;
            ret = Interop.Player.AudioEffectGetEqualizerBandsCount(Player.GetHandle(), out count);
            PlayerErrorConverter.ThrowIfError(ret, "Failed to initialize the AudioEffect");

            int min = 0;
            int max = 0;
            ret = Interop.Player.AudioEffectGetEqualizerLevelRange(Player.GetHandle(), out min, out max);
            PlayerErrorConverter.ThrowIfError(ret, "Failed to initialize the AudioEffect");

            IsAvailable = available;
            Count = count;
            MinBandLevel = min;
            MaxBandLevel = max;

            _bands = new EqualizerBand[count];
        }

        /// <summary>
        /// Gets a <see cref="EqualizerBand"/> at the specified index.
        /// </summary>
        /// <param name="index">The index of the band to get</param>
        /// <exception cref="ObjectDisposedException">The <see cref="Player"/> has already been disposed of.</exception>
        /// <exception cref="ArgumentOutOfRangeException">
        ///     index is less than zero.
        ///     <para>-or-</para>
        ///     index is equal to or greater than <see cref="Count"/>.
        /// </exception>
        public EqualizerBand this[int index]
        {
            get
            {
                Player.ValidateNotDisposed();

                if (index < 0 || Count <= index)
                {
                    throw new ArgumentOutOfRangeException(nameof(index), index,
                        $"Valid index is 0 <= x < { nameof(Count) } ");
                }

                if (_bands[index] == null)
                {
                    _bands[index] = new EqualizerBand(this, index);
                }
                return _bands[index];
            }
        }

        /// <summary>
        /// Clears the equalizer effect.
        /// </summary>
        /// <exception cref="ObjectDisposedException">The <see cref="Player"/> has already been disposed of.</exception>
        public void Clear()
        {
            Player.ValidateNotDisposed();

            PlayerErrorConverter.ThrowIfError(Interop.Player.AudioEffectEqualizerClear(Player.GetHandle()),
                "Failed to clear equalizer effect");
        }

        public int Count{ get; }

        // TODO replace with range struct
        /// <summary>
        /// Get the minimum band level of the bands in dB.
        /// </summary>
        public int MinBandLevel { get; }

        /// <summary>
        /// Gets the maximum band level of the bands in dB.
        /// </summary>
        public int MaxBandLevel { get; }

        /// <summary>
        /// Gets the value whether the AudioEffect is available or not.
        /// </summary>
        public bool IsAvailable { get; }

        /// <summary>
        /// Gets the player that this AudioEffect belongs to.
        /// </summary>
        public Player Player { get; }
    }
}
