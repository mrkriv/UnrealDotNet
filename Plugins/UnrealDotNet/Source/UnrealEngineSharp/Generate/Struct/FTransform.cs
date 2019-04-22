// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Core\Public\Math\TransformNonVectorized.h:28

namespace UnrealEngine
{
	public  partial class FTransform : NativeStructWrapper
	{
		internal FTransform(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		
		/// <summary>
		/// <para>Default constructor. </para>
		/// </summary>
		public FTransform() :
			base(E_CreateStruct_FTransform(), false)
		{
		}

		
		/// <summary>
		/// <para>Constructor with an initial translation </para>
		/// <param name="InTranslation">The value to use for the translation component </param>
		/// </summary>
		public FTransform(FVector inTranslation) :
			base(E_CreateStruct_FTransform_FVector(inTranslation), false)
		{
		}

		
		/// <summary>
		/// <para>Constructor with an initial rotation </para>
		/// <param name="InRotation">The value to use for rotation component </param>
		/// </summary>
		public FTransform(FQuat inRotation) :
			base(E_CreateStruct_FTransform_FQuat(inRotation), false)
		{
		}

		
		/// <summary>
		/// <para>Constructor with an initial rotation </para>
		/// <param name="InRotation">The value to use for rotation component  (after being converted to a quaternion) </param>
		/// </summary>
		public FTransform(FRotator inRotation) :
			base(E_CreateStruct_FTransform_FRotator(inRotation), false)
		{
		}

		
		/// <summary>
		/// <para>Constructor with all components initialized </para>
		/// <param name="InRotation">The value to use for rotation component </param>
		/// <param name="InTranslation">The value to use for the translation component </param>
		/// <param name="InScale3D">The value to use for the scale component </param>
		/// </summary>
		public FTransform(FQuat inRotation, FVector inTranslation, FVector inScale3D) :
			base(E_CreateStruct_FTransform_FQuat_FVector_FVector(inRotation, inTranslation, inScale3D), false)
		{
		}

		
		/// <summary>
		/// <para>Constructor with all components initialized, taking a FRotator as the rotation component </para>
		/// <param name="InRotation">The value to use for rotation component (after being converted to a quaternion) </param>
		/// <param name="InTranslation">The value to use for the translation component </param>
		/// <param name="InScale3D">The value to use for the scale component </param>
		/// </summary>
		public FTransform(FRotator inRotation, FVector inTranslation, FVector inScale3D) :
			base(E_CreateStruct_FTransform_FRotator_FVector_FVector(inRotation, inTranslation, inScale3D), false)
		{
		}

		
		/// <summary>
		/// <para>Copy-constructor </para>
		/// <param name="InTransform">The source transform from which all components will be copied </param>
		/// </summary>
		public FTransform(FTransform inTransform) :
			base(E_CreateStruct_FTransform_FTransform(inTransform), false)
		{
		}

		
		/// <summary>
		/// <para>Constructor for converting a Matrix (including scale) into a FTransform. </para>
		/// </summary>
		public FTransform(FMatrix inMatrix) :
			base(E_CreateStruct_FTransform_FMatrix(inMatrix), false)
		{
		}

		
		/// <summary>
		/// <para>Constructor that takes basis axes and translation </para>
		/// </summary>
		public FTransform(FVector inX, FVector inY, FVector inZ, FVector inTranslation) :
			base(E_CreateStruct_FTransform_FVector_FVector_FVector_FVector(inX, inY, inZ, inTranslation), false)
		{
		}

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
		private static extern void E_FTransform_Accumulate_o1(IntPtr self, IntPtr atom, float blendWeight);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FTransform_AccumulateWithAdditiveScale(IntPtr self, IntPtr atom, float blendWeight);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FTransform_AccumulateWithShortestRotation(IntPtr self, IntPtr deltaAtom, float blendWeight);
		
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
		private static extern void E_FTransform_BlendFromIdentityAndAccumulate(IntPtr self, IntPtr finalAtom, IntPtr sourceAtom, float blendWeight);
		
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
		private static extern bool E_FTransform_DebugEqualMatrix(IntPtr self, IntPtr matrix);
		
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
		private static extern void E_FTransform_LerpTranslationScale3D(IntPtr self, IntPtr sourceAtom1, IntPtr sourceAtom2, IntPtr alpha);
		
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
		
		#region ExternMethods
		
		/// <summary>
		/// <para>Accumulates another transform with this one </para>
		/// <para>Rotation is accumulated multiplicatively (Rotation = SourceAtom.Rotation * Rotation) </para>
		/// <para>Translation is accumulated additively (Translation += SourceAtom.Translation) </para>
		/// <para>Scale3D is accumulated multiplicatively (Scale3D *= SourceAtom.Scale3D) </para>
		/// <param name="SourceAtom">The other transform to accumulate into this one </param>
		/// </summary>
		public void Accumulate(FTransform sourceAtom)
			=> E_FTransform_Accumulate(this, sourceAtom);
		
		
		/// <summary>
		/// <para>Accumulates another transform with this one, with a blending weight </para>
		/// <para>Let SourceAtom = Atom * BlendWeight </para>
		/// <para>Rotation is accumulated multiplicatively (Rotation = SourceAtom.Rotation * Rotation). </para>
		/// <para>Translation is accumulated additively (Translation += SourceAtom.Translation) </para>
		/// <para>Scale3D is accumulated multiplicatively (Scale3D *= SourceAtom.Scale3D) </para>
		/// <para>Note: Rotation will not be normalized! Will have to be done manually. </para>
		/// <param name="Atom">The other transform to accumulate into this one </param>
		/// <param name="BlendWeight">The weight to multiply Atom by before it is accumulated. </param>
		/// </summary>
		public void Accumulate(FTransform atom, float blendWeight)
			=> E_FTransform_Accumulate_o1(this, atom, blendWeight);
		
		
		/// <summary>
		/// <para>Accumulates another transform with this one, with a blending weight </para>
		/// <para>Let SourceAtom = Atom * BlendWeight </para>
		/// <para>Rotation is accumulated multiplicatively (Rotation = SourceAtom.Rotation * Rotation). </para>
		/// <para>Translation is accumulated additively (Translation += SourceAtom.Translation) </para>
		/// <para>Scale3D is accumulated assuming incoming scale is additive scale (Scale3D *= (1 + SourceAtom.Scale3D)) </para>
		/// <para>When we create additive, we create additive scale based on [TargetScale/SourceScale -1] </para>
		/// <para>because that way when you apply weight of 0.3, you don't shrink. We only saves the % of grow/shrink </para>
		/// <para>when we apply that back to it, we add back the 1, so that it goes back to it. </para>
		/// <para>This solves issue where you blend two additives with 0.3, you don't come back to 0.6 scale, but 1 scale at the end </para>
		/// <para>because [1 + [1-1]*0.3 + [1-1]*0.3] becomes 1, so you don't shrink by applying additive scale </para>
		/// <para>Note: Rotation will not be normalized! Will have to be done manually. </para>
		/// <param name="Atom">The other transform to accumulate into this one </param>
		/// <param name="BlendWeight">The weight to multiply Atom by before it is accumulated. </param>
		/// </summary>
		public void AccumulateWithAdditiveScale(FTransform atom, float blendWeight)
			=> E_FTransform_AccumulateWithAdditiveScale(this, atom, blendWeight);
		
		
		/// <summary>
		/// <para>Accumulates another transform with this one, with an optional blending weight </para>
		/// <para>Rotation is accumulated additively, in the shortest direction (Rotation = Rotation +/- DeltaAtom.Rotation * Weight) </para>
		/// <para>Translation is accumulated additively (Translation += DeltaAtom.Translation * Weight) </para>
		/// <para>Scale3D is accumulated additively (Scale3D += DeltaAtom.Scale3D * Weight) </para>
		/// <param name="DeltaAtom">The other transform to accumulate into this one </param>
		/// <param name="Weight">The weight to multiply DeltaAtom by before it is accumulated. </param>
		/// </summary>
		public void AccumulateWithShortestRotation(FTransform deltaAtom, float blendWeight)
			=> E_FTransform_AccumulateWithShortestRotation(this, deltaAtom, blendWeight);
		
		
		/// <summary>
		/// <para>Adjusts the translation component of this transformation </para>
		/// <param name="DeltaTranslation">The translation to add in the following fashion: Translation += DeltaTranslation </param>
		/// </summary>
		public void AddToTranslation(FVector deltaTranslation)
			=> E_FTransform_AddToTranslation(this, deltaTranslation);
		
		
		/// <summary>
		/// <para>Add the translations from two FTransforms and return the result. </para>
		/// <return>A.Translation + B.Translation </return>
		/// </summary>
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
		/// <para>Set this transform to the weighted blend of the supplied two transforms. </para>
		/// </summary>
		public void Blend(FTransform atom1, FTransform atom2, float alpha)
			=> E_FTransform_Blend(this, atom1, atom2, alpha);
		
		
		/// <summary>
		/// <para>Blends the Identity transform with a weighted source transform and accumulates that into a destination transform </para>
		/// <para>SourceAtom = Blend(Identity, SourceAtom, BlendWeight) </para>
		/// <para>FinalAtom.Rotation = SourceAtom.Rotation * FinalAtom.Rotation </para>
		/// <para>FinalAtom.Translation += SourceAtom.Translation </para>
		/// <para>FinalAtom.Scale3D *= SourceAtom.Scale3D </para>
		/// <param name="FinalAtom">in/out] The atom to accumulate the blended source atom into </param>
		/// <param name="SourceAtom">The target transformation (used when BlendWeight = 1); this is modified during the process </param>
		/// <param name="BlendWeight">The blend weight between Identity and SourceAtom </param>
		/// </summary>
		public void BlendFromIdentityAndAccumulate(FTransform finalAtom, FTransform sourceAtom, float blendWeight)
			=> E_FTransform_BlendFromIdentityAndAccumulate(this, finalAtom, sourceAtom, blendWeight);
		
		
		/// <summary>
		/// <para>Set this Transform to the weighted blend of it and the supplied Transform. </para>
		/// </summary>
		public void BlendWith(FTransform otherAtom, float alpha)
			=> E_FTransform_BlendWith(this, otherAtom, alpha);
		
		
		/// <summary>
		/// <para>Concatenates another rotation to this transformation </para>
		/// <param name="DeltaRotation">The rotation to concatenate in the following fashion: Rotation = Rotation * DeltaRotation </param>
		/// </summary>
		public void ConcatenateRotation(FQuat deltaRotation)
			=> E_FTransform_ConcatenateRotation(this, deltaRotation);
		
		
		/// <summary>
		/// <para>Checks the components for non-finite values (NaN or Inf). </para>
		/// <return>Returns true if any component (rotation, translation, or scale) is not finite. </return>
		/// </summary>
		public bool ContainsNaN()
			=> E_FTransform_ContainsNaN(this);
		
		
		/// <summary>
		/// <para>Copy rotation from another FTransform. </para>
		/// </summary>
		public void CopyRotation(FTransform other)
			=> E_FTransform_CopyRotation(this, other);
		
		
		/// <summary>
		/// <para>Sets the Rotation and Scale3D of this transformation from another transform </para>
		/// <param name="SrcBA">The transform to copy rotation and Scale3D from </param>
		/// </summary>
		public void CopyRotationPart(FTransform srcBA)
			=> E_FTransform_CopyRotationPart(this, srcBA);
		
		
		/// <summary>
		/// <para>Copy scale from another FTransform. </para>
		/// </summary>
		public void CopyScale3D(FTransform other)
			=> E_FTransform_CopyScale3D(this, other);
		
		
		/// <summary>
		/// <para>Copy translation from another FTransform. </para>
		/// </summary>
		public void CopyTranslation(FTransform other)
			=> E_FTransform_CopyTranslation(this, other);
		
		
		/// <summary>
		/// <para>Sets the Translation and Scale3D of this transformation from another transform </para>
		/// <param name="SrcBA">The transform to copy translation and Scale3D from </param>
		/// </summary>
		public void CopyTranslationAndScale3D(FTransform srcBA)
			=> E_FTransform_CopyTranslationAndScale3D(this, srcBA);
		
		
		/// <summary>
		/// <para>Debug purpose only </para>
		/// </summary>
		public bool DebugEqualMatrix(FMatrix matrix)
			=> E_FTransform_DebugEqualMatrix(this, matrix);
		
		
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
		
		public bool Equals(FTransform other, float tolerance)
			=> E_FTransform_Equals(this, other, tolerance);
		
		public bool EqualsNoScale(FTransform other, float tolerance)
			=> E_FTransform_EqualsNoScale(this, other, tolerance);
		
		
		/// <summary>
		/// <para>Calculate the determinant of this transformation </para>
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
		public FTransform GetRelativeTransform(FTransform other)
			=> E_FTransform_GetRelativeTransform(this, other);
		
		public FTransform GetRelativeTransformReverse(FTransform other)
			=> E_FTransform_GetRelativeTransformReverse(this, other);
		
		
		/// <summary>
		/// <para>Returns the rotation component </para>
		/// <return>The rotation component </return>
		/// </summary>
		public FQuat GetRotation()
			=> E_FTransform_GetRotation(this);
		
		public FVector GetSafeScaleReciprocal(FVector inScale, float tolerance)
			=> E_FTransform_GetSafeScaleReciprocal(this, inScale, tolerance);
		
		
		/// <summary>
		/// <para>Returns the Scale3D component </para>
		/// <return>The Scale3D component </return>
		/// </summary>
		public FVector GetScale3D()
			=> E_FTransform_GetScale3D(this);
		
		public FTransform GetScaled(float scale)
			=> E_FTransform_GetScaled(this, scale);
		
		public FTransform GetScaled(FVector scale)
			=> E_FTransform_GetScaled_o1(this, scale);
		
		
		/// <summary>
		/// <para>Returns the translation component </para>
		/// <return>The translation component </return>
		/// </summary>
		public FVector GetTranslation()
			=> E_FTransform_GetTranslation(this);
		
		
		/// <summary>
		/// <para>Acceptable form: "%f,%f,%f|%f,%f,%f|%f,%f,%f" </para>
		/// </summary>
		public bool InitFromString(string inSourceString)
			=> E_FTransform_InitFromString(this, inSourceString);
		
		
		/// <summary>
		/// <para>Convert this Transform to inverse. </para>
		/// </summary>
		public FTransform Inverse()
			=> E_FTransform_Inverse(this);
		
		
		/// <summary>
		/// <para>Inverts the transform and then transforms V - correctly handles scaling in this transform. </para>
		/// </summary>
		public FVector InverseTransformPosition(FVector v)
			=> E_FTransform_InverseTransformPosition(this, v);
		
		public FVector InverseTransformPositionNoScale(FVector v)
			=> E_FTransform_InverseTransformPositionNoScale(this, v);
		
		
		/// <summary>
		/// <para>Inverse transform a rotation. </para>
		/// <para>For example if this is a LocalToWorld transform, InverseTransformRotation(Q) would transform Q from world to local space. </para>
		/// </summary>
		public FQuat InverseTransformRotation(FQuat q)
			=> E_FTransform_InverseTransformRotation(this, q);
		
		
		/// <summary>
		/// <para>Transform a direction vector by the inverse of this transform - will not take into account translation part. </para>
		/// <para>If you want to transform a surface normal (or plane) and correctly account for non-uniform scaling you should use TransformByUsingAdjointT with adjoint of matrix inverse. </para>
		/// </summary>
		public FVector InverseTransformVector(FVector v)
			=> E_FTransform_InverseTransformVector(this, v);
		
		public FVector InverseTransformVectorNoScale(FVector v)
			=> E_FTransform_InverseTransformVectorNoScale(this, v);
		
		
		/// <summary>
		/// <para>Checks whether the rotation component is normalized or not </para>
		/// <return>true if the rotation component is normalized, and false otherwise. </return>
		/// </summary>
		public bool IsRotationNormalized()
			=> E_FTransform_IsRotationNormalized(this);
		
		public bool IsValid()
			=> E_FTransform_IsValid(this);
		
		
		/// <summary>
		/// <para>Set the translation and Scale3D components of this transform to a linearly interpolated combination of two other transforms </para>
		/// <para>Translation = FMath::Lerp(SourceAtom1.Translation, SourceAtom2.Translation, Alpha) </para>
		/// <para>Scale3D = FMath::Lerp(SourceAtom1.Scale3D, SourceAtom2.Scale3D, Alpha) </para>
		/// <param name="SourceAtom1">The starting point source atom (used 100% if Alpha is 0) </param>
		/// <param name="SourceAtom2">The ending point source atom (used 100% if Alpha is 1) </param>
		/// <param name="Alpha">The blending weight between SourceAtom1 and SourceAtom2 </param>
		/// </summary>
		public void LerpTranslationScale3D(FTransform sourceAtom1, FTransform sourceAtom2, ScalarRegister alpha)
			=> E_FTransform_LerpTranslationScale3D(this, sourceAtom1, sourceAtom2, alpha);
		
		
		/// <summary>
		/// <para>Create a new transform: OutTransform = A * B. </para>
		/// <para>Order matters when composing transforms : A * B will yield a transform that logically first applies A then B to any subsequent transformation. </para>
		/// <param name="OutTransform">pointer to transform that will store the result of A * B. </param>
		/// <param name="A">Transform A. </param>
		/// <param name="B">Transform B. </param>
		/// </summary>
		public void Multiply(FTransform outTransform, FTransform a, FTransform b)
			=> E_FTransform_Multiply(this, outTransform, a, b);
		
		
		/// <summary>
		/// <para>Scales the Scale3D component by a new factor </para>
		/// <param name="Scale3DMultiplier">The value to multiply Scale3D with </param>
		/// </summary>
		public void MultiplyScale3D(FVector scale3DMultiplier)
			=> E_FTransform_MultiplyScale3D(this, scale3DMultiplier);
		
		
		/// <summary>
		/// <para>Normalize the rotation component of this transformation </para>
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
		/// <para>Sets the components </para>
		/// <param name="InRotation">The new value for the Rotation component </param>
		/// <param name="InTranslation">The new value for the Translation component </param>
		/// <param name="InScale3D">The new value for the Scale3D component </param>
		/// </summary>
		public void SetComponents(FQuat inRotation, FVector inTranslation, FVector inScale3D)
			=> E_FTransform_SetComponents(this, inRotation, inTranslation, inScale3D);
		
		public void SetFromMatrix(FMatrix inMatrix)
			=> E_FTransform_SetFromMatrix(this, inMatrix);
		
		
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
		public void SetLocation(FVector origin)
			=> E_FTransform_SetLocation(this, origin);
		
		
		/// <summary>
		/// <para>Sets the rotation component </para>
		/// <param name="NewRotation">The new value for the rotation component </param>
		/// </summary>
		public void SetRotation(FQuat newRotation)
			=> E_FTransform_SetRotation(this, newRotation);
		
		
		/// <summary>
		/// <para>Sets the Scale3D component </para>
		/// <param name="NewScale3D">The new value for the Scale3D component </param>
		/// </summary>
		public void SetScale3D(FVector newScale3D)
			=> E_FTransform_SetScale3D(this, newScale3D);
		
		
		/// <summary>
		/// <para>Set current transform and the relative to ParentTransform. </para>
		/// <para>Equates to This = This->GetRelativeTransform(Parent), but saves the intermediate FTransform storage and copy. </para>
		/// </summary>
		public void SetToRelativeTransform(FTransform parentTransform)
			=> E_FTransform_SetToRelativeTransform(this, parentTransform);
		
		
		/// <summary>
		/// <para>Sets the translation component </para>
		/// <param name="NewTranslation">The new value for the translation component </param>
		/// </summary>
		public void SetTranslation(FVector newTranslation)
			=> E_FTransform_SetTranslation(this, newTranslation);
		
		
		/// <summary>
		/// <para>Sets both the translation and Scale3D components at the same time </para>
		/// <param name="NewTranslation">The new value for the translation component </param>
		/// <param name="NewScale3D">The new value for the Scale3D component </param>
		/// </summary>
		public void SetTranslationAndScale3D(FVector newTranslation, FVector newScale3D)
			=> E_FTransform_SetTranslationAndScale3D(this, newTranslation, newScale3D);
		
		
		/// <summary>
		/// <para>Subtract translations from two FTransforms and return the difference. </para>
		/// <return>A.Translation - B.Translation. </return>
		/// </summary>
		public FVector SubtractTranslations(FTransform a, FTransform b)
			=> E_FTransform_SubtractTranslations(this, a, b);
		
		
		/// <summary>
		/// <para>Convert FTransform contents to a string </para>
		/// </summary>
		public string ToHumanReadableString()
			=> E_FTransform_ToHumanReadableString(this);
		
		
		/// <summary>
		/// <para>Convert this Transform to matrix with scaling and compute the inverse of that. </para>
		/// </summary>
		public FMatrix ToInverseMatrixWithScale()
			=> E_FTransform_ToInverseMatrixWithScale(this);
		
		
		/// <summary>
		/// <para>Convert this Transform to a transformation matrix, ignoring its scaling </para>
		/// </summary>
		public FMatrix ToMatrixNoScale()
			=> E_FTransform_ToMatrixNoScale(this);
		
		
		/// <summary>
		/// <para>Convert this Transform to a transformation matrix with scaling. </para>
		/// </summary>
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
		/// <para>Transform a rotation. </para>
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
			return self.NativePointer;
		}

		public static implicit operator FTransform(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FTransform(Adress, false);
		}}}
