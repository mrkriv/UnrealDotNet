using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// This class acts as a base class for a save game object that can be used to save state about the game.
	/// When you create your own save game subclass, you would add member variables for the information that you want to save.
	/// Then when you want to save a game, create an instance of this object using CreateSaveGameObject, fill in the data, and use SaveGameToSlot, providing a slot name.
	/// To load the game you then just use LoadGameFromSlot, and read the data from the resulting object.
	/// @see https://docs.unrealengine.com/latest/INT/Gameplay/SaveGame
	/// </summary>
	public partial class USaveGame : UObject
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
			return Adress == IntPtr.Zero ? null : new USaveGame(Adress);
		}}}
