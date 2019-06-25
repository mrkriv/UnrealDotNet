// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\Perception\AISense_Team.h:14

namespace UnrealEngine
{
	public partial class FAITeamStimulusEvent : NativeStructWrapper
	{
		public FAITeamStimulusEvent(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FAITeamStimulusEvent() :
			base(E_CreateStruct_FAITeamStimulusEvent(), false)
		{
		}

		public FAITeamStimulusEvent(AActor inBroadcaster, AActor inEnemy, FVector inLastKnowLocation, float eventRange, float passedInfoAge, float inStrength) :
			base(E_CreateStruct_FAITeamStimulusEvent_AActor_AActor_FVector_float_float_float(inBroadcaster, inEnemy, inLastKnowLocation, eventRange, passedInfoAge, inStrength), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_PROP_FAITeamStimulusEvent_Enemy_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FAITeamStimulusEvent_Enemy_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FAITeamStimulusEvent_InformationAge_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FAITeamStimulusEvent_InformationAge_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FAITeamStimulusEvent_LastKnowLocation_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FAITeamStimulusEvent_LastKnowLocation_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FAITeamStimulusEvent_RangeSq_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FAITeamStimulusEvent_RangeSq_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FAITeamStimulusEvent_Strength_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FAITeamStimulusEvent_Strength_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FAITeamStimulusEvent_TeamIdentifier_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FAITeamStimulusEvent_TeamIdentifier_SET(IntPtr Ptr, IntPtr Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FAITeamStimulusEvent();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FAITeamStimulusEvent_AActor_AActor_FVector_float_float_float(IntPtr inBroadcaster, IntPtr inEnemy, IntPtr inLastKnowLocation, float eventRange, float passedInfoAge, float inStrength);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FAITeamStimulusEvent_CacheBroadcastLocation(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FAITeamStimulusEvent_GetBroadcastLocation(IntPtr self);
		
		#endregion
		
		#region Property
		public AActor Enemy
		{
			get => E_PROP_FAITeamStimulusEvent_Enemy_GET(NativePointer);
			set => E_PROP_FAITeamStimulusEvent_Enemy_SET(NativePointer, value);
		}

		public float InformationAge
		{
			get => E_PROP_FAITeamStimulusEvent_InformationAge_GET(NativePointer);
			set => E_PROP_FAITeamStimulusEvent_InformationAge_SET(NativePointer, value);
		}

		public FVector LastKnowLocation
		{
			get => E_PROP_FAITeamStimulusEvent_LastKnowLocation_GET(NativePointer);
			set => E_PROP_FAITeamStimulusEvent_LastKnowLocation_SET(NativePointer, value);
		}

		public float RangeSq
		{
			get => E_PROP_FAITeamStimulusEvent_RangeSq_GET(NativePointer);
			set => E_PROP_FAITeamStimulusEvent_RangeSq_SET(NativePointer, value);
		}

		public float Strength
		{
			get => E_PROP_FAITeamStimulusEvent_Strength_GET(NativePointer);
			set => E_PROP_FAITeamStimulusEvent_Strength_SET(NativePointer, value);
		}

		public FGenericTeamId TeamIdentifier
		{
			get => E_PROP_FAITeamStimulusEvent_TeamIdentifier_GET(NativePointer);
			set => E_PROP_FAITeamStimulusEvent_TeamIdentifier_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		public void CacheBroadcastLocation()
			=> E_FAITeamStimulusEvent_CacheBroadcastLocation(this);
		
		public FVector GetBroadcastLocation()
			=> E_FAITeamStimulusEvent_GetBroadcastLocation(this);
		
		#endregion
		
		public static implicit operator IntPtr(FAITeamStimulusEvent self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FAITeamStimulusEvent(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FAITeamStimulusEvent(adress, false);
		}}}
