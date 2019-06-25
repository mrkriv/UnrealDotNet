// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\Perception\AISenseConfig_Hearing.h:18

namespace UnrealEngine
{
	public partial class UAISenseConfig_Hearing : UAISenseConfig
	{
		public UAISenseConfig_Hearing(IntPtr adress)
			: base(adress)
		{
		}

		public UAISenseConfig_Hearing(UObject Parent = null, string Name = "AISenseConfig_Hearing")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UAISenseConfig_Hearing(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_UAISenseConfig_Hearing_DetectionByAffiliation_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UAISenseConfig_Hearing_DetectionByAffiliation_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UAISenseConfig_Hearing_HearingRange_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UAISenseConfig_Hearing_HearingRange_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UAISenseConfig_Hearing_LoSHearingRange_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UAISenseConfig_Hearing_LoSHearingRange_SET(IntPtr Ptr, float Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UAISenseConfig_Hearing(IntPtr Parent, string Name);
		
		#endregion
		
		#region Property
		public FAISenseAffiliationFilter DetectionByAffiliation
		{
			get => E_PROP_UAISenseConfig_Hearing_DetectionByAffiliation_GET(NativePointer);
			set => E_PROP_UAISenseConfig_Hearing_DetectionByAffiliation_SET(NativePointer, value);
		}

		public float HearingRange
		{
			get => E_PROP_UAISenseConfig_Hearing_HearingRange_GET(NativePointer);
			set => E_PROP_UAISenseConfig_Hearing_HearingRange_SET(NativePointer, value);
		}

		public float LoSHearingRange
		{
			get => E_PROP_UAISenseConfig_Hearing_LoSHearingRange_GET(NativePointer);
			set => E_PROP_UAISenseConfig_Hearing_LoSHearingRange_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(UAISenseConfig_Hearing self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UAISenseConfig_Hearing(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UAISenseConfig_Hearing>(PtrDesc);
		}}}
