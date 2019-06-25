// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\Perception\AISenseConfig_Blueprint.h:15

namespace UnrealEngine
{
	public partial class UAISenseConfig_Blueprint : UAISenseConfig
	{
		public UAISenseConfig_Blueprint(IntPtr adress)
			: base(adress)
		{
		}

		public UAISenseConfig_Blueprint(UObject Parent = null, string Name = "AISenseConfig_Blueprint")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UAISenseConfig_Blueprint(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UAISenseConfig_Blueprint(IntPtr Parent, string Name);
		
		#endregion
		
		public static implicit operator IntPtr(UAISenseConfig_Blueprint self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UAISenseConfig_Blueprint(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UAISenseConfig_Blueprint>(PtrDesc);
		}}}
