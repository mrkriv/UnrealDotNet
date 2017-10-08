using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class UEngine : UObject
	{
		public UEngine(IntPtr Adress)
			: base(Adress)
		{
		}

		public UEngine(UObject Parent = null, string Name = "Engine")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UEngine(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UEngine(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UEngine_IsInitialized(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UEngine_ParseCommandline(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UEngine_PreExit(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UEngine_RestoreSelectedMaterialColor(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UEngine_ShutdownAudioDeviceManager(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UEngine_ShutdownHMD(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UEngine_Start(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UEngine_Tick(IntPtr Self, float DeltaSeconds, bool bIdleMode);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UEngine_WorldAdded(IntPtr Self, IntPtr World);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UEngine_WorldDestroyed(IntPtr Self, IntPtr InWorld);
		
		#endregion
		
		#region ExternMethods
		public virtual bool IsInitialized()
			=> E_UEngine_IsInitialized(this);
		
		
		/// <summary>
		/// <para>Called at startup, in the middle of FEngineLoop::Init. </para>
		/// </summary>
		public void ParseCommandline()
			=> E_UEngine_ParseCommandline(this);
		
		
		/// <summary>
		/// <para>Called at shutdown, just before the exit purge. </para>
		/// </summary>
		public virtual void PreExit()
			=> E_UEngine_PreExit(this);
		
		
		/// <summary>
		/// <para>Restores the selected material color back to the user setting </para>
		/// </summary>
		public void RestoreSelectedMaterialColor()
			=> E_UEngine_RestoreSelectedMaterialColor(this);
		
		public virtual void ShutdownAudioDeviceManager()
			=> E_UEngine_ShutdownAudioDeviceManager(this);
		
		public void ShutdownHMD()
			=> E_UEngine_ShutdownHMD(this);
		
		
		/// <summary>
		/// <para>Start the game, separate from the initialize call to allow for post initialize configuration before the game starts. </para>
		/// </summary>
		public virtual void Start()
			=> E_UEngine_Start(this);
		
		
		/// <summary>
		/// <para>Update everything. </para>
		/// </summary>
		public virtual void Tick(float DeltaSeconds, bool bIdleMode)
			=> E_UEngine_Tick(this, DeltaSeconds, bIdleMode);
		
		
		/// <summary>
		/// <para>Needs to be called when a world is added to broadcast messages. </para>
		/// </summary>
		public virtual void WorldAdded(UWorld World)
			=> E_UEngine_WorldAdded(this, World);
		
		
		/// <summary>
		/// <para>Needs to be called when a world is destroyed to broadcast messages. </para>
		/// </summary>
		public virtual void WorldDestroyed(UWorld InWorld)
			=> E_UEngine_WorldDestroyed(this, InWorld);
		
		#endregion
		
		public static implicit operator IntPtr(UEngine Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator UEngine(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UEngine>(PtrDesc);
		}}}
