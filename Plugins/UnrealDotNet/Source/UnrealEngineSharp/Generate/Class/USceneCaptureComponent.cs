// This file was created automatically, do not modify the contents of this file.

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\SceneCaptureComponent.h:60

namespace UnrealEngine
{
	public  partial class USceneCaptureComponent : USceneComponent
	{
		public USceneCaptureComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public USceneCaptureComponent(UObject Parent = null, string Name = "SceneCaptureComponent")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_USceneCaptureComponent(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_USceneCaptureComponent_ProfilingEventName_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_USceneCaptureComponent_ProfilingEventName_SET(IntPtr Ptr, string Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_USceneCaptureComponent(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneCaptureComponent_ClearHiddenComponents(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneCaptureComponent_ClearShowOnlyComponents(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_USceneCaptureComponent_GetViewOwner(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneCaptureComponent_HideActorComponents(IntPtr self, IntPtr inActor);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneCaptureComponent_HideComponent(IntPtr self, IntPtr inComponent);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneCaptureComponent_RemoveShowOnlyActorComponents(IntPtr self, IntPtr inActor);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneCaptureComponent_RemoveShowOnlyComponent(IntPtr self, IntPtr inComponent);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneCaptureComponent_SetCaptureSortPriority(IntPtr self, int newCaptureSortPriority);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneCaptureComponent_ShowOnlyActorComponents(IntPtr self, IntPtr inActor);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneCaptureComponent_ShowOnlyComponent(IntPtr self, IntPtr inComponent);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneCaptureComponent_UpdateShowFlags(IntPtr self);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// <para>Name of the profiling event. </para>
		/// </summary>
		public string ProfilingEventName
		{
			get => E_PROP_USceneCaptureComponent_ProfilingEventName_GET(NativePointer);
			set => E_PROP_USceneCaptureComponent_ProfilingEventName_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// <para>Clears the hidden list. </para>
		/// </summary>
		public void ClearHiddenComponents()
			=> E_USceneCaptureComponent_ClearHiddenComponents(this);
		
		
		/// <summary>
		/// <para>Clears the Show Only list. </para>
		/// </summary>
		public void ClearShowOnlyComponents()
			=> E_USceneCaptureComponent_ClearShowOnlyComponents(this);
		
		
		/// <summary>
		/// <para>To leverage a component's bOwnerNoSee/bOnlyOwnerSee properties, the capture view requires an "owner". Override this to set a "ViewActor" for the scene. </para>
		/// </summary>
		public virtual AActor GetViewOwner()
			=> E_USceneCaptureComponent_GetViewOwner(this);
		
		
		/// <summary>
		/// <para>Adds all primitive components in the actor to our list of hidden components. </para>
		/// </summary>
		public void HideActorComponents(AActor inActor)
			=> E_USceneCaptureComponent_HideActorComponents(this, inActor);
		
		
		/// <summary>
		/// <para>Adds the component to our list of hidden components. </para>
		/// </summary>
		public void HideComponent(UPrimitiveComponent inComponent)
			=> E_USceneCaptureComponent_HideComponent(this, inComponent);
		
		
		/// <summary>
		/// <para>Removes a actor's components from the Show Only list. </para>
		/// </summary>
		public void RemoveShowOnlyActorComponents(AActor inActor)
			=> E_USceneCaptureComponent_RemoveShowOnlyActorComponents(this, inActor);
		
		
		/// <summary>
		/// <para>Removes a component from the Show Only list. </para>
		/// </summary>
		public void RemoveShowOnlyComponent(UPrimitiveComponent inComponent)
			=> E_USceneCaptureComponent_RemoveShowOnlyComponent(this, inComponent);
		
		
		/// <summary>
		/// <para>Changes the value of TranslucentSortPriority. </para>
		/// </summary>
		public void SetCaptureSortPriority(int newCaptureSortPriority)
			=> E_USceneCaptureComponent_SetCaptureSortPriority(this, newCaptureSortPriority);
		
		
		/// <summary>
		/// <para>Adds all primitive components in the actor to our list of show-only components. </para>
		/// </summary>
		public void ShowOnlyActorComponents(AActor inActor)
			=> E_USceneCaptureComponent_ShowOnlyActorComponents(this, inActor);
		
		
		/// <summary>
		/// <para>Adds the component to our list of show-only components. </para>
		/// </summary>
		public void ShowOnlyComponent(UPrimitiveComponent inComponent)
			=> E_USceneCaptureComponent_ShowOnlyComponent(this, inComponent);
		
		
		/// <summary>
		/// <para>Update the show flags from our show flags settings (ideally, you'd be able to set this more directly, but currently unable to make FEngineShowFlags a UStruct to use it as a UProperty...) </para>
		/// </summary>
		protected void UpdateShowFlags()
			=> E_USceneCaptureComponent_UpdateShowFlags(this);
		
		#endregion
		
		public static implicit operator IntPtr(USceneCaptureComponent self)
		{
			return self.NativePointer;
		}

		public static implicit operator USceneCaptureComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<USceneCaptureComponent>(PtrDesc);
		}}}
