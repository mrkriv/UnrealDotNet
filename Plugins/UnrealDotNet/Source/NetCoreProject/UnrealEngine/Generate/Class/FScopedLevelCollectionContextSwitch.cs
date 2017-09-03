using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// Класс не может быть наследован в Вашем коде, используйте ManageScopedLevelCollectionContextSwitch
	/// <para>A helper RAII class to set the relevant context on a UWorld for a particular FLevelCollection within a scope. </para>
	/// <para>The constructor will set the PersistentLevel, GameState, NetDriver, and DemoNetDriver on the world and </para>
	/// <para>the destructor will restore the original values. </para>
	/// </summary>
	public  partial class FScopedLevelCollectionContextSwitch : NativeWrapper
	{
		public FScopedLevelCollectionContextSwitch(IntPtr Adress)
			: base(Adress)
		{
		}

		
		public static implicit operator IntPtr(FScopedLevelCollectionContextSwitch Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FScopedLevelCollectionContextSwitch(IntPtr Adress)
		{
			if (Adress == IntPtr.Zero)
				return null;
			return NativeManager.GetWrapper(Adress) as FScopedLevelCollectionContextSwitch ?? new FScopedLevelCollectionContextSwitch(Adress);
		}}}
