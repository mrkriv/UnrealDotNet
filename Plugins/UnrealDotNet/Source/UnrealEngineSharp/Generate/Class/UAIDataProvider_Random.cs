// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\DataProviders\AIDataProvider_Random.h:9

namespace UnrealEngine
{
	public partial class UAIDataProvider_Random : UAIDataProvider_QueryParams
	{
		public UAIDataProvider_Random(IntPtr adress)
			: base(adress)
		{
		}

		public UAIDataProvider_Random(UObject Parent = null, string Name = "AIDataProvider_Random")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UAIDataProvider_Random(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UAIDataProvider_Random(IntPtr Parent, string Name);
		
		#endregion
		
		public static implicit operator IntPtr(UAIDataProvider_Random self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UAIDataProvider_Random(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UAIDataProvider_Random>(PtrDesc);
		}}}
