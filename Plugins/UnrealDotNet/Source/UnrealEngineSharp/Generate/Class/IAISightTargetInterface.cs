// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\Perception\AISightTargetInterface.h:18

namespace UnrealEngine
{
	public partial class IAISightTargetInterface : NativeWrapper
	{
		public IAISightTargetInterface(IntPtr adress)
			: base(adress)
		{
		}

		public IAISightTargetInterface(UObject Parent = null, string Name = "AISightTargetInterface")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_IAISightTargetInterface(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_IAISightTargetInterface(IntPtr Parent, string Name);
		
		#endregion
		
		public static implicit operator IntPtr(IAISightTargetInterface self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator IAISightTargetInterface(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<IAISightTargetInterface>(PtrDesc);
		}}}
