// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\GameNetworkManager.h:27

namespace UnrealEngine
{
	[ManageType("ManageGameNetworkManager")]
	public partial class ManageGameNetworkManager : AGameNetworkManager
	{
		public ManageGameNetworkManager(IntPtr Adress)
			: base(Adress)
		{
		}

		
		/// <summary>
		/// Turns standby detection on/off
		/// </summary>
		/// <param name="bIsEnabled">true to turn it on, false to disable it</param>
		public override void EnableStandbyCheatDetection(bool bIsEnabled) { }
		
		
		/// <summary>
		/// Notifies the game code that a standby cheat was detected
		/// </summary>
		/// <param name="standbyType">the type of cheat detected</param>
		public override void StandbyCheatDetected(EStandbyType standbyType) { }
		
		
		/// <summary>
		/// Update network speeds for listen servers based on number of connected players.
		/// </summary>
		public override void UpdateNetSpeeds(bool bIsLanMatch) { }
		
		
		/// <summary>
		/// Timer which calls UpdateNetSpeeds() once a second.
		/// </summary>
		public override void UpdateNetSpeedsTimer() { }
		
		public static implicit operator IntPtr(ManageGameNetworkManager self)
		{
			return self.NativePointer;
		}

		public static implicit operator ManageGameNetworkManager(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageGameNetworkManager>(PtrDesc);
		}}}
