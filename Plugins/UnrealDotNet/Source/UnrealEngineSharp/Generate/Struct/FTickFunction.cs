// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Engine\EngineBaseTypes.h:168

namespace UnrealEngine
{
	public partial class FTickFunction : NativeStructWrapper
	{
		public FTickFunction(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		
		/// <summary>
		/// Default constructor, intitalizes to reasonable defaults
		/// </summary>
		public FTickFunction() :
			base(E_CreateStruct_FTickFunction(), false)
		{
		}

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
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FTickFunction();
		
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
		/// If we allow this tick to run on a dedicated server
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
		/// Run this tick first within the tick group, presumably to start async tasks that must be completed with this tick group, hiding the latency.
		/// </summary>
		public byte bHighPriority
		{
			get => E_PROP_FTickFunction_bHighPriority_GET(NativePointer);
			set => E_PROP_FTickFunction_bHighPriority_SET(NativePointer, value);
		}

		
		/// <summary>
		/// If false, this tick will run on the game thread, otherwise it will run on any thread in parallel with the game thread and in parallel with other "async ticks"
		/// </summary>
		public byte bRunOnAnyThread
		{
			get => E_PROP_FTickFunction_bRunOnAnyThread_GET(NativePointer);
			set => E_PROP_FTickFunction_bRunOnAnyThread_SET(NativePointer, value);
		}

		
		/// <summary>
		/// If true, this tick function will start enabled, but can be disabled later on.
		/// </summary>
		public byte bStartWithTickEnabled
		{
			get => E_PROP_FTickFunction_bStartWithTickEnabled_GET(NativePointer);
			set => E_PROP_FTickFunction_bStartWithTickEnabled_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Bool indicating that this function should execute even if the game is paused. Pause ticks are very limited in capabilities.
		/// </summary>
		public byte bTickEvenWhenPaused
		{
			get => E_PROP_FTickFunction_bTickEvenWhenPaused_GET(NativePointer);
			set => E_PROP_FTickFunction_bTickEvenWhenPaused_SET(NativePointer, value);
		}

		
		/// <summary>
		/// The frequency in seconds at which this tick function will be executed.  If less than or equal to 0 then it will tick every frame
		/// </summary>
		public float TickIntervalsecs
		{
			get => E_PROP_FTickFunction_TickInterval_GET(NativePointer);
			set => E_PROP_FTickFunction_TickInterval_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Returns whether it is valid to access this tick function's completion handle
		/// </summary>
		public bool IsCompletionHandleValid()
			=> E_FTickFunction_IsCompletionHandleValid(this);
		
		
		/// <summary>
		/// Returns whether the tick function is currently enabled
		/// </summary>
		public bool IsTickFunctionEnabled()
			=> E_FTickFunction_IsTickFunctionEnabled(this);
		
		
		/// <summary>
		/// See if the tick function is currently registered
		/// </summary>
		public bool IsTickFunctionRegistered()
			=> E_FTickFunction_IsTickFunctionRegistered(this);
		
		
		/// <summary>
		/// Sets this function to hipri and all prerequisites recursively
		/// </summary>
		/// <param name="bInHighPriority">priority to set</param>
		public void SetPriorityIncludingPrerequisites(bool bInHighPriority)
			=> E_FTickFunction_SetPriorityIncludingPrerequisites(this, bInHighPriority);
		
		
		/// <summary>
		/// Enables or disables this tick function.
		/// </summary>
		public void SetTickFunctionEnable(bool bInEnabled)
			=> E_FTickFunction_SetTickFunctionEnable(this, bInEnabled);
		
		
		/// <summary>
		/// Removes the tick function from the master list of tick functions.
		/// </summary>
		public void UnRegisterTickFunction()
			=> E_FTickFunction_UnRegisterTickFunction(this);
		
		#endregion
		
		public static implicit operator IntPtr(FTickFunction self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FTickFunction(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FTickFunction(adress, false);
		}}}
