using System;
using System.Runtime.InteropServices;

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Components\SceneCaptureComponent.h:59

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

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_USceneCaptureComponent(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneCaptureComponent_ClearHiddenComponents(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneCaptureComponent_ClearShowOnlyComponents(IntPtr Self, IntPtr InComponent);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneCaptureComponent_HideActorComponents(IntPtr Self, IntPtr InActor);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneCaptureComponent_HideComponent(IntPtr Self, IntPtr InComponent);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneCaptureComponent_RemoveShowOnlyActorComponents(IntPtr Self, IntPtr InActor);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneCaptureComponent_RemoveShowOnlyComponent(IntPtr Self, IntPtr InComponent);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneCaptureComponent_SetCaptureSortPriority(IntPtr Self, int NewCaptureSortPriority);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneCaptureComponent_ShowOnlyActorComponents(IntPtr Self, IntPtr InActor);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneCaptureComponent_ShowOnlyComponent(IntPtr Self, IntPtr InComponent);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_USceneCaptureComponent_UpdateShowFlags(IntPtr Self);
		
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
		public void ClearShowOnlyComponents(UPrimitiveComponent InComponent)
			=> E_USceneCaptureComponent_ClearShowOnlyComponents(this, InComponent);
		
		
		/// <summary>
		/// <para>Adds all primitive components in the actor to our list of hidden components. </para>
		/// </summary>
		public void HideActorComponents(AActor InActor)
			=> E_USceneCaptureComponent_HideActorComponents(this, InActor);
		
		
		/// <summary>
		/// <para>Adds the component to our list of hidden components. </para>
		/// </summary>
		public void HideComponent(UPrimitiveComponent InComponent)
			=> E_USceneCaptureComponent_HideComponent(this, InComponent);
		
		
		/// <summary>
		/// <para>Removes a actor's components from the Show Only list. </para>
		/// </summary>
		public void RemoveShowOnlyActorComponents(AActor InActor)
			=> E_USceneCaptureComponent_RemoveShowOnlyActorComponents(this, InActor);
		
		
		/// <summary>
		/// <para>Removes a component from the Show Only list. </para>
		/// </summary>
		public void RemoveShowOnlyComponent(UPrimitiveComponent InComponent)
			=> E_USceneCaptureComponent_RemoveShowOnlyComponent(this, InComponent);
		
		
		/// <summary>
		/// <para>Changes the value of TranslucentSortPriority. </para>
		/// </summary>
		public void SetCaptureSortPriority(int NewCaptureSortPriority)
			=> E_USceneCaptureComponent_SetCaptureSortPriority(this, NewCaptureSortPriority);
		
		
		/// <summary>
		/// <para>Adds all primitive components in the actor to our list of show-only components. </para>
		/// </summary>
		public void ShowOnlyActorComponents(AActor InActor)
			=> E_USceneCaptureComponent_ShowOnlyActorComponents(this, InActor);
		
		
		/// <summary>
		/// <para>Adds the component to our list of show-only components. </para>
		/// </summary>
		public void ShowOnlyComponent(UPrimitiveComponent InComponent)
			=> E_USceneCaptureComponent_ShowOnlyComponent(this, InComponent);
		
		
		/// <summary>
		/// <para>Update the show flags from our show flags settings (ideally, you'd be able to set this more directly, but currently unable to make FEngineShowFlags a UStruct to use it as a UProperty...) </para>
		/// </summary>
		protected void UpdateShowFlags()
			=> E_USceneCaptureComponent_UpdateShowFlags(this);
		
		#endregion
		
		public static implicit operator IntPtr(USceneCaptureComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator USceneCaptureComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<USceneCaptureComponent>(PtrDesc);
		}}}
