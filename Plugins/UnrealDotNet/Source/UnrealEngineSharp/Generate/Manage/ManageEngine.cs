using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\Engine\Engine.h:630

namespace UnrealEngine
{
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
		public override void Tick(float DeltaSeconds, bool bIdleMode) { }
		
		
		/// <summary>
		/// <para>Needs to be called when a world is added to broadcast messages. </para>
		/// </summary>
		public override void WorldAdded(UWorld World) { }
		
		
		/// <summary>
		/// <para>Needs to be called when a world is destroyed to broadcast messages. </para>
		/// </summary>
		public override void WorldDestroyed(UWorld InWorld) { }
		
		public static implicit operator IntPtr(ManageEngine Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator ManageEngine(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageEngine>(PtrDesc);
		}}}
