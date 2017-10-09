using System;
using System.Runtime.InteropServices;

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
		
		public static implicit operator IntPtr(ManageEngine Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator ManageEngine(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<ManageEngine>(PtrDesc);
		}}}
