// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\BehaviorTree\Tasks\BTTask_Wait.h:20

namespace UnrealEngine
{
	public partial class UBTTask_Wait : UBTTaskNode
	{
		public UBTTask_Wait(IntPtr adress)
			: base(adress)
		{
		}

		public UBTTask_Wait(UObject Parent = null, string Name = "BTTask_Wait")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UBTTask_Wait(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UBTTask_Wait_RandomDeviation_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UBTTask_Wait_RandomDeviation_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UBTTask_Wait_WaitTime_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UBTTask_Wait_WaitTime_SET(IntPtr Ptr, float Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UBTTask_Wait(IntPtr Parent, string Name);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// allows adding random time to wait time
		/// </summary>
		public float RandomDeviation
		{
			get => E_PROP_UBTTask_Wait_RandomDeviation_GET(NativePointer);
			set => E_PROP_UBTTask_Wait_RandomDeviation_SET(NativePointer, value);
		}

		
		/// <summary>
		/// wait time in seconds
		/// </summary>
		public float WaitTime
		{
			get => E_PROP_UBTTask_Wait_WaitTime_GET(NativePointer);
			set => E_PROP_UBTTask_Wait_WaitTime_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(UBTTask_Wait self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UBTTask_Wait(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UBTTask_Wait>(PtrDesc);
		}}}
