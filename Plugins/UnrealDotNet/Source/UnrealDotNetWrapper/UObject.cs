using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq.Expressions;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace UnrealDotNetWrapper
{
    public class UObject
    {
        private delegate int testMethod_Delegate(int p);

        private static readonly testMethod_Delegate testMethod_dlg;

        static UObject()
        {
            if (CPPManager.MethodMap == (IntPtr) 0)
            {
                throw new Exception("CPPManager is not binded");
            }

            testMethod_dlg =
                Marshal.GetDelegateForFunctionPointer<testMethod_Delegate>(CPPManager.MethodMap + IntPtr.Size * 2);
        }

        public int testMethod(int p)
        {
            return testMethod_dlg(p);
        }
    }
}