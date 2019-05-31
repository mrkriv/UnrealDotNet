// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\RootMotionSource.h:20

namespace UnrealEngine
{
	public  partial class RootMotionSourceDebug : NativeStructWrapper
	{
		internal RootMotionSourceDebug(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public RootMotionSourceDebug() :
			base(E_CreateStruct_RootMotionSourceDebug(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_RootMotionSourceDebug();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_RootMotionSourceDebug_PrintOnScreen(IntPtr self, IntPtr inCharacter, string inString);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_RootMotionSourceDebug_PrintOnScreenServerMsg(IntPtr self, string inString);
		
		#endregion
		
		#region ExternMethods
		public void PrintOnScreen(ACharacter inCharacter, string inString)
			=> E_RootMotionSourceDebug_PrintOnScreen(this, inCharacter, inString);
		
		public void PrintOnScreenServerMsg(string inString)
			=> E_RootMotionSourceDebug_PrintOnScreenServerMsg(this, inString);
		
		#endregion
		
		public static implicit operator IntPtr(RootMotionSourceDebug self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator RootMotionSourceDebug(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new RootMotionSourceDebug(adress, false);
		}}}
