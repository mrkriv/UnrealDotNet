// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\VisualLoggerExtension.h:48

namespace UnrealEngine
{
	public partial class UVisualLoggerExtension : UObject
	{
		public UVisualLoggerExtension(IntPtr adress)
			: base(adress)
		{
		}

		public UVisualLoggerExtension(UObject Parent = null, string Name = "VisualLoggerExtension")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UVisualLoggerExtension(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UVisualLoggerExtension(IntPtr Parent, string Name);
		
		#endregion
		
		public static implicit operator IntPtr(UVisualLoggerExtension self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UVisualLoggerExtension(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UVisualLoggerExtension>(PtrDesc);
		}}}
