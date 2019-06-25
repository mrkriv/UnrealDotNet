// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\DataProviders\AIDataProvider.h:138

namespace UnrealEngine
{
	public partial class UAIDataProvider : UObject
	{
		public UAIDataProvider(IntPtr adress)
			: base(adress)
		{
		}

		public UAIDataProvider(UObject Parent = null, string Name = "AIDataProvider")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UAIDataProvider(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UAIDataProvider(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAIDataProvider_BindData(IntPtr self, IntPtr owner, int requestId);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_UAIDataProvider_ToString(IntPtr self, string propName);
		
		#endregion
		
		#region ExternMethods
		public virtual void BindData(UObject owner, int requestId)
			=> E_UAIDataProvider_BindData(this, owner, requestId);
		
		public virtual string ToString(string propName)
			=> E_UAIDataProvider_ToString(this, propName);
		
		#endregion
		
		public static implicit operator IntPtr(UAIDataProvider self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UAIDataProvider(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UAIDataProvider>(PtrDesc);
		}}}
