// This file was created automatically, do not modify the contents of this file.

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
		private static extern float E_UMeshComponent_GetScalarParameterDefaultValue(IntPtr self, string parameterName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UMeshComponent_MarkCachedMaterialParameterNameIndicesDirty(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UMeshComponent_SetScalarParameterValueOnMaterials(IntPtr self, string parameterName, float parameterValue);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UMeshComponent_SetVectorParameterValueOnMaterials(IntPtr self, string parameterName, IntPtr parameterValue);
		
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// <para>Retrieves all the (scalar/vector-)parameters from within the used materials on the SkeletalMesh, and stores material index vs parameter names </para>
		/// </summary>
		protected void CacheMaterialParameterNameIndices()
			=> E_UMeshComponent_CacheMaterialParameterNameIndices(this);
		
		
		/// <summary>
		/// <para>Returns default value for the parameter input. </para>
		/// <para>NOTE: This is not reliable when cooking, as initializing the default value </para>
		/// <para>requires a render resource that only exists if the owning world is rendering. </para>
		/// </summary>
		public float GetScalarParameterDefaultValue(string parameterName)
			=> E_UMeshComponent_GetScalarParameterDefaultValue(this, parameterName);
		
		
		/// <summary>
		/// <para>Mark cache parameters map as dirty, cache will be rebuild once SetScalar/SetVector functions are called </para>
		/// </summary>
		protected void MarkCachedMaterialParameterNameIndicesDirty()
			=> E_UMeshComponent_MarkCachedMaterialParameterNameIndicesDirty(this);
		
		
		/// <summary>
		/// <para>Set all occurrences of Scalar Material Parameters with ParameterName in the set of materials of the SkeletalMesh to ParameterValue </para>
		/// </summary>
		public void SetScalarParameterValueOnMaterials(string parameterName, float parameterValue)
			=> E_UMeshComponent_SetScalarParameterValueOnMaterials(this, parameterName, parameterValue);
		
		
		/// <summary>
		/// <para>Set all occurrences of Vector Material Parameters with ParameterName in the set of materials of the SkeletalMesh to ParameterValue </para>
		/// </summary>
		public void SetVectorParameterValueOnMaterials(string parameterName, FVector parameterValue)
			=> E_UMeshComponent_SetVectorParameterValueOnMaterials(this, parameterName, parameterValue);
		
		#endregion
		
		public static implicit operator IntPtr(UMeshComponent self)
		{
			return self.NativePointer;
		}

		public static implicit operator UMeshComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UMeshComponent>(PtrDesc);
		}}}
