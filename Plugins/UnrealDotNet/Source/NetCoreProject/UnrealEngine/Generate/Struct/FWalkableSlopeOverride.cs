using System;
using System.Runtime.InteropServices;

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

		public FWalkableSlopeOverride(EWalkableSlopeBehavior NewSlopeBehavior, float NewSlopeAngle) :
			base(E_CreateStruct_FWalkableSlopeOverride_EWalkableSlopeBehavior_float((byte)NewSlopeBehavior, NewSlopeAngle), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FWalkableSlopeOverride();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FWalkableSlopeOverride_EWalkableSlopeBehavior_float(byte NewSlopeBehavior, float NewSlopeAngle);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FWalkableSlopeOverride_GetWalkableSlopeAngle(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_FWalkableSlopeOverride_GetWalkableSlopeBehavior(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_FWalkableSlopeOverride_ModifyWalkableFloorZ(IntPtr Self, float InWalkableFloorZ);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FWalkableSlopeOverride_SetWalkableSlopeAngle(IntPtr Self, float NewSlopeAngle);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FWalkableSlopeOverride_SetWalkableSlopeBehavior(IntPtr Self, byte NewSlopeBehavior);
		
		#endregion
		
		#region ExternMethods
		public float GetWalkableSlopeAngle()
			=> E_FWalkableSlopeOverride_GetWalkableSlopeAngle(this);
		
		public EWalkableSlopeBehavior GetWalkableSlopeBehavior()
			=> (EWalkableSlopeBehavior)E_FWalkableSlopeOverride_GetWalkableSlopeBehavior(this);
		
		public float ModifyWalkableFloorZ(float InWalkableFloorZ)
			=> E_FWalkableSlopeOverride_ModifyWalkableFloorZ(this, InWalkableFloorZ);
		
		public void SetWalkableSlopeAngle(float NewSlopeAngle)
			=> E_FWalkableSlopeOverride_SetWalkableSlopeAngle(this, NewSlopeAngle);
		
		public void SetWalkableSlopeBehavior(EWalkableSlopeBehavior NewSlopeBehavior)
			=> E_FWalkableSlopeOverride_SetWalkableSlopeBehavior(this, (byte)NewSlopeBehavior);
		
		#endregion
		
		public static implicit operator IntPtr(FWalkableSlopeOverride Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FWalkableSlopeOverride(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FWalkableSlopeOverride(Adress, false);
		}}}
