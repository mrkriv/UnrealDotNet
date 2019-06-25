// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\EnvironmentQuery\EQSQueryResultSourceInterface.h:16

namespace UnrealEngine
{
	public partial class IEQSQueryResultSourceInterface : NativeWrapper
	{
		public IEQSQueryResultSourceInterface(IntPtr adress)
			: base(adress)
		{
		}

		public IEQSQueryResultSourceInterface(UObject Parent = null, string Name = "EQSQueryResultSourceInterface")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_IEQSQueryResultSourceInterface(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_IEQSQueryResultSourceInterface(IntPtr Parent, string Name);
		
		#endregion
		
		public static implicit operator IntPtr(IEQSQueryResultSourceInterface self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator IEQSQueryResultSourceInterface(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<IEQSQueryResultSourceInterface>(PtrDesc);
		}}}
