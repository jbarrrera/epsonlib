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
	[Protocol (Name = "Epos2PrinterStatusInfo", WrapperType = typeof (Epos2PrinterStatusInfoWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "Connection", Selector = "connection", PropertyType = typeof (int), GetterSelector = "getConnection", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "Online", Selector = "online", PropertyType = typeof (int), GetterSelector = "getOnline", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "CoverOpen", Selector = "coverOpen", PropertyType = typeof (int), GetterSelector = "getCoverOpen", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "Paper", Selector = "paper", PropertyType = typeof (int), GetterSelector = "getPaper", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "PaperFeed", Selector = "paperFeed", PropertyType = typeof (int), GetterSelector = "getPaperFeed", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "PanelSwitch", Selector = "panelSwitch", PropertyType = typeof (int), GetterSelector = "getPanelSwitch", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "WaitOnline", Selector = "waitOnline", PropertyType = typeof (int), GetterSelector = "getWaitOnline", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "Drawer", Selector = "drawer", PropertyType = typeof (int), GetterSelector = "getDrawer", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "ErrorStatus", Selector = "errorStatus", PropertyType = typeof (int), GetterSelector = "getErrorStatus", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "AutoRecoverError", Selector = "autoRecoverError", PropertyType = typeof (int), GetterSelector = "getAutoRecoverError", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "Buzzer", Selector = "buzzer", PropertyType = typeof (int), GetterSelector = "getBuzzer", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "Adapter", Selector = "adapter", PropertyType = typeof (int), GetterSelector = "getAdapter", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "BatteryLevel", Selector = "batteryLevel", PropertyType = typeof (int), GetterSelector = "getBatteryLevel", ArgumentSemantic = ArgumentSemantic.None)]
	public interface IEpos2PrinterStatusInfo : INativeObject, IDisposable
	{
	}
	
	public static partial class Epos2PrinterStatusInfo_Extensions {
		[CompilerGenerated]
		public static int GetConnection (this IEpos2PrinterStatusInfo This)
		{
			return global::ApiDefinition.Messaging.int_objc_msgSend (This.Handle, Selector.GetHandle ("connection"));
		}
		
		[CompilerGenerated]
		public static int GetOnline (this IEpos2PrinterStatusInfo This)
		{
			return global::ApiDefinition.Messaging.int_objc_msgSend (This.Handle, Selector.GetHandle ("online"));
		}
		
		[CompilerGenerated]
		public static int GetCoverOpen (this IEpos2PrinterStatusInfo This)
		{
			return global::ApiDefinition.Messaging.int_objc_msgSend (This.Handle, Selector.GetHandle ("coverOpen"));
		}
		
		[CompilerGenerated]
		public static int GetPaper (this IEpos2PrinterStatusInfo This)
		{
			return global::ApiDefinition.Messaging.int_objc_msgSend (This.Handle, Selector.GetHandle ("paper"));
		}
		
		[CompilerGenerated]
		public static int GetPaperFeed (this IEpos2PrinterStatusInfo This)
		{
			return global::ApiDefinition.Messaging.int_objc_msgSend (This.Handle, Selector.GetHandle ("paperFeed"));
		}
		
		[CompilerGenerated]
		public static int GetPanelSwitch (this IEpos2PrinterStatusInfo This)
		{
			return global::ApiDefinition.Messaging.int_objc_msgSend (This.Handle, Selector.GetHandle ("panelSwitch"));
		}
		
		[CompilerGenerated]
		public static int GetWaitOnline (this IEpos2PrinterStatusInfo This)
		{
			return global::ApiDefinition.Messaging.int_objc_msgSend (This.Handle, Selector.GetHandle ("waitOnline"));
		}
		
		[CompilerGenerated]
		public static int GetDrawer (this IEpos2PrinterStatusInfo This)
		{
			return global::ApiDefinition.Messaging.int_objc_msgSend (This.Handle, Selector.GetHandle ("drawer"));
		}
		
		[CompilerGenerated]
		public static int GetErrorStatus (this IEpos2PrinterStatusInfo This)
		{
			return global::ApiDefinition.Messaging.int_objc_msgSend (This.Handle, Selector.GetHandle ("errorStatus"));
		}
		
		[CompilerGenerated]
		public static int GetAutoRecoverError (this IEpos2PrinterStatusInfo This)
		{
			return global::ApiDefinition.Messaging.int_objc_msgSend (This.Handle, Selector.GetHandle ("autoRecoverError"));
		}
		
		[CompilerGenerated]
		public static int GetBuzzer (this IEpos2PrinterStatusInfo This)
		{
			return global::ApiDefinition.Messaging.int_objc_msgSend (This.Handle, Selector.GetHandle ("buzzer"));
		}
		
		[CompilerGenerated]
		public static int GetAdapter (this IEpos2PrinterStatusInfo This)
		{
			return global::ApiDefinition.Messaging.int_objc_msgSend (This.Handle, Selector.GetHandle ("adapter"));
		}
		
		[CompilerGenerated]
		public static int GetBatteryLevel (this IEpos2PrinterStatusInfo This)
		{
			return global::ApiDefinition.Messaging.int_objc_msgSend (This.Handle, Selector.GetHandle ("batteryLevel"));
		}
		
	}
	
	internal sealed class Epos2PrinterStatusInfoWrapper : BaseWrapper, IEpos2PrinterStatusInfo {
		[Preserve (Conditional = true)]
		public Epos2PrinterStatusInfoWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace epsonlib {
	[Protocol]
	[Register("Epos2PrinterStatusInfo", true)]
	public unsafe partial class Epos2PrinterStatusInfo : NSObject, IEpos2PrinterStatusInfo {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("Epos2PrinterStatusInfo");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public Epos2PrinterStatusInfo () : base (NSObjectFlag.Empty)
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
		protected Epos2PrinterStatusInfo (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal Epos2PrinterStatusInfo (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		public virtual int Adapter {
			[Export ("getAdapter")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("getAdapter"));
				} else {
					return global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getAdapter"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual int AutoRecoverError {
			[Export ("getAutoRecoverError")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("getAutoRecoverError"));
				} else {
					return global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getAutoRecoverError"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual int BatteryLevel {
			[Export ("getBatteryLevel")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("getBatteryLevel"));
				} else {
					return global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getBatteryLevel"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual int Buzzer {
			[Export ("getBuzzer")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("getBuzzer"));
				} else {
					return global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getBuzzer"));
				}
			}
			
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
		
		[CompilerGenerated]
		public virtual int CoverOpen {
			[Export ("getCoverOpen")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("getCoverOpen"));
				} else {
					return global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getCoverOpen"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual int Drawer {
			[Export ("getDrawer")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("getDrawer"));
				} else {
					return global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getDrawer"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual int ErrorStatus {
			[Export ("getErrorStatus")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("getErrorStatus"));
				} else {
					return global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getErrorStatus"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual int Online {
			[Export ("getOnline")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("getOnline"));
				} else {
					return global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getOnline"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual int PanelSwitch {
			[Export ("getPanelSwitch")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("getPanelSwitch"));
				} else {
					return global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getPanelSwitch"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual int Paper {
			[Export ("getPaper")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("getPaper"));
				} else {
					return global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getPaper"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual int PaperFeed {
			[Export ("getPaperFeed")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("getPaperFeed"));
				} else {
					return global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getPaperFeed"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual int WaitOnline {
			[Export ("getWaitOnline")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("getWaitOnline"));
				} else {
					return global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getWaitOnline"));
				}
			}
			
		}
		
	} /* class Epos2PrinterStatusInfo */
}
