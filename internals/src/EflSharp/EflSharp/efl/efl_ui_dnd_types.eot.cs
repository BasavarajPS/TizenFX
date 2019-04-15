#pragma warning disable CS1591
using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
namespace Efl { namespace Dnd { 
/// <summary></summary>
/// <param name="win">The window to create the objects relative to</param>
/// <param name="drag_obj">The drag object</param>
/// <param name="off">Offset from the icon position to the cursor</param>
/// <returns></returns>
public delegate Efl.Canvas.Object DragIconCreate( Efl.Canvas.Object win,  Efl.Canvas.Object drag_obj,  out Eina.Position2D off);
[return:MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Canvas.Object, Efl.Eo.NonOwnTag>))]public delegate Efl.Canvas.Object DragIconCreateInternal(IntPtr data, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Canvas.Object, Efl.Eo.NonOwnTag>))]  Efl.Canvas.Object win, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Canvas.Object, Efl.Eo.NonOwnTag>))]  Efl.Canvas.Object drag_obj,   out Eina.Position2D.NativeStruct off);
internal class DragIconCreateWrapper
{

    private DragIconCreateInternal _cb;
    private IntPtr _cb_data;
    private EinaFreeCb _cb_free_cb;

    internal DragIconCreateWrapper (DragIconCreateInternal _cb, IntPtr _cb_data, EinaFreeCb _cb_free_cb)
    {
        this._cb = _cb;
        this._cb_data = _cb_data;
        this._cb_free_cb = _cb_free_cb;
    }

    ~DragIconCreateWrapper()
    {
        if (this._cb_free_cb != null)
            this._cb_free_cb(this._cb_data);
    }

    internal Efl.Canvas.Object ManagedCb( Efl.Canvas.Object win, Efl.Canvas.Object drag_obj, out Eina.Position2D off)
    {
                                                var _out_off = new Eina.Position2D.NativeStruct();
                                var _ret_var = _cb(_cb_data,  win,  drag_obj,  out _out_off);
        Eina.Error.RaiseIfUnhandledException();
                        off = _out_off;
                                return _ret_var;
    }

    [return:MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Canvas.Object, Efl.Eo.NonOwnTag>))]    internal static Efl.Canvas.Object Cb(IntPtr cb_data, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Canvas.Object, Efl.Eo.NonOwnTag>))]  Efl.Canvas.Object win, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Canvas.Object, Efl.Eo.NonOwnTag>))]  Efl.Canvas.Object drag_obj,   out Eina.Position2D.NativeStruct off)
    {
        GCHandle handle = GCHandle.FromIntPtr(cb_data);
        DragIconCreate cb = (DragIconCreate)handle.Target;
                                                Eina.Position2D _out_off = default(Eina.Position2D);
                                    Efl.Canvas.Object _ret_var = default(Efl.Canvas.Object);
        try {
            _ret_var = cb( win,  drag_obj,  out _out_off);
        } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
        }
                        off = _out_off;
                                return _ret_var;
    }
}
} } 
namespace Efl { namespace Dnd { 
/// <summary></summary>
/// <param name="obj">The container object</param>
/// <param name="format">Data format</param>
/// <param name="drag_data">Data</param>
/// <param name="action">The drag action</param>
/// <returns></returns>
public delegate void DragDataGet( Efl.Canvas.Object obj,  out Efl.Ui.SelectionFormat format,  ref Eina.RwSlice drag_data,  out Efl.Ui.SelectionAction action);
public delegate void DragDataGetInternal(IntPtr data, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Canvas.Object, Efl.Eo.NonOwnTag>))]  Efl.Canvas.Object obj,   out Efl.Ui.SelectionFormat format,   ref Eina.RwSlice drag_data,   out Efl.Ui.SelectionAction action);
internal class DragDataGetWrapper
{

    private DragDataGetInternal _cb;
    private IntPtr _cb_data;
    private EinaFreeCb _cb_free_cb;

    internal DragDataGetWrapper (DragDataGetInternal _cb, IntPtr _cb_data, EinaFreeCb _cb_free_cb)
    {
        this._cb = _cb;
        this._cb_data = _cb_data;
        this._cb_free_cb = _cb_free_cb;
    }

