using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// Transform composed of Scale, Rotation (as a quaternion), and Translation.
	/// Transforms can be used to convert from one space to another, for example by transforming
	/// positions and directions from local space to world space.
	/// Transformation of position vectors is applied in the order:  Scale -> Rotate -> Translate.
	/// Transformation of direction vectors is applied in the order: Scale -> Rotate.
	/// Order matters when composing transforms: C = A * B will yield a transform C that logically
	/// first applies A then B to any subsequent transformation. Note that this is the opposite order of quaternion (FQuat) multiplication.
	/// Example: LocalToWorld = (DeltaRotation * LocalToWorld) will change rotation in local space by DeltaRotation.
	/// Example: LocalToWorld = (LocalToWorld * DeltaRotation) will change rotation in world space by DeltaRotation.
	/// </summary>
	public partial class FTransform
	{
		private readonly IntPtr NativePointer;
		private readonly bool IsRef;
		
		public FTransform()
		{
			NativePointer = E_CreateStruct_FTransform();
			IsRef = false;
		}

		internal FTransform(IntPtr NativePointer, bool IsRef)
		{
			this.NativePointer = NativePointer;
			this.IsRef = IsRef;
		}

		
		#region DLLInmport
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern IntPtr E_CreateStruct_FTransform();
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_DeleteStruct(IntPtr Adress);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_FTransform_DiagnosticCheckNaN_Scale3D(FTransform Self);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern IntPtr E_FTransform_Inverse(FTransform Self);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_FTransform_Blend(FTransform Self, IntPtr Atom1, IntPtr Atom2, float Alpha);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_FTransform_BlendWith(FTransform Self, IntPtr OtherAtom, float Alpha);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern IntPtr E_OPER_FTransform_p(FTransform Self, IntPtr Atom);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern bool E_FTransform_AnyHasNegativeScale(FTransform Self, IntPtr InScale3D, IntPtr InOtherScale3D);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_FTransform_RemoveScaling(FTransform Self, float Tolerance);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern float E_FTransform_GetMaximumAxisScale(FTransform Self);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern IntPtr E_FTransform_TransformFVector4(FTransform Self, IntPtr V);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern IntPtr E_FTransform_TransformPosition(FTransform Self, IntPtr V);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern IntPtr E_FTransform_GetSafeScaleReciprocal(FTransform Self, IntPtr InScale, float Tolerance);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern IntPtr E_FTransform_GetLocation(FTransform Self);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern IntPtr E_FTransform_Rotator(FTransform Self);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern bool E_FTransform_ContainsNaN(FTransform Self);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern bool E_FTransform_AreRotationsEqual(FTransform Self, IntPtr A, IntPtr B, float Tolerance);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern bool E_FTransform_RotationEquals(FTransform Self, IntPtr Other, float Tolerance);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_FTransform_Multiply(FTransform Self, IntPtr OutTransform, IntPtr A, IntPtr B);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_FTransform_SetComponents(FTransform Self, IntPtr InRotation, IntPtr InTranslation, IntPtr InScale3D);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_FTransform_SetIdentity(FTransform Self);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern IntPtr E_FTransform_AddTranslations(FTransform Self, IntPtr A, IntPtr B);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_FTransform_SetTranslationAndScale3D(FTransform Self, IntPtr NewTranslation, IntPtr NewScale3D);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern IntPtr E_FTransform_GetRotation(FTransform Self);
		
		#endregion
		
		#region Property
		#endregion
		
		#region ExternMethods
		public void DiagnosticCheckNaN_Scale3D()
			=> E_FTransform_DiagnosticCheckNaN_Scale3D(this);
		
		
		/// <summary>
		/// Convert this Transform to inverse.
		/// </summary>
		public FTransform Inverse()
			=> E_FTransform_Inverse(this);
		
		
		/// <summary>
		/// Set this transform to the weighted blend of the supplied two transforms.
		/// </summary>
		public void Blend(FTransform Atom1, FTransform Atom2, float Alpha)
			=> E_FTransform_Blend(this, Atom1, Atom2, Alpha);
		
		
		/// <summary>
		/// Set this Transform to the weighted blend of it and the supplied Transform.
		/// </summary>
		public void BlendWith(FTransform OtherAtom, float Alpha)
			=> E_FTransform_BlendWith(this, OtherAtom, Alpha);
		
		
		/// <summary>
		/// Quaternion addition is wrong here. This is just a special case for linear interpolation.
		/// Use only within blends!!
		/// Rotation part is NOT normalized!!
		/// </summary>
		public static FTransform operator+(FTransform Self, FTransform Atom)
			=> E_OPER_FTransform_p(Self, Atom);
		
		public bool AnyHasNegativeScale(FVector InScale3D, FVector InOtherScale3D)
			=> E_FTransform_AnyHasNegativeScale(this, InScale3D, InOtherScale3D);
		
		public void RemoveScaling(float Tolerance)
			=> E_FTransform_RemoveScaling(this, Tolerance);
		
		public float GetMaximumAxisScale()
			=> E_FTransform_GetMaximumAxisScale(this);
		
		public FVector4 TransformFVector4(FVector4 V)
			=> E_FTransform_TransformFVector4(this, V);
		
		public FVector TransformPosition(FVector V)
			=> E_FTransform_TransformPosition(this, V);
		
		public FVector GetSafeScaleReciprocal(FVector InScale, float Tolerance)
			=> E_FTransform_GetSafeScaleReciprocal(this, InScale, Tolerance);
		
		public FVector GetLocation()
			=> E_FTransform_GetLocation(this);
		
		public FRotator Rotator()
			=> E_FTransform_Rotator(this);
		
		
		/// <summary>
		/// Checks the components for NaN's
		/// @return Returns true if any component (rotation, translation, or scale) is a NAN
		/// </summary>
		public bool ContainsNaN()
			=> E_FTransform_ContainsNaN(this);
		
		public bool AreRotationsEqual(FTransform A, FTransform B, float Tolerance)
			=> E_FTransform_AreRotationsEqual(this, A, B, Tolerance);
		
		public bool RotationEquals(FTransform Other, float Tolerance)
			=> E_FTransform_RotationEquals(this, Other, Tolerance);
		
		public void Multiply(FTransform OutTransform, FTransform A, FTransform B)
			=> E_FTransform_Multiply(this, OutTransform, A, B);
		
		
		/// <summary>
		/// Sets the components
		/// @param InRotation The new value for the Rotation component
		/// @param InTranslation The new value for the Translation component
		/// @param InScale3D The new value for the Scale3D component
		/// </summary>
		public void SetComponents(FQuat InRotation, FVector InTranslation, FVector InScale3D)
			=> E_FTransform_SetComponents(this, InRotation, InTranslation, InScale3D);
		
		
		/// <summary>
		/// Sets the components to the identity transform:
		/// Rotation = (0,0,0,1)
		/// Translation = (0,0,0)
		/// Scale3D = (1,1,1)
		/// </summary>
		public void SetIdentity()
			=> E_FTransform_SetIdentity(this);
		
		
		/// <summary>
		/// Add the translations from two FTransforms and return the result.
		/// @return A.Translation + B.Translation
		/// </summary>
		public FVector AddTranslations(FTransform A, FTransform B)
			=> E_FTransform_AddTranslations(this, A, B);
		
		
		/// <summary>
		/// Sets both the translation and Scale3D components at the same time
		/// @param NewTranslation The new value for the translation component
		/// @param NewScale3D The new value for the Scale3D component
		/// </summary>
		public void SetTranslationAndScale3D(FVector NewTranslation, FVector NewScale3D)
			=> E_FTransform_SetTranslationAndScale3D(this, NewTranslation, NewScale3D);
		
		
		/// <summary>
		/// Returns the rotation component
		/// @return The rotation component
		/// </summary>
		public FQuat GetRotation()
			=> E_FTransform_GetRotation(this);
		
		#endregion
		
		public static implicit operator IntPtr(FTransform Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FTransform(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FTransform(Adress, false);
		}}}
