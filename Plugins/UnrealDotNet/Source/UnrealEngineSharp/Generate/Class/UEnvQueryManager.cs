// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\EnvironmentQuery\EnvQueryManager.h:156

namespace UnrealEngine
{
	public partial class UEnvQueryManager : UAISubsystem
	{
		public UEnvQueryManager(IntPtr adress)
			: base(adress)
		{
		}

		public UEnvQueryManager(UObject Parent = null, string Name = "EnvQueryManager")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UEnvQueryManager(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UEnvQueryManager(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UEnvQueryManager_AbortQuery(IntPtr self, int requestID);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UEnvQueryManager_FindNamedParam(IntPtr self, int queryId, string paramName);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_UEnvQueryManager_GetCurrent(IntPtr self, IntPtr world);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_UEnvQueryManager_GetCurrent_o1(IntPtr self, IntPtr worldContextObject);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UEnvQueryManager_GetDebugger(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UEnvQueryManager_OnWorldCleanup(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UEnvQueryManager_RegisterActiveWrapper(IntPtr self, IntPtr wrapper);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UEnvQueryManager_RemoveAllQueriesByQuerier(IntPtr self, IntPtr querier, bool bExecuteFinishDelegate);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UEnvQueryManager_SetAllowTimeSlicing(IntPtr self, bool bAllowTimeSlicing);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UEnvQueryManager_SilentlyRemoveAllQueriesByQuerier(IntPtr self, IntPtr querier);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UEnvQueryManager_UnregisterActiveWrapper(IntPtr self, IntPtr wrapper);
		
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// execute query
		/// </summary>
		public bool AbortQuery(int requestID)
			=> E_UEnvQueryManager_AbortQuery(this, requestID);
		
		
		/// <summary>
		/// find value of named param stored with active query
		/// </summary>
		public float FindNamedParam(int queryId, string paramName)
			=> E_UEnvQueryManager_FindNamedParam(this, queryId, paramName);
		
		public UEnvQueryManager GetCurrent(UWorld world)
			=> E_UEnvQueryManager_GetCurrent(this, world);
		
		public UEnvQueryManager GetCurrent(UObject worldContextObject)
			=> E_UEnvQueryManager_GetCurrent_o1(this, worldContextObject);
		
		public FEQSDebugger GetDebugger()
			=> E_UEnvQueryManager_GetDebugger(this);
		
		
		/// <summary>
		/// fail all running queries on cleaning the world
		/// </summary>
		public virtual void OnWorldCleanup()
			=> E_UEnvQueryManager_OnWorldCleanup(this);
		
		public void RegisterActiveWrapper(UEnvQueryInstanceBlueprintWrapper wrapper)
			=> E_UEnvQueryManager_RegisterActiveWrapper(this, wrapper);
		
		public void RemoveAllQueriesByQuerier(UObject querier, bool bExecuteFinishDelegate)
			=> E_UEnvQueryManager_RemoveAllQueriesByQuerier(this, querier, bExecuteFinishDelegate);
		
		public void SetAllowTimeSlicing(bool bAllowTimeSlicing)
			=> E_UEnvQueryManager_SetAllowTimeSlicing(this, bAllowTimeSlicing);
		
		
		/// <summary>
		/// Removed all active queries asked by Querier. No "on finished" notifications are being sent, call this function when
		/// <para>you no longer care about Querier's queries, like when he's "dead" </para>
		/// </summary>
		public void SilentlyRemoveAllQueriesByQuerier(UObject querier)
			=> E_UEnvQueryManager_SilentlyRemoveAllQueriesByQuerier(this, querier);
		
		public void UnregisterActiveWrapper(UEnvQueryInstanceBlueprintWrapper wrapper)
			=> E_UEnvQueryManager_UnregisterActiveWrapper(this, wrapper);
		
		#endregion
		
		public static implicit operator IntPtr(UEnvQueryManager self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UEnvQueryManager(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UEnvQueryManager>(PtrDesc);
		}}}
