// This file was created automatically, do not modify the contents of this file.

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\Engine\EngineTypes.h:3172

namespace UnrealEngine
{
	public  partial class FWalkableSlopeOverride : NativeStructWrapper
	{
		internal FWalkableSlopeOverride(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FWalkableSlopeOverride() :
			base(E_CreateStruct_FWalkableSlopeOverride(), false)
		{
		}

		public FWalkableSlopeOverride(EWalkableSlopeBehavior newSlopeBehavior, float newSlopeAngle) :
			base(E_CreateStruct_FWalkableSlopeOverride_EWalkableSlopeBehavior_float((byte)newSlopeBehavior, newSlopeAngle), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FWalkableSlopeOverride();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FWalkableSlopeOverride_EWalkableSlopeBehavior_float(byte newSlopeBehavior, float newSlopeAngle);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FWalkableSlopeOverride_WalkableSlopeAngle_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FWalkableSlopeOverride_WalkableSlopeAngle_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FWalkableSlopeOverride_GetWalkableSlopeAngle(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_FWalkableSlopeOverride_GetWalkableSlopeBehavior(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FWalkableSlopeOverride_ModifyWalkableFloorZ(IntPtr self, float inWalkableFloorZ);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FWalkableSlopeOverride_SetWalkableSlopeAngle(IntPtr self, float newSlopeAngle);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FWalkableSlopeOverride_SetWalkableSlopeBehavior(IntPtr self, byte newSlopeBehavior);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// <para>Override walkable slope angle (in degrees), applying the rules of the Walkable Slope Behavior. </para>
		/// <para>@see GetWalkableSlopeAngle(), SetWalkableSlopeAngle() </para>
		/// </summary>
		public float WalkableSlopeAngle
		{
			get => E_PROP_FWalkableSlopeOverride_WalkableSlopeAngle_GET(NativePointer);
			set => E_PROP_FWalkableSlopeOverride_WalkableSlopeAngle_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		public float GetWalkableSlopeAngle()
			=> E_FWalkableSlopeOverride_GetWalkableSlopeAngle(this);
		
		public EWalkableSlopeBehavior GetWalkableSlopeBehavior()
			=> (EWalkableSlopeBehavior)E_FWalkableSlopeOverride_GetWalkableSlopeBehavior(this);
		
		public float ModifyWalkableFloorZ(float inWalkableFloorZ)
			=> E_FWalkableSlopeOverride_ModifyWalkableFloorZ(this, inWalkableFloorZ);
		
		public void SetWalkableSlopeAngle(float newSlopeAngle)
			=> E_FWalkableSlopeOverride_SetWalkableSlopeAngle(this, newSlopeAngle);
		
		public void SetWalkableSlopeBehavior(EWalkableSlopeBehavior newSlopeBehavior)
			=> E_FWalkableSlopeOverride_SetWalkableSlopeBehavior(this, (byte)newSlopeBehavior);
		
		#endregion
		
		public static implicit operator IntPtr(FWalkableSlopeOverride self)
		{
			return self.NativePointer;
		}

		public static implicit operator FWalkableSlopeOverride(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FWalkableSlopeOverride(Adress, false);
		}}}
