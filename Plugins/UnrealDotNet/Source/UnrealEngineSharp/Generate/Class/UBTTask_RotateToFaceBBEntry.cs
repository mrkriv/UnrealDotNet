// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\BehaviorTree\Tasks\BTTask_RotateToFaceBBEntry.h:17

namespace UnrealEngine
{
	public partial class UBTTask_RotateToFaceBBEntry : UBTTask_BlackboardBase
	{
		public UBTTask_RotateToFaceBBEntry(IntPtr adress)
			: base(adress)
		{
		}

		public UBTTask_RotateToFaceBBEntry(UObject Parent = null, string Name = "BTTask_RotateToFaceBBEntry")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UBTTask_RotateToFaceBBEntry(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UBTTask_RotateToFaceBBEntry(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UBTTask_RotateToFaceBBEntry_CleanUp(IntPtr self, IntPtr aIController, byte nodeMemory);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UBTTask_RotateToFaceBBEntry_GetPrecisionDot(IntPtr self);
		
		#endregion
		
		#region ExternMethods
		protected void CleanUp(AAIController aIController, byte nodeMemory)
			=> E_UBTTask_RotateToFaceBBEntry_CleanUp(this, aIController, nodeMemory);
		
		protected float GetPrecisionDot()
			=> E_UBTTask_RotateToFaceBBEntry_GetPrecisionDot(this);
		
		#endregion
		
		public static implicit operator IntPtr(UBTTask_RotateToFaceBBEntry self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UBTTask_RotateToFaceBBEntry(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UBTTask_RotateToFaceBBEntry>(PtrDesc);
		}}}
