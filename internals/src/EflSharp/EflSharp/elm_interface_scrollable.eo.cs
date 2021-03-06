#pragma warning disable CS1591
using System;
using System.Runtime.InteropServices;
using System.Collections.Generic;
using System.Linq;
using System.ComponentModel;
namespace Elm { 
/// <summary>Elm scrollable mixin</summary>
[InterfaceScrollableNativeInherit]
public interface InterfaceScrollable : 
   Efl.Ui.Scrollable ,
   Efl.Ui.WidgetFocusManager ,
   Efl.Ui.Focus.ManagerSub ,
   Efl.Eo.IWrapper, IDisposable
{
   /// <summary>Control scrolling gravity on the scrollable
/// The gravity defines how the scroller will adjust its view when the size of the scroller contents increases.
/// 
/// The scroller will adjust the view to glue itself as follows.
/// 
/// x=0.0, for staying where it is relative to the left edge of the content x=1.0, for staying where it is relative to the right edge of the content y=0.0, for staying where it is relative to the top edge of the content y=1.0, for staying where it is relative to the bottom edge of the content
/// 
/// Default values for x and y are 0.0</summary>
/// <param name="x">Horizontal scrolling gravity</param>
/// <param name="y">Vertical scrolling gravity</param>
/// <returns></returns>
 void GetGravity( out double x,  out double y);
   /// <summary>Control scrolling gravity on the scrollable
/// The gravity defines how the scroller will adjust its view when the size of the scroller contents increases.
/// 
/// The scroller will adjust the view to glue itself as follows.
/// 
/// x=0.0, for staying where it is relative to the left edge of the content x=1.0, for staying where it is relative to the right edge of the content y=0.0, for staying where it is relative to the top edge of the content y=1.0, for staying where it is relative to the bottom edge of the content
/// 
/// Default values for x and y are 0.0</summary>
/// <param name="x">Horizontal scrolling gravity</param>
/// <param name="y">Vertical scrolling gravity</param>
/// <returns></returns>
 void SetGravity( double x,  double y);
   /// <summary>Bouncing behavior
/// When scrolling, the scroller may &quot;bounce&quot; when reaching an edge of the content object. This is a visual way to indicate the end has been reached. This is enabled by default for both axis. This API will set if it is enabled for the given axis with the boolean parameters for each axis.</summary>
/// <param name="horiz">Horizontal bounce policy.</param>
/// <param name="vert">Vertical bounce policy.</param>
/// <returns></returns>
 void GetBounceAllow( out bool horiz,  out bool vert);
   /// <summary>Bouncing behavior
/// When scrolling, the scroller may &quot;bounce&quot; when reaching an edge of the content object. This is a visual way to indicate the end has been reached. This is enabled by default for both axis. This API will set if it is enabled for the given axis with the boolean parameters for each axis.</summary>
/// <param name="horiz">Horizontal bounce policy.</param>
/// <param name="vert">Vertical bounce policy.</param>
/// <returns></returns>
 void SetBounceAllow( bool horiz,  bool vert);
   /// <summary>Control Wheel disable Enable or disable mouse wheel to be used to scroll the scroller content. heel is enabled by default.</summary>
/// <returns><c>true</c> if wheel is disabled, <c>false</c> otherwise</returns>
bool GetWheelDisabled();
   /// <summary>Control Wheel disable Enable or disable mouse wheel to be used to scroll the scroller content. heel is enabled by default.</summary>
/// <param name="disabled"><c>true</c> if wheel is disabled, <c>false</c> otherwise</param>
/// <returns></returns>
 void SetWheelDisabled( bool disabled);
   /// <summary>Blocking of scrolling (per axis)
/// This function will block scrolling movement (by input of a user) in a given direction. One can disable movements in the X axis, the Y axis or both. The default value is <c>none</c>, where movements are allowed in both directions.
/// 
/// What makes this function different from freeze_push(), hold_push() and lock_x_set() (or lock_y_set()) is that it doesn&apos;t propagate its effects to any parent or child widget of <c>obj</c>. Only the target scrollable widget will be locked with regard to scrolling.</summary>
/// <returns>Which axis (or axes) to block</returns>
Efl.Ui.ScrollBlock GetMovementBlock();
   /// <summary>Blocking of scrolling (per axis)
/// This function will block scrolling movement (by input of a user) in a given direction. One can disable movements in the X axis, the Y axis or both. The default value is <c>none</c>, where movements are allowed in both directions.
/// 
/// What makes this function different from freeze_push(), hold_push() and lock_x_set() (or lock_y_set()) is that it doesn&apos;t propagate its effects to any parent or child widget of <c>obj</c>. Only the target scrollable widget will be locked with regard to scrolling.</summary>
/// <param name="block">Which axis (or axes) to block</param>
/// <returns></returns>
 void SetMovementBlock( Efl.Ui.ScrollBlock block);
   /// <summary>Momentum animator</summary>
/// <returns><c>true</c> if disabled, <c>false</c> otherwise</returns>
bool GetMomentumAnimatorDisabled();
   /// <summary>Momentum animator</summary>
/// <param name="disabled"><c>true</c> if disabled, <c>false</c> otherwise</param>
/// <returns></returns>
 void SetMomentumAnimatorDisabled( bool disabled);
   /// <summary>Scrollbar visibility policy
/// #ELM_SCROLLER_POLICY_AUTO means the scrollbar is made visible if it is needed, and otherwise kept hidden. #ELM_SCROLLER_POLICY_ON turns it on all the time, and #ELM_SCROLLER_POLICY_OFF always keeps it off. This applies respectively for the horizontal and vertical scrollbars.</summary>
/// <param name="hbar">Horizontal scrollbar policy</param>
/// <param name="vbar">Vertical scrollbar policy</param>
/// <returns></returns>
 void GetPolicy( out Elm.Scroller.Policy hbar,  out Elm.Scroller.Policy vbar);
   /// <summary>Scrollbar visibility policy
/// #ELM_SCROLLER_POLICY_AUTO means the scrollbar is made visible if it is needed, and otherwise kept hidden. #ELM_SCROLLER_POLICY_ON turns it on all the time, and #ELM_SCROLLER_POLICY_OFF always keeps it off. This applies respectively for the horizontal and vertical scrollbars.</summary>
/// <param name="hbar">Horizontal scrollbar policy</param>
/// <param name="vbar">Vertical scrollbar policy</param>
/// <returns></returns>
 void SetPolicy( Elm.Scroller.Policy hbar,  Elm.Scroller.Policy vbar);
   /// <summary>Currently visible content region
/// This gets the current region in the content object that is visible through the scroller. The region co-ordinates are returned in the <c>x</c>, <c>y</c>, <c>w</c>, <c>h</c> values pointed to.
/// 
/// Note: All coordinates are relative to the content.
/// 
/// See: <see cref="Elm.InterfaceScrollable.ShowContentRegion"/>.</summary>
/// <param name="x">X coordinate of the region</param>
/// <param name="y">Y coordinate of the region</param>
/// <param name="w">Width of the region</param>
/// <param name="h">Height of the region</param>
/// <returns></returns>
 void GetContentRegion( out  int x,  out  int y,  out  int w,  out  int h);
   /// <summary>Currently visible content region
/// This gets the current region in the content object that is visible through the scroller. The region co-ordinates are returned in the <c>x</c>, <c>y</c>, <c>w</c>, <c>h</c> values pointed to.
/// 
/// Note: All coordinates are relative to the content.
/// 
/// See: <see cref="Elm.InterfaceScrollable.ShowContentRegion"/>.</summary>
/// <param name="x">X coordinate of the region</param>
/// <param name="y">Y coordinate of the region</param>
/// <param name="w">Width of the region</param>
/// <param name="h">Height of the region</param>
/// <returns></returns>
 void SetContentRegion(  int x,   int y,   int w,   int h);
   /// <summary>It decides whether the scrollable object propagates the events to content object or not.</summary>
/// <returns><c>true</c> if events are propagated, <c>false</c> otherwise</returns>
bool GetContentEvents();
   /// <summary>It decides whether the scrollable object propagates the events to content object or not.</summary>
/// <param name="repeat_events"><c>true</c> if events are propagated, <c>false</c> otherwise</param>
/// <returns></returns>
 void SetContentEvents( bool repeat_events);
   /// <summary>Scroll page size relative to viewport size.
/// The scroller is capable of limiting scrolling by the user to &quot;pages&quot;. That is to jump by and only show a &quot;whole page&quot; at a time as if the continuous area of the scroller content is split into page sized pieces. This sets the size of a page relative to the viewport of the scroller. 1.0 is &quot;1 viewport&quot; is size (horizontally or vertically). 0.0 turns it off in that axis. This is mutually exclusive with page size (see <see cref="Elm.InterfaceScrollable.GetPageSize"/> for more information). Likewise 0.5 is &quot;half a viewport&quot;. Sane usable values are normally between 0.0 and 1.0 including 1.0. If you only want 1 axis to be page &quot;limited&quot;, use 0.0 for the other axis.</summary>
/// <param name="x">The horizontal page relative size</param>
/// <param name="y">The vertical page relative size</param>
/// <returns></returns>
 void GetPageSize( out  int x,  out  int y);
   /// <summary>Scroll page size relative to viewport size.
/// The scroller is capable of limiting scrolling by the user to &quot;pages&quot;. That is to jump by and only show a &quot;whole page&quot; at a time as if the continuous area of the scroller content is split into page sized pieces. This sets the size of a page relative to the viewport of the scroller. 1.0 is &quot;1 viewport&quot; is size (horizontally or vertically). 0.0 turns it off in that axis. This is mutually exclusive with page size (see <see cref="Elm.InterfaceScrollable.GetPageSize"/> for more information). Likewise 0.5 is &quot;half a viewport&quot;. Sane usable values are normally between 0.0 and 1.0 including 1.0. If you only want 1 axis to be page &quot;limited&quot;, use 0.0 for the other axis.</summary>
/// <param name="x">The horizontal page relative size</param>
/// <param name="y">The vertical page relative size</param>
/// <returns></returns>
 void SetPageSize(  int x,   int y);
   /// <summary>Bounce animator</summary>
/// <returns><c>true</c> if bounce animation is disabled, <c>false</c> otherwise</returns>
bool GetBounceAnimatorDisabled();
   /// <summary>Bounce animator</summary>
/// <param name="disabled"><c>true</c> if bounce animation is disabled, <c>false</c> otherwise</param>
/// <returns></returns>
 void SetBounceAnimatorDisabled( bool disabled);
   /// <summary>Page scroll limit</summary>
/// <param name="page_limit_h">Page limit horizontal</param>
/// <param name="page_limit_v">Page limit vertical</param>
/// <returns></returns>
 void GetPageScrollLimit( out  int page_limit_h,  out  int page_limit_v);
   /// <summary>Page scroll limit</summary>
/// <param name="page_limit_h">Page limit horizontal</param>
/// <param name="page_limit_v">Page limit vertical</param>
/// <returns></returns>
 void SetPageScrollLimit(  int page_limit_h,   int page_limit_v);
   /// <summary>Page snapping behavior
/// When scrolling, if a scroller is paged (see elm_scroller_page_size_set() and elm_scroller_page_relative_set()), the scroller may snap to pages when being scrolled, i.e., even if it had momentum to scroll further, it will stop at the next page boundaries. This is disabled, by default, for both axis. This function will set if it that is enabled or not, for each axis.
/// 
/// Note: If <c>obj</c> is not set to have pages, nothing will happen after this call.
/// 1.8</summary>
/// <param name="horiz">Allow snap horizontally</param>
/// <param name="vert">Allow snap vertically</param>
/// <returns></returns>
 void GetPageSnapAllow( out bool horiz,  out bool vert);
   /// <summary>Page snapping behavior
/// When scrolling, if a scroller is paged (see elm_scroller_page_size_set() and elm_scroller_page_relative_set()), the scroller may snap to pages when being scrolled, i.e., even if it had momentum to scroll further, it will stop at the next page boundaries. This is disabled, by default, for both axis. This function will set if it that is enabled or not, for each axis.
/// 
/// Note: If <c>obj</c> is not set to have pages, nothing will happen after this call.
/// 1.8</summary>
/// <param name="horiz">Allow snap horizontally</param>
/// <param name="vert">Allow snap vertically</param>
/// <returns></returns>
 void SetPageSnapAllow( bool horiz,  bool vert);
   /// <summary>Pagin property</summary>
/// <param name="pagerel_h">Page relation horizontal</param>
/// <param name="pagerel_v">Page relation vertical</param>
/// <param name="pagesize_h">Page size horizontal</param>
/// <param name="pagesize_v">Page size vertical</param>
/// <returns></returns>
 void GetPaging( out double pagerel_h,  out double pagerel_v,  out  int pagesize_h,  out  int pagesize_v);
   /// <summary>Pagin property</summary>
/// <param name="pagerel_h">Page relation horizontal</param>
/// <param name="pagerel_v">Page relation vertical</param>
/// <param name="pagesize_h">Page size horizontal</param>
/// <param name="pagesize_v">Page size vertical</param>
/// <returns></returns>
 void SetPaging( double pagerel_h,  double pagerel_v,   int pagesize_h,   int pagesize_v);
   /// <summary>Single direction scroll configuration
/// This makes it possible to restrict scrolling to a single direction, with a &quot;soft&quot; or &quot;hard&quot; behavior.
/// 
/// The hard behavior restricts the scrolling to a single direction all of the time while the soft one will restrict depending on factors such as the movement angle. If the user scrolls roughly in one direction only, it will only move according to it while if the move was clearly wanted on both axes, it will happen on both of them.
/// 1.8</summary>
/// <returns>The single direction scroll policy</returns>
Elm.Scroller.SingleDirection GetSingleDirection();
   /// <summary>Single direction scroll configuration
/// This makes it possible to restrict scrolling to a single direction, with a &quot;soft&quot; or &quot;hard&quot; behavior.
/// 
/// The hard behavior restricts the scrolling to a single direction all of the time while the soft one will restrict depending on factors such as the movement angle. If the user scrolls roughly in one direction only, it will only move according to it while if the move was clearly wanted on both axes, it will happen on both of them.
/// 1.8</summary>
/// <param name="single_dir">The single direction scroll policy</param>
/// <returns></returns>
 void SetSingleDirection( Elm.Scroller.SingleDirection single_dir);
   /// <summary>Step size</summary>
/// <param name="x">X coordinate</param>
/// <param name="y">Y coordinate</param>
/// <returns></returns>
 void GetStepSize( out  int x,  out  int y);
   /// <summary>Step size</summary>
/// <param name="x">X coordinate</param>
/// <param name="y">Y coordinate</param>
/// <returns></returns>
 void SetStepSize(  int x,   int y);
   /// <summary>Controls an infinite loop for a scroller.
/// 1.14</summary>
/// <param name="loop_h">The scrolling horizontal loop</param>
/// <param name="loop_v">The scrolling vertical loop</param>
/// <returns></returns>
 void GetContentLoop( out bool loop_h,  out bool loop_v);
   /// <summary>Controls an infinite loop for a scroller.
/// 1.14</summary>
/// <param name="loop_h">The scrolling horizontal loop</param>
/// <param name="loop_v">The scrolling vertical loop</param>
/// <returns></returns>
 void SetContentLoop( bool loop_h,  bool loop_v);
   /// <summary>Set the callback to run when the content has been moved up.</summary>
/// <param name="scroll_up_cb">The callback</param>
/// <returns></returns>
 void SetScrollUpCb( ElmInterfaceScrollableCb scroll_up_cb);
   /// <summary>Set the callback to run when the horizontal scrollbar is dragged.</summary>
/// <param name="hbar_drag_cb">The callback</param>
/// <returns></returns>
 void SetHbarDragCb( ElmInterfaceScrollableCb hbar_drag_cb);
   /// <summary>Set the callback to run when dragging of the contents has started.</summary>
/// <param name="drag_start_cb">The callback</param>
/// <returns></returns>
 void SetDragStartCb( ElmInterfaceScrollableCb drag_start_cb);
   /// <summary>Set the callback to run when scrolling of the contents has started.</summary>
/// <param name="scroll_start_cb">The callback</param>
/// <returns></returns>
 void SetScrollStartCb( ElmInterfaceScrollableCb scroll_start_cb);
   /// <summary>Freeze property</summary>
/// <param name="freeze"><c>true</c> if freeze, <c>false</c> otherwise</param>
/// <returns></returns>
 void SetFreeze( bool freeze);
   /// <summary>When the viewport is resized, the callback is called.</summary>
/// <param name="viewport_resize_cb">The callback</param>
/// <returns></returns>
 void SetContentViewportResizeCb( ElmInterfaceScrollableResizeCb viewport_resize_cb);
   /// <summary>Set the callback to run when the content has been moved to the left</summary>
/// <param name="scroll_left_cb">The callback</param>
/// <returns></returns>
 void SetScrollLeftCb( ElmInterfaceScrollableCb scroll_left_cb);
   /// <summary>Set the callback to run when the vertical scrollbar is pressed.</summary>
/// <param name="vbar_press_cb">The callback</param>
/// <returns></returns>
 void SetVbarPressCb( ElmInterfaceScrollableCb vbar_press_cb);
   /// <summary>Set the callback to run when the horizontal scrollbar is pressed.</summary>
/// <param name="hbar_press_cb">The callback</param>
/// <returns></returns>
 void SetHbarPressCb( ElmInterfaceScrollableCb hbar_press_cb);
   /// <summary>Set the callback to run when the horizontal scrollbar is unpressed.</summary>
/// <param name="hbar_unpress_cb">The callback</param>
/// <returns></returns>
 void SetHbarUnpressCb( ElmInterfaceScrollableCb hbar_unpress_cb);
   /// <summary>Set the callback to run when dragging of the contents has stopped.</summary>
/// <param name="drag_stop_cb">The callback</param>
/// <returns></returns>
 void SetDragStopCb( ElmInterfaceScrollableCb drag_stop_cb);
   /// <summary>Set the callback to run when scrolling of the contents has stopped.</summary>
/// <param name="scroll_stop_cb">The callback</param>
/// <returns></returns>
 void SetScrollStopCb( ElmInterfaceScrollableCb scroll_stop_cb);
   /// <summary>Extern pan</summary>
/// <param name="pan">Pan object</param>
/// <returns></returns>
 void SetExternPan( Efl.Canvas.Object pan);
   /// <summary>Set the callback to run when the visible page changes.</summary>
/// <param name="page_change_cb">The callback</param>
/// <returns></returns>
 void SetPageChangeCb( ElmInterfaceScrollableCb page_change_cb);
   /// <summary>Hold property</summary>
/// <param name="hold"><c>true</c> if hold, <c>false</c> otherwise</param>
/// <returns></returns>
 void SetHold( bool hold);
   /// <summary>Set the callback to run when the scrolling animation has started.</summary>
/// <param name="animate_start_cb">The callback</param>
/// <returns></returns>
 void SetAnimateStartCb( ElmInterfaceScrollableCb animate_start_cb);
   /// <summary>Set the callback to run when the content has been moved down.</summary>
/// <param name="scroll_down_cb">The callback</param>
/// <returns></returns>
 void SetScrollDownCb( ElmInterfaceScrollableCb scroll_down_cb);
   /// <summary>Set scroll page size relative to viewport size.</summary>
/// <param name="h_pagerel">Page relation horizontal</param>
/// <param name="v_pagerel">Page relation vertical</param>
/// <returns></returns>
 void SetPageRelative( double h_pagerel,  double v_pagerel);
   /// <summary>Set the callback to run when the content has been moved.</summary>
/// <param name="scroll_cb">The callback</param>
/// <returns></returns>
 void SetScrollCb( ElmInterfaceScrollableCb scroll_cb);
   /// <summary>Set the callback to run when the scrolling animation has stopped.</summary>
/// <param name="animate_stop_cb">The callback</param>
/// <returns></returns>
 void SetAnimateStopCb( ElmInterfaceScrollableCb animate_stop_cb);
   /// <summary>set the callback to run on minimal limit content</summary>
/// <param name="min_limit_cb">The callback</param>
/// <returns></returns>
 void SetContentMinLimitCb( ElmInterfaceScrollableMinLimitCb min_limit_cb);
   /// <summary>Set the callback to run when the content has been moved to the right.</summary>
/// <param name="scroll_right_cb">The callback</param>
/// <returns></returns>
 void SetScrollRightCb( ElmInterfaceScrollableCb scroll_right_cb);
   /// <summary>Content property</summary>
/// <param name="content">Content object</param>
/// <returns></returns>
 void SetScrollableContent( Efl.Canvas.Object content);
   /// <summary>Set the callback to run when the left edge of the content has been reached.</summary>
/// <param name="edge_left_cb">The callback</param>
/// <returns></returns>
 void SetEdgeLeftCb( ElmInterfaceScrollableCb edge_left_cb);
   /// <summary>Set the callback to run when the horizontal scrollbar is dragged.</summary>
/// <param name="vbar_drag_cb">The callback</param>
/// <returns></returns>
 void SetVbarDragCb( ElmInterfaceScrollableCb vbar_drag_cb);
   /// <summary>Set the callback to run when the horizontal scrollbar is unpressed.</summary>
/// <param name="vbar_unpress_cb">The callback</param>
/// <returns></returns>
 void SetVbarUnpressCb( ElmInterfaceScrollableCb vbar_unpress_cb);
   /// <summary>Set the callback to run when the bottom edge of the content has been reached.</summary>
/// <param name="edge_bottom_cb">The callback</param>
/// <returns></returns>
 void SetEdgeBottomCb( ElmInterfaceScrollableCb edge_bottom_cb);
   /// <summary>Set the callback to run when the right edge of the content has been reached.</summary>
/// <param name="edge_right_cb">The callback</param>
/// <returns></returns>
 void SetEdgeRightCb( ElmInterfaceScrollableCb edge_right_cb);
   /// <summary>Set the callback to run when the top edge of the content has been reached.</summary>
/// <param name="edge_top_cb">The callback</param>
/// <returns></returns>
 void SetEdgeTopCb( ElmInterfaceScrollableCb edge_top_cb);
   /// <summary>Object property</summary>
/// <param name="edje_object">Edje object</param>
/// <param name="hit_rectangle">Evas object</param>
/// <returns></returns>
 void SetObjects( Efl.Canvas.Object edje_object,  Efl.Canvas.Object hit_rectangle);
   /// <summary>Get scroll last page number.
/// The page number starts from 0. 0 is the first page. This returns the last page number among the pages.
/// 
/// See: <see cref="Elm.InterfaceScrollable.GetCurrentPage"/>, <see cref="Elm.InterfaceScrollable.ShowPage"/> and <see cref="Elm.InterfaceScrollable.PageBringIn"/>.</summary>
/// <param name="pagenumber_h">The horizontal page number</param>
/// <param name="pagenumber_v">The vertical page number</param>
/// <returns></returns>
 void GetLastPage( out  int pagenumber_h,  out  int pagenumber_v);
   /// <summary>Get scroll current page number.
/// The page number starts from 0. 0 is the first page. Current page means the page which meets the top-left of the viewport. If there are two or more pages in the viewport, it returns the number of the page which meets the top-left of the viewport.
/// 
/// See: <see cref="Elm.InterfaceScrollable.GetLastPage"/>, <see cref="Elm.InterfaceScrollable.ShowPage"/> and <see cref="Elm.InterfaceScrollable.PageBringIn"/>.</summary>
/// <param name="pagenumber_h">The horizontal page number</param>
/// <param name="pagenumber_v">The vertical page number</param>
/// <returns></returns>
 void GetCurrentPage( out  int pagenumber_h,  out  int pagenumber_v);
   /// <summary>Content viewport geometry</summary>
/// <param name="x">X coordinate</param>
/// <param name="y">Y coordinate</param>
/// <param name="w">Width</param>
/// <param name="h">Height</param>
/// <returns></returns>
 void GetContentViewportGeometry( out  int x,  out  int y,  out  int w,  out  int h);
   /// <summary>Get the size of the content object
/// This gets the size of the content object of the scroller.</summary>
/// <param name="w">Width of the content object.</param>
/// <param name="h">Height of the content object.</param>
/// <returns></returns>
 void GetContentSize( out  int w,  out  int h);
   /// <summary>Whether scrolling should loop around.</summary>
/// <returns>True to enable looping.</returns>
bool GetItemLoopEnabled();
   /// <summary>Whether scrolling should loop around.</summary>
/// <param name="enable">True to enable looping.</param>
/// <returns></returns>
 void SetItemLoopEnabled( bool enable);
   /// <summary>Set the content position</summary>
/// <param name="x">X coordinate</param>
/// <param name="y">Y coordinate</param>
/// <param name="sig">Send signals to the theme corresponding to the scroll direction, or if an edge was reached.</param>
/// <returns></returns>
 void SetContentPos(  int x,   int y,  bool sig);
   /// <summary>Get content position</summary>
/// <param name="x">X coordinate</param>
/// <param name="y">Y coordinate</param>
/// <returns></returns>
 void GetContentPos( out  int x,  out  int y);
   /// <summary>Show a specific virtual region within the scroller content object by page number.
/// 0, 0 of the indicated page is located at the top-left of the viewport. This will jump to the page directly without animation.
/// 
/// See <see cref="Elm.InterfaceScrollable.PageBringIn"/>.</summary>
/// <param name="pagenumber_h">The horizontal page number</param>
/// <param name="pagenumber_v">The vertical page number</param>
/// <returns></returns>
 void ShowPage(  int pagenumber_h,   int pagenumber_v);
   /// <summary>Show a specific virtual region within the scroller content object.
/// This will ensure all (or part if it does not fit) of the designated region in the virtual content object (0, 0 starting at the top-left of the virtual content object) is shown within the scroller. Unlike elm_scroller_region_show(), this allows the scroller to &quot;smoothly slide&quot; to this location (if configuration in general calls for transitions). It may not jump immediately to the new location and make take a while and show other content along the way.
/// 
/// See <see cref="Elm.InterfaceScrollable.ShowContentRegion"/></summary>
/// <param name="x">X coordinate of the region</param>
/// <param name="y">Y coordinate of the region</param>
/// <param name="w">Width of the region</param>
/// <param name="h">Height of the region</param>
/// <returns></returns>
 void RegionBringIn(  int x,   int y,   int w,   int h);
   /// <summary>Show a specific virtual region within the scroller content object by page number.
/// 0, 0 of the indicated page is located at the top-left of the viewport. This will slide to the page with animation.
/// 
/// <see cref="Elm.InterfaceScrollable.ShowPage"/></summary>
/// <param name="pagenumber_h">The horizontal page number</param>
/// <param name="pagenumber_v">The vertical page number</param>
/// <returns></returns>
 void PageBringIn(  int pagenumber_h,   int pagenumber_v);
   /// <summary>Show a specific virtual region within the scroller content object
/// This will ensure all (or part if it does not fit) of the designated region in the virtual content object (0, 0 starting at the top-left of the virtual content object) is shown within the scroller.</summary>
/// <param name="x">X coordinate of the region</param>
/// <param name="y">Y coordinate of the region</param>
/// <param name="w">Width of the region</param>
/// <param name="h">Height of the region</param>
/// <returns></returns>
 void ShowContentRegion(  int x,   int y,   int w,   int h);
   /// <summary>Prevent the scrollable from being smaller than the minimum size of the content.
/// By default the scroller will be as small as its design allows, irrespective of its content. This will make the scroller minimum size the right size horizontally and/or vertically to perfectly fit its content in that direction.</summary>
/// <param name="w">Whether to limit the minimum horizontal size</param>
/// <param name="h">Whether to limit the minimum vertical size</param>
/// <returns></returns>
 void ContentMinLimit( bool w,  bool h);
   /// <summary></summary>
/// <param name="x"></param>
/// <param name="y"></param>
/// <returns></returns>
 void SetWantedRegion(  int x,   int y);
   /// <summary></summary>
/// <param name="x"></param>
/// <param name="y"></param>
/// <returns></returns>
 void CustomPanPosAdjust(  int x,   int y);
                                                                                                                                                                                                                                          /// <summary>Called when content changed</summary>
   event EventHandler ChangedEvt;
   /// <summary>Control Wheel disable Enable or disable mouse wheel to be used to scroll the scroller content. heel is enabled by default.</summary>
/// <value><c>true</c> if wheel is disabled, <c>false</c> otherwise</value>
   bool WheelDisabled {
      get ;
      set ;
   }
   /// <summary>Blocking of scrolling (per axis)
/// This function will block scrolling movement (by input of a user) in a given direction. One can disable movements in the X axis, the Y axis or both. The default value is <c>none</c>, where movements are allowed in both directions.
/// 
/// What makes this function different from freeze_push(), hold_push() and lock_x_set() (or lock_y_set()) is that it doesn&apos;t propagate its effects to any parent or child widget of <c>obj</c>. Only the target scrollable widget will be locked with regard to scrolling.</summary>
/// <value>Which axis (or axes) to block</value>
   Efl.Ui.ScrollBlock MovementBlock {
      get ;
      set ;
   }
   /// <summary>Momentum animator</summary>
/// <value><c>true</c> if disabled, <c>false</c> otherwise</value>
   bool MomentumAnimatorDisabled {
      get ;
      set ;
   }
   /// <summary>It decides whether the scrollable object propagates the events to content object or not.</summary>
/// <value><c>true</c> if events are propagated, <c>false</c> otherwise</value>
   bool ContentEvents {
      get ;
      set ;
   }
   /// <summary>Bounce animator</summary>
/// <value><c>true</c> if bounce animation is disabled, <c>false</c> otherwise</value>
   bool BounceAnimatorDisabled {
      get ;
      set ;
   }
   /// <summary>Single direction scroll configuration
/// This makes it possible to restrict scrolling to a single direction, with a &quot;soft&quot; or &quot;hard&quot; behavior.
/// 
/// The hard behavior restricts the scrolling to a single direction all of the time while the soft one will restrict depending on factors such as the movement angle. If the user scrolls roughly in one direction only, it will only move according to it while if the move was clearly wanted on both axes, it will happen on both of them.
/// 1.8</summary>
/// <value>The single direction scroll policy</value>
   Elm.Scroller.SingleDirection SingleDirection {
      get ;
      set ;
   }
   /// <summary>Set the callback to run when the content has been moved up.</summary>
/// <value>The callback</value>
   ElmInterfaceScrollableCb ScrollUpCb {
      set ;
   }
   /// <summary>Set the callback to run when the horizontal scrollbar is dragged.</summary>
/// <value>The callback</value>
   ElmInterfaceScrollableCb HbarDragCb {
      set ;
   }
   /// <summary>Set the callback to run when dragging of the contents has started.</summary>
/// <value>The callback</value>
   ElmInterfaceScrollableCb DragStartCb {
      set ;
   }
   /// <summary>Set the callback to run when scrolling of the contents has started.</summary>
/// <value>The callback</value>
   ElmInterfaceScrollableCb ScrollStartCb {
      set ;
   }
   /// <summary>Freeze property</summary>
/// <value><c>true</c> if freeze, <c>false</c> otherwise</value>
   bool Freeze {
      set ;
   }
   /// <summary>When the viewport is resized, the callback is called.</summary>
/// <value>The callback</value>
   ElmInterfaceScrollableResizeCb ContentViewportResizeCb {
      set ;
   }
   /// <summary>Set the callback to run when the content has been moved to the left</summary>
/// <value>The callback</value>
   ElmInterfaceScrollableCb ScrollLeftCb {
      set ;
   }
   /// <summary>Set the callback to run when the vertical scrollbar is pressed.</summary>
/// <value>The callback</value>
   ElmInterfaceScrollableCb VbarPressCb {
      set ;
   }
   /// <summary>Set the callback to run when the horizontal scrollbar is pressed.</summary>
/// <value>The callback</value>
   ElmInterfaceScrollableCb HbarPressCb {
      set ;
   }
   /// <summary>Set the callback to run when the horizontal scrollbar is unpressed.</summary>
/// <value>The callback</value>
   ElmInterfaceScrollableCb HbarUnpressCb {
      set ;
   }
   /// <summary>Set the callback to run when dragging of the contents has stopped.</summary>
/// <value>The callback</value>
   ElmInterfaceScrollableCb DragStopCb {
      set ;
   }
   /// <summary>Set the callback to run when scrolling of the contents has stopped.</summary>
/// <value>The callback</value>
   ElmInterfaceScrollableCb ScrollStopCb {
      set ;
   }
   /// <summary>Extern pan</summary>
/// <value>Pan object</value>
   Efl.Canvas.Object ExternPan {
      set ;
   }
   /// <summary>Set the callback to run when the visible page changes.</summary>
/// <value>The callback</value>
   ElmInterfaceScrollableCb PageChangeCb {
      set ;
   }
   /// <summary>Hold property</summary>
/// <value><c>true</c> if hold, <c>false</c> otherwise</value>
   bool Hold {
      set ;
   }
   /// <summary>Set the callback to run when the scrolling animation has started.</summary>
/// <value>The callback</value>
   ElmInterfaceScrollableCb AnimateStartCb {
      set ;
   }
   /// <summary>Set the callback to run when the content has been moved down.</summary>
/// <value>The callback</value>
   ElmInterfaceScrollableCb ScrollDownCb {
      set ;
   }
   /// <summary>Set the callback to run when the content has been moved.</summary>
/// <value>The callback</value>
   ElmInterfaceScrollableCb ScrollCb {
      set ;
   }
   /// <summary>Set the callback to run when the scrolling animation has stopped.</summary>
/// <value>The callback</value>
   ElmInterfaceScrollableCb AnimateStopCb {
      set ;
   }
   /// <summary>set the callback to run on minimal limit content</summary>
/// <value>The callback</value>
   ElmInterfaceScrollableMinLimitCb ContentMinLimitCb {
      set ;
   }
   /// <summary>Set the callback to run when the content has been moved to the right.</summary>
/// <value>The callback</value>
   ElmInterfaceScrollableCb ScrollRightCb {
      set ;
   }
   /// <summary>Content property</summary>
/// <value>Content object</value>
   Efl.Canvas.Object ScrollableContent {
      set ;
   }
   /// <summary>Set the callback to run when the left edge of the content has been reached.</summary>
/// <value>The callback</value>
   ElmInterfaceScrollableCb EdgeLeftCb {
      set ;
   }
   /// <summary>Set the callback to run when the horizontal scrollbar is dragged.</summary>
/// <value>The callback</value>
   ElmInterfaceScrollableCb VbarDragCb {
      set ;
   }
   /// <summary>Set the callback to run when the horizontal scrollbar is unpressed.</summary>
/// <value>The callback</value>
   ElmInterfaceScrollableCb VbarUnpressCb {
      set ;
   }
   /// <summary>Set the callback to run when the bottom edge of the content has been reached.</summary>
/// <value>The callback</value>
   ElmInterfaceScrollableCb EdgeBottomCb {
      set ;
   }
   /// <summary>Set the callback to run when the right edge of the content has been reached.</summary>
/// <value>The callback</value>
   ElmInterfaceScrollableCb EdgeRightCb {
      set ;
   }
   /// <summary>Set the callback to run when the top edge of the content has been reached.</summary>
/// <value>The callback</value>
   ElmInterfaceScrollableCb EdgeTopCb {
      set ;
   }
   /// <summary>Whether scrolling should loop around.</summary>
/// <value>True to enable looping.</value>
   bool ItemLoopEnabled {
      get ;
      set ;
   }
}
/// <summary>Elm scrollable mixin</summary>
sealed public class InterfaceScrollableConcrete : 

InterfaceScrollable
   , Efl.Ui.Scrollable, Efl.Ui.WidgetFocusManager, Efl.Ui.Focus.Manager, Efl.Ui.Focus.ManagerSub
{
   ///<summary>Pointer to the native class description.</summary>
   public System.IntPtr NativeClass {
      get {
         if (((object)this).GetType() == typeof (InterfaceScrollableConcrete))
            return Elm.InterfaceScrollableNativeInherit.GetEflClassStatic();
         else
            return Efl.Eo.ClassRegister.klassFromType[((object)this).GetType()];
      }
   }
   private EventHandlerList eventHandlers = new EventHandlerList();
   private  System.IntPtr handle;
   ///<summary>Pointer to the native instance.</summary>
   public System.IntPtr NativeHandle {
      get { return handle; }
   }
   [System.Runtime.InteropServices.DllImport(efl.Libs.Elementary)] internal static extern System.IntPtr
      elm_interface_scrollable_mixin_get();
   ///<summary>Internal usage: Constructs an instance from a native pointer. This is used when interacting with C code and should not be used directly.</summary>
   public InterfaceScrollableConcrete(System.IntPtr raw)
   {
      handle = raw;
      register_event_proxies();
   }
   ///<summary>Destructor.</summary>
   ~InterfaceScrollableConcrete()
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
   public static InterfaceScrollableConcrete static_cast(Efl.Object obj)
   {
      if (obj == null)
         throw new System.ArgumentNullException("obj");
      return new InterfaceScrollableConcrete(obj.NativeHandle);
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
   private readonly object eventLock = new object();
   private Dictionary<string, int> event_cb_count = new Dictionary<string, int>();
   private bool add_cpp_event_handler(string lib, string key, Efl.EventCb evt_delegate) {
      int event_count = 0;
      if (!event_cb_count.TryGetValue(key, out event_count))
         event_cb_count[key] = event_count;
      if (event_count == 0) {
         IntPtr desc = Efl.EventDescription.GetNative(lib, key);
         if (desc == IntPtr.Zero) {
            Eina.Log.Error($"Failed to get native event {key}");
            return false;
         }
          bool result = Efl.Eo.Globals.efl_event_callback_priority_add(handle, desc, 0, evt_delegate, System.IntPtr.Zero);
         if (!result) {
            Eina.Log.Error($"Failed to add event proxy for event {key}");
            return false;
         }
         Eina.Error.RaiseIfUnhandledException();
      } 
      event_cb_count[key]++;
      return true;
   }
   private bool remove_cpp_event_handler(string key, Efl.EventCb evt_delegate) {
      int event_count = 0;
      if (!event_cb_count.TryGetValue(key, out event_count))
         event_cb_count[key] = event_count;
      if (event_count == 1) {
         IntPtr desc = Efl.EventDescription.GetNative(efl.Libs.Elementary, key);
         if (desc == IntPtr.Zero) {
            Eina.Log.Error($"Failed to get native event {key}");
            return false;
         }
         bool result = Efl.Eo.Globals.efl_event_callback_del(handle, desc, evt_delegate, System.IntPtr.Zero);
         if (!result) {
            Eina.Log.Error($"Failed to remove event proxy for event {key}");
            return false;
         }
         Eina.Error.RaiseIfUnhandledException();
      } else if (event_count == 0) {
         Eina.Log.Error($"Trying to remove proxy for event {key} when there is nothing registered.");
         return false;
      } 
      event_cb_count[key]--;
      return true;
   }
private static object ChangedEvtKey = new object();
   /// <summary>Called when content changed</summary>
   public event EventHandler ChangedEvt
   {
      add {
         lock (eventLock) {
            string key = "_ELM_INTERFACE_SCROLLABLE_EVENT_CHANGED";
            if (add_cpp_event_handler(efl.Libs.Elementary, key, this.evt_ChangedEvt_delegate)) {
               eventHandlers.AddHandler(ChangedEvtKey , value);
            } else
               Eina.Log.Error($"Error adding proxy for event {key}");
         }
      }
      remove {
         lock (eventLock) {
            string key = "_ELM_INTERFACE_SCROLLABLE_EVENT_CHANGED";
            if (remove_cpp_event_handler(key, this.evt_ChangedEvt_delegate)) { 
               eventHandlers.RemoveHandler(ChangedEvtKey , value);
            } else
               Eina.Log.Error($"Error removing proxy for event {key}");
         }
      }
   }
   ///<summary>Method to raise event ChangedEvt.</summary>
   public void On_ChangedEvt(EventArgs e)
   {
      EventHandler evt;
      lock (eventLock) {
      evt = (EventHandler)eventHandlers[ChangedEvtKey];
      }
      evt?.Invoke(this, e);
   }
   Efl.EventCb evt_ChangedEvt_delegate;
   private void on_ChangedEvt_NativeCallback(System.IntPtr data, ref Efl.Event_StructInternal evt)
   {
      EventArgs args = EventArgs.Empty;
      try {
         On_ChangedEvt(args);
      } catch (Exception e) {
         Eina.Log.Error(e.ToString());
         Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
      }
   }

private static object ScrollStartEvtKey = new object();
   /// <summary>Called when scroll operation starts</summary>
   public event EventHandler ScrollStartEvt
   {
      add {
         lock (eventLock) {
            string key = "_EFL_UI_EVENT_SCROLL_START";
            if (add_cpp_event_handler(efl.Libs.Efl, key, this.evt_ScrollStartEvt_delegate)) {
               eventHandlers.AddHandler(ScrollStartEvtKey , value);
            } else
               Eina.Log.Error($"Error adding proxy for event {key}");
         }
      }
      remove {
         lock (eventLock) {
            string key = "_EFL_UI_EVENT_SCROLL_START";
            if (remove_cpp_event_handler(key, this.evt_ScrollStartEvt_delegate)) { 
               eventHandlers.RemoveHandler(ScrollStartEvtKey , value);
            } else
               Eina.Log.Error($"Error removing proxy for event {key}");
         }
      }
   }
   ///<summary>Method to raise event ScrollStartEvt.</summary>
   public void On_ScrollStartEvt(EventArgs e)
   {
      EventHandler evt;
      lock (eventLock) {
      evt = (EventHandler)eventHandlers[ScrollStartEvtKey];
      }
      evt?.Invoke(this, e);
   }
   Efl.EventCb evt_ScrollStartEvt_delegate;
   private void on_ScrollStartEvt_NativeCallback(System.IntPtr data, ref Efl.Event_StructInternal evt)
   {
      EventArgs args = EventArgs.Empty;
      try {
         On_ScrollStartEvt(args);
      } catch (Exception e) {
         Eina.Log.Error(e.ToString());
         Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
      }
   }

private static object ScrollEvtKey = new object();
   /// <summary>Called when scrolling</summary>
   public event EventHandler ScrollEvt
   {
      add {
         lock (eventLock) {
            string key = "_EFL_UI_EVENT_SCROLL";
            if (add_cpp_event_handler(efl.Libs.Efl, key, this.evt_ScrollEvt_delegate)) {
               eventHandlers.AddHandler(ScrollEvtKey , value);
            } else
               Eina.Log.Error($"Error adding proxy for event {key}");
         }
      }
      remove {
         lock (eventLock) {
            string key = "_EFL_UI_EVENT_SCROLL";
            if (remove_cpp_event_handler(key, this.evt_ScrollEvt_delegate)) { 
               eventHandlers.RemoveHandler(ScrollEvtKey , value);
            } else
               Eina.Log.Error($"Error removing proxy for event {key}");
         }
      }
   }
   ///<summary>Method to raise event ScrollEvt.</summary>
   public void On_ScrollEvt(EventArgs e)
   {
      EventHandler evt;
      lock (eventLock) {
      evt = (EventHandler)eventHandlers[ScrollEvtKey];
      }
      evt?.Invoke(this, e);
   }
   Efl.EventCb evt_ScrollEvt_delegate;
   private void on_ScrollEvt_NativeCallback(System.IntPtr data, ref Efl.Event_StructInternal evt)
   {
      EventArgs args = EventArgs.Empty;
      try {
         On_ScrollEvt(args);
      } catch (Exception e) {
         Eina.Log.Error(e.ToString());
         Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
      }
   }

private static object ScrollStopEvtKey = new object();
   /// <summary>Called when scroll operation stops</summary>
   public event EventHandler ScrollStopEvt
   {
      add {
         lock (eventLock) {
            string key = "_EFL_UI_EVENT_SCROLL_STOP";
            if (add_cpp_event_handler(efl.Libs.Efl, key, this.evt_ScrollStopEvt_delegate)) {
               eventHandlers.AddHandler(ScrollStopEvtKey , value);
            } else
               Eina.Log.Error($"Error adding proxy for event {key}");
         }
      }
      remove {
         lock (eventLock) {
            string key = "_EFL_UI_EVENT_SCROLL_STOP";
            if (remove_cpp_event_handler(key, this.evt_ScrollStopEvt_delegate)) { 
               eventHandlers.RemoveHandler(ScrollStopEvtKey , value);
            } else
               Eina.Log.Error($"Error removing proxy for event {key}");
         }
      }
   }
   ///<summary>Method to raise event ScrollStopEvt.</summary>
   public void On_ScrollStopEvt(EventArgs e)
   {
      EventHandler evt;
      lock (eventLock) {
      evt = (EventHandler)eventHandlers[ScrollStopEvtKey];
      }
      evt?.Invoke(this, e);
   }
   Efl.EventCb evt_ScrollStopEvt_delegate;
   private void on_ScrollStopEvt_NativeCallback(System.IntPtr data, ref Efl.Event_StructInternal evt)
   {
      EventArgs args = EventArgs.Empty;
      try {
         On_ScrollStopEvt(args);
      } catch (Exception e) {
         Eina.Log.Error(e.ToString());
         Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
      }
   }

private static object ScrollUpEvtKey = new object();
   /// <summary>Called when scrolling upwards</summary>
   public event EventHandler ScrollUpEvt
   {
      add {
         lock (eventLock) {
            string key = "_EFL_UI_EVENT_SCROLL_UP";
            if (add_cpp_event_handler(efl.Libs.Efl, key, this.evt_ScrollUpEvt_delegate)) {
               eventHandlers.AddHandler(ScrollUpEvtKey , value);
            } else
               Eina.Log.Error($"Error adding proxy for event {key}");
         }
      }
      remove {
         lock (eventLock) {
            string key = "_EFL_UI_EVENT_SCROLL_UP";
            if (remove_cpp_event_handler(key, this.evt_ScrollUpEvt_delegate)) { 
               eventHandlers.RemoveHandler(ScrollUpEvtKey , value);
            } else
               Eina.Log.Error($"Error removing proxy for event {key}");
         }
      }
   }
   ///<summary>Method to raise event ScrollUpEvt.</summary>
   public void On_ScrollUpEvt(EventArgs e)
   {
      EventHandler evt;
      lock (eventLock) {
      evt = (EventHandler)eventHandlers[ScrollUpEvtKey];
      }
      evt?.Invoke(this, e);
   }
   Efl.EventCb evt_ScrollUpEvt_delegate;
   private void on_ScrollUpEvt_NativeCallback(System.IntPtr data, ref Efl.Event_StructInternal evt)
   {
      EventArgs args = EventArgs.Empty;
      try {
         On_ScrollUpEvt(args);
      } catch (Exception e) {
         Eina.Log.Error(e.ToString());
         Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
      }
   }

private static object ScrollDownEvtKey = new object();
   /// <summary>Called when scrolling downwards</summary>
   public event EventHandler ScrollDownEvt
   {
      add {
         lock (eventLock) {
            string key = "_EFL_UI_EVENT_SCROLL_DOWN";
            if (add_cpp_event_handler(efl.Libs.Efl, key, this.evt_ScrollDownEvt_delegate)) {
               eventHandlers.AddHandler(ScrollDownEvtKey , value);
            } else
               Eina.Log.Error($"Error adding proxy for event {key}");
         }
      }
      remove {
         lock (eventLock) {
            string key = "_EFL_UI_EVENT_SCROLL_DOWN";
            if (remove_cpp_event_handler(key, this.evt_ScrollDownEvt_delegate)) { 
               eventHandlers.RemoveHandler(ScrollDownEvtKey , value);
            } else
               Eina.Log.Error($"Error removing proxy for event {key}");
         }
      }
   }
   ///<summary>Method to raise event ScrollDownEvt.</summary>
   public void On_ScrollDownEvt(EventArgs e)
   {
      EventHandler evt;
      lock (eventLock) {
      evt = (EventHandler)eventHandlers[ScrollDownEvtKey];
      }
      evt?.Invoke(this, e);
   }
   Efl.EventCb evt_ScrollDownEvt_delegate;
   private void on_ScrollDownEvt_NativeCallback(System.IntPtr data, ref Efl.Event_StructInternal evt)
   {
      EventArgs args = EventArgs.Empty;
      try {
         On_ScrollDownEvt(args);
      } catch (Exception e) {
         Eina.Log.Error(e.ToString());
         Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
      }
   }

private static object ScrollLeftEvtKey = new object();
   /// <summary>Called when scrolling left</summary>
   public event EventHandler ScrollLeftEvt
   {
      add {
         lock (eventLock) {
            string key = "_EFL_UI_EVENT_SCROLL_LEFT";
            if (add_cpp_event_handler(efl.Libs.Efl, key, this.evt_ScrollLeftEvt_delegate)) {
               eventHandlers.AddHandler(ScrollLeftEvtKey , value);
            } else
               Eina.Log.Error($"Error adding proxy for event {key}");
         }
      }
      remove {
         lock (eventLock) {
            string key = "_EFL_UI_EVENT_SCROLL_LEFT";
            if (remove_cpp_event_handler(key, this.evt_ScrollLeftEvt_delegate)) { 
               eventHandlers.RemoveHandler(ScrollLeftEvtKey , value);
            } else
               Eina.Log.Error($"Error removing proxy for event {key}");
         }
      }
   }
   ///<summary>Method to raise event ScrollLeftEvt.</summary>
   public void On_ScrollLeftEvt(EventArgs e)
   {
      EventHandler evt;
      lock (eventLock) {
      evt = (EventHandler)eventHandlers[ScrollLeftEvtKey];
      }
      evt?.Invoke(this, e);
   }
   Efl.EventCb evt_ScrollLeftEvt_delegate;
   private void on_ScrollLeftEvt_NativeCallback(System.IntPtr data, ref Efl.Event_StructInternal evt)
   {
      EventArgs args = EventArgs.Empty;
      try {
         On_ScrollLeftEvt(args);
      } catch (Exception e) {
         Eina.Log.Error(e.ToString());
         Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
      }
   }

private static object ScrollRightEvtKey = new object();
   /// <summary>Called when scrolling right</summary>
   public event EventHandler ScrollRightEvt
   {
      add {
         lock (eventLock) {
            string key = "_EFL_UI_EVENT_SCROLL_RIGHT";
            if (add_cpp_event_handler(efl.Libs.Efl, key, this.evt_ScrollRightEvt_delegate)) {
               eventHandlers.AddHandler(ScrollRightEvtKey , value);
            } else
               Eina.Log.Error($"Error adding proxy for event {key}");
         }
      }
      remove {
         lock (eventLock) {
            string key = "_EFL_UI_EVENT_SCROLL_RIGHT";
            if (remove_cpp_event_handler(key, this.evt_ScrollRightEvt_delegate)) { 
               eventHandlers.RemoveHandler(ScrollRightEvtKey , value);
            } else
               Eina.Log.Error($"Error removing proxy for event {key}");
         }
      }
   }
   ///<summary>Method to raise event ScrollRightEvt.</summary>
   public void On_ScrollRightEvt(EventArgs e)
   {
      EventHandler evt;
      lock (eventLock) {
      evt = (EventHandler)eventHandlers[ScrollRightEvtKey];
      }
      evt?.Invoke(this, e);
   }
   Efl.EventCb evt_ScrollRightEvt_delegate;
   private void on_ScrollRightEvt_NativeCallback(System.IntPtr data, ref Efl.Event_StructInternal evt)
   {
      EventArgs args = EventArgs.Empty;
      try {
         On_ScrollRightEvt(args);
      } catch (Exception e) {
         Eina.Log.Error(e.ToString());
         Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
      }
   }

private static object EdgeUpEvtKey = new object();
   /// <summary>Called when hitting the top edge</summary>
   public event EventHandler EdgeUpEvt
   {
      add {
         lock (eventLock) {
            string key = "_EFL_UI_EVENT_EDGE_UP";
            if (add_cpp_event_handler(efl.Libs.Efl, key, this.evt_EdgeUpEvt_delegate)) {
               eventHandlers.AddHandler(EdgeUpEvtKey , value);
            } else
               Eina.Log.Error($"Error adding proxy for event {key}");
         }
      }
      remove {
         lock (eventLock) {
            string key = "_EFL_UI_EVENT_EDGE_UP";
            if (remove_cpp_event_handler(key, this.evt_EdgeUpEvt_delegate)) { 
               eventHandlers.RemoveHandler(EdgeUpEvtKey , value);
            } else
               Eina.Log.Error($"Error removing proxy for event {key}");
         }
      }
   }
   ///<summary>Method to raise event EdgeUpEvt.</summary>
   public void On_EdgeUpEvt(EventArgs e)
   {
      EventHandler evt;
      lock (eventLock) {
      evt = (EventHandler)eventHandlers[EdgeUpEvtKey];
      }
      evt?.Invoke(this, e);
   }
   Efl.EventCb evt_EdgeUpEvt_delegate;
   private void on_EdgeUpEvt_NativeCallback(System.IntPtr data, ref Efl.Event_StructInternal evt)
   {
      EventArgs args = EventArgs.Empty;
      try {
         On_EdgeUpEvt(args);
      } catch (Exception e) {
         Eina.Log.Error(e.ToString());
         Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
      }
   }

private static object EdgeDownEvtKey = new object();
   /// <summary>Called when hitting the bottom edge</summary>
   public event EventHandler EdgeDownEvt
   {
      add {
         lock (eventLock) {
            string key = "_EFL_UI_EVENT_EDGE_DOWN";
            if (add_cpp_event_handler(efl.Libs.Efl, key, this.evt_EdgeDownEvt_delegate)) {
               eventHandlers.AddHandler(EdgeDownEvtKey , value);
            } else
               Eina.Log.Error($"Error adding proxy for event {key}");
         }
      }
      remove {
         lock (eventLock) {
            string key = "_EFL_UI_EVENT_EDGE_DOWN";
            if (remove_cpp_event_handler(key, this.evt_EdgeDownEvt_delegate)) { 
               eventHandlers.RemoveHandler(EdgeDownEvtKey , value);
            } else
               Eina.Log.Error($"Error removing proxy for event {key}");
         }
      }
   }
   ///<summary>Method to raise event EdgeDownEvt.</summary>
   public void On_EdgeDownEvt(EventArgs e)
   {
      EventHandler evt;
      lock (eventLock) {
      evt = (EventHandler)eventHandlers[EdgeDownEvtKey];
      }
      evt?.Invoke(this, e);
   }
   Efl.EventCb evt_EdgeDownEvt_delegate;
   private void on_EdgeDownEvt_NativeCallback(System.IntPtr data, ref Efl.Event_StructInternal evt)
   {
      EventArgs args = EventArgs.Empty;
      try {
         On_EdgeDownEvt(args);
      } catch (Exception e) {
         Eina.Log.Error(e.ToString());
         Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
      }
   }

private static object EdgeLeftEvtKey = new object();
   /// <summary>Called when hitting the left edge</summary>
   public event EventHandler EdgeLeftEvt
   {
      add {
         lock (eventLock) {
            string key = "_EFL_UI_EVENT_EDGE_LEFT";
            if (add_cpp_event_handler(efl.Libs.Efl, key, this.evt_EdgeLeftEvt_delegate)) {
               eventHandlers.AddHandler(EdgeLeftEvtKey , value);
            } else
               Eina.Log.Error($"Error adding proxy for event {key}");
         }
      }
      remove {
         lock (eventLock) {
            string key = "_EFL_UI_EVENT_EDGE_LEFT";
            if (remove_cpp_event_handler(key, this.evt_EdgeLeftEvt_delegate)) { 
               eventHandlers.RemoveHandler(EdgeLeftEvtKey , value);
            } else
               Eina.Log.Error($"Error removing proxy for event {key}");
         }
      }
   }
   ///<summary>Method to raise event EdgeLeftEvt.</summary>
   public void On_EdgeLeftEvt(EventArgs e)
   {
      EventHandler evt;
      lock (eventLock) {
      evt = (EventHandler)eventHandlers[EdgeLeftEvtKey];
      }
      evt?.Invoke(this, e);
   }
   Efl.EventCb evt_EdgeLeftEvt_delegate;
   private void on_EdgeLeftEvt_NativeCallback(System.IntPtr data, ref Efl.Event_StructInternal evt)
   {
      EventArgs args = EventArgs.Empty;
      try {
         On_EdgeLeftEvt(args);
      } catch (Exception e) {
         Eina.Log.Error(e.ToString());
         Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
      }
   }

private static object EdgeRightEvtKey = new object();
   /// <summary>Called when hitting the right edge</summary>
   public event EventHandler EdgeRightEvt
   {
      add {
         lock (eventLock) {
            string key = "_EFL_UI_EVENT_EDGE_RIGHT";
            if (add_cpp_event_handler(efl.Libs.Efl, key, this.evt_EdgeRightEvt_delegate)) {
               eventHandlers.AddHandler(EdgeRightEvtKey , value);
            } else
               Eina.Log.Error($"Error adding proxy for event {key}");
         }
      }
      remove {
         lock (eventLock) {
            string key = "_EFL_UI_EVENT_EDGE_RIGHT";
            if (remove_cpp_event_handler(key, this.evt_EdgeRightEvt_delegate)) { 
               eventHandlers.RemoveHandler(EdgeRightEvtKey , value);
            } else
               Eina.Log.Error($"Error removing proxy for event {key}");
         }
      }
   }
   ///<summary>Method to raise event EdgeRightEvt.</summary>
   public void On_EdgeRightEvt(EventArgs e)
   {
      EventHandler evt;
      lock (eventLock) {
      evt = (EventHandler)eventHandlers[EdgeRightEvtKey];
      }
      evt?.Invoke(this, e);
   }
   Efl.EventCb evt_EdgeRightEvt_delegate;
   private void on_EdgeRightEvt_NativeCallback(System.IntPtr data, ref Efl.Event_StructInternal evt)
   {
      EventArgs args = EventArgs.Empty;
      try {
         On_EdgeRightEvt(args);
      } catch (Exception e) {
         Eina.Log.Error(e.ToString());
         Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
      }
   }

private static object ScrollAnimStartEvtKey = new object();
   /// <summary>Called when scroll animation starts</summary>
   public event EventHandler ScrollAnimStartEvt
   {
      add {
         lock (eventLock) {
            string key = "_EFL_UI_EVENT_SCROLL_ANIM_START";
            if (add_cpp_event_handler(efl.Libs.Efl, key, this.evt_ScrollAnimStartEvt_delegate)) {
               eventHandlers.AddHandler(ScrollAnimStartEvtKey , value);
            } else
               Eina.Log.Error($"Error adding proxy for event {key}");
         }
      }
      remove {
         lock (eventLock) {
            string key = "_EFL_UI_EVENT_SCROLL_ANIM_START";
            if (remove_cpp_event_handler(key, this.evt_ScrollAnimStartEvt_delegate)) { 
               eventHandlers.RemoveHandler(ScrollAnimStartEvtKey , value);
            } else
               Eina.Log.Error($"Error removing proxy for event {key}");
         }
      }
   }
   ///<summary>Method to raise event ScrollAnimStartEvt.</summary>
   public void On_ScrollAnimStartEvt(EventArgs e)
   {
      EventHandler evt;
      lock (eventLock) {
      evt = (EventHandler)eventHandlers[ScrollAnimStartEvtKey];
      }
      evt?.Invoke(this, e);
   }
   Efl.EventCb evt_ScrollAnimStartEvt_delegate;
   private void on_ScrollAnimStartEvt_NativeCallback(System.IntPtr data, ref Efl.Event_StructInternal evt)
   {
      EventArgs args = EventArgs.Empty;
      try {
         On_ScrollAnimStartEvt(args);
      } catch (Exception e) {
         Eina.Log.Error(e.ToString());
         Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
      }
   }

private static object ScrollAnimStopEvtKey = new object();
   /// <summary>Called when scroll animation stopps</summary>
   public event EventHandler ScrollAnimStopEvt
   {
      add {
         lock (eventLock) {
            string key = "_EFL_UI_EVENT_SCROLL_ANIM_STOP";
            if (add_cpp_event_handler(efl.Libs.Efl, key, this.evt_ScrollAnimStopEvt_delegate)) {
               eventHandlers.AddHandler(ScrollAnimStopEvtKey , value);
            } else
               Eina.Log.Error($"Error adding proxy for event {key}");
         }
      }
      remove {
         lock (eventLock) {
            string key = "_EFL_UI_EVENT_SCROLL_ANIM_STOP";
            if (remove_cpp_event_handler(key, this.evt_ScrollAnimStopEvt_delegate)) { 
               eventHandlers.RemoveHandler(ScrollAnimStopEvtKey , value);
            } else
               Eina.Log.Error($"Error removing proxy for event {key}");
         }
      }
   }
   ///<summary>Method to raise event ScrollAnimStopEvt.</summary>
   public void On_ScrollAnimStopEvt(EventArgs e)
   {
      EventHandler evt;
      lock (eventLock) {
      evt = (EventHandler)eventHandlers[ScrollAnimStopEvtKey];
      }
      evt?.Invoke(this, e);
   }
   Efl.EventCb evt_ScrollAnimStopEvt_delegate;
   private void on_ScrollAnimStopEvt_NativeCallback(System.IntPtr data, ref Efl.Event_StructInternal evt)
   {
      EventArgs args = EventArgs.Empty;
      try {
         On_ScrollAnimStopEvt(args);
      } catch (Exception e) {
         Eina.Log.Error(e.ToString());
         Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
      }
   }

private static object ScrollDragStartEvtKey = new object();
   /// <summary>Called when scroll drag starts</summary>
   public event EventHandler ScrollDragStartEvt
   {
      add {
         lock (eventLock) {
            string key = "_EFL_UI_EVENT_SCROLL_DRAG_START";
            if (add_cpp_event_handler(efl.Libs.Efl, key, this.evt_ScrollDragStartEvt_delegate)) {
               eventHandlers.AddHandler(ScrollDragStartEvtKey , value);
            } else
               Eina.Log.Error($"Error adding proxy for event {key}");
         }
      }
      remove {
         lock (eventLock) {
            string key = "_EFL_UI_EVENT_SCROLL_DRAG_START";
            if (remove_cpp_event_handler(key, this.evt_ScrollDragStartEvt_delegate)) { 
               eventHandlers.RemoveHandler(ScrollDragStartEvtKey , value);
            } else
               Eina.Log.Error($"Error removing proxy for event {key}");
         }
      }
   }
   ///<summary>Method to raise event ScrollDragStartEvt.</summary>
   public void On_ScrollDragStartEvt(EventArgs e)
   {
      EventHandler evt;
      lock (eventLock) {
      evt = (EventHandler)eventHandlers[ScrollDragStartEvtKey];
      }
      evt?.Invoke(this, e);
   }
   Efl.EventCb evt_ScrollDragStartEvt_delegate;
   private void on_ScrollDragStartEvt_NativeCallback(System.IntPtr data, ref Efl.Event_StructInternal evt)
   {
      EventArgs args = EventArgs.Empty;
      try {
         On_ScrollDragStartEvt(args);
      } catch (Exception e) {
         Eina.Log.Error(e.ToString());
         Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
      }
   }

private static object ScrollDragStopEvtKey = new object();
   /// <summary>Called when scroll drag stops</summary>
   public event EventHandler ScrollDragStopEvt
   {
      add {
         lock (eventLock) {
            string key = "_EFL_UI_EVENT_SCROLL_DRAG_STOP";
            if (add_cpp_event_handler(efl.Libs.Efl, key, this.evt_ScrollDragStopEvt_delegate)) {
               eventHandlers.AddHandler(ScrollDragStopEvtKey , value);
            } else
               Eina.Log.Error($"Error adding proxy for event {key}");
         }
      }
      remove {
         lock (eventLock) {
            string key = "_EFL_UI_EVENT_SCROLL_DRAG_STOP";
            if (remove_cpp_event_handler(key, this.evt_ScrollDragStopEvt_delegate)) { 
               eventHandlers.RemoveHandler(ScrollDragStopEvtKey , value);
            } else
               Eina.Log.Error($"Error removing proxy for event {key}");
         }
      }
   }
   ///<summary>Method to raise event ScrollDragStopEvt.</summary>
   public void On_ScrollDragStopEvt(EventArgs e)
   {
      EventHandler evt;
      lock (eventLock) {
      evt = (EventHandler)eventHandlers[ScrollDragStopEvtKey];
      }
      evt?.Invoke(this, e);
   }
   Efl.EventCb evt_ScrollDragStopEvt_delegate;
   private void on_ScrollDragStopEvt_NativeCallback(System.IntPtr data, ref Efl.Event_StructInternal evt)
   {
      EventArgs args = EventArgs.Empty;
      try {
         On_ScrollDragStopEvt(args);
      } catch (Exception e) {
         Eina.Log.Error(e.ToString());
         Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
      }
   }

private static object RedirectChangedEvtKey = new object();
   /// <summary>Redirect object has changed, the old manager is passed as an event argument.
   /// 1.20</summary>
   public event EventHandler<Efl.Ui.Focus.ManagerRedirectChangedEvt_Args> RedirectChangedEvt
   {
      add {
         lock (eventLock) {
            string key = "_EFL_UI_FOCUS_MANAGER_EVENT_REDIRECT_CHANGED";
            if (add_cpp_event_handler(efl.Libs.Elementary, key, this.evt_RedirectChangedEvt_delegate)) {
               eventHandlers.AddHandler(RedirectChangedEvtKey , value);
            } else
               Eina.Log.Error($"Error adding proxy for event {key}");
         }
      }
      remove {
         lock (eventLock) {
            string key = "_EFL_UI_FOCUS_MANAGER_EVENT_REDIRECT_CHANGED";
            if (remove_cpp_event_handler(key, this.evt_RedirectChangedEvt_delegate)) { 
               eventHandlers.RemoveHandler(RedirectChangedEvtKey , value);
            } else
               Eina.Log.Error($"Error removing proxy for event {key}");
         }
      }
   }
   ///<summary>Method to raise event RedirectChangedEvt.</summary>
   public void On_RedirectChangedEvt(Efl.Ui.Focus.ManagerRedirectChangedEvt_Args e)
   {
      EventHandler<Efl.Ui.Focus.ManagerRedirectChangedEvt_Args> evt;
      lock (eventLock) {
      evt = (EventHandler<Efl.Ui.Focus.ManagerRedirectChangedEvt_Args>)eventHandlers[RedirectChangedEvtKey];
      }
      evt?.Invoke(this, e);
   }
   Efl.EventCb evt_RedirectChangedEvt_delegate;
   private void on_RedirectChangedEvt_NativeCallback(System.IntPtr data, ref Efl.Event_StructInternal evt)
   {
      Efl.Ui.Focus.ManagerRedirectChangedEvt_Args args = new Efl.Ui.Focus.ManagerRedirectChangedEvt_Args();
      args.arg = new Efl.Ui.Focus.ManagerConcrete(evt.Info);
      try {
         On_RedirectChangedEvt(args);
      } catch (Exception e) {
         Eina.Log.Error(e.ToString());
         Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
      }
   }

private static object FlushPreEvtKey = new object();
   /// <summary>After this event, the manager object will calculate relations in the graph. Can be used to add / remove children in a lazy fashion.
   /// 1.20</summary>
   public event EventHandler FlushPreEvt
   {
      add {
         lock (eventLock) {
            string key = "_EFL_UI_FOCUS_MANAGER_EVENT_FLUSH_PRE";
            if (add_cpp_event_handler(efl.Libs.Elementary, key, this.evt_FlushPreEvt_delegate)) {
               eventHandlers.AddHandler(FlushPreEvtKey , value);
            } else
               Eina.Log.Error($"Error adding proxy for event {key}");
         }
      }
      remove {
         lock (eventLock) {
            string key = "_EFL_UI_FOCUS_MANAGER_EVENT_FLUSH_PRE";
            if (remove_cpp_event_handler(key, this.evt_FlushPreEvt_delegate)) { 
               eventHandlers.RemoveHandler(FlushPreEvtKey , value);
            } else
               Eina.Log.Error($"Error removing proxy for event {key}");
         }
      }
   }
   ///<summary>Method to raise event FlushPreEvt.</summary>
   public void On_FlushPreEvt(EventArgs e)
   {
      EventHandler evt;
      lock (eventLock) {
      evt = (EventHandler)eventHandlers[FlushPreEvtKey];
      }
      evt?.Invoke(this, e);
   }
   Efl.EventCb evt_FlushPreEvt_delegate;
   private void on_FlushPreEvt_NativeCallback(System.IntPtr data, ref Efl.Event_StructInternal evt)
   {
      EventArgs args = EventArgs.Empty;
      try {
         On_FlushPreEvt(args);
      } catch (Exception e) {
         Eina.Log.Error(e.ToString());
         Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
      }
   }

private static object CoordsDirtyEvtKey = new object();
   /// <summary>Cached relationship calculation results have been invalidated.
   /// 1.20</summary>
   public event EventHandler CoordsDirtyEvt
   {
      add {
         lock (eventLock) {
            string key = "_EFL_UI_FOCUS_MANAGER_EVENT_COORDS_DIRTY";
            if (add_cpp_event_handler(efl.Libs.Elementary, key, this.evt_CoordsDirtyEvt_delegate)) {
               eventHandlers.AddHandler(CoordsDirtyEvtKey , value);
            } else
               Eina.Log.Error($"Error adding proxy for event {key}");
         }
      }
      remove {
         lock (eventLock) {
            string key = "_EFL_UI_FOCUS_MANAGER_EVENT_COORDS_DIRTY";
            if (remove_cpp_event_handler(key, this.evt_CoordsDirtyEvt_delegate)) { 
               eventHandlers.RemoveHandler(CoordsDirtyEvtKey , value);
            } else
               Eina.Log.Error($"Error removing proxy for event {key}");
         }
      }
   }
   ///<summary>Method to raise event CoordsDirtyEvt.</summary>
   public void On_CoordsDirtyEvt(EventArgs e)
   {
      EventHandler evt;
      lock (eventLock) {
      evt = (EventHandler)eventHandlers[CoordsDirtyEvtKey];
      }
      evt?.Invoke(this, e);
   }
   Efl.EventCb evt_CoordsDirtyEvt_delegate;
   private void on_CoordsDirtyEvt_NativeCallback(System.IntPtr data, ref Efl.Event_StructInternal evt)
   {
      EventArgs args = EventArgs.Empty;
      try {
         On_CoordsDirtyEvt(args);
      } catch (Exception e) {
         Eina.Log.Error(e.ToString());
         Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
      }
   }

private static object Manager_focusChangedEvtKey = new object();
   /// <summary>The manager_focus property has changed. The previously focused object is passed as an event argument.
   /// 1.20</summary>
   public event EventHandler<Efl.Ui.Focus.ManagerManager_focusChangedEvt_Args> Manager_focusChangedEvt
   {
      add {
         lock (eventLock) {
            string key = "_EFL_UI_FOCUS_MANAGER_EVENT_MANAGER_FOCUS_CHANGED";
            if (add_cpp_event_handler(efl.Libs.Elementary, key, this.evt_Manager_focusChangedEvt_delegate)) {
               eventHandlers.AddHandler(Manager_focusChangedEvtKey , value);
            } else
               Eina.Log.Error($"Error adding proxy for event {key}");
         }
      }
      remove {
         lock (eventLock) {
            string key = "_EFL_UI_FOCUS_MANAGER_EVENT_MANAGER_FOCUS_CHANGED";
            if (remove_cpp_event_handler(key, this.evt_Manager_focusChangedEvt_delegate)) { 
               eventHandlers.RemoveHandler(Manager_focusChangedEvtKey , value);
            } else
               Eina.Log.Error($"Error removing proxy for event {key}");
         }
      }
   }
   ///<summary>Method to raise event Manager_focusChangedEvt.</summary>
   public void On_Manager_focusChangedEvt(Efl.Ui.Focus.ManagerManager_focusChangedEvt_Args e)
   {
      EventHandler<Efl.Ui.Focus.ManagerManager_focusChangedEvt_Args> evt;
      lock (eventLock) {
      evt = (EventHandler<Efl.Ui.Focus.ManagerManager_focusChangedEvt_Args>)eventHandlers[Manager_focusChangedEvtKey];
      }
      evt?.Invoke(this, e);
   }
   Efl.EventCb evt_Manager_focusChangedEvt_delegate;
   private void on_Manager_focusChangedEvt_NativeCallback(System.IntPtr data, ref Efl.Event_StructInternal evt)
   {
      Efl.Ui.Focus.ManagerManager_focusChangedEvt_Args args = new Efl.Ui.Focus.ManagerManager_focusChangedEvt_Args();
      args.arg = new Efl.Ui.Focus.ObjectConcrete(evt.Info);
      try {
         On_Manager_focusChangedEvt(args);
      } catch (Exception e) {
         Eina.Log.Error(e.ToString());
         Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
      }
   }

private static object Dirty_logic_freezeChangedEvtKey = new object();
   /// <summary>Called when this focus manager is frozen or thawed, even_info beeing <c>true</c> indicates that it is now frozen, <c>false</c> indicates that it is thawed.
   /// 1.20</summary>
   public event EventHandler<Efl.Ui.Focus.ManagerDirty_logic_freezeChangedEvt_Args> Dirty_logic_freezeChangedEvt
   {
      add {
         lock (eventLock) {
            string key = "_EFL_UI_FOCUS_MANAGER_EVENT_DIRTY_LOGIC_FREEZE_CHANGED";
            if (add_cpp_event_handler(efl.Libs.Elementary, key, this.evt_Dirty_logic_freezeChangedEvt_delegate)) {
               eventHandlers.AddHandler(Dirty_logic_freezeChangedEvtKey , value);
            } else
               Eina.Log.Error($"Error adding proxy for event {key}");
         }
      }
      remove {
         lock (eventLock) {
            string key = "_EFL_UI_FOCUS_MANAGER_EVENT_DIRTY_LOGIC_FREEZE_CHANGED";
            if (remove_cpp_event_handler(key, this.evt_Dirty_logic_freezeChangedEvt_delegate)) { 
               eventHandlers.RemoveHandler(Dirty_logic_freezeChangedEvtKey , value);
            } else
               Eina.Log.Error($"Error removing proxy for event {key}");
         }
      }
   }
   ///<summary>Method to raise event Dirty_logic_freezeChangedEvt.</summary>
   public void On_Dirty_logic_freezeChangedEvt(Efl.Ui.Focus.ManagerDirty_logic_freezeChangedEvt_Args e)
   {
      EventHandler<Efl.Ui.Focus.ManagerDirty_logic_freezeChangedEvt_Args> evt;
      lock (eventLock) {
      evt = (EventHandler<Efl.Ui.Focus.ManagerDirty_logic_freezeChangedEvt_Args>)eventHandlers[Dirty_logic_freezeChangedEvtKey];
      }
      evt?.Invoke(this, e);
   }
   Efl.EventCb evt_Dirty_logic_freezeChangedEvt_delegate;
   private void on_Dirty_logic_freezeChangedEvt_NativeCallback(System.IntPtr data, ref Efl.Event_StructInternal evt)
   {
      Efl.Ui.Focus.ManagerDirty_logic_freezeChangedEvt_Args args = new Efl.Ui.Focus.ManagerDirty_logic_freezeChangedEvt_Args();
      args.arg = evt.Info != IntPtr.Zero;
      try {
         On_Dirty_logic_freezeChangedEvt(args);
      } catch (Exception e) {
         Eina.Log.Error(e.ToString());
         Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
      }
   }

    void register_event_proxies()
   {
      evt_ChangedEvt_delegate = new Efl.EventCb(on_ChangedEvt_NativeCallback);
      evt_ScrollStartEvt_delegate = new Efl.EventCb(on_ScrollStartEvt_NativeCallback);
      evt_ScrollEvt_delegate = new Efl.EventCb(on_ScrollEvt_NativeCallback);
      evt_ScrollStopEvt_delegate = new Efl.EventCb(on_ScrollStopEvt_NativeCallback);
      evt_ScrollUpEvt_delegate = new Efl.EventCb(on_ScrollUpEvt_NativeCallback);
      evt_ScrollDownEvt_delegate = new Efl.EventCb(on_ScrollDownEvt_NativeCallback);
      evt_ScrollLeftEvt_delegate = new Efl.EventCb(on_ScrollLeftEvt_NativeCallback);
      evt_ScrollRightEvt_delegate = new Efl.EventCb(on_ScrollRightEvt_NativeCallback);
      evt_EdgeUpEvt_delegate = new Efl.EventCb(on_EdgeUpEvt_NativeCallback);
      evt_EdgeDownEvt_delegate = new Efl.EventCb(on_EdgeDownEvt_NativeCallback);
      evt_EdgeLeftEvt_delegate = new Efl.EventCb(on_EdgeLeftEvt_NativeCallback);
      evt_EdgeRightEvt_delegate = new Efl.EventCb(on_EdgeRightEvt_NativeCallback);
      evt_ScrollAnimStartEvt_delegate = new Efl.EventCb(on_ScrollAnimStartEvt_NativeCallback);
      evt_ScrollAnimStopEvt_delegate = new Efl.EventCb(on_ScrollAnimStopEvt_NativeCallback);
      evt_ScrollDragStartEvt_delegate = new Efl.EventCb(on_ScrollDragStartEvt_NativeCallback);
      evt_ScrollDragStopEvt_delegate = new Efl.EventCb(on_ScrollDragStopEvt_NativeCallback);
      evt_RedirectChangedEvt_delegate = new Efl.EventCb(on_RedirectChangedEvt_NativeCallback);
      evt_FlushPreEvt_delegate = new Efl.EventCb(on_FlushPreEvt_NativeCallback);
      evt_CoordsDirtyEvt_delegate = new Efl.EventCb(on_CoordsDirtyEvt_NativeCallback);
      evt_Manager_focusChangedEvt_delegate = new Efl.EventCb(on_Manager_focusChangedEvt_NativeCallback);
      evt_Dirty_logic_freezeChangedEvt_delegate = new Efl.EventCb(on_Dirty_logic_freezeChangedEvt_NativeCallback);
   }
   /// <summary>Control scrolling gravity on the scrollable
   /// The gravity defines how the scroller will adjust its view when the size of the scroller contents increases.
   /// 
   /// The scroller will adjust the view to glue itself as follows.
   /// 
   /// x=0.0, for staying where it is relative to the left edge of the content x=1.0, for staying where it is relative to the right edge of the content y=0.0, for staying where it is relative to the top edge of the content y=1.0, for staying where it is relative to the bottom edge of the content
   /// 
   /// Default values for x and y are 0.0</summary>
   /// <param name="x">Horizontal scrolling gravity</param>
   /// <param name="y">Vertical scrolling gravity</param>
   /// <returns></returns>
   public  void GetGravity( out double x,  out double y) {
                                           Elm.InterfaceScrollableNativeInherit.elm_interface_scrollable_gravity_get_ptr.Value.Delegate(this.NativeHandle, out x,  out y);
      Eina.Error.RaiseIfUnhandledException();
                               }
   /// <summary>Control scrolling gravity on the scrollable
   /// The gravity defines how the scroller will adjust its view when the size of the scroller contents increases.
   /// 
   /// The scroller will adjust the view to glue itself as follows.
   /// 
   /// x=0.0, for staying where it is relative to the left edge of the content x=1.0, for staying where it is relative to the right edge of the content y=0.0, for staying where it is relative to the top edge of the content y=1.0, for staying where it is relative to the bottom edge of the content
   /// 
   /// Default values for x and y are 0.0</summary>
   /// <param name="x">Horizontal scrolling gravity</param>
   /// <param name="y">Vertical scrolling gravity</param>
   /// <returns></returns>
   public  void SetGravity( double x,  double y) {
                                           Elm.InterfaceScrollableNativeInherit.elm_interface_scrollable_gravity_set_ptr.Value.Delegate(this.NativeHandle, x,  y);
      Eina.Error.RaiseIfUnhandledException();
                               }
   /// <summary>Bouncing behavior
   /// When scrolling, the scroller may &quot;bounce&quot; when reaching an edge of the content object. This is a visual way to indicate the end has been reached. This is enabled by default for both axis. This API will set if it is enabled for the given axis with the boolean parameters for each axis.</summary>
   /// <param name="horiz">Horizontal bounce policy.</param>
   /// <param name="vert">Vertical bounce policy.</param>
   /// <returns></returns>
   public  void GetBounceAllow( out bool horiz,  out bool vert) {
                                           Elm.InterfaceScrollableNativeInherit.elm_interface_scrollable_bounce_allow_get_ptr.Value.Delegate(this.NativeHandle, out horiz,  out vert);
      Eina.Error.RaiseIfUnhandledException();
                               }
   /// <summary>Bouncing behavior
   /// When scrolling, the scroller may &quot;bounce&quot; when reaching an edge of the content object. This is a visual way to indicate the end has been reached. This is enabled by default for both axis. This API will set if it is enabled for the given axis with the boolean parameters for each axis.</summary>
   /// <param name="horiz">Horizontal bounce policy.</param>
   /// <param name="vert">Vertical bounce policy.</param>
   /// <returns></returns>
   public  void SetBounceAllow( bool horiz,  bool vert) {
                                           Elm.InterfaceScrollableNativeInherit.elm_interface_scrollable_bounce_allow_set_ptr.Value.Delegate(this.NativeHandle, horiz,  vert);
      Eina.Error.RaiseIfUnhandledException();
                               }
   /// <summary>Control Wheel disable Enable or disable mouse wheel to be used to scroll the scroller content. heel is enabled by default.</summary>
   /// <returns><c>true</c> if wheel is disabled, <c>false</c> otherwise</returns>
   public bool GetWheelDisabled() {
       var _ret_var = Elm.InterfaceScrollableNativeInherit.elm_interface_scrollable_wheel_disabled_get_ptr.Value.Delegate(this.NativeHandle);
      Eina.Error.RaiseIfUnhandledException();
      return _ret_var;
 }
   /// <summary>Control Wheel disable Enable or disable mouse wheel to be used to scroll the scroller content. heel is enabled by default.</summary>
   /// <param name="disabled"><c>true</c> if wheel is disabled, <c>false</c> otherwise</param>
   /// <returns></returns>
   public  void SetWheelDisabled( bool disabled) {
                         Elm.InterfaceScrollableNativeInherit.elm_interface_scrollable_wheel_disabled_set_ptr.Value.Delegate(this.NativeHandle, disabled);
      Eina.Error.RaiseIfUnhandledException();
                   }
   /// <summary>Blocking of scrolling (per axis)
   /// This function will block scrolling movement (by input of a user) in a given direction. One can disable movements in the X axis, the Y axis or both. The default value is <c>none</c>, where movements are allowed in both directions.
   /// 
   /// What makes this function different from freeze_push(), hold_push() and lock_x_set() (or lock_y_set()) is that it doesn&apos;t propagate its effects to any parent or child widget of <c>obj</c>. Only the target scrollable widget will be locked with regard to scrolling.</summary>
   /// <returns>Which axis (or axes) to block</returns>
   public Efl.Ui.ScrollBlock GetMovementBlock() {
       var _ret_var = Elm.InterfaceScrollableNativeInherit.elm_interface_scrollable_movement_block_get_ptr.Value.Delegate(this.NativeHandle);
      Eina.Error.RaiseIfUnhandledException();
      return _ret_var;
 }
   /// <summary>Blocking of scrolling (per axis)
   /// This function will block scrolling movement (by input of a user) in a given direction. One can disable movements in the X axis, the Y axis or both. The default value is <c>none</c>, where movements are allowed in both directions.
   /// 
   /// What makes this function different from freeze_push(), hold_push() and lock_x_set() (or lock_y_set()) is that it doesn&apos;t propagate its effects to any parent or child widget of <c>obj</c>. Only the target scrollable widget will be locked with regard to scrolling.</summary>
   /// <param name="block">Which axis (or axes) to block</param>
   /// <returns></returns>
   public  void SetMovementBlock( Efl.Ui.ScrollBlock block) {
                         Elm.InterfaceScrollableNativeInherit.elm_interface_scrollable_movement_block_set_ptr.Value.Delegate(this.NativeHandle, block);
      Eina.Error.RaiseIfUnhandledException();
                   }
   /// <summary>Momentum animator</summary>
   /// <returns><c>true</c> if disabled, <c>false</c> otherwise</returns>
   public bool GetMomentumAnimatorDisabled() {
       var _ret_var = Elm.InterfaceScrollableNativeInherit.elm_interface_scrollable_momentum_animator_disabled_get_ptr.Value.Delegate(this.NativeHandle);
      Eina.Error.RaiseIfUnhandledException();
      return _ret_var;
 }
   /// <summary>Momentum animator</summary>
   /// <param name="disabled"><c>true</c> if disabled, <c>false</c> otherwise</param>
   /// <returns></returns>
   public  void SetMomentumAnimatorDisabled( bool disabled) {
                         Elm.InterfaceScrollableNativeInherit.elm_interface_scrollable_momentum_animator_disabled_set_ptr.Value.Delegate(this.NativeHandle, disabled);
      Eina.Error.RaiseIfUnhandledException();
                   }
   /// <summary>Scrollbar visibility policy
   /// #ELM_SCROLLER_POLICY_AUTO means the scrollbar is made visible if it is needed, and otherwise kept hidden. #ELM_SCROLLER_POLICY_ON turns it on all the time, and #ELM_SCROLLER_POLICY_OFF always keeps it off. This applies respectively for the horizontal and vertical scrollbars.</summary>
   /// <param name="hbar">Horizontal scrollbar policy</param>
   /// <param name="vbar">Vertical scrollbar policy</param>
   /// <returns></returns>
   public  void GetPolicy( out Elm.Scroller.Policy hbar,  out Elm.Scroller.Policy vbar) {
                                           Elm.InterfaceScrollableNativeInherit.elm_interface_scrollable_policy_get_ptr.Value.Delegate(this.NativeHandle, out hbar,  out vbar);
      Eina.Error.RaiseIfUnhandledException();
                               }
   /// <summary>Scrollbar visibility policy
   /// #ELM_SCROLLER_POLICY_AUTO means the scrollbar is made visible if it is needed, and otherwise kept hidden. #ELM_SCROLLER_POLICY_ON turns it on all the time, and #ELM_SCROLLER_POLICY_OFF always keeps it off. This applies respectively for the horizontal and vertical scrollbars.</summary>
   /// <param name="hbar">Horizontal scrollbar policy</param>
   /// <param name="vbar">Vertical scrollbar policy</param>
   /// <returns></returns>
   public  void SetPolicy( Elm.Scroller.Policy hbar,  Elm.Scroller.Policy vbar) {
                                           Elm.InterfaceScrollableNativeInherit.elm_interface_scrollable_policy_set_ptr.Value.Delegate(this.NativeHandle, hbar,  vbar);
      Eina.Error.RaiseIfUnhandledException();
                               }
   /// <summary>Currently visible content region
   /// This gets the current region in the content object that is visible through the scroller. The region co-ordinates are returned in the <c>x</c>, <c>y</c>, <c>w</c>, <c>h</c> values pointed to.
   /// 
   /// Note: All coordinates are relative to the content.
   /// 
   /// See: <see cref="Elm.InterfaceScrollable.ShowContentRegion"/>.</summary>
   /// <param name="x">X coordinate of the region</param>
   /// <param name="y">Y coordinate of the region</param>
   /// <param name="w">Width of the region</param>
   /// <param name="h">Height of the region</param>
   /// <returns></returns>
   public  void GetContentRegion( out  int x,  out  int y,  out  int w,  out  int h) {
                                                                               Elm.InterfaceScrollableNativeInherit.elm_interface_scrollable_content_region_get_ptr.Value.Delegate(this.NativeHandle, out x,  out y,  out w,  out h);
      Eina.Error.RaiseIfUnhandledException();
                                                       }
   /// <summary>Currently visible content region
   /// This gets the current region in the content object that is visible through the scroller. The region co-ordinates are returned in the <c>x</c>, <c>y</c>, <c>w</c>, <c>h</c> values pointed to.
   /// 
   /// Note: All coordinates are relative to the content.
   /// 
   /// See: <see cref="Elm.InterfaceScrollable.ShowContentRegion"/>.</summary>
   /// <param name="x">X coordinate of the region</param>
   /// <param name="y">Y coordinate of the region</param>
   /// <param name="w">Width of the region</param>
   /// <param name="h">Height of the region</param>
   /// <returns></returns>
   public  void SetContentRegion(  int x,   int y,   int w,   int h) {
                                                                               Elm.InterfaceScrollableNativeInherit.elm_interface_scrollable_content_region_set_ptr.Value.Delegate(this.NativeHandle, x,  y,  w,  h);
      Eina.Error.RaiseIfUnhandledException();
                                                       }
   /// <summary>It decides whether the scrollable object propagates the events to content object or not.</summary>
   /// <returns><c>true</c> if events are propagated, <c>false</c> otherwise</returns>
   public bool GetContentEvents() {
       var _ret_var = Elm.InterfaceScrollableNativeInherit.elm_interface_scrollable_content_events_get_ptr.Value.Delegate(this.NativeHandle);
      Eina.Error.RaiseIfUnhandledException();
      return _ret_var;
 }
   /// <summary>It decides whether the scrollable object propagates the events to content object or not.</summary>
   /// <param name="repeat_events"><c>true</c> if events are propagated, <c>false</c> otherwise</param>
   /// <returns></returns>
   public  void SetContentEvents( bool repeat_events) {
                         Elm.InterfaceScrollableNativeInherit.elm_interface_scrollable_content_events_set_ptr.Value.Delegate(this.NativeHandle, repeat_events);
      Eina.Error.RaiseIfUnhandledException();
                   }
   /// <summary>Scroll page size relative to viewport size.
   /// The scroller is capable of limiting scrolling by the user to &quot;pages&quot;. That is to jump by and only show a &quot;whole page&quot; at a time as if the continuous area of the scroller content is split into page sized pieces. This sets the size of a page relative to the viewport of the scroller. 1.0 is &quot;1 viewport&quot; is size (horizontally or vertically). 0.0 turns it off in that axis. This is mutually exclusive with page size (see <see cref="Elm.InterfaceScrollable.GetPageSize"/> for more information). Likewise 0.5 is &quot;half a viewport&quot;. Sane usable values are normally between 0.0 and 1.0 including 1.0. If you only want 1 axis to be page &quot;limited&quot;, use 0.0 for the other axis.</summary>
   /// <param name="x">The horizontal page relative size</param>
   /// <param name="y">The vertical page relative size</param>
   /// <returns></returns>
   public  void GetPageSize( out  int x,  out  int y) {
                                           Elm.InterfaceScrollableNativeInherit.elm_interface_scrollable_page_size_get_ptr.Value.Delegate(this.NativeHandle, out x,  out y);
      Eina.Error.RaiseIfUnhandledException();
                               }
   /// <summary>Scroll page size relative to viewport size.
   /// The scroller is capable of limiting scrolling by the user to &quot;pages&quot;. That is to jump by and only show a &quot;whole page&quot; at a time as if the continuous area of the scroller content is split into page sized pieces. This sets the size of a page relative to the viewport of the scroller. 1.0 is &quot;1 viewport&quot; is size (horizontally or vertically). 0.0 turns it off in that axis. This is mutually exclusive with page size (see <see cref="Elm.InterfaceScrollable.GetPageSize"/> for more information). Likewise 0.5 is &quot;half a viewport&quot;. Sane usable values are normally between 0.0 and 1.0 including 1.0. If you only want 1 axis to be page &quot;limited&quot;, use 0.0 for the other axis.</summary>
   /// <param name="x">The horizontal page relative size</param>
   /// <param name="y">The vertical page relative size</param>
   /// <returns></returns>
   public  void SetPageSize(  int x,   int y) {
                                           Elm.InterfaceScrollableNativeInherit.elm_interface_scrollable_page_size_set_ptr.Value.Delegate(this.NativeHandle, x,  y);
      Eina.Error.RaiseIfUnhandledException();
                               }
   /// <summary>Bounce animator</summary>
   /// <returns><c>true</c> if bounce animation is disabled, <c>false</c> otherwise</returns>
   public bool GetBounceAnimatorDisabled() {
       var _ret_var = Elm.InterfaceScrollableNativeInherit.elm_interface_scrollable_bounce_animator_disabled_get_ptr.Value.Delegate(this.NativeHandle);
      Eina.Error.RaiseIfUnhandledException();
      return _ret_var;
 }
   /// <summary>Bounce animator</summary>
   /// <param name="disabled"><c>true</c> if bounce animation is disabled, <c>false</c> otherwise</param>
   /// <returns></returns>
   public  void SetBounceAnimatorDisabled( bool disabled) {
                         Elm.InterfaceScrollableNativeInherit.elm_interface_scrollable_bounce_animator_disabled_set_ptr.Value.Delegate(this.NativeHandle, disabled);
      Eina.Error.RaiseIfUnhandledException();
                   }
   /// <summary>Page scroll limit</summary>
   /// <param name="page_limit_h">Page limit horizontal</param>
   /// <param name="page_limit_v">Page limit vertical</param>
   /// <returns></returns>
   public  void GetPageScrollLimit( out  int page_limit_h,  out  int page_limit_v) {
                                           Elm.InterfaceScrollableNativeInherit.elm_interface_scrollable_page_scroll_limit_get_ptr.Value.Delegate(this.NativeHandle, out page_limit_h,  out page_limit_v);
      Eina.Error.RaiseIfUnhandledException();
                               }
   /// <summary>Page scroll limit</summary>
   /// <param name="page_limit_h">Page limit horizontal</param>
   /// <param name="page_limit_v">Page limit vertical</param>
   /// <returns></returns>
   public  void SetPageScrollLimit(  int page_limit_h,   int page_limit_v) {
                                           Elm.InterfaceScrollableNativeInherit.elm_interface_scrollable_page_scroll_limit_set_ptr.Value.Delegate(this.NativeHandle, page_limit_h,  page_limit_v);
      Eina.Error.RaiseIfUnhandledException();
                               }
   /// <summary>Page snapping behavior
   /// When scrolling, if a scroller is paged (see elm_scroller_page_size_set() and elm_scroller_page_relative_set()), the scroller may snap to pages when being scrolled, i.e., even if it had momentum to scroll further, it will stop at the next page boundaries. This is disabled, by default, for both axis. This function will set if it that is enabled or not, for each axis.
   /// 
   /// Note: If <c>obj</c> is not set to have pages, nothing will happen after this call.
   /// 1.8</summary>
   /// <param name="horiz">Allow snap horizontally</param>
   /// <param name="vert">Allow snap vertically</param>
   /// <returns></returns>
   public  void GetPageSnapAllow( out bool horiz,  out bool vert) {
                                           Elm.InterfaceScrollableNativeInherit.elm_interface_scrollable_page_snap_allow_get_ptr.Value.Delegate(this.NativeHandle, out horiz,  out vert);
      Eina.Error.RaiseIfUnhandledException();
                               }
   /// <summary>Page snapping behavior
   /// When scrolling, if a scroller is paged (see elm_scroller_page_size_set() and elm_scroller_page_relative_set()), the scroller may snap to pages when being scrolled, i.e., even if it had momentum to scroll further, it will stop at the next page boundaries. This is disabled, by default, for both axis. This function will set if it that is enabled or not, for each axis.
   /// 
   /// Note: If <c>obj</c> is not set to have pages, nothing will happen after this call.
   /// 1.8</summary>
   /// <param name="horiz">Allow snap horizontally</param>
   /// <param name="vert">Allow snap vertically</param>
   /// <returns></returns>
   public  void SetPageSnapAllow( bool horiz,  bool vert) {
                                           Elm.InterfaceScrollableNativeInherit.elm_interface_scrollable_page_snap_allow_set_ptr.Value.Delegate(this.NativeHandle, horiz,  vert);
      Eina.Error.RaiseIfUnhandledException();
                               }
   /// <summary>Pagin property</summary>
   /// <param name="pagerel_h">Page relation horizontal</param>
   /// <param name="pagerel_v">Page relation vertical</param>
   /// <param name="pagesize_h">Page size horizontal</param>
   /// <param name="pagesize_v">Page size vertical</param>
   /// <returns></returns>
   public  void GetPaging( out double pagerel_h,  out double pagerel_v,  out  int pagesize_h,  out  int pagesize_v) {
                                                                               Elm.InterfaceScrollableNativeInherit.elm_interface_scrollable_paging_get_ptr.Value.Delegate(this.NativeHandle, out pagerel_h,  out pagerel_v,  out pagesize_h,  out pagesize_v);
      Eina.Error.RaiseIfUnhandledException();
                                                       }
   /// <summary>Pagin property</summary>
   /// <param name="pagerel_h">Page relation horizontal</param>
   /// <param name="pagerel_v">Page relation vertical</param>
   /// <param name="pagesize_h">Page size horizontal</param>
   /// <param name="pagesize_v">Page size vertical</param>
   /// <returns></returns>
   public  void SetPaging( double pagerel_h,  double pagerel_v,   int pagesize_h,   int pagesize_v) {
                                                                               Elm.InterfaceScrollableNativeInherit.elm_interface_scrollable_paging_set_ptr.Value.Delegate(this.NativeHandle, pagerel_h,  pagerel_v,  pagesize_h,  pagesize_v);
      Eina.Error.RaiseIfUnhandledException();
                                                       }
   /// <summary>Single direction scroll configuration
   /// This makes it possible to restrict scrolling to a single direction, with a &quot;soft&quot; or &quot;hard&quot; behavior.
   /// 
   /// The hard behavior restricts the scrolling to a single direction all of the time while the soft one will restrict depending on factors such as the movement angle. If the user scrolls roughly in one direction only, it will only move according to it while if the move was clearly wanted on both axes, it will happen on both of them.
   /// 1.8</summary>
   /// <returns>The single direction scroll policy</returns>
   public Elm.Scroller.SingleDirection GetSingleDirection() {
       var _ret_var = Elm.InterfaceScrollableNativeInherit.elm_interface_scrollable_single_direction_get_ptr.Value.Delegate(this.NativeHandle);
      Eina.Error.RaiseIfUnhandledException();
      return _ret_var;
 }
   /// <summary>Single direction scroll configuration
   /// This makes it possible to restrict scrolling to a single direction, with a &quot;soft&quot; or &quot;hard&quot; behavior.
   /// 
   /// The hard behavior restricts the scrolling to a single direction all of the time while the soft one will restrict depending on factors such as the movement angle. If the user scrolls roughly in one direction only, it will only move according to it while if the move was clearly wanted on both axes, it will happen on both of them.
   /// 1.8</summary>
   /// <param name="single_dir">The single direction scroll policy</param>
   /// <returns></returns>
   public  void SetSingleDirection( Elm.Scroller.SingleDirection single_dir) {
                         Elm.InterfaceScrollableNativeInherit.elm_interface_scrollable_single_direction_set_ptr.Value.Delegate(this.NativeHandle, single_dir);
      Eina.Error.RaiseIfUnhandledException();
                   }
   /// <summary>Step size</summary>
   /// <param name="x">X coordinate</param>
   /// <param name="y">Y coordinate</param>
   /// <returns></returns>
   public  void GetStepSize( out  int x,  out  int y) {
                                           Elm.InterfaceScrollableNativeInherit.elm_interface_scrollable_step_size_get_ptr.Value.Delegate(this.NativeHandle, out x,  out y);
      Eina.Error.RaiseIfUnhandledException();
                               }
   /// <summary>Step size</summary>
   /// <param name="x">X coordinate</param>
   /// <param name="y">Y coordinate</param>
   /// <returns></returns>
   public  void SetStepSize(  int x,   int y) {
                                           Elm.InterfaceScrollableNativeInherit.elm_interface_scrollable_step_size_set_ptr.Value.Delegate(this.NativeHandle, x,  y);
      Eina.Error.RaiseIfUnhandledException();
                               }
   /// <summary>Controls an infinite loop for a scroller.
   /// 1.14</summary>
   /// <param name="loop_h">The scrolling horizontal loop</param>
   /// <param name="loop_v">The scrolling vertical loop</param>
   /// <returns></returns>
   public  void GetContentLoop( out bool loop_h,  out bool loop_v) {
                                           Elm.InterfaceScrollableNativeInherit.elm_interface_scrollable_content_loop_get_ptr.Value.Delegate(this.NativeHandle, out loop_h,  out loop_v);
      Eina.Error.RaiseIfUnhandledException();
                               }
   /// <summary>Controls an infinite loop for a scroller.
   /// 1.14</summary>
   /// <param name="loop_h">The scrolling horizontal loop</param>
   /// <param name="loop_v">The scrolling vertical loop</param>
   /// <returns></returns>
   public  void SetContentLoop( bool loop_h,  bool loop_v) {
                                           Elm.InterfaceScrollableNativeInherit.elm_interface_scrollable_content_loop_set_ptr.Value.Delegate(this.NativeHandle, loop_h,  loop_v);
      Eina.Error.RaiseIfUnhandledException();
                               }
   /// <summary>Set the callback to run when the content has been moved up.</summary>
   /// <param name="scroll_up_cb">The callback</param>
   /// <returns></returns>
   public  void SetScrollUpCb( ElmInterfaceScrollableCb scroll_up_cb) {
                         Elm.InterfaceScrollableNativeInherit.elm_interface_scrollable_scroll_up_cb_set_ptr.Value.Delegate(this.NativeHandle, scroll_up_cb);
      Eina.Error.RaiseIfUnhandledException();
                   }
   /// <summary>Set the callback to run when the horizontal scrollbar is dragged.</summary>
   /// <param name="hbar_drag_cb">The callback</param>
   /// <returns></returns>
   public  void SetHbarDragCb( ElmInterfaceScrollableCb hbar_drag_cb) {
                         Elm.InterfaceScrollableNativeInherit.elm_interface_scrollable_hbar_drag_cb_set_ptr.Value.Delegate(this.NativeHandle, hbar_drag_cb);
      Eina.Error.RaiseIfUnhandledException();
                   }
   /// <summary>Set the callback to run when dragging of the contents has started.</summary>
   /// <param name="drag_start_cb">The callback</param>
   /// <returns></returns>
   public  void SetDragStartCb( ElmInterfaceScrollableCb drag_start_cb) {
                         Elm.InterfaceScrollableNativeInherit.elm_interface_scrollable_drag_start_cb_set_ptr.Value.Delegate(this.NativeHandle, drag_start_cb);
      Eina.Error.RaiseIfUnhandledException();
                   }
   /// <summary>Set the callback to run when scrolling of the contents has started.</summary>
   /// <param name="scroll_start_cb">The callback</param>
   /// <returns></returns>
   public  void SetScrollStartCb( ElmInterfaceScrollableCb scroll_start_cb) {
                         Elm.InterfaceScrollableNativeInherit.elm_interface_scrollable_scroll_start_cb_set_ptr.Value.Delegate(this.NativeHandle, scroll_start_cb);
      Eina.Error.RaiseIfUnhandledException();
                   }
   /// <summary>Freeze property</summary>
   /// <param name="freeze"><c>true</c> if freeze, <c>false</c> otherwise</param>
   /// <returns></returns>
   public  void SetFreeze( bool freeze) {
                         Elm.InterfaceScrollableNativeInherit.elm_interface_scrollable_freeze_set_ptr.Value.Delegate(this.NativeHandle, freeze);
      Eina.Error.RaiseIfUnhandledException();
                   }
   /// <summary>When the viewport is resized, the callback is called.</summary>
   /// <param name="viewport_resize_cb">The callback</param>
   /// <returns></returns>
   public  void SetContentViewportResizeCb( ElmInterfaceScrollableResizeCb viewport_resize_cb) {
                         Elm.InterfaceScrollableNativeInherit.elm_interface_scrollable_content_viewport_resize_cb_set_ptr.Value.Delegate(this.NativeHandle, viewport_resize_cb);
      Eina.Error.RaiseIfUnhandledException();
                   }
   /// <summary>Set the callback to run when the content has been moved to the left</summary>
   /// <param name="scroll_left_cb">The callback</param>
   /// <returns></returns>
   public  void SetScrollLeftCb( ElmInterfaceScrollableCb scroll_left_cb) {
                         Elm.InterfaceScrollableNativeInherit.elm_interface_scrollable_scroll_left_cb_set_ptr.Value.Delegate(this.NativeHandle, scroll_left_cb);
      Eina.Error.RaiseIfUnhandledException();
                   }
   /// <summary>Set the callback to run when the vertical scrollbar is pressed.</summary>
   /// <param name="vbar_press_cb">The callback</param>
   /// <returns></returns>
   public  void SetVbarPressCb( ElmInterfaceScrollableCb vbar_press_cb) {
                         Elm.InterfaceScrollableNativeInherit.elm_interface_scrollable_vbar_press_cb_set_ptr.Value.Delegate(this.NativeHandle, vbar_press_cb);
      Eina.Error.RaiseIfUnhandledException();
                   }
   /// <summary>Set the callback to run when the horizontal scrollbar is pressed.</summary>
   /// <param name="hbar_press_cb">The callback</param>
   /// <returns></returns>
   public  void SetHbarPressCb( ElmInterfaceScrollableCb hbar_press_cb) {
                         Elm.InterfaceScrollableNativeInherit.elm_interface_scrollable_hbar_press_cb_set_ptr.Value.Delegate(this.NativeHandle, hbar_press_cb);
      Eina.Error.RaiseIfUnhandledException();
                   }
   /// <summary>Set the callback to run when the horizontal scrollbar is unpressed.</summary>
   /// <param name="hbar_unpress_cb">The callback</param>
   /// <returns></returns>
   public  void SetHbarUnpressCb( ElmInterfaceScrollableCb hbar_unpress_cb) {
                         Elm.InterfaceScrollableNativeInherit.elm_interface_scrollable_hbar_unpress_cb_set_ptr.Value.Delegate(this.NativeHandle, hbar_unpress_cb);
      Eina.Error.RaiseIfUnhandledException();
                   }
   /// <summary>Set the callback to run when dragging of the contents has stopped.</summary>
   /// <param name="drag_stop_cb">The callback</param>
   /// <returns></returns>
   public  void SetDragStopCb( ElmInterfaceScrollableCb drag_stop_cb) {
                         Elm.InterfaceScrollableNativeInherit.elm_interface_scrollable_drag_stop_cb_set_ptr.Value.Delegate(this.NativeHandle, drag_stop_cb);
      Eina.Error.RaiseIfUnhandledException();
                   }
   /// <summary>Set the callback to run when scrolling of the contents has stopped.</summary>
   /// <param name="scroll_stop_cb">The callback</param>
   /// <returns></returns>
   public  void SetScrollStopCb( ElmInterfaceScrollableCb scroll_stop_cb) {
                         Elm.InterfaceScrollableNativeInherit.elm_interface_scrollable_scroll_stop_cb_set_ptr.Value.Delegate(this.NativeHandle, scroll_stop_cb);
      Eina.Error.RaiseIfUnhandledException();
                   }
   /// <summary>Extern pan</summary>
   /// <param name="pan">Pan object</param>
   /// <returns></returns>
   public  void SetExternPan( Efl.Canvas.Object pan) {
                         Elm.InterfaceScrollableNativeInherit.elm_interface_scrollable_extern_pan_set_ptr.Value.Delegate(this.NativeHandle, pan);
      Eina.Error.RaiseIfUnhandledException();
                   }
   /// <summary>Set the callback to run when the visible page changes.</summary>
   /// <param name="page_change_cb">The callback</param>
   /// <returns></returns>
   public  void SetPageChangeCb( ElmInterfaceScrollableCb page_change_cb) {
                         Elm.InterfaceScrollableNativeInherit.elm_interface_scrollable_page_change_cb_set_ptr.Value.Delegate(this.NativeHandle, page_change_cb);
      Eina.Error.RaiseIfUnhandledException();
                   }
   /// <summary>Hold property</summary>
   /// <param name="hold"><c>true</c> if hold, <c>false</c> otherwise</param>
   /// <returns></returns>
   public  void SetHold( bool hold) {
                         Elm.InterfaceScrollableNativeInherit.elm_interface_scrollable_hold_set_ptr.Value.Delegate(this.NativeHandle, hold);
      Eina.Error.RaiseIfUnhandledException();
                   }
   /// <summary>Set the callback to run when the scrolling animation has started.</summary>
   /// <param name="animate_start_cb">The callback</param>
   /// <returns></returns>
   public  void SetAnimateStartCb( ElmInterfaceScrollableCb animate_start_cb) {
                         Elm.InterfaceScrollableNativeInherit.elm_interface_scrollable_animate_start_cb_set_ptr.Value.Delegate(this.NativeHandle, animate_start_cb);
      Eina.Error.RaiseIfUnhandledException();
                   }
   /// <summary>Set the callback to run when the content has been moved down.</summary>
   /// <param name="scroll_down_cb">The callback</param>
   /// <returns></returns>
   public  void SetScrollDownCb( ElmInterfaceScrollableCb scroll_down_cb) {
                         Elm.InterfaceScrollableNativeInherit.elm_interface_scrollable_scroll_down_cb_set_ptr.Value.Delegate(this.NativeHandle, scroll_down_cb);
      Eina.Error.RaiseIfUnhandledException();
                   }
   /// <summary>Set scroll page size relative to viewport size.</summary>
   /// <param name="h_pagerel">Page relation horizontal</param>
   /// <param name="v_pagerel">Page relation vertical</param>
   /// <returns></returns>
   public  void SetPageRelative( double h_pagerel,  double v_pagerel) {
                                           Elm.InterfaceScrollableNativeInherit.elm_interface_scrollable_page_relative_set_ptr.Value.Delegate(this.NativeHandle, h_pagerel,  v_pagerel);
      Eina.Error.RaiseIfUnhandledException();
                               }
   /// <summary>Set the callback to run when the content has been moved.</summary>
   /// <param name="scroll_cb">The callback</param>
   /// <returns></returns>
   public  void SetScrollCb( ElmInterfaceScrollableCb scroll_cb) {
                         Elm.InterfaceScrollableNativeInherit.elm_interface_scrollable_scroll_cb_set_ptr.Value.Delegate(this.NativeHandle, scroll_cb);
      Eina.Error.RaiseIfUnhandledException();
                   }
   /// <summary>Set the callback to run when the scrolling animation has stopped.</summary>
   /// <param name="animate_stop_cb">The callback</param>
   /// <returns></returns>
   public  void SetAnimateStopCb( ElmInterfaceScrollableCb animate_stop_cb) {
                         Elm.InterfaceScrollableNativeInherit.elm_interface_scrollable_animate_stop_cb_set_ptr.Value.Delegate(this.NativeHandle, animate_stop_cb);
      Eina.Error.RaiseIfUnhandledException();
                   }
   /// <summary>set the callback to run on minimal limit content</summary>
   /// <param name="min_limit_cb">The callback</param>
   /// <returns></returns>
   public  void SetContentMinLimitCb( ElmInterfaceScrollableMinLimitCb min_limit_cb) {
                         Elm.InterfaceScrollableNativeInherit.elm_interface_scrollable_content_min_limit_cb_set_ptr.Value.Delegate(this.NativeHandle, min_limit_cb);
      Eina.Error.RaiseIfUnhandledException();
                   }
   /// <summary>Set the callback to run when the content has been moved to the right.</summary>
   /// <param name="scroll_right_cb">The callback</param>
   /// <returns></returns>
   public  void SetScrollRightCb( ElmInterfaceScrollableCb scroll_right_cb) {
                         Elm.InterfaceScrollableNativeInherit.elm_interface_scrollable_scroll_right_cb_set_ptr.Value.Delegate(this.NativeHandle, scroll_right_cb);
      Eina.Error.RaiseIfUnhandledException();
                   }
   /// <summary>Content property</summary>
   /// <param name="content">Content object</param>
   /// <returns></returns>
   public  void SetScrollableContent( Efl.Canvas.Object content) {
                         Elm.InterfaceScrollableNativeInherit.elm_interface_scrollable_content_set_ptr.Value.Delegate(this.NativeHandle, content);
      Eina.Error.RaiseIfUnhandledException();
                   }
   /// <summary>Set the callback to run when the left edge of the content has been reached.</summary>
   /// <param name="edge_left_cb">The callback</param>
   /// <returns></returns>
   public  void SetEdgeLeftCb( ElmInterfaceScrollableCb edge_left_cb) {
                         Elm.InterfaceScrollableNativeInherit.elm_interface_scrollable_edge_left_cb_set_ptr.Value.Delegate(this.NativeHandle, edge_left_cb);
      Eina.Error.RaiseIfUnhandledException();
                   }
   /// <summary>Set the callback to run when the horizontal scrollbar is dragged.</summary>
   /// <param name="vbar_drag_cb">The callback</param>
   /// <returns></returns>
   public  void SetVbarDragCb( ElmInterfaceScrollableCb vbar_drag_cb) {
                         Elm.InterfaceScrollableNativeInherit.elm_interface_scrollable_vbar_drag_cb_set_ptr.Value.Delegate(this.NativeHandle, vbar_drag_cb);
      Eina.Error.RaiseIfUnhandledException();
                   }
   /// <summary>Set the callback to run when the horizontal scrollbar is unpressed.</summary>
   /// <param name="vbar_unpress_cb">The callback</param>
   /// <returns></returns>
   public  void SetVbarUnpressCb( ElmInterfaceScrollableCb vbar_unpress_cb) {
                         Elm.InterfaceScrollableNativeInherit.elm_interface_scrollable_vbar_unpress_cb_set_ptr.Value.Delegate(this.NativeHandle, vbar_unpress_cb);
      Eina.Error.RaiseIfUnhandledException();
                   }
   /// <summary>Set the callback to run when the bottom edge of the content has been reached.</summary>
   /// <param name="edge_bottom_cb">The callback</param>
   /// <returns></returns>
   public  void SetEdgeBottomCb( ElmInterfaceScrollableCb edge_bottom_cb) {
                         Elm.InterfaceScrollableNativeInherit.elm_interface_scrollable_edge_bottom_cb_set_ptr.Value.Delegate(this.NativeHandle, edge_bottom_cb);
      Eina.Error.RaiseIfUnhandledException();
                   }
   /// <summary>Set the callback to run when the right edge of the content has been reached.</summary>
   /// <param name="edge_right_cb">The callback</param>
   /// <returns></returns>
   public  void SetEdgeRightCb( ElmInterfaceScrollableCb edge_right_cb) {
                         Elm.InterfaceScrollableNativeInherit.elm_interface_scrollable_edge_right_cb_set_ptr.Value.Delegate(this.NativeHandle, edge_right_cb);
      Eina.Error.RaiseIfUnhandledException();
                   }
   /// <summary>Set the callback to run when the top edge of the content has been reached.</summary>
   /// <param name="edge_top_cb">The callback</param>
   /// <returns></returns>
   public  void SetEdgeTopCb( ElmInterfaceScrollableCb edge_top_cb) {
                         Elm.InterfaceScrollableNativeInherit.elm_interface_scrollable_edge_top_cb_set_ptr.Value.Delegate(this.NativeHandle, edge_top_cb);
      Eina.Error.RaiseIfUnhandledException();
                   }
   /// <summary>Object property</summary>
   /// <param name="edje_object">Edje object</param>
   /// <param name="hit_rectangle">Evas object</param>
   /// <returns></returns>
   public  void SetObjects( Efl.Canvas.Object edje_object,  Efl.Canvas.Object hit_rectangle) {
                                           Elm.InterfaceScrollableNativeInherit.elm_interface_scrollable_objects_set_ptr.Value.Delegate(this.NativeHandle, edje_object,  hit_rectangle);
      Eina.Error.RaiseIfUnhandledException();
                               }
   /// <summary>Get scroll last page number.
   /// The page number starts from 0. 0 is the first page. This returns the last page number among the pages.
   /// 
   /// See: <see cref="Elm.InterfaceScrollable.GetCurrentPage"/>, <see cref="Elm.InterfaceScrollable.ShowPage"/> and <see cref="Elm.InterfaceScrollable.PageBringIn"/>.</summary>
   /// <param name="pagenumber_h">The horizontal page number</param>
   /// <param name="pagenumber_v">The vertical page number</param>
   /// <returns></returns>
   public  void GetLastPage( out  int pagenumber_h,  out  int pagenumber_v) {
                                           Elm.InterfaceScrollableNativeInherit.elm_interface_scrollable_last_page_get_ptr.Value.Delegate(this.NativeHandle, out pagenumber_h,  out pagenumber_v);
      Eina.Error.RaiseIfUnhandledException();
                               }
   /// <summary>Get scroll current page number.
   /// The page number starts from 0. 0 is the first page. Current page means the page which meets the top-left of the viewport. If there are two or more pages in the viewport, it returns the number of the page which meets the top-left of the viewport.
   /// 
   /// See: <see cref="Elm.InterfaceScrollable.GetLastPage"/>, <see cref="Elm.InterfaceScrollable.ShowPage"/> and <see cref="Elm.InterfaceScrollable.PageBringIn"/>.</summary>
   /// <param name="pagenumber_h">The horizontal page number</param>
   /// <param name="pagenumber_v">The vertical page number</param>
   /// <returns></returns>
   public  void GetCurrentPage( out  int pagenumber_h,  out  int pagenumber_v) {
                                           Elm.InterfaceScrollableNativeInherit.elm_interface_scrollable_current_page_get_ptr.Value.Delegate(this.NativeHandle, out pagenumber_h,  out pagenumber_v);
      Eina.Error.RaiseIfUnhandledException();
                               }
   /// <summary>Content viewport geometry</summary>
   /// <param name="x">X coordinate</param>
   /// <param name="y">Y coordinate</param>
   /// <param name="w">Width</param>
   /// <param name="h">Height</param>
   /// <returns></returns>
   public  void GetContentViewportGeometry( out  int x,  out  int y,  out  int w,  out  int h) {
                                                                               Elm.InterfaceScrollableNativeInherit.elm_interface_scrollable_content_viewport_geometry_get_ptr.Value.Delegate(this.NativeHandle, out x,  out y,  out w,  out h);
      Eina.Error.RaiseIfUnhandledException();
                                                       }
   /// <summary>Get the size of the content object
   /// This gets the size of the content object of the scroller.</summary>
   /// <param name="w">Width of the content object.</param>
   /// <param name="h">Height of the content object.</param>
   /// <returns></returns>
   public  void GetContentSize( out  int w,  out  int h) {
                                           Elm.InterfaceScrollableNativeInherit.elm_interface_scrollable_content_size_get_ptr.Value.Delegate(this.NativeHandle, out w,  out h);
      Eina.Error.RaiseIfUnhandledException();
                               }
   /// <summary>Whether scrolling should loop around.</summary>
   /// <returns>True to enable looping.</returns>
   public bool GetItemLoopEnabled() {
       var _ret_var = Elm.InterfaceScrollableNativeInherit.elm_interface_scrollable_item_loop_enabled_get_ptr.Value.Delegate(this.NativeHandle);
      Eina.Error.RaiseIfUnhandledException();
      return _ret_var;
 }
   /// <summary>Whether scrolling should loop around.</summary>
   /// <param name="enable">True to enable looping.</param>
   /// <returns></returns>
   public  void SetItemLoopEnabled( bool enable) {
                         Elm.InterfaceScrollableNativeInherit.elm_interface_scrollable_item_loop_enabled_set_ptr.Value.Delegate(this.NativeHandle, enable);
      Eina.Error.RaiseIfUnhandledException();
                   }
   /// <summary>Set the content position</summary>
   /// <param name="x">X coordinate</param>
   /// <param name="y">Y coordinate</param>
   /// <param name="sig">Send signals to the theme corresponding to the scroll direction, or if an edge was reached.</param>
   /// <returns></returns>
   public  void SetContentPos(  int x,   int y,  bool sig) {
                                                             Elm.InterfaceScrollableNativeInherit.elm_interface_scrollable_content_pos_set_ptr.Value.Delegate(this.NativeHandle, x,  y,  sig);
      Eina.Error.RaiseIfUnhandledException();
                                           }
   /// <summary>Get content position</summary>
   /// <param name="x">X coordinate</param>
   /// <param name="y">Y coordinate</param>
   /// <returns></returns>
   public  void GetContentPos( out  int x,  out  int y) {
                                           Elm.InterfaceScrollableNativeInherit.elm_interface_scrollable_content_pos_get_ptr.Value.Delegate(this.NativeHandle, out x,  out y);
      Eina.Error.RaiseIfUnhandledException();
                               }
   /// <summary>Show a specific virtual region within the scroller content object by page number.
   /// 0, 0 of the indicated page is located at the top-left of the viewport. This will jump to the page directly without animation.
   /// 
   /// See <see cref="Elm.InterfaceScrollable.PageBringIn"/>.</summary>
   /// <param name="pagenumber_h">The horizontal page number</param>
   /// <param name="pagenumber_v">The vertical page number</param>
   /// <returns></returns>
   public  void ShowPage(  int pagenumber_h,   int pagenumber_v) {
                                           Elm.InterfaceScrollableNativeInherit.elm_interface_scrollable_page_show_ptr.Value.Delegate(this.NativeHandle, pagenumber_h,  pagenumber_v);
      Eina.Error.RaiseIfUnhandledException();
                               }
   /// <summary>Show a specific virtual region within the scroller content object.
   /// This will ensure all (or part if it does not fit) of the designated region in the virtual content object (0, 0 starting at the top-left of the virtual content object) is shown within the scroller. Unlike elm_scroller_region_show(), this allows the scroller to &quot;smoothly slide&quot; to this location (if configuration in general calls for transitions). It may not jump immediately to the new location and make take a while and show other content along the way.
   /// 
   /// See <see cref="Elm.InterfaceScrollable.ShowContentRegion"/></summary>
   /// <param name="x">X coordinate of the region</param>
   /// <param name="y">Y coordinate of the region</param>
   /// <param name="w">Width of the region</param>
   /// <param name="h">Height of the region</param>
   /// <returns></returns>
   public  void RegionBringIn(  int x,   int y,   int w,   int h) {
                                                                               Elm.InterfaceScrollableNativeInherit.elm_interface_scrollable_region_bring_in_ptr.Value.Delegate(this.NativeHandle, x,  y,  w,  h);
      Eina.Error.RaiseIfUnhandledException();
                                                       }
   /// <summary>Show a specific virtual region within the scroller content object by page number.
   /// 0, 0 of the indicated page is located at the top-left of the viewport. This will slide to the page with animation.
   /// 
   /// <see cref="Elm.InterfaceScrollable.ShowPage"/></summary>
   /// <param name="pagenumber_h">The horizontal page number</param>
   /// <param name="pagenumber_v">The vertical page number</param>
   /// <returns></returns>
   public  void PageBringIn(  int pagenumber_h,   int pagenumber_v) {
                                           Elm.InterfaceScrollableNativeInherit.elm_interface_scrollable_page_bring_in_ptr.Value.Delegate(this.NativeHandle, pagenumber_h,  pagenumber_v);
      Eina.Error.RaiseIfUnhandledException();
                               }
   /// <summary>Show a specific virtual region within the scroller content object
   /// This will ensure all (or part if it does not fit) of the designated region in the virtual content object (0, 0 starting at the top-left of the virtual content object) is shown within the scroller.</summary>
   /// <param name="x">X coordinate of the region</param>
   /// <param name="y">Y coordinate of the region</param>
   /// <param name="w">Width of the region</param>
   /// <param name="h">Height of the region</param>
   /// <returns></returns>
   public  void ShowContentRegion(  int x,   int y,   int w,   int h) {
                                                                               Elm.InterfaceScrollableNativeInherit.elm_interface_scrollable_content_region_show_ptr.Value.Delegate(this.NativeHandle, x,  y,  w,  h);
      Eina.Error.RaiseIfUnhandledException();
                                                       }
   /// <summary>Prevent the scrollable from being smaller than the minimum size of the content.
   /// By default the scroller will be as small as its design allows, irrespective of its content. This will make the scroller minimum size the right size horizontally and/or vertically to perfectly fit its content in that direction.</summary>
   /// <param name="w">Whether to limit the minimum horizontal size</param>
   /// <param name="h">Whether to limit the minimum vertical size</param>
   /// <returns></returns>
   public  void ContentMinLimit( bool w,  bool h) {
                                           Elm.InterfaceScrollableNativeInherit.elm_interface_scrollable_content_min_limit_ptr.Value.Delegate(this.NativeHandle, w,  h);
      Eina.Error.RaiseIfUnhandledException();
                               }
   /// <summary></summary>
   /// <param name="x"></param>
   /// <param name="y"></param>
   /// <returns></returns>
   public  void SetWantedRegion(  int x,   int y) {
                                           Elm.InterfaceScrollableNativeInherit.elm_interface_scrollable_wanted_region_set_ptr.Value.Delegate(this.NativeHandle, x,  y);
      Eina.Error.RaiseIfUnhandledException();
                               }
   /// <summary></summary>
   /// <param name="x"></param>
   /// <param name="y"></param>
   /// <returns></returns>
   public  void CustomPanPosAdjust(  int x,   int y) {
       var _in_x = Eina.PrimitiveConversion.ManagedToPointerAlloc(x);
      var _in_y = Eina.PrimitiveConversion.ManagedToPointerAlloc(y);
                              Elm.InterfaceScrollableNativeInherit.elm_interface_scrollable_custom_pan_pos_adjust_ptr.Value.Delegate(this.NativeHandle, _in_x,  _in_y);
      Eina.Error.RaiseIfUnhandledException();
                               }
   /// <summary>If the widget needs a focus manager, this function will be called.
   /// It can be used and overriden to inject your own manager or set custom options on the focus manager.</summary>
   /// <param name="root">The logical root object for focus.</param>
   /// <returns>The focus manager.</returns>
   public Efl.Ui.Focus.Manager FocusManagerCreate( Efl.Ui.Focus.Object root) {
                         var _ret_var = Efl.Ui.WidgetFocusManagerNativeInherit.efl_ui_widget_focus_manager_create_ptr.Value.Delegate(this.NativeHandle, root);
      Eina.Error.RaiseIfUnhandledException();
                  return _ret_var;
 }
   /// <summary>The element which is currently focused by this manager
   /// Use this property to retrieve the object currently being focused, or to set the focus to a new one. When <c>focus</c> is a logical child (which cannot receive focus), the next non-logical object is selected instead. If there is no such object, focus does not change.
   /// 1.20</summary>
   /// <returns>Currently focused element.
   /// 1.20</returns>
   public Efl.Ui.Focus.Object GetManagerFocus() {
       var _ret_var = Efl.Ui.Focus.ManagerNativeInherit.efl_ui_focus_manager_focus_get_ptr.Value.Delegate(this.NativeHandle);
      Eina.Error.RaiseIfUnhandledException();
      return _ret_var;
 }
   /// <summary>The element which is currently focused by this manager
   /// Use this property to retrieve the object currently being focused, or to set the focus to a new one. When <c>focus</c> is a logical child (which cannot receive focus), the next non-logical object is selected instead. If there is no such object, focus does not change.
   /// 1.20</summary>
   /// <param name="focus">Currently focused element.
   /// 1.20</param>
   /// <returns></returns>
   public  void SetManagerFocus( Efl.Ui.Focus.Object focus) {
                         Efl.Ui.Focus.ManagerNativeInherit.efl_ui_focus_manager_focus_set_ptr.Value.Delegate(this.NativeHandle, focus);
      Eina.Error.RaiseIfUnhandledException();
                   }
   /// <summary>Add another manager to serve the move requests.
   /// If this value is set, all move requests are redirected to this manager object. Set it to <c>null</c> once nothing should be redirected anymore.
   /// 1.20</summary>
   /// <returns>The redirect manager.
   /// 1.20</returns>
   public Efl.Ui.Focus.Manager GetRedirect() {
       var _ret_var = Efl.Ui.Focus.ManagerNativeInherit.efl_ui_focus_manager_redirect_get_ptr.Value.Delegate(this.NativeHandle);
      Eina.Error.RaiseIfUnhandledException();
      return _ret_var;
 }
   /// <summary>Add another manager to serve the move requests.
   /// If this value is set, all move requests are redirected to this manager object. Set it to <c>null</c> once nothing should be redirected anymore.
   /// 1.20</summary>
   /// <param name="redirect">The redirect manager.
   /// 1.20</param>
   /// <returns></returns>
   public  void SetRedirect( Efl.Ui.Focus.Manager redirect) {
                         Efl.Ui.Focus.ManagerNativeInherit.efl_ui_focus_manager_redirect_set_ptr.Value.Delegate(this.NativeHandle, redirect);
      Eina.Error.RaiseIfUnhandledException();
                   }
   /// <summary>The list of elements which are at the border of the graph.
   /// This means one of the relations right,left or down,up are not set. This call flushes all changes. See <see cref="Efl.Ui.Focus.Manager.Move"/>
   /// 1.20</summary>
   /// <returns>An iterator over the border objects.
   /// 1.20</returns>
   public Eina.Iterator<Efl.Ui.Focus.Object> GetBorderElements() {
       var _ret_var = Efl.Ui.Focus.ManagerNativeInherit.efl_ui_focus_manager_border_elements_get_ptr.Value.Delegate(this.NativeHandle);
      Eina.Error.RaiseIfUnhandledException();
      return new Eina.Iterator<Efl.Ui.Focus.Object>(_ret_var, false, false);
 }
   /// <summary>Get all elements that are at the border of the viewport
   /// Every element returned by this is located inside the viewport rectangle, but has a right, left, down or up neighbor outside the viewport.
   /// 1.20</summary>
   /// <param name="viewport">The rectangle defining the viewport.
   /// 1.20</param>
   /// <returns>The list of border objects.
   /// 1.20</returns>
   public Eina.Iterator<Efl.Ui.Focus.Object> GetViewportElements( Eina.Rect viewport) {
       var _in_viewport = Eina.Rect_StructConversion.ToInternal(viewport);
                  var _ret_var = Efl.Ui.Focus.ManagerNativeInherit.efl_ui_focus_manager_viewport_elements_get_ptr.Value.Delegate(this.NativeHandle, _in_viewport);
      Eina.Error.RaiseIfUnhandledException();
                  return new Eina.Iterator<Efl.Ui.Focus.Object>(_ret_var, false, false);
 }
   /// <summary>Root node for all logical subtrees.
   /// This property can only be set once.
   /// 1.20</summary>
   /// <returns>Will be registered into this manager object.
   /// 1.20</returns>
   public Efl.Ui.Focus.Object GetRoot() {
       var _ret_var = Efl.Ui.Focus.ManagerNativeInherit.efl_ui_focus_manager_root_get_ptr.Value.Delegate(this.NativeHandle);
      Eina.Error.RaiseIfUnhandledException();
      return _ret_var;
 }
   /// <summary>Root node for all logical subtrees.
   /// This property can only be set once.
   /// 1.20</summary>
   /// <param name="root">Will be registered into this manager object.
   /// 1.20</param>
   /// <returns>If <c>true</c>, this is the root node
   /// 1.20</returns>
   public bool SetRoot( Efl.Ui.Focus.Object root) {
                         var _ret_var = Efl.Ui.Focus.ManagerNativeInherit.efl_ui_focus_manager_root_set_ptr.Value.Delegate(this.NativeHandle, root);
      Eina.Error.RaiseIfUnhandledException();
                  return _ret_var;
 }
   /// <summary>Move the focus in the given direction.
   /// This call flushes all changes. This means all changes between the last flush and now are computed.
   /// 1.20</summary>
   /// <param name="direction">The direction to move to.
   /// 1.20</param>
   /// <returns>The element which is now focused.
   /// 1.20</returns>
   public Efl.Ui.Focus.Object Move( Efl.Ui.Focus.Direction direction) {
                         var _ret_var = Efl.Ui.Focus.ManagerNativeInherit.efl_ui_focus_manager_move_ptr.Value.Delegate(this.NativeHandle, direction);
      Eina.Error.RaiseIfUnhandledException();
                  return _ret_var;
 }
   /// <summary>Return the object in the <c>direction</c> from <c>child</c>.
   /// 1.20</summary>
   /// <param name="direction">Direction to move focus.
   /// 1.20</param>
   /// <param name="child">The child to move from. Pass <c>null</c> to indicate the currently focused child.
   /// 1.20</param>
   /// <param name="logical">Wether you want to have a logical node as result or a non-logical. Note, in a <see cref="Efl.Ui.Focus.Manager.Move"/> call no logical node will get focus.
   /// 1.20</param>
   /// <returns>Object that would receive focus if moved in the given direction.
   /// 1.20</returns>
   public Efl.Ui.Focus.Object MoveRequest( Efl.Ui.Focus.Direction direction,  Efl.Ui.Focus.Object child,  bool logical) {
                                                             var _ret_var = Efl.Ui.Focus.ManagerNativeInherit.efl_ui_focus_manager_request_move_ptr.Value.Delegate(this.NativeHandle, direction,  child,  logical);
      Eina.Error.RaiseIfUnhandledException();
                                          return _ret_var;
 }
   /// <summary>Return the widget in the direction next.
   /// The returned widget is a child of <c>root</c>. It&apos;s guaranteed that child will not be prepared once again, so you can call this function inside a <see cref="Efl.Ui.Focus.Object.SetupOrder"/> call.
   /// 1.20</summary>
   /// <param name="root">Parent for returned child.
   /// 1.20</param>
   /// <returns>Child of passed parameter.
   /// 1.20</returns>
   public Efl.Ui.Focus.Object RequestSubchild( Efl.Ui.Focus.Object root) {
                         var _ret_var = Efl.Ui.Focus.ManagerNativeInherit.efl_ui_focus_manager_request_subchild_ptr.Value.Delegate(this.NativeHandle, root);
      Eina.Error.RaiseIfUnhandledException();
                  return _ret_var;
 }
   /// <summary>This will fetch the data from a registered node.
   /// Be aware this function will trigger a computation of all dirty nodes.
   /// 1.20</summary>
   /// <param name="child">The child object to inspect.
   /// 1.20</param>
   /// <returns>The list of relations starting from <c>child</c>.
   /// 1.20</returns>
   public Efl.Ui.Focus.Relations Fetch( Efl.Ui.Focus.Object child) {
                         var _ret_var = Efl.Ui.Focus.ManagerNativeInherit.efl_ui_focus_manager_fetch_ptr.Value.Delegate(this.NativeHandle, child);
      Eina.Error.RaiseIfUnhandledException();
                  var __ret_tmp = Eina.PrimitiveConversion.PointerToManaged<Efl.Ui.Focus.Relations>(_ret_var);
      Marshal.FreeHGlobal(_ret_var);
      return __ret_tmp;
 }
   /// <summary>Return the last logical object.
   /// The returned object is the last object that would be returned if you start at the root and move the direction into next.
   /// 1.20</summary>
   /// <returns>Last object.
   /// 1.20</returns>
   public Efl.Ui.Focus.ManagerLogicalEndDetail LogicalEnd() {
       var _ret_var = Efl.Ui.Focus.ManagerNativeInherit.efl_ui_focus_manager_logical_end_ptr.Value.Delegate(this.NativeHandle);
      Eina.Error.RaiseIfUnhandledException();
      return Efl.Ui.Focus.ManagerLogicalEndDetail_StructConversion.ToManaged(_ret_var);
 }
   /// <summary>Reset the history stack of this manager object. This means the uppermost element will be unfocused, and all other elements will be removed from the remembered list.
   /// You should focus another element immediately after calling this, in order to always have a focused object.
   /// 1.20</summary>
   /// <returns></returns>
   public  void ResetHistory() {
       Efl.Ui.Focus.ManagerNativeInherit.efl_ui_focus_manager_reset_history_ptr.Value.Delegate(this.NativeHandle);
      Eina.Error.RaiseIfUnhandledException();
       }
   /// <summary>Remove the uppermost history element, and focus the previous one.
   /// If there is an element that was focused before, it will be used. Otherwise, the best fitting element from the registered elements will be focused.
   /// 1.20</summary>
   /// <returns></returns>
   public  void PopHistoryStack() {
       Efl.Ui.Focus.ManagerNativeInherit.efl_ui_focus_manager_pop_history_stack_ptr.Value.Delegate(this.NativeHandle);
      Eina.Error.RaiseIfUnhandledException();
       }
   /// <summary>Called when this manager is set as redirect.
   /// In case that this is called as an result of a move call, <c>direction</c> and <c>entry</c> will be set to the direction of the move call, and the <c>entry</c> object will be set to the object that had this manager as redirect property.
   /// 1.20</summary>
   /// <param name="direction">The direction in which this should be setup.
   /// 1.20</param>
   /// <param name="entry">The object that caused this manager to be redirect.
   /// 1.20</param>
   /// <returns></returns>
   public  void SetupOnFirstTouch( Efl.Ui.Focus.Direction direction,  Efl.Ui.Focus.Object entry) {
                                           Efl.Ui.Focus.ManagerNativeInherit.efl_ui_focus_manager_setup_on_first_touch_ptr.Value.Delegate(this.NativeHandle, direction,  entry);
      Eina.Error.RaiseIfUnhandledException();
                               }
   /// <summary>This disables the cache invalidation when an object is moved.
   /// Even if an object is moved, the focus manager will not recalculate its relations. This can be used when you know that the set of widgets in the focus manager is moved the same way, so the relations between the widets in the set do not change and the complex calculations can be avoided. Use <see cref="Efl.Ui.Focus.Manager.DirtyLogicUnfreeze"/> to re-enable relationship calculation.
   /// 1.20</summary>
   /// <returns></returns>
   public  void FreezeDirtyLogic() {
       Efl.Ui.Focus.ManagerNativeInherit.efl_ui_focus_manager_dirty_logic_freeze_ptr.Value.Delegate(this.NativeHandle);
      Eina.Error.RaiseIfUnhandledException();
       }
   /// <summary>This enables the cache invalidation when an object is moved.
   /// This is the counterpart to <see cref="Efl.Ui.Focus.Manager.FreezeDirtyLogic"/>.
   /// 1.20</summary>
   /// <returns></returns>
   public  void DirtyLogicUnfreeze() {
       Efl.Ui.Focus.ManagerNativeInherit.efl_ui_focus_manager_dirty_logic_unfreeze_ptr.Value.Delegate(this.NativeHandle);
      Eina.Error.RaiseIfUnhandledException();
       }
   /// <summary>Control Wheel disable Enable or disable mouse wheel to be used to scroll the scroller content. heel is enabled by default.</summary>
/// <value><c>true</c> if wheel is disabled, <c>false</c> otherwise</value>
   public bool WheelDisabled {
      get { return GetWheelDisabled(); }
      set { SetWheelDisabled( value); }
   }
   /// <summary>Blocking of scrolling (per axis)
/// This function will block scrolling movement (by input of a user) in a given direction. One can disable movements in the X axis, the Y axis or both. The default value is <c>none</c>, where movements are allowed in both directions.
/// 
/// What makes this function different from freeze_push(), hold_push() and lock_x_set() (or lock_y_set()) is that it doesn&apos;t propagate its effects to any parent or child widget of <c>obj</c>. Only the target scrollable widget will be locked with regard to scrolling.</summary>
/// <value>Which axis (or axes) to block</value>
   public Efl.Ui.ScrollBlock MovementBlock {
      get { return GetMovementBlock(); }
      set { SetMovementBlock( value); }
   }
   /// <summary>Momentum animator</summary>
/// <value><c>true</c> if disabled, <c>false</c> otherwise</value>
   public bool MomentumAnimatorDisabled {
      get { return GetMomentumAnimatorDisabled(); }
      set { SetMomentumAnimatorDisabled( value); }
   }
   /// <summary>It decides whether the scrollable object propagates the events to content object or not.</summary>
/// <value><c>true</c> if events are propagated, <c>false</c> otherwise</value>
   public bool ContentEvents {
      get { return GetContentEvents(); }
      set { SetContentEvents( value); }
   }
   /// <summary>Bounce animator</summary>
/// <value><c>true</c> if bounce animation is disabled, <c>false</c> otherwise</value>
   public bool BounceAnimatorDisabled {
      get { return GetBounceAnimatorDisabled(); }
      set { SetBounceAnimatorDisabled( value); }
   }
   /// <summary>Single direction scroll configuration
/// This makes it possible to restrict scrolling to a single direction, with a &quot;soft&quot; or &quot;hard&quot; behavior.
/// 
/// The hard behavior restricts the scrolling to a single direction all of the time while the soft one will restrict depending on factors such as the movement angle. If the user scrolls roughly in one direction only, it will only move according to it while if the move was clearly wanted on both axes, it will happen on both of them.
/// 1.8</summary>
/// <value>The single direction scroll policy</value>
   public Elm.Scroller.SingleDirection SingleDirection {
      get { return GetSingleDirection(); }
      set { SetSingleDirection( value); }
   }
   /// <summary>Set the callback to run when the content has been moved up.</summary>
/// <value>The callback</value>
   public ElmInterfaceScrollableCb ScrollUpCb {
      set { SetScrollUpCb( value); }
   }
   /// <summary>Set the callback to run when the horizontal scrollbar is dragged.</summary>
/// <value>The callback</value>
   public ElmInterfaceScrollableCb HbarDragCb {
      set { SetHbarDragCb( value); }
   }
   /// <summary>Set the callback to run when dragging of the contents has started.</summary>
/// <value>The callback</value>
   public ElmInterfaceScrollableCb DragStartCb {
      set { SetDragStartCb( value); }
   }
   /// <summary>Set the callback to run when scrolling of the contents has started.</summary>
/// <value>The callback</value>
   public ElmInterfaceScrollableCb ScrollStartCb {
      set { SetScrollStartCb( value); }
   }
   /// <summary>Freeze property</summary>
/// <value><c>true</c> if freeze, <c>false</c> otherwise</value>
   public bool Freeze {
      set { SetFreeze( value); }
   }
   /// <summary>When the viewport is resized, the callback is called.</summary>
/// <value>The callback</value>
   public ElmInterfaceScrollableResizeCb ContentViewportResizeCb {
      set { SetContentViewportResizeCb( value); }
   }
   /// <summary>Set the callback to run when the content has been moved to the left</summary>
/// <value>The callback</value>
   public ElmInterfaceScrollableCb ScrollLeftCb {
      set { SetScrollLeftCb( value); }
   }
   /// <summary>Set the callback to run when the vertical scrollbar is pressed.</summary>
/// <value>The callback</value>
   public ElmInterfaceScrollableCb VbarPressCb {
      set { SetVbarPressCb( value); }
   }
   /// <summary>Set the callback to run when the horizontal scrollbar is pressed.</summary>
/// <value>The callback</value>
   public ElmInterfaceScrollableCb HbarPressCb {
      set { SetHbarPressCb( value); }
   }
   /// <summary>Set the callback to run when the horizontal scrollbar is unpressed.</summary>
/// <value>The callback</value>
   public ElmInterfaceScrollableCb HbarUnpressCb {
      set { SetHbarUnpressCb( value); }
   }
   /// <summary>Set the callback to run when dragging of the contents has stopped.</summary>
/// <value>The callback</value>
   public ElmInterfaceScrollableCb DragStopCb {
      set { SetDragStopCb( value); }
   }
   /// <summary>Set the callback to run when scrolling of the contents has stopped.</summary>
/// <value>The callback</value>
   public ElmInterfaceScrollableCb ScrollStopCb {
      set { SetScrollStopCb( value); }
   }
   /// <summary>Extern pan</summary>
/// <value>Pan object</value>
   public Efl.Canvas.Object ExternPan {
      set { SetExternPan( value); }
   }
   /// <summary>Set the callback to run when the visible page changes.</summary>
/// <value>The callback</value>
   public ElmInterfaceScrollableCb PageChangeCb {
      set { SetPageChangeCb( value); }
   }
   /// <summary>Hold property</summary>
/// <value><c>true</c> if hold, <c>false</c> otherwise</value>
   public bool Hold {
      set { SetHold( value); }
   }
   /// <summary>Set the callback to run when the scrolling animation has started.</summary>
/// <value>The callback</value>
   public ElmInterfaceScrollableCb AnimateStartCb {
      set { SetAnimateStartCb( value); }
   }
   /// <summary>Set the callback to run when the content has been moved down.</summary>
/// <value>The callback</value>
   public ElmInterfaceScrollableCb ScrollDownCb {
      set { SetScrollDownCb( value); }
   }
   /// <summary>Set the callback to run when the content has been moved.</summary>
/// <value>The callback</value>
   public ElmInterfaceScrollableCb ScrollCb {
      set { SetScrollCb( value); }
   }
   /// <summary>Set the callback to run when the scrolling animation has stopped.</summary>
/// <value>The callback</value>
   public ElmInterfaceScrollableCb AnimateStopCb {
      set { SetAnimateStopCb( value); }
   }
   /// <summary>set the callback to run on minimal limit content</summary>
/// <value>The callback</value>
   public ElmInterfaceScrollableMinLimitCb ContentMinLimitCb {
      set { SetContentMinLimitCb( value); }
   }
   /// <summary>Set the callback to run when the content has been moved to the right.</summary>
/// <value>The callback</value>
   public ElmInterfaceScrollableCb ScrollRightCb {
      set { SetScrollRightCb( value); }
   }
   /// <summary>Content property</summary>
/// <value>Content object</value>
   public Efl.Canvas.Object ScrollableContent {
      set { SetScrollableContent( value); }
   }
   /// <summary>Set the callback to run when the left edge of the content has been reached.</summary>
/// <value>The callback</value>
   public ElmInterfaceScrollableCb EdgeLeftCb {
      set { SetEdgeLeftCb( value); }
   }
   /// <summary>Set the callback to run when the horizontal scrollbar is dragged.</summary>
/// <value>The callback</value>
   public ElmInterfaceScrollableCb VbarDragCb {
      set { SetVbarDragCb( value); }
   }
   /// <summary>Set the callback to run when the horizontal scrollbar is unpressed.</summary>
/// <value>The callback</value>
   public ElmInterfaceScrollableCb VbarUnpressCb {
      set { SetVbarUnpressCb( value); }
   }
   /// <summary>Set the callback to run when the bottom edge of the content has been reached.</summary>
/// <value>The callback</value>
   public ElmInterfaceScrollableCb EdgeBottomCb {
      set { SetEdgeBottomCb( value); }
   }
   /// <summary>Set the callback to run when the right edge of the content has been reached.</summary>
/// <value>The callback</value>
   public ElmInterfaceScrollableCb EdgeRightCb {
      set { SetEdgeRightCb( value); }
   }
   /// <summary>Set the callback to run when the top edge of the content has been reached.</summary>
/// <value>The callback</value>
   public ElmInterfaceScrollableCb EdgeTopCb {
      set { SetEdgeTopCb( value); }
   }
   /// <summary>Whether scrolling should loop around.</summary>
/// <value>True to enable looping.</value>
   public bool ItemLoopEnabled {
      get { return GetItemLoopEnabled(); }
      set { SetItemLoopEnabled( value); }
   }
   /// <summary>The element which is currently focused by this manager
/// Use this property to retrieve the object currently being focused, or to set the focus to a new one. When <c>focus</c> is a logical child (which cannot receive focus), the next non-logical object is selected instead. If there is no such object, focus does not change.
/// 1.20</summary>
/// <value>Currently focused element.
/// 1.20</value>
   public Efl.Ui.Focus.Object ManagerFocus {
      get { return GetManagerFocus(); }
      set { SetManagerFocus( value); }
   }
   /// <summary>Add another manager to serve the move requests.
/// If this value is set, all move requests are redirected to this manager object. Set it to <c>null</c> once nothing should be redirected anymore.
/// 1.20</summary>
/// <value>The redirect manager.
/// 1.20</value>
   public Efl.Ui.Focus.Manager Redirect {
      get { return GetRedirect(); }
      set { SetRedirect( value); }
   }
   /// <summary>The list of elements which are at the border of the graph.
/// This means one of the relations right,left or down,up are not set. This call flushes all changes. See <see cref="Efl.Ui.Focus.Manager.Move"/>
/// 1.20</summary>
/// <value>An iterator over the border objects.
/// 1.20</value>
   public Eina.Iterator<Efl.Ui.Focus.Object> BorderElements {
      get { return GetBorderElements(); }
   }
   /// <summary>Root node for all logical subtrees.
/// This property can only be set once.
/// 1.20</summary>
/// <value>Will be registered into this manager object.
/// 1.20</value>
   public Efl.Ui.Focus.Object Root {
      get { return GetRoot(); }
      set { SetRoot( value); }
   }
}
public class InterfaceScrollableNativeInherit  : Efl.Eo.NativeClass{
   public  static Efl.Eo.NativeModule _Module = new Efl.Eo.NativeModule(efl.Libs.Elementary);
   public override System.Collections.Generic.List<Efl_Op_Description> GetEoOps(System.Type type)
   {
      var descs = new System.Collections.Generic.List<Efl_Op_Description>();
      if (elm_interface_scrollable_gravity_get_static_delegate == null)
      elm_interface_scrollable_gravity_get_static_delegate = new elm_interface_scrollable_gravity_get_delegate(gravity_get);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "elm_interface_scrollable_gravity_get"), func = Marshal.GetFunctionPointerForDelegate(elm_interface_scrollable_gravity_get_static_delegate)});
      if (elm_interface_scrollable_gravity_set_static_delegate == null)
      elm_interface_scrollable_gravity_set_static_delegate = new elm_interface_scrollable_gravity_set_delegate(gravity_set);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "elm_interface_scrollable_gravity_set"), func = Marshal.GetFunctionPointerForDelegate(elm_interface_scrollable_gravity_set_static_delegate)});
      if (elm_interface_scrollable_bounce_allow_get_static_delegate == null)
      elm_interface_scrollable_bounce_allow_get_static_delegate = new elm_interface_scrollable_bounce_allow_get_delegate(bounce_allow_get);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "elm_interface_scrollable_bounce_allow_get"), func = Marshal.GetFunctionPointerForDelegate(elm_interface_scrollable_bounce_allow_get_static_delegate)});
      if (elm_interface_scrollable_bounce_allow_set_static_delegate == null)
      elm_interface_scrollable_bounce_allow_set_static_delegate = new elm_interface_scrollable_bounce_allow_set_delegate(bounce_allow_set);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "elm_interface_scrollable_bounce_allow_set"), func = Marshal.GetFunctionPointerForDelegate(elm_interface_scrollable_bounce_allow_set_static_delegate)});
      if (elm_interface_scrollable_wheel_disabled_get_static_delegate == null)
      elm_interface_scrollable_wheel_disabled_get_static_delegate = new elm_interface_scrollable_wheel_disabled_get_delegate(wheel_disabled_get);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "elm_interface_scrollable_wheel_disabled_get"), func = Marshal.GetFunctionPointerForDelegate(elm_interface_scrollable_wheel_disabled_get_static_delegate)});
      if (elm_interface_scrollable_wheel_disabled_set_static_delegate == null)
      elm_interface_scrollable_wheel_disabled_set_static_delegate = new elm_interface_scrollable_wheel_disabled_set_delegate(wheel_disabled_set);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "elm_interface_scrollable_wheel_disabled_set"), func = Marshal.GetFunctionPointerForDelegate(elm_interface_scrollable_wheel_disabled_set_static_delegate)});
      if (elm_interface_scrollable_movement_block_get_static_delegate == null)
      elm_interface_scrollable_movement_block_get_static_delegate = new elm_interface_scrollable_movement_block_get_delegate(movement_block_get);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "elm_interface_scrollable_movement_block_get"), func = Marshal.GetFunctionPointerForDelegate(elm_interface_scrollable_movement_block_get_static_delegate)});
      if (elm_interface_scrollable_movement_block_set_static_delegate == null)
      elm_interface_scrollable_movement_block_set_static_delegate = new elm_interface_scrollable_movement_block_set_delegate(movement_block_set);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "elm_interface_scrollable_movement_block_set"), func = Marshal.GetFunctionPointerForDelegate(elm_interface_scrollable_movement_block_set_static_delegate)});
      if (elm_interface_scrollable_momentum_animator_disabled_get_static_delegate == null)
      elm_interface_scrollable_momentum_animator_disabled_get_static_delegate = new elm_interface_scrollable_momentum_animator_disabled_get_delegate(momentum_animator_disabled_get);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "elm_interface_scrollable_momentum_animator_disabled_get"), func = Marshal.GetFunctionPointerForDelegate(elm_interface_scrollable_momentum_animator_disabled_get_static_delegate)});
      if (elm_interface_scrollable_momentum_animator_disabled_set_static_delegate == null)
      elm_interface_scrollable_momentum_animator_disabled_set_static_delegate = new elm_interface_scrollable_momentum_animator_disabled_set_delegate(momentum_animator_disabled_set);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "elm_interface_scrollable_momentum_animator_disabled_set"), func = Marshal.GetFunctionPointerForDelegate(elm_interface_scrollable_momentum_animator_disabled_set_static_delegate)});
      if (elm_interface_scrollable_policy_get_static_delegate == null)
      elm_interface_scrollable_policy_get_static_delegate = new elm_interface_scrollable_policy_get_delegate(policy_get);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "elm_interface_scrollable_policy_get"), func = Marshal.GetFunctionPointerForDelegate(elm_interface_scrollable_policy_get_static_delegate)});
      if (elm_interface_scrollable_policy_set_static_delegate == null)
      elm_interface_scrollable_policy_set_static_delegate = new elm_interface_scrollable_policy_set_delegate(policy_set);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "elm_interface_scrollable_policy_set"), func = Marshal.GetFunctionPointerForDelegate(elm_interface_scrollable_policy_set_static_delegate)});
      if (elm_interface_scrollable_content_region_get_static_delegate == null)
      elm_interface_scrollable_content_region_get_static_delegate = new elm_interface_scrollable_content_region_get_delegate(content_region_get);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "elm_interface_scrollable_content_region_get"), func = Marshal.GetFunctionPointerForDelegate(elm_interface_scrollable_content_region_get_static_delegate)});
      if (elm_interface_scrollable_content_region_set_static_delegate == null)
      elm_interface_scrollable_content_region_set_static_delegate = new elm_interface_scrollable_content_region_set_delegate(content_region_set);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "elm_interface_scrollable_content_region_set"), func = Marshal.GetFunctionPointerForDelegate(elm_interface_scrollable_content_region_set_static_delegate)});
      if (elm_interface_scrollable_content_events_get_static_delegate == null)
      elm_interface_scrollable_content_events_get_static_delegate = new elm_interface_scrollable_content_events_get_delegate(content_events_get);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "elm_interface_scrollable_content_events_get"), func = Marshal.GetFunctionPointerForDelegate(elm_interface_scrollable_content_events_get_static_delegate)});
      if (elm_interface_scrollable_content_events_set_static_delegate == null)
      elm_interface_scrollable_content_events_set_static_delegate = new elm_interface_scrollable_content_events_set_delegate(content_events_set);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "elm_interface_scrollable_content_events_set"), func = Marshal.GetFunctionPointerForDelegate(elm_interface_scrollable_content_events_set_static_delegate)});
      if (elm_interface_scrollable_page_size_get_static_delegate == null)
      elm_interface_scrollable_page_size_get_static_delegate = new elm_interface_scrollable_page_size_get_delegate(page_size_get);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "elm_interface_scrollable_page_size_get"), func = Marshal.GetFunctionPointerForDelegate(elm_interface_scrollable_page_size_get_static_delegate)});
      if (elm_interface_scrollable_page_size_set_static_delegate == null)
      elm_interface_scrollable_page_size_set_static_delegate = new elm_interface_scrollable_page_size_set_delegate(page_size_set);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "elm_interface_scrollable_page_size_set"), func = Marshal.GetFunctionPointerForDelegate(elm_interface_scrollable_page_size_set_static_delegate)});
      if (elm_interface_scrollable_bounce_animator_disabled_get_static_delegate == null)
      elm_interface_scrollable_bounce_animator_disabled_get_static_delegate = new elm_interface_scrollable_bounce_animator_disabled_get_delegate(bounce_animator_disabled_get);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "elm_interface_scrollable_bounce_animator_disabled_get"), func = Marshal.GetFunctionPointerForDelegate(elm_interface_scrollable_bounce_animator_disabled_get_static_delegate)});
      if (elm_interface_scrollable_bounce_animator_disabled_set_static_delegate == null)
      elm_interface_scrollable_bounce_animator_disabled_set_static_delegate = new elm_interface_scrollable_bounce_animator_disabled_set_delegate(bounce_animator_disabled_set);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "elm_interface_scrollable_bounce_animator_disabled_set"), func = Marshal.GetFunctionPointerForDelegate(elm_interface_scrollable_bounce_animator_disabled_set_static_delegate)});
      if (elm_interface_scrollable_page_scroll_limit_get_static_delegate == null)
      elm_interface_scrollable_page_scroll_limit_get_static_delegate = new elm_interface_scrollable_page_scroll_limit_get_delegate(page_scroll_limit_get);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "elm_interface_scrollable_page_scroll_limit_get"), func = Marshal.GetFunctionPointerForDelegate(elm_interface_scrollable_page_scroll_limit_get_static_delegate)});
      if (elm_interface_scrollable_page_scroll_limit_set_static_delegate == null)
      elm_interface_scrollable_page_scroll_limit_set_static_delegate = new elm_interface_scrollable_page_scroll_limit_set_delegate(page_scroll_limit_set);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "elm_interface_scrollable_page_scroll_limit_set"), func = Marshal.GetFunctionPointerForDelegate(elm_interface_scrollable_page_scroll_limit_set_static_delegate)});
      if (elm_interface_scrollable_page_snap_allow_get_static_delegate == null)
      elm_interface_scrollable_page_snap_allow_get_static_delegate = new elm_interface_scrollable_page_snap_allow_get_delegate(page_snap_allow_get);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "elm_interface_scrollable_page_snap_allow_get"), func = Marshal.GetFunctionPointerForDelegate(elm_interface_scrollable_page_snap_allow_get_static_delegate)});
      if (elm_interface_scrollable_page_snap_allow_set_static_delegate == null)
      elm_interface_scrollable_page_snap_allow_set_static_delegate = new elm_interface_scrollable_page_snap_allow_set_delegate(page_snap_allow_set);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "elm_interface_scrollable_page_snap_allow_set"), func = Marshal.GetFunctionPointerForDelegate(elm_interface_scrollable_page_snap_allow_set_static_delegate)});
      if (elm_interface_scrollable_paging_get_static_delegate == null)
      elm_interface_scrollable_paging_get_static_delegate = new elm_interface_scrollable_paging_get_delegate(paging_get);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "elm_interface_scrollable_paging_get"), func = Marshal.GetFunctionPointerForDelegate(elm_interface_scrollable_paging_get_static_delegate)});
      if (elm_interface_scrollable_paging_set_static_delegate == null)
      elm_interface_scrollable_paging_set_static_delegate = new elm_interface_scrollable_paging_set_delegate(paging_set);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "elm_interface_scrollable_paging_set"), func = Marshal.GetFunctionPointerForDelegate(elm_interface_scrollable_paging_set_static_delegate)});
      if (elm_interface_scrollable_single_direction_get_static_delegate == null)
      elm_interface_scrollable_single_direction_get_static_delegate = new elm_interface_scrollable_single_direction_get_delegate(single_direction_get);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "elm_interface_scrollable_single_direction_get"), func = Marshal.GetFunctionPointerForDelegate(elm_interface_scrollable_single_direction_get_static_delegate)});
      if (elm_interface_scrollable_single_direction_set_static_delegate == null)
      elm_interface_scrollable_single_direction_set_static_delegate = new elm_interface_scrollable_single_direction_set_delegate(single_direction_set);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "elm_interface_scrollable_single_direction_set"), func = Marshal.GetFunctionPointerForDelegate(elm_interface_scrollable_single_direction_set_static_delegate)});
      if (elm_interface_scrollable_step_size_get_static_delegate == null)
      elm_interface_scrollable_step_size_get_static_delegate = new elm_interface_scrollable_step_size_get_delegate(step_size_get);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "elm_interface_scrollable_step_size_get"), func = Marshal.GetFunctionPointerForDelegate(elm_interface_scrollable_step_size_get_static_delegate)});
      if (elm_interface_scrollable_step_size_set_static_delegate == null)
      elm_interface_scrollable_step_size_set_static_delegate = new elm_interface_scrollable_step_size_set_delegate(step_size_set);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "elm_interface_scrollable_step_size_set"), func = Marshal.GetFunctionPointerForDelegate(elm_interface_scrollable_step_size_set_static_delegate)});
      if (elm_interface_scrollable_content_loop_get_static_delegate == null)
      elm_interface_scrollable_content_loop_get_static_delegate = new elm_interface_scrollable_content_loop_get_delegate(content_loop_get);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "elm_interface_scrollable_content_loop_get"), func = Marshal.GetFunctionPointerForDelegate(elm_interface_scrollable_content_loop_get_static_delegate)});
      if (elm_interface_scrollable_content_loop_set_static_delegate == null)
      elm_interface_scrollable_content_loop_set_static_delegate = new elm_interface_scrollable_content_loop_set_delegate(content_loop_set);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "elm_interface_scrollable_content_loop_set"), func = Marshal.GetFunctionPointerForDelegate(elm_interface_scrollable_content_loop_set_static_delegate)});
      if (elm_interface_scrollable_scroll_up_cb_set_static_delegate == null)
      elm_interface_scrollable_scroll_up_cb_set_static_delegate = new elm_interface_scrollable_scroll_up_cb_set_delegate(scroll_up_cb_set);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "elm_interface_scrollable_scroll_up_cb_set"), func = Marshal.GetFunctionPointerForDelegate(elm_interface_scrollable_scroll_up_cb_set_static_delegate)});
      if (elm_interface_scrollable_hbar_drag_cb_set_static_delegate == null)
      elm_interface_scrollable_hbar_drag_cb_set_static_delegate = new elm_interface_scrollable_hbar_drag_cb_set_delegate(hbar_drag_cb_set);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "elm_interface_scrollable_hbar_drag_cb_set"), func = Marshal.GetFunctionPointerForDelegate(elm_interface_scrollable_hbar_drag_cb_set_static_delegate)});
      if (elm_interface_scrollable_drag_start_cb_set_static_delegate == null)
      elm_interface_scrollable_drag_start_cb_set_static_delegate = new elm_interface_scrollable_drag_start_cb_set_delegate(drag_start_cb_set);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "elm_interface_scrollable_drag_start_cb_set"), func = Marshal.GetFunctionPointerForDelegate(elm_interface_scrollable_drag_start_cb_set_static_delegate)});
      if (elm_interface_scrollable_scroll_start_cb_set_static_delegate == null)
      elm_interface_scrollable_scroll_start_cb_set_static_delegate = new elm_interface_scrollable_scroll_start_cb_set_delegate(scroll_start_cb_set);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "elm_interface_scrollable_scroll_start_cb_set"), func = Marshal.GetFunctionPointerForDelegate(elm_interface_scrollable_scroll_start_cb_set_static_delegate)});
      if (elm_interface_scrollable_freeze_set_static_delegate == null)
      elm_interface_scrollable_freeze_set_static_delegate = new elm_interface_scrollable_freeze_set_delegate(freeze_set);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "elm_interface_scrollable_freeze_set"), func = Marshal.GetFunctionPointerForDelegate(elm_interface_scrollable_freeze_set_static_delegate)});
      if (elm_interface_scrollable_content_viewport_resize_cb_set_static_delegate == null)
      elm_interface_scrollable_content_viewport_resize_cb_set_static_delegate = new elm_interface_scrollable_content_viewport_resize_cb_set_delegate(content_viewport_resize_cb_set);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "elm_interface_scrollable_content_viewport_resize_cb_set"), func = Marshal.GetFunctionPointerForDelegate(elm_interface_scrollable_content_viewport_resize_cb_set_static_delegate)});
      if (elm_interface_scrollable_scroll_left_cb_set_static_delegate == null)
      elm_interface_scrollable_scroll_left_cb_set_static_delegate = new elm_interface_scrollable_scroll_left_cb_set_delegate(scroll_left_cb_set);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "elm_interface_scrollable_scroll_left_cb_set"), func = Marshal.GetFunctionPointerForDelegate(elm_interface_scrollable_scroll_left_cb_set_static_delegate)});
      if (elm_interface_scrollable_vbar_press_cb_set_static_delegate == null)
      elm_interface_scrollable_vbar_press_cb_set_static_delegate = new elm_interface_scrollable_vbar_press_cb_set_delegate(vbar_press_cb_set);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "elm_interface_scrollable_vbar_press_cb_set"), func = Marshal.GetFunctionPointerForDelegate(elm_interface_scrollable_vbar_press_cb_set_static_delegate)});
      if (elm_interface_scrollable_hbar_press_cb_set_static_delegate == null)
      elm_interface_scrollable_hbar_press_cb_set_static_delegate = new elm_interface_scrollable_hbar_press_cb_set_delegate(hbar_press_cb_set);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "elm_interface_scrollable_hbar_press_cb_set"), func = Marshal.GetFunctionPointerForDelegate(elm_interface_scrollable_hbar_press_cb_set_static_delegate)});
      if (elm_interface_scrollable_hbar_unpress_cb_set_static_delegate == null)
      elm_interface_scrollable_hbar_unpress_cb_set_static_delegate = new elm_interface_scrollable_hbar_unpress_cb_set_delegate(hbar_unpress_cb_set);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "elm_interface_scrollable_hbar_unpress_cb_set"), func = Marshal.GetFunctionPointerForDelegate(elm_interface_scrollable_hbar_unpress_cb_set_static_delegate)});
      if (elm_interface_scrollable_drag_stop_cb_set_static_delegate == null)
      elm_interface_scrollable_drag_stop_cb_set_static_delegate = new elm_interface_scrollable_drag_stop_cb_set_delegate(drag_stop_cb_set);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "elm_interface_scrollable_drag_stop_cb_set"), func = Marshal.GetFunctionPointerForDelegate(elm_interface_scrollable_drag_stop_cb_set_static_delegate)});
      if (elm_interface_scrollable_scroll_stop_cb_set_static_delegate == null)
      elm_interface_scrollable_scroll_stop_cb_set_static_delegate = new elm_interface_scrollable_scroll_stop_cb_set_delegate(scroll_stop_cb_set);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "elm_interface_scrollable_scroll_stop_cb_set"), func = Marshal.GetFunctionPointerForDelegate(elm_interface_scrollable_scroll_stop_cb_set_static_delegate)});
      if (elm_interface_scrollable_extern_pan_set_static_delegate == null)
      elm_interface_scrollable_extern_pan_set_static_delegate = new elm_interface_scrollable_extern_pan_set_delegate(extern_pan_set);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "elm_interface_scrollable_extern_pan_set"), func = Marshal.GetFunctionPointerForDelegate(elm_interface_scrollable_extern_pan_set_static_delegate)});
      if (elm_interface_scrollable_page_change_cb_set_static_delegate == null)
      elm_interface_scrollable_page_change_cb_set_static_delegate = new elm_interface_scrollable_page_change_cb_set_delegate(page_change_cb_set);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "elm_interface_scrollable_page_change_cb_set"), func = Marshal.GetFunctionPointerForDelegate(elm_interface_scrollable_page_change_cb_set_static_delegate)});
      if (elm_interface_scrollable_hold_set_static_delegate == null)
      elm_interface_scrollable_hold_set_static_delegate = new elm_interface_scrollable_hold_set_delegate(hold_set);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "elm_interface_scrollable_hold_set"), func = Marshal.GetFunctionPointerForDelegate(elm_interface_scrollable_hold_set_static_delegate)});
      if (elm_interface_scrollable_animate_start_cb_set_static_delegate == null)
      elm_interface_scrollable_animate_start_cb_set_static_delegate = new elm_interface_scrollable_animate_start_cb_set_delegate(animate_start_cb_set);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "elm_interface_scrollable_animate_start_cb_set"), func = Marshal.GetFunctionPointerForDelegate(elm_interface_scrollable_animate_start_cb_set_static_delegate)});
      if (elm_interface_scrollable_scroll_down_cb_set_static_delegate == null)
      elm_interface_scrollable_scroll_down_cb_set_static_delegate = new elm_interface_scrollable_scroll_down_cb_set_delegate(scroll_down_cb_set);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "elm_interface_scrollable_scroll_down_cb_set"), func = Marshal.GetFunctionPointerForDelegate(elm_interface_scrollable_scroll_down_cb_set_static_delegate)});
      if (elm_interface_scrollable_page_relative_set_static_delegate == null)
      elm_interface_scrollable_page_relative_set_static_delegate = new elm_interface_scrollable_page_relative_set_delegate(page_relative_set);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "elm_interface_scrollable_page_relative_set"), func = Marshal.GetFunctionPointerForDelegate(elm_interface_scrollable_page_relative_set_static_delegate)});
      if (elm_interface_scrollable_scroll_cb_set_static_delegate == null)
      elm_interface_scrollable_scroll_cb_set_static_delegate = new elm_interface_scrollable_scroll_cb_set_delegate(scroll_cb_set);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "elm_interface_scrollable_scroll_cb_set"), func = Marshal.GetFunctionPointerForDelegate(elm_interface_scrollable_scroll_cb_set_static_delegate)});
      if (elm_interface_scrollable_animate_stop_cb_set_static_delegate == null)
      elm_interface_scrollable_animate_stop_cb_set_static_delegate = new elm_interface_scrollable_animate_stop_cb_set_delegate(animate_stop_cb_set);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "elm_interface_scrollable_animate_stop_cb_set"), func = Marshal.GetFunctionPointerForDelegate(elm_interface_scrollable_animate_stop_cb_set_static_delegate)});
      if (elm_interface_scrollable_content_min_limit_cb_set_static_delegate == null)
      elm_interface_scrollable_content_min_limit_cb_set_static_delegate = new elm_interface_scrollable_content_min_limit_cb_set_delegate(content_min_limit_cb_set);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "elm_interface_scrollable_content_min_limit_cb_set"), func = Marshal.GetFunctionPointerForDelegate(elm_interface_scrollable_content_min_limit_cb_set_static_delegate)});
      if (elm_interface_scrollable_scroll_right_cb_set_static_delegate == null)
      elm_interface_scrollable_scroll_right_cb_set_static_delegate = new elm_interface_scrollable_scroll_right_cb_set_delegate(scroll_right_cb_set);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "elm_interface_scrollable_scroll_right_cb_set"), func = Marshal.GetFunctionPointerForDelegate(elm_interface_scrollable_scroll_right_cb_set_static_delegate)});
      if (elm_interface_scrollable_content_set_static_delegate == null)
      elm_interface_scrollable_content_set_static_delegate = new elm_interface_scrollable_content_set_delegate(scrollable_content_set);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "elm_interface_scrollable_content_set"), func = Marshal.GetFunctionPointerForDelegate(elm_interface_scrollable_content_set_static_delegate)});
      if (elm_interface_scrollable_edge_left_cb_set_static_delegate == null)
      elm_interface_scrollable_edge_left_cb_set_static_delegate = new elm_interface_scrollable_edge_left_cb_set_delegate(edge_left_cb_set);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "elm_interface_scrollable_edge_left_cb_set"), func = Marshal.GetFunctionPointerForDelegate(elm_interface_scrollable_edge_left_cb_set_static_delegate)});
      if (elm_interface_scrollable_vbar_drag_cb_set_static_delegate == null)
      elm_interface_scrollable_vbar_drag_cb_set_static_delegate = new elm_interface_scrollable_vbar_drag_cb_set_delegate(vbar_drag_cb_set);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "elm_interface_scrollable_vbar_drag_cb_set"), func = Marshal.GetFunctionPointerForDelegate(elm_interface_scrollable_vbar_drag_cb_set_static_delegate)});
      if (elm_interface_scrollable_vbar_unpress_cb_set_static_delegate == null)
      elm_interface_scrollable_vbar_unpress_cb_set_static_delegate = new elm_interface_scrollable_vbar_unpress_cb_set_delegate(vbar_unpress_cb_set);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "elm_interface_scrollable_vbar_unpress_cb_set"), func = Marshal.GetFunctionPointerForDelegate(elm_interface_scrollable_vbar_unpress_cb_set_static_delegate)});
      if (elm_interface_scrollable_edge_bottom_cb_set_static_delegate == null)
      elm_interface_scrollable_edge_bottom_cb_set_static_delegate = new elm_interface_scrollable_edge_bottom_cb_set_delegate(edge_bottom_cb_set);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "elm_interface_scrollable_edge_bottom_cb_set"), func = Marshal.GetFunctionPointerForDelegate(elm_interface_scrollable_edge_bottom_cb_set_static_delegate)});
      if (elm_interface_scrollable_edge_right_cb_set_static_delegate == null)
      elm_interface_scrollable_edge_right_cb_set_static_delegate = new elm_interface_scrollable_edge_right_cb_set_delegate(edge_right_cb_set);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "elm_interface_scrollable_edge_right_cb_set"), func = Marshal.GetFunctionPointerForDelegate(elm_interface_scrollable_edge_right_cb_set_static_delegate)});
      if (elm_interface_scrollable_edge_top_cb_set_static_delegate == null)
      elm_interface_scrollable_edge_top_cb_set_static_delegate = new elm_interface_scrollable_edge_top_cb_set_delegate(edge_top_cb_set);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "elm_interface_scrollable_edge_top_cb_set"), func = Marshal.GetFunctionPointerForDelegate(elm_interface_scrollable_edge_top_cb_set_static_delegate)});
      if (elm_interface_scrollable_objects_set_static_delegate == null)
      elm_interface_scrollable_objects_set_static_delegate = new elm_interface_scrollable_objects_set_delegate(objects_set);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "elm_interface_scrollable_objects_set"), func = Marshal.GetFunctionPointerForDelegate(elm_interface_scrollable_objects_set_static_delegate)});
      if (elm_interface_scrollable_last_page_get_static_delegate == null)
      elm_interface_scrollable_last_page_get_static_delegate = new elm_interface_scrollable_last_page_get_delegate(last_page_get);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "elm_interface_scrollable_last_page_get"), func = Marshal.GetFunctionPointerForDelegate(elm_interface_scrollable_last_page_get_static_delegate)});
      if (elm_interface_scrollable_current_page_get_static_delegate == null)
      elm_interface_scrollable_current_page_get_static_delegate = new elm_interface_scrollable_current_page_get_delegate(current_page_get);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "elm_interface_scrollable_current_page_get"), func = Marshal.GetFunctionPointerForDelegate(elm_interface_scrollable_current_page_get_static_delegate)});
      if (elm_interface_scrollable_content_viewport_geometry_get_static_delegate == null)
      elm_interface_scrollable_content_viewport_geometry_get_static_delegate = new elm_interface_scrollable_content_viewport_geometry_get_delegate(content_viewport_geometry_get);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "elm_interface_scrollable_content_viewport_geometry_get"), func = Marshal.GetFunctionPointerForDelegate(elm_interface_scrollable_content_viewport_geometry_get_static_delegate)});
      if (elm_interface_scrollable_content_size_get_static_delegate == null)
      elm_interface_scrollable_content_size_get_static_delegate = new elm_interface_scrollable_content_size_get_delegate(content_size_get);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "elm_interface_scrollable_content_size_get"), func = Marshal.GetFunctionPointerForDelegate(elm_interface_scrollable_content_size_get_static_delegate)});
      if (elm_interface_scrollable_item_loop_enabled_get_static_delegate == null)
      elm_interface_scrollable_item_loop_enabled_get_static_delegate = new elm_interface_scrollable_item_loop_enabled_get_delegate(item_loop_enabled_get);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "elm_interface_scrollable_item_loop_enabled_get"), func = Marshal.GetFunctionPointerForDelegate(elm_interface_scrollable_item_loop_enabled_get_static_delegate)});
      if (elm_interface_scrollable_item_loop_enabled_set_static_delegate == null)
      elm_interface_scrollable_item_loop_enabled_set_static_delegate = new elm_interface_scrollable_item_loop_enabled_set_delegate(item_loop_enabled_set);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "elm_interface_scrollable_item_loop_enabled_set"), func = Marshal.GetFunctionPointerForDelegate(elm_interface_scrollable_item_loop_enabled_set_static_delegate)});
      if (elm_interface_scrollable_content_pos_set_static_delegate == null)
      elm_interface_scrollable_content_pos_set_static_delegate = new elm_interface_scrollable_content_pos_set_delegate(content_pos_set);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "elm_interface_scrollable_content_pos_set"), func = Marshal.GetFunctionPointerForDelegate(elm_interface_scrollable_content_pos_set_static_delegate)});
      if (elm_interface_scrollable_content_pos_get_static_delegate == null)
      elm_interface_scrollable_content_pos_get_static_delegate = new elm_interface_scrollable_content_pos_get_delegate(content_pos_get);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "elm_interface_scrollable_content_pos_get"), func = Marshal.GetFunctionPointerForDelegate(elm_interface_scrollable_content_pos_get_static_delegate)});
      if (elm_interface_scrollable_page_show_static_delegate == null)
      elm_interface_scrollable_page_show_static_delegate = new elm_interface_scrollable_page_show_delegate(page_show);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "elm_interface_scrollable_page_show"), func = Marshal.GetFunctionPointerForDelegate(elm_interface_scrollable_page_show_static_delegate)});
      if (elm_interface_scrollable_region_bring_in_static_delegate == null)
      elm_interface_scrollable_region_bring_in_static_delegate = new elm_interface_scrollable_region_bring_in_delegate(region_bring_in);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "elm_interface_scrollable_region_bring_in"), func = Marshal.GetFunctionPointerForDelegate(elm_interface_scrollable_region_bring_in_static_delegate)});
      if (elm_interface_scrollable_page_bring_in_static_delegate == null)
      elm_interface_scrollable_page_bring_in_static_delegate = new elm_interface_scrollable_page_bring_in_delegate(page_bring_in);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "elm_interface_scrollable_page_bring_in"), func = Marshal.GetFunctionPointerForDelegate(elm_interface_scrollable_page_bring_in_static_delegate)});
      if (elm_interface_scrollable_content_region_show_static_delegate == null)
      elm_interface_scrollable_content_region_show_static_delegate = new elm_interface_scrollable_content_region_show_delegate(content_region_show);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "elm_interface_scrollable_content_region_show"), func = Marshal.GetFunctionPointerForDelegate(elm_interface_scrollable_content_region_show_static_delegate)});
      if (elm_interface_scrollable_content_min_limit_static_delegate == null)
      elm_interface_scrollable_content_min_limit_static_delegate = new elm_interface_scrollable_content_min_limit_delegate(content_min_limit);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "elm_interface_scrollable_content_min_limit"), func = Marshal.GetFunctionPointerForDelegate(elm_interface_scrollable_content_min_limit_static_delegate)});
      if (elm_interface_scrollable_wanted_region_set_static_delegate == null)
      elm_interface_scrollable_wanted_region_set_static_delegate = new elm_interface_scrollable_wanted_region_set_delegate(wanted_region_set);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "elm_interface_scrollable_wanted_region_set"), func = Marshal.GetFunctionPointerForDelegate(elm_interface_scrollable_wanted_region_set_static_delegate)});
      if (elm_interface_scrollable_custom_pan_pos_adjust_static_delegate == null)
      elm_interface_scrollable_custom_pan_pos_adjust_static_delegate = new elm_interface_scrollable_custom_pan_pos_adjust_delegate(custom_pan_pos_adjust);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "elm_interface_scrollable_custom_pan_pos_adjust"), func = Marshal.GetFunctionPointerForDelegate(elm_interface_scrollable_custom_pan_pos_adjust_static_delegate)});
      if (efl_ui_widget_focus_manager_create_static_delegate == null)
      efl_ui_widget_focus_manager_create_static_delegate = new efl_ui_widget_focus_manager_create_delegate(focus_manager_create);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_widget_focus_manager_create"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_widget_focus_manager_create_static_delegate)});
      if (efl_ui_focus_manager_focus_get_static_delegate == null)
      efl_ui_focus_manager_focus_get_static_delegate = new efl_ui_focus_manager_focus_get_delegate(manager_focus_get);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_focus_manager_focus_get"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_focus_manager_focus_get_static_delegate)});
      if (efl_ui_focus_manager_focus_set_static_delegate == null)
      efl_ui_focus_manager_focus_set_static_delegate = new efl_ui_focus_manager_focus_set_delegate(manager_focus_set);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_focus_manager_focus_set"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_focus_manager_focus_set_static_delegate)});
      if (efl_ui_focus_manager_redirect_get_static_delegate == null)
      efl_ui_focus_manager_redirect_get_static_delegate = new efl_ui_focus_manager_redirect_get_delegate(redirect_get);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_focus_manager_redirect_get"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_focus_manager_redirect_get_static_delegate)});
      if (efl_ui_focus_manager_redirect_set_static_delegate == null)
      efl_ui_focus_manager_redirect_set_static_delegate = new efl_ui_focus_manager_redirect_set_delegate(redirect_set);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_focus_manager_redirect_set"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_focus_manager_redirect_set_static_delegate)});
      if (efl_ui_focus_manager_border_elements_get_static_delegate == null)
      efl_ui_focus_manager_border_elements_get_static_delegate = new efl_ui_focus_manager_border_elements_get_delegate(border_elements_get);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_focus_manager_border_elements_get"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_focus_manager_border_elements_get_static_delegate)});
      if (efl_ui_focus_manager_viewport_elements_get_static_delegate == null)
      efl_ui_focus_manager_viewport_elements_get_static_delegate = new efl_ui_focus_manager_viewport_elements_get_delegate(viewport_elements_get);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_focus_manager_viewport_elements_get"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_focus_manager_viewport_elements_get_static_delegate)});
      if (efl_ui_focus_manager_root_get_static_delegate == null)
      efl_ui_focus_manager_root_get_static_delegate = new efl_ui_focus_manager_root_get_delegate(root_get);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_focus_manager_root_get"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_focus_manager_root_get_static_delegate)});
      if (efl_ui_focus_manager_root_set_static_delegate == null)
      efl_ui_focus_manager_root_set_static_delegate = new efl_ui_focus_manager_root_set_delegate(root_set);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_focus_manager_root_set"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_focus_manager_root_set_static_delegate)});
      if (efl_ui_focus_manager_move_static_delegate == null)
      efl_ui_focus_manager_move_static_delegate = new efl_ui_focus_manager_move_delegate(move);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_focus_manager_move"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_focus_manager_move_static_delegate)});
      if (efl_ui_focus_manager_request_move_static_delegate == null)
      efl_ui_focus_manager_request_move_static_delegate = new efl_ui_focus_manager_request_move_delegate(request_move);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_focus_manager_request_move"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_focus_manager_request_move_static_delegate)});
      if (efl_ui_focus_manager_request_subchild_static_delegate == null)
      efl_ui_focus_manager_request_subchild_static_delegate = new efl_ui_focus_manager_request_subchild_delegate(request_subchild);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_focus_manager_request_subchild"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_focus_manager_request_subchild_static_delegate)});
      if (efl_ui_focus_manager_fetch_static_delegate == null)
      efl_ui_focus_manager_fetch_static_delegate = new efl_ui_focus_manager_fetch_delegate(fetch);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_focus_manager_fetch"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_focus_manager_fetch_static_delegate)});
      if (efl_ui_focus_manager_logical_end_static_delegate == null)
      efl_ui_focus_manager_logical_end_static_delegate = new efl_ui_focus_manager_logical_end_delegate(logical_end);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_focus_manager_logical_end"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_focus_manager_logical_end_static_delegate)});
      if (efl_ui_focus_manager_reset_history_static_delegate == null)
      efl_ui_focus_manager_reset_history_static_delegate = new efl_ui_focus_manager_reset_history_delegate(reset_history);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_focus_manager_reset_history"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_focus_manager_reset_history_static_delegate)});
      if (efl_ui_focus_manager_pop_history_stack_static_delegate == null)
      efl_ui_focus_manager_pop_history_stack_static_delegate = new efl_ui_focus_manager_pop_history_stack_delegate(pop_history_stack);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_focus_manager_pop_history_stack"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_focus_manager_pop_history_stack_static_delegate)});
      if (efl_ui_focus_manager_setup_on_first_touch_static_delegate == null)
      efl_ui_focus_manager_setup_on_first_touch_static_delegate = new efl_ui_focus_manager_setup_on_first_touch_delegate(setup_on_first_touch);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_focus_manager_setup_on_first_touch"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_focus_manager_setup_on_first_touch_static_delegate)});
      if (efl_ui_focus_manager_dirty_logic_freeze_static_delegate == null)
      efl_ui_focus_manager_dirty_logic_freeze_static_delegate = new efl_ui_focus_manager_dirty_logic_freeze_delegate(dirty_logic_freeze);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_focus_manager_dirty_logic_freeze"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_focus_manager_dirty_logic_freeze_static_delegate)});
      if (efl_ui_focus_manager_dirty_logic_unfreeze_static_delegate == null)
      efl_ui_focus_manager_dirty_logic_unfreeze_static_delegate = new efl_ui_focus_manager_dirty_logic_unfreeze_delegate(dirty_logic_unfreeze);
      descs.Add(new Efl_Op_Description() {api_func = Efl.Eo.FunctionInterop.LoadFunctionPointer(_Module.Module, "efl_ui_focus_manager_dirty_logic_unfreeze"), func = Marshal.GetFunctionPointerForDelegate(efl_ui_focus_manager_dirty_logic_unfreeze_static_delegate)});
      return descs;
   }
   public override IntPtr GetEflClass()
   {
      return Elm.InterfaceScrollableConcrete.elm_interface_scrollable_mixin_get();
   }
   public static  IntPtr GetEflClassStatic()
   {
      return Elm.InterfaceScrollableConcrete.elm_interface_scrollable_mixin_get();
   }


    private delegate  void elm_interface_scrollable_gravity_get_delegate(System.IntPtr obj, System.IntPtr pd,   out double x,   out double y);


    public delegate  void elm_interface_scrollable_gravity_get_api_delegate(System.IntPtr obj,   out double x,   out double y);
    public static Efl.Eo.FunctionWrapper<elm_interface_scrollable_gravity_get_api_delegate> elm_interface_scrollable_gravity_get_ptr = new Efl.Eo.FunctionWrapper<elm_interface_scrollable_gravity_get_api_delegate>(_Module, "elm_interface_scrollable_gravity_get");
    private static  void gravity_get(System.IntPtr obj, System.IntPtr pd,  out double x,  out double y)
   {
      Eina.Log.Debug("function elm_interface_scrollable_gravity_get was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                           x = default(double);      y = default(double);                     
         try {
            ((InterfaceScrollableConcrete)wrapper).GetGravity( out x,  out y);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                                    } else {
         elm_interface_scrollable_gravity_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  out x,  out y);
      }
   }
   private static elm_interface_scrollable_gravity_get_delegate elm_interface_scrollable_gravity_get_static_delegate;


    private delegate  void elm_interface_scrollable_gravity_set_delegate(System.IntPtr obj, System.IntPtr pd,   double x,   double y);


    public delegate  void elm_interface_scrollable_gravity_set_api_delegate(System.IntPtr obj,   double x,   double y);
    public static Efl.Eo.FunctionWrapper<elm_interface_scrollable_gravity_set_api_delegate> elm_interface_scrollable_gravity_set_ptr = new Efl.Eo.FunctionWrapper<elm_interface_scrollable_gravity_set_api_delegate>(_Module, "elm_interface_scrollable_gravity_set");
    private static  void gravity_set(System.IntPtr obj, System.IntPtr pd,  double x,  double y)
   {
      Eina.Log.Debug("function elm_interface_scrollable_gravity_set was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                                      
         try {
            ((InterfaceScrollableConcrete)wrapper).SetGravity( x,  y);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                                    } else {
         elm_interface_scrollable_gravity_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  x,  y);
      }
   }
   private static elm_interface_scrollable_gravity_set_delegate elm_interface_scrollable_gravity_set_static_delegate;


    private delegate  void elm_interface_scrollable_bounce_allow_get_delegate(System.IntPtr obj, System.IntPtr pd,  [MarshalAs(UnmanagedType.U1)]  out bool horiz,  [MarshalAs(UnmanagedType.U1)]  out bool vert);


    public delegate  void elm_interface_scrollable_bounce_allow_get_api_delegate(System.IntPtr obj,  [MarshalAs(UnmanagedType.U1)]  out bool horiz,  [MarshalAs(UnmanagedType.U1)]  out bool vert);
    public static Efl.Eo.FunctionWrapper<elm_interface_scrollable_bounce_allow_get_api_delegate> elm_interface_scrollable_bounce_allow_get_ptr = new Efl.Eo.FunctionWrapper<elm_interface_scrollable_bounce_allow_get_api_delegate>(_Module, "elm_interface_scrollable_bounce_allow_get");
    private static  void bounce_allow_get(System.IntPtr obj, System.IntPtr pd,  out bool horiz,  out bool vert)
   {
      Eina.Log.Debug("function elm_interface_scrollable_bounce_allow_get was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                           horiz = default(bool);      vert = default(bool);                     
         try {
            ((InterfaceScrollableConcrete)wrapper).GetBounceAllow( out horiz,  out vert);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                                    } else {
         elm_interface_scrollable_bounce_allow_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  out horiz,  out vert);
      }
   }
   private static elm_interface_scrollable_bounce_allow_get_delegate elm_interface_scrollable_bounce_allow_get_static_delegate;


    private delegate  void elm_interface_scrollable_bounce_allow_set_delegate(System.IntPtr obj, System.IntPtr pd,  [MarshalAs(UnmanagedType.U1)]  bool horiz,  [MarshalAs(UnmanagedType.U1)]  bool vert);


    public delegate  void elm_interface_scrollable_bounce_allow_set_api_delegate(System.IntPtr obj,  [MarshalAs(UnmanagedType.U1)]  bool horiz,  [MarshalAs(UnmanagedType.U1)]  bool vert);
    public static Efl.Eo.FunctionWrapper<elm_interface_scrollable_bounce_allow_set_api_delegate> elm_interface_scrollable_bounce_allow_set_ptr = new Efl.Eo.FunctionWrapper<elm_interface_scrollable_bounce_allow_set_api_delegate>(_Module, "elm_interface_scrollable_bounce_allow_set");
    private static  void bounce_allow_set(System.IntPtr obj, System.IntPtr pd,  bool horiz,  bool vert)
   {
      Eina.Log.Debug("function elm_interface_scrollable_bounce_allow_set was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                                      
         try {
            ((InterfaceScrollableConcrete)wrapper).SetBounceAllow( horiz,  vert);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                                    } else {
         elm_interface_scrollable_bounce_allow_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  horiz,  vert);
      }
   }
   private static elm_interface_scrollable_bounce_allow_set_delegate elm_interface_scrollable_bounce_allow_set_static_delegate;


    [return: MarshalAs(UnmanagedType.U1)] private delegate bool elm_interface_scrollable_wheel_disabled_get_delegate(System.IntPtr obj, System.IntPtr pd);


    [return: MarshalAs(UnmanagedType.U1)] public delegate bool elm_interface_scrollable_wheel_disabled_get_api_delegate(System.IntPtr obj);
    public static Efl.Eo.FunctionWrapper<elm_interface_scrollable_wheel_disabled_get_api_delegate> elm_interface_scrollable_wheel_disabled_get_ptr = new Efl.Eo.FunctionWrapper<elm_interface_scrollable_wheel_disabled_get_api_delegate>(_Module, "elm_interface_scrollable_wheel_disabled_get");
    private static bool wheel_disabled_get(System.IntPtr obj, System.IntPtr pd)
   {
      Eina.Log.Debug("function elm_interface_scrollable_wheel_disabled_get was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                  bool _ret_var = default(bool);
         try {
            _ret_var = ((InterfaceScrollableConcrete)wrapper).GetWheelDisabled();
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
      return _ret_var;
      } else {
         return elm_interface_scrollable_wheel_disabled_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
      }
   }
   private static elm_interface_scrollable_wheel_disabled_get_delegate elm_interface_scrollable_wheel_disabled_get_static_delegate;


    private delegate  void elm_interface_scrollable_wheel_disabled_set_delegate(System.IntPtr obj, System.IntPtr pd,  [MarshalAs(UnmanagedType.U1)]  bool disabled);


    public delegate  void elm_interface_scrollable_wheel_disabled_set_api_delegate(System.IntPtr obj,  [MarshalAs(UnmanagedType.U1)]  bool disabled);
    public static Efl.Eo.FunctionWrapper<elm_interface_scrollable_wheel_disabled_set_api_delegate> elm_interface_scrollable_wheel_disabled_set_ptr = new Efl.Eo.FunctionWrapper<elm_interface_scrollable_wheel_disabled_set_api_delegate>(_Module, "elm_interface_scrollable_wheel_disabled_set");
    private static  void wheel_disabled_set(System.IntPtr obj, System.IntPtr pd,  bool disabled)
   {
      Eina.Log.Debug("function elm_interface_scrollable_wheel_disabled_set was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                    
         try {
            ((InterfaceScrollableConcrete)wrapper).SetWheelDisabled( disabled);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                        } else {
         elm_interface_scrollable_wheel_disabled_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  disabled);
      }
   }
   private static elm_interface_scrollable_wheel_disabled_set_delegate elm_interface_scrollable_wheel_disabled_set_static_delegate;


    private delegate Efl.Ui.ScrollBlock elm_interface_scrollable_movement_block_get_delegate(System.IntPtr obj, System.IntPtr pd);


    public delegate Efl.Ui.ScrollBlock elm_interface_scrollable_movement_block_get_api_delegate(System.IntPtr obj);
    public static Efl.Eo.FunctionWrapper<elm_interface_scrollable_movement_block_get_api_delegate> elm_interface_scrollable_movement_block_get_ptr = new Efl.Eo.FunctionWrapper<elm_interface_scrollable_movement_block_get_api_delegate>(_Module, "elm_interface_scrollable_movement_block_get");
    private static Efl.Ui.ScrollBlock movement_block_get(System.IntPtr obj, System.IntPtr pd)
   {
      Eina.Log.Debug("function elm_interface_scrollable_movement_block_get was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                  Efl.Ui.ScrollBlock _ret_var = default(Efl.Ui.ScrollBlock);
         try {
            _ret_var = ((InterfaceScrollableConcrete)wrapper).GetMovementBlock();
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
      return _ret_var;
      } else {
         return elm_interface_scrollable_movement_block_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
      }
   }
   private static elm_interface_scrollable_movement_block_get_delegate elm_interface_scrollable_movement_block_get_static_delegate;


    private delegate  void elm_interface_scrollable_movement_block_set_delegate(System.IntPtr obj, System.IntPtr pd,   Efl.Ui.ScrollBlock block);


    public delegate  void elm_interface_scrollable_movement_block_set_api_delegate(System.IntPtr obj,   Efl.Ui.ScrollBlock block);
    public static Efl.Eo.FunctionWrapper<elm_interface_scrollable_movement_block_set_api_delegate> elm_interface_scrollable_movement_block_set_ptr = new Efl.Eo.FunctionWrapper<elm_interface_scrollable_movement_block_set_api_delegate>(_Module, "elm_interface_scrollable_movement_block_set");
    private static  void movement_block_set(System.IntPtr obj, System.IntPtr pd,  Efl.Ui.ScrollBlock block)
   {
      Eina.Log.Debug("function elm_interface_scrollable_movement_block_set was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                    
         try {
            ((InterfaceScrollableConcrete)wrapper).SetMovementBlock( block);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                        } else {
         elm_interface_scrollable_movement_block_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  block);
      }
   }
   private static elm_interface_scrollable_movement_block_set_delegate elm_interface_scrollable_movement_block_set_static_delegate;


    [return: MarshalAs(UnmanagedType.U1)] private delegate bool elm_interface_scrollable_momentum_animator_disabled_get_delegate(System.IntPtr obj, System.IntPtr pd);


    [return: MarshalAs(UnmanagedType.U1)] public delegate bool elm_interface_scrollable_momentum_animator_disabled_get_api_delegate(System.IntPtr obj);
    public static Efl.Eo.FunctionWrapper<elm_interface_scrollable_momentum_animator_disabled_get_api_delegate> elm_interface_scrollable_momentum_animator_disabled_get_ptr = new Efl.Eo.FunctionWrapper<elm_interface_scrollable_momentum_animator_disabled_get_api_delegate>(_Module, "elm_interface_scrollable_momentum_animator_disabled_get");
    private static bool momentum_animator_disabled_get(System.IntPtr obj, System.IntPtr pd)
   {
      Eina.Log.Debug("function elm_interface_scrollable_momentum_animator_disabled_get was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                  bool _ret_var = default(bool);
         try {
            _ret_var = ((InterfaceScrollableConcrete)wrapper).GetMomentumAnimatorDisabled();
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
      return _ret_var;
      } else {
         return elm_interface_scrollable_momentum_animator_disabled_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
      }
   }
   private static elm_interface_scrollable_momentum_animator_disabled_get_delegate elm_interface_scrollable_momentum_animator_disabled_get_static_delegate;


    private delegate  void elm_interface_scrollable_momentum_animator_disabled_set_delegate(System.IntPtr obj, System.IntPtr pd,  [MarshalAs(UnmanagedType.U1)]  bool disabled);


    public delegate  void elm_interface_scrollable_momentum_animator_disabled_set_api_delegate(System.IntPtr obj,  [MarshalAs(UnmanagedType.U1)]  bool disabled);
    public static Efl.Eo.FunctionWrapper<elm_interface_scrollable_momentum_animator_disabled_set_api_delegate> elm_interface_scrollable_momentum_animator_disabled_set_ptr = new Efl.Eo.FunctionWrapper<elm_interface_scrollable_momentum_animator_disabled_set_api_delegate>(_Module, "elm_interface_scrollable_momentum_animator_disabled_set");
    private static  void momentum_animator_disabled_set(System.IntPtr obj, System.IntPtr pd,  bool disabled)
   {
      Eina.Log.Debug("function elm_interface_scrollable_momentum_animator_disabled_set was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                    
         try {
            ((InterfaceScrollableConcrete)wrapper).SetMomentumAnimatorDisabled( disabled);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                        } else {
         elm_interface_scrollable_momentum_animator_disabled_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  disabled);
      }
   }
   private static elm_interface_scrollable_momentum_animator_disabled_set_delegate elm_interface_scrollable_momentum_animator_disabled_set_static_delegate;


    private delegate  void elm_interface_scrollable_policy_get_delegate(System.IntPtr obj, System.IntPtr pd,   out Elm.Scroller.Policy hbar,   out Elm.Scroller.Policy vbar);


    public delegate  void elm_interface_scrollable_policy_get_api_delegate(System.IntPtr obj,   out Elm.Scroller.Policy hbar,   out Elm.Scroller.Policy vbar);
    public static Efl.Eo.FunctionWrapper<elm_interface_scrollable_policy_get_api_delegate> elm_interface_scrollable_policy_get_ptr = new Efl.Eo.FunctionWrapper<elm_interface_scrollable_policy_get_api_delegate>(_Module, "elm_interface_scrollable_policy_get");
    private static  void policy_get(System.IntPtr obj, System.IntPtr pd,  out Elm.Scroller.Policy hbar,  out Elm.Scroller.Policy vbar)
   {
      Eina.Log.Debug("function elm_interface_scrollable_policy_get was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                           hbar = default(Elm.Scroller.Policy);      vbar = default(Elm.Scroller.Policy);                     
         try {
            ((InterfaceScrollableConcrete)wrapper).GetPolicy( out hbar,  out vbar);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                                    } else {
         elm_interface_scrollable_policy_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  out hbar,  out vbar);
      }
   }
   private static elm_interface_scrollable_policy_get_delegate elm_interface_scrollable_policy_get_static_delegate;


    private delegate  void elm_interface_scrollable_policy_set_delegate(System.IntPtr obj, System.IntPtr pd,   Elm.Scroller.Policy hbar,   Elm.Scroller.Policy vbar);


    public delegate  void elm_interface_scrollable_policy_set_api_delegate(System.IntPtr obj,   Elm.Scroller.Policy hbar,   Elm.Scroller.Policy vbar);
    public static Efl.Eo.FunctionWrapper<elm_interface_scrollable_policy_set_api_delegate> elm_interface_scrollable_policy_set_ptr = new Efl.Eo.FunctionWrapper<elm_interface_scrollable_policy_set_api_delegate>(_Module, "elm_interface_scrollable_policy_set");
    private static  void policy_set(System.IntPtr obj, System.IntPtr pd,  Elm.Scroller.Policy hbar,  Elm.Scroller.Policy vbar)
   {
      Eina.Log.Debug("function elm_interface_scrollable_policy_set was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                                      
         try {
            ((InterfaceScrollableConcrete)wrapper).SetPolicy( hbar,  vbar);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                                    } else {
         elm_interface_scrollable_policy_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  hbar,  vbar);
      }
   }
   private static elm_interface_scrollable_policy_set_delegate elm_interface_scrollable_policy_set_static_delegate;


    private delegate  void elm_interface_scrollable_content_region_get_delegate(System.IntPtr obj, System.IntPtr pd,   out  int x,   out  int y,   out  int w,   out  int h);


    public delegate  void elm_interface_scrollable_content_region_get_api_delegate(System.IntPtr obj,   out  int x,   out  int y,   out  int w,   out  int h);
    public static Efl.Eo.FunctionWrapper<elm_interface_scrollable_content_region_get_api_delegate> elm_interface_scrollable_content_region_get_ptr = new Efl.Eo.FunctionWrapper<elm_interface_scrollable_content_region_get_api_delegate>(_Module, "elm_interface_scrollable_content_region_get");
    private static  void content_region_get(System.IntPtr obj, System.IntPtr pd,  out  int x,  out  int y,  out  int w,  out  int h)
   {
      Eina.Log.Debug("function elm_interface_scrollable_content_region_get was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                       x = default( int);      y = default( int);      w = default( int);      h = default( int);                                 
         try {
            ((InterfaceScrollableConcrete)wrapper).GetContentRegion( out x,  out y,  out w,  out h);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                                                            } else {
         elm_interface_scrollable_content_region_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  out x,  out y,  out w,  out h);
      }
   }
   private static elm_interface_scrollable_content_region_get_delegate elm_interface_scrollable_content_region_get_static_delegate;


    private delegate  void elm_interface_scrollable_content_region_set_delegate(System.IntPtr obj, System.IntPtr pd,    int x,    int y,    int w,    int h);


    public delegate  void elm_interface_scrollable_content_region_set_api_delegate(System.IntPtr obj,    int x,    int y,    int w,    int h);
    public static Efl.Eo.FunctionWrapper<elm_interface_scrollable_content_region_set_api_delegate> elm_interface_scrollable_content_region_set_ptr = new Efl.Eo.FunctionWrapper<elm_interface_scrollable_content_region_set_api_delegate>(_Module, "elm_interface_scrollable_content_region_set");
    private static  void content_region_set(System.IntPtr obj, System.IntPtr pd,   int x,   int y,   int w,   int h)
   {
      Eina.Log.Debug("function elm_interface_scrollable_content_region_set was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                                                                          
         try {
            ((InterfaceScrollableConcrete)wrapper).SetContentRegion( x,  y,  w,  h);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                                                            } else {
         elm_interface_scrollable_content_region_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  x,  y,  w,  h);
      }
   }
   private static elm_interface_scrollable_content_region_set_delegate elm_interface_scrollable_content_region_set_static_delegate;


    [return: MarshalAs(UnmanagedType.U1)] private delegate bool elm_interface_scrollable_content_events_get_delegate(System.IntPtr obj, System.IntPtr pd);


    [return: MarshalAs(UnmanagedType.U1)] public delegate bool elm_interface_scrollable_content_events_get_api_delegate(System.IntPtr obj);
    public static Efl.Eo.FunctionWrapper<elm_interface_scrollable_content_events_get_api_delegate> elm_interface_scrollable_content_events_get_ptr = new Efl.Eo.FunctionWrapper<elm_interface_scrollable_content_events_get_api_delegate>(_Module, "elm_interface_scrollable_content_events_get");
    private static bool content_events_get(System.IntPtr obj, System.IntPtr pd)
   {
      Eina.Log.Debug("function elm_interface_scrollable_content_events_get was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                  bool _ret_var = default(bool);
         try {
            _ret_var = ((InterfaceScrollableConcrete)wrapper).GetContentEvents();
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
      return _ret_var;
      } else {
         return elm_interface_scrollable_content_events_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
      }
   }
   private static elm_interface_scrollable_content_events_get_delegate elm_interface_scrollable_content_events_get_static_delegate;


    private delegate  void elm_interface_scrollable_content_events_set_delegate(System.IntPtr obj, System.IntPtr pd,  [MarshalAs(UnmanagedType.U1)]  bool repeat_events);


    public delegate  void elm_interface_scrollable_content_events_set_api_delegate(System.IntPtr obj,  [MarshalAs(UnmanagedType.U1)]  bool repeat_events);
    public static Efl.Eo.FunctionWrapper<elm_interface_scrollable_content_events_set_api_delegate> elm_interface_scrollable_content_events_set_ptr = new Efl.Eo.FunctionWrapper<elm_interface_scrollable_content_events_set_api_delegate>(_Module, "elm_interface_scrollable_content_events_set");
    private static  void content_events_set(System.IntPtr obj, System.IntPtr pd,  bool repeat_events)
   {
      Eina.Log.Debug("function elm_interface_scrollable_content_events_set was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                    
         try {
            ((InterfaceScrollableConcrete)wrapper).SetContentEvents( repeat_events);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                        } else {
         elm_interface_scrollable_content_events_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  repeat_events);
      }
   }
   private static elm_interface_scrollable_content_events_set_delegate elm_interface_scrollable_content_events_set_static_delegate;


    private delegate  void elm_interface_scrollable_page_size_get_delegate(System.IntPtr obj, System.IntPtr pd,   out  int x,   out  int y);


    public delegate  void elm_interface_scrollable_page_size_get_api_delegate(System.IntPtr obj,   out  int x,   out  int y);
    public static Efl.Eo.FunctionWrapper<elm_interface_scrollable_page_size_get_api_delegate> elm_interface_scrollable_page_size_get_ptr = new Efl.Eo.FunctionWrapper<elm_interface_scrollable_page_size_get_api_delegate>(_Module, "elm_interface_scrollable_page_size_get");
    private static  void page_size_get(System.IntPtr obj, System.IntPtr pd,  out  int x,  out  int y)
   {
      Eina.Log.Debug("function elm_interface_scrollable_page_size_get was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                           x = default( int);      y = default( int);                     
         try {
            ((InterfaceScrollableConcrete)wrapper).GetPageSize( out x,  out y);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                                    } else {
         elm_interface_scrollable_page_size_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  out x,  out y);
      }
   }
   private static elm_interface_scrollable_page_size_get_delegate elm_interface_scrollable_page_size_get_static_delegate;


    private delegate  void elm_interface_scrollable_page_size_set_delegate(System.IntPtr obj, System.IntPtr pd,    int x,    int y);


    public delegate  void elm_interface_scrollable_page_size_set_api_delegate(System.IntPtr obj,    int x,    int y);
    public static Efl.Eo.FunctionWrapper<elm_interface_scrollable_page_size_set_api_delegate> elm_interface_scrollable_page_size_set_ptr = new Efl.Eo.FunctionWrapper<elm_interface_scrollable_page_size_set_api_delegate>(_Module, "elm_interface_scrollable_page_size_set");
    private static  void page_size_set(System.IntPtr obj, System.IntPtr pd,   int x,   int y)
   {
      Eina.Log.Debug("function elm_interface_scrollable_page_size_set was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                                      
         try {
            ((InterfaceScrollableConcrete)wrapper).SetPageSize( x,  y);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                                    } else {
         elm_interface_scrollable_page_size_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  x,  y);
      }
   }
   private static elm_interface_scrollable_page_size_set_delegate elm_interface_scrollable_page_size_set_static_delegate;


    [return: MarshalAs(UnmanagedType.U1)] private delegate bool elm_interface_scrollable_bounce_animator_disabled_get_delegate(System.IntPtr obj, System.IntPtr pd);


    [return: MarshalAs(UnmanagedType.U1)] public delegate bool elm_interface_scrollable_bounce_animator_disabled_get_api_delegate(System.IntPtr obj);
    public static Efl.Eo.FunctionWrapper<elm_interface_scrollable_bounce_animator_disabled_get_api_delegate> elm_interface_scrollable_bounce_animator_disabled_get_ptr = new Efl.Eo.FunctionWrapper<elm_interface_scrollable_bounce_animator_disabled_get_api_delegate>(_Module, "elm_interface_scrollable_bounce_animator_disabled_get");
    private static bool bounce_animator_disabled_get(System.IntPtr obj, System.IntPtr pd)
   {
      Eina.Log.Debug("function elm_interface_scrollable_bounce_animator_disabled_get was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                  bool _ret_var = default(bool);
         try {
            _ret_var = ((InterfaceScrollableConcrete)wrapper).GetBounceAnimatorDisabled();
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
      return _ret_var;
      } else {
         return elm_interface_scrollable_bounce_animator_disabled_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
      }
   }
   private static elm_interface_scrollable_bounce_animator_disabled_get_delegate elm_interface_scrollable_bounce_animator_disabled_get_static_delegate;


    private delegate  void elm_interface_scrollable_bounce_animator_disabled_set_delegate(System.IntPtr obj, System.IntPtr pd,  [MarshalAs(UnmanagedType.U1)]  bool disabled);


    public delegate  void elm_interface_scrollable_bounce_animator_disabled_set_api_delegate(System.IntPtr obj,  [MarshalAs(UnmanagedType.U1)]  bool disabled);
    public static Efl.Eo.FunctionWrapper<elm_interface_scrollable_bounce_animator_disabled_set_api_delegate> elm_interface_scrollable_bounce_animator_disabled_set_ptr = new Efl.Eo.FunctionWrapper<elm_interface_scrollable_bounce_animator_disabled_set_api_delegate>(_Module, "elm_interface_scrollable_bounce_animator_disabled_set");
    private static  void bounce_animator_disabled_set(System.IntPtr obj, System.IntPtr pd,  bool disabled)
   {
      Eina.Log.Debug("function elm_interface_scrollable_bounce_animator_disabled_set was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                    
         try {
            ((InterfaceScrollableConcrete)wrapper).SetBounceAnimatorDisabled( disabled);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                        } else {
         elm_interface_scrollable_bounce_animator_disabled_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  disabled);
      }
   }
   private static elm_interface_scrollable_bounce_animator_disabled_set_delegate elm_interface_scrollable_bounce_animator_disabled_set_static_delegate;


    private delegate  void elm_interface_scrollable_page_scroll_limit_get_delegate(System.IntPtr obj, System.IntPtr pd,   out  int page_limit_h,   out  int page_limit_v);


    public delegate  void elm_interface_scrollable_page_scroll_limit_get_api_delegate(System.IntPtr obj,   out  int page_limit_h,   out  int page_limit_v);
    public static Efl.Eo.FunctionWrapper<elm_interface_scrollable_page_scroll_limit_get_api_delegate> elm_interface_scrollable_page_scroll_limit_get_ptr = new Efl.Eo.FunctionWrapper<elm_interface_scrollable_page_scroll_limit_get_api_delegate>(_Module, "elm_interface_scrollable_page_scroll_limit_get");
    private static  void page_scroll_limit_get(System.IntPtr obj, System.IntPtr pd,  out  int page_limit_h,  out  int page_limit_v)
   {
      Eina.Log.Debug("function elm_interface_scrollable_page_scroll_limit_get was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                           page_limit_h = default( int);      page_limit_v = default( int);                     
         try {
            ((InterfaceScrollableConcrete)wrapper).GetPageScrollLimit( out page_limit_h,  out page_limit_v);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                                    } else {
         elm_interface_scrollable_page_scroll_limit_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  out page_limit_h,  out page_limit_v);
      }
   }
   private static elm_interface_scrollable_page_scroll_limit_get_delegate elm_interface_scrollable_page_scroll_limit_get_static_delegate;


    private delegate  void elm_interface_scrollable_page_scroll_limit_set_delegate(System.IntPtr obj, System.IntPtr pd,    int page_limit_h,    int page_limit_v);


    public delegate  void elm_interface_scrollable_page_scroll_limit_set_api_delegate(System.IntPtr obj,    int page_limit_h,    int page_limit_v);
    public static Efl.Eo.FunctionWrapper<elm_interface_scrollable_page_scroll_limit_set_api_delegate> elm_interface_scrollable_page_scroll_limit_set_ptr = new Efl.Eo.FunctionWrapper<elm_interface_scrollable_page_scroll_limit_set_api_delegate>(_Module, "elm_interface_scrollable_page_scroll_limit_set");
    private static  void page_scroll_limit_set(System.IntPtr obj, System.IntPtr pd,   int page_limit_h,   int page_limit_v)
   {
      Eina.Log.Debug("function elm_interface_scrollable_page_scroll_limit_set was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                                      
         try {
            ((InterfaceScrollableConcrete)wrapper).SetPageScrollLimit( page_limit_h,  page_limit_v);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                                    } else {
         elm_interface_scrollable_page_scroll_limit_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  page_limit_h,  page_limit_v);
      }
   }
   private static elm_interface_scrollable_page_scroll_limit_set_delegate elm_interface_scrollable_page_scroll_limit_set_static_delegate;


    private delegate  void elm_interface_scrollable_page_snap_allow_get_delegate(System.IntPtr obj, System.IntPtr pd,  [MarshalAs(UnmanagedType.U1)]  out bool horiz,  [MarshalAs(UnmanagedType.U1)]  out bool vert);


    public delegate  void elm_interface_scrollable_page_snap_allow_get_api_delegate(System.IntPtr obj,  [MarshalAs(UnmanagedType.U1)]  out bool horiz,  [MarshalAs(UnmanagedType.U1)]  out bool vert);
    public static Efl.Eo.FunctionWrapper<elm_interface_scrollable_page_snap_allow_get_api_delegate> elm_interface_scrollable_page_snap_allow_get_ptr = new Efl.Eo.FunctionWrapper<elm_interface_scrollable_page_snap_allow_get_api_delegate>(_Module, "elm_interface_scrollable_page_snap_allow_get");
    private static  void page_snap_allow_get(System.IntPtr obj, System.IntPtr pd,  out bool horiz,  out bool vert)
   {
      Eina.Log.Debug("function elm_interface_scrollable_page_snap_allow_get was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                           horiz = default(bool);      vert = default(bool);                     
         try {
            ((InterfaceScrollableConcrete)wrapper).GetPageSnapAllow( out horiz,  out vert);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                                    } else {
         elm_interface_scrollable_page_snap_allow_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  out horiz,  out vert);
      }
   }
   private static elm_interface_scrollable_page_snap_allow_get_delegate elm_interface_scrollable_page_snap_allow_get_static_delegate;


    private delegate  void elm_interface_scrollable_page_snap_allow_set_delegate(System.IntPtr obj, System.IntPtr pd,  [MarshalAs(UnmanagedType.U1)]  bool horiz,  [MarshalAs(UnmanagedType.U1)]  bool vert);


    public delegate  void elm_interface_scrollable_page_snap_allow_set_api_delegate(System.IntPtr obj,  [MarshalAs(UnmanagedType.U1)]  bool horiz,  [MarshalAs(UnmanagedType.U1)]  bool vert);
    public static Efl.Eo.FunctionWrapper<elm_interface_scrollable_page_snap_allow_set_api_delegate> elm_interface_scrollable_page_snap_allow_set_ptr = new Efl.Eo.FunctionWrapper<elm_interface_scrollable_page_snap_allow_set_api_delegate>(_Module, "elm_interface_scrollable_page_snap_allow_set");
    private static  void page_snap_allow_set(System.IntPtr obj, System.IntPtr pd,  bool horiz,  bool vert)
   {
      Eina.Log.Debug("function elm_interface_scrollable_page_snap_allow_set was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                                      
         try {
            ((InterfaceScrollableConcrete)wrapper).SetPageSnapAllow( horiz,  vert);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                                    } else {
         elm_interface_scrollable_page_snap_allow_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  horiz,  vert);
      }
   }
   private static elm_interface_scrollable_page_snap_allow_set_delegate elm_interface_scrollable_page_snap_allow_set_static_delegate;


    private delegate  void elm_interface_scrollable_paging_get_delegate(System.IntPtr obj, System.IntPtr pd,   out double pagerel_h,   out double pagerel_v,   out  int pagesize_h,   out  int pagesize_v);


    public delegate  void elm_interface_scrollable_paging_get_api_delegate(System.IntPtr obj,   out double pagerel_h,   out double pagerel_v,   out  int pagesize_h,   out  int pagesize_v);
    public static Efl.Eo.FunctionWrapper<elm_interface_scrollable_paging_get_api_delegate> elm_interface_scrollable_paging_get_ptr = new Efl.Eo.FunctionWrapper<elm_interface_scrollable_paging_get_api_delegate>(_Module, "elm_interface_scrollable_paging_get");
    private static  void paging_get(System.IntPtr obj, System.IntPtr pd,  out double pagerel_h,  out double pagerel_v,  out  int pagesize_h,  out  int pagesize_v)
   {
      Eina.Log.Debug("function elm_interface_scrollable_paging_get was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                       pagerel_h = default(double);      pagerel_v = default(double);      pagesize_h = default( int);      pagesize_v = default( int);                                 
         try {
            ((InterfaceScrollableConcrete)wrapper).GetPaging( out pagerel_h,  out pagerel_v,  out pagesize_h,  out pagesize_v);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                                                            } else {
         elm_interface_scrollable_paging_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  out pagerel_h,  out pagerel_v,  out pagesize_h,  out pagesize_v);
      }
   }
   private static elm_interface_scrollable_paging_get_delegate elm_interface_scrollable_paging_get_static_delegate;


    private delegate  void elm_interface_scrollable_paging_set_delegate(System.IntPtr obj, System.IntPtr pd,   double pagerel_h,   double pagerel_v,    int pagesize_h,    int pagesize_v);


    public delegate  void elm_interface_scrollable_paging_set_api_delegate(System.IntPtr obj,   double pagerel_h,   double pagerel_v,    int pagesize_h,    int pagesize_v);
    public static Efl.Eo.FunctionWrapper<elm_interface_scrollable_paging_set_api_delegate> elm_interface_scrollable_paging_set_ptr = new Efl.Eo.FunctionWrapper<elm_interface_scrollable_paging_set_api_delegate>(_Module, "elm_interface_scrollable_paging_set");
    private static  void paging_set(System.IntPtr obj, System.IntPtr pd,  double pagerel_h,  double pagerel_v,   int pagesize_h,   int pagesize_v)
   {
      Eina.Log.Debug("function elm_interface_scrollable_paging_set was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                                                                          
         try {
            ((InterfaceScrollableConcrete)wrapper).SetPaging( pagerel_h,  pagerel_v,  pagesize_h,  pagesize_v);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                                                            } else {
         elm_interface_scrollable_paging_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  pagerel_h,  pagerel_v,  pagesize_h,  pagesize_v);
      }
   }
   private static elm_interface_scrollable_paging_set_delegate elm_interface_scrollable_paging_set_static_delegate;


    private delegate Elm.Scroller.SingleDirection elm_interface_scrollable_single_direction_get_delegate(System.IntPtr obj, System.IntPtr pd);


    public delegate Elm.Scroller.SingleDirection elm_interface_scrollable_single_direction_get_api_delegate(System.IntPtr obj);
    public static Efl.Eo.FunctionWrapper<elm_interface_scrollable_single_direction_get_api_delegate> elm_interface_scrollable_single_direction_get_ptr = new Efl.Eo.FunctionWrapper<elm_interface_scrollable_single_direction_get_api_delegate>(_Module, "elm_interface_scrollable_single_direction_get");
    private static Elm.Scroller.SingleDirection single_direction_get(System.IntPtr obj, System.IntPtr pd)
   {
      Eina.Log.Debug("function elm_interface_scrollable_single_direction_get was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                  Elm.Scroller.SingleDirection _ret_var = default(Elm.Scroller.SingleDirection);
         try {
            _ret_var = ((InterfaceScrollableConcrete)wrapper).GetSingleDirection();
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
      return _ret_var;
      } else {
         return elm_interface_scrollable_single_direction_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
      }
   }
   private static elm_interface_scrollable_single_direction_get_delegate elm_interface_scrollable_single_direction_get_static_delegate;


    private delegate  void elm_interface_scrollable_single_direction_set_delegate(System.IntPtr obj, System.IntPtr pd,   Elm.Scroller.SingleDirection single_dir);


    public delegate  void elm_interface_scrollable_single_direction_set_api_delegate(System.IntPtr obj,   Elm.Scroller.SingleDirection single_dir);
    public static Efl.Eo.FunctionWrapper<elm_interface_scrollable_single_direction_set_api_delegate> elm_interface_scrollable_single_direction_set_ptr = new Efl.Eo.FunctionWrapper<elm_interface_scrollable_single_direction_set_api_delegate>(_Module, "elm_interface_scrollable_single_direction_set");
    private static  void single_direction_set(System.IntPtr obj, System.IntPtr pd,  Elm.Scroller.SingleDirection single_dir)
   {
      Eina.Log.Debug("function elm_interface_scrollable_single_direction_set was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                    
         try {
            ((InterfaceScrollableConcrete)wrapper).SetSingleDirection( single_dir);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                        } else {
         elm_interface_scrollable_single_direction_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  single_dir);
      }
   }
   private static elm_interface_scrollable_single_direction_set_delegate elm_interface_scrollable_single_direction_set_static_delegate;


    private delegate  void elm_interface_scrollable_step_size_get_delegate(System.IntPtr obj, System.IntPtr pd,   out  int x,   out  int y);


    public delegate  void elm_interface_scrollable_step_size_get_api_delegate(System.IntPtr obj,   out  int x,   out  int y);
    public static Efl.Eo.FunctionWrapper<elm_interface_scrollable_step_size_get_api_delegate> elm_interface_scrollable_step_size_get_ptr = new Efl.Eo.FunctionWrapper<elm_interface_scrollable_step_size_get_api_delegate>(_Module, "elm_interface_scrollable_step_size_get");
    private static  void step_size_get(System.IntPtr obj, System.IntPtr pd,  out  int x,  out  int y)
   {
      Eina.Log.Debug("function elm_interface_scrollable_step_size_get was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                           x = default( int);      y = default( int);                     
         try {
            ((InterfaceScrollableConcrete)wrapper).GetStepSize( out x,  out y);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                                    } else {
         elm_interface_scrollable_step_size_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  out x,  out y);
      }
   }
   private static elm_interface_scrollable_step_size_get_delegate elm_interface_scrollable_step_size_get_static_delegate;


    private delegate  void elm_interface_scrollable_step_size_set_delegate(System.IntPtr obj, System.IntPtr pd,    int x,    int y);


    public delegate  void elm_interface_scrollable_step_size_set_api_delegate(System.IntPtr obj,    int x,    int y);
    public static Efl.Eo.FunctionWrapper<elm_interface_scrollable_step_size_set_api_delegate> elm_interface_scrollable_step_size_set_ptr = new Efl.Eo.FunctionWrapper<elm_interface_scrollable_step_size_set_api_delegate>(_Module, "elm_interface_scrollable_step_size_set");
    private static  void step_size_set(System.IntPtr obj, System.IntPtr pd,   int x,   int y)
   {
      Eina.Log.Debug("function elm_interface_scrollable_step_size_set was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                                      
         try {
            ((InterfaceScrollableConcrete)wrapper).SetStepSize( x,  y);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                                    } else {
         elm_interface_scrollable_step_size_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  x,  y);
      }
   }
   private static elm_interface_scrollable_step_size_set_delegate elm_interface_scrollable_step_size_set_static_delegate;


    private delegate  void elm_interface_scrollable_content_loop_get_delegate(System.IntPtr obj, System.IntPtr pd,  [MarshalAs(UnmanagedType.U1)]  out bool loop_h,  [MarshalAs(UnmanagedType.U1)]  out bool loop_v);


    public delegate  void elm_interface_scrollable_content_loop_get_api_delegate(System.IntPtr obj,  [MarshalAs(UnmanagedType.U1)]  out bool loop_h,  [MarshalAs(UnmanagedType.U1)]  out bool loop_v);
    public static Efl.Eo.FunctionWrapper<elm_interface_scrollable_content_loop_get_api_delegate> elm_interface_scrollable_content_loop_get_ptr = new Efl.Eo.FunctionWrapper<elm_interface_scrollable_content_loop_get_api_delegate>(_Module, "elm_interface_scrollable_content_loop_get");
    private static  void content_loop_get(System.IntPtr obj, System.IntPtr pd,  out bool loop_h,  out bool loop_v)
   {
      Eina.Log.Debug("function elm_interface_scrollable_content_loop_get was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                           loop_h = default(bool);      loop_v = default(bool);                     
         try {
            ((InterfaceScrollableConcrete)wrapper).GetContentLoop( out loop_h,  out loop_v);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                                    } else {
         elm_interface_scrollable_content_loop_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  out loop_h,  out loop_v);
      }
   }
   private static elm_interface_scrollable_content_loop_get_delegate elm_interface_scrollable_content_loop_get_static_delegate;


    private delegate  void elm_interface_scrollable_content_loop_set_delegate(System.IntPtr obj, System.IntPtr pd,  [MarshalAs(UnmanagedType.U1)]  bool loop_h,  [MarshalAs(UnmanagedType.U1)]  bool loop_v);


    public delegate  void elm_interface_scrollable_content_loop_set_api_delegate(System.IntPtr obj,  [MarshalAs(UnmanagedType.U1)]  bool loop_h,  [MarshalAs(UnmanagedType.U1)]  bool loop_v);
    public static Efl.Eo.FunctionWrapper<elm_interface_scrollable_content_loop_set_api_delegate> elm_interface_scrollable_content_loop_set_ptr = new Efl.Eo.FunctionWrapper<elm_interface_scrollable_content_loop_set_api_delegate>(_Module, "elm_interface_scrollable_content_loop_set");
    private static  void content_loop_set(System.IntPtr obj, System.IntPtr pd,  bool loop_h,  bool loop_v)
   {
      Eina.Log.Debug("function elm_interface_scrollable_content_loop_set was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                                      
         try {
            ((InterfaceScrollableConcrete)wrapper).SetContentLoop( loop_h,  loop_v);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                                    } else {
         elm_interface_scrollable_content_loop_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  loop_h,  loop_v);
      }
   }
   private static elm_interface_scrollable_content_loop_set_delegate elm_interface_scrollable_content_loop_set_static_delegate;


    private delegate  void elm_interface_scrollable_scroll_up_cb_set_delegate(System.IntPtr obj, System.IntPtr pd,   ElmInterfaceScrollableCb scroll_up_cb);


    public delegate  void elm_interface_scrollable_scroll_up_cb_set_api_delegate(System.IntPtr obj,   ElmInterfaceScrollableCb scroll_up_cb);
    public static Efl.Eo.FunctionWrapper<elm_interface_scrollable_scroll_up_cb_set_api_delegate> elm_interface_scrollable_scroll_up_cb_set_ptr = new Efl.Eo.FunctionWrapper<elm_interface_scrollable_scroll_up_cb_set_api_delegate>(_Module, "elm_interface_scrollable_scroll_up_cb_set");
    private static  void scroll_up_cb_set(System.IntPtr obj, System.IntPtr pd,  ElmInterfaceScrollableCb scroll_up_cb)
   {
      Eina.Log.Debug("function elm_interface_scrollable_scroll_up_cb_set was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                    
         try {
            ((InterfaceScrollableConcrete)wrapper).SetScrollUpCb( scroll_up_cb);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                        } else {
         elm_interface_scrollable_scroll_up_cb_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  scroll_up_cb);
      }
   }
   private static elm_interface_scrollable_scroll_up_cb_set_delegate elm_interface_scrollable_scroll_up_cb_set_static_delegate;


    private delegate  void elm_interface_scrollable_hbar_drag_cb_set_delegate(System.IntPtr obj, System.IntPtr pd,   ElmInterfaceScrollableCb hbar_drag_cb);


    public delegate  void elm_interface_scrollable_hbar_drag_cb_set_api_delegate(System.IntPtr obj,   ElmInterfaceScrollableCb hbar_drag_cb);
    public static Efl.Eo.FunctionWrapper<elm_interface_scrollable_hbar_drag_cb_set_api_delegate> elm_interface_scrollable_hbar_drag_cb_set_ptr = new Efl.Eo.FunctionWrapper<elm_interface_scrollable_hbar_drag_cb_set_api_delegate>(_Module, "elm_interface_scrollable_hbar_drag_cb_set");
    private static  void hbar_drag_cb_set(System.IntPtr obj, System.IntPtr pd,  ElmInterfaceScrollableCb hbar_drag_cb)
   {
      Eina.Log.Debug("function elm_interface_scrollable_hbar_drag_cb_set was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                    
         try {
            ((InterfaceScrollableConcrete)wrapper).SetHbarDragCb( hbar_drag_cb);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                        } else {
         elm_interface_scrollable_hbar_drag_cb_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  hbar_drag_cb);
      }
   }
   private static elm_interface_scrollable_hbar_drag_cb_set_delegate elm_interface_scrollable_hbar_drag_cb_set_static_delegate;


    private delegate  void elm_interface_scrollable_drag_start_cb_set_delegate(System.IntPtr obj, System.IntPtr pd,   ElmInterfaceScrollableCb drag_start_cb);


    public delegate  void elm_interface_scrollable_drag_start_cb_set_api_delegate(System.IntPtr obj,   ElmInterfaceScrollableCb drag_start_cb);
    public static Efl.Eo.FunctionWrapper<elm_interface_scrollable_drag_start_cb_set_api_delegate> elm_interface_scrollable_drag_start_cb_set_ptr = new Efl.Eo.FunctionWrapper<elm_interface_scrollable_drag_start_cb_set_api_delegate>(_Module, "elm_interface_scrollable_drag_start_cb_set");
    private static  void drag_start_cb_set(System.IntPtr obj, System.IntPtr pd,  ElmInterfaceScrollableCb drag_start_cb)
   {
      Eina.Log.Debug("function elm_interface_scrollable_drag_start_cb_set was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                    
         try {
            ((InterfaceScrollableConcrete)wrapper).SetDragStartCb( drag_start_cb);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                        } else {
         elm_interface_scrollable_drag_start_cb_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  drag_start_cb);
      }
   }
   private static elm_interface_scrollable_drag_start_cb_set_delegate elm_interface_scrollable_drag_start_cb_set_static_delegate;


    private delegate  void elm_interface_scrollable_scroll_start_cb_set_delegate(System.IntPtr obj, System.IntPtr pd,   ElmInterfaceScrollableCb scroll_start_cb);


    public delegate  void elm_interface_scrollable_scroll_start_cb_set_api_delegate(System.IntPtr obj,   ElmInterfaceScrollableCb scroll_start_cb);
    public static Efl.Eo.FunctionWrapper<elm_interface_scrollable_scroll_start_cb_set_api_delegate> elm_interface_scrollable_scroll_start_cb_set_ptr = new Efl.Eo.FunctionWrapper<elm_interface_scrollable_scroll_start_cb_set_api_delegate>(_Module, "elm_interface_scrollable_scroll_start_cb_set");
    private static  void scroll_start_cb_set(System.IntPtr obj, System.IntPtr pd,  ElmInterfaceScrollableCb scroll_start_cb)
   {
      Eina.Log.Debug("function elm_interface_scrollable_scroll_start_cb_set was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                    
         try {
            ((InterfaceScrollableConcrete)wrapper).SetScrollStartCb( scroll_start_cb);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                        } else {
         elm_interface_scrollable_scroll_start_cb_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  scroll_start_cb);
      }
   }
   private static elm_interface_scrollable_scroll_start_cb_set_delegate elm_interface_scrollable_scroll_start_cb_set_static_delegate;


    private delegate  void elm_interface_scrollable_freeze_set_delegate(System.IntPtr obj, System.IntPtr pd,  [MarshalAs(UnmanagedType.U1)]  bool freeze);


    public delegate  void elm_interface_scrollable_freeze_set_api_delegate(System.IntPtr obj,  [MarshalAs(UnmanagedType.U1)]  bool freeze);
    public static Efl.Eo.FunctionWrapper<elm_interface_scrollable_freeze_set_api_delegate> elm_interface_scrollable_freeze_set_ptr = new Efl.Eo.FunctionWrapper<elm_interface_scrollable_freeze_set_api_delegate>(_Module, "elm_interface_scrollable_freeze_set");
    private static  void freeze_set(System.IntPtr obj, System.IntPtr pd,  bool freeze)
   {
      Eina.Log.Debug("function elm_interface_scrollable_freeze_set was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                    
         try {
            ((InterfaceScrollableConcrete)wrapper).SetFreeze( freeze);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                        } else {
         elm_interface_scrollable_freeze_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  freeze);
      }
   }
   private static elm_interface_scrollable_freeze_set_delegate elm_interface_scrollable_freeze_set_static_delegate;


    private delegate  void elm_interface_scrollable_content_viewport_resize_cb_set_delegate(System.IntPtr obj, System.IntPtr pd,   ElmInterfaceScrollableResizeCb viewport_resize_cb);


    public delegate  void elm_interface_scrollable_content_viewport_resize_cb_set_api_delegate(System.IntPtr obj,   ElmInterfaceScrollableResizeCb viewport_resize_cb);
    public static Efl.Eo.FunctionWrapper<elm_interface_scrollable_content_viewport_resize_cb_set_api_delegate> elm_interface_scrollable_content_viewport_resize_cb_set_ptr = new Efl.Eo.FunctionWrapper<elm_interface_scrollable_content_viewport_resize_cb_set_api_delegate>(_Module, "elm_interface_scrollable_content_viewport_resize_cb_set");
    private static  void content_viewport_resize_cb_set(System.IntPtr obj, System.IntPtr pd,  ElmInterfaceScrollableResizeCb viewport_resize_cb)
   {
      Eina.Log.Debug("function elm_interface_scrollable_content_viewport_resize_cb_set was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                    
         try {
            ((InterfaceScrollableConcrete)wrapper).SetContentViewportResizeCb( viewport_resize_cb);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                        } else {
         elm_interface_scrollable_content_viewport_resize_cb_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  viewport_resize_cb);
      }
   }
   private static elm_interface_scrollable_content_viewport_resize_cb_set_delegate elm_interface_scrollable_content_viewport_resize_cb_set_static_delegate;


    private delegate  void elm_interface_scrollable_scroll_left_cb_set_delegate(System.IntPtr obj, System.IntPtr pd,   ElmInterfaceScrollableCb scroll_left_cb);


    public delegate  void elm_interface_scrollable_scroll_left_cb_set_api_delegate(System.IntPtr obj,   ElmInterfaceScrollableCb scroll_left_cb);
    public static Efl.Eo.FunctionWrapper<elm_interface_scrollable_scroll_left_cb_set_api_delegate> elm_interface_scrollable_scroll_left_cb_set_ptr = new Efl.Eo.FunctionWrapper<elm_interface_scrollable_scroll_left_cb_set_api_delegate>(_Module, "elm_interface_scrollable_scroll_left_cb_set");
    private static  void scroll_left_cb_set(System.IntPtr obj, System.IntPtr pd,  ElmInterfaceScrollableCb scroll_left_cb)
   {
      Eina.Log.Debug("function elm_interface_scrollable_scroll_left_cb_set was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                    
         try {
            ((InterfaceScrollableConcrete)wrapper).SetScrollLeftCb( scroll_left_cb);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                        } else {
         elm_interface_scrollable_scroll_left_cb_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  scroll_left_cb);
      }
   }
   private static elm_interface_scrollable_scroll_left_cb_set_delegate elm_interface_scrollable_scroll_left_cb_set_static_delegate;


    private delegate  void elm_interface_scrollable_vbar_press_cb_set_delegate(System.IntPtr obj, System.IntPtr pd,   ElmInterfaceScrollableCb vbar_press_cb);


    public delegate  void elm_interface_scrollable_vbar_press_cb_set_api_delegate(System.IntPtr obj,   ElmInterfaceScrollableCb vbar_press_cb);
    public static Efl.Eo.FunctionWrapper<elm_interface_scrollable_vbar_press_cb_set_api_delegate> elm_interface_scrollable_vbar_press_cb_set_ptr = new Efl.Eo.FunctionWrapper<elm_interface_scrollable_vbar_press_cb_set_api_delegate>(_Module, "elm_interface_scrollable_vbar_press_cb_set");
    private static  void vbar_press_cb_set(System.IntPtr obj, System.IntPtr pd,  ElmInterfaceScrollableCb vbar_press_cb)
   {
      Eina.Log.Debug("function elm_interface_scrollable_vbar_press_cb_set was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                    
         try {
            ((InterfaceScrollableConcrete)wrapper).SetVbarPressCb( vbar_press_cb);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                        } else {
         elm_interface_scrollable_vbar_press_cb_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  vbar_press_cb);
      }
   }
   private static elm_interface_scrollable_vbar_press_cb_set_delegate elm_interface_scrollable_vbar_press_cb_set_static_delegate;


    private delegate  void elm_interface_scrollable_hbar_press_cb_set_delegate(System.IntPtr obj, System.IntPtr pd,   ElmInterfaceScrollableCb hbar_press_cb);


    public delegate  void elm_interface_scrollable_hbar_press_cb_set_api_delegate(System.IntPtr obj,   ElmInterfaceScrollableCb hbar_press_cb);
    public static Efl.Eo.FunctionWrapper<elm_interface_scrollable_hbar_press_cb_set_api_delegate> elm_interface_scrollable_hbar_press_cb_set_ptr = new Efl.Eo.FunctionWrapper<elm_interface_scrollable_hbar_press_cb_set_api_delegate>(_Module, "elm_interface_scrollable_hbar_press_cb_set");
    private static  void hbar_press_cb_set(System.IntPtr obj, System.IntPtr pd,  ElmInterfaceScrollableCb hbar_press_cb)
   {
      Eina.Log.Debug("function elm_interface_scrollable_hbar_press_cb_set was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                    
         try {
            ((InterfaceScrollableConcrete)wrapper).SetHbarPressCb( hbar_press_cb);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                        } else {
         elm_interface_scrollable_hbar_press_cb_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  hbar_press_cb);
      }
   }
   private static elm_interface_scrollable_hbar_press_cb_set_delegate elm_interface_scrollable_hbar_press_cb_set_static_delegate;


    private delegate  void elm_interface_scrollable_hbar_unpress_cb_set_delegate(System.IntPtr obj, System.IntPtr pd,   ElmInterfaceScrollableCb hbar_unpress_cb);


    public delegate  void elm_interface_scrollable_hbar_unpress_cb_set_api_delegate(System.IntPtr obj,   ElmInterfaceScrollableCb hbar_unpress_cb);
    public static Efl.Eo.FunctionWrapper<elm_interface_scrollable_hbar_unpress_cb_set_api_delegate> elm_interface_scrollable_hbar_unpress_cb_set_ptr = new Efl.Eo.FunctionWrapper<elm_interface_scrollable_hbar_unpress_cb_set_api_delegate>(_Module, "elm_interface_scrollable_hbar_unpress_cb_set");
    private static  void hbar_unpress_cb_set(System.IntPtr obj, System.IntPtr pd,  ElmInterfaceScrollableCb hbar_unpress_cb)
   {
      Eina.Log.Debug("function elm_interface_scrollable_hbar_unpress_cb_set was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                    
         try {
            ((InterfaceScrollableConcrete)wrapper).SetHbarUnpressCb( hbar_unpress_cb);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                        } else {
         elm_interface_scrollable_hbar_unpress_cb_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  hbar_unpress_cb);
      }
   }
   private static elm_interface_scrollable_hbar_unpress_cb_set_delegate elm_interface_scrollable_hbar_unpress_cb_set_static_delegate;


    private delegate  void elm_interface_scrollable_drag_stop_cb_set_delegate(System.IntPtr obj, System.IntPtr pd,   ElmInterfaceScrollableCb drag_stop_cb);


    public delegate  void elm_interface_scrollable_drag_stop_cb_set_api_delegate(System.IntPtr obj,   ElmInterfaceScrollableCb drag_stop_cb);
    public static Efl.Eo.FunctionWrapper<elm_interface_scrollable_drag_stop_cb_set_api_delegate> elm_interface_scrollable_drag_stop_cb_set_ptr = new Efl.Eo.FunctionWrapper<elm_interface_scrollable_drag_stop_cb_set_api_delegate>(_Module, "elm_interface_scrollable_drag_stop_cb_set");
    private static  void drag_stop_cb_set(System.IntPtr obj, System.IntPtr pd,  ElmInterfaceScrollableCb drag_stop_cb)
   {
      Eina.Log.Debug("function elm_interface_scrollable_drag_stop_cb_set was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                    
         try {
            ((InterfaceScrollableConcrete)wrapper).SetDragStopCb( drag_stop_cb);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                        } else {
         elm_interface_scrollable_drag_stop_cb_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  drag_stop_cb);
      }
   }
   private static elm_interface_scrollable_drag_stop_cb_set_delegate elm_interface_scrollable_drag_stop_cb_set_static_delegate;


    private delegate  void elm_interface_scrollable_scroll_stop_cb_set_delegate(System.IntPtr obj, System.IntPtr pd,   ElmInterfaceScrollableCb scroll_stop_cb);


    public delegate  void elm_interface_scrollable_scroll_stop_cb_set_api_delegate(System.IntPtr obj,   ElmInterfaceScrollableCb scroll_stop_cb);
    public static Efl.Eo.FunctionWrapper<elm_interface_scrollable_scroll_stop_cb_set_api_delegate> elm_interface_scrollable_scroll_stop_cb_set_ptr = new Efl.Eo.FunctionWrapper<elm_interface_scrollable_scroll_stop_cb_set_api_delegate>(_Module, "elm_interface_scrollable_scroll_stop_cb_set");
    private static  void scroll_stop_cb_set(System.IntPtr obj, System.IntPtr pd,  ElmInterfaceScrollableCb scroll_stop_cb)
   {
      Eina.Log.Debug("function elm_interface_scrollable_scroll_stop_cb_set was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                    
         try {
            ((InterfaceScrollableConcrete)wrapper).SetScrollStopCb( scroll_stop_cb);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                        } else {
         elm_interface_scrollable_scroll_stop_cb_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  scroll_stop_cb);
      }
   }
   private static elm_interface_scrollable_scroll_stop_cb_set_delegate elm_interface_scrollable_scroll_stop_cb_set_static_delegate;


    private delegate  void elm_interface_scrollable_extern_pan_set_delegate(System.IntPtr obj, System.IntPtr pd, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Canvas.Object, Efl.Eo.NonOwnTag>))]  Efl.Canvas.Object pan);


    public delegate  void elm_interface_scrollable_extern_pan_set_api_delegate(System.IntPtr obj, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Canvas.Object, Efl.Eo.NonOwnTag>))]  Efl.Canvas.Object pan);
    public static Efl.Eo.FunctionWrapper<elm_interface_scrollable_extern_pan_set_api_delegate> elm_interface_scrollable_extern_pan_set_ptr = new Efl.Eo.FunctionWrapper<elm_interface_scrollable_extern_pan_set_api_delegate>(_Module, "elm_interface_scrollable_extern_pan_set");
    private static  void extern_pan_set(System.IntPtr obj, System.IntPtr pd,  Efl.Canvas.Object pan)
   {
      Eina.Log.Debug("function elm_interface_scrollable_extern_pan_set was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                    
         try {
            ((InterfaceScrollableConcrete)wrapper).SetExternPan( pan);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                        } else {
         elm_interface_scrollable_extern_pan_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  pan);
      }
   }
   private static elm_interface_scrollable_extern_pan_set_delegate elm_interface_scrollable_extern_pan_set_static_delegate;


    private delegate  void elm_interface_scrollable_page_change_cb_set_delegate(System.IntPtr obj, System.IntPtr pd,   ElmInterfaceScrollableCb page_change_cb);


    public delegate  void elm_interface_scrollable_page_change_cb_set_api_delegate(System.IntPtr obj,   ElmInterfaceScrollableCb page_change_cb);
    public static Efl.Eo.FunctionWrapper<elm_interface_scrollable_page_change_cb_set_api_delegate> elm_interface_scrollable_page_change_cb_set_ptr = new Efl.Eo.FunctionWrapper<elm_interface_scrollable_page_change_cb_set_api_delegate>(_Module, "elm_interface_scrollable_page_change_cb_set");
    private static  void page_change_cb_set(System.IntPtr obj, System.IntPtr pd,  ElmInterfaceScrollableCb page_change_cb)
   {
      Eina.Log.Debug("function elm_interface_scrollable_page_change_cb_set was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                    
         try {
            ((InterfaceScrollableConcrete)wrapper).SetPageChangeCb( page_change_cb);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                        } else {
         elm_interface_scrollable_page_change_cb_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  page_change_cb);
      }
   }
   private static elm_interface_scrollable_page_change_cb_set_delegate elm_interface_scrollable_page_change_cb_set_static_delegate;


    private delegate  void elm_interface_scrollable_hold_set_delegate(System.IntPtr obj, System.IntPtr pd,  [MarshalAs(UnmanagedType.U1)]  bool hold);


    public delegate  void elm_interface_scrollable_hold_set_api_delegate(System.IntPtr obj,  [MarshalAs(UnmanagedType.U1)]  bool hold);
    public static Efl.Eo.FunctionWrapper<elm_interface_scrollable_hold_set_api_delegate> elm_interface_scrollable_hold_set_ptr = new Efl.Eo.FunctionWrapper<elm_interface_scrollable_hold_set_api_delegate>(_Module, "elm_interface_scrollable_hold_set");
    private static  void hold_set(System.IntPtr obj, System.IntPtr pd,  bool hold)
   {
      Eina.Log.Debug("function elm_interface_scrollable_hold_set was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                    
         try {
            ((InterfaceScrollableConcrete)wrapper).SetHold( hold);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                        } else {
         elm_interface_scrollable_hold_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  hold);
      }
   }
   private static elm_interface_scrollable_hold_set_delegate elm_interface_scrollable_hold_set_static_delegate;


    private delegate  void elm_interface_scrollable_animate_start_cb_set_delegate(System.IntPtr obj, System.IntPtr pd,   ElmInterfaceScrollableCb animate_start_cb);


    public delegate  void elm_interface_scrollable_animate_start_cb_set_api_delegate(System.IntPtr obj,   ElmInterfaceScrollableCb animate_start_cb);
    public static Efl.Eo.FunctionWrapper<elm_interface_scrollable_animate_start_cb_set_api_delegate> elm_interface_scrollable_animate_start_cb_set_ptr = new Efl.Eo.FunctionWrapper<elm_interface_scrollable_animate_start_cb_set_api_delegate>(_Module, "elm_interface_scrollable_animate_start_cb_set");
    private static  void animate_start_cb_set(System.IntPtr obj, System.IntPtr pd,  ElmInterfaceScrollableCb animate_start_cb)
   {
      Eina.Log.Debug("function elm_interface_scrollable_animate_start_cb_set was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                    
         try {
            ((InterfaceScrollableConcrete)wrapper).SetAnimateStartCb( animate_start_cb);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                        } else {
         elm_interface_scrollable_animate_start_cb_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  animate_start_cb);
      }
   }
   private static elm_interface_scrollable_animate_start_cb_set_delegate elm_interface_scrollable_animate_start_cb_set_static_delegate;


    private delegate  void elm_interface_scrollable_scroll_down_cb_set_delegate(System.IntPtr obj, System.IntPtr pd,   ElmInterfaceScrollableCb scroll_down_cb);


    public delegate  void elm_interface_scrollable_scroll_down_cb_set_api_delegate(System.IntPtr obj,   ElmInterfaceScrollableCb scroll_down_cb);
    public static Efl.Eo.FunctionWrapper<elm_interface_scrollable_scroll_down_cb_set_api_delegate> elm_interface_scrollable_scroll_down_cb_set_ptr = new Efl.Eo.FunctionWrapper<elm_interface_scrollable_scroll_down_cb_set_api_delegate>(_Module, "elm_interface_scrollable_scroll_down_cb_set");
    private static  void scroll_down_cb_set(System.IntPtr obj, System.IntPtr pd,  ElmInterfaceScrollableCb scroll_down_cb)
   {
      Eina.Log.Debug("function elm_interface_scrollable_scroll_down_cb_set was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                    
         try {
            ((InterfaceScrollableConcrete)wrapper).SetScrollDownCb( scroll_down_cb);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                        } else {
         elm_interface_scrollable_scroll_down_cb_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  scroll_down_cb);
      }
   }
   private static elm_interface_scrollable_scroll_down_cb_set_delegate elm_interface_scrollable_scroll_down_cb_set_static_delegate;


    private delegate  void elm_interface_scrollable_page_relative_set_delegate(System.IntPtr obj, System.IntPtr pd,   double h_pagerel,   double v_pagerel);


    public delegate  void elm_interface_scrollable_page_relative_set_api_delegate(System.IntPtr obj,   double h_pagerel,   double v_pagerel);
    public static Efl.Eo.FunctionWrapper<elm_interface_scrollable_page_relative_set_api_delegate> elm_interface_scrollable_page_relative_set_ptr = new Efl.Eo.FunctionWrapper<elm_interface_scrollable_page_relative_set_api_delegate>(_Module, "elm_interface_scrollable_page_relative_set");
    private static  void page_relative_set(System.IntPtr obj, System.IntPtr pd,  double h_pagerel,  double v_pagerel)
   {
      Eina.Log.Debug("function elm_interface_scrollable_page_relative_set was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                                      
         try {
            ((InterfaceScrollableConcrete)wrapper).SetPageRelative( h_pagerel,  v_pagerel);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                                    } else {
         elm_interface_scrollable_page_relative_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  h_pagerel,  v_pagerel);
      }
   }
   private static elm_interface_scrollable_page_relative_set_delegate elm_interface_scrollable_page_relative_set_static_delegate;


    private delegate  void elm_interface_scrollable_scroll_cb_set_delegate(System.IntPtr obj, System.IntPtr pd,   ElmInterfaceScrollableCb scroll_cb);


    public delegate  void elm_interface_scrollable_scroll_cb_set_api_delegate(System.IntPtr obj,   ElmInterfaceScrollableCb scroll_cb);
    public static Efl.Eo.FunctionWrapper<elm_interface_scrollable_scroll_cb_set_api_delegate> elm_interface_scrollable_scroll_cb_set_ptr = new Efl.Eo.FunctionWrapper<elm_interface_scrollable_scroll_cb_set_api_delegate>(_Module, "elm_interface_scrollable_scroll_cb_set");
    private static  void scroll_cb_set(System.IntPtr obj, System.IntPtr pd,  ElmInterfaceScrollableCb scroll_cb)
   {
      Eina.Log.Debug("function elm_interface_scrollable_scroll_cb_set was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                    
         try {
            ((InterfaceScrollableConcrete)wrapper).SetScrollCb( scroll_cb);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                        } else {
         elm_interface_scrollable_scroll_cb_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  scroll_cb);
      }
   }
   private static elm_interface_scrollable_scroll_cb_set_delegate elm_interface_scrollable_scroll_cb_set_static_delegate;


    private delegate  void elm_interface_scrollable_animate_stop_cb_set_delegate(System.IntPtr obj, System.IntPtr pd,   ElmInterfaceScrollableCb animate_stop_cb);


    public delegate  void elm_interface_scrollable_animate_stop_cb_set_api_delegate(System.IntPtr obj,   ElmInterfaceScrollableCb animate_stop_cb);
    public static Efl.Eo.FunctionWrapper<elm_interface_scrollable_animate_stop_cb_set_api_delegate> elm_interface_scrollable_animate_stop_cb_set_ptr = new Efl.Eo.FunctionWrapper<elm_interface_scrollable_animate_stop_cb_set_api_delegate>(_Module, "elm_interface_scrollable_animate_stop_cb_set");
    private static  void animate_stop_cb_set(System.IntPtr obj, System.IntPtr pd,  ElmInterfaceScrollableCb animate_stop_cb)
   {
      Eina.Log.Debug("function elm_interface_scrollable_animate_stop_cb_set was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                    
         try {
            ((InterfaceScrollableConcrete)wrapper).SetAnimateStopCb( animate_stop_cb);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                        } else {
         elm_interface_scrollable_animate_stop_cb_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  animate_stop_cb);
      }
   }
   private static elm_interface_scrollable_animate_stop_cb_set_delegate elm_interface_scrollable_animate_stop_cb_set_static_delegate;


    private delegate  void elm_interface_scrollable_content_min_limit_cb_set_delegate(System.IntPtr obj, System.IntPtr pd,   ElmInterfaceScrollableMinLimitCb min_limit_cb);


    public delegate  void elm_interface_scrollable_content_min_limit_cb_set_api_delegate(System.IntPtr obj,   ElmInterfaceScrollableMinLimitCb min_limit_cb);
    public static Efl.Eo.FunctionWrapper<elm_interface_scrollable_content_min_limit_cb_set_api_delegate> elm_interface_scrollable_content_min_limit_cb_set_ptr = new Efl.Eo.FunctionWrapper<elm_interface_scrollable_content_min_limit_cb_set_api_delegate>(_Module, "elm_interface_scrollable_content_min_limit_cb_set");
    private static  void content_min_limit_cb_set(System.IntPtr obj, System.IntPtr pd,  ElmInterfaceScrollableMinLimitCb min_limit_cb)
   {
      Eina.Log.Debug("function elm_interface_scrollable_content_min_limit_cb_set was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                    
         try {
            ((InterfaceScrollableConcrete)wrapper).SetContentMinLimitCb( min_limit_cb);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                        } else {
         elm_interface_scrollable_content_min_limit_cb_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  min_limit_cb);
      }
   }
   private static elm_interface_scrollable_content_min_limit_cb_set_delegate elm_interface_scrollable_content_min_limit_cb_set_static_delegate;


    private delegate  void elm_interface_scrollable_scroll_right_cb_set_delegate(System.IntPtr obj, System.IntPtr pd,   ElmInterfaceScrollableCb scroll_right_cb);


    public delegate  void elm_interface_scrollable_scroll_right_cb_set_api_delegate(System.IntPtr obj,   ElmInterfaceScrollableCb scroll_right_cb);
    public static Efl.Eo.FunctionWrapper<elm_interface_scrollable_scroll_right_cb_set_api_delegate> elm_interface_scrollable_scroll_right_cb_set_ptr = new Efl.Eo.FunctionWrapper<elm_interface_scrollable_scroll_right_cb_set_api_delegate>(_Module, "elm_interface_scrollable_scroll_right_cb_set");
    private static  void scroll_right_cb_set(System.IntPtr obj, System.IntPtr pd,  ElmInterfaceScrollableCb scroll_right_cb)
   {
      Eina.Log.Debug("function elm_interface_scrollable_scroll_right_cb_set was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                    
         try {
            ((InterfaceScrollableConcrete)wrapper).SetScrollRightCb( scroll_right_cb);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                        } else {
         elm_interface_scrollable_scroll_right_cb_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  scroll_right_cb);
      }
   }
   private static elm_interface_scrollable_scroll_right_cb_set_delegate elm_interface_scrollable_scroll_right_cb_set_static_delegate;


    private delegate  void elm_interface_scrollable_content_set_delegate(System.IntPtr obj, System.IntPtr pd, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Canvas.Object, Efl.Eo.NonOwnTag>))]  Efl.Canvas.Object content);


    public delegate  void elm_interface_scrollable_content_set_api_delegate(System.IntPtr obj, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Canvas.Object, Efl.Eo.NonOwnTag>))]  Efl.Canvas.Object content);
    public static Efl.Eo.FunctionWrapper<elm_interface_scrollable_content_set_api_delegate> elm_interface_scrollable_content_set_ptr = new Efl.Eo.FunctionWrapper<elm_interface_scrollable_content_set_api_delegate>(_Module, "elm_interface_scrollable_content_set");
    private static  void scrollable_content_set(System.IntPtr obj, System.IntPtr pd,  Efl.Canvas.Object content)
   {
      Eina.Log.Debug("function elm_interface_scrollable_content_set was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                    
         try {
            ((InterfaceScrollableConcrete)wrapper).SetScrollableContent( content);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                        } else {
         elm_interface_scrollable_content_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  content);
      }
   }
   private static elm_interface_scrollable_content_set_delegate elm_interface_scrollable_content_set_static_delegate;


    private delegate  void elm_interface_scrollable_edge_left_cb_set_delegate(System.IntPtr obj, System.IntPtr pd,   ElmInterfaceScrollableCb edge_left_cb);


    public delegate  void elm_interface_scrollable_edge_left_cb_set_api_delegate(System.IntPtr obj,   ElmInterfaceScrollableCb edge_left_cb);
    public static Efl.Eo.FunctionWrapper<elm_interface_scrollable_edge_left_cb_set_api_delegate> elm_interface_scrollable_edge_left_cb_set_ptr = new Efl.Eo.FunctionWrapper<elm_interface_scrollable_edge_left_cb_set_api_delegate>(_Module, "elm_interface_scrollable_edge_left_cb_set");
    private static  void edge_left_cb_set(System.IntPtr obj, System.IntPtr pd,  ElmInterfaceScrollableCb edge_left_cb)
   {
      Eina.Log.Debug("function elm_interface_scrollable_edge_left_cb_set was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                    
         try {
            ((InterfaceScrollableConcrete)wrapper).SetEdgeLeftCb( edge_left_cb);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                        } else {
         elm_interface_scrollable_edge_left_cb_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  edge_left_cb);
      }
   }
   private static elm_interface_scrollable_edge_left_cb_set_delegate elm_interface_scrollable_edge_left_cb_set_static_delegate;


    private delegate  void elm_interface_scrollable_vbar_drag_cb_set_delegate(System.IntPtr obj, System.IntPtr pd,   ElmInterfaceScrollableCb vbar_drag_cb);


    public delegate  void elm_interface_scrollable_vbar_drag_cb_set_api_delegate(System.IntPtr obj,   ElmInterfaceScrollableCb vbar_drag_cb);
    public static Efl.Eo.FunctionWrapper<elm_interface_scrollable_vbar_drag_cb_set_api_delegate> elm_interface_scrollable_vbar_drag_cb_set_ptr = new Efl.Eo.FunctionWrapper<elm_interface_scrollable_vbar_drag_cb_set_api_delegate>(_Module, "elm_interface_scrollable_vbar_drag_cb_set");
    private static  void vbar_drag_cb_set(System.IntPtr obj, System.IntPtr pd,  ElmInterfaceScrollableCb vbar_drag_cb)
   {
      Eina.Log.Debug("function elm_interface_scrollable_vbar_drag_cb_set was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                    
         try {
            ((InterfaceScrollableConcrete)wrapper).SetVbarDragCb( vbar_drag_cb);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                        } else {
         elm_interface_scrollable_vbar_drag_cb_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  vbar_drag_cb);
      }
   }
   private static elm_interface_scrollable_vbar_drag_cb_set_delegate elm_interface_scrollable_vbar_drag_cb_set_static_delegate;


    private delegate  void elm_interface_scrollable_vbar_unpress_cb_set_delegate(System.IntPtr obj, System.IntPtr pd,   ElmInterfaceScrollableCb vbar_unpress_cb);


    public delegate  void elm_interface_scrollable_vbar_unpress_cb_set_api_delegate(System.IntPtr obj,   ElmInterfaceScrollableCb vbar_unpress_cb);
    public static Efl.Eo.FunctionWrapper<elm_interface_scrollable_vbar_unpress_cb_set_api_delegate> elm_interface_scrollable_vbar_unpress_cb_set_ptr = new Efl.Eo.FunctionWrapper<elm_interface_scrollable_vbar_unpress_cb_set_api_delegate>(_Module, "elm_interface_scrollable_vbar_unpress_cb_set");
    private static  void vbar_unpress_cb_set(System.IntPtr obj, System.IntPtr pd,  ElmInterfaceScrollableCb vbar_unpress_cb)
   {
      Eina.Log.Debug("function elm_interface_scrollable_vbar_unpress_cb_set was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                    
         try {
            ((InterfaceScrollableConcrete)wrapper).SetVbarUnpressCb( vbar_unpress_cb);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                        } else {
         elm_interface_scrollable_vbar_unpress_cb_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  vbar_unpress_cb);
      }
   }
   private static elm_interface_scrollable_vbar_unpress_cb_set_delegate elm_interface_scrollable_vbar_unpress_cb_set_static_delegate;


    private delegate  void elm_interface_scrollable_edge_bottom_cb_set_delegate(System.IntPtr obj, System.IntPtr pd,   ElmInterfaceScrollableCb edge_bottom_cb);


    public delegate  void elm_interface_scrollable_edge_bottom_cb_set_api_delegate(System.IntPtr obj,   ElmInterfaceScrollableCb edge_bottom_cb);
    public static Efl.Eo.FunctionWrapper<elm_interface_scrollable_edge_bottom_cb_set_api_delegate> elm_interface_scrollable_edge_bottom_cb_set_ptr = new Efl.Eo.FunctionWrapper<elm_interface_scrollable_edge_bottom_cb_set_api_delegate>(_Module, "elm_interface_scrollable_edge_bottom_cb_set");
    private static  void edge_bottom_cb_set(System.IntPtr obj, System.IntPtr pd,  ElmInterfaceScrollableCb edge_bottom_cb)
   {
      Eina.Log.Debug("function elm_interface_scrollable_edge_bottom_cb_set was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                    
         try {
            ((InterfaceScrollableConcrete)wrapper).SetEdgeBottomCb( edge_bottom_cb);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                        } else {
         elm_interface_scrollable_edge_bottom_cb_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  edge_bottom_cb);
      }
   }
   private static elm_interface_scrollable_edge_bottom_cb_set_delegate elm_interface_scrollable_edge_bottom_cb_set_static_delegate;


    private delegate  void elm_interface_scrollable_edge_right_cb_set_delegate(System.IntPtr obj, System.IntPtr pd,   ElmInterfaceScrollableCb edge_right_cb);


    public delegate  void elm_interface_scrollable_edge_right_cb_set_api_delegate(System.IntPtr obj,   ElmInterfaceScrollableCb edge_right_cb);
    public static Efl.Eo.FunctionWrapper<elm_interface_scrollable_edge_right_cb_set_api_delegate> elm_interface_scrollable_edge_right_cb_set_ptr = new Efl.Eo.FunctionWrapper<elm_interface_scrollable_edge_right_cb_set_api_delegate>(_Module, "elm_interface_scrollable_edge_right_cb_set");
    private static  void edge_right_cb_set(System.IntPtr obj, System.IntPtr pd,  ElmInterfaceScrollableCb edge_right_cb)
   {
      Eina.Log.Debug("function elm_interface_scrollable_edge_right_cb_set was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                    
         try {
            ((InterfaceScrollableConcrete)wrapper).SetEdgeRightCb( edge_right_cb);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                        } else {
         elm_interface_scrollable_edge_right_cb_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  edge_right_cb);
      }
   }
   private static elm_interface_scrollable_edge_right_cb_set_delegate elm_interface_scrollable_edge_right_cb_set_static_delegate;


    private delegate  void elm_interface_scrollable_edge_top_cb_set_delegate(System.IntPtr obj, System.IntPtr pd,   ElmInterfaceScrollableCb edge_top_cb);


    public delegate  void elm_interface_scrollable_edge_top_cb_set_api_delegate(System.IntPtr obj,   ElmInterfaceScrollableCb edge_top_cb);
    public static Efl.Eo.FunctionWrapper<elm_interface_scrollable_edge_top_cb_set_api_delegate> elm_interface_scrollable_edge_top_cb_set_ptr = new Efl.Eo.FunctionWrapper<elm_interface_scrollable_edge_top_cb_set_api_delegate>(_Module, "elm_interface_scrollable_edge_top_cb_set");
    private static  void edge_top_cb_set(System.IntPtr obj, System.IntPtr pd,  ElmInterfaceScrollableCb edge_top_cb)
   {
      Eina.Log.Debug("function elm_interface_scrollable_edge_top_cb_set was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                    
         try {
            ((InterfaceScrollableConcrete)wrapper).SetEdgeTopCb( edge_top_cb);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                        } else {
         elm_interface_scrollable_edge_top_cb_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  edge_top_cb);
      }
   }
   private static elm_interface_scrollable_edge_top_cb_set_delegate elm_interface_scrollable_edge_top_cb_set_static_delegate;


    private delegate  void elm_interface_scrollable_objects_set_delegate(System.IntPtr obj, System.IntPtr pd, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Canvas.Object, Efl.Eo.NonOwnTag>))]  Efl.Canvas.Object edje_object, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Canvas.Object, Efl.Eo.NonOwnTag>))]  Efl.Canvas.Object hit_rectangle);


    public delegate  void elm_interface_scrollable_objects_set_api_delegate(System.IntPtr obj, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Canvas.Object, Efl.Eo.NonOwnTag>))]  Efl.Canvas.Object edje_object, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Canvas.Object, Efl.Eo.NonOwnTag>))]  Efl.Canvas.Object hit_rectangle);
    public static Efl.Eo.FunctionWrapper<elm_interface_scrollable_objects_set_api_delegate> elm_interface_scrollable_objects_set_ptr = new Efl.Eo.FunctionWrapper<elm_interface_scrollable_objects_set_api_delegate>(_Module, "elm_interface_scrollable_objects_set");
    private static  void objects_set(System.IntPtr obj, System.IntPtr pd,  Efl.Canvas.Object edje_object,  Efl.Canvas.Object hit_rectangle)
   {
      Eina.Log.Debug("function elm_interface_scrollable_objects_set was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                                      
         try {
            ((InterfaceScrollableConcrete)wrapper).SetObjects( edje_object,  hit_rectangle);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                                    } else {
         elm_interface_scrollable_objects_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  edje_object,  hit_rectangle);
      }
   }
   private static elm_interface_scrollable_objects_set_delegate elm_interface_scrollable_objects_set_static_delegate;


    private delegate  void elm_interface_scrollable_last_page_get_delegate(System.IntPtr obj, System.IntPtr pd,   out  int pagenumber_h,   out  int pagenumber_v);


    public delegate  void elm_interface_scrollable_last_page_get_api_delegate(System.IntPtr obj,   out  int pagenumber_h,   out  int pagenumber_v);
    public static Efl.Eo.FunctionWrapper<elm_interface_scrollable_last_page_get_api_delegate> elm_interface_scrollable_last_page_get_ptr = new Efl.Eo.FunctionWrapper<elm_interface_scrollable_last_page_get_api_delegate>(_Module, "elm_interface_scrollable_last_page_get");
    private static  void last_page_get(System.IntPtr obj, System.IntPtr pd,  out  int pagenumber_h,  out  int pagenumber_v)
   {
      Eina.Log.Debug("function elm_interface_scrollable_last_page_get was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                           pagenumber_h = default( int);      pagenumber_v = default( int);                     
         try {
            ((InterfaceScrollableConcrete)wrapper).GetLastPage( out pagenumber_h,  out pagenumber_v);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                                    } else {
         elm_interface_scrollable_last_page_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  out pagenumber_h,  out pagenumber_v);
      }
   }
   private static elm_interface_scrollable_last_page_get_delegate elm_interface_scrollable_last_page_get_static_delegate;


    private delegate  void elm_interface_scrollable_current_page_get_delegate(System.IntPtr obj, System.IntPtr pd,   out  int pagenumber_h,   out  int pagenumber_v);


    public delegate  void elm_interface_scrollable_current_page_get_api_delegate(System.IntPtr obj,   out  int pagenumber_h,   out  int pagenumber_v);
    public static Efl.Eo.FunctionWrapper<elm_interface_scrollable_current_page_get_api_delegate> elm_interface_scrollable_current_page_get_ptr = new Efl.Eo.FunctionWrapper<elm_interface_scrollable_current_page_get_api_delegate>(_Module, "elm_interface_scrollable_current_page_get");
    private static  void current_page_get(System.IntPtr obj, System.IntPtr pd,  out  int pagenumber_h,  out  int pagenumber_v)
   {
      Eina.Log.Debug("function elm_interface_scrollable_current_page_get was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                           pagenumber_h = default( int);      pagenumber_v = default( int);                     
         try {
            ((InterfaceScrollableConcrete)wrapper).GetCurrentPage( out pagenumber_h,  out pagenumber_v);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                                    } else {
         elm_interface_scrollable_current_page_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  out pagenumber_h,  out pagenumber_v);
      }
   }
   private static elm_interface_scrollable_current_page_get_delegate elm_interface_scrollable_current_page_get_static_delegate;


    private delegate  void elm_interface_scrollable_content_viewport_geometry_get_delegate(System.IntPtr obj, System.IntPtr pd,   out  int x,   out  int y,   out  int w,   out  int h);


    public delegate  void elm_interface_scrollable_content_viewport_geometry_get_api_delegate(System.IntPtr obj,   out  int x,   out  int y,   out  int w,   out  int h);
    public static Efl.Eo.FunctionWrapper<elm_interface_scrollable_content_viewport_geometry_get_api_delegate> elm_interface_scrollable_content_viewport_geometry_get_ptr = new Efl.Eo.FunctionWrapper<elm_interface_scrollable_content_viewport_geometry_get_api_delegate>(_Module, "elm_interface_scrollable_content_viewport_geometry_get");
    private static  void content_viewport_geometry_get(System.IntPtr obj, System.IntPtr pd,  out  int x,  out  int y,  out  int w,  out  int h)
   {
      Eina.Log.Debug("function elm_interface_scrollable_content_viewport_geometry_get was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                       x = default( int);      y = default( int);      w = default( int);      h = default( int);                                 
         try {
            ((InterfaceScrollableConcrete)wrapper).GetContentViewportGeometry( out x,  out y,  out w,  out h);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                                                            } else {
         elm_interface_scrollable_content_viewport_geometry_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  out x,  out y,  out w,  out h);
      }
   }
   private static elm_interface_scrollable_content_viewport_geometry_get_delegate elm_interface_scrollable_content_viewport_geometry_get_static_delegate;


    private delegate  void elm_interface_scrollable_content_size_get_delegate(System.IntPtr obj, System.IntPtr pd,   out  int w,   out  int h);


    public delegate  void elm_interface_scrollable_content_size_get_api_delegate(System.IntPtr obj,   out  int w,   out  int h);
    public static Efl.Eo.FunctionWrapper<elm_interface_scrollable_content_size_get_api_delegate> elm_interface_scrollable_content_size_get_ptr = new Efl.Eo.FunctionWrapper<elm_interface_scrollable_content_size_get_api_delegate>(_Module, "elm_interface_scrollable_content_size_get");
    private static  void content_size_get(System.IntPtr obj, System.IntPtr pd,  out  int w,  out  int h)
   {
      Eina.Log.Debug("function elm_interface_scrollable_content_size_get was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                           w = default( int);      h = default( int);                     
         try {
            ((InterfaceScrollableConcrete)wrapper).GetContentSize( out w,  out h);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                                    } else {
         elm_interface_scrollable_content_size_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  out w,  out h);
      }
   }
   private static elm_interface_scrollable_content_size_get_delegate elm_interface_scrollable_content_size_get_static_delegate;


    [return: MarshalAs(UnmanagedType.U1)] private delegate bool elm_interface_scrollable_item_loop_enabled_get_delegate(System.IntPtr obj, System.IntPtr pd);


    [return: MarshalAs(UnmanagedType.U1)] public delegate bool elm_interface_scrollable_item_loop_enabled_get_api_delegate(System.IntPtr obj);
    public static Efl.Eo.FunctionWrapper<elm_interface_scrollable_item_loop_enabled_get_api_delegate> elm_interface_scrollable_item_loop_enabled_get_ptr = new Efl.Eo.FunctionWrapper<elm_interface_scrollable_item_loop_enabled_get_api_delegate>(_Module, "elm_interface_scrollable_item_loop_enabled_get");
    private static bool item_loop_enabled_get(System.IntPtr obj, System.IntPtr pd)
   {
      Eina.Log.Debug("function elm_interface_scrollable_item_loop_enabled_get was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                  bool _ret_var = default(bool);
         try {
            _ret_var = ((InterfaceScrollableConcrete)wrapper).GetItemLoopEnabled();
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
      return _ret_var;
      } else {
         return elm_interface_scrollable_item_loop_enabled_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
      }
   }
   private static elm_interface_scrollable_item_loop_enabled_get_delegate elm_interface_scrollable_item_loop_enabled_get_static_delegate;


    private delegate  void elm_interface_scrollable_item_loop_enabled_set_delegate(System.IntPtr obj, System.IntPtr pd,  [MarshalAs(UnmanagedType.U1)]  bool enable);


    public delegate  void elm_interface_scrollable_item_loop_enabled_set_api_delegate(System.IntPtr obj,  [MarshalAs(UnmanagedType.U1)]  bool enable);
    public static Efl.Eo.FunctionWrapper<elm_interface_scrollable_item_loop_enabled_set_api_delegate> elm_interface_scrollable_item_loop_enabled_set_ptr = new Efl.Eo.FunctionWrapper<elm_interface_scrollable_item_loop_enabled_set_api_delegate>(_Module, "elm_interface_scrollable_item_loop_enabled_set");
    private static  void item_loop_enabled_set(System.IntPtr obj, System.IntPtr pd,  bool enable)
   {
      Eina.Log.Debug("function elm_interface_scrollable_item_loop_enabled_set was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                    
         try {
            ((InterfaceScrollableConcrete)wrapper).SetItemLoopEnabled( enable);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                        } else {
         elm_interface_scrollable_item_loop_enabled_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  enable);
      }
   }
   private static elm_interface_scrollable_item_loop_enabled_set_delegate elm_interface_scrollable_item_loop_enabled_set_static_delegate;


    private delegate  void elm_interface_scrollable_content_pos_set_delegate(System.IntPtr obj, System.IntPtr pd,    int x,    int y,  [MarshalAs(UnmanagedType.U1)]  bool sig);


    public delegate  void elm_interface_scrollable_content_pos_set_api_delegate(System.IntPtr obj,    int x,    int y,  [MarshalAs(UnmanagedType.U1)]  bool sig);
    public static Efl.Eo.FunctionWrapper<elm_interface_scrollable_content_pos_set_api_delegate> elm_interface_scrollable_content_pos_set_ptr = new Efl.Eo.FunctionWrapper<elm_interface_scrollable_content_pos_set_api_delegate>(_Module, "elm_interface_scrollable_content_pos_set");
    private static  void content_pos_set(System.IntPtr obj, System.IntPtr pd,   int x,   int y,  bool sig)
   {
      Eina.Log.Debug("function elm_interface_scrollable_content_pos_set was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                                                        
         try {
            ((InterfaceScrollableConcrete)wrapper).SetContentPos( x,  y,  sig);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                                                } else {
         elm_interface_scrollable_content_pos_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  x,  y,  sig);
      }
   }
   private static elm_interface_scrollable_content_pos_set_delegate elm_interface_scrollable_content_pos_set_static_delegate;


    private delegate  void elm_interface_scrollable_content_pos_get_delegate(System.IntPtr obj, System.IntPtr pd,   out  int x,   out  int y);


    public delegate  void elm_interface_scrollable_content_pos_get_api_delegate(System.IntPtr obj,   out  int x,   out  int y);
    public static Efl.Eo.FunctionWrapper<elm_interface_scrollable_content_pos_get_api_delegate> elm_interface_scrollable_content_pos_get_ptr = new Efl.Eo.FunctionWrapper<elm_interface_scrollable_content_pos_get_api_delegate>(_Module, "elm_interface_scrollable_content_pos_get");
    private static  void content_pos_get(System.IntPtr obj, System.IntPtr pd,  out  int x,  out  int y)
   {
      Eina.Log.Debug("function elm_interface_scrollable_content_pos_get was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                           x = default( int);      y = default( int);                     
         try {
            ((InterfaceScrollableConcrete)wrapper).GetContentPos( out x,  out y);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                                    } else {
         elm_interface_scrollable_content_pos_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  out x,  out y);
      }
   }
   private static elm_interface_scrollable_content_pos_get_delegate elm_interface_scrollable_content_pos_get_static_delegate;


    private delegate  void elm_interface_scrollable_page_show_delegate(System.IntPtr obj, System.IntPtr pd,    int pagenumber_h,    int pagenumber_v);


    public delegate  void elm_interface_scrollable_page_show_api_delegate(System.IntPtr obj,    int pagenumber_h,    int pagenumber_v);
    public static Efl.Eo.FunctionWrapper<elm_interface_scrollable_page_show_api_delegate> elm_interface_scrollable_page_show_ptr = new Efl.Eo.FunctionWrapper<elm_interface_scrollable_page_show_api_delegate>(_Module, "elm_interface_scrollable_page_show");
    private static  void page_show(System.IntPtr obj, System.IntPtr pd,   int pagenumber_h,   int pagenumber_v)
   {
      Eina.Log.Debug("function elm_interface_scrollable_page_show was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                                      
         try {
            ((InterfaceScrollableConcrete)wrapper).ShowPage( pagenumber_h,  pagenumber_v);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                                    } else {
         elm_interface_scrollable_page_show_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  pagenumber_h,  pagenumber_v);
      }
   }
   private static elm_interface_scrollable_page_show_delegate elm_interface_scrollable_page_show_static_delegate;


    private delegate  void elm_interface_scrollable_region_bring_in_delegate(System.IntPtr obj, System.IntPtr pd,    int x,    int y,    int w,    int h);


    public delegate  void elm_interface_scrollable_region_bring_in_api_delegate(System.IntPtr obj,    int x,    int y,    int w,    int h);
    public static Efl.Eo.FunctionWrapper<elm_interface_scrollable_region_bring_in_api_delegate> elm_interface_scrollable_region_bring_in_ptr = new Efl.Eo.FunctionWrapper<elm_interface_scrollable_region_bring_in_api_delegate>(_Module, "elm_interface_scrollable_region_bring_in");
    private static  void region_bring_in(System.IntPtr obj, System.IntPtr pd,   int x,   int y,   int w,   int h)
   {
      Eina.Log.Debug("function elm_interface_scrollable_region_bring_in was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                                                                          
         try {
            ((InterfaceScrollableConcrete)wrapper).RegionBringIn( x,  y,  w,  h);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                                                            } else {
         elm_interface_scrollable_region_bring_in_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  x,  y,  w,  h);
      }
   }
   private static elm_interface_scrollable_region_bring_in_delegate elm_interface_scrollable_region_bring_in_static_delegate;


    private delegate  void elm_interface_scrollable_page_bring_in_delegate(System.IntPtr obj, System.IntPtr pd,    int pagenumber_h,    int pagenumber_v);


    public delegate  void elm_interface_scrollable_page_bring_in_api_delegate(System.IntPtr obj,    int pagenumber_h,    int pagenumber_v);
    public static Efl.Eo.FunctionWrapper<elm_interface_scrollable_page_bring_in_api_delegate> elm_interface_scrollable_page_bring_in_ptr = new Efl.Eo.FunctionWrapper<elm_interface_scrollable_page_bring_in_api_delegate>(_Module, "elm_interface_scrollable_page_bring_in");
    private static  void page_bring_in(System.IntPtr obj, System.IntPtr pd,   int pagenumber_h,   int pagenumber_v)
   {
      Eina.Log.Debug("function elm_interface_scrollable_page_bring_in was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                                      
         try {
            ((InterfaceScrollableConcrete)wrapper).PageBringIn( pagenumber_h,  pagenumber_v);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                                    } else {
         elm_interface_scrollable_page_bring_in_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  pagenumber_h,  pagenumber_v);
      }
   }
   private static elm_interface_scrollable_page_bring_in_delegate elm_interface_scrollable_page_bring_in_static_delegate;


    private delegate  void elm_interface_scrollable_content_region_show_delegate(System.IntPtr obj, System.IntPtr pd,    int x,    int y,    int w,    int h);


    public delegate  void elm_interface_scrollable_content_region_show_api_delegate(System.IntPtr obj,    int x,    int y,    int w,    int h);
    public static Efl.Eo.FunctionWrapper<elm_interface_scrollable_content_region_show_api_delegate> elm_interface_scrollable_content_region_show_ptr = new Efl.Eo.FunctionWrapper<elm_interface_scrollable_content_region_show_api_delegate>(_Module, "elm_interface_scrollable_content_region_show");
    private static  void content_region_show(System.IntPtr obj, System.IntPtr pd,   int x,   int y,   int w,   int h)
   {
      Eina.Log.Debug("function elm_interface_scrollable_content_region_show was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                                                                          
         try {
            ((InterfaceScrollableConcrete)wrapper).ShowContentRegion( x,  y,  w,  h);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                                                            } else {
         elm_interface_scrollable_content_region_show_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  x,  y,  w,  h);
      }
   }
   private static elm_interface_scrollable_content_region_show_delegate elm_interface_scrollable_content_region_show_static_delegate;


    private delegate  void elm_interface_scrollable_content_min_limit_delegate(System.IntPtr obj, System.IntPtr pd,  [MarshalAs(UnmanagedType.U1)]  bool w,  [MarshalAs(UnmanagedType.U1)]  bool h);


    public delegate  void elm_interface_scrollable_content_min_limit_api_delegate(System.IntPtr obj,  [MarshalAs(UnmanagedType.U1)]  bool w,  [MarshalAs(UnmanagedType.U1)]  bool h);
    public static Efl.Eo.FunctionWrapper<elm_interface_scrollable_content_min_limit_api_delegate> elm_interface_scrollable_content_min_limit_ptr = new Efl.Eo.FunctionWrapper<elm_interface_scrollable_content_min_limit_api_delegate>(_Module, "elm_interface_scrollable_content_min_limit");
    private static  void content_min_limit(System.IntPtr obj, System.IntPtr pd,  bool w,  bool h)
   {
      Eina.Log.Debug("function elm_interface_scrollable_content_min_limit was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                                      
         try {
            ((InterfaceScrollableConcrete)wrapper).ContentMinLimit( w,  h);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                                    } else {
         elm_interface_scrollable_content_min_limit_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  w,  h);
      }
   }
   private static elm_interface_scrollable_content_min_limit_delegate elm_interface_scrollable_content_min_limit_static_delegate;


    private delegate  void elm_interface_scrollable_wanted_region_set_delegate(System.IntPtr obj, System.IntPtr pd,    int x,    int y);


    public delegate  void elm_interface_scrollable_wanted_region_set_api_delegate(System.IntPtr obj,    int x,    int y);
    public static Efl.Eo.FunctionWrapper<elm_interface_scrollable_wanted_region_set_api_delegate> elm_interface_scrollable_wanted_region_set_ptr = new Efl.Eo.FunctionWrapper<elm_interface_scrollable_wanted_region_set_api_delegate>(_Module, "elm_interface_scrollable_wanted_region_set");
    private static  void wanted_region_set(System.IntPtr obj, System.IntPtr pd,   int x,   int y)
   {
      Eina.Log.Debug("function elm_interface_scrollable_wanted_region_set was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                                      
         try {
            ((InterfaceScrollableConcrete)wrapper).SetWantedRegion( x,  y);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                                    } else {
         elm_interface_scrollable_wanted_region_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  x,  y);
      }
   }
   private static elm_interface_scrollable_wanted_region_set_delegate elm_interface_scrollable_wanted_region_set_static_delegate;


    private delegate  void elm_interface_scrollable_custom_pan_pos_adjust_delegate(System.IntPtr obj, System.IntPtr pd,    System.IntPtr x,    System.IntPtr y);


    public delegate  void elm_interface_scrollable_custom_pan_pos_adjust_api_delegate(System.IntPtr obj,    System.IntPtr x,    System.IntPtr y);
    public static Efl.Eo.FunctionWrapper<elm_interface_scrollable_custom_pan_pos_adjust_api_delegate> elm_interface_scrollable_custom_pan_pos_adjust_ptr = new Efl.Eo.FunctionWrapper<elm_interface_scrollable_custom_pan_pos_adjust_api_delegate>(_Module, "elm_interface_scrollable_custom_pan_pos_adjust");
    private static  void custom_pan_pos_adjust(System.IntPtr obj, System.IntPtr pd,   System.IntPtr x,   System.IntPtr y)
   {
      Eina.Log.Debug("function elm_interface_scrollable_custom_pan_pos_adjust was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
               var _in_x = Eina.PrimitiveConversion.PointerToManaged< int>(x);
      var _in_y = Eina.PrimitiveConversion.PointerToManaged< int>(y);
                                 
         try {
            ((InterfaceScrollableConcrete)wrapper).CustomPanPosAdjust( _in_x,  _in_y);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                                    } else {
         elm_interface_scrollable_custom_pan_pos_adjust_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  x,  y);
      }
   }
   private static elm_interface_scrollable_custom_pan_pos_adjust_delegate elm_interface_scrollable_custom_pan_pos_adjust_static_delegate;


   [return:MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Ui.Focus.ManagerConcrete, Efl.Eo.NonOwnTag>))] private delegate Efl.Ui.Focus.Manager efl_ui_widget_focus_manager_create_delegate(System.IntPtr obj, System.IntPtr pd, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Ui.Focus.ObjectConcrete, Efl.Eo.NonOwnTag>))]  Efl.Ui.Focus.Object root);


   [return:MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Ui.Focus.ManagerConcrete, Efl.Eo.NonOwnTag>))] public delegate Efl.Ui.Focus.Manager efl_ui_widget_focus_manager_create_api_delegate(System.IntPtr obj, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Ui.Focus.ObjectConcrete, Efl.Eo.NonOwnTag>))]  Efl.Ui.Focus.Object root);
    public static Efl.Eo.FunctionWrapper<efl_ui_widget_focus_manager_create_api_delegate> efl_ui_widget_focus_manager_create_ptr = new Efl.Eo.FunctionWrapper<efl_ui_widget_focus_manager_create_api_delegate>(_Module, "efl_ui_widget_focus_manager_create");
    private static Efl.Ui.Focus.Manager focus_manager_create(System.IntPtr obj, System.IntPtr pd,  Efl.Ui.Focus.Object root)
   {
      Eina.Log.Debug("function efl_ui_widget_focus_manager_create was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                    Efl.Ui.Focus.Manager _ret_var = default(Efl.Ui.Focus.Manager);
         try {
            _ret_var = ((InterfaceScrollableConcrete)wrapper).FocusManagerCreate( root);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                  return _ret_var;
      } else {
         return efl_ui_widget_focus_manager_create_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  root);
      }
   }
   private static efl_ui_widget_focus_manager_create_delegate efl_ui_widget_focus_manager_create_static_delegate;


   [return:MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Ui.Focus.ObjectConcrete, Efl.Eo.NonOwnTag>))] private delegate Efl.Ui.Focus.Object efl_ui_focus_manager_focus_get_delegate(System.IntPtr obj, System.IntPtr pd);


   [return:MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Ui.Focus.ObjectConcrete, Efl.Eo.NonOwnTag>))] public delegate Efl.Ui.Focus.Object efl_ui_focus_manager_focus_get_api_delegate(System.IntPtr obj);
    public static Efl.Eo.FunctionWrapper<efl_ui_focus_manager_focus_get_api_delegate> efl_ui_focus_manager_focus_get_ptr = new Efl.Eo.FunctionWrapper<efl_ui_focus_manager_focus_get_api_delegate>(_Module, "efl_ui_focus_manager_focus_get");
    private static Efl.Ui.Focus.Object manager_focus_get(System.IntPtr obj, System.IntPtr pd)
   {
      Eina.Log.Debug("function efl_ui_focus_manager_focus_get was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                  Efl.Ui.Focus.Object _ret_var = default(Efl.Ui.Focus.Object);
         try {
            _ret_var = ((InterfaceScrollableConcrete)wrapper).GetManagerFocus();
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
      return _ret_var;
      } else {
         return efl_ui_focus_manager_focus_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
      }
   }
   private static efl_ui_focus_manager_focus_get_delegate efl_ui_focus_manager_focus_get_static_delegate;


    private delegate  void efl_ui_focus_manager_focus_set_delegate(System.IntPtr obj, System.IntPtr pd, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Ui.Focus.ObjectConcrete, Efl.Eo.NonOwnTag>))]  Efl.Ui.Focus.Object focus);


    public delegate  void efl_ui_focus_manager_focus_set_api_delegate(System.IntPtr obj, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Ui.Focus.ObjectConcrete, Efl.Eo.NonOwnTag>))]  Efl.Ui.Focus.Object focus);
    public static Efl.Eo.FunctionWrapper<efl_ui_focus_manager_focus_set_api_delegate> efl_ui_focus_manager_focus_set_ptr = new Efl.Eo.FunctionWrapper<efl_ui_focus_manager_focus_set_api_delegate>(_Module, "efl_ui_focus_manager_focus_set");
    private static  void manager_focus_set(System.IntPtr obj, System.IntPtr pd,  Efl.Ui.Focus.Object focus)
   {
      Eina.Log.Debug("function efl_ui_focus_manager_focus_set was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                    
         try {
            ((InterfaceScrollableConcrete)wrapper).SetManagerFocus( focus);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                        } else {
         efl_ui_focus_manager_focus_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  focus);
      }
   }
   private static efl_ui_focus_manager_focus_set_delegate efl_ui_focus_manager_focus_set_static_delegate;


   [return:MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Ui.Focus.ManagerConcrete, Efl.Eo.NonOwnTag>))] private delegate Efl.Ui.Focus.Manager efl_ui_focus_manager_redirect_get_delegate(System.IntPtr obj, System.IntPtr pd);


   [return:MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Ui.Focus.ManagerConcrete, Efl.Eo.NonOwnTag>))] public delegate Efl.Ui.Focus.Manager efl_ui_focus_manager_redirect_get_api_delegate(System.IntPtr obj);
    public static Efl.Eo.FunctionWrapper<efl_ui_focus_manager_redirect_get_api_delegate> efl_ui_focus_manager_redirect_get_ptr = new Efl.Eo.FunctionWrapper<efl_ui_focus_manager_redirect_get_api_delegate>(_Module, "efl_ui_focus_manager_redirect_get");
    private static Efl.Ui.Focus.Manager redirect_get(System.IntPtr obj, System.IntPtr pd)
   {
      Eina.Log.Debug("function efl_ui_focus_manager_redirect_get was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                  Efl.Ui.Focus.Manager _ret_var = default(Efl.Ui.Focus.Manager);
         try {
            _ret_var = ((InterfaceScrollableConcrete)wrapper).GetRedirect();
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
      return _ret_var;
      } else {
         return efl_ui_focus_manager_redirect_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
      }
   }
   private static efl_ui_focus_manager_redirect_get_delegate efl_ui_focus_manager_redirect_get_static_delegate;


    private delegate  void efl_ui_focus_manager_redirect_set_delegate(System.IntPtr obj, System.IntPtr pd, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Ui.Focus.ManagerConcrete, Efl.Eo.NonOwnTag>))]  Efl.Ui.Focus.Manager redirect);


    public delegate  void efl_ui_focus_manager_redirect_set_api_delegate(System.IntPtr obj, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Ui.Focus.ManagerConcrete, Efl.Eo.NonOwnTag>))]  Efl.Ui.Focus.Manager redirect);
    public static Efl.Eo.FunctionWrapper<efl_ui_focus_manager_redirect_set_api_delegate> efl_ui_focus_manager_redirect_set_ptr = new Efl.Eo.FunctionWrapper<efl_ui_focus_manager_redirect_set_api_delegate>(_Module, "efl_ui_focus_manager_redirect_set");
    private static  void redirect_set(System.IntPtr obj, System.IntPtr pd,  Efl.Ui.Focus.Manager redirect)
   {
      Eina.Log.Debug("function efl_ui_focus_manager_redirect_set was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                    
         try {
            ((InterfaceScrollableConcrete)wrapper).SetRedirect( redirect);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                        } else {
         efl_ui_focus_manager_redirect_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  redirect);
      }
   }
   private static efl_ui_focus_manager_redirect_set_delegate efl_ui_focus_manager_redirect_set_static_delegate;


    private delegate  System.IntPtr efl_ui_focus_manager_border_elements_get_delegate(System.IntPtr obj, System.IntPtr pd);


    public delegate  System.IntPtr efl_ui_focus_manager_border_elements_get_api_delegate(System.IntPtr obj);
    public static Efl.Eo.FunctionWrapper<efl_ui_focus_manager_border_elements_get_api_delegate> efl_ui_focus_manager_border_elements_get_ptr = new Efl.Eo.FunctionWrapper<efl_ui_focus_manager_border_elements_get_api_delegate>(_Module, "efl_ui_focus_manager_border_elements_get");
    private static  System.IntPtr border_elements_get(System.IntPtr obj, System.IntPtr pd)
   {
      Eina.Log.Debug("function efl_ui_focus_manager_border_elements_get was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                  Eina.Iterator<Efl.Ui.Focus.Object> _ret_var = default(Eina.Iterator<Efl.Ui.Focus.Object>);
         try {
            _ret_var = ((InterfaceScrollableConcrete)wrapper).GetBorderElements();
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
      return _ret_var.Handle;
      } else {
         return efl_ui_focus_manager_border_elements_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
      }
   }
   private static efl_ui_focus_manager_border_elements_get_delegate efl_ui_focus_manager_border_elements_get_static_delegate;


    private delegate  System.IntPtr efl_ui_focus_manager_viewport_elements_get_delegate(System.IntPtr obj, System.IntPtr pd,   Eina.Rect_StructInternal viewport);


    public delegate  System.IntPtr efl_ui_focus_manager_viewport_elements_get_api_delegate(System.IntPtr obj,   Eina.Rect_StructInternal viewport);
    public static Efl.Eo.FunctionWrapper<efl_ui_focus_manager_viewport_elements_get_api_delegate> efl_ui_focus_manager_viewport_elements_get_ptr = new Efl.Eo.FunctionWrapper<efl_ui_focus_manager_viewport_elements_get_api_delegate>(_Module, "efl_ui_focus_manager_viewport_elements_get");
    private static  System.IntPtr viewport_elements_get(System.IntPtr obj, System.IntPtr pd,  Eina.Rect_StructInternal viewport)
   {
      Eina.Log.Debug("function efl_ui_focus_manager_viewport_elements_get was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
               var _in_viewport = Eina.Rect_StructConversion.ToManaged(viewport);
                     Eina.Iterator<Efl.Ui.Focus.Object> _ret_var = default(Eina.Iterator<Efl.Ui.Focus.Object>);
         try {
            _ret_var = ((InterfaceScrollableConcrete)wrapper).GetViewportElements( _in_viewport);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                  return _ret_var.Handle;
      } else {
         return efl_ui_focus_manager_viewport_elements_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  viewport);
      }
   }
   private static efl_ui_focus_manager_viewport_elements_get_delegate efl_ui_focus_manager_viewport_elements_get_static_delegate;


   [return:MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Ui.Focus.ObjectConcrete, Efl.Eo.NonOwnTag>))] private delegate Efl.Ui.Focus.Object efl_ui_focus_manager_root_get_delegate(System.IntPtr obj, System.IntPtr pd);


   [return:MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Ui.Focus.ObjectConcrete, Efl.Eo.NonOwnTag>))] public delegate Efl.Ui.Focus.Object efl_ui_focus_manager_root_get_api_delegate(System.IntPtr obj);
    public static Efl.Eo.FunctionWrapper<efl_ui_focus_manager_root_get_api_delegate> efl_ui_focus_manager_root_get_ptr = new Efl.Eo.FunctionWrapper<efl_ui_focus_manager_root_get_api_delegate>(_Module, "efl_ui_focus_manager_root_get");
    private static Efl.Ui.Focus.Object root_get(System.IntPtr obj, System.IntPtr pd)
   {
      Eina.Log.Debug("function efl_ui_focus_manager_root_get was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                  Efl.Ui.Focus.Object _ret_var = default(Efl.Ui.Focus.Object);
         try {
            _ret_var = ((InterfaceScrollableConcrete)wrapper).GetRoot();
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
      return _ret_var;
      } else {
         return efl_ui_focus_manager_root_get_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
      }
   }
   private static efl_ui_focus_manager_root_get_delegate efl_ui_focus_manager_root_get_static_delegate;


    [return: MarshalAs(UnmanagedType.U1)] private delegate bool efl_ui_focus_manager_root_set_delegate(System.IntPtr obj, System.IntPtr pd, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Ui.Focus.ObjectConcrete, Efl.Eo.NonOwnTag>))]  Efl.Ui.Focus.Object root);


    [return: MarshalAs(UnmanagedType.U1)] public delegate bool efl_ui_focus_manager_root_set_api_delegate(System.IntPtr obj, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Ui.Focus.ObjectConcrete, Efl.Eo.NonOwnTag>))]  Efl.Ui.Focus.Object root);
    public static Efl.Eo.FunctionWrapper<efl_ui_focus_manager_root_set_api_delegate> efl_ui_focus_manager_root_set_ptr = new Efl.Eo.FunctionWrapper<efl_ui_focus_manager_root_set_api_delegate>(_Module, "efl_ui_focus_manager_root_set");
    private static bool root_set(System.IntPtr obj, System.IntPtr pd,  Efl.Ui.Focus.Object root)
   {
      Eina.Log.Debug("function efl_ui_focus_manager_root_set was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                    bool _ret_var = default(bool);
         try {
            _ret_var = ((InterfaceScrollableConcrete)wrapper).SetRoot( root);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                  return _ret_var;
      } else {
         return efl_ui_focus_manager_root_set_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  root);
      }
   }
   private static efl_ui_focus_manager_root_set_delegate efl_ui_focus_manager_root_set_static_delegate;


   [return:MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Ui.Focus.ObjectConcrete, Efl.Eo.NonOwnTag>))] private delegate Efl.Ui.Focus.Object efl_ui_focus_manager_move_delegate(System.IntPtr obj, System.IntPtr pd,   Efl.Ui.Focus.Direction direction);


   [return:MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Ui.Focus.ObjectConcrete, Efl.Eo.NonOwnTag>))] public delegate Efl.Ui.Focus.Object efl_ui_focus_manager_move_api_delegate(System.IntPtr obj,   Efl.Ui.Focus.Direction direction);
    public static Efl.Eo.FunctionWrapper<efl_ui_focus_manager_move_api_delegate> efl_ui_focus_manager_move_ptr = new Efl.Eo.FunctionWrapper<efl_ui_focus_manager_move_api_delegate>(_Module, "efl_ui_focus_manager_move");
    private static Efl.Ui.Focus.Object move(System.IntPtr obj, System.IntPtr pd,  Efl.Ui.Focus.Direction direction)
   {
      Eina.Log.Debug("function efl_ui_focus_manager_move was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                    Efl.Ui.Focus.Object _ret_var = default(Efl.Ui.Focus.Object);
         try {
            _ret_var = ((InterfaceScrollableConcrete)wrapper).Move( direction);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                  return _ret_var;
      } else {
         return efl_ui_focus_manager_move_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  direction);
      }
   }
   private static efl_ui_focus_manager_move_delegate efl_ui_focus_manager_move_static_delegate;


   [return:MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Ui.Focus.ObjectConcrete, Efl.Eo.NonOwnTag>))] private delegate Efl.Ui.Focus.Object efl_ui_focus_manager_request_move_delegate(System.IntPtr obj, System.IntPtr pd,   Efl.Ui.Focus.Direction direction, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Ui.Focus.ObjectConcrete, Efl.Eo.NonOwnTag>))]  Efl.Ui.Focus.Object child,  [MarshalAs(UnmanagedType.U1)]  bool logical);


   [return:MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Ui.Focus.ObjectConcrete, Efl.Eo.NonOwnTag>))] public delegate Efl.Ui.Focus.Object efl_ui_focus_manager_request_move_api_delegate(System.IntPtr obj,   Efl.Ui.Focus.Direction direction, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Ui.Focus.ObjectConcrete, Efl.Eo.NonOwnTag>))]  Efl.Ui.Focus.Object child,  [MarshalAs(UnmanagedType.U1)]  bool logical);
    public static Efl.Eo.FunctionWrapper<efl_ui_focus_manager_request_move_api_delegate> efl_ui_focus_manager_request_move_ptr = new Efl.Eo.FunctionWrapper<efl_ui_focus_manager_request_move_api_delegate>(_Module, "efl_ui_focus_manager_request_move");
    private static Efl.Ui.Focus.Object request_move(System.IntPtr obj, System.IntPtr pd,  Efl.Ui.Focus.Direction direction,  Efl.Ui.Focus.Object child,  bool logical)
   {
      Eina.Log.Debug("function efl_ui_focus_manager_request_move was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                                                        Efl.Ui.Focus.Object _ret_var = default(Efl.Ui.Focus.Object);
         try {
            _ret_var = ((InterfaceScrollableConcrete)wrapper).MoveRequest( direction,  child,  logical);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                                          return _ret_var;
      } else {
         return efl_ui_focus_manager_request_move_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  direction,  child,  logical);
      }
   }
   private static efl_ui_focus_manager_request_move_delegate efl_ui_focus_manager_request_move_static_delegate;


   [return:MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Ui.Focus.ObjectConcrete, Efl.Eo.NonOwnTag>))] private delegate Efl.Ui.Focus.Object efl_ui_focus_manager_request_subchild_delegate(System.IntPtr obj, System.IntPtr pd, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Ui.Focus.ObjectConcrete, Efl.Eo.NonOwnTag>))]  Efl.Ui.Focus.Object root);


   [return:MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Ui.Focus.ObjectConcrete, Efl.Eo.NonOwnTag>))] public delegate Efl.Ui.Focus.Object efl_ui_focus_manager_request_subchild_api_delegate(System.IntPtr obj, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Ui.Focus.ObjectConcrete, Efl.Eo.NonOwnTag>))]  Efl.Ui.Focus.Object root);
    public static Efl.Eo.FunctionWrapper<efl_ui_focus_manager_request_subchild_api_delegate> efl_ui_focus_manager_request_subchild_ptr = new Efl.Eo.FunctionWrapper<efl_ui_focus_manager_request_subchild_api_delegate>(_Module, "efl_ui_focus_manager_request_subchild");
    private static Efl.Ui.Focus.Object request_subchild(System.IntPtr obj, System.IntPtr pd,  Efl.Ui.Focus.Object root)
   {
      Eina.Log.Debug("function efl_ui_focus_manager_request_subchild was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                    Efl.Ui.Focus.Object _ret_var = default(Efl.Ui.Focus.Object);
         try {
            _ret_var = ((InterfaceScrollableConcrete)wrapper).RequestSubchild( root);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                  return _ret_var;
      } else {
         return efl_ui_focus_manager_request_subchild_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  root);
      }
   }
   private static efl_ui_focus_manager_request_subchild_delegate efl_ui_focus_manager_request_subchild_static_delegate;


    private delegate  System.IntPtr efl_ui_focus_manager_fetch_delegate(System.IntPtr obj, System.IntPtr pd, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Ui.Focus.ObjectConcrete, Efl.Eo.NonOwnTag>))]  Efl.Ui.Focus.Object child);


    public delegate  System.IntPtr efl_ui_focus_manager_fetch_api_delegate(System.IntPtr obj, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Ui.Focus.ObjectConcrete, Efl.Eo.NonOwnTag>))]  Efl.Ui.Focus.Object child);
    public static Efl.Eo.FunctionWrapper<efl_ui_focus_manager_fetch_api_delegate> efl_ui_focus_manager_fetch_ptr = new Efl.Eo.FunctionWrapper<efl_ui_focus_manager_fetch_api_delegate>(_Module, "efl_ui_focus_manager_fetch");
    private static  System.IntPtr fetch(System.IntPtr obj, System.IntPtr pd,  Efl.Ui.Focus.Object child)
   {
      Eina.Log.Debug("function efl_ui_focus_manager_fetch was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                    Efl.Ui.Focus.Relations _ret_var = default(Efl.Ui.Focus.Relations);
         try {
            _ret_var = ((InterfaceScrollableConcrete)wrapper).Fetch( child);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                  return Eina.PrimitiveConversion.ManagedToPointerAlloc(_ret_var);
      } else {
         return efl_ui_focus_manager_fetch_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  child);
      }
   }
   private static efl_ui_focus_manager_fetch_delegate efl_ui_focus_manager_fetch_static_delegate;


    private delegate Efl.Ui.Focus.ManagerLogicalEndDetail_StructInternal efl_ui_focus_manager_logical_end_delegate(System.IntPtr obj, System.IntPtr pd);


    public delegate Efl.Ui.Focus.ManagerLogicalEndDetail_StructInternal efl_ui_focus_manager_logical_end_api_delegate(System.IntPtr obj);
    public static Efl.Eo.FunctionWrapper<efl_ui_focus_manager_logical_end_api_delegate> efl_ui_focus_manager_logical_end_ptr = new Efl.Eo.FunctionWrapper<efl_ui_focus_manager_logical_end_api_delegate>(_Module, "efl_ui_focus_manager_logical_end");
    private static Efl.Ui.Focus.ManagerLogicalEndDetail_StructInternal logical_end(System.IntPtr obj, System.IntPtr pd)
   {
      Eina.Log.Debug("function efl_ui_focus_manager_logical_end was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                  Efl.Ui.Focus.ManagerLogicalEndDetail _ret_var = default(Efl.Ui.Focus.ManagerLogicalEndDetail);
         try {
            _ret_var = ((InterfaceScrollableConcrete)wrapper).LogicalEnd();
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
      return Efl.Ui.Focus.ManagerLogicalEndDetail_StructConversion.ToInternal(_ret_var);
      } else {
         return efl_ui_focus_manager_logical_end_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
      }
   }
   private static efl_ui_focus_manager_logical_end_delegate efl_ui_focus_manager_logical_end_static_delegate;


    private delegate  void efl_ui_focus_manager_reset_history_delegate(System.IntPtr obj, System.IntPtr pd);


    public delegate  void efl_ui_focus_manager_reset_history_api_delegate(System.IntPtr obj);
    public static Efl.Eo.FunctionWrapper<efl_ui_focus_manager_reset_history_api_delegate> efl_ui_focus_manager_reset_history_ptr = new Efl.Eo.FunctionWrapper<efl_ui_focus_manager_reset_history_api_delegate>(_Module, "efl_ui_focus_manager_reset_history");
    private static  void reset_history(System.IntPtr obj, System.IntPtr pd)
   {
      Eina.Log.Debug("function efl_ui_focus_manager_reset_history was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                  
         try {
            ((InterfaceScrollableConcrete)wrapper).ResetHistory();
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
            } else {
         efl_ui_focus_manager_reset_history_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
      }
   }
   private static efl_ui_focus_manager_reset_history_delegate efl_ui_focus_manager_reset_history_static_delegate;


    private delegate  void efl_ui_focus_manager_pop_history_stack_delegate(System.IntPtr obj, System.IntPtr pd);


    public delegate  void efl_ui_focus_manager_pop_history_stack_api_delegate(System.IntPtr obj);
    public static Efl.Eo.FunctionWrapper<efl_ui_focus_manager_pop_history_stack_api_delegate> efl_ui_focus_manager_pop_history_stack_ptr = new Efl.Eo.FunctionWrapper<efl_ui_focus_manager_pop_history_stack_api_delegate>(_Module, "efl_ui_focus_manager_pop_history_stack");
    private static  void pop_history_stack(System.IntPtr obj, System.IntPtr pd)
   {
      Eina.Log.Debug("function efl_ui_focus_manager_pop_history_stack was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                  
         try {
            ((InterfaceScrollableConcrete)wrapper).PopHistoryStack();
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
            } else {
         efl_ui_focus_manager_pop_history_stack_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
      }
   }
   private static efl_ui_focus_manager_pop_history_stack_delegate efl_ui_focus_manager_pop_history_stack_static_delegate;


    private delegate  void efl_ui_focus_manager_setup_on_first_touch_delegate(System.IntPtr obj, System.IntPtr pd,   Efl.Ui.Focus.Direction direction, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Ui.Focus.ObjectConcrete, Efl.Eo.NonOwnTag>))]  Efl.Ui.Focus.Object entry);


    public delegate  void efl_ui_focus_manager_setup_on_first_touch_api_delegate(System.IntPtr obj,   Efl.Ui.Focus.Direction direction, [MarshalAs(UnmanagedType.CustomMarshaler, MarshalTypeRef=typeof(Efl.Eo.MarshalTest<Efl.Ui.Focus.ObjectConcrete, Efl.Eo.NonOwnTag>))]  Efl.Ui.Focus.Object entry);
    public static Efl.Eo.FunctionWrapper<efl_ui_focus_manager_setup_on_first_touch_api_delegate> efl_ui_focus_manager_setup_on_first_touch_ptr = new Efl.Eo.FunctionWrapper<efl_ui_focus_manager_setup_on_first_touch_api_delegate>(_Module, "efl_ui_focus_manager_setup_on_first_touch");
    private static  void setup_on_first_touch(System.IntPtr obj, System.IntPtr pd,  Efl.Ui.Focus.Direction direction,  Efl.Ui.Focus.Object entry)
   {
      Eina.Log.Debug("function efl_ui_focus_manager_setup_on_first_touch was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                                                      
         try {
            ((InterfaceScrollableConcrete)wrapper).SetupOnFirstTouch( direction,  entry);
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
                                    } else {
         efl_ui_focus_manager_setup_on_first_touch_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)),  direction,  entry);
      }
   }
   private static efl_ui_focus_manager_setup_on_first_touch_delegate efl_ui_focus_manager_setup_on_first_touch_static_delegate;


    private delegate  void efl_ui_focus_manager_dirty_logic_freeze_delegate(System.IntPtr obj, System.IntPtr pd);


    public delegate  void efl_ui_focus_manager_dirty_logic_freeze_api_delegate(System.IntPtr obj);
    public static Efl.Eo.FunctionWrapper<efl_ui_focus_manager_dirty_logic_freeze_api_delegate> efl_ui_focus_manager_dirty_logic_freeze_ptr = new Efl.Eo.FunctionWrapper<efl_ui_focus_manager_dirty_logic_freeze_api_delegate>(_Module, "efl_ui_focus_manager_dirty_logic_freeze");
    private static  void dirty_logic_freeze(System.IntPtr obj, System.IntPtr pd)
   {
      Eina.Log.Debug("function efl_ui_focus_manager_dirty_logic_freeze was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                  
         try {
            ((InterfaceScrollableConcrete)wrapper).FreezeDirtyLogic();
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
            } else {
         efl_ui_focus_manager_dirty_logic_freeze_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
      }
   }
   private static efl_ui_focus_manager_dirty_logic_freeze_delegate efl_ui_focus_manager_dirty_logic_freeze_static_delegate;


    private delegate  void efl_ui_focus_manager_dirty_logic_unfreeze_delegate(System.IntPtr obj, System.IntPtr pd);


    public delegate  void efl_ui_focus_manager_dirty_logic_unfreeze_api_delegate(System.IntPtr obj);
    public static Efl.Eo.FunctionWrapper<efl_ui_focus_manager_dirty_logic_unfreeze_api_delegate> efl_ui_focus_manager_dirty_logic_unfreeze_ptr = new Efl.Eo.FunctionWrapper<efl_ui_focus_manager_dirty_logic_unfreeze_api_delegate>(_Module, "efl_ui_focus_manager_dirty_logic_unfreeze");
    private static  void dirty_logic_unfreeze(System.IntPtr obj, System.IntPtr pd)
   {
      Eina.Log.Debug("function efl_ui_focus_manager_dirty_logic_unfreeze was called");
      Efl.Eo.IWrapper wrapper = Efl.Eo.Globals.data_get(pd);
      if(wrapper != null) {
                  
         try {
            ((InterfaceScrollableConcrete)wrapper).DirtyLogicUnfreeze();
         } catch (Exception e) {
            Eina.Log.Warning($"Callback error: {e.ToString()}");
            Eina.Error.Set(Eina.Error.UNHANDLED_EXCEPTION);
         }
            } else {
         efl_ui_focus_manager_dirty_logic_unfreeze_ptr.Value.Delegate(Efl.Eo.Globals.efl_super(obj, Efl.Eo.Globals.efl_class_get(obj)));
      }
   }
   private static efl_ui_focus_manager_dirty_logic_unfreeze_delegate efl_ui_focus_manager_dirty_logic_unfreeze_static_delegate;
}
} 
namespace Elm { namespace Scroller { 
/// <summary>Type that controls when scrollbars should appear.
/// See also <see cref="Elm.InterfaceScrollable.GetPolicy"/>.</summary>
public enum Policy
{
/// <summary>Show scrollbars as needed</summary>
Auto = 0,
/// <summary>Always show scrollbars</summary>
On = 1,
/// <summary>Never show scrollbars</summary>
Off = 2,
/// <summary>Sentinel value to indicate last enum field during iteration</summary>
Last = 3,
}
} } 
namespace Elm { namespace Scroller { 
/// <summary>Type that controls how the content is scrolled.
/// See also <see cref="Elm.InterfaceScrollable.SetSingleDirection"/>.</summary>
public enum SingleDirection
{
/// <summary>Scroll every direction</summary>
None = 0,
/// <summary>Scroll single direction if the direction is certain</summary>
Soft = 1,
/// <summary>Scroll only single direction</summary>
Hard = 2,
/// <summary>Sentinel value to indicate last enum field during iteration</summary>
Last = 3,
}
} } 
