// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\BoxComponent.h:17

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
		private static extern IntPtr E_UBoxComponent_GetScaledBoxExtent(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UBoxComponent_GetUnscaledBoxExtent(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UBoxComponent_InitBoxExtent(IntPtr self, IntPtr inBoxExtent);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UBoxComponent_SetBoxExtent(IntPtr self, IntPtr inBoxExtent, bool bUpdateOverlaps);
		
		#endregion
		
		#region ExternMethods
		public FVector GetScaledBoxExtent()
			=> E_UBoxComponent_GetScaledBoxExtent(this);
		
		public FVector GetUnscaledBoxExtent()
			=> E_UBoxComponent_GetUnscaledBoxExtent(this);
		
		public void InitBoxExtent(FVector inBoxExtent)
			=> E_UBoxComponent_InitBoxExtent(this, inBoxExtent);
		
		
		/// <summary>
		/// <para>Change the box extent size. This is the unscaled size, before component scale is applied. </para>
		/// <param name="InBoxExtent">new extent (radius) for the box. </param>
		/// <param name="bUpdateOverlaps">if true and this shape is registered and collides, updates touching array for owner actor. </param>
		/// </summary>
		public void SetBoxExtent(FVector inBoxExtent, bool bUpdateOverlaps = true)
			=> E_UBoxComponent_SetBoxExtent(this, inBoxExtent, bUpdateOverlaps);
		
		#endregion
		
		public static implicit operator IntPtr(UBoxComponent self)
		{
			return self.NativePointer;
		}

		public static implicit operator UBoxComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UBoxComponent>(PtrDesc);
		}}}
