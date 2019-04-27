using System;
using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
    public partial class UInputComponent
    {
        [DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
        private static extern void E_UInputComponent_BindAction(IntPtr Ptr, uint eventId, string actionName, EInputEvent keyEvent);
        
        [DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
        private static extern void E_UInputComponent_BindAxis_Event(IntPtr Ptr, uint eventId, string axisName);

        public void BindAction(string actionName, EInputEvent keyEvent, Action callback)
        {
            var eventId = NativeManager.AddEvent(callback);
            E_UInputComponent_BindAction(this, eventId, actionName, keyEvent);
        }
        
        public void BindAxis(string axisName, Action<float> callback)
        {
            var eventId = NativeManager.AddEvent(callback);
            E_UInputComponent_BindAxis_Event(this, eventId, axisName);
        }
    }
}