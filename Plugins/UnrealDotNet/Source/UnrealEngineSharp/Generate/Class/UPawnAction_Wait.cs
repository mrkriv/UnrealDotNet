// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\Actions\PawnAction_Wait.h:13

namespace UnrealEngine
{
	public partial class UPawnAction_Wait : UPawnAction
	{
		public UPawnAction_Wait(IntPtr adress)
			: base(adress)
		{
		}

		public UPawnAction_Wait(UObject Parent = null, string Name = "PawnAction_Wait")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UPawnAction_Wait(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UPawnAction_Wait_FinishTimeStamp_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UPawnAction_Wait_FinishTimeStamp_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UPawnAction_Wait_TimeToWait_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UPawnAction_Wait_TimeToWait_SET(IntPtr Ptr, float Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UPawnAction_Wait(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_UPawnAction_Wait_CreateAction(IntPtr self, IntPtr world, float inTimeToWait);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPawnAction_Wait_TimerDone(IntPtr self);
		
		#endregion
		
		#region Property
		public float FinishTimeStamp
		{
			get => E_PROP_UPawnAction_Wait_FinishTimeStamp_GET(NativePointer);
			set => E_PROP_UPawnAction_Wait_FinishTimeStamp_SET(NativePointer, value);
		}

		public float TimeToWait
		{
			get => E_PROP_UPawnAction_Wait_TimeToWait_GET(NativePointer);
			set => E_PROP_UPawnAction_Wait_TimeToWait_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// InTimeToWait < 0 (or just FAISystem::InfiniteInterval) will result in waiting forever
		/// </summary>
		public UPawnAction_Wait CreateAction(UWorld world, float inTimeToWait)
			=> E_UPawnAction_Wait_CreateAction(this, world, inTimeToWait);
		
		public void TimerDone()
			=> E_UPawnAction_Wait_TimerDone(this);
		
		#endregion
		
		public static implicit operator IntPtr(UPawnAction_Wait self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UPawnAction_Wait(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UPawnAction_Wait>(PtrDesc);
		}}}
