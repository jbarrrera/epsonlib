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
	[Protocol (Name = "Epos2Printer", WrapperType = typeof (Epos2PrinterWrapper))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "Dealloc", Selector = "dealloc")]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "Connect", Selector = "connect:timeout:", ReturnType = typeof (int), ParameterType = new Type [] { typeof (string), typeof (nint) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "getStatus", Selector = "getStatus", ReturnType = typeof (epsonlib.Epos2PrinterStatusInfo))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SendData", Selector = "sendData:", ReturnType = typeof (int), ParameterType = new Type [] { typeof (nint) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "BeginTransaction", Selector = "beginTransaction", ReturnType = typeof (int))]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "RequestPrintJobStatus", Selector = "requestPrintJobStatus:", ReturnType = typeof (int), ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "AddTextAlign", Selector = "addTextAlign:", ReturnType = typeof (int), ParameterType = new Type [] { typeof (int) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "AddLineSpace", Selector = "addLineSpace:", ReturnType = typeof (int), ParameterType = new Type [] { typeof (nint) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "AddTextRotate", Selector = "addTextRotate:", ReturnType = typeof (int), ParameterType = new Type [] { typeof (int) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "AddText", Selector = "addText:", ReturnType = typeof (int), ParameterType = new Type [] { typeof (string) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "AddTextLang", Selector = "addTextLang:", ReturnType = typeof (int), ParameterType = new Type [] { typeof (int) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "AddTextFont", Selector = "addTextFont:", ReturnType = typeof (int), ParameterType = new Type [] { typeof (int) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "AddTextSmooth", Selector = "addTextSmooth:", ReturnType = typeof (int), ParameterType = new Type [] { typeof (int) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "AddTextSize", Selector = "addTextSize:height:", ReturnType = typeof (int), ParameterType = new Type [] { typeof (nint), typeof (nint) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "AddTextStyle", Selector = "addTextStyle:ul:em:color:", ReturnType = typeof (int), ParameterType = new Type [] { typeof (int), typeof (int), typeof (int), typeof (int) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "AddHPosition", Selector = "addHPosition:", ReturnType = typeof (int), ParameterType = new Type [] { typeof (nint) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "AddFeedUnit", Selector = "addFeedUnit:", ReturnType = typeof (int), ParameterType = new Type [] { typeof (nint) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "AddFeedLine", Selector = "addFeedLine:", ReturnType = typeof (int), ParameterType = new Type [] { typeof (nint) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "AddImage", Selector = "addImage:x:y:width:height:color:mode:halftone:brightness:compress:", ReturnType = typeof (int), ParameterType = new Type [] { typeof (UIImage), typeof (nint), typeof (nint), typeof (nint), typeof (nint), typeof (int), typeof (int), typeof (int), typeof (double), typeof (int) }, ParameterByRef = new bool [] { false, false, false, false, false, false, false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "AddLogo", Selector = "addLogo:key2:", ReturnType = typeof (int), ParameterType = new Type [] { typeof (nint), typeof (nint) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "AddBarcode", Selector = "addBarcode:type:hri:font:width:height:", ReturnType = typeof (int), ParameterType = new Type [] { typeof (string), typeof (int), typeof (int), typeof (int), typeof (nint), typeof (nint) }, ParameterByRef = new bool [] { false, false, false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "AddSymbol", Selector = "addSymbol:type:level:width:height:size:", ReturnType = typeof (int), ParameterType = new Type [] { typeof (string), typeof (int), typeof (int), typeof (nint), typeof (nint), typeof (nint) }, ParameterByRef = new bool [] { false, false, false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "AddHLine", Selector = "addHLine:x2:style:", ReturnType = typeof (int), ParameterType = new Type [] { typeof (nint), typeof (nint), typeof (int) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "AddVLineBegin", Selector = "addVLineBegin:style:lineId:", ReturnType = typeof (int), ParameterType = new Type [] { typeof (nint), typeof (int), typeof (int) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "AddVLineEnd", Selector = "addVLineEnd:", ReturnType = typeof (int), ParameterType = new Type [] { typeof (int) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "AddPageArea", Selector = "addPageArea:y:width:height:", ReturnType = typeof (int), ParameterType = new Type [] { typeof (nint), typeof (nint), typeof (nint), typeof (nint) }, ParameterByRef = new bool [] { false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "AddPageDirection", Selector = "addPageDirection:", ReturnType = typeof (int), ParameterType = new Type [] { typeof (int) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "AddPagePosition", Selector = "addPagePosition:y:", ReturnType = typeof (int), ParameterType = new Type [] { typeof (nint), typeof (nint) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "AddPageLine", Selector = "addPageLine:y1:x2:y2:style:", ReturnType = typeof (int), ParameterType = new Type [] { typeof (nint), typeof (nint), typeof (nint), typeof (nint), typeof (int) }, ParameterByRef = new bool [] { false, false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "AddPageRectangle", Selector = "addPageRectangle:y1:x2:y2:style:", ReturnType = typeof (int), ParameterType = new Type [] { typeof (nint), typeof (nint), typeof (nint), typeof (nint), typeof (int) }, ParameterByRef = new bool [] { false, false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "AddCut", Selector = "addCut:", ReturnType = typeof (int), ParameterType = new Type [] { typeof (int) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "AddPulse", Selector = "addPulse:time:", ReturnType = typeof (int), ParameterType = new Type [] { typeof (int), typeof (int) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "AddSound", Selector = "addSound:repeat:cycle:", ReturnType = typeof (int), ParameterType = new Type [] { typeof (int), typeof (nint), typeof (nint) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "AddFeedPosition", Selector = "addFeedPosition:", ReturnType = typeof (int), ParameterType = new Type [] { typeof (int) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "AddLayout", Selector = "addLayout:width:height:marginTop:marginBottom:offsetCut:offsetLabel:", ReturnType = typeof (int), ParameterType = new Type [] { typeof (int), typeof (nint), typeof (nint), typeof (nint), typeof (nint), typeof (nint), typeof (nint) }, ParameterByRef = new bool [] { false, false, false, false, false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "AddCommand", Selector = "addCommand:", ReturnType = typeof (int), ParameterType = new Type [] { typeof (NSData) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ForceRecover", Selector = "forceRecover:", ReturnType = typeof (int), ParameterType = new Type [] { typeof (nint) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ForcePulse", Selector = "forcePulse:pulseTime:timeout:", ReturnType = typeof (int), ParameterType = new Type [] { typeof (int), typeof (int), typeof (nint) }, ParameterByRef = new bool [] { false, false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ForceStopSound", Selector = "forceStopSound:", ReturnType = typeof (int), ParameterType = new Type [] { typeof (nint) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ForceCommand", Selector = "forceCommand:timeout:", ReturnType = typeof (int), ParameterType = new Type [] { typeof (NSData), typeof (nint) }, ParameterByRef = new bool [] { false, false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "ForceReset", Selector = "forceReset:", ReturnType = typeof (int), ParameterType = new Type [] { typeof (nint) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SetStatusChangeEventDelegate", Selector = "setStatusChangeEventDelegate:", ParameterType = new Type [] { typeof (epsonlib.Epos2PtrStatusChangeDelegate) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SetReceiveEventDelegate", Selector = "setReceiveEventDelegate:", ParameterType = new Type [] { typeof (epsonlib.Epos2PtrReceiveDelegate) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SetInterval", Selector = "setInterval:", ReturnType = typeof (int), ParameterType = new Type [] { typeof (nint) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = false, IsStatic = false, Name = "SetConnectionEventDelegate", Selector = "setConnectionEventDelegate:", ParameterType = new Type [] { typeof (epsonlib.Epos2ConnectionDelegate) }, ParameterByRef = new bool [] { false })]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "Disconnect", Selector = "disconnect", PropertyType = typeof (int), GetterSelector = "disconnect", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "StartMonitor", Selector = "startMonitor", PropertyType = typeof (int), GetterSelector = "startMonitor", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "StopMonitor", Selector = "stopMonitor", PropertyType = typeof (int), GetterSelector = "stopMonitor", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "EndTransaction", Selector = "endTransaction", PropertyType = typeof (int), GetterSelector = "endTransaction", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "ClearCommandBuffer", Selector = "clearCommandBuffer", PropertyType = typeof (int), GetterSelector = "clearCommandBuffer", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "AddPageBegin", Selector = "addPageBegin", PropertyType = typeof (int), GetterSelector = "addPageBegin", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "AddPageEnd", Selector = "addPageEnd", PropertyType = typeof (int), GetterSelector = "addPageEnd", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "Interval", Selector = "getInterval", PropertyType = typeof (nint), GetterSelector = "getInterval", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "Admin", Selector = "getAdmin", PropertyType = typeof (string), GetterSelector = "getAdmin", ArgumentSemantic = ArgumentSemantic.None)]
	[ProtocolMember (IsRequired = false, IsProperty = true, IsStatic = false, Name = "Location", Selector = "getLocation", PropertyType = typeof (string), GetterSelector = "getLocation", ArgumentSemantic = ArgumentSemantic.None)]
	public interface IEpos2Printer : INativeObject, IDisposable
	{
	}
	
	public static partial class Epos2Printer_Extensions {
		[CompilerGenerated]
		public static void Dealloc (this IEpos2Printer This)
		{
			global::ApiDefinition.Messaging.void_objc_msgSend (This.Handle, Selector.GetHandle ("dealloc"));
		}
		
		[CompilerGenerated]
		public static int Connect (this IEpos2Printer This, string target, global::System.nint timeout)
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
		public static Epos2PrinterStatusInfo getStatus (this IEpos2Printer This)
		{
			return  Runtime.GetNSObject<Epos2PrinterStatusInfo> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("getStatus")));
		}
		
		[CompilerGenerated]
		public static int SendData (this IEpos2Printer This, global::System.nint timeout)
		{
			return global::ApiDefinition.Messaging.int_objc_msgSend_nint (This.Handle, Selector.GetHandle ("sendData:"), timeout);
		}
		
		[CompilerGenerated]
		public static int BeginTransaction (this IEpos2Printer This)
		{
			return global::ApiDefinition.Messaging.int_objc_msgSend (This.Handle, Selector.GetHandle ("beginTransaction"));
		}
		
		[CompilerGenerated]
		public static int RequestPrintJobStatus (this IEpos2Printer This, string printJobId)
		{
			if (printJobId == null)
				throw new ArgumentNullException ("printJobId");
			var nsprintJobId = NSString.CreateNative (printJobId);
			
			int ret;
			ret = global::ApiDefinition.Messaging.int_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("requestPrintJobStatus:"), nsprintJobId);
			NSString.ReleaseNative (nsprintJobId);
			
			return ret;
		}
		
		[CompilerGenerated]
		public static int AddTextAlign (this IEpos2Printer This, int align)
		{
			return global::ApiDefinition.Messaging.int_objc_msgSend_int (This.Handle, Selector.GetHandle ("addTextAlign:"), align);
		}
		
		[CompilerGenerated]
		public static int AddLineSpace (this IEpos2Printer This, global::System.nint linespc)
		{
			return global::ApiDefinition.Messaging.int_objc_msgSend_nint (This.Handle, Selector.GetHandle ("addLineSpace:"), linespc);
		}
		
		[CompilerGenerated]
		public static int AddTextRotate (this IEpos2Printer This, int rotate)
		{
			return global::ApiDefinition.Messaging.int_objc_msgSend_int (This.Handle, Selector.GetHandle ("addTextRotate:"), rotate);
		}
		
		[CompilerGenerated]
		public static int AddText (this IEpos2Printer This, string data)
		{
			if (data == null)
				throw new ArgumentNullException ("data");
			var nsdata = NSString.CreateNative (data);
			
			int ret;
			ret = global::ApiDefinition.Messaging.int_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("addText:"), nsdata);
			NSString.ReleaseNative (nsdata);
			
			return ret;
		}
		
		[CompilerGenerated]
		public static int AddTextLang (this IEpos2Printer This, int lang)
		{
			return global::ApiDefinition.Messaging.int_objc_msgSend_int (This.Handle, Selector.GetHandle ("addTextLang:"), lang);
		}
		
		[CompilerGenerated]
		public static int AddTextFont (this IEpos2Printer This, int font)
		{
			return global::ApiDefinition.Messaging.int_objc_msgSend_int (This.Handle, Selector.GetHandle ("addTextFont:"), font);
		}
		
		[CompilerGenerated]
		public static int AddTextSmooth (this IEpos2Printer This, int smooth)
		{
			return global::ApiDefinition.Messaging.int_objc_msgSend_int (This.Handle, Selector.GetHandle ("addTextSmooth:"), smooth);
		}
		
		[CompilerGenerated]
		public static int AddTextSize (this IEpos2Printer This, global::System.nint width, global::System.nint height)
		{
			return global::ApiDefinition.Messaging.int_objc_msgSend_nint_nint (This.Handle, Selector.GetHandle ("addTextSize:height:"), width, height);
		}
		
		[CompilerGenerated]
		public static int AddTextStyle (this IEpos2Printer This, int reverse, int ul, int em, int color)
		{
			return global::ApiDefinition.Messaging.int_objc_msgSend_int_int_int_int (This.Handle, Selector.GetHandle ("addTextStyle:ul:em:color:"), reverse, ul, em, color);
		}
		
		[CompilerGenerated]
		public static int AddHPosition (this IEpos2Printer This, global::System.nint x)
		{
			return global::ApiDefinition.Messaging.int_objc_msgSend_nint (This.Handle, Selector.GetHandle ("addHPosition:"), x);
		}
		
		[CompilerGenerated]
		public static int AddFeedUnit (this IEpos2Printer This, global::System.nint unit)
		{
			return global::ApiDefinition.Messaging.int_objc_msgSend_nint (This.Handle, Selector.GetHandle ("addFeedUnit:"), unit);
		}
		
		[CompilerGenerated]
		public static int AddFeedLine (this IEpos2Printer This, global::System.nint line)
		{
			return global::ApiDefinition.Messaging.int_objc_msgSend_nint (This.Handle, Selector.GetHandle ("addFeedLine:"), line);
		}
		
		[CompilerGenerated]
		public static int AddImage (this IEpos2Printer This, global::UIKit.UIImage data, global::System.nint x, global::System.nint y, global::System.nint width, global::System.nint height, int color, int mode, int halftone, global::System.Double brightness, int compress)
		{
			if (data == null)
				throw new ArgumentNullException ("data");
			return global::ApiDefinition.Messaging.int_objc_msgSend_IntPtr_nint_nint_nint_nint_int_int_int_Double_int (This.Handle, Selector.GetHandle ("addImage:x:y:width:height:color:mode:halftone:brightness:compress:"), data.Handle, x, y, width, height, color, mode, halftone, brightness, compress);
		}
		
		[CompilerGenerated]
		public static int AddLogo (this IEpos2Printer This, global::System.nint key1, global::System.nint key2)
		{
			return global::ApiDefinition.Messaging.int_objc_msgSend_nint_nint (This.Handle, Selector.GetHandle ("addLogo:key2:"), key1, key2);
		}
		
		[CompilerGenerated]
		public static int AddBarcode (this IEpos2Printer This, string data, int type, int hri, int font, global::System.nint width, global::System.nint height)
		{
			if (data == null)
				throw new ArgumentNullException ("data");
			var nsdata = NSString.CreateNative (data);
			
			int ret;
			ret = global::ApiDefinition.Messaging.int_objc_msgSend_IntPtr_int_int_int_nint_nint (This.Handle, Selector.GetHandle ("addBarcode:type:hri:font:width:height:"), nsdata, type, hri, font, width, height);
			NSString.ReleaseNative (nsdata);
			
			return ret;
		}
		
		[CompilerGenerated]
		public static int AddSymbol (this IEpos2Printer This, string data, int type, int level, global::System.nint width, global::System.nint height, global::System.nint size)
		{
			if (data == null)
				throw new ArgumentNullException ("data");
			var nsdata = NSString.CreateNative (data);
			
			int ret;
			ret = global::ApiDefinition.Messaging.int_objc_msgSend_IntPtr_int_int_nint_nint_nint (This.Handle, Selector.GetHandle ("addSymbol:type:level:width:height:size:"), nsdata, type, level, width, height, size);
			NSString.ReleaseNative (nsdata);
			
			return ret;
		}
		
		[CompilerGenerated]
		public static int AddHLine (this IEpos2Printer This, global::System.nint x1, global::System.nint x2, int style)
		{
			return global::ApiDefinition.Messaging.int_objc_msgSend_nint_nint_int (This.Handle, Selector.GetHandle ("addHLine:x2:style:"), x1, x2, style);
		}
		
		[CompilerGenerated]
		public static int AddVLineBegin (this IEpos2Printer This, global::System.nint x, int style, int lineId)
		{
			return global::ApiDefinition.Messaging.int_objc_msgSend_nint_int_int (This.Handle, Selector.GetHandle ("addVLineBegin:style:lineId:"), x, style, lineId);
		}
		
		[CompilerGenerated]
		public static int AddVLineEnd (this IEpos2Printer This, int lineId)
		{
			return global::ApiDefinition.Messaging.int_objc_msgSend_int (This.Handle, Selector.GetHandle ("addVLineEnd:"), lineId);
		}
		
		[CompilerGenerated]
		public static int AddPageArea (this IEpos2Printer This, global::System.nint x, global::System.nint y, global::System.nint width, global::System.nint height)
		{
			return global::ApiDefinition.Messaging.int_objc_msgSend_nint_nint_nint_nint (This.Handle, Selector.GetHandle ("addPageArea:y:width:height:"), x, y, width, height);
		}
		
		[CompilerGenerated]
		public static int AddPageDirection (this IEpos2Printer This, int direction)
		{
			return global::ApiDefinition.Messaging.int_objc_msgSend_int (This.Handle, Selector.GetHandle ("addPageDirection:"), direction);
		}
		
		[CompilerGenerated]
		public static int AddPagePosition (this IEpos2Printer This, global::System.nint x, global::System.nint y)
		{
			return global::ApiDefinition.Messaging.int_objc_msgSend_nint_nint (This.Handle, Selector.GetHandle ("addPagePosition:y:"), x, y);
		}
		
		[CompilerGenerated]
		public static int AddPageLine (this IEpos2Printer This, global::System.nint x1, global::System.nint y1, global::System.nint x2, global::System.nint y2, int style)
		{
			return global::ApiDefinition.Messaging.int_objc_msgSend_nint_nint_nint_nint_int (This.Handle, Selector.GetHandle ("addPageLine:y1:x2:y2:style:"), x1, y1, x2, y2, style);
		}
		
		[CompilerGenerated]
		public static int AddPageRectangle (this IEpos2Printer This, global::System.nint x1, global::System.nint y1, global::System.nint x2, global::System.nint y2, int style)
		{
			return global::ApiDefinition.Messaging.int_objc_msgSend_nint_nint_nint_nint_int (This.Handle, Selector.GetHandle ("addPageRectangle:y1:x2:y2:style:"), x1, y1, x2, y2, style);
		}
		
		[CompilerGenerated]
		public static int AddCut (this IEpos2Printer This, int type)
		{
			return global::ApiDefinition.Messaging.int_objc_msgSend_int (This.Handle, Selector.GetHandle ("addCut:"), type);
		}
		
		[CompilerGenerated]
		public static int AddPulse (this IEpos2Printer This, int drawer, int time)
		{
			return global::ApiDefinition.Messaging.int_objc_msgSend_int_int (This.Handle, Selector.GetHandle ("addPulse:time:"), drawer, time);
		}
		
		[CompilerGenerated]
		public static int AddSound (this IEpos2Printer This, int pattern, global::System.nint repeat, global::System.nint cycle)
		{
			return global::ApiDefinition.Messaging.int_objc_msgSend_int_nint_nint (This.Handle, Selector.GetHandle ("addSound:repeat:cycle:"), pattern, repeat, cycle);
		}
		
		[CompilerGenerated]
		public static int AddFeedPosition (this IEpos2Printer This, int position)
		{
			return global::ApiDefinition.Messaging.int_objc_msgSend_int (This.Handle, Selector.GetHandle ("addFeedPosition:"), position);
		}
		
		[CompilerGenerated]
		public static int AddLayout (this IEpos2Printer This, int type, global::System.nint width, global::System.nint height, global::System.nint marginTop, global::System.nint marginBottom, global::System.nint offsetCut, global::System.nint offsetLabel)
		{
			return global::ApiDefinition.Messaging.int_objc_msgSend_int_nint_nint_nint_nint_nint_nint (This.Handle, Selector.GetHandle ("addLayout:width:height:marginTop:marginBottom:offsetCut:offsetLabel:"), type, width, height, marginTop, marginBottom, offsetCut, offsetLabel);
		}
		
		[CompilerGenerated]
		public static int AddCommand (this IEpos2Printer This, NSData data)
		{
			if (data == null)
				throw new ArgumentNullException ("data");
			return global::ApiDefinition.Messaging.int_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("addCommand:"), data.Handle);
		}
		
		[CompilerGenerated]
		public static int ForceRecover (this IEpos2Printer This, global::System.nint timeout)
		{
			return global::ApiDefinition.Messaging.int_objc_msgSend_nint (This.Handle, Selector.GetHandle ("forceRecover:"), timeout);
		}
		
		[CompilerGenerated]
		public static int ForcePulse (this IEpos2Printer This, int drawer, int time, global::System.nint timeout)
		{
			return global::ApiDefinition.Messaging.int_objc_msgSend_int_int_nint (This.Handle, Selector.GetHandle ("forcePulse:pulseTime:timeout:"), drawer, time, timeout);
		}
		
		[CompilerGenerated]
		public static int ForceStopSound (this IEpos2Printer This, global::System.nint timeout)
		{
			return global::ApiDefinition.Messaging.int_objc_msgSend_nint (This.Handle, Selector.GetHandle ("forceStopSound:"), timeout);
		}
		
		[CompilerGenerated]
		public static int ForceCommand (this IEpos2Printer This, NSData data, global::System.nint timeout)
		{
			if (data == null)
				throw new ArgumentNullException ("data");
			return global::ApiDefinition.Messaging.int_objc_msgSend_IntPtr_nint (This.Handle, Selector.GetHandle ("forceCommand:timeout:"), data.Handle, timeout);
		}
		
		[CompilerGenerated]
		public static int ForceReset (this IEpos2Printer This, global::System.nint timeout)
		{
			return global::ApiDefinition.Messaging.int_objc_msgSend_nint (This.Handle, Selector.GetHandle ("forceReset:"), timeout);
		}
		
		[CompilerGenerated]
		public static void SetStatusChangeEventDelegate (this IEpos2Printer This, Epos2PtrStatusChangeDelegate @delegate)
		{
			if (@delegate == null)
				throw new ArgumentNullException ("@delegate");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setStatusChangeEventDelegate:"), @delegate.Handle);
		}
		
		[CompilerGenerated]
		public static void SetReceiveEventDelegate (this IEpos2Printer This, Epos2PtrReceiveDelegate @delegate)
		{
			if (@delegate == null)
				throw new ArgumentNullException ("@delegate");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setReceiveEventDelegate:"), @delegate.Handle);
		}
		
		[CompilerGenerated]
		public static int SetInterval (this IEpos2Printer This, global::System.nint interval)
		{
			return global::ApiDefinition.Messaging.int_objc_msgSend_nint (This.Handle, Selector.GetHandle ("setInterval:"), interval);
		}
		
		[CompilerGenerated]
		public static void SetConnectionEventDelegate (this IEpos2Printer This, Epos2ConnectionDelegate @delegate)
		{
			if (@delegate == null)
				throw new ArgumentNullException ("@delegate");
			global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (This.Handle, Selector.GetHandle ("setConnectionEventDelegate:"), @delegate.Handle);
		}
		
		[CompilerGenerated]
		public static int GetDisconnect (this IEpos2Printer This)
		{
			return global::ApiDefinition.Messaging.int_objc_msgSend (This.Handle, Selector.GetHandle ("disconnect"));
		}
		
		[CompilerGenerated]
		public static int GetStartMonitor (this IEpos2Printer This)
		{
			return global::ApiDefinition.Messaging.int_objc_msgSend (This.Handle, Selector.GetHandle ("startMonitor"));
		}
		
		[CompilerGenerated]
		public static int GetStopMonitor (this IEpos2Printer This)
		{
			return global::ApiDefinition.Messaging.int_objc_msgSend (This.Handle, Selector.GetHandle ("stopMonitor"));
		}
		
		[CompilerGenerated]
		public static int GetEndTransaction (this IEpos2Printer This)
		{
			return global::ApiDefinition.Messaging.int_objc_msgSend (This.Handle, Selector.GetHandle ("endTransaction"));
		}
		
		[CompilerGenerated]
		public static int GetClearCommandBuffer (this IEpos2Printer This)
		{
			return global::ApiDefinition.Messaging.int_objc_msgSend (This.Handle, Selector.GetHandle ("clearCommandBuffer"));
		}
		
		[CompilerGenerated]
		public static int GetAddPageBegin (this IEpos2Printer This)
		{
			return global::ApiDefinition.Messaging.int_objc_msgSend (This.Handle, Selector.GetHandle ("addPageBegin"));
		}
		
		[CompilerGenerated]
		public static int GetAddPageEnd (this IEpos2Printer This)
		{
			return global::ApiDefinition.Messaging.int_objc_msgSend (This.Handle, Selector.GetHandle ("addPageEnd"));
		}
		
		[CompilerGenerated]
		public static global::System.nint GetInterval (this IEpos2Printer This)
		{
			return global::ApiDefinition.Messaging.nint_objc_msgSend (This.Handle, Selector.GetHandle ("getInterval"));
		}
		
		[CompilerGenerated]
		public static string GetAdmin (this IEpos2Printer This)
		{
			return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("getAdmin")));
		}
		
		[CompilerGenerated]
		public static string GetLocation (this IEpos2Printer This)
		{
			return NSString.FromHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (This.Handle, Selector.GetHandle ("getLocation")));
		}
		
	}
	
	internal sealed class Epos2PrinterWrapper : BaseWrapper, IEpos2Printer {
		[Preserve (Conditional = true)]
		public Epos2PrinterWrapper (IntPtr handle, bool owns)
			: base (handle, owns)
		{
		}
		
	}
}
namespace epsonlib {
	[Protocol]
	[Register("Epos2Printer", true)]
	public unsafe partial class Epos2Printer : NSObject, IEpos2Printer {
		
