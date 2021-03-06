#pragma warning disable CS1591
using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
namespace Efl { 
/// <summary>A generic configuration interface, that holds key-value pairs.</summary>
[ConfigNativeInherit]
public interface Config : 
   Efl.Eo.IWrapper, IDisposable
{
   /// <summary>A generic configuration value, referred to by name.</summary>
/// <param name="name">Configuration option name.</param>
/// <returns>The value. It will be empty if it doesn&apos;t exist. The caller must free it after use (using <c>eina_value_free</c>() in C).</returns>
 Eina.Value GetConfig(  System.String name);
   /// <summary>A generic configuration value, referred to by name.</summary>
/// <param name="name">Configuration option name.</param>
/// <param name="value">Configuration option value. May be <c>null</c> if not found.</param>
/// <returns><c>false</c> in case of error: value type was invalid, the config can&apos;t be changed, config does not exist...</returns>
bool SetConfig(  System.String name,   Eina.Value value);
      }
/// <summary>A generic configuration interface, that holds key-value pairs.</summary>
sealed public class ConfigConcrete : 

Config
   
{
   ///<summary>Pointer to the native class description.</summary>
   public System.IntPtr NativeClass {
      get {
         if (((object)this).GetType() == typeof (ConfigConcrete))
            return Efl.ConfigNativeInherit.GetEflClassStatic();
         else
            return Efl.Eo.ClassRegister.klassFromType[((object)this).GetType()];
      }
   }
   private  System.IntPtr handle;
   ///<summary>Pointer to the native instance.</summary>
   public System.IntPtr NativeHandle {
      get { return handle; }
   }
   [System.Runtime.InteropServices.DllImport(efl.Libs.Efl)] internal static extern System.IntPtr
      efl_config_interface_get();
   ///<summary>Internal usage: Constructs an instance from a native pointer. This is used when interacting with C code and should not be used directly.</summary>
   public ConfigConcrete(System.IntPtr raw)
   {
      handle = raw;
      register_event_proxies();
   }
   ///<summary>Destructor.</summary>
   ~ConfigConcrete()
   {
      Dispose(false);
   }
   ///<summary>Releases the underlying native instance.</summary>
   void Dispose(bool disposing)
   {
      if (handle != System.IntPtr.Zero) {
         Efl.Eo.Globals.efl_unref(handle);
         handle = System.IntPtr.Zero;
      }
   }
   ///<summary>Releases the underlying native instance.</summary>
   public void Dispose()
   {
      Dispose(true);
      GC.SuppressFinalize(this);
   }
   ///<summary>Casts obj into an instance of this type.</summary>
   public static ConfigConcrete static_cast(Efl.Object obj)
   {
      if (obj == null)
         throw new System.ArgumentNullException("obj");
      return new ConfigConcrete(obj.NativeHandle);
   }
   ///<summary>Verifies if the given object is equal to this one.</summary>
   public override bool Equals(object obj)
   {
      var other = obj as Efl.Object;
      if (other == null)
         return false;
      return this.NativeHandle == other.NativeHandle;
   }
   ///<summary>Gets the hash code for this object based on the native pointer it points to.</summary>
   public override int GetHashCode()
   {
      return this.NativeHandle.ToInt32();
   }
   ///<summary>Turns the native pointer into a string representation.</summary>
   public override String ToString()
   {
      return $"{this.GetType().Name}@[{this.NativeHandle.ToInt32():x}]";
   }
    void register_event_proxies()
   {
   }
   /// <summary>A generic configuration value, referred to by name.</summary>
   /// <param name="name">Configuration option name.</param>
   /// <returns>The value. It will be empty if it doesn&apos;t exist. The caller must free it after use (using <c>eina_value_free</c>() in C).</returns>
   public  Eina.Value GetConfig(  System.String name) {
                         var _ret_var = Efl.ConfigNativeInherit.efl_config_get_ptr.Value.Delegate(this.NativeHandle, name);
      Eina.Error.RaiseIfUnhandledException();
                  return _ret_var;
 }
   /// <summary>A generic configuration value, referred to by name.</summary>
   /// <param name="name">Configuration option name.</param>
   /// <param name="value">Configuration option value. May be <c>null</c> if not found.</param>
   /// <returns><c>false</c> in case of error: value type was invalid, the config can&apos;t be changed, config does not exist...</returns>
   public bool SetConfig(  System.String name,   Eina.Value value) {
                                           var _ret_var = Efl.ConfigNativeInherit.efl_config_set_ptr.Value.Delegate(this.NativeHandle, name,  value);
      Eina.Error.RaiseIfUnhandledException();
                              return _ret_var;
 }
}
public class ConfigNativeInherit  : Efl.Eo.NativeClass{
   public  static Efl.Eo.NativeModule _Module = new Efl.Eo.NativeModule(efl.Libs.Efl);
   public override System.Collections.Generic.List<Efl_Op_Description> GetEoOps(System.Type type)
   {
      var descs = new System.Collections.Generic.List<Efl_Op_Description>();
      if (efl_config_get_static_delegate == null)
      efl_config_get_static_delegate = new efl_config_get_delegate(config_get);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_config_get"), func = Marshal.GetFunctionPointerForDelegate(efl_config_get_static_delegate)});
      if (efl_config_set_static_delegate == null)
      efl_config_set_static_delegate = new efl_config_set_delegate(config_set);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_config_set"), func = Marshal.GetFunctionPointerForDelegate(efl_config_set_static_delegate)});
      return descs;
   }
   public override IntPtr GetEflClass()
   {
      return Efl.ConfigConcrete.efl_config_interface_get();
   }
   public static  IntPtr GetEflClassStatic()
   {
      return Efl.ConfigConcrete.efl_config_interface_get();
   }


    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Eina.ValueMarshalerOwn))] private delegate  Eina.Value efl_config_get_delegate(System.IntPtr obj, System.IntPtr pd,  [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))]   System.String name);


    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Eina.ValueMarshalerOwn))] public delegate  Eina.Value efl_config_get_api_delegate(System.IntPtr obj,  [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))]   System.String name);
    public static Efl.Eo.FunctionWrapper<efl_config_get_api_delegate> efl_config_get_ptr = new Efl.Eo.FunctionWrapper<efl_config_get_api_delegate>(_Module, "efl_config_get");
    private static  Eina.Value config_get(System.IntPtr obj, System.IntPtr pd,   System.String name)
   {
      Eina.Log.Debug("function efl_config_get was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                     Eina.Value _ret_var = default( Eina.Value);
         try {
            _ret_var = ((Config)wrapper).GetConfig( name);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                  return _ret_var;
      } else {
         return efl_config_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  name);
      }
   }
   private static efl_config_get_delegate efl_config_get_static_delegate;


    [return: MarshalAs(UnmanagedType.U1)] private delegate bool efl_config_set_delegate(System.IntPtr obj, System.IntPtr pd,  [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))]   System.String name,  [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Eina.ValueMarshaler))]   Eina.Value value);


    [return: MarshalAs(UnmanagedType.U1)] public delegate bool efl_config_set_api_delegate(System.IntPtr obj,  [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))]   System.String name,  [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Eina.ValueMarshaler))]   Eina.Value value);
    public static Efl.Eo.FunctionWrapper<efl_config_set_api_delegate> efl_config_set_ptr = new Efl.Eo.FunctionWrapper<efl_config_set_api_delegate>(_Module, "efl_config_set");
    private static bool config_set(System.IntPtr obj, System.IntPtr pd,   System.String name,   Eina.Value value)
   {
      Eina.Log.Debug("function efl_config_set was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                                      bool _ret_var = default(bool);
         try {
            _ret_var = ((Config)wrapper).SetConfig( name,  value);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                              return _ret_var;
      } else {
         return efl_config_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  name,  value);
      }
   }
   private static efl_config_set_delegate efl_config_set_static_delegate;
}
} 
