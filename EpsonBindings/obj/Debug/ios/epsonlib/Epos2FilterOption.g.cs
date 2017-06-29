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
	[Protocol (Name = "Epos2FilterOption", WrapperType = typeof (Epos2FilterOptionWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "PortType", Selector = "portType", PropertyType = typeof (int), GetterSelector = "getPortType", SetterSelector = "setPortType:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "Broadcast", Selector = "broadcast", PropertyType = typeof (string), GetterSelector = "getBroadcast", SetterSelector = "setBroadcast:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "DeviceModel", Selector = "deviceModel", PropertyType = typeof (int), GetterSelector = "getDeviceModel", SetterSelector = "setDeviceModel:", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "DeviceType", Selector = "deviceType", PropertyType = typeof (int), GetterSelector = "getDeviceType", SetterSelector = "setDeviceType:", ArgumentSemantic = ArgumentSemantic.None)]
	public interface IEpos2FilterOption : INativeObject, IDisposable
	{
	}
	
	public static partial class Epos2FilterOption_Extensions {
		[CompilerGenerated]
		public static int GetPortType (this IEpos2FilterOption This)
		{
			return global::ApiDefinition.Messaging.int_objc_msgSend (This.Handle, Selector.GetHandle ("portType"));
		}
		
		[CompilerGenerated]
		public static void SetPortType (this IEpos2FilterOption This, int value)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_int (This.Handle, Selector.GetHandle ("setPortType:"), value);
		}
		
		[CompilerGenerated]
		public static string GetBroadcast (this IEpos2FilterOption This)
		{
			return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("broadcast")));
		}
		
		[CompilerGenerated]
		public static void SetBroadcast (this IEpos2FilterOption This, string value)
		{
			if (value == null)
				throw new ArgumentNullException ("value");
			var nsvalue = NSString.CreateNative (value);
			
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setBroadcast:"), nsvalue);
			NSString.ReleaseNative (nsvalue);
			
		}
		
		[CompilerGenerated]
		public static int GetDeviceModel (this IEpos2FilterOption This)
		{
			return global::ApiDefinition.Messaging.int_objc_msgSend (This.Handle, Selector.GetHandle ("deviceModel"));
		}
		
		[CompilerGenerated]
		public static void SetDeviceModel (this IEpos2FilterOption This, int value)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_int (This.Handle, Selector.GetHandle ("setDeviceModel:"), value);
		}
		
		[CompilerGenerated]
		public static int GetDeviceType (this IEpos2FilterOption This)
		{
			return global::ApiDefinition.Messaging.int_objc_msgSend (This.Handle, Selector.GetHandle ("deviceType"));
		}
		
		[CompilerGenerated]
		public static void SetDeviceType (this IEpos2FilterOption This, int value)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend_int (This.Handle, Selector.GetHandle ("setDeviceType:"), value);
		}
		
	}
	
	internal sealed class Epos2FilterOptionWrapper : BaseWrapper, IEpos2FilterOption {
		[Preserve (Conditional = true)]
		public Epos2FilterOptionWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace epsonlib {
	[Protocol]
	[Register("Epos2FilterOption", true)]
	public unsafe partial class Epos2FilterOption : NSObject, IEpos2FilterOption {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("Epos2FilterOption");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public Epos2FilterOption () : base (NSObjectFlag.Empty)
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
		protected Epos2FilterOption (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal Epos2FilterOption (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		public virtual string Broadcast {
			[Export ("getBroadcast")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("getBroadcast")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getBroadcast")));
				}
			}
			
			[Export ("setBroadcast:")]
			set {
				if (value == null)
					throw new ArgumentNullException ("value");
				var nsvalue = NSString.CreateNative (value);
				
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setBroadcast:"), nsvalue);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setBroadcast:"), nsvalue);
				}
				NSString.ReleaseNative (nsvalue);
				
			}
		}
		
		[CompilerGenerated]
		public virtual int DeviceModel {
			[Export ("getDeviceModel")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("getDeviceModel"));
				} else {
					return global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getDeviceModel"));
				}
			}
			
			[Export ("setDeviceModel:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setDeviceModel:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("setDeviceModel:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual int DeviceType {
			[Export ("getDeviceType")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("getDeviceType"));
				} else {
					return global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getDeviceType"));
				}
			}
			
			[Export ("setDeviceType:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setDeviceType:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("setDeviceType:"), value);
				}
			}
		}
		
		[CompilerGenerated]
		public virtual int PortType {
			[Export ("getPortType")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("getPortType"));
				} else {
					return global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getPortType"));
				}
			}
			
			[Export ("setPortType:")]
			set {
				if (IsDirectBinding) {
					global::ApiDefinition.Messaging.void_objc_msgSend_int (this.Handle, Selector.GetHandle ("setPortType:"), value);
				} else {
					global::ApiDefinition.Messaging.void_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("setPortType:"), value);
				}
			}
		}
		
	} /* class Epos2FilterOption */
}
