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
	[Protocol (Name = "Epos2Keyboard", WrapperType = typeof (Epos2KeyboardWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "Dealloc", Selector = "dealloc")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "Connect", Selector = "connect:timeout:", ReturnType = typeof (int), ParameterType = new Type [] { typeof (string), typeof (nint) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SetPrefix", Selector = "setPrefix:", ReturnType = typeof (int), ParameterType = new Type [] { typeof (NSData) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SetKeyPressEventDelegate", Selector = "setKeyPressEventDelegate:", ParameterType = new Type [] { typeof (epsonlib.Epos2KbdKeyPressDelegate) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SetReadStringEventDelegate", Selector = "setReadStringEventDelegate:", ParameterType = new Type [] { typeof (epsonlib.Epos2KbdReadStringDelegate) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SetConnectionEventDelegate", Selector = "setConnectionEventDelegate:", ParameterType = new Type [] { typeof (epsonlib.Epos2ConnectionDelegate) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "Disconnect", Selector = "disconnect", PropertyType = typeof (int), GetterSelector = "disconnect", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "Status", Selector = "getStatus", PropertyType = typeof (epsonlib.Epos2KeyboardStatusInfo), GetterSelector = "getStatus", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "Prefix", Selector = "getPrefix", PropertyType = typeof (NSData), GetterSelector = "getPrefix", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "Admin", Selector = "getAdmin", PropertyType = typeof (string), GetterSelector = "getAdmin", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "Location", Selector = "getLocation", PropertyType = typeof (string), GetterSelector = "getLocation", ArgumentSemantic = ArgumentSemantic.None)]
	public interface IEpos2Keyboard : INativeObject, IDisposable
	{
	}
	
	public static partial class Epos2Keyboard_Extensions {
		[CompilerGenerated]
		public static void Dealloc (this IEpos2Keyboard This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("dealloc"));
		}
		
		[CompilerGenerated]
		public static int Connect (this IEpos2Keyboard This, string target, global::System.nint timeout)
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
		public static int SetPrefix (this IEpos2Keyboard This, NSData data)
		{
			if (data == null)
				throw new ArgumentNullException ("data");
			return global::ApiDefinition.Messaging.int_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setPrefix:"), data.Handle);
		}
		
		[CompilerGenerated]
		public static void SetKeyPressEventDelegate (this IEpos2Keyboard This, Epos2KbdKeyPressDelegate @delegate)
		{
			if (@delegate == null)
				throw new ArgumentNullException ("@delegate");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setKeyPressEventDelegate:"), @delegate.Handle);
		}
		
		[CompilerGenerated]
		public static void SetReadStringEventDelegate (this IEpos2Keyboard This, Epos2KbdReadStringDelegate @delegate)
		{
			if (@delegate == null)
				throw new ArgumentNullException ("@delegate");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setReadStringEventDelegate:"), @delegate.Handle);
		}
		
		[CompilerGenerated]
		public static void SetConnectionEventDelegate (this IEpos2Keyboard This, Epos2ConnectionDelegate @delegate)
		{
			if (@delegate == null)
				throw new ArgumentNullException ("@delegate");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setConnectionEventDelegate:"), @delegate.Handle);
		}
		
		[CompilerGenerated]
		public static int GetDisconnect (this IEpos2Keyboard This)
		{
			return global::ApiDefinition.Messaging.int_objc_msgSend (This.Handle, Selector.GetHandle ("disconnect"));
		}
		
		[CompilerGenerated]
		public static Epos2KeyboardStatusInfo GetStatus (this IEpos2Keyboard This)
		{
			return  Runtime.GetNSObject<Epos2KeyboardStatusInfo> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("getStatus")));
		}
		
		[CompilerGenerated]
		public static NSData GetPrefix (this IEpos2Keyboard This)
		{
			return  Runtime.GetNSObject<NSData> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("getPrefix")));
		}
		
		[CompilerGenerated]
		public static string GetAdmin (this IEpos2Keyboard This)
		{
			return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("getAdmin")));
		}
		
		[CompilerGenerated]
		public static string GetLocation (this IEpos2Keyboard This)
		{
			return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("getLocation")));
		}
		
	}
	
	internal sealed class Epos2KeyboardWrapper : BaseWrapper, IEpos2Keyboard {
		[Preserve (Conditional = true)]
		public Epos2KeyboardWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace epsonlib {
	[Protocol]
	[Register("Epos2Keyboard", true)]
	public unsafe partial class Epos2Keyboard : NSObject, IEpos2Keyboard {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("Epos2Keyboard");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public Epos2Keyboard () : base (NSObjectFlag.Empty)
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
		protected Epos2Keyboard (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal Epos2Keyboard (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
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
		
		[Export ("setKeyPressEventDelegate:")]
		[CompilerGenerated]
		public virtual void SetKeyPressEventDelegate (Epos2KbdKeyPressDelegate @delegate)
		{
			if (@delegate == null)
				throw new ArgumentNullException ("@delegate");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setKeyPressEventDelegate:"), @delegate.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setKeyPressEventDelegate:"), @delegate.Handle);
			}
		}
		
		[Export ("setPrefix:")]
		[CompilerGenerated]
		public virtual int SetPrefix (NSData data)
		{
			if (data == null)
				throw new ArgumentNullException ("data");
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.int_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setPrefix:"), data.Handle);
			} else {
				return global::ApiDefinition.Messaging.int_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setPrefix:"), data.Handle);
			}
		}
		
		[Export ("setReadStringEventDelegate:")]
		[CompilerGenerated]
		public virtual void SetReadStringEventDelegate (Epos2KbdReadStringDelegate @delegate)
		{
			if (@delegate == null)
				throw new ArgumentNullException ("@delegate");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setReadStringEventDelegate:"), @delegate.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setReadStringEventDelegate:"), @delegate.Handle);
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
		public virtual NSData Prefix {
			[Export ("getPrefix")]
			get {
				NSData ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<NSData> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("getPrefix")));
				} else {
					ret =  Runtime.GetNSObject<NSData> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getPrefix")));
				}
				return ret;
			}
			
		}
		
		[CompilerGenerated]
		public virtual Epos2KeyboardStatusInfo Status {
			[Export ("getStatus")]
			get {
				Epos2KeyboardStatusInfo ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<Epos2KeyboardStatusInfo> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("getStatus")));
				} else {
					ret =  Runtime.GetNSObject<Epos2KeyboardStatusInfo> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getStatus")));
				}
				return ret;
			}
			
		}
		
	} /* class Epos2Keyboard */
}
