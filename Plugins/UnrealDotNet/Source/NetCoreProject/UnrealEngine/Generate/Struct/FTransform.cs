using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class FTransform : NativeStructWrapper
	{
		internal FTransform(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		
		/// <summary>
		/// <para>Constructor with initialization to the identity transform. </para>
		/// </summary>
		public FTransform() :
			base(E_CreateStruct_FTransform(), false)
		{
		}

		
		/// <summary>
		/// <para>Constructor with an initial translation </para>
		/// <param name="InTranslation">The value to use for the translation component </param>
		/// </summary>
		public FTransform(FVector InTranslation) :
			base(E_CreateStruct_FTransform_FVector(InTranslation), false)
		{
		}

		
		/// <summary>
		/// <para>Constructor with an initial rotation </para>
		/// <param name="InRotation">The value to use for rotation component </param>
		/// </summary>
		public FTransform(FQuat InRotation) :
			base(E_CreateStruct_FTransform_FQuat(InRotation), false)
		{
		}

		
		/// <summary>
		/// <para>Constructor with an initial rotation </para>
		/// <param name="InRotation">The value to use for rotation component  (after being converted to a quaternion) </param>
		/// </summary>
		public FTransform(FRotator InRotation) :
			base(E_CreateStruct_FTransform_FRotator(InRotation), false)
		{
		}

		
		/// <summary>
		/// <para>Constructor with all components initialized </para>
		/// <param name="InRotation">The value to use for rotation component </param>
		/// <param name="InTranslation">The value to use for the translation component </param>
		/// <param name="InScale3D">The value to use for the scale component </param>
		/// </summary>
		public FTransform(FQuat InRotation, FVector InTranslation, FVector InScale3D) :
			base(E_CreateStruct_FTransform_FQuat_FVector_FVector(InRotation, InTranslation, InScale3D), false)
		{
		}

		
		/// <summary>
		/// <para>Constructor with all components initialized, taking a FRotator as the rotation component </para>
		/// <param name="InRotation">The value to use for rotation component (after being converted to a quaternion) </param>
		/// <param name="InTranslation">The value to use for the translation component </param>
		/// <param name="InScale3D">The value to use for the scale component </param>
		/// </summary>
		public FTransform(FRotator InRotation, FVector InTranslation, FVector InScale3D) :
			base(E_CreateStruct_FTransform_FRotator_FVector_FVector(InRotation, InTranslation, InScale3D), false)
		{
		}

		
		/// <summary>
		/// <para>Copy-constructor </para>
		/// <param name="InTransform">The source transform from which all components will be copied </param>
		/// </summary>
		public FTransform(FTransform InTransform) :
			base(E_CreateStruct_FTransform_FTransform(InTransform), false)
		{
		}

		
		/// <summary>
		/// <para>Constructor that takes basis axes and translation </para>
		/// </summary>
		public FTransform(FVector InX, FVector InY, FVector InZ, FVector InTranslation) :
			base(E_CreateStruct_FTransform_FVector_FVector_FVector_FVector(InX, InY, InZ, InTranslation), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FTransform();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FTransform_FVector(IntPtr InTranslation);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FTransform_FQuat(IntPtr InRotation);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FTransform_FRotator(IntPtr InRotation);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FTransform_FQuat_FVector_FVector(IntPtr InRotation, IntPtr InTranslation, IntPtr InScale3D);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FTransform_FRotator_FVector_FVector(IntPtr InRotation, IntPtr InTranslation, IntPtr InScale3D);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FTransform_FTransform(IntPtr InTransform);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FTransform_FVector_FVector_FVector_FVector(IntPtr InX, IntPtr InY, IntPtr InZ, IntPtr InTranslation);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FTransform_AddToTranslation(IntPtr Self, IntPtr DeltaTranslation);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FTransform_AddTranslations(IntPtr Self, IntPtr A, IntPtr B);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FTransform_AnyHasNegativeScale(IntPtr Self, IntPtr InScale3D, IntPtr InOtherScale3D);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FTransform_AreRotationsEqual(IntPtr Self, IntPtr A, IntPtr B, float Tolerance);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FTransform_AreScale3DsEqual(IntPtr Self, IntPtr A, IntPtr B, float Tolerance);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FTransform_AreTranslationsEqual(IntPtr Self, IntPtr A, IntPtr B, float Tolerance);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FTransform_Blend(IntPtr Self, IntPtr Atom1, IntPtr Atom2, float Alpha);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FTransform_BlendWith(IntPtr Self, IntPtr OtherAtom, float Alpha);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FTransform_ConcatenateRotation(IntPtr Self, IntPtr DeltaRotation);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FTransform_ContainsNaN(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FTransform_CopyRotation(IntPtr Self, IntPtr Other);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FTransform_CopyRotationPart(IntPtr Self, IntPtr SrcBA);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FTransform_CopyScale3D(IntPtr Self, IntPtr Other);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FTransform_CopyTranslation(IntPtr Self, IntPtr Other);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FTransform_CopyTranslationAndScale3D(IntPtr Self, IntPtr SrcBA);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FTransform_DebugPrint(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FTransform_DiagnosticCheck_IsValid(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FTransform_DiagnosticCheckNaN_All(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FTransform_DiagnosticCheckNaN_Rotate(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FTransform_DiagnosticCheckNaN_Scale3D(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FTransform_DiagnosticCheckNaN_Translate(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FTransform_Equals(IntPtr Self, IntPtr Other, float Tolerance);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FTransform_EqualsNoScale(IntPtr Self, IntPtr Other, float Tolerance);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FTransform_GetDeterminant(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FTransform_GetLocation(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FTransform_GetMaximumAxisScale(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FTransform_GetMinimumAxisScale(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FTransform_GetRelativeTransform(IntPtr Self, IntPtr Other);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FTransform_GetRelativeTransformReverse(IntPtr Self, IntPtr Other);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FTransform_GetRotation(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FTransform_GetRotationV(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FTransform_GetSafeScaleReciprocal(IntPtr Self, IntPtr InScale, float Tolerance);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FTransform_GetScale3D(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FTransform_GetScale3DV(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FTransform_GetTranslation(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FTransform_GetTranslationV(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FTransform_InitFromString(IntPtr Self, string InSourceString);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FTransform_Inverse(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FTransform_InverseTransformPosition(IntPtr Self, IntPtr V);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FTransform_InverseTransformPositionNoScale(IntPtr Self, IntPtr V);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FTransform_InverseTransformVector(IntPtr Self, IntPtr V);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FTransform_InverseTransformVectorNoScale(IntPtr Self, IntPtr V);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FTransform_IsRotationNormalized(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FTransform_IsValid(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FTransform_MultiplyScale3D(IntPtr Self, IntPtr Scale3DMultiplier);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FTransform_NormalizeRotation(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FTransform_RemoveScaling(IntPtr Self, float Tolerance);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FTransform_RotationEquals(IntPtr Self, IntPtr Other, float Tolerance);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FTransform_Rotator(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FTransform_Scale3DEquals(IntPtr Self, IntPtr Other, float Tolerance);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FTransform_SetComponents(IntPtr Self, IntPtr InRotation, IntPtr InTranslation, IntPtr InScale3D);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FTransform_SetIdentity(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FTransform_SetLocation(IntPtr Self, IntPtr Origin);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FTransform_SetRotation(IntPtr Self, IntPtr NewRotation);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FTransform_SetScale3D(IntPtr Self, IntPtr NewScale3D);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FTransform_SetToRelativeTransform(IntPtr Self, IntPtr ParentTransform);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FTransform_SetTranslation(IntPtr Self, IntPtr NewTranslation);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FTransform_SetTranslationAndScale3D(IntPtr Self, IntPtr NewTranslation, IntPtr NewScale3D);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FTransform_SubtractTranslations(IntPtr Self, IntPtr A, IntPtr B);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FTransform_ToHumanReadableString(IntPtr Self, out int ResultStringLen);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FTransform_ToString(IntPtr Self, out int ResultStringLen);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FTransform_TransformFVector4(IntPtr Self, IntPtr V);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FTransform_TransformFVector4NoScale(IntPtr Self, IntPtr V);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FTransform_TransformPosition(IntPtr Self, IntPtr V);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FTransform_TransformPositionNoScale(IntPtr Self, IntPtr V);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FTransform_TransformVector(IntPtr Self, IntPtr V);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FTransform_TransformVectorNoScale(IntPtr Self, IntPtr V);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FTransform_TranslationEquals(IntPtr Self, IntPtr Other, float Tolerance);
		
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// <para>Adjusts the translation component of this transformation </para>
		/// <param name="DeltaTranslation">The translation to add in the following fashion: Translation += DeltaTranslation </param>
		/// </summary>
		public void AddToTranslation(FVector DeltaTranslation)
			=> E_FTransform_AddToTranslation(this, DeltaTranslation);
		
		
		/// <summary>
		/// <para>Add the translations from two FTransforms and return the result. </para>
		/// <return>A.Translation + B.Translation </return>
		/// </summary>
		public FVector AddTranslations(FTransform A, FTransform B)
			=> E_FTransform_AddTranslations(this, A, B);
		
		public bool AnyHasNegativeScale(FVector InScale3D, FVector InOtherScale3D)
			=> E_FTransform_AnyHasNegativeScale(this, InScale3D, InOtherScale3D);
		
		public bool AreRotationsEqual(FTransform A, FTransform B, float Tolerance)
			=> E_FTransform_AreRotationsEqual(this, A, B, Tolerance);
		
		public bool AreScale3DsEqual(FTransform A, FTransform B, float Tolerance)
			=> E_FTransform_AreScale3DsEqual(this, A, B, Tolerance);
		
		public bool AreTranslationsEqual(FTransform A, FTransform B, float Tolerance)
			=> E_FTransform_AreTranslationsEqual(this, A, B, Tolerance);
		
		
		/// <summary>
		/// <para>Set this transform to the weighted blend of the supplied two transforms. </para>
		/// </summary>
		public void Blend(FTransform Atom1, FTransform Atom2, float Alpha)
			=> E_FTransform_Blend(this, Atom1, Atom2, Alpha);
		
		
		/// <summary>
		/// <para>Set this Transform to the weighted blend of it and the supplied Transform. </para>
		/// </summary>
		public void BlendWith(FTransform OtherAtom, float Alpha)
			=> E_FTransform_BlendWith(this, OtherAtom, Alpha);
		
		
		/// <summary>
		/// <para>Concatenates another rotation to this transformation </para>
		/// <param name="DeltaRotation">The rotation to concatenate in the following fashion: Rotation = Rotation * DeltaRotation </param>
		/// </summary>
		public void ConcatenateRotation(FQuat DeltaRotation)
			=> E_FTransform_ConcatenateRotation(this, DeltaRotation);
		
		
		/// <summary>
		/// <para>Checks the components for NaN's </para>
		/// <return>Returns true if any component (rotation, translation, or scale) is a NAN </return>
		/// </summary>
		public bool ContainsNaN()
			=> E_FTransform_ContainsNaN(this);
		
		
		/// <summary>
		/// <para>Copy rotation from another FTransform. </para>
		/// </summary>
		public void CopyRotation(FTransform Other)
			=> E_FTransform_CopyRotation(this, Other);
		
		
		/// <summary>
		/// <para>Sets the Rotation and Scale3D of this transformation from another transform </para>
		/// <param name="SrcBA">The transform to copy rotation and Scale3D from </param>
		/// </summary>
		public void CopyRotationPart(FTransform SrcBA)
			=> E_FTransform_CopyRotationPart(this, SrcBA);
		
		
		/// <summary>
		/// <para>Copy scale from another FTransform. </para>
		/// </summary>
		public void CopyScale3D(FTransform Other)
			=> E_FTransform_CopyScale3D(this, Other);
		
		
		/// <summary>
		/// <para>Copy translation from another FTransform. </para>
		/// </summary>
		public void CopyTranslation(FTransform Other)
			=> E_FTransform_CopyTranslation(this, Other);
		
		
		/// <summary>
		/// <para>Sets the Translation and Scale3D of this transformation from another transform </para>
		/// <param name="SrcBA">The transform to copy translation and Scale3D from </param>
		/// </summary>
		public void CopyTranslationAndScale3D(FTransform SrcBA)
			=> E_FTransform_CopyTranslationAndScale3D(this, SrcBA);
		
		
		/// <summary>
		/// <para>Does a debugf of the contents of this Transform. </para>
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
		
		public bool Equals(FTransform Other, float Tolerance)
			=> E_FTransform_Equals(this, Other, Tolerance);
		
		public bool EqualsNoScale(FTransform Other, float Tolerance)
			=> E_FTransform_EqualsNoScale(this, Other, Tolerance);
		
		
		/// <summary>
		/// <para>Calculate the </para>
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
		/// <para>The below 2 functions are the ones to get delta transform and return FTransform format that can be concatenated </para>
		/// <para>Inverse itself can't concatenate with VQS format(since VQS always transform from S->Q->T, where inverse happens from T(-1)->Q(-1)->S(-1)) </para>
		/// <para>So these 2 provides ways to fix this </para>
		/// <para>GetRelativeTransform returns this*Other(-1) and parameter is Other(not Other(-1)) </para>
		/// <para>GetRelativeTransformReverse returns this(-1)*Other, and parameter is Other. </para>
		/// </summary>
		public FTransform GetRelativeTransform(FTransform Other)
			=> E_FTransform_GetRelativeTransform(this, Other);
		
		public FTransform GetRelativeTransformReverse(FTransform Other)
			=> E_FTransform_GetRelativeTransformReverse(this, Other);
		
		
		/// <summary>
		/// <para>Returns the rotation component </para>
		/// <return>The rotation component </return>
		/// </summary>
		public FQuat GetRotation()
			=> E_FTransform_GetRotation(this);
		
		
		/// <summary>
		/// <para>Returns an opaque copy of the rotation component </para>
		/// <para>This method should be used when passing rotation from one FTransform to another </para>
		/// <return>The rotation component </return>
		/// </summary>
		public FQuat GetRotationV()
			=> E_FTransform_GetRotationV(this);
		
		public FVector GetSafeScaleReciprocal(FVector InScale, float Tolerance)
			=> E_FTransform_GetSafeScaleReciprocal(this, InScale, Tolerance);
		
		
		/// <summary>
		/// <para>Returns the Scale3D component </para>
		/// <return>The Scale3D component </return>
		/// </summary>
		public FVector GetScale3D()
			=> E_FTransform_GetScale3D(this);
		
		
		/// <summary>
		/// <para>Returns an opaque copy of the Scale3D component </para>
		/// <para>This method should be used when passing Scale3D from one FTransform to another </para>
		/// <return>The Scale3D component </return>
		/// </summary>
		public FVector GetScale3DV()
			=> E_FTransform_GetScale3DV(this);
		
		
		/// <summary>
		/// <para>Returns the translation component </para>
		/// <return>The translation component </return>
		/// </summary>
		public FVector GetTranslation()
			=> E_FTransform_GetTranslation(this);
		
		
		/// <summary>
		/// <para>Returns an opaque copy of the translation component </para>
		/// <para>This method should be used when passing translation from one FTransform to another </para>
		/// <return>The translation component </return>
		/// </summary>
		public FVector GetTranslationV()
			=> E_FTransform_GetTranslationV(this);
		
		
		/// <summary>
		/// <para>Acceptable form: "%f,%f,%f|%f,%f,%f|%f,%f,%f" </para>
		/// </summary>
		public bool InitFromString(string InSourceString)
			=> E_FTransform_InitFromString(this, InSourceString);
		
		
		/// <summary>
		/// <para>Convert this Transform to inverse. </para>
		/// </summary>
		public FTransform Inverse()
			=> E_FTransform_Inverse(this);
		
		
		/// <summary>
		/// <para>Inverts the matrix and then transforms V - correctly handles scaling in this matrix. </para>
		/// </summary>
		public FVector InverseTransformPosition(FVector V)
			=> E_FTransform_InverseTransformPosition(this, V);
		
		public FVector InverseTransformPositionNoScale(FVector V)
			=> E_FTransform_InverseTransformPositionNoScale(this, V);
		
		
		/// <summary>
		/// <para>Transform a direction vector by the inverse of this matrix - will not take into account translation part. </para>
		/// <para>If you want to transform a surface normal (or plane) and correctly account for non-uniform scaling you should use TransformByUsingAdjointT with adjoint of matrix inverse. </para>
		/// </summary>
		public FVector InverseTransformVector(FVector V)
			=> E_FTransform_InverseTransformVector(this, V);
		
		public FVector InverseTransformVectorNoScale(FVector V)
			=> E_FTransform_InverseTransformVectorNoScale(this, V);
		
		
		/// <summary>
		/// <para>Checks whether the rotation component is normalized or not </para>
		/// <return>true if the rotation component is normalized, and false otherwise. </return>
		/// </summary>
		public bool IsRotationNormalized()
			=> E_FTransform_IsRotationNormalized(this);
		
		public bool IsValid()
			=> E_FTransform_IsValid(this);
		
		
		/// <summary>
		/// <para>Scales the Scale3D component by a new factor </para>
		/// <param name="Scale3DMultiplier">The value to multiply Scale3D with </param>
		/// </summary>
		public void MultiplyScale3D(FVector Scale3DMultiplier)
			=> E_FTransform_MultiplyScale3D(this, Scale3DMultiplier);
		
		
		/// <summary>
		/// <para>Normalize the rotation component of this transformation </para>
		/// </summary>
		public void NormalizeRotation()
			=> E_FTransform_NormalizeRotation(this);
		
		public void RemoveScaling(float Tolerance)
			=> E_FTransform_RemoveScaling(this, Tolerance);
		
		public bool RotationEquals(FTransform Other, float Tolerance)
			=> E_FTransform_RotationEquals(this, Other, Tolerance);
		
		public FRotator Rotator()
			=> E_FTransform_Rotator(this);
		
		public bool Scale3DEquals(FTransform Other, float Tolerance)
			=> E_FTransform_Scale3DEquals(this, Other, Tolerance);
		
		
		/// <summary>
		/// <para>Sets the components </para>
		/// <param name="InRotation">The new value for the Rotation component </param>
		/// <param name="InTranslation">The new value for the Translation component </param>
		/// <param name="InScale3D">The new value for the Scale3D component </param>
		/// </summary>
		public void SetComponents(FQuat InRotation, FVector InTranslation, FVector InScale3D)
			=> E_FTransform_SetComponents(this, InRotation, InTranslation, InScale3D);
		
		
		/// <summary>
		/// <para>Sets the components to the identity transform: </para>
		/// <para>Rotation = (0,0,0,1) </para>
		/// <para>Translation = (0,0,0) </para>
		/// <para>Scale3D = (1,1,1) </para>
		/// </summary>
		public void SetIdentity()
			=> E_FTransform_SetIdentity(this);
		
		
		/// <summary>
		/// <para>Set the translation of this transformation </para>
		/// </summary>
		public void SetLocation(FVector Origin)
			=> E_FTransform_SetLocation(this, Origin);
		
		
		/// <summary>
		/// <para>Sets the rotation component </para>
		/// <param name="NewRotation">The new value for the rotation component </param>
		/// </summary>
		public void SetRotation(FQuat NewRotation)
			=> E_FTransform_SetRotation(this, NewRotation);
		
		
		/// <summary>
		/// <para>Sets the Scale3D component </para>
		/// <param name="NewScale3D">The new value for the Scale3D component </param>
		/// </summary>
		public void SetScale3D(FVector NewScale3D)
			=> E_FTransform_SetScale3D(this, NewScale3D);
		
		
		/// <summary>
		/// <para>Set current transform and the relative to ParentTransform. </para>
		/// <para>Equates to This = This->GetRelativeTransform(Parent), but saves the intermediate FTransform storage and copy. </para>
		/// </summary>
		public void SetToRelativeTransform(FTransform ParentTransform)
			=> E_FTransform_SetToRelativeTransform(this, ParentTransform);
		
		
		/// <summary>
		/// <para>Sets the translation component </para>
		/// <param name="NewTranslation">The new value for the translation component </param>
		/// </summary>
		public void SetTranslation(FVector NewTranslation)
			=> E_FTransform_SetTranslation(this, NewTranslation);
		
		
		/// <summary>
		/// <para>Sets both the translation and Scale3D components at the same time </para>
		/// <param name="NewTranslation">The new value for the translation component </param>
		/// <param name="NewScale3D">The new value for the Scale3D component </param>
		/// </summary>
		public void SetTranslationAndScale3D(FVector NewTranslation, FVector NewScale3D)
			=> E_FTransform_SetTranslationAndScale3D(this, NewTranslation, NewScale3D);
		
		
		/// <summary>
		/// <para>Subtract translations from two FTransforms and return the difference. </para>
		/// <return>A.Translation - B.Translation. </return>
		/// </summary>
		public FVector SubtractTranslations(FTransform A, FTransform B)
			=> E_FTransform_SubtractTranslations(this, A, B);
		
		
		/// <summary>
		/// <para>Convert FTransform contents to a string </para>
		/// </summary>
		public string ToHumanReadableString()
			=> Marshal.PtrToStringUTF8(E_FTransform_ToHumanReadableString(this, out int ResultStringLen), ResultStringLen);
		
		public override string ToString()
			=> Marshal.PtrToStringUTF8(E_FTransform_ToString(this, out int ResultStringLen), ResultStringLen);
		
		public FVector4 TransformFVector4(FVector4 V)
			=> E_FTransform_TransformFVector4(this, V);
		
		public FVector4 TransformFVector4NoScale(FVector4 V)
			=> E_FTransform_TransformFVector4NoScale(this, V);
		
		public FVector TransformPosition(FVector V)
			=> E_FTransform_TransformPosition(this, V);
		
		public FVector TransformPositionNoScale(FVector V)
			=> E_FTransform_TransformPositionNoScale(this, V);
		
		public FVector TransformVector(FVector V)
			=> E_FTransform_TransformVector(this, V);
		
		public FVector TransformVectorNoScale(FVector V)
			=> E_FTransform_TransformVectorNoScale(this, V);
		
		public bool TranslationEquals(FTransform Other, float Tolerance)
			=> E_FTransform_TranslationEquals(this, Other, Tolerance);
		
		#endregion
		
		public static implicit operator IntPtr(FTransform Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FTransform(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FTransform(Adress, false);
		}
}
}
