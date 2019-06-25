// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\Perception\AIPerceptionSystem.h:29

namespace UnrealEngine
{
	public partial class UAIPerceptionSystem : UAISubsystem
	{
		public UAIPerceptionSystem(IntPtr adress)
			: base(adress)
		{
		}

		public UAIPerceptionSystem(UObject Parent = null, string Name = "AIPerceptionSystem")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UAIPerceptionSystem(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UAIPerceptionSystem(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAIPerceptionSystem_UnregisterListener(IntPtr self, IntPtr listener);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAIPerceptionSystem_UpdateListener(IntPtr self, IntPtr listener);
		
		#endregion
		
		#region ExternMethods
		public void UnregisterListener(UAIPerceptionComponent listener)
			=> E_UAIPerceptionSystem_UnregisterListener(this, listener);
		
		
		/// <summary>
		/// Registers listener if not registered
		/// </summary>
		public void UpdateListener(UAIPerceptionComponent listener)
			=> E_UAIPerceptionSystem_UpdateListener(this, listener);
		
		#endregion
		
		public static implicit operator IntPtr(UAIPerceptionSystem self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UAIPerceptionSystem(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UAIPerceptionSystem>(PtrDesc);
		}}}
