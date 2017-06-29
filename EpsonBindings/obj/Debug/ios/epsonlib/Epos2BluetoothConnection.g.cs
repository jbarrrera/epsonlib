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
	[Protocol (Name = "Epos2BluetoothConnection", WrapperType = typeof (Epos2BluetoothConnectionWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "Dealloc", Selector = "dealloc")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ConnectDevice", Selector = "connectDevice:", ReturnType = typeof (int), ParameterType = new Type [] { typeof (NSMutableString) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "DisconnectDevice", Selector = "disconnectDevice:", ReturnType = typeof (int), ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	public interface IEpos2BluetoothConnection : INativeObject, IDisposable
	{
	}
	
	public static partial class Epos2BluetoothConnection_Extensions {
		[CompilerGenerated]
		public static void Dealloc (this IEpos2BluetoothConnection This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("dealloc"));
		}
		
		[CompilerGenerated]
		public static int ConnectDevice (this IEpos2BluetoothConnection This, NSMutableString target)
		{
			if (target == null)
				throw new ArgumentNullException ("target");
			return global::ApiDefinition.Messaging.int_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("connectDevice:"), target.Handle);
		}
		
		[CompilerGenerated]
		public static int DisconnectDevice (this IEpos2BluetoothConnection This, string target)
		{
			if (target == null)
				throw new ArgumentNullException ("target");
			var nstarget = NSString.CreateNative (target);
			
			int ret;
			ret = global::ApiDefinition.Messaging.int_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("disconnectDevice:"), nstarget);
			NSString.ReleaseNative (nstarget);
			
			return ret;
		}
		
	}
	
	internal sealed class Epos2BluetoothConnectionWrapper : BaseWrapper, IEpos2BluetoothConnection {
		[Preserve (Conditional = true)]
		public Epos2BluetoothConnectionWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace epsonlib {
	[Protocol]
	[Register("Epos2BluetoothConnection", true)]
	public unsafe partial class Epos2BluetoothConnection : NSObject, IEpos2BluetoothConnection {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("Epos2BluetoothConnection");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public Epos2BluetoothConnection () : base (NSObjectFlag.Empty)
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
		protected Epos2BluetoothConnection (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal Epos2BluetoothConnection (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("connectDevice:")]
		[CompilerGenerated]
		public virtual int ConnectDevice (NSMutableString target)
		{
			if (target == null)
				throw new ArgumentNullException ("target");
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.int_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("connectDevice:"), target.Handle);
			} else {
				return global::ApiDefinition.Messaging.int_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("connectDevice:"), target.Handle);
			}
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
		
		[Export ("disconnectDevice:")]
		[CompilerGenerated]
		public virtual int DisconnectDevice (string target)
		{
			if (target == null)
				throw new ArgumentNullException ("target");
			var nstarget = NSString.CreateNative (target);
			
			int ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.int_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("disconnectDevice:"), nstarget);
			} else {
				ret = global::ApiDefinition.Messaging.int_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("disconnectDevice:"), nstarget);
			}
			NSString.ReleaseNative (nstarget);
			
			return ret;
		}
		
	} /* class Epos2BluetoothConnection */
}
