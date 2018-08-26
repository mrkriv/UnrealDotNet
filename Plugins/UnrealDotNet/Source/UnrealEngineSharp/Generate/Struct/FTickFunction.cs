// This file was created automatically, do not modify the contents of this file.

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\Engine\EngineBaseTypes.h:166

namespace UnrealEngine
{
	public  partial class FTickFunction : NativeStructWrapper
	{
		internal FTickFunction(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		
		/// <summary>
		/// <para>Default constructor, intitalizes to reasonable defaults </para>
		/// </summary>
		public FTickFunction() :
			base(E_CreateStruct_FTickFunction(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FTickFunction();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FTickFunction_bAllowTickOnDedicatedServer_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FTickFunction_bAllowTickOnDedicatedServer_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FTickFunction_bCanEverTick_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FTickFunction_bCanEverTick_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FTickFunction_bHighPriority_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FTickFunction_bHighPriority_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FTickFunction_bRunOnAnyThread_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FTickFunction_bRunOnAnyThread_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FTickFunction_bStartWithTickEnabled_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FTickFunction_bStartWithTickEnabled_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FTickFunction_bTickEvenWhenPaused_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FTickFunction_bTickEvenWhenPaused_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FTickFunction_TickInterval_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FTickFunction_TickInterval_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FTickFunction_IsCompletionHandleValid(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FTickFunction_IsTickFunctionEnabled(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FTickFunction_IsTickFunctionRegistered(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FTickFunction_SetPriorityIncludingPrerequisites(IntPtr self, bool bInHighPriority);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FTickFunction_SetTickFunctionEnable(IntPtr self, bool bInEnabled);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FTickFunction_UnRegisterTickFunction(IntPtr self);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// <para>If we allow this tick to run on a dedicated server </para>
		/// </summary>
		public byte bAllowTickOnDedicatedServer
		{
			get => E_PROP_FTickFunction_bAllowTickOnDedicatedServer_GET(NativePointer);
			set => E_PROP_FTickFunction_bAllowTickOnDedicatedServer_SET(NativePointer, value);
		}

		public byte bCanEverTick
		{
			get => E_PROP_FTickFunction_bCanEverTick_GET(NativePointer);
			set => E_PROP_FTickFunction_bCanEverTick_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Run this tick first within the tick group, presumably to start async tasks that must be completed with this tick group, hiding the latency. </para>
		/// </summary>
		public byte bHighPriority
		{
			get => E_PROP_FTickFunction_bHighPriority_GET(NativePointer);
			set => E_PROP_FTickFunction_bHighPriority_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>If false, this tick will run on the game thread, otherwise it will run on any thread in parallel with the game thread and in parallel with other "async ticks" </para>
		/// </summary>
		public byte bRunOnAnyThread
		{
			get => E_PROP_FTickFunction_bRunOnAnyThread_GET(NativePointer);
			set => E_PROP_FTickFunction_bRunOnAnyThread_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>If true, this tick function will start enabled, but can be disabled later on. </para>
		/// </summary>
		public byte bStartWithTickEnabled
		{
			get => E_PROP_FTickFunction_bStartWithTickEnabled_GET(NativePointer);
			set => E_PROP_FTickFunction_bStartWithTickEnabled_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Bool indicating that this function should execute even if the game is paused. Pause ticks are very limited in capabilities. </para>
		/// </summary>
		public byte bTickEvenWhenPaused
		{
			get => E_PROP_FTickFunction_bTickEvenWhenPaused_GET(NativePointer);
			set => E_PROP_FTickFunction_bTickEvenWhenPaused_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>The frequency in seconds at which this tick function will be executed.  If less than or equal to 0 then it will tick every frame </para>
		/// </summary>
		public float TickIntervalsecs
		{
			get => E_PROP_FTickFunction_TickInterval_GET(NativePointer);
			set => E_PROP_FTickFunction_TickInterval_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// <para>Returns whether it is valid to access this tick function's completion handle </para>
		/// </summary>
		public bool IsCompletionHandleValid()
			=> E_FTickFunction_IsCompletionHandleValid(this);
		
		
		/// <summary>
		/// <para>Returns whether the tick function is currently enabled </para>
		/// </summary>
		public bool IsTickFunctionEnabled()
			=> E_FTickFunction_IsTickFunctionEnabled(this);
		
		
		/// <summary>
		/// <para>See if the tick function is currently registered </para>
		/// </summary>
		public bool IsTickFunctionRegistered()
			=> E_FTickFunction_IsTickFunctionRegistered(this);
		
		
		/// <summary>
		/// <para>Sets this function to hipri and all prerequisites recursively </para>
		/// <param name="bInHighPriority">priority to set </param>
		/// </summary>
		public void SetPriorityIncludingPrerequisites(bool bInHighPriority)
			=> E_FTickFunction_SetPriorityIncludingPrerequisites(this, bInHighPriority);
		
		
		/// <summary>
		/// <para>Enables or disables this tick function. </para>
		/// </summary>
		public void SetTickFunctionEnable(bool bInEnabled)
			=> E_FTickFunction_SetTickFunctionEnable(this, bInEnabled);
		
		
		/// <summary>
		/// <para>Removes the tick function from the master list of tick functions. </para>
		/// </summary>
		public void UnRegisterTickFunction()
			=> E_FTickFunction_UnRegisterTickFunction(this);
		
		#endregion
		
		public static implicit operator IntPtr(FTickFunction self)
		{
			return self.NativePointer;
		}

		public static implicit operator FTickFunction(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FTickFunction(Adress, false);
		}}}
