// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\CheatManager.h:69

namespace UnrealEngine
{
	public  partial class UCheatManager : UObject
	{
		public UCheatManager(IntPtr Adress)
			: base(Adress)
		{
		}

		public UCheatManager(UObject Parent = null, string Name = "CheatManager")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UCheatManager(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UCheatManager(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCheatManager_DisableDebugCamera(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UCheatManager_EnableDebugCamera(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_UCheatManager_GetTarget(IntPtr self, IntPtr playerController, IntPtr outHit);
		
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// <para>Switch controller from debug camera back to normal controller </para>
		/// </summary>
		protected virtual void DisableDebugCamera()
			=> E_UCheatManager_DisableDebugCamera(this);
		
		
		/// <summary>
		/// <para>Switch controller to debug camera without locking gameplay and with locking local player controller input </para>
		/// </summary>
		protected virtual void EnableDebugCamera()
			=> E_UCheatManager_EnableDebugCamera(this);
		
		
		/// <summary>
		/// <para>Retrieve the given PlayerContoller's current "target" AActor. </para>
		/// </summary>
		protected virtual AActor GetTarget(APlayerController playerController, FHitResult outHit)
			=> E_UCheatManager_GetTarget(this, playerController, outHit);
		
		#endregion
		
		public static implicit operator IntPtr(UCheatManager self)
		{
			return self.NativePointer;
		}

		public static implicit operator UCheatManager(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UCheatManager>(PtrDesc);
		}}}
