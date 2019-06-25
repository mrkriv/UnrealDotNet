// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\Perception\AISenseConfig_Touch.h:13

namespace UnrealEngine
{
	public partial class UAISenseConfig_Touch : UAISenseConfig
	{
		public UAISenseConfig_Touch(IntPtr adress)
			: base(adress)
		{
		}

		public UAISenseConfig_Touch(UObject Parent = null, string Name = "AISenseConfig_Touch")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UAISenseConfig_Touch(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UAISenseConfig_Touch(IntPtr Parent, string Name);
		
		#endregion
		
		public static implicit operator IntPtr(UAISenseConfig_Touch self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UAISenseConfig_Touch(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UAISenseConfig_Touch>(PtrDesc);
		}}}
