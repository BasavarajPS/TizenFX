#pragma warning disable CS1591
using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
namespace Efl { namespace Ui { 
/// <summary>The bg (background) widget is used for setting (solid) background decorations
/// in a window (unless it has transparency enabled) or on any container object. It works just like an image but has some properties useful for backgrounds, such as setting it to tiled, centered, scaled or stretched.</summary>
[LegacyNativeInherit]
public interface Legacy : 
   Efl.Eo.IWrapper, IDisposable
{
}
/// <summary>The bg (background) widget is used for setting (solid) background decorations
/// in a window (unless it has transparency enabled) or on any container object. It works just like an image but has some properties useful for backgrounds, such as setting it to tiled, centered, scaled or stretched.</summary>
sealed public class LegacyConcrete : 

Legacy
   
{
   ///<summary>Pointer to the native class description.</summary>
   public System.IntPtr NativeClass {
      get {
         if (((object)this).GetType() == typeof (LegacyConcrete))
            return Efl.Ui.LegacyNativeInherit.GetEflClassStatic();
         else
            return Efl.Eo.ClassRegister.klassFromType[((object)this).GetType()];
      }
   }
   private  System.IntPtr handle;
   ///<summary>Pointer to the native instance.</summary>
   public System.IntPtr NativeHandle {
      get { return handle; }
   }
   [System.Runtime.InteropServices.DllImport(efl.Libs.Elementary)] internal static extern System.IntPtr
      efl_ui_legacy_interface_get();
   ///<summary>Internal usage: Constructs an instance from a native pointer. This is used when interacting with C code and should not be used directly.</summary>
   public LegacyConcrete(System.IntPtr raw)
   {
      handle = raw;
      register_event_proxies();
   }
   ///<summary>Destructor.</summary>
   ~LegacyConcrete()
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
   public static LegacyConcrete static_cast(Efl.Object obj)
   {
      if (obj == null)
         throw new System.ArgumentNullException("obj");
      return new LegacyConcrete(obj.NativeHandle);
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
}
public class LegacyNativeInherit  : Efl.Eo.NativeClass{
   public  static Efl.Eo.NativeModule _Module = new Efl.Eo.NativeModule(efl.Libs.Elementary);
   public override System.Collections.Generic.List<Efl_Op_Description> GetEoOps(System.Type type)
   {
      var descs = new System.Collections.Generic.List<Efl_Op_Description>();
      return descs;
   }
   public override IntPtr GetEflClass()
   {
      return Efl.Ui.LegacyConcrete.efl_ui_legacy_interface_get();
   }
   public static  IntPtr GetEflClassStatic()
   {
      return Efl.Ui.LegacyConcrete.efl_ui_legacy_interface_get();
   }
}
} } 
