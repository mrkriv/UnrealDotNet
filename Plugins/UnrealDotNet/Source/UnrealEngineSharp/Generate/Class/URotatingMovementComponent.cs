// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\RotatingMovementComponent.h:16

namespace UnrealEngine
{
	public  partial class URotatingMovementComponent : UMovementComponent
	{
		public URotatingMovementComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public URotatingMovementComponent(UObject Parent = null, string Name = "RotatingMovementComponent")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_URotatingMovementComponent(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_URotatingMovementComponent(IntPtr Parent, string Name);
		
		#endregion
		
		public static implicit operator IntPtr(URotatingMovementComponent self)
		{
			return self.NativePointer;
		}

		public static implicit operator URotatingMovementComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<URotatingMovementComponent>(PtrDesc);
		}}}
