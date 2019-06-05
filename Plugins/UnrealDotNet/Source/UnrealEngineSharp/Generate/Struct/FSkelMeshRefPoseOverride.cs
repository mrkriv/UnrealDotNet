// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\SkinnedMeshComponent.h:178

namespace UnrealEngine
{
	public partial class FSkelMeshRefPoseOverride : NativeStructWrapper
	{
		public FSkelMeshRefPoseOverride(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FSkelMeshRefPoseOverride() :
			base(E_CreateStruct_FSkelMeshRefPoseOverride(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FSkelMeshRefPoseOverride();
		
		#endregion
		
		public static implicit operator IntPtr(FSkelMeshRefPoseOverride self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FSkelMeshRefPoseOverride(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FSkelMeshRefPoseOverride(adress, false);
		}}}
