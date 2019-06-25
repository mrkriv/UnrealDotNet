// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\EnvironmentQuery\Items\EnvQueryItemType.h:15

namespace UnrealEngine
{
	public partial class UEnvQueryItemType : UObject
	{
		public UEnvQueryItemType(IntPtr adress)
			: base(adress)
		{
		}

		public UEnvQueryItemType(UObject Parent = null, string Name = "EnvQueryItemType")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UEnvQueryItemType(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UEnvQueryItemType(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_UEnvQueryItemType_GetDescription(IntPtr self, byte rawData);
		
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// describe item
		/// </summary>
		public virtual string GetDescription(byte rawData)
			=> E_UEnvQueryItemType_GetDescription(this, rawData);
		
		#endregion
		
		public static implicit operator IntPtr(UEnvQueryItemType self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UEnvQueryItemType(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UEnvQueryItemType>(PtrDesc);
		}}}
