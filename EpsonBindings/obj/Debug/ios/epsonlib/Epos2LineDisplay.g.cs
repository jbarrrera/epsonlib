//
// Auto-generated from generator.cs, do not edit
//
// We keep references to objects, so warning 414 is expected

#pragma warning disable 414

using System;
using System.Drawing;
using System.Diagnostics;
using System.ComponentModel;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Runtime.CompilerServices;
using UIKit;
using GLKit;
using Metal;
using MapKit;
using ModelIO;
using SceneKit;
using Security;
using AudioUnit;
using CoreVideo;
using CoreMedia;
using QuickLook;
using Foundation;
using CoreMotion;
using ObjCRuntime;
using AddressBook;
using CoreGraphics;
using CoreLocation;
using AVFoundation;
using NewsstandKit;
using CoreAnimation;
using CoreFoundation;

namespace epsonlib {
	[Protocol (Name = "Epos2LineDisplay", WrapperType = typeof (Epos2LineDisplayWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "Dealloc", Selector = "dealloc")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "Connect", Selector = "connect:timeout:", ReturnType = typeof (int), ParameterType = new Type [] { typeof (string), typeof (nint) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "AddCreateWindow", Selector = "addCreateWindow:x:y:width:height:scrollMode:", ReturnType = typeof (int), ParameterType = new Type [] { typeof (nint), typeof (nint), typeof (nint), typeof (nint), typeof (nint), typeof (int) }, ParameterByRef = new bool [] { false, false, false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "AddDestroyWindow", Selector = "addDestroyWindow:", ReturnType = typeof (int), ParameterType = new Type [] { typeof (nint) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "AddSetCurrentWindow", Selector = "addSetCurrentWindow:", ReturnType = typeof (int), ParameterType = new Type [] { typeof (nint) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "AddSetCursorPosition", Selector = "addSetCursorPosition:y:", ReturnType = typeof (int), ParameterType = new Type [] { typeof (nint), typeof (nint) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "AddMoveCursorPosition", Selector = "addMoveCursorPosition:", ReturnType = typeof (int), ParameterType = new Type [] { typeof (int) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "AddSetCursorType", Selector = "addSetCursorType:", ReturnType = typeof (int), ParameterType = new Type [] { typeof (int) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "AddText", Selector = "addText:", ReturnType = typeof (int), ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "AddText", Selector = "addText:lang:", ReturnType = typeof (int), ParameterType = new Type [] { typeof (string), typeof (int) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "AddText", Selector = "addText:x:y:", ReturnType = typeof (int), ParameterType = new Type [] { typeof (string), typeof (nint), typeof (nint) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "AddText", Selector = "addText:x:y:lang:", ReturnType = typeof (int), ParameterType = new Type [] { typeof (string), typeof (nint), typeof (nint), typeof (int) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "AddReverseText", Selector = "addReverseText:", ReturnType = typeof (int), ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "AddReverseText", Selector = "addReverseText:lang:", ReturnType = typeof (int), ParameterType = new Type [] { typeof (string), typeof (int) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "AddReverseText", Selector = "addReverseText:x:y:", ReturnType = typeof (int), ParameterType = new Type [] { typeof (string), typeof (nint), typeof (nint) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "AddReverseText", Selector = "addReverseText:x:y:lang:", ReturnType = typeof (int), ParameterType = new Type [] { typeof (string), typeof (nint), typeof (nint), typeof (int) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "AddMarqueeText", Selector = "addMarqueeText:format:unitWait:repeatWait:repeatCount:lang:", ReturnType = typeof (int), ParameterType = new Type [] { typeof (string), typeof (int), typeof (nint), typeof (nint), typeof (nint), typeof (int) }, ParameterByRef = new bool [] { false, false, false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "AddSetBlink", Selector = "addSetBlink:", ReturnType = typeof (int), ParameterType = new Type [] { typeof (nint) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "AddSetBrightness", Selector = "addSetBrightness:", ReturnType = typeof (int), ParameterType = new Type [] { typeof (int) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "AddCommand", Selector = "addCommand:", ReturnType = typeof (int), ParameterType = new Type [] { typeof (NSData) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SetReceiveEventDelegate", Selector = "setReceiveEventDelegate:", ParameterType = new Type [] { typeof (epsonlib.Epos2DispReceiveDelegate) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SetConnectionEventDelegate", Selector = "setConnectionEventDelegate:", ParameterType = new Type [] { typeof (epsonlib.Epos2ConnectionDelegate) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "Disconnect", Selector = "disconnect", PropertyType = typeof (int), GetterSelector = "disconnect", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "Status", Selector = "getStatus", PropertyType = typeof (epsonlib.Epos2DisplayStatusInfo), GetterSelector = "getStatus", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "SendData", Selector = "sendData", PropertyType = typeof (int), GetterSelector = "sendData", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "ClearCommandBuffer", Selector = "clearCommandBuffer", PropertyType = typeof (int), GetterSelector = "clearCommandBuffer", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "AddInitialize", Selector = "addInitialize", PropertyType = typeof (int), GetterSelector = "addInitialize", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "AddClearCurrentWindow", Selector = "addClearCurrentWindow", PropertyType = typeof (int), GetterSelector = "addClearCurrentWindow", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "AddShowClock", Selector = "addShowClock", PropertyType = typeof (int), GetterSelector = "addShowClock", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "Admin", Selector = "getAdmin", PropertyType = typeof (string), GetterSelector = "getAdmin", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "Location", Selector = "getLocation", PropertyType = typeof (string), GetterSelector = "getLocation", ArgumentSemantic = ArgumentSemantic.None)]
	public interface IEpos2LineDisplay : INativeObject, IDisposable
	{
	}
	
	public static partial class Epos2LineDisplay_Extensions {
		[CompilerGenerated]
		public static void Dealloc (this IEpos2LineDisplay This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("dealloc"));
		}
		
		[CompilerGenerated]
		public static int Connect (this IEpos2LineDisplay This, string target, global::System.nint timeout)
		{
			if (target == null)
				throw new ArgumentNullException ("target");
			var nstarget = NSString.CreateNative (target);
			
			int ret;
			ret = global::ApiDefinition.Messaging.int_objc_msgSend_IntPtr_nint (This.Handle, Selector.GetHandle ("connect:timeout:"), nstarget, timeout);
			NSString.ReleaseNative (nstarget);
			
			return ret;
		}
		
		[CompilerGenerated]
		public static int AddCreateWindow (this IEpos2LineDisplay This, global::System.nint number, global::System.nint x, global::System.nint y, global::System.nint width, global::System.nint height, int scrollMode)
		{
			return global::ApiDefinition.Messaging.int_objc_msgSend_nint_nint_nint_nint_nint_int (This.Handle, Selector.GetHandle ("addCreateWindow:x:y:width:height:scrollMode:"), number, x, y, width, height, scrollMode);
		}
		
		[CompilerGenerated]
		public static int AddDestroyWindow (this IEpos2LineDisplay This, global::System.nint number)
		{
			return global::ApiDefinition.Messaging.int_objc_msgSend_nint (This.Handle, Selector.GetHandle ("addDestroyWindow:"), number);
		}
		
		[CompilerGenerated]
		public static int AddSetCurrentWindow (this IEpos2LineDisplay This, global::System.nint number)
		{
			return global::ApiDefinition.Messaging.int_objc_msgSend_nint (This.Handle, Selector.GetHandle ("addSetCurrentWindow:"), number);
		}
		
		[CompilerGenerated]
		public static int AddSetCursorPosition (this IEpos2LineDisplay This, global::System.nint x, global::System.nint y)
		{
			return global::ApiDefinition.Messaging.int_objc_msgSend_nint_nint (This.Handle, Selector.GetHandle ("addSetCursorPosition:y:"), x, y);
		}
		
		[CompilerGenerated]
		public static int AddMoveCursorPosition (this IEpos2LineDisplay This, int position)
		{
			return global::ApiDefinition.Messaging.int_objc_msgSend_int (This.Handle, Selector.GetHandle ("addMoveCursorPosition:"), position);
		}
		
		[CompilerGenerated]
		public static int AddSetCursorType (this IEpos2LineDisplay This, int type)
		{
			return global::ApiDefinition.Messaging.int_objc_msgSend_int (This.Handle, Selector.GetHandle ("addSetCursorType:"), type);
		}
		
		[CompilerGenerated]
		public static int AddText (this IEpos2LineDisplay This, string data)
		{
			if (data == null)
				throw new ArgumentNullException ("data");
			var nsdata = NSString.CreateNative (data);
			
			int ret;
			ret = global::ApiDefinition.Messaging.int_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("addText:"), nsdata);
			NSString.ReleaseNative (nsdata);
			
			return ret;
		}
		
		[CompilerGenerated]
		public static int AddText (this IEpos2LineDisplay This, string data, int lang)
		{
			if (data == null)
				throw new ArgumentNullException ("data");
			var nsdata = NSString.CreateNative (data);
			
			int ret;
			ret = global::ApiDefinition.Messaging.int_objc_msgSend_IntPtr_int (This.Handle, Selector.GetHandle ("addText:lang:"), nsdata, lang);
			NSString.ReleaseNative (nsdata);
			
			return ret;
		}
		
		[CompilerGenerated]
		public static int AddText (this IEpos2LineDisplay This, string data, global::System.nint x, global::System.nint y)
		{
			if (data == null)
				throw new ArgumentNullException ("data");
			var nsdata = NSString.CreateNative (data);
			
			int ret;
			ret = global::ApiDefinition.Messaging.int_objc_msgSend_IntPtr_nint_nint (This.Handle, Selector.GetHandle ("addText:x:y:"), nsdata, x, y);
			NSString.ReleaseNative (nsdata);
			
			return ret;
		}
		
		[CompilerGenerated]
		public static int AddText (this IEpos2LineDisplay This, string data, global::System.nint x, global::System.nint y, int lang)
		{
			if (data == null)
				throw new ArgumentNullException ("data");
			var nsdata = NSString.CreateNative (data);
			
			int ret;
			ret = global::ApiDefinition.Messaging.int_objc_msgSend_IntPtr_nint_nint_int (This.Handle, Selector.GetHandle ("addText:x:y:lang:"), nsdata, x, y, lang);
			NSString.ReleaseNative (nsdata);
			
			return ret;
		}
		
		[CompilerGenerated]
		public static int AddReverseText (this IEpos2LineDisplay This, string data)
		{
			if (data == null)
				throw new ArgumentNullException ("data");
			var nsdata = NSString.CreateNative (data);
			
			int ret;
			ret = global::ApiDefinition.Messaging.int_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("addReverseText:"), nsdata);
			NSString.ReleaseNative (nsdata);
			
			return ret;
		}
		
		[CompilerGenerated]
		public static int AddReverseText (this IEpos2LineDisplay This, string data, int lang)
		{
			if (data == null)
				throw new ArgumentNullException ("data");
			var nsdata = NSString.CreateNative (data);
			
			int ret;
			ret = global::ApiDefinition.Messaging.int_objc_msgSend_IntPtr_int (This.Handle, Selector.GetHandle ("addReverseText:lang:"), nsdata, lang);
			NSString.ReleaseNative (nsdata);
			
			return ret;
		}
		
		[CompilerGenerated]
		public static int AddReverseText (this IEpos2LineDisplay This, string data, global::System.nint x, global::System.nint y)
		{
			if (data == null)
				throw new ArgumentNullException ("data");
			var nsdata = NSString.CreateNative (data);
			
			int ret;
			ret = global::ApiDefinition.Messaging.int_objc_msgSend_IntPtr_nint_nint (This.Handle, Selector.GetHandle ("addReverseText:x:y:"), nsdata, x, y);
			NSString.ReleaseNative (nsdata);
			
			return ret;
		}
		
		[CompilerGenerated]
		public static int AddReverseText (this IEpos2LineDisplay This, string data, global::System.nint x, global::System.nint y, int lang)
		{
			if (data == null)
				throw new ArgumentNullException ("data");
			var nsdata = NSString.CreateNative (data);
			
			int ret;
			ret = global::ApiDefinition.Messaging.int_objc_msgSend_IntPtr_nint_nint_int (This.Handle, Selector.GetHandle ("addReverseText:x:y:lang:"), nsdata, x, y, lang);
			NSString.ReleaseNative (nsdata);
			
			return ret;
		}
		
		[CompilerGenerated]
		public static int AddMarqueeText (this IEpos2LineDisplay This, string data, int format, global::System.nint unitWait, global::System.nint repeatWait, global::System.nint repeatCount, int lang)
		{
			if (data == null)
				throw new ArgumentNullException ("data");
			var nsdata = NSString.CreateNative (data);
			
			int ret;
			ret = global::ApiDefinition.Messaging.int_objc_msgSend_IntPtr_int_nint_nint_nint_int (This.Handle, Selector.GetHandle ("addMarqueeText:format:unitWait:repeatWait:repeatCount:lang:"), nsdata, format, unitWait, repeatWait, repeatCount, lang);
			NSString.ReleaseNative (nsdata);
			
			return ret;
		}
		
		[CompilerGenerated]
		public static int AddSetBlink (this IEpos2LineDisplay This, global::System.nint interval)
		{
			return global::ApiDefinition.Messaging.int_objc_msgSend_nint (This.Handle, Selector.GetHandle ("addSetBlink:"), interval);
		}
		
		[CompilerGenerated]
		public static int AddSetBrightness (this IEpos2LineDisplay This, int brightness)
		{
			return global::ApiDefinition.Messaging.int_objc_msgSend_int (This.Handle, Selector.GetHandle ("addSetBrightness:"), brightness);
		}
		
		[CompilerGenerated]
		public static int AddCommand (this IEpos2LineDisplay This, NSData data)
		{
			if (data == null)
				throw new ArgumentNullException ("data");
			return global::ApiDefinition.Messaging.int_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("addCommand:"), data.Handle);
		}
		
		[CompilerGenerated]
		public static void SetReceiveEventDelegate (this IEpos2LineDisplay This, Epos2DispReceiveDelegate @delegate)
		{
			if (@delegate == null)
				throw new ArgumentNullException ("@delegate");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setReceiveEventDelegate:"), @delegate.Handle);
		}
		
		[CompilerGenerated]
		public static void SetConnectionEventDelegate (this IEpos2LineDisplay This, Epos2ConnectionDelegate @delegate)
		{
			if (@delegate == null)
				throw new ArgumentNullException ("@delegate");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setConnectionEventDelegate:"), @delegate.Handle);
		}
		
		[CompilerGenerated]
		public static int GetDisconnect (this IEpos2LineDisplay This)
		{
			return global::ApiDefinition.Messaging.int_objc_msgSend (This.Handle, Selector.GetHandle ("disconnect"));
		}
		
		[CompilerGenerated]
		public static Epos2DisplayStatusInfo GetStatus (this IEpos2LineDisplay This)
		{
			return  Runtime.GetNSObject<Epos2DisplayStatusInfo> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("getStatus")));
		}
		
		[CompilerGenerated]
		public static int GetSendData (this IEpos2LineDisplay This)
		{
			return global::ApiDefinition.Messaging.int_objc_msgSend (This.Handle, Selector.GetHandle ("sendData"));
		}
		
		[CompilerGenerated]
		public static int GetClearCommandBuffer (this IEpos2LineDisplay This)
		{
			return global::ApiDefinition.Messaging.int_objc_msgSend (This.Handle, Selector.GetHandle ("clearCommandBuffer"));
		}
		
		[CompilerGenerated]
		public static int GetAddInitialize (this IEpos2LineDisplay This)
		{
			return global::ApiDefinition.Messaging.int_objc_msgSend (This.Handle, Selector.GetHandle ("addInitialize"));
		}
		
		[CompilerGenerated]
		public static int GetAddClearCurrentWindow (this IEpos2LineDisplay This)
		{
			return global::ApiDefinition.Messaging.int_objc_msgSend (This.Handle, Selector.GetHandle ("addClearCurrentWindow"));
		}
		
		[CompilerGenerated]
		public static int GetAddShowClock (this IEpos2LineDisplay This)
		{
			return global::ApiDefinition.Messaging.int_objc_msgSend (This.Handle, Selector.GetHandle ("addShowClock"));
		}
		
		[CompilerGenerated]
		public static string GetAdmin (this IEpos2LineDisplay This)
		{
			return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("getAdmin")));
		}
		
		[CompilerGenerated]
		public static string GetLocation (this IEpos2LineDisplay This)
		{
			return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("getLocation")));
		}
		
	}
	
	internal sealed class Epos2LineDisplayWrapper : BaseWrapper, IEpos2LineDisplay {
		[Preserve (Conditional = true)]
		public Epos2LineDisplayWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace epsonlib {
	[Protocol]
	[Register("Epos2LineDisplay", true)]
	public unsafe partial class Epos2LineDisplay : NSObject, IEpos2LineDisplay {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("Epos2LineDisplay");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public Epos2LineDisplay () : base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, global::ObjCRuntime.Selector.GetHandle ("init")), "init");
			}
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected Epos2LineDisplay (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal Epos2LineDisplay (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithDisplayModel:")]
		[CompilerGenerated]
		public Epos2LineDisplay (int displayModel)
			: base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_int (this.Handle, Selector.GetHandle ("initWithDisplayModel:"), displayModel), "initWithDisplayModel:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("initWithDisplayModel:"), displayModel), "initWithDisplayModel:");
			}
		}
		
		[Export ("addCommand:")]
		[CompilerGenerated]
		public virtual int AddCommand (NSData data)
		{
			if (data == null)
				throw new ArgumentNullException ("data");
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.int_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("addCommand:"), data.Handle);
			} else {
				return global::ApiDefinition.Messaging.int_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("addCommand:"), data.Handle);
			}
		}
		
		[Export ("addCreateWindow:x:y:width:height:scrollMode:")]
		[CompilerGenerated]
		public virtual int AddCreateWindow (global::System.nint number, global::System.nint x, global::System.nint y, global::System.nint width, global::System.nint height, int scrollMode)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.int_objc_msgSend_nint_nint_nint_nint_nint_int (this.Handle, Selector.GetHandle ("addCreateWindow:x:y:width:height:scrollMode:"), number, x, y, width, height, scrollMode);
			} else {
				return global::ApiDefinition.Messaging.int_objc_msgSendSuper_nint_nint_nint_nint_nint_int (this.SuperHandle, Selector.GetHandle ("addCreateWindow:x:y:width:height:scrollMode:"), number, x, y, width, height, scrollMode);
			}
		}
		
		[Export ("addDestroyWindow:")]
		[CompilerGenerated]
		public virtual int AddDestroyWindow (global::System.nint number)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.int_objc_msgSend_nint (this.Handle, Selector.GetHandle ("addDestroyWindow:"), number);
			} else {
				return global::ApiDefinition.Messaging.int_objc_msgSendSuper_nint (this.SuperHandle, Selector.GetHandle ("addDestroyWindow:"), number);
			}
		}
		
		[Export ("addMarqueeText:format:unitWait:repeatWait:repeatCount:lang:")]
		[CompilerGenerated]
		public virtual int AddMarqueeText (string data, int format, global::System.nint unitWait, global::System.nint repeatWait, global::System.nint repeatCount, int lang)
		{
			if (data == null)
				throw new ArgumentNullException ("data");
			var nsdata = NSString.CreateNative (data);
			
			int ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.int_objc_msgSend_IntPtr_int_nint_nint_nint_int (this.Handle, Selector.GetHandle ("addMarqueeText:format:unitWait:repeatWait:repeatCount:lang:"), nsdata, format, unitWait, repeatWait, repeatCount, lang);
			} else {
				ret = global::ApiDefinition.Messaging.int_objc_msgSendSuper_IntPtr_int_nint_nint_nint_int (this.SuperHandle, Selector.GetHandle ("addMarqueeText:format:unitWait:repeatWait:repeatCount:lang:"), nsdata, format, unitWait, repeatWait, repeatCount, lang);
			}
			NSString.ReleaseNative (nsdata);
			
			return ret;
		}
		