    ~DragDataGetWrapper()
    {
        if (this._cb_free_cb != null)
            this._cb_free_cb(this._cb_data);
    }

    internal void ManagedCb( Efl.Canvas.Object obj, out Efl.Ui.SelectionFormat format, ref Eina.RwSlice drag_data, out Efl.Ui.SelectionAction action)
    {
                                                                                                        _cb(_cb_data,  obj,  out format,  ref drag_data,  out action);
        Eina.Error.RaiseIfUnhandledException();
                                                                            }

        internal static void Cb(IntPtr cb_data, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Canvas.Object, Efl.Eo.NonOwnTag>))]  Efl.Canvas.Object obj,   out Efl.Ui.SelectionFormat format,   ref Eina.RwSlice drag_data,   out Efl.Ui.SelectionAction action)
    {
        GCHandle handle = GCHandle.FromIntPtr(cb_data);
        DragDataGet cb = (DragDataGet)handle.Target;
                                                format = default(Efl.Ui.SelectionFormat);        drag_data = default(Eina.RwSlice);        action = default(Efl.Ui.SelectionAction);                                            
        try {
            cb( obj,  out format,  ref drag_data,  out action);
        } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
        }
                                                                            }
}
} } 
namespace Efl { namespace Dnd { 
/// <summary></summary>
/// <param name="obj">The container object</param>
/// <param name="pos">The coordinates to get item</param>
/// <param name="posret">position relative to item (left (-1), middle (0), right (1)</param>
/// <returns></returns>
public delegate Efl.Object ItemGet( Efl.Canvas.Object obj,  Eina.Position2D pos,  out Eina.Position2D posret);
[return:MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Object, Efl.Eo.NonOwnTag>))]public delegate Efl.Object ItemGetInternal(IntPtr data, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Canvas.Object, Efl.Eo.NonOwnTag>))]  Efl.Canvas.Object obj,   Eina.Position2D.NativeStruct pos,   out Eina.Position2D.NativeStruct posret);
internal class ItemGetWrapper
{

    private ItemGetInternal _cb;
    private IntPtr _cb_data;
    private EinaFreeCb _cb_free_cb;

    internal ItemGetWrapper (ItemGetInternal _cb, IntPtr _cb_data, EinaFreeCb _cb_free_cb)
    {
        this._cb = _cb;
        this._cb_data = _cb_data;
        this._cb_free_cb = _cb_free_cb;
    }

    ~ItemGetWrapper()
    {
        if (this._cb_free_cb != null)
            this._cb_free_cb(this._cb_data);
    }

    internal Efl.Object ManagedCb( Efl.Canvas.Object obj, Eina.Position2D pos, out Eina.Position2D posret)
    {
                Eina.Position2D.NativeStruct _in_pos = pos;
                                var _out_posret = new Eina.Position2D.NativeStruct();
                                var _ret_var = _cb(_cb_data,  obj,  _in_pos,  out _out_posret);
        Eina.Error.RaiseIfUnhandledException();
                        posret = _out_posret;
                                return _ret_var;
    }

    [return:MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Object, Efl.Eo.NonOwnTag>))]    internal static Efl.Object Cb(IntPtr cb_data, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Canvas.Object, Efl.Eo.NonOwnTag>))]  Efl.Canvas.Object obj,   Eina.Position2D.NativeStruct pos,   out Eina.Position2D.NativeStruct posret)
    {
        GCHandle handle = GCHandle.FromIntPtr(cb_data);
        ItemGet cb = (ItemGet)handle.Target;
                Eina.Position2D _in_pos = pos;
                                Eina.Position2D _out_posret = default(Eina.Position2D);
                                    Efl.Object _ret_var = default(Efl.Object);
        try {
            _ret_var = cb( obj,  _in_pos,  out _out_posret);
        } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
        }
                        posret = _out_posret;
                                return _ret_var;
    }
}
} } 
namespace Efl { namespace Dnd { 
/// <summary></summary>
/// <param name="obj">The container object</param>
/// <returns></returns>
public delegate Eina.List<Efl.Canvas.Object> DragIconListCreate( Efl.Canvas.Object obj);
public delegate System.IntPtr DragIconListCreateInternal(IntPtr data, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Canvas.Object, Efl.Eo.NonOwnTag>))]  Efl.Canvas.Object obj);
internal class DragIconListCreateWrapper
{

