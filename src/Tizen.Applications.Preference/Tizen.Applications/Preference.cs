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
using System.Collections.Generic;
using Tizen.Internals.Errors;

namespace Tizen.Applications
{
    /// <summary>
    /// The Preference class provides APIs to store and retrieve application specific data/preference. A preference is saved in the form of a key-value pair.
    /// Keys are always text strings and value can be any one of four types: integer, double, string and boolean.
    /// </summary>
    public static class Preference
    {
        private const string LogTag = "Tizen.Applications";
        private static Interop.Preference.ChangedCallback s_preferenceChangedCallback;
        private static IDictionary<string, EventContext> s_eventMap = new Dictionary<string, EventContext>();

        static Preference()
        {
            s_preferenceChangedCallback = (string key, IntPtr userData) =>
            {
                try
                {
                    s_eventMap[key]?.FireEvent();
                }
                catch (Exception e)
                {
                    Log.Warn(LogTag, e.Message);
                }
            };
        }

        /// <summary>
        /// Retrieves all keys of the application preferences
        /// </summary>
        /// <value>
        /// The list of keys
        /// </value>
        /// <example>
        /// <code>
        ///     Preference.Set("Option_enabled", true);
        ///     Preference.Set("active_user", "Joe");
        ///     Preference.Set("default_volume", 10);
        ///     Preference.Set("brightness", "0.6");
        ///     foreach(string key in Preference.Keys)
        ///     {
        ///         Console.WriteLine("key {0}", key);
        ///     }
        /// </code>
        /// </example>
        public static IEnumerable<string> Keys
        {
            get
            {
                var collection = new List<string>();
                Interop.Preference.ItemCallback itemsCallback = (string key, IntPtr userData) =>
                {
                    collection.Add(key);
                    return true;
                };
                Interop.Preference.ForeachItem(itemsCallback, IntPtr.Zero);
                return collection;
            }
        }

        /// <summary>
        /// Gets the event context for the given key.
        /// </summary>
        /// <seealso cref="EventContext"/>
        /// <param name="key">The preference key</param>
        /// <returns>The event context of respective key</returns>
        /// <exception cref="KeyNotFoundException">Thrown if the key is not found</exception>
        /// <exception cref="ArgumentException">Thrown if the key is an invalid parameter.</exception>
        /// <example>
        /// <code>
        ///     private static void Preference_PreferenceChanged(object sender, PreferenceChangedEventArgs e)
        ///     {
        ///         Console.WriteLine("key {0}", e.Key);
        ///     }
        ///
        ///     Preference.EventContext context = null;
        ///     Preference.GetEventContext("active_user").TryGetTarget(out context);
        ///     if(context != null)
        ///     {
        ///         context.Changed += Preference_PreferenceChanged;
        ///     }
        ///
        ///     Preference.Set("active_user", "Poe");
        ///
        ///     Preference.GetEventContext("active_user").TryGetTarget(out context);
        ///     if (context != null)
        ///     {
        ///         context.Changed -= Preference_PreferenceChanged;
        ///     }
        /// </code>
        /// </example>
        public static WeakReference<EventContext> GetEventContext(string key)
        {
            if (!s_eventMap.ContainsKey(key))
            {
                if (Contains(key))
                {
                    s_eventMap[key] = new EventContext(key);
                }
                else
                {
                    throw PreferenceErrorFactory.GetException((int)PreferenceErrorFactory.PreferenceError.KeyNotAvailable);
                }
            }

            return new WeakReference<EventContext>(s_eventMap[key]);
        }

        /// <summary>
        /// Checks whether the given key exists in the preference.
        /// </summary>
        /// <param name="key">The name of the key to check</param>
        /// <returns>true if the key exists in the preference, otherwise false</returns>
        /// <exception cref="ArgumentException">Thrown if the key is an invalid parameter.</exception>
        /// <exception cref="IOException">Thrown when method failed due to internal IO error.</exception>
        /// <example>
        /// <code>
        ///     Preference.Set("active_user", "Joe");
        ///     bool exists = Preference.Contains("active_user");
        ///     if (exists)
        ///     {
        ///         string value = Preference.Get<string>("active_user");
        ///         Console.WriteLine("user {0}", value);
        ///     }
        /// </code>
        /// </example>
        public static bool Contains(string key)
        {
            bool contains;
            int ret = Interop.Preference.IsExisting(key, out contains);
            if (ret != (int)PreferenceErrorFactory.PreferenceError.None)
            {
                Log.Error(LogTag, "Failed to find key");
                throw PreferenceErrorFactory.GetException(ret);
            }

            return contains;
        }

