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
	[Protocol (Name = "Epos2DeviceInfo", WrapperType = typeof (Epos2DeviceInfoWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "DeviceType", Selector = "deviceType", PropertyType = typeof (int), GetterSelector = "getDeviceType", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "Target", Selector = "target", PropertyType = typeof (string), GetterSelector = "getTarget", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "DeviceName", Selector = "deviceName", PropertyType = typeof (string), GetterSelector = "getDeviceName", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "IpAddress", Selector = "ipAddress", PropertyType = typeof (string), GetterSelector = "getIpAddress", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "MacAddress", Selector = "macAddress", PropertyType = typeof (string), GetterSelector = "getMacAddress", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "BdAddress", Selector = "bdAddress", PropertyType = typeof (string), GetterSelector = "getBdAddress", ArgumentSemantic = ArgumentSemantic.None)]
	public interface IEpos2DeviceInfo : INativeObject, IDisposable
	{
	}
	
	public static partial class Epos2DeviceInfo_Extensions {
		[CompilerGenerated]
		public static int GetDeviceType (this IEpos2DeviceInfo This)
		{
			return global::ApiDefinition.Messaging.int_objc_msgSend (This.Handle, Selector.GetHandle ("deviceType"));
		}
		
		[CompilerGenerated]
		public static string GetTarget (this IEpos2DeviceInfo This)
		{
			return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("target")));
		}
		
		[CompilerGenerated]
		public static string GetDeviceName (this IEpos2DeviceInfo This)
		{
			return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("deviceName")));
		}
		
		[CompilerGenerated]
		public static string GetIpAddress (this IEpos2DeviceInfo This)
		{
			return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("ipAddress")));
		}
		
		[CompilerGenerated]
		public static string GetMacAddress (this IEpos2DeviceInfo This)
		{
			return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("macAddress")));
		}
		
		[CompilerGenerated]
		public static string GetBdAddress (this IEpos2DeviceInfo This)
		{
			return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("bdAddress")));
		}
		
	}
	
	internal sealed class Epos2DeviceInfoWrapper : BaseWrapper, IEpos2DeviceInfo {
		[Preserve (Conditional = true)]
		public Epos2DeviceInfoWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace epsonlib {
	[Protocol]
	[Register("Epos2DeviceInfo", true)]
	public unsafe partial class Epos2DeviceInfo : NSObject, IEpos2DeviceInfo {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("Epos2DeviceInfo");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public Epos2DeviceInfo () : base (NSObjectFlag.Empty)
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
		protected Epos2DeviceInfo (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal Epos2DeviceInfo (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		public virtual string BdAddress {
			[Export ("getBdAddress")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("getBdAddress")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getBdAddress")));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual string DeviceName {
			[Export ("getDeviceName")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("getDeviceName")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getDeviceName")));
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
			
		}
		
		[CompilerGenerated]
		public virtual string IpAddress {
			[Export ("getIpAddress")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("getIpAddress")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getIpAddress")));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual string MacAddress {
			[Export ("getMacAddress")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("getMacAddress")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getMacAddress")));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual string Target {
			[Export ("getTarget")]
			get {
				if (IsDirectBinding) {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("getTarget")));
				} else {
					return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getTarget")));
				}
			}
			
		}
		
	} /* class Epos2DeviceInfo */
}
