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
		/// <para>Turns standby detection on/off </para>
		/// <param name="bIsEnabled">true to turn it on, false to disable it </param>
		/// </summary>
		public override void EnableStandbyCheatDetection(bool bIsEnabled) { }
		
		
		/// <summary>
		/// <para>Notifies the game code that a standby cheat was detected </para>
		/// <param name="StandbyType">the type of cheat detected </param>
		/// </summary>
		public override void StandbyCheatDetected(EStandbyType standbyType) { }
		
		
		/// <summary>
		/// <para>Update network speeds for listen servers based on number of connected players. </para>
		/// </summary>
		public override void UpdateNetSpeeds(bool bIsLanMatch) { }
		
		
		/// <summary>
		/// <para>Timer which calls UpdateNetSpeeds() once a second. </para>
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
