// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\Navigation\PathFollowingManager.h:13

namespace UnrealEngine
{
	public partial class UPathFollowingManager : UObject
	{
		public UPathFollowingManager(IntPtr adress)
			: base(adress)
		{
		}

		public UPathFollowingManager(UObject Parent = null, string Name = "PathFollowingManager")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UPathFollowingManager(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UPathFollowingManager(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UPathFollowingManager_IsFollowingAPath(IntPtr self, IntPtr controller);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UPathFollowingManager_StopMovement(IntPtr self, IntPtr controller);
		
		#endregion
		
		#region ExternMethods
		public bool IsFollowingAPath(AController controller)
			=> E_UPathFollowingManager_IsFollowingAPath(this, controller);
		
		public void StopMovement(AController controller)
			=> E_UPathFollowingManager_StopMovement(this, controller);
		
		#endregion
		
		public static implicit operator IntPtr(UPathFollowingManager self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UPathFollowingManager(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UPathFollowingManager>(PtrDesc);
		}}}
