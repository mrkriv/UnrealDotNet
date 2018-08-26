// This file was created automatically, do not modify the contents of this file.

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\Engine\Player.h:17

namespace UnrealEngine
{
	[ManageType("ManagePlayer")]
	public partial class ManagePlayer : UPlayer
	{
		public ManagePlayer(IntPtr Adress)
			: base(Adress)
		{
		}

		public static implicit operator IntPtr(ManagePlayer self)
		{
			return self.NativePointer;
		}

		public static implicit operator ManagePlayer(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManagePlayer>(PtrDesc);
		}}}
