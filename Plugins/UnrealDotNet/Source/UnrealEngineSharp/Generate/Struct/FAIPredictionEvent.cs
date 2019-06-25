// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\Perception\AISense_Prediction.h:15

namespace UnrealEngine
{
	public partial class FAIPredictionEvent : NativeStructWrapper
	{
		public FAIPredictionEvent(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FAIPredictionEvent() :
			base(E_CreateStruct_FAIPredictionEvent(), false)
		{
		}

		public FAIPredictionEvent(AActor inRequestor, AActor inPredictedActor, float predictionTime) :
			base(E_CreateStruct_FAIPredictionEvent_AActor_AActor_float(inRequestor, inPredictedActor, predictionTime), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_PROP_FAIPredictionEvent_PredictedActor_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FAIPredictionEvent_PredictedActor_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_PROP_FAIPredictionEvent_Requestor_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FAIPredictionEvent_Requestor_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FAIPredictionEvent_TimeToPredict_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FAIPredictionEvent_TimeToPredict_SET(IntPtr Ptr, float Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FAIPredictionEvent();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FAIPredictionEvent_AActor_AActor_float(IntPtr inRequestor, IntPtr inPredictedActor, float predictionTime);
		
		#endregion
		
		#region Property
		public AActor PredictedActor
		{
			get => E_PROP_FAIPredictionEvent_PredictedActor_GET(NativePointer);
			set => E_PROP_FAIPredictionEvent_PredictedActor_SET(NativePointer, value);
		}

		public AActor Requestor
		{
			get => E_PROP_FAIPredictionEvent_Requestor_GET(NativePointer);
			set => E_PROP_FAIPredictionEvent_Requestor_SET(NativePointer, value);
		}

		public float TimeToPredict
		{
			get => E_PROP_FAIPredictionEvent_TimeToPredict_GET(NativePointer);
			set => E_PROP_FAIPredictionEvent_TimeToPredict_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FAIPredictionEvent self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FAIPredictionEvent(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FAIPredictionEvent(adress, false);
		}}}
