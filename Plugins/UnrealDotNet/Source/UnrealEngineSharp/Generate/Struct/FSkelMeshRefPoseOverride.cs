// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\SkinnedMeshComponent.h:178

namespace UnrealEngine
{
	public  partial class FSkelMeshRefPoseOverride : NativeStructWrapper
	{
		internal FSkelMeshRefPoseOverride(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FSkelMeshRefPoseOverride() :
			base(E_CreateStruct_FSkelMeshRefPoseOverride(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern TemplatePointerDescription E_PROP_FSkelMeshRefPoseOverride_RefBonePoses_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FSkelMeshRefPoseOverride_RefBonePoses_SET(IntPtr Ptr, IntPtr Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FSkelMeshRefPoseOverride();
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// <para>Per bone transforms (local space) for new ref pose </para>
		/// </summary>
		public TArray<FTransform> RefBonePoses
		{
			get => E_PROP_FSkelMeshRefPoseOverride_RefBonePoses_GET(NativePointer);
			set => E_PROP_FSkelMeshRefPoseOverride_RefBonePoses_SET(NativePointer, value);
		}

		#endregion
		
		public static implicit operator IntPtr(FSkelMeshRefPoseOverride self)
		{
			return self.NativePointer;
		}

		public static implicit operator FSkelMeshRefPoseOverride(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FSkelMeshRefPoseOverride(Adress, false);
		}}}
