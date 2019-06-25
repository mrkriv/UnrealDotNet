// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\EnvironmentQuery\EnvQueryTypes.h:289

namespace UnrealEngine
{
	public partial class FEnvDirection : NativeStructWrapper
	{
		public FEnvDirection(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FEnvDirection() :
			base(E_CreateStruct_FEnvDirection(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FEnvDirection();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_FEnvDirection_ToText(IntPtr self);
		
		#endregion
		
		#region ExternMethods
		public string ToText()
			=> E_FEnvDirection_ToText(this);
		
		#endregion
		
		public static implicit operator IntPtr(FEnvDirection self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FEnvDirection(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FEnvDirection(adress, false);
		}}}
