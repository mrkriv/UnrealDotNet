// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Core\Public\Math\RandomStream.h:17

namespace UnrealEngine
{
	public  partial class FRandomStream : NativeStructWrapper
	{
		internal FRandomStream(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		
		/// <summary>
		/// <para>Default constructor. </para>
		/// <para>The seed should be set prior to use. </para>
		/// </summary>
		public FRandomStream() :
			base(E_CreateStruct_FRandomStream(), false)
		{
		}

		
		/// <summary>
		/// <para>Creates and initializes a new random stream from the specified seed value. </para>
		/// <param name="InSeed">The seed value. </param>
		/// </summary>
		public FRandomStream(int inSeed) :
			base(E_CreateStruct_FRandomStream_int32(inSeed), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FRandomStream();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FRandomStream_int32(int inSeed);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FRandomStream_ExportTextItem(IntPtr self, string valueStr, IntPtr defaultValue, IntPtr parent, int portFlags, IntPtr exportRootScope);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FRandomStream_FRand(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FRandomStream_FRandRange(IntPtr self, float inMin, float inMax);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FRandomStream_GenerateNewSeed(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_FRandomStream_GetCurrentSeed(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FRandomStream_GetFraction(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_FRandomStream_GetInitialSeed(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FRandomStream_GetUnitVector(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FRandomStream_Initialize(IntPtr self, int inSeed);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_FRandomStream_RandHelper(IntPtr self, int a);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_FRandomStream_RandRange(IntPtr self, int min, int max);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FRandomStream_Reset(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FRandomStream_VRand(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FRandomStream_VRandCone(IntPtr self, IntPtr dir, float coneHalfAngleRad);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_FRandomStream_VRandCone_o1(IntPtr self, IntPtr dir, float horizontalConeHalfAngleRad, float verticalConeHalfAngleRad);
		
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// <para>Exports the RandomStreams value to a string. </para>
		/// <param name="ValueStr">Will hold the string value. </param>
		/// <param name="DefaultValue">The default value. </param>
		/// <param name="Parent">Not used. </param>
		/// <param name="PortFlags">Not used. </param>
		/// <param name="ExportRootScope">Not used. </param>
		/// <return>true on success, false otherwise. </return>
		/// <para>@see ImportTextItem </para>
		/// </summary>
		public bool ExportTextItem(string valueStr, FRandomStream defaultValue, UObject parent, int portFlags, UObject exportRootScope)
			=> E_FRandomStream_ExportTextItem(this, valueStr, defaultValue, parent, portFlags, exportRootScope);
		
		
		/// <summary>
		/// <para>Mirrors the random number API in FMath </para>
		/// <return>Random number. </return>
		/// </summary>
		public float FRand()
			=> E_FRandomStream_FRand(this);
		
		
		/// <summary>
		/// <para>Helper function for rand implementations. </para>
		/// <return>A random number >= Min and <= Max </return>
		/// </summary>
		public float FRandRange(float inMin, float inMax)
			=> E_FRandomStream_FRandRange(this, inMin, inMax);
		
		
		/// <summary>
		/// <para>Generates a new random seed. </para>
		/// </summary>
		public void GenerateNewSeed()
			=> E_FRandomStream_GenerateNewSeed(this);
		
		
		/// <summary>
		/// <para>Gets the current seed. </para>
		/// <return>Current seed. </return>
		/// </summary>
		public int GetCurrentSeed()
			=> E_FRandomStream_GetCurrentSeed(this);
		
		
		/// <summary>
		/// <para>Returns a random number between 0 and 1. </para>
		/// <return>Random number. </return>
		/// </summary>
		public float GetFraction()
			=> E_FRandomStream_GetFraction(this);
		
		public int GetInitialSeed()
			=> E_FRandomStream_GetInitialSeed(this);
		
		
		/// <summary>
		/// <para>Returns a random vector of unit size. </para>
		/// <return>Random unit vector. </return>
		/// </summary>
		public FVector GetUnitVector()
			=> E_FRandomStream_GetUnitVector(this);
		
		
		/// <summary>
		/// <para>Initializes this random stream with the specified seed value. </para>
		/// <param name="InSeed">The seed value. </param>
		/// </summary>
		public void Initialize(int inSeed)
			=> E_FRandomStream_Initialize(this, inSeed);
		
		
		/// <summary>
		/// <para>Helper function for rand implementations. </para>
		/// <return>A random number in [0..A) </return>
		/// </summary>
		public int RandHelper(int a)
			=> E_FRandomStream_RandHelper(this, a);
		
		
		/// <summary>
		/// <para>Helper function for rand implementations. </para>
		/// <return>A random number >= Min and <= Max </return>
		/// </summary>
		public int RandRange(int min, int max)
			=> E_FRandomStream_RandRange(this, min, max);
		
		
		/// <summary>
		/// <para>Resets this random stream to the initial seed value. </para>
		/// </summary>
		public void Reset()
			=> E_FRandomStream_Reset(this);
		
		
		/// <summary>
		/// <para>Returns a random vector of unit size. </para>
		/// <return>Random unit vector. </return>
		/// </summary>
		public FVector VRand()
			=> E_FRandomStream_VRand(this);
		
		
		/// <summary>
		/// <para>Returns a random unit vector, uniformly distributed, within the specified cone. </para>
		/// <param name="Dir">The center direction of the cone </param>
		/// <param name="ConeHalfAngleRad">Half-angle of cone, in radians. </param>
		/// <return>Normalized vector within the specified cone. </return>
		/// </summary>
		public FVector VRandCone(FVector dir, float coneHalfAngleRad)
			=> E_FRandomStream_VRandCone(this, dir, coneHalfAngleRad);
		
		
		/// <summary>
		/// <para>Returns a random unit vector, uniformly distributed, within the specified cone. </para>
		/// <param name="Dir">The center direction of the cone </param>
		/// <param name="HorizontalConeHalfAngleRad">Horizontal half-angle of cone, in radians. </param>
		/// <param name="VerticalConeHalfAngleRad">Vertical half-angle of cone, in radians. </param>
		/// <return>Normalized vector within the specified cone. </return>
		/// </summary>
		public FVector VRandCone(FVector dir, float horizontalConeHalfAngleRad, float verticalConeHalfAngleRad)
			=> E_FRandomStream_VRandCone_o1(this, dir, horizontalConeHalfAngleRad, verticalConeHalfAngleRad);
		
		#endregion
		
		public static implicit operator IntPtr(FRandomStream self)
		{
			return self.NativePointer;
		}

		public static implicit operator FRandomStream(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FRandomStream(Adress, false);
		}}}
