// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\EngineTypes.h:2581

namespace UnrealEngine
{
	public  partial class FDamageEvent : NativeStructWrapper
	{
		internal FDamageEvent(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		
		/// <summary>
		/// Default constructor (no initialization).
		/// </summary>
		public FDamageEvent() :
			base(E_CreateStruct_FDamageEvent(), false)
		{
		}

		public FDamageEvent(FDamageEvent inDamageEvent) :
			base(E_CreateStruct_FDamageEvent_FDamageEvent(inDamageEvent), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FDamageEvent();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FDamageEvent_FDamageEvent(IntPtr inDamageEvent);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FDamageEvent_GetBestHitInfo(IntPtr self, IntPtr hitActor, IntPtr hitInstigator, IntPtr outHitInfo, IntPtr outImpulseDir);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_FDamageEvent_GetTypeID(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FDamageEvent_IsOfType(IntPtr self, int inID);
		
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// This is for compatibility with old-style functions which want a unified set of hit data regardless of type of hit.  Ideally this will go away over time.
		/// </summary>
		public virtual void GetBestHitInfo(AActor hitActor, AActor hitInstigator, FHitResult outHitInfo, FVector outImpulseDir)
			=> E_FDamageEvent_GetBestHitInfo(this, hitActor, hitInstigator, outHitInfo, outImpulseDir);
		
		public virtual int GetTypeID()
			=> E_FDamageEvent_GetTypeID(this);
		
		public virtual bool IsOfType(int inID)
			=> E_FDamageEvent_IsOfType(this, inID);
		
		#endregion
		
		public static implicit operator IntPtr(FDamageEvent self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FDamageEvent(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FDamageEvent(Adress, false);
		}}}
