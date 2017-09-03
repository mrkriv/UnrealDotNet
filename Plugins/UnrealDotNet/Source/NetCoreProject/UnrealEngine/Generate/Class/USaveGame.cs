using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// Класс не может быть наследован в Вашем коде, используйте ManageSaveGame
	/// <para>This class acts as a base class for a save game object that can be used to save state about the game. </para>
	/// <para>When you create your own save game subclass, you would add member variables for the information that you want to save. </para>
	/// <para>Then when you want to save a game, create an instance of this object using CreateSaveGameObject, fill in the data, and use SaveGameToSlot, providing a slot name. </para>
	/// <para>To load the game you then just use LoadGameFromSlot, and read the data from the resulting object. </para>
	/// <para>@see https://docs.unrealengine.com/latest/INT/Gameplay/SaveGame </para>
	/// </summary>
	public  partial class USaveGame : UObject
	{
		public USaveGame(IntPtr Adress)
			: base(Adress)
		{
		}

		
		public static implicit operator IntPtr(USaveGame Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator USaveGame(IntPtr Adress)
		{
			if (Adress == IntPtr.Zero)
				return null;
			return NativeManager.GetWrapper(Adress) as USaveGame ?? new USaveGame(Adress);
		}}}
