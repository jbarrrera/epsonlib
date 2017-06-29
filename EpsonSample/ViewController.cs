using System;

using UIKit;
using epsonlib;
namespace EpsonSample
{
    public partial class ViewController : UIViewController
    {
        RecieveDelegate reciveDelegate;
        
        public ViewController(IntPtr handle) : base(handle)
        {
        }


        public override void ViewDidLoad()
        {
            //ObjCRuntime.Class.ThrowOnInitFailure = false;
            base.ViewDidLoad();
            var printer = new Epos2Printer();

            //var filter = new Epos2FilterOption()
            //{
            //    DeviceType = (int)Epos2DeviceType.Printer,
            //    PortType = (int)Epos2PortType.All,
            //    DeviceModel = (int)Epos2DeviceModel.Epos2ModelAll
            //};
             // Epos2Printer printer;
             // printer = new Epos2Printer(12, 0);
            //if (printer == null)
            //{
            //    throw new NotImplementedException();
            //}
            //reciveDelegate = new RecieveDelegate();
            //reciveDelegate.Code(printer, 0, printer.getStatus(), "2");
            //printer.SetReceiveEventDelegate(reciveDelegate);
            //printer.AddText("Hellowolrlds");
            //printer.Connect("TCP:192.168.100.20", 1000);
            //int a = printer.BeginTransaction();
            ////Epos2PrinterStatusInfo status = ;
            //Epos2PrinterStatusInfo status = printer.getStatus();
            //printer.SendData(1000);
            //Perform any additional setup after loading the view, typically from a nib.
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        partial void UIButton3_TouchUpInside(UIButton sender)
        {
        }

        public class RecieveDelegate : Epos2PtrReceiveDelegate
        {
            public Epos2Printer PrinterObj;
            public int Codex;
            public Epos2PrinterStatusInfo Status;
            public string PrintJobId;
            public override void Code(Epos2Printer printerObj, int code, Epos2PrinterStatusInfo status, string printJobId)
            {
                PrinterObj = printerObj;
                Codex = code;
                Status = status;
                PrintJobId = printJobId;
            }

        }

      

        

    }
}