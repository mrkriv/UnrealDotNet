// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\Perception\AISenseEvent_Hearing.h:13

namespace UnrealEngine
{
	public partial class UAISenseEvent_Hearing : UAISenseEvent
	{
		public UAISenseEvent_Hearing(IntPtr adress)
			: base(adress)
		{
		}

		public UAISenseEvent_Hearing(UObject Parent = null, string Name = "AISenseEvent_Hearing")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UAISenseEvent_Hearing(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UAISenseEvent_Hearing(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UAISenseEvent_Hearing_GetNoiseEvent(IntPtr self);
		
		#endregion
		
		#region ExternMethods
		public FAINoiseEvent GetNoiseEvent()
			=> E_UAISenseEvent_Hearing_GetNoiseEvent(this);
		
		#endregion
		
		public static implicit operator IntPtr(UAISenseEvent_Hearing self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UAISenseEvent_Hearing(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UAISenseEvent_Hearing>(PtrDesc);
		}}}
