// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\Perception\AISense_Touch.h:13

namespace UnrealEngine
{
	public partial class FAITouchEvent : NativeStructWrapper
	{
		public FAITouchEvent(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FAITouchEvent() :
			base(E_CreateStruct_FAITouchEvent(), false)
		{
		}

		public FAITouchEvent(AActor inTouchReceiver, AActor inOtherActor, FVector eventLocation) :
			base(E_CreateStruct_FAITouchEvent_AActor_AActor_FVector(inTouchReceiver, inOtherActor, eventLocation), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FAITouchEvent_Location_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FAITouchEvent_Location_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_PROP_FAITouchEvent_OtherActor_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FAITouchEvent_OtherActor_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_PROP_FAITouchEvent_TouchReceiver_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FAITouchEvent_TouchReceiver_SET(IntPtr Ptr, IntPtr Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FAITouchEvent();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FAITouchEvent_AActor_AActor_FVector(IntPtr inTouchReceiver, IntPtr inOtherActor, IntPtr eventLocation);
		
		#endregion
		
		#region Property
		public FVector Location
		{
			get => E_PROP_FAITouchEvent_Location_GET(NativePointer);
			set => E_PROP_FAITouchEvent_Location_SET(NativePointer, value);
		}

		public AActor OtherActor
		{
			get => E_PROP_FAITouchEvent_OtherActor_GET(NativePointer);
			set => E_PROP_FAITouchEvent_OtherActor_SET(NativePointer, value);
		}

		public AActor TouchReceiver
		{
			get => E_PROP_FAITouchEvent_TouchReceiver_GET(NativePointer);
			set => E_PROP_FAITouchEvent_TouchReceiver_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FAITouchEvent self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FAITouchEvent(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FAITouchEvent(adress, false);
		}}}