    private DragIconListCreateInternal _cb;
    private IntPtr _cb_data;
    private EinaFreeCb _cb_free_cb;

    internal DragIconListCreateWrapper (DragIconListCreateInternal _cb, IntPtr _cb_data, EinaFreeCb _cb_free_cb)
    {
        this._cb = _cb;
        this._cb_data = _cb_data;
        this._cb_free_cb = _cb_free_cb;
    }

    ~DragIconListCreateWrapper()
    {
        if (this._cb_free_cb != null)
            this._cb_free_cb(this._cb_data);
    }

    internal Eina.List<Efl.Canvas.Object> ManagedCb( Efl.Canvas.Object obj)
    {
                                var _ret_var = _cb(_cb_data,  obj);
        Eina.Error.RaiseIfUnhandledException();
                        return new Eina.List<Efl.Canvas.Object>(_ret_var, false, false);
    }

        internal static System.IntPtr Cb(IntPtr cb_data, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Canvas.Object, Efl.Eo.NonOwnTag>))]  Efl.Canvas.Object obj)
    {
        GCHandle handle = GCHandle.FromIntPtr(cb_data);
        DragIconListCreate cb = (DragIconListCreate)handle.Target;
                                    Eina.List<Efl.Canvas.Object> _ret_var = default(Eina.List<Efl.Canvas.Object>);
        try {
            _ret_var = cb( obj);
        } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
        }
                        return _ret_var.Handle;
    }
}
} } 
namespace Efl { namespace Dnd { 
/// <summary></summary>
[StructLayout(LayoutKind.Sequential)]
public struct DragAccept
{
    /// <summary></summary>
    public bool Accepted;
    ///<summary>Constructor for DragAccept.</summary>
    public DragAccept(
        bool Accepted=default(bool)    )
    {
        this.Accepted = Accepted;
    }

    public static implicit operator DragAccept(IntPtr ptr)
    {
        var tmp = (DragAccept.NativeStruct)Marshal.PtrToStructure(ptr, typeof(DragAccept.NativeStruct));
        return tmp;
    }

    ///<summary>Internal wrapper for struct DragAccept.</summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct NativeStruct
    {
        ///<summary>Internal wrapper for field Accepted</summary>
        public System.Byte Accepted;
        ///<summary>Implicit conversion to the internal/marshalling representation.</summary>
        public static implicit operator DragAccept.NativeStruct(DragAccept _external_struct)
        {
            var _internal_struct = new DragAccept.NativeStruct();
            _internal_struct.Accepted = _external_struct.Accepted ? (byte)1 : (byte)0;
            return _internal_struct;
        }

        ///<summary>Implicit conversion to the managed representation.</summary>
        public static implicit operator DragAccept(DragAccept.NativeStruct _internal_struct)
        {
            var _external_struct = new DragAccept();
            _external_struct.Accepted = _internal_struct.Accepted != 0;
            return _external_struct;
        }

    }

}

} } 
namespace Efl { namespace Dnd { 
/// <summary></summary>
[StructLayout(LayoutKind.Sequential)]
public struct DragPos
{
    /// <summary>Evas Coordinate</summary>
    public Eina.Position2D Pos;
    /// <summary>The drag action</summary>
    public Efl.Ui.SelectionAction Action;
    /// <summary>The drag format</summary>
    public Efl.Ui.SelectionFormat Format;
    /// <summary>The item object. It is only available for container object.</summary>
    public Efl.Canvas.Object Item;
    ///<summary>Constructor for DragPos.</summary>
    public DragPos(
        Eina.Position2D Pos=default(Eina.Position2D),
        Efl.Ui.SelectionAction Action=default(Efl.Ui.SelectionAction),
        Efl.Ui.SelectionFormat Format=default(Efl.Ui.SelectionFormat),
        Efl.Canvas.Object Item=default(Efl.Canvas.Object)    )
    {
        this.Pos = Pos;
        this.Action = Action;
        this.Format = Format;
        this.Item = Item;
    }

