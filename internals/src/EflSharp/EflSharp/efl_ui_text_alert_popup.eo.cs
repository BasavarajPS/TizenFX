#pragma warning disable CS1591
using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
namespace Efl { namespace Ui { 
/// <summary>EFL UI Text Alert Popup class</summary>
[TextAlertPopupNativeInherit]
public class TextAlertPopup : Efl.Ui.AlertPopup, Efl.Eo.IWrapper,Efl.Text
{
   public new static System.IntPtr klass = System.IntPtr.Zero;
   public new static Efl.Ui.TextAlertPopupNativeInherit nativeInherit = new Efl.Ui.TextAlertPopupNativeInherit();
   ///<summary>Pointer to the native class description.</summary>
   public override System.IntPtr NativeClass {
      get {
         if (((object)this).GetType() == typeof (TextAlertPopup))
            return Efl.Ui.TextAlertPopupNativeInherit.GetEflClassStatic();
         else
            return Efl.Eo.ClassRegister.klassFromType[((object)this).GetType()];
      }
   }
   [System.Runtime.InteropServices.DllImport(efl.Libs.Elementary)] internal static extern System.IntPtr
      efl_ui_text_alert_popup_class_get();
   ///<summary>Creates a new instance.</summary>
   ///<param name="parent">Parent instance.</param>
   ///<param name="style">The widget style to use. See <see cref="Efl.Ui.Widget.SetStyle"/></param>
   public TextAlertPopup(Efl.Object parent
         ,  System.String style = null) :
      base(efl_ui_text_alert_popup_class_get(), typeof(TextAlertPopup), parent)
   {
      if (Efl.Eo.Globals.ParamHelperCheck(style))
         SetStyle(Efl.Eo.Globals.GetParamHelper(style));
      FinishInstantiation();
   }
   ///<summary>Internal usage: Constructs an instance from a native pointer. This is used when interacting with C code and should not be used directly.</summary>
   public TextAlertPopup(System.IntPtr raw) : base(raw)
   {
            register_event_proxies();
   }
   ///<summary>Internal usage: Constructor to forward the wrapper initialization to the root class that interfaces with native code. Should not be used directly.</summary>
   protected TextAlertPopup(IntPtr base_klass, System.Type managed_type, Efl.Object parent) : base(base_klass, managed_type, parent) {}
   ///<summary>Casts obj into an instance of this type.</summary>
   public new static TextAlertPopup static_cast(Efl.Object obj)
   {
      if (obj == null)
         throw new System.ArgumentNullException("obj");
      return new TextAlertPopup(obj.NativeHandle);
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
   /// <summary>Set the expandable of popup.
   /// If the contents of the popup has min size, the popup will be increased by min size along the Y axis. If max hint is set it will be increased to the value of max hint and scrolling will occur.</summary>
   /// <param name="max_size">A 2D max size in pixel units.</param>
   /// <returns></returns>
   virtual public  void SetExpandable( Eina.Size2D max_size) {
       var _in_max_size = Eina.Size2D_StructConversion.ToInternal(max_size);
                  Efl.Ui.TextAlertPopupNativeInherit.efl_ui_text_alert_popup_expandable_set_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle), _in_max_size);
      Eina.Error.RaiseIfUnhandledException();
                   }
   /// <summary>Retrieves the text string currently being displayed by the given text object.
   /// Do not free() the return value.
   /// 
   /// See also <see cref="Efl.Text.GetText"/>.</summary>
   /// <returns>Text string to display on it.</returns>
   virtual public  System.String GetText() {
       var _ret_var = Efl.TextNativeInherit.efl_text_get_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle));
      Eina.Error.RaiseIfUnhandledException();
      return _ret_var;
 }
   /// <summary>Sets the text string to be displayed by the given text object.
   /// See also <see cref="Efl.Text.GetText"/>.</summary>
   /// <param name="text">Text string to display on it.</param>
   /// <returns></returns>
   virtual public  void SetText(  System.String text) {
                         Efl.TextNativeInherit.efl_text_set_ptr.Value.Delegate((inherited ? Efl.Eo.Globals.efl_super(this.NativeHandle, this.NativeClass) : this.NativeHandle), text);
      Eina.Error.RaiseIfUnhandledException();
                   }
   /// <summary>Set the expandable of popup.
