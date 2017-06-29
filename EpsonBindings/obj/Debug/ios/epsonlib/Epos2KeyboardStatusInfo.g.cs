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
	[Protocol (Name = "Epos2KeyboardStatusInfo", WrapperType = typeof (Epos2KeyboardStatusInfoWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "Connection", Selector = "connection", PropertyType = typeof (int), GetterSelector = "getConnection", ArgumentSemantic = ArgumentSemantic.None)]
	public interface IEpos2KeyboardStatusInfo : INativeObject, IDisposable
	{
	}
	
	public static partial class Epos2KeyboardStatusInfo_Extensions {
		[CompilerGenerated]
		public static int GetConnection (this IEpos2KeyboardStatusInfo This)
		{
			return global::ApiDefinition.Messaging.int_objc_msgSend (This.Handle, Selector.GetHandle ("connection"));
		}
		
	}
	
	internal sealed class Epos2KeyboardStatusInfoWrapper : BaseWrapper, IEpos2KeyboardStatusInfo {
		[Preserve (Conditional = true)]
		public Epos2KeyboardStatusInfoWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace epsonlib {
	[Protocol]
	[Register("Epos2KeyboardStatusInfo", true)]
	public unsafe partial class Epos2KeyboardStatusInfo : NSObject, IEpos2KeyboardStatusInfo {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("Epos2KeyboardStatusInfo");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public Epos2KeyboardStatusInfo () : base (NSObjectFlag.Empty)
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
		protected Epos2KeyboardStatusInfo (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal Epos2KeyboardStatusInfo (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		public virtual int Connection {
			[Export ("getConnection")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("getConnection"));
				} else {
					return global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getConnection"));
				}
			}
			
		}
		
	} /* class Epos2KeyboardStatusInfo */
}
