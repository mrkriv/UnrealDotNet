// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\EnvironmentQuery\EnvQueryTypes.h:728

namespace UnrealEngine
{
	public partial class FEnvQueryInstance : FEnvQueryResult
	{
		public FEnvQueryInstance(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FEnvQueryInstance() :
			base(E_CreateStruct_FEnvQueryInstance(), false)
		{
		}

		public FEnvQueryInstance(FEnvQueryInstance other) :
			base(E_CreateStruct_FEnvQueryInstance_FEnvQueryInstance(other), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FEnvQueryInstance_bFoundSingleResult_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FEnvQueryInstance_bFoundSingleResult_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FEnvQueryInstance_bHasLoggedTimeLimitWarning_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FEnvQueryInstance_bHasLoggedTimeLimitWarning_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FEnvQueryInstance_bPassOnSingleResult_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FEnvQueryInstance_bPassOnSingleResult_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FEnvQueryInstance_bStoreDebugInfo_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FEnvQueryInstance_bStoreDebugInfo_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FEnvQueryInstance_CurrentStepTimeLimit_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FEnvQueryInstance_CurrentStepTimeLimit_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_FEnvQueryInstance_CurrentTest_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FEnvQueryInstance_CurrentTest_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_FEnvQueryInstance_CurrentTestStartingItem_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FEnvQueryInstance_CurrentTestStartingItem_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_PROP_FEnvQueryInstance_ItemTypeActorCDO_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FEnvQueryInstance_ItemTypeActorCDO_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_PROP_FEnvQueryInstance_ItemTypeVectorCDO_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FEnvQueryInstance_ItemTypeVectorCDO_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_FEnvQueryInstance_NumProcessedItems_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FEnvQueryInstance_NumProcessedItems_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_FEnvQueryInstance_NumValidItems_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FEnvQueryInstance_NumValidItems_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_FEnvQueryInstance_QueryName_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FEnvQueryInstance_QueryName_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern double E_PROP_FEnvQueryInstance_StartTime_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FEnvQueryInstance_StartTime_SET(IntPtr Ptr, double Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_FEnvQueryInstance_TotalExecutionTime_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FEnvQueryInstance_TotalExecutionTime_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_FEnvQueryInstance_UniqueName_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FEnvQueryInstance_UniqueName_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_PROP_FEnvQueryInstance_World_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FEnvQueryInstance_World_SET(IntPtr Ptr, IntPtr Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FEnvQueryInstance();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FEnvQueryInstance_FEnvQueryInstance(IntPtr other);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FEnvQueryInstance_CanBatchTest(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FEnvQueryInstance_ExecuteOneStep(IntPtr self, float timeLimit);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FEnvQueryInstance_IsInSingleItemFinalSearch(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FEnvQueryInstance_ReserveItemData(IntPtr self, int numAdditionalItems);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// used to breaking from item iterator loops
		/// </summary>
		public byte bFoundSingleResult
		{
			get => E_PROP_FEnvQueryInstance_bFoundSingleResult_GET(NativePointer);
			set => E_PROP_FEnvQueryInstance_bFoundSingleResult_SET(NativePointer, value);
		}

		
		/// <summary>
		/// true if this query has logged a warning that it overran the time limit
		/// </summary>
		public byte bHasLoggedTimeLimitWarning
		{
			get => E_PROP_FEnvQueryInstance_bHasLoggedTimeLimitWarning_GET(NativePointer);
			set => E_PROP_FEnvQueryInstance_bHasLoggedTimeLimitWarning_SET(NativePointer, value);
		}

		
		/// <summary>
		/// set when testing final condition of an option
		/// </summary>
		public byte bPassOnSingleResult
		{
			get => E_PROP_FEnvQueryInstance_bPassOnSingleResult_GET(NativePointer);
			set => E_PROP_FEnvQueryInstance_bPassOnSingleResult_SET(NativePointer, value);
		}

		
		/// <summary>
		/// set to true to store additional debug info
		/// </summary>
		public byte bStoreDebugInfo
		{
			get => E_PROP_FEnvQueryInstance_bStoreDebugInfo_GET(NativePointer);
			set => E_PROP_FEnvQueryInstance_bStoreDebugInfo_SET(NativePointer, value);
		}

		
		/// <summary>
		/// if > 0 then it's how much time query has for performing current step
		/// </summary>
		public float CurrentStepTimeLimit
		{
			get => E_PROP_FEnvQueryInstance_CurrentStepTimeLimit_GET(NativePointer);
			set => E_PROP_FEnvQueryInstance_CurrentStepTimeLimit_SET(NativePointer, value);
		}

		
		/// <summary>
		/// currently processed test (-1 = generator)
		/// </summary>
		public int CurrentTest
		{
			get => E_PROP_FEnvQueryInstance_CurrentTest_GET(NativePointer);
			set => E_PROP_FEnvQueryInstance_CurrentTest_SET(NativePointer, value);
		}

		
		/// <summary>
		/// non-zero if test run last step has been stopped mid-process. This indicates
		/// <para>index of the first item that needs processing when resumed </para>
		/// </summary>
		public int CurrentTestStartingItem
		{
			get => E_PROP_FEnvQueryInstance_CurrentTestStartingItem_GET(NativePointer);
			set => E_PROP_FEnvQueryInstance_CurrentTestStartingItem_SET(NativePointer, value);
		}

		
		/// <summary>
		/// item type's CDO for actor tests
		/// </summary>
		public UEnvQueryItemType_ActorBase ItemTypeActorCDO
		{
			get => E_PROP_FEnvQueryInstance_ItemTypeActorCDO_GET(NativePointer);
			set => E_PROP_FEnvQueryInstance_ItemTypeActorCDO_SET(NativePointer, value);
		}

		
		/// <summary>
		/// item type's CDO for location tests
		/// </summary>
		public UEnvQueryItemType_VectorBase ItemTypeVectorCDO
		{
			get => E_PROP_FEnvQueryInstance_ItemTypeVectorCDO_GET(NativePointer);
			set => E_PROP_FEnvQueryInstance_ItemTypeVectorCDO_SET(NativePointer, value);
		}

		
		/// <summary>
		/// number of items processed in current step
		/// </summary>
		public int NumProcessedItems
		{
			get => E_PROP_FEnvQueryInstance_NumProcessedItems_GET(NativePointer);
			set => E_PROP_FEnvQueryInstance_NumProcessedItems_SET(NativePointer, value);
		}

		
		/// <summary>
		/// number of valid items on list
		/// </summary>
		public int NumValidItems
		{
			get => E_PROP_FEnvQueryInstance_NumValidItems_GET(NativePointer);
			set => E_PROP_FEnvQueryInstance_NumValidItems_SET(NativePointer, value);
		}

		
		/// <summary>
		/// short name of query template - friendly name for debugging
		/// </summary>
		public string QueryName
		{
			get => E_PROP_FEnvQueryInstance_QueryName_GET(NativePointer);
			set => E_PROP_FEnvQueryInstance_QueryName_SET(NativePointer, value);
		}

		
		/// <summary>
		/// timestamp of creating query instance
		/// </summary>
		public double StartTime
		{
			get => E_PROP_FEnvQueryInstance_StartTime_GET(NativePointer);
			set => E_PROP_FEnvQueryInstance_StartTime_SET(NativePointer, value);
		}

		
		/// <summary>
		/// time spent executing this query
		/// </summary>
		public float TotalExecutionTime
		{
			get => E_PROP_FEnvQueryInstance_TotalExecutionTime_GET(NativePointer);
			set => E_PROP_FEnvQueryInstance_TotalExecutionTime_SET(NativePointer, value);
		}

		
		/// <summary>
		/// unique name of query template - object name
		/// </summary>
		public string UniqueName
		{
			get => E_PROP_FEnvQueryInstance_UniqueName_GET(NativePointer);
			set => E_PROP_FEnvQueryInstance_UniqueName_SET(NativePointer, value);
		}

		
		/// <summary>
		/// world owning this query instance
		/// </summary>
		public UWorld World
		{
			get => E_PROP_FEnvQueryInstance_World_GET(NativePointer);
			set => E_PROP_FEnvQueryInstance_World_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// check if current test can batch its calculations
		/// </summary>
		public bool CanBatchTest()
			=> E_FEnvQueryInstance_CanBatchTest(this);
		
		
		/// <summary>
		/// execute single step of query
		/// </summary>
		public void ExecuteOneStep(float timeLimit)
			=> E_FEnvQueryInstance_ExecuteOneStep(this, timeLimit);
		
		public bool IsInSingleItemFinalSearch()
			=> E_FEnvQueryInstance_IsInSingleItemFinalSearch(this);
		
		
		/// <summary>
		/// raw data operations
		/// </summary>
		public void ReserveItemData(int numAdditionalItems)
			=> E_FEnvQueryInstance_ReserveItemData(this, numAdditionalItems);
		
		#endregion
		
		public static implicit operator IntPtr(FEnvQueryInstance self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FEnvQueryInstance(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FEnvQueryInstance(adress, false);
		}}}
