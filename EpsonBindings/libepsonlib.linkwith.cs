using System;
using ObjCRuntime;

[assembly: LinkWith ("libepsonlib.a", 
    LinkTarget.ArmV7 | LinkTarget.Simulator | LinkTarget.Simulator64 | LinkTarget.ArmV7s, ForceLoad = false, SmartLink = true)]
