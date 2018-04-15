using System;
using System.Runtime.InteropServices;

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Components\BoxComponent.h:17

namespace UnrealEngine
{
	public  partial class UBoxComponent : UShapeComponent
	{
		public UBoxComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public UBoxComponent(UObject Parent = null, string Name = "BoxComponent")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UBoxComponent(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UBoxComponent(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UBoxComponent_GetScaledBoxExtent(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UBoxComponent_GetUnscaledBoxExtent(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UBoxComponent_InitBoxExtent(IntPtr Self, IntPtr InBoxExtent);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UBoxComponent_SetBoxExtent(IntPtr Self, IntPtr InBoxExtent, bool bUpdateOverlaps);
		
		#endregion
		
		#region ExternMethods
		public FVector GetScaledBoxExtent()
			=> E_UBoxComponent_GetScaledBoxExtent(this);
		
		public FVector GetUnscaledBoxExtent()
			=> E_UBoxComponent_GetUnscaledBoxExtent(this);
		
		public void InitBoxExtent(FVector InBoxExtent)
			=> E_UBoxComponent_InitBoxExtent(this, InBoxExtent);
		
		
		/// <summary>
		/// <para>Change the box extent size. This is the unscaled size, before component scale is applied. </para>
		/// <param name="InBoxExtent">new extent (radius) for the box. </param>
		/// <param name="bUpdateOverlaps">if true and this shape is registered and collides, updates touching array for owner actor. </param>
		/// </summary>
		public void SetBoxExtent(FVector InBoxExtent, bool bUpdateOverlaps = true)
			=> E_UBoxComponent_SetBoxExtent(this, InBoxExtent, bUpdateOverlaps);
		
		#endregion
		
		public static implicit operator IntPtr(UBoxComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator UBoxComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UBoxComponent>(PtrDesc);
		}}}
