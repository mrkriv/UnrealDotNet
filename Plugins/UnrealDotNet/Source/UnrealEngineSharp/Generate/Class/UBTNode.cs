// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\BehaviorTree\BTNode.h:36

namespace UnrealEngine
{
	public partial class UBTNode : UObject
	{
		public UBTNode(IntPtr adress)
			: base(adress)
		{
		}

		public UBTNode(UObject Parent = null, string Name = "BTNode")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UBTNode(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_UBTNode_NodeName_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UBTNode_NodeName_SET(IntPtr Ptr, string Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UBTNode(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UBTNode_ForceInstancing(IntPtr self, bool bEnable);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_UBTNode_GetNextNode(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_UBTNode_GetNodeInstance(IntPtr self, IntPtr ownerComp, byte nodeMemory);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_UBTNode_GetNodeInstance_o1(IntPtr self, IntPtr searchData);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_UBTNode_GetNodeName(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_UBTNode_GetParentNode(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_UBTNode_GetStaticDescription(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_UBTNode_GetTreeAsset(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_UBTNode_GetTreeDepth(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UBTNode_HasInstance(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UBTNode_InitializeExecutionOrder(IntPtr self, IntPtr nextNode);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UBTNode_InitializeFromAsset(IntPtr self, IntPtr asset);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UBTNode_IsInjected(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UBTNode_IsInstanced(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UBTNode_MarkInjectedNode(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UBTNode_OnInstanceCreated(IntPtr self, IntPtr ownerComp);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UBTNode_OnInstanceDestroyed(IntPtr self, IntPtr ownerComp);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UBTNode_SetOwner(IntPtr self, IntPtr actorOwner);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// node name
		/// </summary>
		public string NodeName
		{
			get => E_PROP_UBTNode_NodeName_GET(NativePointer);
			set => E_PROP_UBTNode_NodeName_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// sets bCreateNodeInstance flag, do NOT call this function on already pushed tree instance!
		/// </summary>
		public void ForceInstancing(bool bEnable)
			=> E_UBTNode_ForceInstancing(this, bEnable);
		
		
		/// <summary>
		/// </summary>
		/// <return>next</return>
		public UBTNode GetNextNode()
			=> E_UBTNode_GetNextNode(this);
		
		
		/// <summary>
		/// </summary>
		/// <return>node</return>
		public UBTNode GetNodeInstance(UBehaviorTreeComponent ownerComp, byte nodeMemory)
			=> E_UBTNode_GetNodeInstance(this, ownerComp, nodeMemory);
		
		public UBTNode GetNodeInstance(FBehaviorTreeSearchData searchData)
			=> E_UBTNode_GetNodeInstance_o1(this, searchData);
		
		
		/// <summary>
		/// </summary>
		/// <return>name</return>
		public string GetNodeName()
			=> E_UBTNode_GetNodeName(this);
		
		
		/// <summary>
		/// </summary>
		/// <return>parent</return>
		public UBTCompositeNode GetParentNode()
			=> E_UBTNode_GetParentNode(this);
		
		
		/// <summary>
		/// </summary>
		/// <return>string</return>
		public virtual string GetStaticDescription()
			=> E_UBTNode_GetStaticDescription(this);
		
		
		/// <summary>
		/// </summary>
		/// <return>tree</return>
		public UBehaviorTree GetTreeAsset()
			=> E_UBTNode_GetTreeAsset(this);
		
		
		/// <summary>
		/// </summary>
		/// <return>depth</return>
		public byte GetTreeDepth()
			=> E_UBTNode_GetTreeDepth(this);
		
		
		/// <summary>
		/// </summary>
		/// <return>true</return>
		public bool HasInstance()
			=> E_UBTNode_HasInstance(this);
		
		
		/// <summary>
		/// fill in data about execution order
		/// </summary>
		public void InitializeExecutionOrder(UBTNode nextNode)
			=> E_UBTNode_InitializeExecutionOrder(this, nextNode);
		
		
		/// <summary>
		/// initialize any asset related data
		/// </summary>
		public virtual void InitializeFromAsset(UBehaviorTree asset)
			=> E_UBTNode_InitializeFromAsset(this, asset);
		
		
		/// <summary>
		/// </summary>
		/// <return>true</return>
		public bool IsInjected()
			=> E_UBTNode_IsInjected(this);
		
		
		/// <summary>
		/// </summary>
		/// <return>true</return>
		public bool IsInstanced()
			=> E_UBTNode_IsInstanced(this);
		
		
		/// <summary>
		/// sets bIsInjected flag, do NOT call this function unless you really know what you are doing!
		/// </summary>
		public void MarkInjectedNode()
			=> E_UBTNode_MarkInjectedNode(this);
		
		
		/// <summary>
		/// called when node instance is added to tree
		/// </summary>
		public virtual void OnInstanceCreated(UBehaviorTreeComponent ownerComp)
			=> E_UBTNode_OnInstanceCreated(this, ownerComp);
		
		
		/// <summary>
		/// called when node instance is removed from tree
		/// </summary>
		public virtual void OnInstanceDestroyed(UBehaviorTreeComponent ownerComp)
			=> E_UBTNode_OnInstanceDestroyed(this, ownerComp);
		
		
		/// <summary>
		/// Gets called only for instanced nodes(bCreateNodeInstance == true). In practive overridden by BP-implemented BT nodes
		/// </summary>
		public virtual void SetOwner(AActor actorOwner)
			=> E_UBTNode_SetOwner(this, actorOwner);
		
		#endregion
		
		public static implicit operator IntPtr(UBTNode self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UBTNode(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UBTNode>(PtrDesc);
		}}}
