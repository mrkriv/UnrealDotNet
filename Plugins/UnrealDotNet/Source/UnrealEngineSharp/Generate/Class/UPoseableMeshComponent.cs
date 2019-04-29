// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\PoseableMeshComponent.h:17

namespace UnrealEngine
{
	public  partial class UPoseableMeshComponent : USkinnedMeshComponent
	{
		public UPoseableMeshComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public UPoseableMeshComponent(UObject Parent = null, string Name = "PoseableMeshComponent")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UPoseableMeshComponent(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UPoseableMeshComponent(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPoseableMeshComponent_CopyPoseFromSkeletalComponent(IntPtr self, IntPtr inComponentToCopy);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPoseableMeshComponent_FillComponentSpaceTransforms(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UPoseableMeshComponent_IsRunningParallelEvaluation(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPoseableMeshComponent_MarkRefreshTransformDirty(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPoseableMeshComponent_ResetBoneTransformByName(IntPtr self, string boneName);
		
		#endregion
		
		#region ExternMethods
		public void CopyPoseFromSkeletalComponent(USkeletalMeshComponent inComponentToCopy)
			=> E_UPoseableMeshComponent_CopyPoseFromSkeletalComponent(this, inComponentToCopy);
		
		
		/// <summary>
		/// Take the BoneSpaceTransforms array (translation vector, rotation quaternion and scale vector) and update the array of component-space bone transformation matrices (SpaceBases).
		/// <para>It will work down hierarchy multiplying the component-space transform of the parent by the relative transform of the child. </para>
		/// This code also applies any per-bone rotators etc. as part of the composition process
		/// </summary>
		public void FillComponentSpaceTransforms()
			=> E_UPoseableMeshComponent_FillComponentSpaceTransforms(this);
		
		public bool IsRunningParallelEvaluation()
			=> E_UPoseableMeshComponent_IsRunningParallelEvaluation(this);
		
		public void MarkRefreshTransformDirty()
			=> E_UPoseableMeshComponent_MarkRefreshTransformDirty(this);
		
		public void ResetBoneTransformByName(string boneName)
			=> E_UPoseableMeshComponent_ResetBoneTransformByName(this, boneName);
		
		#endregion
		
		public static implicit operator IntPtr(UPoseableMeshComponent self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UPoseableMeshComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UPoseableMeshComponent>(PtrDesc);
		}}}
