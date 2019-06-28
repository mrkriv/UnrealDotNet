// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\Navigation\MetaNavMeshPath.h:20

namespace UnrealEngine
{
	public partial class FMetaPathWayPoint : FVector
	{
		public FMetaPathWayPoint(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FMetaPathWayPoint() :
			base(E_CreateStruct_FMetaPathWayPoint(), false)
		{
		}

		public FMetaPathWayPoint(FVector location) :
			base(E_CreateStruct_FMetaPathWayPoint_FVector(location), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FMetaPathWayPoint();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FMetaPathWayPoint_FVector(IntPtr location);
		
		#endregion
		
		public static implicit operator IntPtr(FMetaPathWayPoint self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FMetaPathWayPoint(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FMetaPathWayPoint(adress, false);
		}}}
