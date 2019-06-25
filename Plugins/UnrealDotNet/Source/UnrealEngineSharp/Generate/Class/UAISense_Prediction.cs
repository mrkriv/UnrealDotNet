// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\Perception\AISense_Prediction.h:38

namespace UnrealEngine
{
	public partial class UAISense_Prediction : UAISense
	{
		public UAISense_Prediction(IntPtr adress)
			: base(adress)
		{
		}

		public UAISense_Prediction(UObject Parent = null, string Name = "AISense_Prediction")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UAISense_Prediction(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UAISense_Prediction(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAISense_Prediction_RegisterEvent(IntPtr self, IntPtr @event);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAISense_Prediction_RequestControllerPredictionEvent(IntPtr self, IntPtr requestor, IntPtr predictedActor, float predictionTime);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAISense_Prediction_RequestPawnPredictionEvent(IntPtr self, IntPtr requestor, IntPtr predictedActor, float predictionTime);
		
		#endregion
		
		#region ExternMethods
		public void RegisterEvent(FAIPredictionEvent @event)
			=> E_UAISense_Prediction_RegisterEvent(this, @event);
		
		
		/// <summary>
		/// Asks perception system to supply Requestor with PredictedActor's predicted location in PredictionTime seconds
		/// <para>Location is being predicted based on PredicterActor's current location and velocity </para>
		/// </summary>
		public void RequestControllerPredictionEvent(AAIController requestor, AActor predictedActor, float predictionTime)
			=> E_UAISense_Prediction_RequestControllerPredictionEvent(this, requestor, predictedActor, predictionTime);
		
		
		/// <summary>
		/// Asks perception system to supply Requestor with PredictedActor's predicted location in PredictionTime seconds
		/// <para>Location is being predicted based on PredicterActor's current location and velocity </para>
		/// </summary>
		public void RequestPawnPredictionEvent(APawn requestor, AActor predictedActor, float predictionTime)
			=> E_UAISense_Prediction_RequestPawnPredictionEvent(this, requestor, predictedActor, predictionTime);
		
		#endregion
		
		public static implicit operator IntPtr(UAISense_Prediction self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UAISense_Prediction(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UAISense_Prediction>(PtrDesc);
		}}}
