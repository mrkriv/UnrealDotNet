// This file was created automatically, do not modify the contents of this file.

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\Engine\World.h:690

namespace UnrealEngine
{
	public  partial class FScopedLevelCollectionContextSwitch : NativeStructWrapper
	{
		internal FScopedLevelCollectionContextSwitch(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		
		/// <summary>
		/// <para>Constructor that will save the current relevant values of InWorld </para>
		/// <para>and set the collection's context values for InWorld. </para>
		/// <param name="InLevelCollectionIndex">The index of the collection to use </param>
		/// <param name="InWorld">The world on which to set the context. </param>
		/// </summary>
		public FScopedLevelCollectionContextSwitch(int inLevelCollectionIndex, UWorld inWorld) :
			base(E_CreateStruct_FScopedLevelCollectionContextSwitch_int32_UWorld(inLevelCollectionIndex, inWorld), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FScopedLevelCollectionContextSwitch_int32_UWorld(int inLevelCollectionIndex, IntPtr inWorld);
		
		#endregion
		
		public static implicit operator IntPtr(FScopedLevelCollectionContextSwitch self)
		{
			return self.NativePointer;
		}

		public static implicit operator FScopedLevelCollectionContextSwitch(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FScopedLevelCollectionContextSwitch(Adress, false);
		}}}
