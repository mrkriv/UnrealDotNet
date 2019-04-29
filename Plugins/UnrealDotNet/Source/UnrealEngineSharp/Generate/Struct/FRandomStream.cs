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
		/// Default constructor.
		/// <para>The seed should be set prior to use. </para>
		/// </summary>
		public FRandomStream() :
			base(E_CreateStruct_FRandomStream(), false)
		{
		}

		
		/// <summary>
		/// Creates and initializes a new random stream from the specified seed value.
		/// </summary>
		/// <param name="inSeed">The seed value.</param>
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
		/// Exports the RandomStreams value to a string.
		/// <para>@see ImportTextItem </para>
		/// </summary>
		/// <param name="valueStr">Will hold the string value.</param>
		/// <param name="defaultValue">The default value.</param>
		/// <param name="parent">Not used.</param>
		/// <param name="portFlags">Not used.</param>
		/// <param name="exportRootScope">Not used.</param>
		/// <return>true</return>
		public bool ExportTextItem(string valueStr, FRandomStream defaultValue, UObject parent, int portFlags, UObject exportRootScope)
			=> E_FRandomStream_ExportTextItem(this, valueStr, defaultValue, parent, portFlags, exportRootScope);
		
		
		/// <summary>
		/// Mirrors the random number API in FMath
		/// </summary>
		/// <return>Random</return>
		public float FRand()
			=> E_FRandomStream_FRand(this);
		
		
		/// <summary>
		/// Helper function for rand implementations.
		/// </summary>
		/// <return>A</return>
		public float FRandRange(float inMin, float inMax)
			=> E_FRandomStream_FRandRange(this, inMin, inMax);
		
		
		/// <summary>
		/// Generates a new random seed.
		/// </summary>
		public void GenerateNewSeed()
			=> E_FRandomStream_GenerateNewSeed(this);
		
		
		/// <summary>
		/// Gets the current seed.
		/// </summary>
		/// <return>Current</return>
		public int GetCurrentSeed()
			=> E_FRandomStream_GetCurrentSeed(this);
		
		
		/// <summary>
		/// Returns a random number between 0 and 1.
		/// </summary>
		/// <return>Random</return>
		public float GetFraction()
			=> E_FRandomStream_GetFraction(this);
		
		public int GetInitialSeed()
			=> E_FRandomStream_GetInitialSeed(this);
		
		
		/// <summary>
		/// Returns a random vector of unit size.
		/// </summary>
		/// <return>Random</return>
		public FVector GetUnitVector()
			=> E_FRandomStream_GetUnitVector(this);
		
		
		/// <summary>
		/// Initializes this random stream with the specified seed value.
		/// </summary>
		/// <param name="inSeed">The seed value.</param>
		public void Initialize(int inSeed)
			=> E_FRandomStream_Initialize(this, inSeed);
		
		
		/// <summary>
		/// Helper function for rand implementations.
		/// </summary>
		/// <return>A</return>
		public int RandHelper(int a)
			=> E_FRandomStream_RandHelper(this, a);
		
		
		/// <summary>
		/// Helper function for rand implementations.
		/// </summary>
		/// <return>A</return>
		public int RandRange(int min, int max)
			=> E_FRandomStream_RandRange(this, min, max);
		
		
		/// <summary>
		/// Resets this random stream to the initial seed value.
		/// </summary>
		public void Reset()
			=> E_FRandomStream_Reset(this);
		
		
		/// <summary>
		/// Returns a random vector of unit size.
		/// </summary>
		/// <return>Random</return>
		public FVector VRand()
			=> E_FRandomStream_VRand(this);
		
		
		/// <summary>
		/// Returns a random unit vector, uniformly distributed, within the specified cone.
		/// </summary>
		/// <param name="dir">The center direction of the cone</param>
		/// <param name="coneHalfAngleRad">Half-angle of cone, in radians.</param>
		/// <return>Normalized</return>
		public FVector VRandCone(FVector dir, float coneHalfAngleRad)
			=> E_FRandomStream_VRandCone(this, dir, coneHalfAngleRad);
		
		
		/// <summary>
		/// Returns a random unit vector, uniformly distributed, within the specified cone.
		/// </summary>
		/// <param name="dir">The center direction of the cone</param>
		/// <param name="horizontalConeHalfAngleRad">Horizontal half-angle of cone, in radians.</param>
		/// <param name="verticalConeHalfAngleRad">Vertical half-angle of cone, in radians.</param>
		/// <return>Normalized</return>
		public FVector VRandCone(FVector dir, float horizontalConeHalfAngleRad, float verticalConeHalfAngleRad)
			=> E_FRandomStream_VRandCone_o1(this, dir, horizontalConeHalfAngleRad, verticalConeHalfAngleRad);
		
		#endregion
		
		public static implicit operator IntPtr(FRandomStream self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FRandomStream(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FRandomStream(Adress, false);
		}}}
