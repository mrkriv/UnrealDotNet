// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Components\DecalComponent.h:22

namespace UnrealEngine
{
	public  partial class UDecalComponent : USceneComponent
	{
		public UDecalComponent(IntPtr adress)
			: base(adress)
		{
		}

		public UDecalComponent(UObject Parent = null, string Name = "DecalComponent")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UDecalComponent(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UDecalComponent_bDestroyOwnerAfterFade_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UDecalComponent_bDestroyOwnerAfterFade_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_UDecalComponent_DecalSize_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UDecalComponent_DecalSize_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UDecalComponent_FadeDuration_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UDecalComponent_FadeDuration_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UDecalComponent_FadeInDuration_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UDecalComponent_FadeInDuration_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UDecalComponent_FadeInStartDelay_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UDecalComponent_FadeInStartDelay_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UDecalComponent_FadeScreenSize_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UDecalComponent_FadeScreenSize_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_PROP_UDecalComponent_FadeStartDelay_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UDecalComponent_FadeStartDelay_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_UDecalComponent_SortOrder_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UDecalComponent_SortOrder_SET(IntPtr Ptr, int Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UDecalComponent(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UDecalComponent_GetFadeDuration(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UDecalComponent_GetFadeInDuration(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UDecalComponent_GetFadeInStartDelay(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UDecalComponent_GetFadeStartDelay(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_UDecalComponent_GetNumMaterials(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UDecalComponent_GetTransformIncludingDecalSize(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UDecalComponent_LifeSpanCallback(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UDecalComponent_PushSelectionToProxy(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UDecalComponent_SetFadeIn(IntPtr self, float startDelay, float duaration);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UDecalComponent_SetFadeOut(IntPtr self, float startDelay, float duration, bool destroyOwnerAfterFade);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UDecalComponent_SetFadeScreenSize(IntPtr self, float newFadeScreenSize);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UDecalComponent_SetLifeSpan(IntPtr self, float lifeSpan);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UDecalComponent_SetSortOrder(IntPtr self, int value);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// Automatically destroys the owning actor after fully fading out.
		/// </summary>
		public byte bDestroyOwnerAfterFade
		{
			get => E_PROP_UDecalComponent_bDestroyOwnerAfterFade_GET(NativePointer);
			set => E_PROP_UDecalComponent_bDestroyOwnerAfterFade_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Decal size in local space (does not include the component scale), technically redundant but there for convenience
		/// </summary>
		public FVector DecalSize
		{
			get => E_PROP_UDecalComponent_DecalSize_GET(NativePointer);
			set => E_PROP_UDecalComponent_DecalSize_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Time in seconds for the decal to fade out. Set fade duration and start delay to 0 to make persistent. Only fades in active simulation or game.
		/// </summary>
		public float FadeDuration
		{
			get => E_PROP_UDecalComponent_FadeDuration_GET(NativePointer);
			set => E_PROP_UDecalComponent_FadeDuration_SET(NativePointer, value);
		}

		public float FadeInDuration
		{
			get => E_PROP_UDecalComponent_FadeInDuration_GET(NativePointer);
			set => E_PROP_UDecalComponent_FadeInDuration_SET(NativePointer, value);
		}

		public float FadeInStartDelay
		{
			get => E_PROP_UDecalComponent_FadeInStartDelay_GET(NativePointer);
			set => E_PROP_UDecalComponent_FadeInStartDelay_SET(NativePointer, value);
		}

		public float FadeScreenSize
		{
			get => E_PROP_UDecalComponent_FadeScreenSize_GET(NativePointer);
			set => E_PROP_UDecalComponent_FadeScreenSize_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Time in seconds to wait before beginning to fade out the decal. Set fade duration and start delay to 0 to make persistent.
		/// </summary>
		public float FadeStartDelay
		{
			get => E_PROP_UDecalComponent_FadeStartDelay_GET(NativePointer);
			set => E_PROP_UDecalComponent_FadeStartDelay_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Controls the order in which decal elements are rendered.  Higher values draw later (on top).
		/// <para>Setting many different sort orders on many different decals prevents sorting by state and can reduce performance. </para>
		/// </summary>
		public int SortOrder
		{
			get => E_PROP_UDecalComponent_SortOrder_GET(NativePointer);
			set => E_PROP_UDecalComponent_SortOrder_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		public float GetFadeDuration()
			=> E_UDecalComponent_GetFadeDuration(this);
		
		public float GetFadeInDuration()
			=> E_UDecalComponent_GetFadeInDuration(this);
		
		public float GetFadeInStartDelay()
			=> E_UDecalComponent_GetFadeInStartDelay(this);
		
		public float GetFadeStartDelay()
			=> E_UDecalComponent_GetFadeStartDelay(this);
		
		public virtual int GetNumMaterials()
			=> E_UDecalComponent_GetNumMaterials(this);
		
		public FTransform GetTransformIncludingDecalSize()
			=> E_UDecalComponent_GetTransformIncludingDecalSize(this);
		
		
		/// <summary>
		/// Called when the life span of the decal has been exceeded
		/// </summary>
		protected virtual void LifeSpanCallback()
			=> E_UDecalComponent_LifeSpanCallback(this);
		
		
		/// <summary>
		/// Pushes new selection state to the render thread primitive proxy
		/// </summary>
		public void PushSelectionToProxy()
			=> E_UDecalComponent_PushSelectionToProxy(this);
		
		public void SetFadeIn(float startDelay, float duaration)
			=> E_UDecalComponent_SetFadeIn(this, startDelay, duaration);
		
		
		/// <summary>
		/// Sets the decal's fade start time, duration and if the owning actor should be destroyed after the decal is fully faded out.
		/// <para>The default value of 0 for FadeStartDelay and FadeDuration makes the decal persistent. See DecalLifetimeOpacity material </para>
		/// node to control the look of "fading out."
		/// </summary>
		/// <param name="startDelay">Time in seconds to wait before beginning to fade out the decal.</param>
		/// <param name="duration">Time in second for the decal to fade out.</param>
		/// <param name="destroyOwnerAfterFade">Should the owning actor automatically be destroyed after it is completely faded out.</param>
		public void SetFadeOut(float startDelay, float duration, bool destroyOwnerAfterFade = true)
			=> E_UDecalComponent_SetFadeOut(this, startDelay, duration, destroyOwnerAfterFade);
		
		
		/// <summary>
		/// Set the FadeScreenSize for this decal component
		/// </summary>
		public void SetFadeScreenSize(float newFadeScreenSize)
			=> E_UDecalComponent_SetFadeScreenSize(this, newFadeScreenSize);
		
		public void SetLifeSpan(float lifeSpan)
			=> E_UDecalComponent_SetLifeSpan(this, lifeSpan);
		
		
		/// <summary>
		/// Sets the sort order for the decal component. Higher values draw later (on top). This will force the decal to reattach
		/// </summary>
		public void SetSortOrder(int value)
			=> E_UDecalComponent_SetSortOrder(this, value);
		
		#endregion
		
		public static implicit operator IntPtr(UDecalComponent self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UDecalComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UDecalComponent>(PtrDesc);
		}}}
