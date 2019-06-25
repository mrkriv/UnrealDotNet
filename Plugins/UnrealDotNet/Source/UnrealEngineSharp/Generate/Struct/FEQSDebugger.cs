// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\EnvironmentQuery\EnvQueryManager.h:96

namespace UnrealEngine
{
	public partial class FEQSDebugger : NativeStructWrapper
	{
		public FEQSDebugger(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FEQSDebugger() :
			base(E_CreateStruct_FEQSDebugger(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FEQSDebugger();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FEQSDebugger_LoadStats(IntPtr self, string fileName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FEQSDebugger_SaveStats(IntPtr self, string fileName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FEQSDebugger_StoreStats(IntPtr self, IntPtr queryInstance);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FEQSDebugger_StoreTickTime(IntPtr self, IntPtr queryInstance, float tickTime, float maxTickTime);
		
		#endregion
		
		#region ExternMethods
		public void LoadStats(string fileName)
			=> E_FEQSDebugger_LoadStats(this, fileName);
		
		public void SaveStats(string fileName)
			=> E_FEQSDebugger_SaveStats(this, fileName);
		
		public void StoreStats(FEnvQueryInstance queryInstance)
			=> E_FEQSDebugger_StoreStats(this, queryInstance);
		
		public void StoreTickTime(FEnvQueryInstance queryInstance, float tickTime, float maxTickTime)
			=> E_FEQSDebugger_StoreTickTime(this, queryInstance, tickTime, maxTickTime);
		
		#endregion
		
		public static implicit operator IntPtr(FEQSDebugger self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FEQSDebugger(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FEQSDebugger(adress, false);
		}}}
