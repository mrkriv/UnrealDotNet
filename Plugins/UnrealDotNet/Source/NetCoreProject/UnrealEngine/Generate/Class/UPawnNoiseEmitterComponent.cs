using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class UPawnNoiseEmitterComponent : UActorComponent
	{
		public UPawnNoiseEmitterComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public UPawnNoiseEmitterComponent(UObject Parent = null, string Name = "PawnNoiseEmitterComponent")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UPawnNoiseEmitterComponent(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UPawnNoiseEmitterComponent(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_UPawnNoiseEmitterComponent_LastRemoteNoisePosition_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UPawnNoiseEmitterComponent_LastRemoteNoisePosition_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UPawnNoiseEmitterComponent_NoiseLifetime_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UPawnNoiseEmitterComponent_NoiseLifetime_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UPawnNoiseEmitterComponent_GetLastNoiseTime(IntPtr Self, bool bSourceWithinNoiseEmitter);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UPawnNoiseEmitterComponent_GetLastNoiseVolume(IntPtr Self, bool bSourceWithinNoiseEmitter);
		
		#endregion
		
		#region Property
		public FVector LastRemoteNoisePosition
		{
			get => E_PROP_UPawnNoiseEmitterComponent_LastRemoteNoisePosition_GET(NativePointer);
			set => E_PROP_UPawnNoiseEmitterComponent_LastRemoteNoisePosition_SET(NativePointer, value);
		}

		public float NoiseLifetime
		{
			get => E_PROP_UPawnNoiseEmitterComponent_NoiseLifetime_GET(NativePointer);
			set => E_PROP_UPawnNoiseEmitterComponent_NoiseLifetime_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		public float GetLastNoiseTime(bool bSourceWithinNoiseEmitter)
			=> E_UPawnNoiseEmitterComponent_GetLastNoiseTime(this, bSourceWithinNoiseEmitter);
		
		public float GetLastNoiseVolume(bool bSourceWithinNoiseEmitter)
			=> E_UPawnNoiseEmitterComponent_GetLastNoiseVolume(this, bSourceWithinNoiseEmitter);
		
		#endregion
		
		public static implicit operator IntPtr(UPawnNoiseEmitterComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator UPawnNoiseEmitterComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UPawnNoiseEmitterComponent>(PtrDesc);
		}}}
