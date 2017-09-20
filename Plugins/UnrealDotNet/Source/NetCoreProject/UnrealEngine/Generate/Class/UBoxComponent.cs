using System;
using System.Runtime.InteropServices;

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
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UBoxComponent(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_UBoxComponent_BoxExtent_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UBoxComponent_BoxExtent_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UBoxComponent_GetScaledBoxExtent(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UBoxComponent_GetUnscaledBoxExtent(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UBoxComponent_InitBoxExtent(IntPtr Self, IntPtr InBoxExtent);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UBoxComponent_SetBoxExtent(IntPtr Self, IntPtr InBoxExtent, bool bUpdateOverlaps);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// <para>The extents (radii dimensions) of the box </para>
		/// </summary>
		protected FVector BoxExtent
		{
			get => E_PROP_UBoxComponent_BoxExtent_GET(NativePointer);
			set => E_PROP_UBoxComponent_BoxExtent_SET(NativePointer, value);
		}

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
		/// <para>@param	InBoxExtent: new extent (radius) for the box. </para>
		/// <para>@param	bUpdateOverlaps: if true and this shape is registered and collides, updates touching array for owner actor. </para>
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
