// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\CheatManager.h:69

namespace UnrealEngine
{
	[ManageType("ManageCheatManager")]
	public partial class ManageCheatManager : UCheatManager
	{
		public ManageCheatManager(IntPtr Adress)
			: base(Adress)
		{
		}

		
		/// <summary>
		/// <para>Switch controller from debug camera back to normal controller </para>
		/// </summary>
		protected override void DisableDebugCamera() { }
		
		
		/// <summary>
		/// <para>Switch controller to debug camera without locking gameplay and with locking local player controller input </para>
		/// </summary>
		protected override void EnableDebugCamera() { }
		
		public static implicit operator IntPtr(ManageCheatManager self)
		{
			return self.NativePointer;
		}

		public static implicit operator ManageCheatManager(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageCheatManager>(PtrDesc);
		}}}
