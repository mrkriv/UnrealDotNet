// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\Perception\AISense_Hearing.h:64

namespace UnrealEngine
{
	public partial class UAISense_Hearing : UAISense
	{
		public UAISense_Hearing(IntPtr adress)
			: base(adress)
		{
		}

		public UAISense_Hearing(UObject Parent = null, string Name = "AISense_Hearing")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UAISense_Hearing(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UAISense_Hearing(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAISense_Hearing_OnListenerRemovedImpl(IntPtr self, IntPtr updatedListener);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAISense_Hearing_OnListenerUpdateImpl(IntPtr self, IntPtr updatedListener);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAISense_Hearing_OnNewListenerImpl(IntPtr self, IntPtr newListener);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAISense_Hearing_RegisterEvent(IntPtr self, IntPtr @event);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAISense_Hearing_RegisterMakeNoiseDelegate(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAISense_Hearing_ReportNoiseEvent(IntPtr self, IntPtr worldContextObject, IntPtr noiseLocation, float loudness, IntPtr instigator, float maxRange, string tag);
		
		#endregion
		
		#region ExternMethods
		protected void OnListenerRemovedImpl(FPerceptionListener updatedListener)
			=> E_UAISense_Hearing_OnListenerRemovedImpl(this, updatedListener);
		
		protected void OnListenerUpdateImpl(FPerceptionListener updatedListener)
			=> E_UAISense_Hearing_OnListenerUpdateImpl(this, updatedListener);
		
		protected void OnNewListenerImpl(FPerceptionListener newListener)
			=> E_UAISense_Hearing_OnNewListenerImpl(this, newListener);
		
		public void RegisterEvent(FAINoiseEvent @event)
			=> E_UAISense_Hearing_RegisterEvent(this, @event);
		
		protected virtual void RegisterMakeNoiseDelegate()
			=> E_UAISense_Hearing_RegisterMakeNoiseDelegate(this);
		
		
		/// <summary>
		/// Report a noise event.
		/// </summary>
		/// <param name="noiseLocation">Location of the noise.</param>
		/// <param name="loudness">Loudness of the noise. If MaxRange is non-zero, modifies MaxRange, otherwise modifies the squared distance of the sensor's range.</param>
		/// <param name="instigator">Actor that triggered the noise.</param>
		/// <param name="maxRange">Max range at which the sound can be heard, multiplied by Loudness. Values <= 0 mean no limit (still limited by listener's range however).</param>
		/// <param name="tag">Identifier for the event.</param>
		public void ReportNoiseEvent(UObject worldContextObject, FVector noiseLocation, float loudness, AActor instigator, float maxRange, string tag)
			=> E_UAISense_Hearing_ReportNoiseEvent(this, worldContextObject, noiseLocation, loudness, instigator, maxRange, tag);
		
		#endregion
		
		public static implicit operator IntPtr(UAISense_Hearing self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UAISense_Hearing(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UAISense_Hearing>(PtrDesc);
		}}}
