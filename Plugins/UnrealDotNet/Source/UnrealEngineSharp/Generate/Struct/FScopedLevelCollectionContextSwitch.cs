// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\World.h:659

namespace UnrealEngine
{
	public  partial class FScopedLevelCollectionContextSwitch : NativeStructWrapper
	{
		internal FScopedLevelCollectionContextSwitch(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		
		/// <summary>
		/// Constructor that will save the current relevant values of InWorld
		/// <para>and set the collection's context values for InWorld. </para>
		/// </summary>
		/// <param name="inLevelCollectionIndex">The index of the collection to use</param>
		/// <param name="inWorld">The world on which to set the context.</param>
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
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FScopedLevelCollectionContextSwitch(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FScopedLevelCollectionContextSwitch(Adress, false);
		}}}
