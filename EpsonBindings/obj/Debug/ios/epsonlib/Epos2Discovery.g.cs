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
	[Protocol (Name = "Epos2Discovery", WrapperType = typeof (Epos2DiscoveryWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = true, Name = "Start", Selector = "start:delegate:", ReturnType = typeof (int), ParameterType = new Type [] { typeof (epsonlib.Epos2FilterOption), typeof (epsonlib.Epos2DiscoveryDelegate) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = true, Name = "Stop", Selector = "stop", PropertyType = typeof (int), GetterSelector = "stop", ArgumentSemantic = ArgumentSemantic.None)]
	public interface IEpos2Discovery : INativeObject, IDisposable
	{
	}
	
	internal sealed class Epos2DiscoveryWrapper : BaseWrapper, IEpos2Discovery {
		[Preserve (Conditional = true)]
		public Epos2DiscoveryWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace epsonlib {
	[Protocol]
	[Register("Epos2Discovery", true)]
	public unsafe partial class Epos2Discovery : NSObject, IEpos2Discovery {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("Epos2Discovery");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public Epos2Discovery () : base (NSObjectFlag.Empty)
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
		protected Epos2Discovery (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal Epos2Discovery (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("start:delegate:")]
		[CompilerGenerated]
		public static int Start (Epos2FilterOption filterOption, Epos2DiscoveryDelegate @delegate)
		{
			if (filterOption == null)
				throw new ArgumentNullException ("filterOption");
			if (@delegate == null)
				throw new ArgumentNullException ("@delegate");
			return global::ApiDefinition.Messaging.int_objc_msgSend_IntPtr_IntPtr (class_ptr, Selector.GetHandle ("start:delegate:"), filterOption.Handle, @delegate.Handle);
		}
		
		[CompilerGenerated]
		public static int Stop {
			[Export ("stop")]
			get {
				return global::ApiDefinition.Messaging.int_objc_msgSend (class_ptr, Selector.GetHandle ("stop"));
			}
			
		}
		
	} /* class Epos2Discovery */
}
