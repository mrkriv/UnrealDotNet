using System;
using System.Runtime.InteropServices;

// Source file C:\Users\vladi\Desktop\Engine\Source\Runtime\GameFramework\SaveGame.h:19

namespace UnrealEngine
{
	public partial class ManageSaveGame : USaveGame
	{
		public ManageSaveGame(IntPtr Adress)
			: base(Adress)
		{
		}

		public static implicit operator IntPtr(ManageSaveGame Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator ManageSaveGame(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageSaveGame>(PtrDesc);
		}}}
