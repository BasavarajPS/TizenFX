#pragma warning disable CS1591
using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
namespace Efl { namespace Ui { 
/// <summary>Textpath widget</summary>
[TextpathLegacyNativeInherit]
public class TextpathLegacy : Efl.Ui.Textpath, Efl.Eo.IWrapper,Efl.Ui.Legacy
{
   public new static System.IntPtr klass = System.IntPtr.Zero;
   public new static Efl.Ui.TextpathLegacyNativeInherit nativeInherit = new Efl.Ui.TextpathLegacyNativeInherit();
   ///<summary>Pointer to the native class description.</summary>
   public override System.IntPtr NativeClass {
      get {
         if (((object)this).GetType() == typeof (TextpathLegacy))
            return Efl.Ui.TextpathLegacyNativeInherit.GetEflClassStatic();
         else
            return Efl.Eo.ClassRegister.klassFromType[((object)this).GetType()];
      }
   }
   [System.Runtime.InteropServices.DllImport(efl.Libs.Elementary)] internal static extern System.IntPtr
      efl_ui_textpath_legacy_class_get();
   ///<summary>Creates a new instance.</summary>
   ///<param name="parent">Parent instance.</param>
   ///<param name="style">The widget style to use. See <see cref="Efl.Ui.Widget.SetStyle"/></param>
   public TextpathLegacy(Efl.Object parent
         ,  System.String style = null) :
      base(efl_ui_textpath_legacy_class_get(), typeof(TextpathLegacy), parent)
   {
      if (Efl.Eo.Globals.ParamHelperCheck(style))
         SetStyle(Efl.Eo.Globals.GetParamHelper(style));
      FinishInstantiation();
   }
   ///<summary>Internal usage: Constructs an instance from a native pointer. This is used when interacting with C code and should not be used directly.</summary>
   public TextpathLegacy(System.IntPtr raw) : base(raw)
   {
            register_event_proxies();
   }
   ///<summary>Internal usage: Constructor to forward the wrapper initialization to the root class that interfaces with native code. Should not be used directly.</summary>
   protected TextpathLegacy(IntPtr base_klass, System.Type managed_type, Efl.Object parent) : base(base_klass, managed_type, parent) {}
   ///<summary>Casts obj into an instance of this type.</summary>
   public new static TextpathLegacy static_cast(Efl.Object obj)
   {
      if (obj == null)
         throw new System.ArgumentNullException("obj");
      return new TextpathLegacy(obj.NativeHandle);
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
   protected override void register_event_proxies()
   {
      base.register_event_proxies();
   }
   private static new  IntPtr GetEflClassStatic()
   {
      return Efl.Ui.TextpathLegacy.efl_ui_textpath_legacy_class_get();
   }
}
public class TextpathLegacyNativeInherit : Efl.Ui.TextpathNativeInherit{
   public new  static Efl.Eo.NativeModule _Module = new Efl.Eo.NativeModule(efl.Libs.Elementary);
   public override System.Collections.Generic.List<Efl_Op_Description> GetEoOps(System.Type type)
   {
      var descs = new System.Collections.Generic.List<Efl_Op_Description>();
      descs.AddRange(base.GetEoOps(type));
      return descs;
   }
   public override IntPtr GetEflClass()
   {
      return Efl.Ui.TextpathLegacy.efl_ui_textpath_legacy_class_get();
   }
   public static new  IntPtr GetEflClassStatic()
   {
      return Efl.Ui.TextpathLegacy.efl_ui_textpath_legacy_class_get();
   }
}
} } 
