// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\Perception\AISenseEvent.h:13

namespace UnrealEngine
{
	public partial class UAISenseEvent : UObject
	{
		public UAISenseEvent(IntPtr adress)
			: base(adress)
		{
		}

		public UAISenseEvent(UObject Parent = null, string Name = "AISenseEvent")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UAISenseEvent(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UAISenseEvent(IntPtr Parent, string Name);
		
		#endregion
		
		public static implicit operator IntPtr(UAISenseEvent self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UAISenseEvent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UAISenseEvent>(PtrDesc);
		}}}
