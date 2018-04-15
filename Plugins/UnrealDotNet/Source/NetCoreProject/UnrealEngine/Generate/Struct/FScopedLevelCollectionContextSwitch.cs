using System;
using System.Runtime.InteropServices;

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Engine\World.h:689

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
		public FScopedLevelCollectionContextSwitch(int InLevelCollectionIndex, UWorld InWorld) :
			base(E_CreateStruct_FScopedLevelCollectionContextSwitch_int32_UWorld(InLevelCollectionIndex, InWorld), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FScopedLevelCollectionContextSwitch_int32_UWorld(int InLevelCollectionIndex, IntPtr InWorld);
		
		#endregion
		
		public static implicit operator IntPtr(FScopedLevelCollectionContextSwitch Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FScopedLevelCollectionContextSwitch(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FScopedLevelCollectionContextSwitch(Adress, false);
		}}}
