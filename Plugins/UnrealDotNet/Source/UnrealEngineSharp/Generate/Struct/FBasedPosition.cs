// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\EngineTypes.h:1363

namespace UnrealEngine
{
	public  partial class FBasedPosition : NativeStructWrapper
	{
		internal FBasedPosition(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FBasedPosition() :
			base(E_CreateStruct_FBasedPosition(), false)
		{
		}

		public FBasedPosition(AActor inBase, FVector inPosition) :
			base(E_CreateStruct_FBasedPosition_AActor_FVector(inBase, inPosition), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_PROP_FBasedPosition_Base_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FBasedPosition_Base_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FBasedPosition_CachedBaseLocation_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FBasedPosition_CachedBaseLocation_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FBasedPosition_CachedBaseRotation_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FBasedPosition_CachedBaseRotation_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FBasedPosition_CachedTransPosition_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FBasedPosition_CachedTransPosition_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_FBasedPosition_Position_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FBasedPosition_Position_SET(IntPtr Ptr, IntPtr Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FBasedPosition();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FBasedPosition_AActor_FVector(IntPtr inBase, IntPtr inPosition);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FBasedPosition_Clear(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FBasedPosition_Set(IntPtr self, IntPtr inBase, IntPtr inPosition);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// Actor that is the base
		/// </summary>
		public AActor Base
		{
			get => E_PROP_FBasedPosition_Base_GET(NativePointer);
			set => E_PROP_FBasedPosition_Base_SET(NativePointer, value);
		}

		public FVector CachedBaseLocation
		{
			get => E_PROP_FBasedPosition_CachedBaseLocation_GET(NativePointer);
			set => E_PROP_FBasedPosition_CachedBaseLocation_SET(NativePointer, value);
		}

		public FRotator CachedBaseRotation
		{
			get => E_PROP_FBasedPosition_CachedBaseRotation_GET(NativePointer);
			set => E_PROP_FBasedPosition_CachedBaseRotation_SET(NativePointer, value);
		}

		public FVector CachedTransPosition
		{
			get => E_PROP_FBasedPosition_CachedTransPosition_GET(NativePointer);
			set => E_PROP_FBasedPosition_CachedTransPosition_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Position relative to the base actor
		/// </summary>
		public FVector Position
		{
			get => E_PROP_FBasedPosition_Position_GET(NativePointer);
			set => E_PROP_FBasedPosition_Position_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Clear base/position
		/// </summary>
		public void Clear()
			=> E_FBasedPosition_Clear(this);
		
		
		/// <summary>
		/// Updates base/position
		/// </summary>
		public void Set(AActor inBase, FVector inPosition)
			=> E_FBasedPosition_Set(this, inBase, inPosition);
		
		#endregion
		
		public static implicit operator IntPtr(FBasedPosition self)
		{
			return self.NativePointer;
		}

		public static implicit operator FBasedPosition(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FBasedPosition(Adress, false);
		}}}
