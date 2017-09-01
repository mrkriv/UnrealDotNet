using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// Render only primitives in the ShowOnlyActors list, or components specified with ShowOnlyComponent().
	/// </summary>
	public partial class USceneCaptureComponent : USceneComponent
	{
		public USceneCaptureComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_USceneCaptureComponent_HideComponent(IntPtr Self, IntPtr InComponent);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_USceneCaptureComponent_HideActorComponents(IntPtr Self, IntPtr InActor);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_USceneCaptureComponent_SetCaptureSortPriority(IntPtr Self, int NewCaptureSortPriority);
		
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Adds the component to our list of hidden components.
		/// </summary>
		public void HideComponent(UPrimitiveComponent InComponent)
			=> E_USceneCaptureComponent_HideComponent(NativePointer, InComponent);
		
		
		/// <summary>
		/// Adds all primitive components in the actor to our list of hidden components.
		/// </summary>
		public void HideActorComponents(AActor InActor)
			=> E_USceneCaptureComponent_HideActorComponents(NativePointer, InActor);
		
		
		/// <summary>
		/// Changes the value of TranslucentSortPriority.
		/// </summary>
		public void SetCaptureSortPriority(int NewCaptureSortPriority)
			=> E_USceneCaptureComponent_SetCaptureSortPriority(NativePointer, NewCaptureSortPriority);
		
		#endregion
		
		public static implicit operator IntPtr(USceneCaptureComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator USceneCaptureComponent(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new USceneCaptureComponent(Adress);
		}}}
