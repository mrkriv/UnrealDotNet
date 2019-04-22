// This file was created automatically, do not modify the contents of this file.

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\Engine.h:637

namespace UnrealEngine
{
	[ManageType("ManageEngine")]
	public partial class ManageEngine : UEngine
	{
		public ManageEngine(IntPtr Adress)
			: base(Adress)
		{
		}

		
		/// <summary>
		/// <para>Called at shutdown, just before the exit purge. </para>
		/// </summary>
		public override void PreExit() { }
		
		public override void ShutdownAudioDeviceManager() { }
		
		
		/// <summary>
		/// <para>Start the game, separate from the initialize call to allow for post initialize configuration before the game starts. </para>
		/// </summary>
		public override void Start() { }
		
		
		/// <summary>
		/// <para>Update everything. </para>
		/// </summary>
		public override void Tick(float deltaSeconds, bool bIdleMode) { }
		
		
		/// <summary>
		/// <para>Needs to be called when a world is added to broadcast messages. </para>
		/// </summary>
		public override void WorldAdded(UWorld world) { }
		
		
		/// <summary>
		/// <para>Needs to be called when a world is destroyed to broadcast messages. </para>
		/// </summary>
		public override void WorldDestroyed(UWorld inWorld) { }
		
		public static implicit operator IntPtr(ManageEngine self)
		{
			return self.NativePointer;
		}

		public static implicit operator ManageEngine(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageEngine>(PtrDesc);
		}}}
