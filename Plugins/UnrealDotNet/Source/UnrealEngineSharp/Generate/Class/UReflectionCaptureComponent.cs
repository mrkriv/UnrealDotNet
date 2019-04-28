// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\ReflectionCaptureComponent.h:28

namespace UnrealEngine
{
	public  partial class UReflectionCaptureComponent : USceneComponent
	{
		public UReflectionCaptureComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public UReflectionCaptureComponent(UObject Parent = null, string Name = "ReflectionCaptureComponent")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UReflectionCaptureComponent(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UReflectionCaptureComponent_Brightness_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UReflectionCaptureComponent_Brightness_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_UReflectionCaptureComponent_CaptureOffset_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UReflectionCaptureComponent_CaptureOffset_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_PROP_UReflectionCaptureComponent_CaptureOffsetComponent_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UReflectionCaptureComponent_CaptureOffsetComponent_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UReflectionCaptureComponent_ReflectionSourceType_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UReflectionCaptureComponent_ReflectionSourceType_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UReflectionCaptureComponent_SourceCubemapAngle_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UReflectionCaptureComponent_SourceCubemapAngle_SET(IntPtr Ptr, float Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UReflectionCaptureComponent(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UReflectionCaptureComponent_GetInfluenceBoundingRadius(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UReflectionCaptureComponent_MarkDirtyForRecapture(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UReflectionCaptureComponent_MarkDirtyForRecaptureOrUpload(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UReflectionCaptureComponent_SetCaptureCompleted(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UReflectionCaptureComponent_UpdatePreviewShape(IntPtr self);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// <para>A brightness control to scale the captured scene's reflection intensity. </para>
		/// </summary>
		public float Brightness
		{
			get => E_PROP_UReflectionCaptureComponent_Brightness_GET(NativePointer);
			set => E_PROP_UReflectionCaptureComponent_Brightness_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>World space offset to apply before capturing. </para>
		/// </summary>
		public FVector CaptureOffset
		{
			get => E_PROP_UReflectionCaptureComponent_CaptureOffset_GET(NativePointer);
			set => E_PROP_UReflectionCaptureComponent_CaptureOffset_SET(NativePointer, value);
		}

		public UBillboardComponent CaptureOffsetComponent
		{
			get => E_PROP_UReflectionCaptureComponent_CaptureOffsetComponent_GET(NativePointer);
			set => E_PROP_UReflectionCaptureComponent_CaptureOffsetComponent_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Indicates where to get the reflection source from. </para>
		/// </summary>
		public EReflectionSourceType ReflectionSourceType
		{
			get => (EReflectionSourceType)E_PROP_UReflectionCaptureComponent_ReflectionSourceType_GET(NativePointer);
			set => E_PROP_UReflectionCaptureComponent_ReflectionSourceType_SET(NativePointer, (byte)value);
		}

		
		/// <summary>
		/// <para>Angle to rotate the source cubemap when SourceType is set to SLS_SpecifiedCubemap. </para>
		/// </summary>
		public float SourceCubemapAngle
		{
			get => E_PROP_UReflectionCaptureComponent_SourceCubemapAngle_GET(NativePointer);
			set => E_PROP_UReflectionCaptureComponent_SourceCubemapAngle_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// <para>Gets the radius that bounds the shape's influence, used for culling. </para>
		/// </summary>
		public virtual float GetInfluenceBoundingRadius()
			=> E_UReflectionCaptureComponent_GetInfluenceBoundingRadius(this);
		
		
		/// <summary>
		/// <para>Generates a new MapBuildDataId and adds the capture to the capture queue processed by UpdateReflectionCaptureContents. </para>
		/// </summary>
		public void MarkDirtyForRecapture()
			=> E_UReflectionCaptureComponent_MarkDirtyForRecapture(this);
		
		
		/// <summary>
		/// <para>Adds the capture to the capture queue processed by UpdateReflectionCaptureContents. </para>
		/// </summary>
		public void MarkDirtyForRecaptureOrUpload()
			=> E_UReflectionCaptureComponent_MarkDirtyForRecaptureOrUpload(this);
		
		
		/// <summary>
		/// <para>Marks this component has having been recaptured. </para>
		/// </summary>
		public void SetCaptureCompleted()
			=> E_UReflectionCaptureComponent_SetCaptureCompleted(this);
		
		
		/// <summary>
		/// <para>Called to update the preview shapes when something they are dependent on has changed. </para>
		/// </summary>
		public virtual void UpdatePreviewShape()
			=> E_UReflectionCaptureComponent_UpdatePreviewShape(this);
		
		#endregion
		
		public static implicit operator IntPtr(UReflectionCaptureComponent self)
		{
			return self.NativePointer;
		}

		public static implicit operator UReflectionCaptureComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UReflectionCaptureComponent>(PtrDesc);
		}}}
