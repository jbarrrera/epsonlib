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
	[Protocol (Name = "Epos2BarcodeScanner", WrapperType = typeof (Epos2BarcodeScannerWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "Dealloc", Selector = "dealloc")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "Connect", Selector = "connect:timeout:", ReturnType = typeof (int), ParameterType = new Type [] { typeof (string), typeof (nint) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SetScanEventDelegate", Selector = "setScanEventDelegate:", ParameterType = new Type [] { typeof (epsonlib.Epos2ScanDelegate) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SetConnectionEventDelegate", Selector = "setConnectionEventDelegate:", ParameterType = new Type [] { typeof (epsonlib.Epos2ConnectionDelegate) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "Disconnect", Selector = "disconnect", PropertyType = typeof (int), GetterSelector = "disconnect", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "Status", Selector = "getStatus", PropertyType = typeof (epsonlib.Epos2ScannerStatusInfo), GetterSelector = "getStatus", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "Admin", Selector = "getAdmin", PropertyType = typeof (string), GetterSelector = "getAdmin", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "Location", Selector = "getLocation", PropertyType = typeof (string), GetterSelector = "getLocation", ArgumentSemantic = ArgumentSemantic.None)]
	public interface IEpos2BarcodeScanner : INativeObject, IDisposable
	{
	}
	
	public static partial class Epos2BarcodeScanner_Extensions {
		[CompilerGenerated]
		public static void Dealloc (this IEpos2BarcodeScanner This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("dealloc"));
		}
		
		[CompilerGenerated]
		public static int Connect (this IEpos2BarcodeScanner This, string target, global::System.nint timeout)
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
		public static void SetScanEventDelegate (this IEpos2BarcodeScanner This, Epos2ScanDelegate @delegate)
		{
			if (@delegate == null)
				throw new ArgumentNullException ("@delegate");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setScanEventDelegate:"), @delegate.Handle);
		}
		
		[CompilerGenerated]
		public static void SetConnectionEventDelegate (this IEpos2BarcodeScanner This, Epos2ConnectionDelegate @delegate)
		{
			if (@delegate == null)
				throw new ArgumentNullException ("@delegate");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setConnectionEventDelegate:"), @delegate.Handle);
		}
		
		[CompilerGenerated]
		public static int GetDisconnect (this IEpos2BarcodeScanner This)
		{
			return global::ApiDefinition.Messaging.int_objc_msgSend (This.Handle, Selector.GetHandle ("disconnect"));
		}
		
		[CompilerGenerated]
		public static Epos2ScannerStatusInfo GetStatus (this IEpos2BarcodeScanner This)
		{
			return  Runtime.GetNSObject<Epos2ScannerStatusInfo> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("getStatus")));
		}
		
		[CompilerGenerated]
		public static string GetAdmin (this IEpos2BarcodeScanner This)
		{
			return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("getAdmin")));
		}
		
		[CompilerGenerated]
		public static string GetLocation (this IEpos2BarcodeScanner This)
		{
			return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("getLocation")));
		}
		
	}
	
	internal sealed class Epos2BarcodeScannerWrapper : BaseWrapper, IEpos2BarcodeScanner {
		[Preserve (Conditional = true)]
		public Epos2BarcodeScannerWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace epsonlib {
	[Protocol]
	[Register("Epos2BarcodeScanner", true)]
	public unsafe partial class Epos2BarcodeScanner : NSObject, IEpos2BarcodeScanner {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("Epos2BarcodeScanner");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public Epos2BarcodeScanner () : base (NSObjectFlag.Empty)
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
		protected Epos2BarcodeScanner (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal Epos2BarcodeScanner (IntPtr handle) : base (handle)
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
		
		[Export ("setScanEventDelegate:")]
		[CompilerGenerated]
		public virtual void SetScanEventDelegate (Epos2ScanDelegate @delegate)
		{
			if (@delegate == null)
				throw new ArgumentNullException ("@delegate");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setScanEventDelegate:"), @delegate.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setScanEventDelegate:"), @delegate.Handle);
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
		public virtual Epos2ScannerStatusInfo Status {
			[Export ("getStatus")]
			get {
				Epos2ScannerStatusInfo ret;
				if (IsDirectBinding) {
					ret =  Runtime.GetNSObject<Epos2ScannerStatusInfo> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("getStatus")));
				} else {
					ret =  Runtime.GetNSObject<Epos2ScannerStatusInfo> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getStatus")));
				}
				return ret;
			}
			
		}
		
	} /* class Epos2BarcodeScanner */
}
