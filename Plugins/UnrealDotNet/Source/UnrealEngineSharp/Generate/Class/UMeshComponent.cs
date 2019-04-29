// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\MeshComponent.h:21

namespace UnrealEngine
{
	public  partial class UMeshComponent : UPrimitiveComponent
	{
		public UMeshComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public UMeshComponent(UObject Parent = null, string Name = "MeshComponent")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UMeshComponent(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UMeshComponent(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UMeshComponent_CacheMaterialParameterNameIndices(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UMeshComponent_EmptyOverrideMaterials(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_UMeshComponent_GetMaterialIndex(IntPtr self, string materialSlotName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_UMeshComponent_GetNumOverrideMaterials(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UMeshComponent_GetScalarParameterDefaultValue(IntPtr self, string parameterName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UMeshComponent_IsMaterialSlotNameValid(IntPtr self, string materialSlotName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UMeshComponent_MarkCachedMaterialParameterNameIndicesDirty(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UMeshComponent_PrestreamTextures(IntPtr self, float seconds, bool bPrioritizeCharacterTextures, int cinematicTextureGroups);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UMeshComponent_SetScalarParameterValueOnMaterials(IntPtr self, string parameterName, float parameterValue);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UMeshComponent_SetTextureForceResidentFlag(IntPtr self, bool bForceMiplevelsToBeResident);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UMeshComponent_SetVectorParameterValueOnMaterials(IntPtr self, string parameterName, IntPtr parameterValue);
		
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Retrieves all the (scalar/vector-)parameters from within the used materials on the SkeletalMesh, and stores material index vs parameter names
		/// </summary>
		protected void CacheMaterialParameterNameIndices()
			=> E_UMeshComponent_CacheMaterialParameterNameIndices(this);
		
		
		/// <summary>
		/// This empties all override materials and used by editor when replacing preview mesh
		/// </summary>
		public void EmptyOverrideMaterials()
			=> E_UMeshComponent_EmptyOverrideMaterials(this);
		
		public virtual int GetMaterialIndex(string materialSlotName)
			=> E_UMeshComponent_GetMaterialIndex(this, materialSlotName);
		
		
		/// <summary>
		/// Returns override Materials count
		/// </summary>
		public virtual int GetNumOverrideMaterials()
			=> E_UMeshComponent_GetNumOverrideMaterials(this);
		
		
		/// <summary>
		/// Returns default value for the parameter input.
		/// <para>NOTE: This is not reliable when cooking, as initializing the default value </para>
		/// requires a render resource that only exists if the owning world is rendering.
		/// </summary>
		public float GetScalarParameterDefaultValue(string parameterName)
			=> E_UMeshComponent_GetScalarParameterDefaultValue(this, parameterName);
		
		public virtual bool IsMaterialSlotNameValid(string materialSlotName)
			=> E_UMeshComponent_IsMaterialSlotNameValid(this, materialSlotName);
		
		
		/// <summary>
		/// Mark cache parameters map as dirty, cache will be rebuild once SetScalar/SetVector functions are called
		/// </summary>
		protected void MarkCachedMaterialParameterNameIndicesDirty()
			=> E_UMeshComponent_MarkCachedMaterialParameterNameIndicesDirty(this);
		
		
		/// <summary>
		/// Tell the streaming system to start loading all textures with all mip-levels.
		/// </summary>
		/// <param name="seconds">Number of seconds to force all mip-levels to be resident</param>
		/// <param name="bPrioritizeCharacterTextures">Whether character textures should be prioritized for a while by the streaming system</param>
		/// <param name="cinematicTextureGroups">Bitfield indicating which texture groups that use extra high-resolution mips</param>
		public virtual void PrestreamTextures(float seconds, bool bPrioritizeCharacterTextures, int cinematicTextureGroups)
			=> E_UMeshComponent_PrestreamTextures(this, seconds, bPrioritizeCharacterTextures, cinematicTextureGroups);
		
		
		/// <summary>
		/// Set all occurrences of Scalar Material Parameters with ParameterName in the set of materials of the SkeletalMesh to ParameterValue
		/// </summary>
		public void SetScalarParameterValueOnMaterials(string parameterName, float parameterValue)
			=> E_UMeshComponent_SetScalarParameterValueOnMaterials(this, parameterName, parameterValue);
		
		
		/// <summary>
		/// Tell the streaming system whether or not all mip levels of all textures used by this component should be loaded and remain loaded.
		/// </summary>
		/// <param name="bForceMiplevelsToBeResident">Whether textures should be forced to be resident or not.</param>
		public virtual void SetTextureForceResidentFlag(bool bForceMiplevelsToBeResident)
			=> E_UMeshComponent_SetTextureForceResidentFlag(this, bForceMiplevelsToBeResident);
		
		
		/// <summary>
		/// Set all occurrences of Vector Material Parameters with ParameterName in the set of materials of the SkeletalMesh to ParameterValue
		/// </summary>
		public void SetVectorParameterValueOnMaterials(string parameterName, FVector parameterValue)
			=> E_UMeshComponent_SetVectorParameterValueOnMaterials(this, parameterName, parameterValue);
		
		#endregion
		
		public static implicit operator IntPtr(UMeshComponent self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UMeshComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UMeshComponent>(PtrDesc);
		}}}
