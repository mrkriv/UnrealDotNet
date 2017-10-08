using System;
using System.Runtime.InteropServices;

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
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FTickFunction();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FTickFunction_IsCompletionHandleValid(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FTickFunction_IsTickFunctionEnabled(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FTickFunction_IsTickFunctionRegistered(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FTickFunction_SetPriorityIncludingPrerequisites(IntPtr Self, bool bInHighPriority);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FTickFunction_SetTickFunctionEnable(IntPtr Self, bool bInEnabled);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FTickFunction_UnRegisterTickFunction(IntPtr Self);
		
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
		
		public static implicit operator IntPtr(FTickFunction Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FTickFunction(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FTickFunction(Adress, false);
		}}}
