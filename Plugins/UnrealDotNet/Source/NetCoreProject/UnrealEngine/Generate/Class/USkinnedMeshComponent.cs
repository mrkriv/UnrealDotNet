using System;
using System.Runtime.InteropServices;

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

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_USkinnedMeshComponent(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkinnedMeshComponent_ClearRefPoseOverride(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkinnedMeshComponent_ClearSkinWeightOverride(IntPtr Self, int LODIndex);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkinnedMeshComponent_ClearVertexColorOverride(IntPtr Self, int LODIndex);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_USkinnedMeshComponent_GetBoneIndex(IntPtr Self, string BoneName);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_USkinnedMeshComponent_GetBoneName(IntPtr Self, int BoneIndex);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_USkinnedMeshComponent_GetNumBones(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_USkinnedMeshComponent_GetParentBone(IntPtr Self, string BoneName);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_USkinnedMeshComponent_GetSkinnedVertexPosition(IntPtr Self, int VertexIndex);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_USkinnedMeshComponent_GetSocketBoneName(IntPtr Self, string InSocketName);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkinnedMeshComponent_SetCapsuleIndirectShadowMinVisibility(IntPtr Self, float NewValue);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkinnedMeshComponent_SetCastCapsuleDirectShadow(IntPtr Self, bool bNewValue);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkinnedMeshComponent_SetCastCapsuleIndirectShadow(IntPtr Self, bool bNewValue);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkinnedMeshComponent_SetForcedLOD(IntPtr Self, int InNewForcedLOD);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkinnedMeshComponent_SetForceWireframe(IntPtr Self, bool InForceWireframe);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkinnedMeshComponent_SetMaterialPreview(IntPtr Self, int InMaterialIndexPreview);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkinnedMeshComponent_SetMinLOD(IntPtr Self, int InNewMinLOD);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkinnedMeshComponent_SetSectionPreview(IntPtr Self, int InSectionIndexPreview);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_USkinnedMeshComponent_ShouldCPUSkin(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USkinnedMeshComponent_UpdateRecomputeTangent(IntPtr Self, int MaterialIndex, int LodIndex, bool bRecomputeTangentValue);
		
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// <para>Clear any applied ref pose override </para>
		/// </summary>
		public virtual void ClearRefPoseOverride()
			=> E_USkinnedMeshComponent_ClearRefPoseOverride(this);
		
		
		/// <summary>
		/// <para>Clear any applied skin weight override </para>
		/// </summary>
		public void ClearSkinWeightOverride(int LODIndex)
			=> E_USkinnedMeshComponent_ClearSkinWeightOverride(this, LODIndex);
		
		
		/// <summary>
		/// <para>Clear any applied vertex color override </para>
		/// </summary>
		public void ClearVertexColorOverride(int LODIndex)
			=> E_USkinnedMeshComponent_ClearVertexColorOverride(this, LODIndex);
		
		
		/// <summary>
		/// <para>Find the index of bone by name. Looks in the current SkeletalMesh being used by this SkeletalMeshComponent. </para>
		/// <param name="BoneName">Name of bone to look up </param>
		/// <return>Index of the named bone in the current SkeletalMesh. Will return INDEX_NONE if bone not found. </return>
		/// <para>@see USkeletalMesh::GetBoneIndex. </para>
		/// </summary>
		public int GetBoneIndex(string BoneName)
			=> E_USkinnedMeshComponent_GetBoneIndex(this, BoneName);
		
		
		/// <summary>
		/// <para>Get Bone Name from index </para>
		/// <param name="BoneIndex">Index of the bone </param>
		/// <return>the name of the bone at the specified index </return>
		/// </summary>
		public string GetBoneName(int BoneIndex)
			=> E_USkinnedMeshComponent_GetBoneName(this, BoneIndex);
		
		
		/// <summary>
		/// <para>Returns the number of bones in the skeleton. </para>
		/// </summary>
		public int GetNumBones()
			=> E_USkinnedMeshComponent_GetNumBones(this);
		
		
		/// <summary>
		/// <para>Get Parent Bone of the input bone </para>
		/// <param name="BoneName">Name of the bone </param>
		/// <return>the name of the parent bone for the specified bone. Returns 'None' if the bone does not exist or it is the root bone </return>
		/// </summary>
		public string GetParentBone(string BoneName)
			=> E_USkinnedMeshComponent_GetParentBone(this, BoneName);
		
		
		/// <summary>
		/// <para>Simple, CPU evaluation of a vertex's skinned position (returned in component space) </para>
		/// <param name="VertexIndex">Vertex Index. If compressed, this will be slow. </param>
		/// </summary>
		public virtual FVector GetSkinnedVertexPosition(int VertexIndex)
			=> E_USkinnedMeshComponent_GetSkinnedVertexPosition(this, VertexIndex);
		
		
		/// <summary>
		/// <para>Returns bone name linked to a given named socket on the skeletal mesh component. </para>
		/// <para>If you're unsure to deal with sockets or bones names, you can use this function to filter through, and always return the bone name. </para>
		/// <param name="bone">name or socket name </param>
		/// <return>bone name </return>
		/// </summary>
		public string GetSocketBoneName(string InSocketName)
			=> E_USkinnedMeshComponent_GetSocketBoneName(this, InSocketName);
		
		public void SetCapsuleIndirectShadowMinVisibility(float NewValue)
			=> E_USkinnedMeshComponent_SetCapsuleIndirectShadowMinVisibility(this, NewValue);
		
		
		/// <summary>
		/// <para>Get the LOD Bias of this component </para>
		/// <return>The LOD bias of this component. Derived classes can override this to ignore or override LOD bias settings. </return>
		/// </summary>
		public void SetCastCapsuleDirectShadow(bool bNewValue)
			=> E_USkinnedMeshComponent_SetCastCapsuleDirectShadow(this, bNewValue);
		
		public void SetCastCapsuleIndirectShadow(bool bNewValue)
			=> E_USkinnedMeshComponent_SetCastCapsuleIndirectShadow(this, bNewValue);
		
		
		/// <summary>
		/// <para>Set MinLodModel of the mesh component </para>
		/// <param name="InNewForcedLOD">Set new ForcedLODModel that forces to set the incoming LOD. Range from [1, Max Number of LOD]. This will affect in the next tick update. </param>
		/// </summary>
		public void SetForcedLOD(int InNewForcedLOD)
			=> E_USkinnedMeshComponent_SetForcedLOD(this, InNewForcedLOD);
		
		
		/// <summary>
		/// <para>Sets the value of the bForceWireframe flag and reattaches the component as necessary. </para>
		/// <param name="InForceWireframe">New value of bForceWireframe. </param>
		/// </summary>
		public void SetForceWireframe(bool InForceWireframe)
			=> E_USkinnedMeshComponent_SetForceWireframe(this, InForceWireframe);
		
		public void SetMaterialPreview(int InMaterialIndexPreview)
			=> E_USkinnedMeshComponent_SetMaterialPreview(this, InMaterialIndexPreview);
		
		
		/// <summary>
		/// <para>Set MinLodModel of the mesh component </para>
		/// <param name="InNewMinLOD">Set new MinLodModel that make sure the LOD does not go below of this value. Range from [0, Max Number of LOD - 1]. This will affect in the next tick update. </param>
		/// </summary>
		public void SetMinLOD(int InNewMinLOD)
			=> E_USkinnedMeshComponent_SetMinLOD(this, InNewMinLOD);
		
		
		/// <summary>
		/// <para>Sets the value of the SectionIndexPreview flag and reattaches the component as necessary. </para>
		/// <param name="InSectionIndexPreview">New value of SectionIndexPreview. </param>
		/// </summary>
		public void SetSectionPreview(int InSectionIndexPreview)
			=> E_USkinnedMeshComponent_SetSectionPreview(this, InSectionIndexPreview);
		
		
		/// <summary>
		/// <para>Function returns whether or not CPU skinning should be applied </para>
		/// <para>Allows the editor to override the skinning state for editor tools </para>
		/// <return>true if should CPU skin. false otherwise </return>
		/// </summary>
		public virtual bool ShouldCPUSkin()
			=> E_USkinnedMeshComponent_ShouldCPUSkin(this);
		
		
		/// <summary>
		/// <para>update Recalculate Normal flag in matching section </para>
		/// </summary>
		public void UpdateRecomputeTangent(int MaterialIndex, int LodIndex, bool bRecomputeTangentValue)
			=> E_USkinnedMeshComponent_UpdateRecomputeTangent(this, MaterialIndex, LodIndex, bRecomputeTangentValue);
		
		#endregion
		
		public static implicit operator IntPtr(USkinnedMeshComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator USkinnedMeshComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<USkinnedMeshComponent>(PtrDesc);
		}}}
