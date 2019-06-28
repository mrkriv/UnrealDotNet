// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Core\Public\Math\TransformVectorized.h:36

namespace UnrealEngine
{
	public partial class FTransform : NativeStructWrapper
	{
		public FTransform(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		
		/// <summary>
		/// Constructor with initialization to the identity transform.
		/// </summary>
		public FTransform() :
			base(E_CreateStruct_FTransform(), false)
		{
		}

		
		/// <summary>
		/// Constructor with an initial translation
		/// </summary>
		/// <param name="inTranslation">The value to use for the translation component</param>
		public FTransform(FVector inTranslation) :
			base(E_CreateStruct_FTransform_FVector(inTranslation), false)
		{
		}

		
		/// <summary>
		/// Constructor with an initial rotation
		/// </summary>
		/// <param name="inRotation">The value to use for rotation component</param>
		public FTransform(FQuat inRotation) :
			base(E_CreateStruct_FTransform_FQuat(inRotation), false)
		{
		}

		
		/// <summary>
		/// Constructor with an initial rotation
		/// </summary>
		/// <param name="inRotation">The value to use for rotation component  (after being converted to a quaternion)</param>
		public FTransform(FRotator inRotation) :
			base(E_CreateStruct_FTransform_FRotator(inRotation), false)
		{
		}

		
		/// <summary>
		/// Constructor with all components initialized
		/// </summary>
		/// <param name="inRotation">The value to use for rotation component</param>
		/// <param name="inTranslation">The value to use for the translation component</param>
		/// <param name="inScale3D">The value to use for the scale component</param>
		public FTransform(FQuat inRotation, FVector inTranslation, FVector inScale3D) :
			base(E_CreateStruct_FTransform_FQuat_FVector_FVector(inRotation, inTranslation, inScale3D), false)
		{
		}

		
		/// <summary>
		/// Constructor with all components initialized, taking a FRotator as the rotation component
		/// </summary>
		/// <param name="inRotation">The value to use for rotation component (after being converted to a quaternion)</param>
		/// <param name="inTranslation">The value to use for the translation component</param>
		/// <param name="inScale3D">The value to use for the scale component</param>
		public FTransform(FRotator inRotation, FVector inTranslation, FVector inScale3D) :
			base(E_CreateStruct_FTransform_FRotator_FVector_FVector(inRotation, inTranslation, inScale3D), false)
		{
		}

		
		/// <summary>
		/// Copy-constructor
		/// </summary>
		/// <param name="inTransform">The source transform from which all components will be copied</param>
		public FTransform(FTransform inTransform) :
			base(E_CreateStruct_FTransform_FTransform(inTransform), false)
		{
		}

		
		/// <summary>
		/// Constructor for converting a Matrix (including scale) into a FTransform.
		/// </summary>
		public FTransform(FMatrix inMatrix) :
			base(E_CreateStruct_FTransform_FMatrix(inMatrix), false)
		{
		}

		
		/// <summary>
		/// Constructor that takes basis axes and translation
		/// </summary>
		public FTransform(FVector inX, FVector inY, FVector inZ, FVector inTranslation) :
			base(E_CreateStruct_FTransform_FVector_FVector_FVector_FVector(inX, inY, inZ, inTranslation), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FTransform_Identity_GET();
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FTransform();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FTransform_FVector(IntPtr inTranslation);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FTransform_FQuat(IntPtr inRotation);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FTransform_FRotator(IntPtr inRotation);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FTransform_FQuat_FVector_FVector(IntPtr inRotation, IntPtr inTranslation, IntPtr inScale3D);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FTransform_FRotator_FVector_FVector(IntPtr inRotation, IntPtr inTranslation, IntPtr inScale3D);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FTransform_FTransform(IntPtr inTransform);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FTransform_FMatrix(IntPtr inMatrix);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FTransform_FVector_FVector_FVector_FVector(IntPtr inX, IntPtr inY, IntPtr inZ, IntPtr inTranslation);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FTransform_Accumulate(IntPtr self, IntPtr sourceAtom);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FTransform_AddToTranslation(IntPtr self, IntPtr deltaTranslation);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FTransform_AddTranslations(IntPtr self, IntPtr a, IntPtr b);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FTransform_AnyHasNegativeScale(IntPtr self, IntPtr inScale3D, IntPtr inOtherScale3D);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FTransform_AreRotationsEqual(IntPtr self, IntPtr a, IntPtr b, float tolerance);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FTransform_AreScale3DsEqual(IntPtr self, IntPtr a, IntPtr b, float tolerance);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FTransform_AreTranslationsEqual(IntPtr self, IntPtr a, IntPtr b, float tolerance);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FTransform_Blend(IntPtr self, IntPtr atom1, IntPtr atom2, float alpha);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FTransform_BlendWith(IntPtr self, IntPtr otherAtom, float alpha);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FTransform_ConcatenateRotation(IntPtr self, IntPtr deltaRotation);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FTransform_ContainsNaN(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FTransform_CopyRotation(IntPtr self, IntPtr other);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FTransform_CopyRotationPart(IntPtr self, IntPtr srcBA);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FTransform_CopyScale3D(IntPtr self, IntPtr other);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FTransform_CopyTranslation(IntPtr self, IntPtr other);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FTransform_CopyTranslationAndScale3D(IntPtr self, IntPtr srcBA);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FTransform_DebugPrint(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FTransform_DiagnosticCheck_IsValid(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FTransform_DiagnosticCheckNaN_All(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FTransform_DiagnosticCheckNaN_Rotate(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FTransform_DiagnosticCheckNaN_Scale3D(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FTransform_DiagnosticCheckNaN_Translate(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FTransform_Equals(IntPtr self, IntPtr other, float tolerance);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FTransform_EqualsNoScale(IntPtr self, IntPtr other, float tolerance);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FTransform_GetDeterminant(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FTransform_GetLocation(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FTransform_GetMaximumAxisScale(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FTransform_GetMinimumAxisScale(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FTransform_GetRelativeTransform(IntPtr self, IntPtr other);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FTransform_GetRelativeTransformReverse(IntPtr self, IntPtr other);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FTransform_GetRotation(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FTransform_GetSafeScaleReciprocal(IntPtr self, IntPtr inScale, float tolerance);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FTransform_GetScale3D(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FTransform_GetScaled(IntPtr self, float scale);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FTransform_GetScaled_o1(IntPtr self, IntPtr scale);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FTransform_GetTranslation(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FTransform_InitFromString(IntPtr self, string inSourceString);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FTransform_Inverse(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FTransform_InverseTransformPosition(IntPtr self, IntPtr v);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FTransform_InverseTransformPositionNoScale(IntPtr self, IntPtr v);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FTransform_InverseTransformRotation(IntPtr self, IntPtr q);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FTransform_InverseTransformVector(IntPtr self, IntPtr v);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FTransform_InverseTransformVectorNoScale(IntPtr self, IntPtr v);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FTransform_IsRotationNormalized(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FTransform_IsValid(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FTransform_Multiply(IntPtr self, IntPtr outTransform, IntPtr a, IntPtr b);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FTransform_MultiplyScale3D(IntPtr self, IntPtr scale3DMultiplier);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FTransform_NormalizeRotation(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FTransform_RemoveScaling(IntPtr self, float tolerance);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FTransform_RotationEquals(IntPtr self, IntPtr other, float tolerance);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FTransform_Rotator(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FTransform_Scale3DEquals(IntPtr self, IntPtr other, float tolerance);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FTransform_ScaleTranslation(IntPtr self, IntPtr inScale3D);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FTransform_ScaleTranslation_o1(IntPtr self, float scale);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FTransform_SetComponents(IntPtr self, IntPtr inRotation, IntPtr inTranslation, IntPtr inScale3D);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FTransform_SetFromMatrix(IntPtr self, IntPtr inMatrix);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FTransform_SetIdentity(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FTransform_SetLocation(IntPtr self, IntPtr origin);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FTransform_SetRotation(IntPtr self, IntPtr newRotation);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FTransform_SetScale3D(IntPtr self, IntPtr newScale3D);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FTransform_SetToRelativeTransform(IntPtr self, IntPtr parentTransform);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FTransform_SetTranslation(IntPtr self, IntPtr newTranslation);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FTransform_SetTranslationAndScale3D(IntPtr self, IntPtr newTranslation, IntPtr newScale3D);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FTransform_SubtractTranslations(IntPtr self, IntPtr a, IntPtr b);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_FTransform_ToHumanReadableString(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FTransform_ToInverseMatrixWithScale(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FTransform_ToMatrixNoScale(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FTransform_ToMatrixWithScale(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_FTransform_ToString(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FTransform_TransformFVector4(IntPtr self, IntPtr v);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FTransform_TransformFVector4NoScale(IntPtr self, IntPtr v);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FTransform_TransformPosition(IntPtr self, IntPtr v);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FTransform_TransformPositionNoScale(IntPtr self, IntPtr v);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FTransform_TransformRotation(IntPtr self, IntPtr q);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FTransform_TransformVector(IntPtr self, IntPtr v);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FTransform_TransformVectorNoScale(IntPtr self, IntPtr v);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FTransform_TranslationEquals(IntPtr self, IntPtr other, float tolerance);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// The identity transformation (Rotation = FQuat::Identity, Translation = FVector::ZeroVector, Scale3D = (1,1,1))
		/// </summary>
		public static FTransform Identity
		{
			get => E_PROP_FTransform_Identity_GET();
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Accumulates another transform with this one
		/// <para>Rotation is accumulated multiplicatively (Rotation = SourceAtom.Rotation * Rotation) </para>
		/// Translation is accumulated additively (Translation += SourceAtom.Translation)
		/// <para>Scale3D is accumulated multiplicatively (Scale3D *= SourceAtom.Scale3D) </para>
		/// </summary>
		/// <param name="sourceAtom">The other transform to accumulate into this one</param>
		public void Accumulate(FTransform sourceAtom)
			=> E_FTransform_Accumulate(this, sourceAtom);
		
		
		/// <summary>
		/// Adjusts the translation component of this transformation
		/// </summary>
		/// <param name="deltaTranslation">The translation to add in the following fashion: Translation += DeltaTranslation</param>
		public void AddToTranslation(FVector deltaTranslation)
			=> E_FTransform_AddToTranslation(this, deltaTranslation);
		
		
		/// <summary>
		/// Add the translations from two FTransforms and return the result.
		/// </summary>
		/// <return>A</return>
		public FVector AddTranslations(FTransform a, FTransform b)
			=> E_FTransform_AddTranslations(this, a, b);
		
		public bool AnyHasNegativeScale(FVector inScale3D, FVector inOtherScale3D)
			=> E_FTransform_AnyHasNegativeScale(this, inScale3D, inOtherScale3D);
		
		public bool AreRotationsEqual(FTransform a, FTransform b, float tolerance)
			=> E_FTransform_AreRotationsEqual(this, a, b, tolerance);
		
		public bool AreScale3DsEqual(FTransform a, FTransform b, float tolerance)
			=> E_FTransform_AreScale3DsEqual(this, a, b, tolerance);
		
		public bool AreTranslationsEqual(FTransform a, FTransform b, float tolerance)
			=> E_FTransform_AreTranslationsEqual(this, a, b, tolerance);
		
		
		/// <summary>
		/// Set this transform to the weighted blend of the supplied two transforms.
		/// </summary>
		public void Blend(FTransform atom1, FTransform atom2, float alpha)
			=> E_FTransform_Blend(this, atom1, atom2, alpha);
		
		
		/// <summary>
		/// Set this Transform to the weighted blend of it and the supplied Transform.
		/// </summary>
		public void BlendWith(FTransform otherAtom, float alpha)
			=> E_FTransform_BlendWith(this, otherAtom, alpha);
		
		
		/// <summary>
		/// Concatenates another rotation to this transformation
		/// </summary>
		/// <param name="deltaRotation">The rotation to concatenate in the following fashion: Rotation = Rotation * DeltaRotation</param>
		public void ConcatenateRotation(FQuat deltaRotation)
			=> E_FTransform_ConcatenateRotation(this, deltaRotation);
		
		
		/// <summary>
		/// Checks the components for NaN's
		/// </summary>
		/// <return>Returns</return>
		public bool ContainsNaN()
			=> E_FTransform_ContainsNaN(this);
		
		
		/// <summary>
		/// Copy rotation from another FTransform.
		/// </summary>
		public void CopyRotation(FTransform other)
			=> E_FTransform_CopyRotation(this, other);
		
		
		/// <summary>
		/// Sets the Rotation and Scale3D of this transformation from another transform
		/// </summary>
		/// <param name="srcBA">The transform to copy rotation and Scale3D from</param>
		public void CopyRotationPart(FTransform srcBA)
			=> E_FTransform_CopyRotationPart(this, srcBA);
		
		
		/// <summary>
		/// Copy scale from another FTransform.
		/// </summary>
		public void CopyScale3D(FTransform other)
			=> E_FTransform_CopyScale3D(this, other);
		
		
		/// <summary>
		/// Copy translation from another FTransform.
		/// </summary>
		public void CopyTranslation(FTransform other)
			=> E_FTransform_CopyTranslation(this, other);
		
		
		/// <summary>
		/// Sets the Translation and Scale3D of this transformation from another transform
		/// </summary>
		/// <param name="srcBA">The transform to copy translation and Scale3D from</param>
		public void CopyTranslationAndScale3D(FTransform srcBA)
			=> E_FTransform_CopyTranslationAndScale3D(this, srcBA);
		
		
		/// <summary>
		/// Does a debugf of the contents of this Transform.
		/// </summary>
		public void DebugPrint()
			=> E_FTransform_DebugPrint(this);
		
		public void DiagnosticCheck_IsValid()
			=> E_FTransform_DiagnosticCheck_IsValid(this);
		
		public void DiagnosticCheckNaN_All()
			=> E_FTransform_DiagnosticCheckNaN_All(this);
		
		public void DiagnosticCheckNaN_Rotate()
			=> E_FTransform_DiagnosticCheckNaN_Rotate(this);
		
		public void DiagnosticCheckNaN_Scale3D()
			=> E_FTransform_DiagnosticCheckNaN_Scale3D(this);
		
		public void DiagnosticCheckNaN_Translate()
			=> E_FTransform_DiagnosticCheckNaN_Translate(this);
		
		public bool Equals(FTransform other, float tolerance)
			=> E_FTransform_Equals(this, other, tolerance);
		
		public bool EqualsNoScale(FTransform other, float tolerance)
			=> E_FTransform_EqualsNoScale(this, other, tolerance);
		
		
		/// <summary>
		/// Calculate the
		/// </summary>
		public float GetDeterminant()
			=> E_FTransform_GetDeterminant(this);
		
		public FVector GetLocation()
			=> E_FTransform_GetLocation(this);
		
		public float GetMaximumAxisScale()
			=> E_FTransform_GetMaximumAxisScale(this);
		
		public float GetMinimumAxisScale()
			=> E_FTransform_GetMinimumAxisScale(this);
		
		
		/// <summary>
		/// The below 2 functions are the ones to get delta transform and return FTransform format that can be concatenated
		/// <para>Inverse itself can't concatenate with VQS format(since VQS always transform from S->Q->T, where inverse happens from T(-1)->Q(-1)->S(-1)) </para>
		/// So these 2 provides ways to fix this
		/// <para>GetRelativeTransform returns this*Other(-1) and parameter is Other(not Other(-1)) </para>
		/// GetRelativeTransformReverse returns this(-1)*Other, and parameter is Other.
		/// </summary>
		public FTransform GetRelativeTransform(FTransform other)
			=> E_FTransform_GetRelativeTransform(this, other);
		
		public FTransform GetRelativeTransformReverse(FTransform other)
			=> E_FTransform_GetRelativeTransformReverse(this, other);
		
		
		/// <summary>
		/// Returns the rotation component
		/// </summary>
		/// <return>The</return>
		public FQuat GetRotation()
			=> E_FTransform_GetRotation(this);
		
		public FVector GetSafeScaleReciprocal(FVector inScale, float tolerance)
			=> E_FTransform_GetSafeScaleReciprocal(this, inScale, tolerance);
		
		
		/// <summary>
		/// Returns the Scale3D component
		/// </summary>
		/// <return>The</return>
		public FVector GetScale3D()
			=> E_FTransform_GetScale3D(this);
		
		public FTransform GetScaled(float scale)
			=> E_FTransform_GetScaled(this, scale);
		
		public FTransform GetScaled(FVector scale)
			=> E_FTransform_GetScaled_o1(this, scale);
		
		
		/// <summary>
		/// Returns the translation component
		/// </summary>
		/// <return>The</return>
		public FVector GetTranslation()
			=> E_FTransform_GetTranslation(this);
		
		
		/// <summary>
		/// Acceptable form: "%f,%f,%f|%f,%f,%f|%f,%f,%f"
		/// </summary>
		public bool InitFromString(string inSourceString)
			=> E_FTransform_InitFromString(this, inSourceString);
		
		
		/// <summary>
		/// Convert this Transform to inverse.
		/// </summary>
		public FTransform Inverse()
			=> E_FTransform_Inverse(this);
		
		
		/// <summary>
		/// Inverts the transform and then transforms V - correctly handles scaling in this transform.
		/// </summary>
		public FVector InverseTransformPosition(FVector v)
			=> E_FTransform_InverseTransformPosition(this, v);
		
		public FVector InverseTransformPositionNoScale(FVector v)
			=> E_FTransform_InverseTransformPositionNoScale(this, v);
		
		
		/// <summary>
		/// Inverse transform a rotation.
		/// <para>For example if this is a LocalToWorld transform, InverseTransformRotation(Q) would transform Q from world to local space. </para>
		/// </summary>
		public FQuat InverseTransformRotation(FQuat q)
			=> E_FTransform_InverseTransformRotation(this, q);
		
		
		/// <summary>
		/// Transform a direction vector by the inverse of this matrix - will not take into account translation part.
		/// <para>If you want to transform a surface normal (or plane) and correctly account for non-uniform scaling you should use TransformByUsingAdjointT with adjoint of matrix inverse. </para>
		/// </summary>
		public FVector InverseTransformVector(FVector v)
			=> E_FTransform_InverseTransformVector(this, v);
		
		public FVector InverseTransformVectorNoScale(FVector v)
			=> E_FTransform_InverseTransformVectorNoScale(this, v);
		
		
		/// <summary>
		/// Checks whether the rotation component is normalized or not
		/// </summary>
		/// <return>true</return>
		public bool IsRotationNormalized()
			=> E_FTransform_IsRotationNormalized(this);
		
		public bool IsValid()
			=> E_FTransform_IsValid(this);
		
		public void Multiply(FTransform outTransform, FTransform a, FTransform b)
			=> E_FTransform_Multiply(this, outTransform, a, b);
		
		
		/// <summary>
		/// Scales the Scale3D component by a new factor
		/// </summary>
		/// <param name="scale3DMultiplier">The value to multiply Scale3D with</param>
		public void MultiplyScale3D(FVector scale3DMultiplier)
			=> E_FTransform_MultiplyScale3D(this, scale3DMultiplier);
		
		
		/// <summary>
		/// Normalize the rotation component of this transformation
		/// </summary>
		public void NormalizeRotation()
			=> E_FTransform_NormalizeRotation(this);
		
		public void RemoveScaling(float tolerance)
			=> E_FTransform_RemoveScaling(this, tolerance);
		
		public bool RotationEquals(FTransform other, float tolerance)
			=> E_FTransform_RotationEquals(this, other, tolerance);
		
		public FRotator Rotator()
			=> E_FTransform_Rotator(this);
		
		public bool Scale3DEquals(FTransform other, float tolerance)
			=> E_FTransform_Scale3DEquals(this, other, tolerance);
		
		public void ScaleTranslation(FVector inScale3D)
			=> E_FTransform_ScaleTranslation(this, inScale3D);
		
		public void ScaleTranslation(float scale)
			=> E_FTransform_ScaleTranslation_o1(this, scale);
		
		
		/// <summary>
		/// Sets the components
		/// </summary>
		/// <param name="inRotation">The new value for the Rotation component</param>
		/// <param name="inTranslation">The new value for the Translation component</param>
		/// <param name="inScale3D">The new value for the Scale3D component</param>
		public void SetComponents(FQuat inRotation, FVector inTranslation, FVector inScale3D)
			=> E_FTransform_SetComponents(this, inRotation, inTranslation, inScale3D);
		
		public void SetFromMatrix(FMatrix inMatrix)
			=> E_FTransform_SetFromMatrix(this, inMatrix);
		
		
		/// <summary>
		/// Sets the components to the identity transform:
		/// <para>Rotation = (0,0,0,1) </para>
		/// Translation = (0,0,0)
		/// <para>Scale3D = (1,1,1) </para>
		/// </summary>
		public void SetIdentity()
			=> E_FTransform_SetIdentity(this);
		
		
		/// <summary>
		/// Set the translation of this transformation
		/// </summary>
		public void SetLocation(FVector origin)
			=> E_FTransform_SetLocation(this, origin);
		
		
		/// <summary>
		/// Sets the rotation component
		/// </summary>
		/// <param name="newRotation">The new value for the rotation component</param>
		public void SetRotation(FQuat newRotation)
			=> E_FTransform_SetRotation(this, newRotation);
		
		
		/// <summary>
		/// Sets the Scale3D component
		/// </summary>
		/// <param name="newScale3D">The new value for the Scale3D component</param>
		public void SetScale3D(FVector newScale3D)
			=> E_FTransform_SetScale3D(this, newScale3D);
		
		
		/// <summary>
		/// Set current transform and the relative to ParentTransform.
		/// <para>Equates to This = This->GetRelativeTransform(Parent), but saves the intermediate FTransform storage and copy. </para>
		/// </summary>
		public void SetToRelativeTransform(FTransform parentTransform)
			=> E_FTransform_SetToRelativeTransform(this, parentTransform);
		
		
		/// <summary>
		/// Sets the translation component
		/// </summary>
		/// <param name="newTranslation">The new value for the translation component</param>
		public void SetTranslation(FVector newTranslation)
			=> E_FTransform_SetTranslation(this, newTranslation);
		
		
		/// <summary>
		/// Sets both the translation and Scale3D components at the same time
		/// </summary>
		/// <param name="newTranslation">The new value for the translation component</param>
		/// <param name="newScale3D">The new value for the Scale3D component</param>
		public void SetTranslationAndScale3D(FVector newTranslation, FVector newScale3D)
			=> E_FTransform_SetTranslationAndScale3D(this, newTranslation, newScale3D);
		
		
		/// <summary>
		/// Subtract translations from two FTransforms and return the difference.
		/// </summary>
		/// <return>A</return>
		public FVector SubtractTranslations(FTransform a, FTransform b)
			=> E_FTransform_SubtractTranslations(this, a, b);
		
		
		/// <summary>
		/// Convert FTransform contents to a string
		/// </summary>
		public string ToHumanReadableString()
			=> E_FTransform_ToHumanReadableString(this);
		
		
		/// <summary>
		/// Convert this Transform to matrix with scaling and compute the inverse of that.
		/// </summary>
		public FMatrix ToInverseMatrixWithScale()
			=> E_FTransform_ToInverseMatrixWithScale(this);
		
		
		/// <summary>
		/// Convert this Transform to a transformation matrix, ignoring its scaling
		/// </summary>
		public FMatrix ToMatrixNoScale()
			=> E_FTransform_ToMatrixNoScale(this);
		
		public FMatrix ToMatrixWithScale()
			=> E_FTransform_ToMatrixWithScale(this);
		
		public override string ToString()
			=> E_FTransform_ToString(this);
		
		public FVector4 TransformFVector4(FVector4 v)
			=> E_FTransform_TransformFVector4(this, v);
		
		public FVector4 TransformFVector4NoScale(FVector4 v)
			=> E_FTransform_TransformFVector4NoScale(this, v);
		
		public FVector TransformPosition(FVector v)
			=> E_FTransform_TransformPosition(this, v);
		
		public FVector TransformPositionNoScale(FVector v)
			=> E_FTransform_TransformPositionNoScale(this, v);
		
		
		/// <summary>
		/// Transform a rotation.
		/// <para>For example if this is a LocalToWorld transform, TransformRotation(Q) would transform Q from local to world space. </para>
		/// </summary>
		public FQuat TransformRotation(FQuat q)
			=> E_FTransform_TransformRotation(this, q);
		
		public FVector TransformVector(FVector v)
			=> E_FTransform_TransformVector(this, v);
		
		public FVector TransformVectorNoScale(FVector v)
			=> E_FTransform_TransformVectorNoScale(this, v);
		
		public bool TranslationEquals(FTransform other, float tolerance)
			=> E_FTransform_TranslationEquals(this, other, tolerance);
		
		#endregion
		
		public static implicit operator IntPtr(FTransform self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FTransform(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FTransform(adress, false);
		}}}
