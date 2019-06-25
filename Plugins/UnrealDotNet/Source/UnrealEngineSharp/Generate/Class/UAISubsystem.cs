// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\AISubsystem.h:15

namespace UnrealEngine
{
	public partial class UAISubsystem : UObject
	{
		public UAISubsystem(IntPtr adress)
			: base(adress)
		{
		}

		public UAISubsystem(UObject Parent = null, string Name = "AISubsystem")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UAISubsystem(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UAISubsystem(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_UAISubsystem_GetWorldFast(IntPtr self);
		
		#endregion
		
		#region ExternMethods
		public UWorld GetWorldFast()
			=> E_UAISubsystem_GetWorldFast(this);
		
		#endregion
		
		public static implicit operator IntPtr(UAISubsystem self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UAISubsystem(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UAISubsystem>(PtrDesc);
		}}}
