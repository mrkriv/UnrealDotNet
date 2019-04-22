// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Core\Public\Math\CurveEdInterface.h:10

namespace UnrealEngine
{
	public  partial class FCurveEdInterface : NativeStructWrapper
	{
		internal FCurveEdInterface(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FCurveEdInterface() :
			base(E_CreateStruct_FCurveEdInterface(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FCurveEdInterface();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_FCurveEdInterface_CreateNewKey(IntPtr self, float keyIn);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FCurveEdInterface_DeleteKey(IntPtr self, int keyIndex);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FCurveEdInterface_EvalSub(IntPtr self, int subIndex, float inVal);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FCurveEdInterface_GetInRange(IntPtr self, float minIn, float maxIn);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FCurveEdInterface_GetKeyIn(IntPtr self, int keyIndex);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_FCurveEdInterface_GetKeyInterpMode(IntPtr self, int keyIndex);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FCurveEdInterface_GetKeyOut(IntPtr self, int subIndex, int keyIndex);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_FCurveEdInterface_GetNumKeys(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_FCurveEdInterface_GetNumSubCurves(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FCurveEdInterface_GetOutRange(IntPtr self, float minOut, float maxOut);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FCurveEdInterface_GetTangents(IntPtr self, int subIndex, int keyIndex, float arriveTangent, float leaveTangent);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_FCurveEdInterface_SetKeyIn(IntPtr self, int keyIndex, float newInVal);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FCurveEdInterface_SetKeyInterpMode(IntPtr self, int keyIndex, byte newMode);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FCurveEdInterface_SetKeyOut(IntPtr self, int subIndex, int keyIndex, float newOutVal);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FCurveEdInterface_SetTangents(IntPtr self, int subIndex, int keyIndex, float arriveTangent, float leaveTangent);
		
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// <para>Add a new key to the curve with the specified input. Its initial value is set using EvalSub at that location. </para>
		/// <para>Returns the index of the new key. </para>
		/// </summary>
		public virtual int CreateNewKey(float keyIn)
			=> E_FCurveEdInterface_CreateNewKey(this, keyIn);
		
		
		/// <summary>
		/// <para>Remove the specified key from the curve. </para>
		/// <para>KeyIndex must be within range ie >=0 and < NumKeys. </para>
		/// </summary>
		public virtual void DeleteKey(int keyIndex)
			=> E_FCurveEdInterface_DeleteKey(this, keyIndex);
		
		
		/// <summary>
		/// <para>Evaluate a subcurve at an arbitary point. Outside the keyframe range, curves are assumed to continue their end values. </para>
		/// </summary>
		public virtual float EvalSub(int subIndex, float inVal)
			=> E_FCurveEdInterface_EvalSub(this, subIndex, inVal);
		
		
		/// <summary>
		/// <para>Get input range of keys. Outside this region curve continues constantly the start/end values. </para>
		/// </summary>
		public virtual void GetInRange(float minIn, float maxIn)
			=> E_FCurveEdInterface_GetInRange(this, minIn, maxIn);
		
		
		/// <summary>
		/// <para>Get the input value for the Key with the specified index. KeyIndex must be within range ie >=0 and < NumKeys. </para>
		/// </summary>
		public virtual float GetKeyIn(int keyIndex)
			=> E_FCurveEdInterface_GetKeyIn(this, keyIndex);
		
		
		/// <summary>
		/// <para>Get the interpolation mode of the specified keyframe. This can be CIM_Constant, CIM_Linear or CIM_Curve. </para>
		/// <para>KeyIndex must be within range ie >=0 and < NumKeys. </para>
		/// </summary>
		public virtual EInterpCurveMode GetKeyInterpMode(int keyIndex)
			=> (EInterpCurveMode)E_FCurveEdInterface_GetKeyInterpMode(this, keyIndex);
		
		
		/// <summary>
		/// <para>Get the output value for the key with the specified index on the specified sub-curve. </para>
		/// <para>SubIndex must be within range ie >=0 and < NumSubCurves. </para>
		/// <para>KeyIndex must be within range ie >=0 and < NumKeys. </para>
		/// </summary>
		public virtual float GetKeyOut(int subIndex, int keyIndex)
			=> E_FCurveEdInterface_GetKeyOut(this, subIndex, keyIndex);
		
		
		/// <summary>
		/// <para>Get number of keyframes in curve. </para>
		/// </summary>
		public virtual int GetNumKeys()
			=> E_FCurveEdInterface_GetNumKeys(this);
		
		
		/// <summary>
		/// <para>Get number of 'sub curves' in this Curve. For example, a vector curve will have 3 sub-curves, for X, Y and Z. </para>
		/// </summary>
		public virtual int GetNumSubCurves()
			=> E_FCurveEdInterface_GetNumSubCurves(this);
		
		
		/// <summary>
		/// <para>Get overall range of output values. </para>
		/// </summary>
		public virtual void GetOutRange(float minOut, float maxOut)
			=> E_FCurveEdInterface_GetOutRange(this, minOut, maxOut);
		
		
		/// <summary>
		/// <para>Get the incoming and outgoing tangent for the given subcurve and key. </para>
		/// <para>SubIndex must be within range ie >=0 and < NumSubCurves. </para>
		/// <para>KeyIndex must be within range ie >=0 and < NumKeys. </para>
		/// </summary>
		public virtual void GetTangents(int subIndex, int keyIndex, float arriveTangent, float leaveTangent)
			=> E_FCurveEdInterface_GetTangents(this, subIndex, keyIndex, arriveTangent, leaveTangent);
		
		
		/// <summary>
		/// <para>Set the input value of the specified Key. This may change the index of the key, so the new index of the key is retured. </para>
		/// <para>KeyIndex must be within range ie >=0 and < NumKeys. </para>
		/// </summary>
		public virtual int SetKeyIn(int keyIndex, float newInVal)
			=> E_FCurveEdInterface_SetKeyIn(this, keyIndex, newInVal);
		
		
		/// <summary>
		/// <para>Set the method to use for interpolating between the give keyframe and the next one. </para>
		/// <para>KeyIndex must be within range ie >=0 and < NumKeys. </para>
		/// </summary>
		public virtual void SetKeyInterpMode(int keyIndex, EInterpCurveMode newMode)
			=> E_FCurveEdInterface_SetKeyInterpMode(this, keyIndex, (byte)newMode);
		
		
		/// <summary>
		/// <para>Set the output values of the specified key. </para>
		/// <para>SubIndex must be within range ie >=0 and < NumSubCurves. </para>
		/// <para>KeyIndex must be within range ie >=0 and < NumKeys. </para>
		/// </summary>
		public virtual void SetKeyOut(int subIndex, int keyIndex, float newOutVal)
			=> E_FCurveEdInterface_SetKeyOut(this, subIndex, keyIndex, newOutVal);
		
		
		/// <summary>
		/// <para>Set the incoming and outgoing tangent for the given subcurve and key. </para>
		/// <para>SubIndex must be within range ie >=0 and < NumSubCurves. </para>
		/// <para>KeyIndex must be within range ie >=0 and < NumKeys. </para>
		/// </summary>
		public virtual void SetTangents(int subIndex, int keyIndex, float arriveTangent, float leaveTangent)
			=> E_FCurveEdInterface_SetTangents(this, subIndex, keyIndex, arriveTangent, leaveTangent);
		
		#endregion
		
		public static implicit operator IntPtr(FCurveEdInterface self)
		{
			return self.NativePointer;
		}

		public static implicit operator FCurveEdInterface(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FCurveEdInterface(Adress, false);
		}}}
