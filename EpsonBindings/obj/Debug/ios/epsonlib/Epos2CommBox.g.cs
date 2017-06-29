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
	[Protocol (Name = "Epos2CommBox", WrapperType = typeof (Epos2CommBoxWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "Dealloc", Selector = "dealloc")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "Connect", Selector = "connect:timeout:myId:", ReturnType = typeof (int), ParameterType = new Type [] { typeof (string), typeof (nint), typeof (string) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "GetCommHistory", Selector = "getCommHistory:", ReturnType = typeof (int), ParameterType = new Type [] { typeof (epsonlib.Epos2GetCommHistoryDelegate) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SendMessage", Selector = "sendMessage:targetId:delegate:", ReturnType = typeof (int), ParameterType = new Type [] { typeof (string), typeof (string), typeof (epsonlib.Epos2CommBoxSendMessageDelegate) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SetReceiveEventDelegate", Selector = "setReceiveEventDelegate:", ParameterType = new Type [] { typeof (epsonlib.Epos2CommBoxReceiveDelegate) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SetConnectionEventDelegate", Selector = "setConnectionEventDelegate:", ParameterType = new Type [] { typeof (epsonlib.Epos2ConnectionDelegate) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "Disconnect", Selector = "disconnect", PropertyType = typeof (int), GetterSelector = "disconnect", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "Status", Selector = "getStatus", PropertyType = typeof (epsonlib.Epos2CommBoxStatusInfo), GetterSelector = "getStatus", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "Admin", Selector = "getAdmin", PropertyType = typeof (string), GetterSelector = "getAdmin", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "Location", Selector = "getLocation", PropertyType = typeof (string), GetterSelector = "getLocation", ArgumentSemantic = ArgumentSemantic.None)]
	public interface IEpos2CommBox : INativeObject, IDisposable
	{
	}
	
	public static partial class Epos2CommBox_Extensions {
		[CompilerGenerated]
		public static void Dealloc (this IEpos2CommBox This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("dealloc"));
		}
		
		[CompilerGenerated]
		public static int Connect (this IEpos2CommBox This, string target, global::System.nint timeout, string myId)
		{
			if (target == null)
				throw new ArgumentNullException ("target");
			if (myId == null)
				throw new ArgumentNullException ("myId");
			var nstarget = NSString.CreateNative (target);
			var nsmyId = NSString.CreateNative (myId);
			
			int ret;
			ret = global::ApiDefinition.Messaging.int_objc_msgSend_IntPtr_nint_IntPtr (This.Handle, Selector.GetHandle ("connect:timeout:myId:"), nstarget, timeout, nsmyId);
			NSString.ReleaseNative (nstarget);
			NSString.ReleaseNative (nsmyId);
			
			return ret;
		}
		
		[CompilerGenerated]
		public static int GetCommHistory (this IEpos2CommBox This, Epos2GetCommHistoryDelegate @delegate)
		{
			if (@delegate == null)
				throw new ArgumentNullException ("@delegate");
			return global::ApiDefinition.Messaging.int_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("getCommHistory:"), @delegate.Handle);
		}
		
		[CompilerGenerated]
		public static int SendMessage (this IEpos2CommBox This, string message, string targetId, Epos2CommBoxSendMessageDelegate @delegate)
		{
			if (message == null)
				throw new ArgumentNullException ("message");
			if (targetId == null)
				throw new ArgumentNullException ("targetId");
			if (@delegate == null)
				throw new ArgumentNullException ("@delegate");
			var nsmessage = NSString.CreateNative (message);
			var nstargetId = NSString.CreateNative (targetId);
			
			int ret;
			ret = global::ApiDefinition.Messaging.int_objc_msgSend_IntPtr_IntPtr_IntPtr (This.Handle, Selector.GetHandle ("sendMessage:targetId:delegate:"), nsmessage, nstargetId, @delegate.Handle);
			NSString.ReleaseNative (nsmessage);
			NSString.ReleaseNative (nstargetId);
			
			return ret;
		}
		
		[CompilerGenerated]
		public static void SetReceiveEventDelegate (this IEpos2CommBox This, Epos2CommBoxReceiveDelegate @delegate)
		{
			if (@delegate == null)
				throw new ArgumentNullException ("@delegate");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setReceiveEventDelegate:"), @delegate.Handle);
		}
		
		[CompilerGenerated]
		public static void SetConnectionEventDelegate (this IEpos2CommBox This, Epos2ConnectionDelegate @delegate)
		{
			if (@delegate == null)
				throw new ArgumentNullException ("@delegate");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setConnectionEventDelegate:"), @delegate.Handle);
		}
		
		[CompilerGenerated]
		public static int GetDisconnect (this IEpos2CommBox This)
		{
			return global::ApiDefinition.Messaging.int_objc_msgSend (This.Handle, Selector.GetHandle ("disconnect"));
		}
		
		[CompilerGenerated]
		public static Epos2CommBoxStatusInfo GetStatus (this IEpos2CommBox This)
		{
			return  Runtime.GetNSObject<Epos2CommBoxStatusInfo> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("getStatus")));
		}
		
		[CompilerGenerated]
		public static string GetAdmin (this IEpos2CommBox This)
		{
			return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("getAdmin")));
		}
		
		[CompilerGenerated]
		public static string GetLocation (this IEpos2CommBox This)
		{
			return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("getLocation")));
		}
		
	}
	
	internal sealed class Epos2CommBoxWrapper : BaseWrapper, IEpos2CommBox {
		[Preserve (Conditional = true)]
		public Epos2CommBoxWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace epsonlib {
	[Protocol]
	[Register("Epos2CommBox", true)]
	public unsafe partial class Epos2CommBox : NSObject, IEpos2CommBox {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("Epos2CommBox");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public Epos2CommBox () : base (NSObjectFlag.Empty)
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
		protected Epos2CommBox (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal Epos2CommBox (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("connect:timeout:myId:")]
		[CompilerGenerated]
		public virtual int Connect (string target, global::System.nint timeout, string myId)
		{
			if (target == null)
				throw new ArgumentNullException ("target");
			if (myId == null)
				throw new ArgumentNullException ("myId");
			var nstarget = NSString.CreateNative (target);
			var nsmyId = NSString.CreateNative (myId);
			
			int ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.int_objc_msgSend_IntPtr_nint_IntPtr (this.Handle, Selector.GetHandle ("connect:timeout:myId:"), nstarget, timeout, nsmyId);
			} else {
				ret = global::ApiDefinition.Messaging.int_objc_msgSendSuper_IntPtr_nint_IntPtr (this.SuperHandle, Selector.GetHandle ("connect:timeout:myId:"), nstarget, timeout, nsmyId);
			}
			NSString.ReleaseNative (nstarget);
			NSString.ReleaseNative (nsmyId);
			
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
		
		[Export ("getCommHistory:")]
		[CompilerGenerated]
		public virtual int GetCommHistory (Epos2GetCommHistoryDelegate @delegate)
		{
			if (@delegate == null)
				throw new ArgumentNullException ("@delegate");
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.int_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("getCommHistory:"), @delegate.Handle);
			} else {
				return global::ApiDefinition.Messaging.int_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("getCommHistory:"), @delegate.Handle);
			}
		}
		
		[Export ("sendMessage:targetId:delegate:")]
		[CompilerGenerated]
		public virtual int SendMessage (string message, string targetId, Epos2CommBoxSendMessageDelegate @delegate)
		{
			if (message == null)
				throw new ArgumentNullException ("message");
			if (targetId == null)
				throw new ArgumentNullException ("targetId");
			if (@delegate == null)
				throw new ArgumentNullException ("@delegate");
			var nsmessage = NSString.CreateNative (message);
			var nstargetId = NSString.CreateNative (targetId);
			
			int ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.int_objc_msgSend_IntPtr_IntPtr_IntPtr (this.Handle, Selector.GetHandle ("sendMessage:targetId:delegate:"), nsmessage, nstargetId, @delegate.Handle);
			} else {
				ret = global::ApiDefinition.Messaging.int_objc_msgSendSuper_IntPtr_IntPtr_IntPtr (this.SuperHandle, Selector.GetHandle ("sendMessage:targetId:delegate:"), nsmessage, nstargetId, @delegate.Handle);
			}
			NSString.ReleaseNative (nsmessage);
			NSString.ReleaseNative (nstargetId);
			
			return ret;
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
		public virtual void SetReceiveEventDelegate (Epos2CommBoxReceiveDelegate @delegate)
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
		public virtual Epos2CommBoxStatusInfo Status {
			[Export ("getStatus")]
			get {
				Epos2CommBoxStatusInfo ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<Epos2CommBoxStatusInfo> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("getStatus")));
				} else {
					ret =  Runtime.GetNSObject<Epos2CommBoxStatusInfo> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getStatus")));
				}
				return ret;
			}
			
		}
		
	} /* class Epos2CommBox */
}
