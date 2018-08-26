// This file was created automatically, do not modify the contents of this file.

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\Components\SkinnedMeshComponent.h:182

namespace UnrealEngine
{
	[ManageType("ManageSkinnedMeshComponent")]
	public partial class ManageSkinnedMeshComponent : USkinnedMeshComponent
	{
		public ManageSkinnedMeshComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		
		/// <summary>
		/// <para>Clear any applied ref pose override </para>
		/// </summary>
		public override void ClearRefPoseOverride() { }
		
		
		/// <summary>
		/// <para>Apply an override for the current mesh ref pose </para>
		/// </summary>
		public override void SetRefPoseOverride(TArray<FTransform> newRefPoseTransforms) { }
		
		public static implicit operator IntPtr(ManageSkinnedMeshComponent self)
		{
			return self.NativePointer;
		}

		public static implicit operator ManageSkinnedMeshComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageSkinnedMeshComponent>(PtrDesc);
		}}}
