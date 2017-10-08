using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class UPlanarReflectionComponent : USceneCaptureComponent
	{
		public UPlanarReflectionComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public UPlanarReflectionComponent(UObject Parent = null, string Name = "PlanarReflectionComponent")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UPlanarReflectionComponent(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UPlanarReflectionComponent(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_UPlanarReflectionComponent_GetPlanarReflectionId(IntPtr Self);
		
		#endregion
		
		#region ExternMethods
		public int GetPlanarReflectionId()
			=> E_UPlanarReflectionComponent_GetPlanarReflectionId(this);
		
		#endregion
		
		public static implicit operator IntPtr(UPlanarReflectionComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator UPlanarReflectionComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UPlanarReflectionComponent>(PtrDesc);
		}}}