/// If the contents of the popup has min size, the popup will be increased by min size along the Y axis. If max hint is set it will be increased to the value of max hint and scrolling will occur.</summary>
/// <value>A 2D max size in pixel units.</value>
   public Eina.Size2D Expandable {
      set { SetExpandable( value); }
   }
   private static new  IntPtr GetEflClassStatic()
   {
      return Efl.Ui.TextAlertPopup.efl_ui_text_alert_popup_class_get();
   }
}
public class TextAlertPopupNativeInherit : Efl.Ui.AlertPopupNativeInherit{
   public new  static Efl.Eo.NativeModule _Module = new Efl.Eo.NativeModule(efl.Libs.Elementary);
   public override System.Collections.Generic.List<Efl_Op_Description> GetEoOps(System.Type type)
   {
      var descs = new System.Collections.Generic.List<Efl_Op_Description>();
      if (efl_ui_text_alert_popup_expandable_set_static_delegate == null)
      efl_ui_text_alert_popup_expandable_set_static_delegate = new efl_ui_text_alert_popup_expandable_set_delegate(expandable_set);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_text_alert_popup_expandable_set"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_text_alert_popup_expandable_set_static_delegate)});
      if (efl_text_get_static_delegate == null)
      efl_text_get_static_delegate = new efl_text_get_delegate(text_get);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_text_get"), func = Marshal.GetFunctionPointerForDelegate(efl_text_get_static_delegate)});
      if (efl_text_set_static_delegate == null)
      efl_text_set_static_delegate = new efl_text_set_delegate(text_set);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_text_set"), func = Marshal.GetFunctionPointerForDelegate(efl_text_set_static_delegate)});
      descs.AddRange(base.GetEoOps(type));
      return descs;
   }
   public override IntPtr GetEflClass()
   {
      return Efl.Ui.TextAlertPopup.efl_ui_text_alert_popup_class_get();
   }
   public static new  IntPtr GetEflClassStatic()
   {
      return Efl.Ui.TextAlertPopup.efl_ui_text_alert_popup_class_get();
   }


    private delegate  void efl_ui_text_alert_popup_expandable_set_delegate(System.IntPtr obj, System.IntPtr pd,   Eina.Size2D_StructInternal max_size);


    public delegate  void efl_ui_text_alert_popup_expandable_set_api_delegate(System.IntPtr obj,   Eina.Size2D_StructInternal max_size);
    public static Efl.Eo.FunctionWrapper<efl_ui_text_alert_popup_expandable_set_api_delegate> efl_ui_text_alert_popup_expandable_set_ptr = new Efl.Eo.FunctionWrapper<efl_ui_text_alert_popup_expandable_set_api_delegate>(_Module, "efl_ui_text_alert_popup_expandable_set");
    private static  void expandable_set(System.IntPtr obj, System.IntPtr pd,  Eina.Size2D_StructInternal max_size)
   {
      Eina.Log.Debug("function efl_ui_text_alert_popup_expandable_set was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
               var _in_max_size = Eina.Size2D_StructConversion.ToManaged(max_size);
                     
         try {
            ((TextAlertPopup)wrapper).SetExpandable( _in_max_size);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                        } else {
         efl_ui_text_alert_popup_expandable_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  max_size);
      }
   }
   private static efl_ui_text_alert_popup_expandable_set_delegate efl_ui_text_alert_popup_expandable_set_static_delegate;


    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))] private delegate  System.String efl_text_get_delegate(System.IntPtr obj, System.IntPtr pd);


    [return: MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))] public delegate  System.String efl_text_get_api_delegate(System.IntPtr obj);
    public static Efl.Eo.FunctionWrapper<efl_text_get_api_delegate> efl_text_get_ptr = new Efl.Eo.FunctionWrapper<efl_text_get_api_delegate>(_Module, "efl_text_get");
    private static  System.String text_get(System.IntPtr obj, System.IntPtr pd)
   {
      Eina.Log.Debug("function efl_text_get was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                   System.String _ret_var = default( System.String);
         try {
            _ret_var = ((TextAlertPopup)wrapper).GetText();
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
      return _ret_var;
      } else {
         return efl_text_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
      }
   }
   private static efl_text_get_delegate efl_text_get_static_delegate;


    private delegate  void efl_text_set_delegate(System.IntPtr obj, System.IntPtr pd,  [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))]   System.String text);


    public delegate  void efl_text_set_api_delegate(System.IntPtr obj,  [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.StringKeepOwnershipMarshaler))]   System.String text);
    public static Efl.Eo.FunctionWrapper<efl_text_set_api_delegate> efl_text_set_ptr = new Efl.Eo.FunctionWrapper<efl_text_set_api_delegate>(_Module, "efl_text_set");
    private static  void text_set(System.IntPtr obj, System.IntPtr pd,   System.String text)
   {
      Eina.Log.Debug("function efl_text_set was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                    
         try {
            ((TextAlertPopup)wrapper).SetText( text);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                        } else {
         efl_text_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  text);
      }
   }
   private static efl_text_set_delegate efl_text_set_static_delegate;
}
} } 
