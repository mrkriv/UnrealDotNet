// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\BehaviorTree\BehaviorTreeTypes.h:540

namespace UnrealEngine
{
	public partial class UBehaviorTreeTypes : UObject
	{
		public UBehaviorTreeTypes(IntPtr adress)
			: base(adress)
		{
		}

		public UBehaviorTreeTypes(UObject Parent = null, string Name = "BehaviorTreeTypes")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UBehaviorTreeTypes(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UBehaviorTreeTypes(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_UBehaviorTreeTypes_DescribeNodeHelper(IntPtr self, IntPtr node);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_UBehaviorTreeTypes_GetBTLoggingContext(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_UBehaviorTreeTypes_GetShortTypeName(IntPtr self, IntPtr ob);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UBehaviorTreeTypes_SetBTLoggingContext(IntPtr self, IntPtr newBTLoggingContext);
		
		#endregion
		
		#region ExternMethods
		public string DescribeNodeHelper(UBTNode node)
			=> E_UBehaviorTreeTypes_DescribeNodeHelper(this, node);
		
		public string GetBTLoggingContext()
			=> E_UBehaviorTreeTypes_GetBTLoggingContext(this);
		
		
		/// <summary>
		/// returns short name of object's class (BTTaskNode_Wait -> Wait)
		/// </summary>
		public string GetShortTypeName(UObject ob)
			=> E_UBehaviorTreeTypes_GetShortTypeName(this, ob);
		
		public void SetBTLoggingContext(UBTNode newBTLoggingContext)
			=> E_UBehaviorTreeTypes_SetBTLoggingContext(this, newBTLoggingContext);
		
		#endregion
		
		public static implicit operator IntPtr(UBehaviorTreeTypes self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UBehaviorTreeTypes(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UBehaviorTreeTypes>(PtrDesc);
		}}}
