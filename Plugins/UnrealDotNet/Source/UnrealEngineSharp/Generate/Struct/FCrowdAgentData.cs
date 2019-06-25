// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\Navigation\CrowdManager.h:127

namespace UnrealEngine
{
	public partial class FCrowdAgentData : NativeStructWrapper
	{
		public FCrowdAgentData(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FCrowdAgentData() :
			base(E_CreateStruct_FCrowdAgentData(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_FCrowdAgentData_AgentIndex_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FCrowdAgentData_AgentIndex_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FCrowdAgentData_PathOptRemainingTime_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FCrowdAgentData_PathOptRemainingTime_SET(IntPtr Ptr, float Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FCrowdAgentData();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FCrowdAgentData_ClearFilter(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FCrowdAgentData_IsValid(IntPtr self);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// index of agent in detour crowd
		/// </summary>
		public int AgentIndex
		{
			get => E_PROP_FCrowdAgentData_AgentIndex_GET(NativePointer);
			set => E_PROP_FCrowdAgentData_AgentIndex_SET(NativePointer, value);
		}

		
		/// <summary>
		/// remaining time for next path optimization
		/// </summary>
		public float PathOptRemainingTime
		{
			get => E_PROP_FCrowdAgentData_PathOptRemainingTime_GET(NativePointer);
			set => E_PROP_FCrowdAgentData_PathOptRemainingTime_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		public void ClearFilter()
			=> E_FCrowdAgentData_ClearFilter(this);
		
		public bool IsValid()
			=> E_FCrowdAgentData_IsValid(this);
		
		#endregion
		
		public static implicit operator IntPtr(FCrowdAgentData self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FCrowdAgentData(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FCrowdAgentData(adress, false);
		}}}
