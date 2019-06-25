// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\Perception\AIPerceptionListenerInterface.h:18

namespace UnrealEngine
{
	public partial class IAIPerceptionListenerInterface : NativeWrapper
	{
		public IAIPerceptionListenerInterface(IntPtr adress)
			: base(adress)
		{
		}

		public IAIPerceptionListenerInterface(UObject Parent = null, string Name = "AIPerceptionListenerInterface")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_IAIPerceptionListenerInterface(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_IAIPerceptionListenerInterface(IntPtr Parent, string Name);
		
		#endregion
		
		public static implicit operator IntPtr(IAIPerceptionListenerInterface self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator IAIPerceptionListenerInterface(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<IAIPerceptionListenerInterface>(PtrDesc);
		}}}
