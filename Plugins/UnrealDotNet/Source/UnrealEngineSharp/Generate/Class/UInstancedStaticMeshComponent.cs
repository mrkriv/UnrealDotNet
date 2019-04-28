// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\InstancedStaticMeshComponent.h:120

namespace UnrealEngine
{
	public  partial class UInstancedStaticMeshComponent : UStaticMeshComponent
	{
		public UInstancedStaticMeshComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public UInstancedStaticMeshComponent(UObject Parent = null, string Name = "InstancedStaticMeshComponent")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UInstancedStaticMeshComponent(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_UInstancedStaticMeshComponent_InstanceEndCullDistance_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UInstancedStaticMeshComponent_InstanceEndCullDistance_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_UInstancedStaticMeshComponent_InstanceStartCullDistance_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UInstancedStaticMeshComponent_InstanceStartCullDistance_SET(IntPtr Ptr, int Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_UInstancedStaticMeshComponent_InstancingRandomSeed_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UInstancedStaticMeshComponent_InstancingRandomSeed_SET(IntPtr Ptr, int Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UInstancedStaticMeshComponent(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_UInstancedStaticMeshComponent_AddInstance(IntPtr self, IntPtr instanceTransform);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_UInstancedStaticMeshComponent_AddInstanceWorldSpace(IntPtr self, IntPtr worldTransform);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UInstancedStaticMeshComponent_ClearInstances(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_UInstancedStaticMeshComponent_GetInstanceCount(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UInstancedStaticMeshComponent_GetInstanceTransform(IntPtr self, int instanceIndex, IntPtr outInstanceTransform, bool bWorldSpace);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UInstancedStaticMeshComponent_PreAllocateInstancesMemory(IntPtr self, int addedInstanceCount);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UInstancedStaticMeshComponent_RemoveInstance(IntPtr self, int instanceIndex);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UInstancedStaticMeshComponent_SetCullDistances(IntPtr self, int startCullDistance, int endCullDistance);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UInstancedStaticMeshComponent_UpdateInstanceTransform(IntPtr self, int instanceIndex, IntPtr newInstanceTransform, bool bWorldSpace, bool bMarkRenderStateDirty, bool bTeleport);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// <para>Distance from camera at which each instance completely fades out. </para>
		/// </summary>
		public int InstanceEndCullDistance
		{
			get => E_PROP_UInstancedStaticMeshComponent_InstanceEndCullDistance_GET(NativePointer);
			set => E_PROP_UInstancedStaticMeshComponent_InstanceEndCullDistance_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Distance from camera at which each instance begins to fade out. </para>
		/// </summary>
		public int InstanceStartCullDistance
		{
			get => E_PROP_UInstancedStaticMeshComponent_InstanceStartCullDistance_GET(NativePointer);
			set => E_PROP_UInstancedStaticMeshComponent_InstanceStartCullDistance_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Value used to seed the random number stream that generates random numbers for each of this mesh's instances. </para>
		/// <para>The random number is stored in a buffer accessible to materials through the PerInstanceRandom expression. If </para>
		/// <para>this is set to zero (default), it will be populated automatically by the editor. </para>
		/// </summary>
		public int InstancingRandomSeed
		{
			get => E_PROP_UInstancedStaticMeshComponent_InstancingRandomSeed_GET(NativePointer);
			set => E_PROP_UInstancedStaticMeshComponent_InstancingRandomSeed_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// <para>Add an instance to this component. Transform is given in local space of this component. </para>
		/// </summary>
		public virtual int AddInstance(FTransform instanceTransform)
			=> E_UInstancedStaticMeshComponent_AddInstance(this, instanceTransform);
		
		
		/// <summary>
		/// <para>Add an instance to this component. Transform is given in world space. </para>
		/// </summary>
		public int AddInstanceWorldSpace(FTransform worldTransform)
			=> E_UInstancedStaticMeshComponent_AddInstanceWorldSpace(this, worldTransform);
		
		
		/// <summary>
		/// <para>Clear all instances being rendered by this component. </para>
		/// </summary>
		public virtual void ClearInstances()
			=> E_UInstancedStaticMeshComponent_ClearInstances(this);
		
		
		/// <summary>
		/// <para>Get the number of instances in this component. </para>
		/// </summary>
		public int GetInstanceCount()
			=> E_UInstancedStaticMeshComponent_GetInstanceCount(this);
		
		
		/// <summary>
		/// <para>Get the transform for the instance specified. Instance is returned in local space of this component unless bWorldSpace is set.  Returns True on success. </para>
		/// </summary>
		public bool GetInstanceTransform(int instanceIndex, FTransform outInstanceTransform, bool bWorldSpace = false)
			=> E_UInstancedStaticMeshComponent_GetInstanceTransform(this, instanceIndex, outInstanceTransform, bWorldSpace);
		
		
		/// <summary>
		/// <para>Preallocated memory to include the new added instances count, to prevent reallloc during the add operation. </para>
		/// </summary>
		public virtual void PreAllocateInstancesMemory(int addedInstanceCount)
			=> E_UInstancedStaticMeshComponent_PreAllocateInstancesMemory(this, addedInstanceCount);
		
		
		/// <summary>
		/// <para>Remove the instance specified. Returns True on success. Note that this will leave the array in order, but may shrink it. </para>
		/// </summary>
		public virtual bool RemoveInstance(int instanceIndex)
			=> E_UInstancedStaticMeshComponent_RemoveInstance(this, instanceIndex);
		
		
		/// <summary>
		/// <para>Sets the fading start and culling end distances for this component. </para>
		/// </summary>
		public void SetCullDistances(int startCullDistance, int endCullDistance)
			=> E_UInstancedStaticMeshComponent_SetCullDistances(this, startCullDistance, endCullDistance);
		
		
		/// <summary>
		/// <para>Update the transform for the instance specified. </para>
		/// <param name="InstanceIndex">The index of the instance to update </param>
		/// <param name="NewInstanceTransform">The new transform </param>
		/// <param name="bWorldSpace">If true, the new transform interpreted as a World Space transform, otherwise it is interpreted as Local Space </param>
		/// <param name="bMarkRenderStateDirty">If true, the change should be visible immediately. If you are updating many instances you should only set this to true for the last instance. </param>
		/// <param name="bTeleport">Whether or not the instance's physics should be moved normally, or teleported (moved instantly, ignoring velocity). </param>
		/// <return>True on success. </return>
		/// </summary>
		public virtual bool UpdateInstanceTransform(int instanceIndex, FTransform newInstanceTransform, bool bWorldSpace, bool bMarkRenderStateDirty, bool bTeleport)
			=> E_UInstancedStaticMeshComponent_UpdateInstanceTransform(this, instanceIndex, newInstanceTransform, bWorldSpace, bMarkRenderStateDirty, bTeleport);
		
		#endregion
		
		public static implicit operator IntPtr(UInstancedStaticMeshComponent self)
		{
			return self.NativePointer;
		}

		public static implicit operator UInstancedStaticMeshComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UInstancedStaticMeshComponent>(PtrDesc);
		}}}