		[Export ("addMoveCursorPosition:")]
		[CompilerGenerated]
		public virtual int AddMoveCursorPosition (int position)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.int_objc_msgSend_int (this.Handle, Selector.GetHandle ("addMoveCursorPosition:"), position);
			} else {
				return global::ApiDefinition.Messaging.int_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("addMoveCursorPosition:"), position);
			}
		}
		
		[Export ("addReverseText:")]
		[CompilerGenerated]
		public virtual int AddReverseText (string data)
		{
			if (data == null)
				throw new ArgumentNullException ("data");
			var nsdata = NSString.CreateNative (data);
			
			int ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.int_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("addReverseText:"), nsdata);
			} else {
				ret = global::ApiDefinition.Messaging.int_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("addReverseText:"), nsdata);
			}
			NSString.ReleaseNative (nsdata);
			
			return ret;
		}
		
		[Export ("addReverseText:lang:")]
		[CompilerGenerated]
		public virtual int AddReverseText (string data, int lang)
		{
			if (data == null)
				throw new ArgumentNullException ("data");
			var nsdata = NSString.CreateNative (data);
			
			int ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.int_objc_msgSend_IntPtr_int (this.Handle, Selector.GetHandle ("addReverseText:lang:"), nsdata, lang);
			} else {
				ret = global::ApiDefinition.Messaging.int_objc_msgSendSuper_IntPtr_int (this.SuperHandle, Selector.GetHandle ("addReverseText:lang:"), nsdata, lang);
			}
			NSString.ReleaseNative (nsdata);
			
			return ret;
		}
		
		[Export ("addReverseText:x:y:")]
		[CompilerGenerated]
		public virtual int AddReverseText (string data, global::System.nint x, global::System.nint y)
		{
			if (data == null)
				throw new ArgumentNullException ("data");
			var nsdata = NSString.CreateNative (data);
			
			int ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.int_objc_msgSend_IntPtr_nint_nint (this.Handle, Selector.GetHandle ("addReverseText:x:y:"), nsdata, x, y);
			} else {
				ret = global::ApiDefinition.Messaging.int_objc_msgSendSuper_IntPtr_nint_nint (this.SuperHandle, Selector.GetHandle ("addReverseText:x:y:"), nsdata, x, y);
			}
			NSString.ReleaseNative (nsdata);
			
			return ret;
		}
		
		[Export ("addReverseText:x:y:lang:")]
		[CompilerGenerated]
		public virtual int AddReverseText (string data, global::System.nint x, global::System.nint y, int lang)
		{
			if (data == null)
				throw new ArgumentNullException ("data");
			var nsdata = NSString.CreateNative (data);
			
			int ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.int_objc_msgSend_IntPtr_nint_nint_int (this.Handle, Selector.GetHandle ("addReverseText:x:y:lang:"), nsdata, x, y, lang);
			} else {
				ret = global::ApiDefinition.Messaging.int_objc_msgSendSuper_IntPtr_nint_nint_int (this.SuperHandle, Selector.GetHandle ("addReverseText:x:y:lang:"), nsdata, x, y, lang);
			}
			NSString.ReleaseNative (nsdata);
			
			return ret;
		}
		
		[Export ("addSetBlink:")]
		[CompilerGenerated]
		public virtual int AddSetBlink (global::System.nint interval)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.int_objc_msgSend_nint (this.Handle, Selector.GetHandle ("addSetBlink:"), interval);
			} else {
				return global::ApiDefinition.Messaging.int_objc_msgSendSuper_nint (this.SuperHandle, Selector.GetHandle ("addSetBlink:"), interval);
			}
		}
		
		[Export ("addSetBrightness:")]
		[CompilerGenerated]
		public virtual int AddSetBrightness (int brightness)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.int_objc_msgSend_int (this.Handle, Selector.GetHandle ("addSetBrightness:"), brightness);
			} else {
				return global::ApiDefinition.Messaging.int_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("addSetBrightness:"), brightness);
			}
		}
		
		[Export ("addSetCurrentWindow:")]
		[CompilerGenerated]
		public virtual int AddSetCurrentWindow (global::System.nint number)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.int_objc_msgSend_nint (this.Handle, Selector.GetHandle ("addSetCurrentWindow:"), number);
			} else {
				return global::ApiDefinition.Messaging.int_objc_msgSendSuper_nint (this.SuperHandle, Selector.GetHandle ("addSetCurrentWindow:"), number);
			}
		}
		
		[Export ("addSetCursorPosition:y:")]
		[CompilerGenerated]
		public virtual int AddSetCursorPosition (global::System.nint x, global::System.nint y)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.int_objc_msgSend_nint_nint (this.Handle, Selector.GetHandle ("addSetCursorPosition:y:"), x, y);
			} else {
				return global::ApiDefinition.Messaging.int_objc_msgSendSuper_nint_nint (this.SuperHandle, Selector.GetHandle ("addSetCursorPosition:y:"), x, y);
			}
		}
		
		[Export ("addSetCursorType:")]
		[CompilerGenerated]
		public virtual int AddSetCursorType (int type)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.int_objc_msgSend_int (this.Handle, Selector.GetHandle ("addSetCursorType:"), type);
			} else {
				return global::ApiDefinition.Messaging.int_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("addSetCursorType:"), type);
			}
		}
		
		[Export ("addText:")]
		[CompilerGenerated]
		public virtual int AddText (string data)
		{
			if (data == null)
				throw new ArgumentNullException ("data");
			var nsdata = NSString.CreateNative (data);
			
			int ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.int_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("addText:"), nsdata);
			} else {
				ret = global::ApiDefinition.Messaging.int_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("addText:"), nsdata);
			}
			NSString.ReleaseNative (nsdata);
			
			return ret;
		}
		
		[Export ("addText:lang:")]
		[CompilerGenerated]
		public virtual int AddText (string data, int lang)
		{
			if (data == null)
				throw new ArgumentNullException ("data");
			var nsdata = NSString.CreateNative (data);
			
			int ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.int_objc_msgSend_IntPtr_int (this.Handle, Selector.GetHandle ("addText:lang:"), nsdata, lang);
			} else {
				ret = global::ApiDefinition.Messaging.int_objc_msgSendSuper_IntPtr_int (this.SuperHandle, Selector.GetHandle ("addText:lang:"), nsdata, lang);
			}
			NSString.ReleaseNative (nsdata);
			
			return ret;
		}
		
		[Export ("addText:x:y:")]
		[CompilerGenerated]
		public virtual int AddText (string data, global::System.nint x, global::System.nint y)
		{
			if (data == null)
				throw new ArgumentNullException ("data");
			var nsdata = NSString.CreateNative (data);
			
			int ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.int_objc_msgSend_IntPtr_nint_nint (this.Handle, Selector.GetHandle ("addText:x:y:"), nsdata, x, y);
			} else {
				ret = global::ApiDefinition.Messaging.int_objc_msgSendSuper_IntPtr_nint_nint (this.SuperHandle, Selector.GetHandle ("addText:x:y:"), nsdata, x, y);
			}
			NSString.ReleaseNative (nsdata);
			
			return ret;
		}
		
		[Export ("addText:x:y:lang:")]
		[CompilerGenerated]
		public virtual int AddText (string data, global::System.nint x, global::System.nint y, int lang)
		{
			if (data == null)
				throw new ArgumentNullException ("data");
			var nsdata = NSString.CreateNative (data);
			
			int ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.int_objc_msgSend_IntPtr_nint_nint_int (this.Handle, Selector.GetHandle ("addText:x:y:lang:"), nsdata, x, y, lang);
			} else {
				ret = global::ApiDefinition.Messaging.int_objc_msgSendSuper_IntPtr_nint_nint_int (this.SuperHandle, Selector.GetHandle ("addText:x:y:lang:"), nsdata, x, y, lang);
			}
			NSString.ReleaseNative (nsdata);
			
			return ret;
		}
		
		[Export ("connect:timeout:")]
		[CompilerGenerated]
		public virtual int Connect (string target, global::System.nint timeout)
		{
			if (target == null)
				throw new ArgumentNullException ("target");
			var nstarget = NSString.CreateNative (target);
			
			int ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.int_objc_msgSend_IntPtr_nint (this.Handle, Selector.GetHandle ("connect:timeout:"), nstarget, timeout);
			} else {
				ret = global::ApiDefinition.Messaging.int_objc_msgSendSuper_IntPtr_nint (this.SuperHandle, Selector.GetHandle ("connect:timeout:"), nstarget, timeout);
			}
			NSString.ReleaseNative (nstarget);
			
			return ret;
		}
		
		[Export ("dealloc")]
		[CompilerGenerated]
		public virtual void Dealloc ()
		{
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend (this.Handle, Selector.GetHandle ("dealloc"));
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("dealloc"));
			}
		}
		
		[Export ("setConnectionEventDelegate:")]
		[CompilerGenerated]
		public virtual void SetConnectionEventDelegate (Epos2ConnectionDelegate @delegate)
		{
			if (@delegate == null)
				throw new ArgumentNullException ("@delegate");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setConnectionEventDelegate:"), @delegate.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setConnectionEventDelegate:"), @delegate.Handle);
			}
		}
		
		[Export ("setReceiveEventDelegate:")]
		[CompilerGenerated]
		public virtual void SetReceiveEventDelegate (Epos2DispReceiveDelegate @delegate)
		{
			if (@delegate == null)
				throw new ArgumentNullException ("@delegate");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setReceiveEventDelegate:"), @delegate.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setReceiveEventDelegate:"), @delegate.Handle);
			}
		}
		
		[CompilerGenerated]
		public virtual int AddClearCurrentWindow {
			[Export ("addClearCurrentWindow")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("addClearCurrentWindow"));
				} else {
					return global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("addClearCurrentWindow"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual int AddInitialize {
			[Export ("addInitialize")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("addInitialize"));
				} else {
					return global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("addInitialize"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual int AddShowClock {
			[Export ("addShowClock")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("addShowClock"));
				} else {
					return global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("addShowClock"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual string Admin {
			[Export ("getAdmin")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("getAdmin")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getAdmin")));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual int ClearCommandBuffer {
			[Export ("clearCommandBuffer")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("clearCommandBuffer"));
				} else {
					return global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("clearCommandBuffer"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual int Disconnect {
			[Export ("disconnect")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("disconnect"));
				} else {
					return global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("disconnect"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual string Location {
			[Export ("getLocation")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("getLocation")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getLocation")));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual int SendData {
			[Export ("sendData")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("sendData"));
				} else {
					return global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("sendData"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual Epos2DisplayStatusInfo Status {
			[Export ("getStatus")]
			get {
				Epos2DisplayStatusInfo ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<Epos2DisplayStatusInfo> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("getStatus")));
				} else {
					ret =  Runtime.GetNSObject<Epos2DisplayStatusInfo> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getStatus")));
				}
				return ret;
			}
			
		}
		
	} /* class Epos2LineDisplay */
}