    public static implicit operator DragPos(IntPtr ptr)
    {
        var tmp = (DragPos.NativeStruct)Marshal.PtrToStructure(ptr, typeof(DragPos.NativeStruct));
        return tmp;
    }

    ///<summary>Internal wrapper for struct DragPos.</summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct NativeStruct
    {
        
        public Eina.Position2D.NativeStruct Pos;
        
        public Efl.Ui.SelectionAction Action;
        
        public Efl.Ui.SelectionFormat Format;
        ///<summary>Internal wrapper for field Item</summary>
        public System.IntPtr Item;
        ///<summary>Implicit conversion to the internal/marshalling representation.</summary>
        public static implicit operator DragPos.NativeStruct(DragPos _external_struct)
        {
            var _internal_struct = new DragPos.NativeStruct();
            _internal_struct.Pos = _external_struct.Pos;
            _internal_struct.Action = _external_struct.Action;
            _internal_struct.Format = _external_struct.Format;
            _internal_struct.Item = _external_struct.Item?.NativeHandle ?? System.IntPtr.Zero;
            return _internal_struct;
        }

        ///<summary>Implicit conversion to the managed representation.</summary>
        public static implicit operator DragPos(DragPos.NativeStruct _internal_struct)
        {
            var _external_struct = new DragPos();
            _external_struct.Pos = _internal_struct.Pos;
            _external_struct.Action = _internal_struct.Action;
            _external_struct.Format = _internal_struct.Format;

            _external_struct.Item = (Efl.Canvas.Object) Efl.Eo.Globals.CreateWrapperFor(_internal_struct.Item);
            return _external_struct;
        }

    }

}

} } 
namespace Efl { namespace Dnd { 
/// <summary></summary>
[StructLayout(LayoutKind.Sequential)]
public struct DragItemContainerDrop
{
    /// <summary>The item object</summary>
    public Efl.Canvas.Object Item;
    /// <summary>The selection data</summary>
    public Efl.Ui.SelectionData Data;
    /// <summary>Position relative to item (left (-1), middle (0), right (1)</summary>
    public Eina.Position2D Pos;
    ///<summary>Constructor for DragItemContainerDrop.</summary>
    public DragItemContainerDrop(
        Efl.Canvas.Object Item=default(Efl.Canvas.Object),
        Efl.Ui.SelectionData Data=default(Efl.Ui.SelectionData),
        Eina.Position2D Pos=default(Eina.Position2D)    )
    {
        this.Item = Item;
        this.Data = Data;
        this.Pos = Pos;
    }

    public static implicit operator DragItemContainerDrop(IntPtr ptr)
    {
        var tmp = (DragItemContainerDrop.NativeStruct)Marshal.PtrToStructure(ptr, typeof(DragItemContainerDrop.NativeStruct));
        return tmp;
    }

    ///<summary>Internal wrapper for struct DragItemContainerDrop.</summary>
    [StructLayout(LayoutKind.Sequential)]
    public struct NativeStruct
    {
        ///<summary>Internal wrapper for field Item</summary>
        public System.IntPtr Item;
        
        public Efl.Ui.SelectionData.NativeStruct Data;
        
        public Eina.Position2D.NativeStruct Pos;
        ///<summary>Implicit conversion to the internal/marshalling representation.</summary>
        public static implicit operator DragItemContainerDrop.NativeStruct(DragItemContainerDrop _external_struct)
        {
            var _internal_struct = new DragItemContainerDrop.NativeStruct();
            _internal_struct.Item = _external_struct.Item?.NativeHandle ?? System.IntPtr.Zero;
            _internal_struct.Data = _external_struct.Data;
            _internal_struct.Pos = _external_struct.Pos;
            return _internal_struct;
        }

        ///<summary>Implicit conversion to the managed representation.</summary>
        public static implicit operator DragItemContainerDrop(DragItemContainerDrop.NativeStruct _internal_struct)
        {
            var _external_struct = new DragItemContainerDrop();

            _external_struct.Item = (Efl.Canvas.Object) Efl.Eo.Globals.CreateWrapperFor(_internal_struct.Item);
            _external_struct.Data = _internal_struct.Data;
            _external_struct.Pos = _internal_struct.Pos;
            return _external_struct;
        }

    }

}

} } 
