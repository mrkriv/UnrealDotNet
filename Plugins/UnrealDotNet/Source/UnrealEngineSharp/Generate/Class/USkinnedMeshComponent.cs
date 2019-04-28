// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\SkinnedMeshComponent.h:195

namespace UnrealEngine
{
	public  partial class USkinnedMeshComponent : UMeshComponent
	{
		public USkinnedMeshComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public USkinnedMeshComponent(UObject Parent = null, string Name = "SkinnedMeshComponent")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_USkinnedMeshComponent(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_USkinnedMeshComponent_ForcedLodModel_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USkinnedMeshComponent_ForcedLodModel_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_USkinnedMeshComponent_MaxDistanceFactor_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USkinnedMeshComponent_MaxDistanceFactor_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_USkinnedMeshComponent_MinLodModel_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USkinnedMeshComponent_MinLodModel_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_USkinnedMeshComponent_PredictedLODLevel_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USkinnedMeshComponent_PredictedLODLevel_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_USkinnedMeshComponent_StreamingDistanceMultiplier_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USkinnedMeshComponent_StreamingDistanceMultiplier_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_USkinnedMeshComponent_VisibilityBasedAnimTickOption_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USkinnedMeshComponent_VisibilityBasedAnimTickOption_SET(IntPtr Ptr, byte Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_USkinnedMeshComponent(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkinnedMeshComponent_ClearMotionVector(IntPtr self);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// If 0, auto-select LOD level. if >0, force to (ForcedLodModel-1).
		/// </summary>
		public int ForcedLodModel
		{
			get => E_PROP_USkinnedMeshComponent_ForcedLodModel_GET(NativePointer);
			set => E_PROP_USkinnedMeshComponent_ForcedLodModel_SET(NativePointer, value);
		}

		
		/// <summary>
		/// High (best) DistanceFactor that was desired for rendering this USkeletalMesh last frame. Represents how big this mesh was in screen space
		/// </summary>
		public float MaxDistanceFactor
		{
			get => E_PROP_USkinnedMeshComponent_MaxDistanceFactor_GET(NativePointer);
			set => E_PROP_USkinnedMeshComponent_MaxDistanceFactor_SET(NativePointer, value);
		}

		
		/// <summary>
		/// This is the min LOD that this component will use.  (e.g. if set to 2 then only 2+ LOD Models will be used.) This is useful to set on
		/// <para>meshes which are known to be a certain distance away and still want to have better LODs when zoomed in on them. </para>
		/// </summary>
		public int MinLodModel
		{
			get => E_PROP_USkinnedMeshComponent_MinLodModel_GET(NativePointer);
			set => E_PROP_USkinnedMeshComponent_MinLodModel_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Best LOD that was 'predicted' by UpdateSkelPose.
		/// <para>This is what bones were updated based on, so we do not allow rendering at a better LOD than this. </para>
		/// </summary>
		public int PredictedLODLevel
		{
			get => E_PROP_USkinnedMeshComponent_PredictedLODLevel_GET(NativePointer);
			set => E_PROP_USkinnedMeshComponent_PredictedLODLevel_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Allows adjusting the desired streaming distance of streaming textures that uses UV 0.
		/// <para>1.0 is the default, whereas a higher value makes the textures stream in sooner from far away. </para>
		/// A lower value (0.0-1.0) makes the textures stream in later (you have to be closer).
		/// <para>Value can be < 0 (from legcay content, or code changes) </para>
		/// </summary>
		public float StreamingDistanceMultiplier
		{
			get => E_PROP_USkinnedMeshComponent_StreamingDistanceMultiplier_GET(NativePointer);
			set => E_PROP_USkinnedMeshComponent_StreamingDistanceMultiplier_SET(NativePointer, value);
		}

		public EVisibilityBasedAnimTickOption VisibilityBasedAnimTickOption
		{
			get => (EVisibilityBasedAnimTickOption)E_PROP_USkinnedMeshComponent_VisibilityBasedAnimTickOption_GET(NativePointer);
			set => E_PROP_USkinnedMeshComponent_VisibilityBasedAnimTickOption_SET(NativePointer, (byte)value);
		}

		#endregion
		
		#region ExternMethods
		public void ClearMotionVector()
			=> E_USkinnedMeshComponent_ClearMotionVector(this);
		
		#endregion
		
		public static implicit operator IntPtr(USkinnedMeshComponent self)
		{
			return self.NativePointer;
		}

		public static implicit operator USkinnedMeshComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<USkinnedMeshComponent>(PtrDesc);
		}}}
