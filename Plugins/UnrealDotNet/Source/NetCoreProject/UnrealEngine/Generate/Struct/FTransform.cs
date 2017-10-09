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

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FTransform();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FTransform_ContainsNaN(IntPtr Self);
		
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
		private static extern float E_FTransform_GetDeterminant(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FTransform_GetLocation(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FTransform_GetMaximumAxisScale(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FTransform_GetMinimumAxisScale(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FTransform_GetRotation(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FTransform_GetRotationV(IntPtr Self);
		
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
		private static extern bool E_FTransform_IsRotationNormalized(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FTransform_IsValid(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FTransform_NormalizeRotation(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FTransform_RemoveScaling(IntPtr Self, float Tolerance);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FTransform_Rotator(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FTransform_SetIdentity(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_FTransform_ToHumanReadableString(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_FTransform_ToString(IntPtr Self);
		
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// <para>Checks the components for NaN's </para>
		/// <return>Returns true if any component (rotation, translation, or scale) is a NAN </return>
		/// </summary>
		public bool ContainsNaN()
			=> E_FTransform_ContainsNaN(this);
		
		
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
		/// <para>Checks whether the rotation component is normalized or not </para>
		/// <return>true if the rotation component is normalized, and false otherwise. </return>
		/// </summary>
		public bool IsRotationNormalized()
			=> E_FTransform_IsRotationNormalized(this);
		
		public bool IsValid()
			=> E_FTransform_IsValid(this);
		
		
		/// <summary>
		/// <para>Normalize the rotation component of this transformation </para>
		/// </summary>
		public void NormalizeRotation()
			=> E_FTransform_NormalizeRotation(this);
		
		public void RemoveScaling(float Tolerance)
			=> E_FTransform_RemoveScaling(this, Tolerance);
		
		public FRotator Rotator()
			=> E_FTransform_Rotator(this);
		
		
		/// <summary>
		/// <para>Sets the components to the identity transform: </para>
		/// <para>Rotation = (0,0,0,1) </para>
		/// <para>Translation = (0,0,0) </para>
		/// <para>Scale3D = (1,1,1) </para>
		/// </summary>
		public void SetIdentity()
			=> E_FTransform_SetIdentity(this);
		
		
		/// <summary>
		/// <para>Convert FTransform contents to a string </para>
		/// </summary>
		public string ToHumanReadableString()
			=> E_FTransform_ToHumanReadableString(this);
		
		public override string ToString()
			=> E_FTransform_ToString(this);
		
		#endregion
		
		public static implicit operator IntPtr(FTransform Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FTransform(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FTransform(Adress, false);
		}}}
