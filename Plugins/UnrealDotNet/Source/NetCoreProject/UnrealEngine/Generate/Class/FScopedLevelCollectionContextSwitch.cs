using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// A helper RAII class to set the relevant context on a UWorld for a particular FLevelCollection within a scope.
	/// The constructor will set the PersistentLevel, GameState, NetDriver, and DemoNetDriver on the world and
	/// the destructor will restore the original values.
	/// </summary>
	public partial class FScopedLevelCollectionContextSwitch
	{
		protected readonly IntPtr NativePointer;
		
		public FScopedLevelCollectionContextSwitch(IntPtr Adress)
		{
			NativePointer = Adress;
		}

		
		public static implicit operator IntPtr(FScopedLevelCollectionContextSwitch Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FScopedLevelCollectionContextSwitch(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FScopedLevelCollectionContextSwitch(Adress);
		}}}
