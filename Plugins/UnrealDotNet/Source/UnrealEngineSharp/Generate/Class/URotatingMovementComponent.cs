// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\RotatingMovementComponent.h:16

namespace UnrealEngine
{
	public  partial class URotatingMovementComponent : UMovementComponent
	{
		public URotatingMovementComponent(IntPtr adress)
			: base(adress)
		{
		}

		public URotatingMovementComponent(UObject Parent = null, string Name = "RotatingMovementComponent")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_URotatingMovementComponent(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_URotatingMovementComponent_PivotTranslation_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_URotatingMovementComponent_PivotTranslation_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_URotatingMovementComponent_RotationRate_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_URotatingMovementComponent_RotationRate_SET(IntPtr Ptr, IntPtr Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_URotatingMovementComponent(IntPtr Parent, string Name);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// Translation of pivot point around which we rotate, relative to current rotation.
		/// <para>For instance, with PivotTranslation set to (X=+100, Y=0, Z=0), rotation will occur </para>
		/// around the point +100 units along the local X axis from the center of the object,
		/// <para>rather than around the object's origin (the default). </para>
		/// </summary>
		public FVector PivotTranslation
		{
			get => E_PROP_URotatingMovementComponent_PivotTranslation_GET(NativePointer);
			set => E_PROP_URotatingMovementComponent_PivotTranslation_SET(NativePointer, value);
		}

		
		/// <summary>
		/// How fast to update roll/pitch/yaw of the component we update.
		/// </summary>
		public FRotator RotationRate
		{
			get => E_PROP_URotatingMovementComponent_RotationRate_GET(NativePointer);
			set => E_PROP_URotatingMovementComponent_RotationRate_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(URotatingMovementComponent self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator URotatingMovementComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<URotatingMovementComponent>(PtrDesc);
		}}}