        /// <summary>
        /// Sets a key-value pair representing the preference.
        /// </summary>
        /// <remarks>
        /// If the key already exists in the Preference, old value will be overwritten with new value.
        /// Data types supported for value are: integer, double, string and bool.
        /// </remarks>
        /// <param name="key">The name of the key to create/modigy</param>
        /// <param name="value">The value corresponding to the key.</param>
        /// <exception cref="ArgumentException">Thrown if the key is an invalid parameter.</exception>
        /// <exception cref="System.IO.IOException">Thrown when method failed due to internal IO error.</exception>
        /// <example>
        /// <code>
        ///     Preference.Set("Option_enabled", true);
        ///     Preference.Set("active_user", "Joe");
        ///     Preference.Set("default_volume", 10);
        ///     Preference.Set("brightness", "0.6");
        /// </code>
        /// </example>
        public static void Set(string key, object value)
        {
            int ret = 0;
            if (value is int)
            {
                ret = Interop.Preference.SetInt(key, (int)value);
                if (ret != (int)PreferenceErrorFactory.PreferenceError.None)
                {
                    Log.Error(LogTag, "Failed to find key");
                    throw PreferenceErrorFactory.GetException(ret);
                }
            }
            else if (value is double)
            {
                ret = Interop.Preference.SetDouble(key, (double)value);
                if (ret != (int)PreferenceErrorFactory.PreferenceError.None)
                {
                    Log.Error(LogTag, "Failed to find key");
                    throw PreferenceErrorFactory.GetException(ret);
                }
            }
            else if (value is string)
            {
                ret = Interop.Preference.SetString(key, (string)value);
                if (ret != (int)PreferenceErrorFactory.PreferenceError.None)
                {
                    Log.Error(LogTag, "Failed to find key");
                    throw PreferenceErrorFactory.GetException(ret);
                }
            }
            else if (value is bool)
            {
                ret = Interop.Preference.SetBoolean(key, (bool)value);
                if (ret != (int)PreferenceErrorFactory.PreferenceError.None)
                {
                    Log.Error(LogTag, "Failed to find key");
                    throw PreferenceErrorFactory.GetException(ret);
                }
            }
            else
            {
                Log.Error(LogTag, "Failed to Set");
                throw new ArgumentException("Invalid parameter");
            }
        }

        /// <summary>
        /// Gets the value of a preference item with the specified key.
        /// Note that this is a generic method.
        /// </summary>
        /// <typeparam name="T">The generic type to return.</typeparam>
        /// <param name="key">The key of the preference</param>
        /// <returns>The value of the preference item if it is of the specified generic type.</returns>
        /// <exception cref="KeyNotFoundException">Thrown if the key is not found</exception>
        /// <exception cref="ArgumentException">Thrown if the key is an invalid parameter.</exception>
        /// <exception cref="System.IO.IOException">Thrown when method failed due to internal IO error.</exception>
        /// <example>
        /// <code>
        ///     bool exists = Preference.Contains("active_user");
        ///     if (exists)
        ///     {
        ///         string value = Preference.Get<string>("active_user");
        ///         Console.WriteLine("user {0}", value);
        ///     }
        /// </code>
        /// </example>
        public static T Get<T>(string key)
        {
            object result = null;
            int ret = (int)PreferenceErrorFactory.PreferenceError.None;
            if (typeof(T) == typeof(bool))
            {
                bool val;
                ret = Interop.Preference.GetBoolean(key, out val);
                result = val;
            }
            else if (typeof(T) == typeof(int))
            {
                int val;
                ret = Interop.Preference.GetInt(key, out val);
                result = val;
            }
            else if (typeof(T) == typeof(string))
            {
                string val;
                ret = Interop.Preference.GetString(key, out val);
                result = val;
            }
            else if (typeof(T) == typeof(double))
            {
                double val;
                ret = Interop.Preference.GetDouble(key, out val);
                result = val;
            }
            else
            {
                Log.Error(LogTag, "Failed to remove key");
                throw new ArgumentException("Invalid parameter");
            }

            if (ret != (int)PreferenceErrorFactory.PreferenceError.None)
            {
                Log.Error(LogTag, "Failed to remove key");
                throw PreferenceErrorFactory.GetException(ret);
            }

            return (result != null) ? (T)result : default(T);
        }

        /// <summary>
        /// Removes any preference value with the given key.
        /// </summary>
        /// <param name="key">The key to remove</param>
        /// <exception cref="KeyNotFoundException">Thrown if the key is not found</exception>
        /// <exception cref="System.IO.IOException">Thrown when method failed due to internal IO error.</exception>
        /// <example>
        /// <code>
        ///     bool exists = Preference.Contains("active_user");
        ///     if (exists)
        ///     {
        ///         string value = Preference.Remove("active_user");
        ///     }
        /// </code>
        /// </example>
        public static void Remove(string key)
        {
            int ret = Interop.Preference.Remove(key);
            if (ret != (int)PreferenceErrorFactory.PreferenceError.None)
            {
                Log.Error(LogTag, "Failed to remove key");
                throw PreferenceErrorFactory.GetException(ret);
            }
        }

