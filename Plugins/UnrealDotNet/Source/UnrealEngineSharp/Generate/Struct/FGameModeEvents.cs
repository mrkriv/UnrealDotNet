// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\GameModeBase.h:566

namespace UnrealEngine
{
	public  partial class FGameModeEvents : NativeStructWrapper
	{
		internal FGameModeEvents(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FGameModeEvents() :
			base(E_CreateStruct_FGameModeEvents(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FGameModeEvents();
		
		#endregion
		
		public static implicit operator IntPtr(FGameModeEvents self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FGameModeEvents(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FGameModeEvents(adress, false);
		}}}
