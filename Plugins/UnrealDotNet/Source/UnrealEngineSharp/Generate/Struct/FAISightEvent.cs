// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\Perception\AISense_Sight.h:26

namespace UnrealEngine
{
	public partial class FAISightEvent : NativeStructWrapper
	{
		public FAISightEvent(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FAISightEvent() :
			base(E_CreateStruct_FAISightEvent(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FAISightEvent_Age_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FAISightEvent_Age_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_PROP_FAISightEvent_Observer_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FAISightEvent_Observer_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_PROP_FAISightEvent_SeenActor_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FAISightEvent_SeenActor_SET(IntPtr Ptr, IntPtr Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FAISightEvent();
		
		#endregion
		
		#region Property
		public float Age
		{
			get => E_PROP_FAISightEvent_Age_GET(NativePointer);
			set => E_PROP_FAISightEvent_Age_SET(NativePointer, value);
		}

		public AActor Observer
		{
			get => E_PROP_FAISightEvent_Observer_GET(NativePointer);
			set => E_PROP_FAISightEvent_Observer_SET(NativePointer, value);
		}

		public AActor SeenActor
		{
			get => E_PROP_FAISightEvent_SeenActor_GET(NativePointer);
			set => E_PROP_FAISightEvent_SeenActor_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FAISightEvent self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FAISightEvent(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FAISightEvent(adress, false);
		}}}