		[CompilerGenerated]
		static readonly IntPtr class_ptr = Class.GetHandle ("Epos2Printer");
		
		public override IntPtr ClassHandle { get { return class_ptr; } }
		
		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		[Export ("init")]
		public Epos2Printer () : base (NSObjectFlag.Empty)
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
		protected Epos2Printer (NSObjectFlag t) : base (t)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[CompilerGenerated]
		[EditorBrowsable (EditorBrowsableState.Advanced)]
		protected internal Epos2Printer (IntPtr handle) : base (handle)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
		}

		[Export ("initWithPrinterSeries:lang:")]
		[CompilerGenerated]
		public Epos2Printer (int printerSeries, int lang)
			: base (NSObjectFlag.Empty)
		{
			IsDirectBinding = GetType ().Assembly == global::ApiDefinition.Messaging.this_assembly;
			if (IsDirectBinding) {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSend_int_int (this.Handle, Selector.GetHandle ("initWithPrinterSeries:lang:"), printerSeries, lang), "initWithPrinterSeries:lang:");
			} else {
				InitializeHandle (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper_int_int (this.SuperHandle, Selector.GetHandle ("initWithPrinterSeries:lang:"), printerSeries, lang), "initWithPrinterSeries:lang:");
			}
		}
		
		[Export ("addBarcode:type:hri:font:width:height:")]
		[CompilerGenerated]
		public virtual int AddBarcode (string data, int type, int hri, int font, global::System.nint width, global::System.nint height)
		{
			if (data == null)
				throw new ArgumentNullException ("data");
			var nsdata = NSString.CreateNative (data);
			
			int ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.int_objc_msgSend_IntPtr_int_int_int_nint_nint (this.Handle, Selector.GetHandle ("addBarcode:type:hri:font:width:height:"), nsdata, type, hri, font, width, height);
			} else {
				ret = global::ApiDefinition.Messaging.int_objc_msgSendSuper_IntPtr_int_int_int_nint_nint (this.SuperHandle, Selector.GetHandle ("addBarcode:type:hri:font:width:height:"), nsdata, type, hri, font, width, height);
			}
			NSString.ReleaseNative (nsdata);
			
			return ret;
		}
		
		[Export ("addCommand:")]
		[CompilerGenerated]
		public virtual int AddCommand (NSData data)
		{
			if (data == null)
				throw new ArgumentNullException ("data");
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.int_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("addCommand:"), data.Handle);
			} else {
				return global::ApiDefinition.Messaging.int_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("addCommand:"), data.Handle);
			}
		}
		
		[Export ("addCut:")]
		[CompilerGenerated]
		public virtual int AddCut (int type)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.int_objc_msgSend_int (this.Handle, Selector.GetHandle ("addCut:"), type);
			} else {
				return global::ApiDefinition.Messaging.int_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("addCut:"), type);
			}
		}
		
		[Export ("addFeedLine:")]
		[CompilerGenerated]
		public virtual int AddFeedLine (global::System.nint line)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.int_objc_msgSend_nint (this.Handle, Selector.GetHandle ("addFeedLine:"), line);
			} else {
				return global::ApiDefinition.Messaging.int_objc_msgSendSuper_nint (this.SuperHandle, Selector.GetHandle ("addFeedLine:"), line);
			}
		}
		
		[Export ("addFeedPosition:")]
		[CompilerGenerated]
		public virtual int AddFeedPosition (int position)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.int_objc_msgSend_int (this.Handle, Selector.GetHandle ("addFeedPosition:"), position);
			} else {
				return global::ApiDefinition.Messaging.int_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("addFeedPosition:"), position);
			}
		}
		
		[Export ("addFeedUnit:")]
		[CompilerGenerated]
		public virtual int AddFeedUnit (global::System.nint unit)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.int_objc_msgSend_nint (this.Handle, Selector.GetHandle ("addFeedUnit:"), unit);
			} else {
				return global::ApiDefinition.Messaging.int_objc_msgSendSuper_nint (this.SuperHandle, Selector.GetHandle ("addFeedUnit:"), unit);
			}
		}
		
		[Export ("addHLine:x2:style:")]
		[CompilerGenerated]
		public virtual int AddHLine (global::System.nint x1, global::System.nint x2, int style)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.int_objc_msgSend_nint_nint_int (this.Handle, Selector.GetHandle ("addHLine:x2:style:"), x1, x2, style);
			} else {
				return global::ApiDefinition.Messaging.int_objc_msgSendSuper_nint_nint_int (this.SuperHandle, Selector.GetHandle ("addHLine:x2:style:"), x1, x2, style);
			}
		}
		
		[Export ("addHPosition:")]
		[CompilerGenerated]
		public virtual int AddHPosition (global::System.nint x)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.int_objc_msgSend_nint (this.Handle, Selector.GetHandle ("addHPosition:"), x);
			} else {
				return global::ApiDefinition.Messaging.int_objc_msgSendSuper_nint (this.SuperHandle, Selector.GetHandle ("addHPosition:"), x);
			}
		}
		
		[Export ("addImage:x:y:width:height:color:mode:halftone:brightness:compress:")]
		[CompilerGenerated]
		public virtual int AddImage (global::UIKit.UIImage data, global::System.nint x, global::System.nint y, global::System.nint width, global::System.nint height, int color, int mode, int halftone, global::System.Double brightness, int compress)
		{
			if (data == null)
				throw new ArgumentNullException ("data");
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.int_objc_msgSend_IntPtr_nint_nint_nint_nint_int_int_int_Double_int (this.Handle, Selector.GetHandle ("addImage:x:y:width:height:color:mode:halftone:brightness:compress:"), data.Handle, x, y, width, height, color, mode, halftone, brightness, compress);
			} else {
				return global::ApiDefinition.Messaging.int_objc_msgSendSuper_IntPtr_nint_nint_nint_nint_int_int_int_Double_int (this.SuperHandle, Selector.GetHandle ("addImage:x:y:width:height:color:mode:halftone:brightness:compress:"), data.Handle, x, y, width, height, color, mode, halftone, brightness, compress);
			}
		}
		
		[Export ("addLayout:width:height:marginTop:marginBottom:offsetCut:offsetLabel:")]
		[CompilerGenerated]
		public virtual int AddLayout (int type, global::System.nint width, global::System.nint height, global::System.nint marginTop, global::System.nint marginBottom, global::System.nint offsetCut, global::System.nint offsetLabel)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.int_objc_msgSend_int_nint_nint_nint_nint_nint_nint (this.Handle, Selector.GetHandle ("addLayout:width:height:marginTop:marginBottom:offsetCut:offsetLabel:"), type, width, height, marginTop, marginBottom, offsetCut, offsetLabel);
			} else {
				return global::ApiDefinition.Messaging.int_objc_msgSendSuper_int_nint_nint_nint_nint_nint_nint (this.SuperHandle, Selector.GetHandle ("addLayout:width:height:marginTop:marginBottom:offsetCut:offsetLabel:"), type, width, height, marginTop, marginBottom, offsetCut, offsetLabel);
			}
		}
		
		[Export ("addLineSpace:")]
		[CompilerGenerated]
		public virtual int AddLineSpace (global::System.nint linespc)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.int_objc_msgSend_nint (this.Handle, Selector.GetHandle ("addLineSpace:"), linespc);
			} else {
				return global::ApiDefinition.Messaging.int_objc_msgSendSuper_nint (this.SuperHandle, Selector.GetHandle ("addLineSpace:"), linespc);
			}
		}
		
		[Export ("addLogo:key2:")]
		[CompilerGenerated]
		public virtual int AddLogo (global::System.nint key1, global::System.nint key2)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.int_objc_msgSend_nint_nint (this.Handle, Selector.GetHandle ("addLogo:key2:"), key1, key2);
			} else {
				return global::ApiDefinition.Messaging.int_objc_msgSendSuper_nint_nint (this.SuperHandle, Selector.GetHandle ("addLogo:key2:"), key1, key2);
			}
		}
		
		[Export ("addPageArea:y:width:height:")]
		[CompilerGenerated]
		public virtual int AddPageArea (global::System.nint x, global::System.nint y, global::System.nint width, global::System.nint height)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.int_objc_msgSend_nint_nint_nint_nint (this.Handle, Selector.GetHandle ("addPageArea:y:width:height:"), x, y, width, height);
			} else {
				return global::ApiDefinition.Messaging.int_objc_msgSendSuper_nint_nint_nint_nint (this.SuperHandle, Selector.GetHandle ("addPageArea:y:width:height:"), x, y, width, height);
			}
		}
		
		[Export ("addPageDirection:")]
		[CompilerGenerated]
		public virtual int AddPageDirection (int direction)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.int_objc_msgSend_int (this.Handle, Selector.GetHandle ("addPageDirection:"), direction);
			} else {
				return global::ApiDefinition.Messaging.int_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("addPageDirection:"), direction);
			}
		}
		
		[Export ("addPageLine:y1:x2:y2:style:")]
		[CompilerGenerated]
		public virtual int AddPageLine (global::System.nint x1, global::System.nint y1, global::System.nint x2, global::System.nint y2, int style)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.int_objc_msgSend_nint_nint_nint_nint_int (this.Handle, Selector.GetHandle ("addPageLine:y1:x2:y2:style:"), x1, y1, x2, y2, style);
			} else {
				return global::ApiDefinition.Messaging.int_objc_msgSendSuper_nint_nint_nint_nint_int (this.SuperHandle, Selector.GetHandle ("addPageLine:y1:x2:y2:style:"), x1, y1, x2, y2, style);
			}
		}
		
		[Export ("addPagePosition:y:")]
		[CompilerGenerated]
		public virtual int AddPagePosition (global::System.nint x, global::System.nint y)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.int_objc_msgSend_nint_nint (this.Handle, Selector.GetHandle ("addPagePosition:y:"), x, y);
			} else {
				return global::ApiDefinition.Messaging.int_objc_msgSendSuper_nint_nint (this.SuperHandle, Selector.GetHandle ("addPagePosition:y:"), x, y);
			}
		}
		
		[Export ("addPageRectangle:y1:x2:y2:style:")]
		[CompilerGenerated]
		public virtual int AddPageRectangle (global::System.nint x1, global::System.nint y1, global::System.nint x2, global::System.nint y2, int style)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.int_objc_msgSend_nint_nint_nint_nint_int (this.Handle, Selector.GetHandle ("addPageRectangle:y1:x2:y2:style:"), x1, y1, x2, y2, style);
			} else {
				return global::ApiDefinition.Messaging.int_objc_msgSendSuper_nint_nint_nint_nint_int (this.SuperHandle, Selector.GetHandle ("addPageRectangle:y1:x2:y2:style:"), x1, y1, x2, y2, style);
			}
		}
		
		[Export ("addPulse:time:")]
		[CompilerGenerated]
		public virtual int AddPulse (int drawer, int time)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.int_objc_msgSend_int_int (this.Handle, Selector.GetHandle ("addPulse:time:"), drawer, time);
			} else {
				return global::ApiDefinition.Messaging.int_objc_msgSendSuper_int_int (this.SuperHandle, Selector.GetHandle ("addPulse:time:"), drawer, time);
			}
		}
		
		[Export ("addSound:repeat:cycle:")]
		[CompilerGenerated]
		public virtual int AddSound (int pattern, global::System.nint repeat, global::System.nint cycle)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.int_objc_msgSend_int_nint_nint (this.Handle, Selector.GetHandle ("addSound:repeat:cycle:"), pattern, repeat, cycle);
			} else {
				return global::ApiDefinition.Messaging.int_objc_msgSendSuper_int_nint_nint (this.SuperHandle, Selector.GetHandle ("addSound:repeat:cycle:"), pattern, repeat, cycle);
			}
		}
		
		[Export ("addSymbol:type:level:width:height:size:")]
		[CompilerGenerated]
		public virtual int AddSymbol (string data, int type, int level, global::System.nint width, global::System.nint height, global::System.nint size)
		{
			if (data == null)
				throw new ArgumentNullException ("data");
			var nsdata = NSString.CreateNative (data);
			
			int ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.int_objc_msgSend_IntPtr_int_int_nint_nint_nint (this.Handle, Selector.GetHandle ("addSymbol:type:level:width:height:size:"), nsdata, type, level, width, height, size);
			} else {
				ret = global::ApiDefinition.Messaging.int_objc_msgSendSuper_IntPtr_int_int_nint_nint_nint (this.SuperHandle, Selector.GetHandle ("addSymbol:type:level:width:height:size:"), nsdata, type, level, width, height, size);
			}
			NSString.ReleaseNative (nsdata);
			
			return ret;
		}
		
		[Export ("addText:")]
		[CompilerGenerated]
		public virtual int AddText (string data)
		{
			if (data == null)
				throw new ArgumentNullException ("data");
			var nsdata = NSString.CreateNative (data);
			
			int ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.int_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("addText:"), nsdata);
			} else {
				ret = global::ApiDefinition.Messaging.int_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("addText:"), nsdata);
			}
			NSString.ReleaseNative (nsdata);
			
			return ret;
		}
		
		[Export ("addTextAlign:")]
		[CompilerGenerated]
		public virtual int AddTextAlign (int align)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.int_objc_msgSend_int (this.Handle, Selector.GetHandle ("addTextAlign:"), align);
			} else {
				return global::ApiDefinition.Messaging.int_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("addTextAlign:"), align);
			}
		}
		
		[Export ("addTextFont:")]
		[CompilerGenerated]
		public virtual int AddTextFont (int font)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.int_objc_msgSend_int (this.Handle, Selector.GetHandle ("addTextFont:"), font);
			} else {
				return global::ApiDefinition.Messaging.int_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("addTextFont:"), font);
			}
		}
		
		[Export ("addTextLang:")]
		[CompilerGenerated]
		public virtual int AddTextLang (int lang)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.int_objc_msgSend_int (this.Handle, Selector.GetHandle ("addTextLang:"), lang);
			} else {
				return global::ApiDefinition.Messaging.int_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("addTextLang:"), lang);
			}
		}
		
		[Export ("addTextRotate:")]
		[CompilerGenerated]
		public virtual int AddTextRotate (int rotate)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.int_objc_msgSend_int (this.Handle, Selector.GetHandle ("addTextRotate:"), rotate);
			} else {
				return global::ApiDefinition.Messaging.int_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("addTextRotate:"), rotate);
			}
		}
		
		[Export ("addTextSize:height:")]
		[CompilerGenerated]
		public virtual int AddTextSize (global::System.nint width, global::System.nint height)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.int_objc_msgSend_nint_nint (this.Handle, Selector.GetHandle ("addTextSize:height:"), width, height);
			} else {
				return global::ApiDefinition.Messaging.int_objc_msgSendSuper_nint_nint (this.SuperHandle, Selector.GetHandle ("addTextSize:height:"), width, height);
			}
		}
		
		[Export ("addTextSmooth:")]
		[CompilerGenerated]
		public virtual int AddTextSmooth (int smooth)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.int_objc_msgSend_int (this.Handle, Selector.GetHandle ("addTextSmooth:"), smooth);
			} else {
				return global::ApiDefinition.Messaging.int_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("addTextSmooth:"), smooth);
			}
		}
		
		[Export ("addTextStyle:ul:em:color:")]
		[CompilerGenerated]
		public virtual int AddTextStyle (int reverse, int ul, int em, int color)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.int_objc_msgSend_int_int_int_int (this.Handle, Selector.GetHandle ("addTextStyle:ul:em:color:"), reverse, ul, em, color);
			} else {
				return global::ApiDefinition.Messaging.int_objc_msgSendSuper_int_int_int_int (this.SuperHandle, Selector.GetHandle ("addTextStyle:ul:em:color:"), reverse, ul, em, color);
			}
		}
		
		[Export ("addVLineBegin:style:lineId:")]
		[CompilerGenerated]
		public virtual int AddVLineBegin (global::System.nint x, int style, int lineId)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.int_objc_msgSend_nint_int_int (this.Handle, Selector.GetHandle ("addVLineBegin:style:lineId:"), x, style, lineId);
			} else {
				return global::ApiDefinition.Messaging.int_objc_msgSendSuper_nint_int_int (this.SuperHandle, Selector.GetHandle ("addVLineBegin:style:lineId:"), x, style, lineId);
			}
		}
		
		[Export ("addVLineEnd:")]
		[CompilerGenerated]
		public virtual int AddVLineEnd (int lineId)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.int_objc_msgSend_int (this.Handle, Selector.GetHandle ("addVLineEnd:"), lineId);
			} else {
				return global::ApiDefinition.Messaging.int_objc_msgSendSuper_int (this.SuperHandle, Selector.GetHandle ("addVLineEnd:"), lineId);
			}
		}
		
		[Export ("beginTransaction")]
		[CompilerGenerated]
		public virtual int BeginTransaction ()
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("beginTransaction"));
			} else {
				return global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("beginTransaction"));
			}
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
		
		[Export ("forceCommand:timeout:")]
		[CompilerGenerated]
		public virtual int ForceCommand (NSData data, global::System.nint timeout)
		{
			if (data == null)
				throw new ArgumentNullException ("data");
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.int_objc_msgSend_IntPtr_nint (this.Handle, Selector.GetHandle ("forceCommand:timeout:"), data.Handle, timeout);
			} else {
				return global::ApiDefinition.Messaging.int_objc_msgSendSuper_IntPtr_nint (this.SuperHandle, Selector.GetHandle ("forceCommand:timeout:"), data.Handle, timeout);
			}
		}
		
		[Export ("forcePulse:pulseTime:timeout:")]
		[CompilerGenerated]
		public virtual int ForcePulse (int drawer, int time, global::System.nint timeout)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.int_objc_msgSend_int_int_nint (this.Handle, Selector.GetHandle ("forcePulse:pulseTime:timeout:"), drawer, time, timeout);
			} else {
				return global::ApiDefinition.Messaging.int_objc_msgSendSuper_int_int_nint (this.SuperHandle, Selector.GetHandle ("forcePulse:pulseTime:timeout:"), drawer, time, timeout);
			}
		}
		
		[Export ("forceRecover:")]
		[CompilerGenerated]
		public virtual int ForceRecover (global::System.nint timeout)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.int_objc_msgSend_nint (this.Handle, Selector.GetHandle ("forceRecover:"), timeout);
			} else {
				return global::ApiDefinition.Messaging.int_objc_msgSendSuper_nint (this.SuperHandle, Selector.GetHandle ("forceRecover:"), timeout);
			}
		}
		
		[Export ("forceReset:")]
		[CompilerGenerated]
		public virtual int ForceReset (global::System.nint timeout)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.int_objc_msgSend_nint (this.Handle, Selector.GetHandle ("forceReset:"), timeout);
			} else {
				return global::ApiDefinition.Messaging.int_objc_msgSendSuper_nint (this.SuperHandle, Selector.GetHandle ("forceReset:"), timeout);
			}
		}
		
		[Export ("forceStopSound:")]
		[CompilerGenerated]
		public virtual int ForceStopSound (global::System.nint timeout)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.int_objc_msgSend_nint (this.Handle, Selector.GetHandle ("forceStopSound:"), timeout);
			} else {
				return global::ApiDefinition.Messaging.int_objc_msgSendSuper_nint (this.SuperHandle, Selector.GetHandle ("forceStopSound:"), timeout);
			}
		}
		
		[Export ("requestPrintJobStatus:")]
		[CompilerGenerated]
		public virtual int RequestPrintJobStatus (string printJobId)
		{
			if (printJobId == null)
				throw new ArgumentNullException ("printJobId");
			var nsprintJobId = NSString.CreateNative (printJobId);
			
			int ret;
			if (IsDirectBinding) {
				ret = global::ApiDefinition.Messaging.int_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("requestPrintJobStatus:"), nsprintJobId);
			} else {
				ret = global::ApiDefinition.Messaging.int_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("requestPrintJobStatus:"), nsprintJobId);
			}
			NSString.ReleaseNative (nsprintJobId);
			
			return ret;
		}
		
		[Export ("sendData:")]
		[CompilerGenerated]
		public virtual int SendData (global::System.nint timeout)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.int_objc_msgSend_nint (this.Handle, Selector.GetHandle ("sendData:"), timeout);
			} else {
				return global::ApiDefinition.Messaging.int_objc_msgSendSuper_nint (this.SuperHandle, Selector.GetHandle ("sendData:"), timeout);
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
		
		[Export ("setInterval:")]
		[CompilerGenerated]
		public virtual int SetInterval (global::System.nint interval)
		{
			if (IsDirectBinding) {
				return global::ApiDefinition.Messaging.int_objc_msgSend_nint (this.Handle, Selector.GetHandle ("setInterval:"), interval);
			} else {
				return global::ApiDefinition.Messaging.int_objc_msgSendSuper_nint (this.SuperHandle, Selector.GetHandle ("setInterval:"), interval);
			}
		}
		
		[Export ("setReceiveEventDelegate:")]
		[CompilerGenerated]
		public virtual void SetReceiveEventDelegate (Epos2PtrReceiveDelegate @delegate)
		{
			if (@delegate == null)
				throw new ArgumentNullException ("@delegate");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setReceiveEventDelegate:"), @delegate.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setReceiveEventDelegate:"), @delegate.Handle);
			}
		}
		
		[Export ("setStatusChangeEventDelegate:")]
		[CompilerGenerated]
		public virtual void SetStatusChangeEventDelegate (Epos2PtrStatusChangeDelegate @delegate)
		{
			if (@delegate == null)
				throw new ArgumentNullException ("@delegate");
			if (IsDirectBinding) {
				global::ApiDefinition.Messaging.void_objc_msgSend_IntPtr (this.Handle, Selector.GetHandle ("setStatusChangeEventDelegate:"), @delegate.Handle);
			} else {
				global::ApiDefinition.Messaging.void_objc_msgSendSuper_IntPtr (this.SuperHandle, Selector.GetHandle ("setStatusChangeEventDelegate:"), @delegate.Handle);
			}
		}
		
		[Export ("getStatus")]
		[CompilerGenerated]
		public virtual Epos2PrinterStatusInfo getStatus ()
		{
			if (IsDirectBinding) {
				return  Runtime.GetNSObject<Epos2PrinterStatusInfo> (global::ApiDefinition.Messaging.IntPtr_objc_msgSend (this.Handle, Selector.GetHandle ("getStatus")));
			} else {
				return  Runtime.GetNSObject<Epos2PrinterStatusInfo> (global::ApiDefinition.Messaging.IntPtr_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getStatus")));
			}
		}
		
		[CompilerGenerated]
		public virtual int AddPageBegin {
			[Export ("addPageBegin")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("addPageBegin"));
				} else {
					return global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("addPageBegin"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual int AddPageEnd {
			[Export ("addPageEnd")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("addPageEnd"));
				} else {
					return global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("addPageEnd"));
				}
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
		public virtual int ClearCommandBuffer {
			[Export ("clearCommandBuffer")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("clearCommandBuffer"));
				} else {
					return global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("clearCommandBuffer"));
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
		public virtual int EndTransaction {
			[Export ("endTransaction")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("endTransaction"));
				} else {
					return global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("endTransaction"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual global::System.nint Interval {
			[Export ("getInterval")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.nint_objc_msgSend (this.Handle, Selector.GetHandle ("getInterval"));
				} else {
					return global::ApiDefinition.Messaging.nint_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("getInterval"));
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
		public virtual int StartMonitor {
			[Export ("startMonitor")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("startMonitor"));
				} else {
					return global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("startMonitor"));
				}
			}
			
		}
		
		[CompilerGenerated]
		public virtual int StopMonitor {
			[Export ("stopMonitor")]
			get {
				if (IsDirectBinding) {
					return global::ApiDefinition.Messaging.int_objc_msgSend (this.Handle, Selector.GetHandle ("stopMonitor"));
				} else {
					return global::ApiDefinition.Messaging.int_objc_msgSendSuper (this.SuperHandle, Selector.GetHandle ("stopMonitor"));
				}
			}
			
		}
		
	} /* class Epos2Printer */
}
