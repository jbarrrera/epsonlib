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
	[Protocol (Name = "Epos2Log", WrapperType = typeof (Epos2LogWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = true, Name = "SetLogSettings", Selector = "setLogSettings:output:ipAddress:port:logSize:logLevel:", ReturnType = typeof (int), ParameterType = new Type [] { typeof (int), typeof (int), typeof (string), typeof (int), typeof (int), typeof (int) }, ParameterByRef = new bool [] { false, false, false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = true, Name = "SdkVersion", Selector = "getSdkVersion", PropertyType = typeof (string), GetterSelector = "getSdkVersion", ArgumentSemantic = ArgumentSemantic.None)]
	public interface IEpos2Log : INativeObject, IDisposable
	{
	}
	
	internal sealed class Epos2LogWrapper : BaseWrapper, IEpos2Log {
		[Preserve (Conditional = true)]
		public Epos2LogWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace epsonlib {
	[Protocol]
	[Register("Epos2Log", true)]
	public unsafe partial class Epos2Log : NSObject, IEpos2Log {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("Epos2Log");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public Epos2Log () : base (NSObjectFlag.Empty)
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
		protected Epos2Log (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal Epos2Log (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("setLogSettings:output:ipAddress:port:logSize:logLevel:")]
		[CompilerGenerated]
		public static int SetLogSettings (int period, int output, string ipAddress, int port, int logSize, int logLevel)
		{
			if (ipAddress == null)
				throw new ArgumentNullException ("ipAddress");
			var nsipAddress = NSString.CreateNative (ipAddress);
			
			int ret;
			ret = global::ApiDefinition.Messaging.int_objc_msgSend_int_int_IntPtr_int_int_int (class_ptr, Selector.GetHandle ("setLogSettings:output:ipAddress:port:logSize:logLevel:"), period, output, nsipAddress, port, logSize, logLevel);
			NSString.ReleaseNative (nsipAddress);
			
			return ret;
		}
		
		[CompilerGenerated]
		public static string SdkVersion {
			[Export ("getSdkVersion")]
			get {
				return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (class_ptr, Selector.GetHandle ("getSdkVersion")));
			}
			
		}
		
	} /* class Epos2Log */
}
