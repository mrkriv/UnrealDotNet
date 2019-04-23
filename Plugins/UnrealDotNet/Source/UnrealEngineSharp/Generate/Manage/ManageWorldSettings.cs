// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\GameFramework\WorldSettings.h:395

namespace UnrealEngine
{
	[ManageType("ManageWorldSettings")]
	public partial class ManageWorldSettings : AWorldSettings
	{
		public ManageWorldSettings(IntPtr Adress)
			: base(Adress)
		{
		}

		
		/// <summary>
		/// <para>Called from GameStateBase, calls BeginPlay on all actors </para>
		/// </summary>
		public override void NotifyBeginPlay() { }
		
		
		/// <summary>
		/// <para>Called from GameStateBase, used to notify native classes of match startup (such as level scripting) </para>
		/// </summary>
		public override void NotifyMatchStarted() { }
		
		public override void OnRep_WorldGravityZ() { }
		
		public static implicit operator IntPtr(ManageWorldSettings self)
		{
			return self.NativePointer;
		}

		public static implicit operator ManageWorldSettings(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageWorldSettings>(PtrDesc);
		}}}
