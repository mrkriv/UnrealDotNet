// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\Player.h:17

namespace UnrealEngine
{
	[ManageType("ManagePlayer")]
	public partial class ManagePlayer : UPlayer
	{
		public ManagePlayer(IntPtr Adress)
			: base(Adress)
		{
		}

		
		/// <summary>
		/// <para>Dynamically assign Controller to Player and set viewport. </para>
		/// <param name="PC">new player controller to assign to player </param>
		/// </summary>
		public override void SwitchController(APlayerController pC) { }
		
		public static implicit operator IntPtr(ManagePlayer self)
		{
			return self.NativePointer;
		}

		public static implicit operator ManagePlayer(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManagePlayer>(PtrDesc);
		}}}
