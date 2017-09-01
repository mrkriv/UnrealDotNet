using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// A Spline Mesh Component is a derivation of a Static Mesh Component which can be deformed using a spline. Only a start and end position (and tangent) can be specified.
	/// @see https://docs.unrealengine.com/latest/INT/Resources/ContentExamples/Blueprint_Splines
	/// </summary>
	public partial class USplineMeshComponent : UStaticMeshComponent
	{
		public USplineMeshComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_USplineMeshComponent_CalculateScaleZAndMinZ(IntPtr Self, float OutScaleZ, float OutMinZ);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_USplineMeshComponent_GetStartPosition(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_USplineMeshComponent_SetStartPosition(IntPtr Self, IntPtr StartPos, bool bUpdateMesh);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_USplineMeshComponent_SetStartAndEnd(IntPtr Self, IntPtr StartPos, IntPtr StartTangent, IntPtr EndPos, IntPtr EndTangent, bool bUpdateMesh);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_USplineMeshComponent_GetStartScale(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_USplineMeshComponent_SetStartScale(IntPtr Self, IntPtr StartScale, bool bUpdateMesh);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_USplineMeshComponent_GetStartRoll(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_USplineMeshComponent_SetStartRoll(IntPtr Self, float StartRoll, bool bUpdateMesh);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_USplineMeshComponent_SetSplineUpDir(IntPtr Self, IntPtr InSplineUpDir, bool bUpdateMesh);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_USplineMeshComponent_CalcSliceTransform(IntPtr Self, float DistanceAlong);
		
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Determines the mesh proxy values for SplineMeshScaleZ and SplineMeshMinZ
		/// </summary>
		public void CalculateScaleZAndMinZ(float OutScaleZ, float OutMinZ)
			=> E_USplineMeshComponent_CalculateScaleZAndMinZ(NativePointer, OutScaleZ, OutMinZ);
		
		
		/// <summary>
		/// Get the start position of spline in local space
		/// </summary>
		public FVector GetStartPosition()
			=> E_USplineMeshComponent_GetStartPosition(NativePointer);
		
		
		/// <summary>
		/// Set the start position of spline in local space
		/// </summary>
		public void SetStartPosition(FVector StartPos, bool bUpdateMesh = true)
			=> E_USplineMeshComponent_SetStartPosition(NativePointer, StartPos, bUpdateMesh);
		
		
		/// <summary>
		/// Set the start and end, position and tangent, all in local space
		/// </summary>
		public void SetStartAndEnd(FVector StartPos, FVector StartTangent, FVector EndPos, FVector EndTangent, bool bUpdateMesh = true)
			=> E_USplineMeshComponent_SetStartAndEnd(NativePointer, StartPos, StartTangent, EndPos, EndTangent, bUpdateMesh);
		
		
		/// <summary>
		/// Get the start scaling
		/// </summary>
		public FVector2D GetStartScale()
			=> E_USplineMeshComponent_GetStartScale(NativePointer);
		
		
		/// <summary>
		/// Set the start scaling
		/// </summary>
		public void SetStartScale(FVector2D StartScale, bool bUpdateMesh = true)
			=> E_USplineMeshComponent_SetStartScale(NativePointer, StartScale, bUpdateMesh);
		
		
		/// <summary>
		/// Get the start roll
		/// </summary>
		public float GetStartRoll()
			=> E_USplineMeshComponent_GetStartRoll(NativePointer);
		
		
		/// <summary>
		/// Set the start roll
		/// </summary>
		public void SetStartRoll(float StartRoll, bool bUpdateMesh = true)
			=> E_USplineMeshComponent_SetStartRoll(NativePointer, StartRoll, bUpdateMesh);
		
		
		/// <summary>
		/// Set the spline up direction
		/// </summary>
		public void SetSplineUpDir(FVector InSplineUpDir, bool bUpdateMesh = true)
			=> E_USplineMeshComponent_SetSplineUpDir(NativePointer, InSplineUpDir, bUpdateMesh);
		
		
		/// <summary>
		/// Calculates the spline transform, including roll, scale, and offset along the spline at a specified distance
		/// </summary>
		public FTransform CalcSliceTransform(float DistanceAlong)
			=> E_USplineMeshComponent_CalcSliceTransform(NativePointer, DistanceAlong);
		
		#endregion
		
		public static implicit operator IntPtr(USplineMeshComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator USplineMeshComponent(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new USplineMeshComponent(Adress);
		}}}
