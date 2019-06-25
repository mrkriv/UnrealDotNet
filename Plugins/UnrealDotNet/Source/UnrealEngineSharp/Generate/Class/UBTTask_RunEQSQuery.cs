// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\BehaviorTree\Tasks\BTTask_RunEQSQuery.h:25

namespace UnrealEngine
{
	public partial class UBTTask_RunEQSQuery : UBTTask_BlackboardBase
	{
		public UBTTask_RunEQSQuery(IntPtr adress)
			: base(adress)
		{
		}

		public UBTTask_RunEQSQuery(UObject Parent = null, string Name = "BTTask_RunEQSQuery")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UBTTask_RunEQSQuery(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_UBTTask_RunEQSQuery_bUseBBKey_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UBTTask_RunEQSQuery_bUseBBKey_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_UBTTask_RunEQSQuery_EQSQueryBlackboardKey_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UBTTask_RunEQSQuery_EQSQueryBlackboardKey_SET(IntPtr Ptr, IntPtr Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UBTTask_RunEQSQuery(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UBTTask_RunEQSQuery_CollectKeyFilters(IntPtr self);
		
		#endregion
		
		#region Property
		public bool bUseBBKey
		{
			get => E_PROP_UBTTask_RunEQSQuery_bUseBBKey_GET(NativePointer);
			set => E_PROP_UBTTask_RunEQSQuery_bUseBBKey_SET(NativePointer, value);
		}

		
		/// <summary>
		/// blackboard key storing an EQS query template
		/// </summary>
		public FBlackboardKeySelector EQSQueryBlackboardKey_DEPRECATED
		{
			get => E_PROP_UBTTask_RunEQSQuery_EQSQueryBlackboardKey_GET(NativePointer);
			set => E_PROP_UBTTask_RunEQSQuery_EQSQueryBlackboardKey_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// gather all filters from existing EnvQueryItemTypes
		/// </summary>
		protected void CollectKeyFilters()
			=> E_UBTTask_RunEQSQuery_CollectKeyFilters(this);
		
		#endregion
		
		public static implicit operator IntPtr(UBTTask_RunEQSQuery self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UBTTask_RunEQSQuery(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UBTTask_RunEQSQuery>(PtrDesc);
		}}}
