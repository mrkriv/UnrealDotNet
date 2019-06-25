// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\Actions\PawnActionsComponent.h:43

namespace UnrealEngine
{
	public partial class FPawnActionStack : NativeStructWrapper
	{
		public FPawnActionStack(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FPawnActionStack() :
			base(E_CreateStruct_FPawnActionStack(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FPawnActionStack();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_FPawnActionStack_GetStackSize(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_FPawnActionStack_GetTop(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FPawnActionStack_IsEmpty(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FPawnActionStack_Pause(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FPawnActionStack_PopAction(IntPtr self, IntPtr actionToPop);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FPawnActionStack_PushAction(IntPtr self, IntPtr newTopAction);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FPawnActionStack_Resume(IntPtr self);
		
		#endregion
		
		#region ExternMethods
		public int GetStackSize()
			=> E_FPawnActionStack_GetStackSize(this);
		
		public UPawnAction GetTop()
			=> E_FPawnActionStack_GetTop(this);
		
		public bool IsEmpty()
			=> E_FPawnActionStack_IsEmpty(this);
		
		public void Pause()
			=> E_FPawnActionStack_Pause(this);
		
		
		/// <summary>
		/// Looks through the double-linked action list looking for specified action
		/// <para>and if found action will be popped along with all it's siblings </para>
		/// </summary>
		public void PopAction(UPawnAction actionToPop)
			=> E_FPawnActionStack_PopAction(this, actionToPop);
		
		
		/// <summary>
		/// All it does is tie actions into a double-linked list making NewTopAction
		/// <para>new stack's top </para>
		/// </summary>
		public void PushAction(UPawnAction newTopAction)
			=> E_FPawnActionStack_PushAction(this, newTopAction);
		
		public void Resume()
			=> E_FPawnActionStack_Resume(this);
		
		#endregion
		
		public static implicit operator IntPtr(FPawnActionStack self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FPawnActionStack(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FPawnActionStack(adress, false);
		}}}
