// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\Perception\AISense_Damage.h:14

namespace UnrealEngine
{
	public partial class FAIDamageEvent : NativeStructWrapper
	{
		public FAIDamageEvent(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FAIDamageEvent() :
			base(E_CreateStruct_FAIDamageEvent(), false)
		{
		}

		public FAIDamageEvent(AActor inDamagedActor, AActor inInstigator, float damageAmount, FVector eventLocation, FVector inHitLocation) :
			base(E_CreateStruct_FAIDamageEvent_AActor_AActor_float_FVector_FVector(inDamagedActor, inInstigator, damageAmount, eventLocation, inHitLocation), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FAIDamageEvent_Amount_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FAIDamageEvent_Amount_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_PROP_FAIDamageEvent_DamagedActor_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FAIDamageEvent_DamagedActor_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FAIDamageEvent_HitLocation_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FAIDamageEvent_HitLocation_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_PROP_FAIDamageEvent_Instigator_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FAIDamageEvent_Instigator_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FAIDamageEvent_Location_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FAIDamageEvent_Location_SET(IntPtr Ptr, IntPtr Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FAIDamageEvent();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FAIDamageEvent_AActor_AActor_float_FVector_FVector(IntPtr inDamagedActor, IntPtr inInstigator, float damageAmount, IntPtr eventLocation, IntPtr inHitLocation);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FAIDamageEvent_Compile(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_FAIDamageEvent_GetDamagedActorAsPerceptionListener(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FAIDamageEvent_IsValid(IntPtr self);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// Damage taken by DamagedActor.
		/// <para>@Note 0-damage events do not get ignored </para>
		/// </summary>
		public float Amount
		{
			get => E_PROP_FAIDamageEvent_Amount_GET(NativePointer);
			set => E_PROP_FAIDamageEvent_Amount_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Damaged actor
		/// </summary>
		public AActor DamagedActor
		{
			get => E_PROP_FAIDamageEvent_DamagedActor_GET(NativePointer);
			set => E_PROP_FAIDamageEvent_DamagedActor_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Event's additional spatial information
		/// <para>@TODO document </para>
		/// </summary>
		public FVector HitLocation
		{
			get => E_PROP_FAIDamageEvent_HitLocation_GET(NativePointer);
			set => E_PROP_FAIDamageEvent_HitLocation_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Actor that instigated damage. Can be None
		/// </summary>
		public AActor Instigator
		{
			get => E_PROP_FAIDamageEvent_Instigator_GET(NativePointer);
			set => E_PROP_FAIDamageEvent_Instigator_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Event's "Location", or what will be later treated as the perceived location for this sense.
		/// <para>If not set, HitLocation will be used, if that is unset too DamagedActor's location </para>
		/// </summary>
		public FVector Location
		{
			get => E_PROP_FAIDamageEvent_Location_GET(NativePointer);
			set => E_PROP_FAIDamageEvent_Location_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		public void Compile()
			=> E_FAIDamageEvent_Compile(this);
		
		public IAIPerceptionListenerInterface GetDamagedActorAsPerceptionListener()
			=> E_FAIDamageEvent_GetDamagedActorAsPerceptionListener(this);
		
		public bool IsValid()
			=> E_FAIDamageEvent_IsValid(this);
		
		#endregion
		
		public static implicit operator IntPtr(FAIDamageEvent self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FAIDamageEvent(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FAIDamageEvent(adress, false);
		}}}
