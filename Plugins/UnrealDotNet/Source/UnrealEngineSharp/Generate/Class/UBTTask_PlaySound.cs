// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\BehaviorTree\Tasks\BTTask_PlaySound.h:17

namespace UnrealEngine
{
	public partial class UBTTask_PlaySound : UBTTaskNode
	{
		public UBTTask_PlaySound(IntPtr adress)
			: base(adress)
		{
		}

		public UBTTask_PlaySound(UObject Parent = null, string Name = "BTTask_PlaySound")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UBTTask_PlaySound(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UBTTask_PlaySound(IntPtr Parent, string Name);
		
		#endregion
		
		public static implicit operator IntPtr(UBTTask_PlaySound self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UBTTask_PlaySound(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UBTTask_PlaySound>(PtrDesc);
		}}}
