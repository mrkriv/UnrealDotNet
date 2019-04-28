// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\VectorFieldComponent.h:18

namespace UnrealEngine
{
	public  partial class UVectorFieldComponent : UPrimitiveComponent
	{
		public UVectorFieldComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public UVectorFieldComponent(UObject Parent = null, string Name = "VectorFieldComponent")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UVectorFieldComponent(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UVectorFieldComponent_Intensity_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UVectorFieldComponent_Intensity_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UVectorFieldComponent_Tightness_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UVectorFieldComponent_Tightness_SET(IntPtr Ptr, float Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UVectorFieldComponent(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UVectorFieldComponent_SetIntensity(IntPtr self, float newIntensity);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// The intensity at which the vector field is applied.
		/// </summary>
		public float Intensity
		{
			get => E_PROP_UVectorFieldComponent_Intensity_GET(NativePointer);
			set => E_PROP_UVectorFieldComponent_Intensity_SET(NativePointer, value);
		}

		
		/// <summary>
		/// How tightly particles follow the vector field.
		/// </summary>
		public float Tightness
		{
			get => E_PROP_UVectorFieldComponent_Tightness_GET(NativePointer);
			set => E_PROP_UVectorFieldComponent_Tightness_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Set the intensity of the vector field.
		/// </summary>
		/// <param name="newIntensity">The new intensity of the vector field.</param>
		public virtual void SetIntensity(float newIntensity)
			=> E_UVectorFieldComponent_SetIntensity(this, newIntensity);
		
		#endregion
		
		public static implicit operator IntPtr(UVectorFieldComponent self)
		{
			return self.NativePointer;
		}

		public static implicit operator UVectorFieldComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UVectorFieldComponent>(PtrDesc);
		}}}
