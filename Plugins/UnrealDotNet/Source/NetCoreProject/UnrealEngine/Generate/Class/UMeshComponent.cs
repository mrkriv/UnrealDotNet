using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// MeshComponent is an abstract base for any component that is an instance of a renderable collection of triangles.
	/// @see UStaticMeshComponent
	/// @see USkeletalMeshComponent
	/// </summary>
	public partial class UMeshComponent : UPrimitiveComponent
	{
		public UMeshComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UMeshComponent_SetScalarParameterValueOnMaterials(IntPtr Self, string ParameterName, float ParameterValue);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UMeshComponent_SetVectorParameterValueOnMaterials(IntPtr Self, string ParameterName, IntPtr ParameterValue);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_UMeshComponent_GetScalarParameterDefaultValue(IntPtr Self, string ParameterName);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UMeshComponent_CacheMaterialParameterNameIndices(IntPtr Self);
		
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Set all occurrences of Scalar Material Parameters with ParameterName in the set of materials of the SkeletalMesh to ParameterValue
		/// </summary>
		public void SetScalarParameterValueOnMaterials(string ParameterName, float ParameterValue)
			=> E_UMeshComponent_SetScalarParameterValueOnMaterials(NativePointer, ParameterName, ParameterValue);
		
		
		/// <summary>
		/// Set all occurrences of Vector Material Parameters with ParameterName in the set of materials of the SkeletalMesh to ParameterValue
		/// </summary>
		public void SetVectorParameterValueOnMaterials(string ParameterName, FVector ParameterValue)
			=> E_UMeshComponent_SetVectorParameterValueOnMaterials(NativePointer, ParameterName, ParameterValue);
		
		
		/// <summary>
		/// Returns default value for the parameter input.
		/// NOTE: This is not reliable when cooking, as initializing the default value
		/// requires a render resource that only exists if the owning world is rendering.
		/// </summary>
		public float GetScalarParameterDefaultValue(string ParameterName)
			=> E_UMeshComponent_GetScalarParameterDefaultValue(NativePointer, ParameterName);
		
		
		/// <summary>
		/// Retrieves all the (scalar/vector-)parameters from within the used materials on the SkeletalMesh, and stores material index vs parameter names
		/// </summary>
		protected void CacheMaterialParameterNameIndices()
			=> E_UMeshComponent_CacheMaterialParameterNameIndices(NativePointer);
		
		#endregion
		
		public static implicit operator IntPtr(UMeshComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator UMeshComponent(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new UMeshComponent(Adress);
		}}}