        /// <summary>
        /// Removes all key-value pairs from the preference.
        /// </summary>
        /// <exception cref="System.IO.IOException">Thrown when method failed due to internal IO error.</exception>
        /// <example>
        /// <code>
        ///     Preference.Set("Option_enabled", true);
        ///     Preference.Set("active_user", "Joe");
        ///     Preference.Set("default_volume", 10);
        ///     Preference.Set("brightness", "0.6");
        ///     Preference.RemoveAll();
        /// </code>
        /// </example>
        public static void RemoveAll()
        {
            int ret = Interop.Preference.RemoveAll();
            if (ret != (int)PreferenceErrorFactory.PreferenceError.None)
            {
                Log.Error(LogTag, "Failed to remove all keys");
                throw PreferenceErrorFactory.GetException(ret);
            }
        }

        private static void AllowChangeNotifications(string key)
        {
            int ret = Interop.Preference.SetChangedCb(key, s_preferenceChangedCallback, IntPtr.Zero);
            if (ret != (int)PreferenceErrorFactory.PreferenceError.None)
            {
                Log.Error(LogTag, "Failed to set key notification");
                throw PreferenceErrorFactory.GetException(ret);
            }
        }

        private static void DisallowChangeNotifications(string key)
        {
            int ret = Interop.Preference.UnsetChangedCb(key);
            if (ret != (int)PreferenceErrorFactory.PreferenceError.None)
            {
                Log.Error(LogTag, "Failed to remove key notification");
                throw PreferenceErrorFactory.GetException(ret);
            }
        }

        /// <summary>
        /// The class manages event handlers of preference keys. The class enables having event handlers for individual preference keys.
        /// </summary>
        public class EventContext
        {
            private string _key;

            internal EventContext(string key)
            {
                _key = key;
            }

            /// <summary>
            /// Occurs whenever there is change in the value of preference key.
            /// </summary>
            /// <exception cref="System.ArgumentException">Thrown when the key does not exist or when there is an invalid parameter.</exception>
            /// <exception cref="System.InvalidOperationException">Thrown when the Bundle instance has been disposed.</exception>
            /// <example>
            /// <code>
            ///     private static void Preference_PreferenceChanged(object sender, PreferenceChangedEventArgs e)
            ///     {
            ///         Console.WriteLine("key {0}", e.Key);
            ///     }
            ///     Preference.EventContext context = null;
            ///     Preference.GetEventContext("active_user").TryGetTarget(out context);
            ///     if(context != null)
            ///     {
            ///         context.Changed += Preference_PreferenceChanged;
            ///     }
            ///
            ///     Preference.Set("active_user", "Poe");
            ///
            ///     Preference.GetEventContext("active_user").TryGetTarget(out context);
            ///     if (context != null)
            ///     {
            ///         context.Changed -= Preference_PreferenceChanged;
            ///     }
            /// </code>
            /// </example>
            public event EventHandler<PreferenceChangedEventArgs> Changed
            {
                add
                {
                    if (_changed == null)
                    {
                        AllowChangeNotifications(_key);
                    }

                    _changed += value;
                }

                remove
                {
                    _changed -= value;
                    if (_changed == null)
                    {
                        DisallowChangeNotifications(_key);
                        s_eventMap.Remove(_key);
                    }
                }
            }

            private event EventHandler<PreferenceChangedEventArgs> _changed;

            internal void FireEvent()
            {
                _changed?.Invoke(null, new PreferenceChangedEventArgs() { Key = _key });
            }
        }

    }

    internal static class PreferenceErrorFactory
    {
        internal enum PreferenceError
        {
            None = ErrorCode.None,
            OutOfMemory = ErrorCode.OutOfMemory,
            InvalidParameter = ErrorCode.InvalidParameter,
            KeyNotAvailable = -0x01100000 | 0x30,
            IoError = ErrorCode.IoError
        }

        static internal Exception GetException(int error)
        {
            if ((PreferenceError)error == PreferenceError.OutOfMemory)
            {
                return new OutOfMemoryException("Out of memory");
            }
            else if ((PreferenceError)error == PreferenceError.InvalidParameter)
            {
                return new ArgumentException("Invalid parameter");
            }
            else if ((PreferenceError)error == PreferenceError.KeyNotAvailable)
            {
                return new KeyNotFoundException("Key does not exist in the bundle");
            }
            else if ((PreferenceError)error == PreferenceError.IoError)
            {
                return new System.IO.IOException("I/O Error");
            }
            else
            {
                return new ArgumentException("Unknown error");
            }
        }
    }
}
