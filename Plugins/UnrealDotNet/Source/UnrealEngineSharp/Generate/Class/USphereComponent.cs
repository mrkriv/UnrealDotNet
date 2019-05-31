// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\SphereComponent.h:17

namespace UnrealEngine
{
	public  partial class USphereComponent : UShapeComponent
	{
		public USphereComponent(IntPtr adress)
			: base(adress)
		{
		}

		public USphereComponent(UObject Parent = null, string Name = "SphereComponent")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_USphereComponent(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_USphereComponent(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_USphereComponent_GetScaledSphereRadius(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_USphereComponent_GetShapeScale(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_USphereComponent_GetUnscaledSphereRadius(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USphereComponent_InitSphereRadius(IntPtr self, float inSphereRadius);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USphereComponent_SetSphereRadius(IntPtr self, float inSphereRadius, bool bUpdateOverlaps);
		
		#endregion
		
		#region ExternMethods
		public float GetScaledSphereRadius()
			=> E_USphereComponent_GetScaledSphereRadius(this);
		
		public float GetShapeScale()
			=> E_USphereComponent_GetShapeScale(this);
		
		public float GetUnscaledSphereRadius()
			=> E_USphereComponent_GetUnscaledSphereRadius(this);
		
		public void InitSphereRadius(float inSphereRadius)
			=> E_USphereComponent_InitSphereRadius(this, inSphereRadius);
		
		
		/// <summary>
		/// Change the sphere radius. This is the unscaled radius, before component scale is applied.
		/// </summary>
		/// <param name="inSphereRadius">the new sphere radius</param>
		/// <param name="bUpdateOverlaps">if true and this shape is registered and collides, updates touching array for owner actor.</param>
		public void SetSphereRadius(float inSphereRadius, bool bUpdateOverlaps = true)
			=> E_USphereComponent_SetSphereRadius(this, inSphereRadius, bUpdateOverlaps);
		
		#endregion
		
		public static implicit operator IntPtr(USphereComponent self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator USphereComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<USphereComponent>(PtrDesc);
		}}}
