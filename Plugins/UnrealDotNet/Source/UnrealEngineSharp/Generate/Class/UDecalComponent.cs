using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\Components\DecalComponent.h:22

namespace UnrealEngine
{
	public  partial class UDecalComponent : USceneComponent
	{
		public UDecalComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public UDecalComponent(UObject Parent = null, string Name = "DecalComponent")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UDecalComponent(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UDecalComponent(IntPtr Parent, string Name);
		
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
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UDecalComponent_GetFadeDuration(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern float E_UDecalComponent_GetFadeStartDelay(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_UDecalComponent_GetNumMaterials(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UDecalComponent_GetTransformIncludingDecalSize(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UDecalComponent_LifeSpanCallback(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UDecalComponent_PushSelectionToProxy(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UDecalComponent_SetFadeOut(IntPtr Self, float StartDelay, float Duration, bool DestroyOwnerAfterFade);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UDecalComponent_SetFadeScreenSize(IntPtr Self, float NewFadeScreenSize);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UDecalComponent_SetLifeSpan(IntPtr Self, float LifeSpan);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UDecalComponent_SetSortOrder(IntPtr Self, int Value);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// <para>Automatically destroys the owning actor after fully fading out. </para>
		/// </summary>
		public byte bDestroyOwnerAfterFade
		{
			get => E_PROP_UDecalComponent_bDestroyOwnerAfterFade_GET(NativePointer);
			set => E_PROP_UDecalComponent_bDestroyOwnerAfterFade_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Decal size in local space (does not include the component scale), technically redundant but there for convenience </para>
		/// </summary>
		public FVector DecalSize
		{
			get => E_PROP_UDecalComponent_DecalSize_GET(NativePointer);
			set => E_PROP_UDecalComponent_DecalSize_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Time in seconds for the decal to fade out. Set fade duration and start delay to 0 to make persistent. Only fades in active simulation or game. </para>
		/// </summary>
		public float FadeDuration
		{
			get => E_PROP_UDecalComponent_FadeDuration_GET(NativePointer);
			set => E_PROP_UDecalComponent_FadeDuration_SET(NativePointer, value);
		}

		public float FadeScreenSize
		{
			get => E_PROP_UDecalComponent_FadeScreenSize_GET(NativePointer);
			set => E_PROP_UDecalComponent_FadeScreenSize_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Time in seconds to wait before beginning to fade out the decal. Set fade duration and start delay to 0 to make persistent. </para>
		/// </summary>
		public float FadeStartDelay
		{
			get => E_PROP_UDecalComponent_FadeStartDelay_GET(NativePointer);
			set => E_PROP_UDecalComponent_FadeStartDelay_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Controls the order in which decal elements are rendered.  Higher values draw later (on top). </para>
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
		
		public float GetFadeStartDelay()
			=> E_UDecalComponent_GetFadeStartDelay(this);
		
		public virtual int GetNumMaterials()
			=> E_UDecalComponent_GetNumMaterials(this);
		
		public FTransform GetTransformIncludingDecalSize()
			=> E_UDecalComponent_GetTransformIncludingDecalSize(this);
		
		
		/// <summary>
		/// <para>Called when the life span of the decal has been exceeded </para>
		/// </summary>
		protected virtual void LifeSpanCallback()
			=> E_UDecalComponent_LifeSpanCallback(this);
		
		
		/// <summary>
		/// <para>Pushes new selection state to the render thread primitive proxy </para>
		/// </summary>
		public void PushSelectionToProxy()
			=> E_UDecalComponent_PushSelectionToProxy(this);
		
		
		/// <summary>
		/// <para>Sets the decal's fade start time, duration and if the owning actor should be destroyed after the decal is fully faded out. </para>
		/// <para>The default value of 0 for FadeStartDelay and FadeDuration makes the decal persistent. See DecalLifetimeOpacity material </para>
		/// <para>node to control the look of "fading out." </para>
		/// <param name="StartDelay">Time in seconds to wait before beginning to fade out the decal. </param>
		/// <param name="Duration">Time in second for the decal to fade out. </param>
		/// <param name="DestroyOwnerAfterFade">Should the owning actor automatically be destroyed after it is completely faded out. </param>
		/// </summary>
		public void SetFadeOut(float StartDelay, float Duration, bool DestroyOwnerAfterFade = true)
			=> E_UDecalComponent_SetFadeOut(this, StartDelay, Duration, DestroyOwnerAfterFade);
		
		
		/// <summary>
		/// <para>Set the FadeScreenSize for this decal component </para>
		/// </summary>
		public void SetFadeScreenSize(float NewFadeScreenSize)
			=> E_UDecalComponent_SetFadeScreenSize(this, NewFadeScreenSize);
		
		public void SetLifeSpan(float LifeSpan)
			=> E_UDecalComponent_SetLifeSpan(this, LifeSpan);
		
		
		/// <summary>
		/// <para>Sets the sort order for the decal component. Higher values draw later (on top). This will force the decal to reattach </para>
		/// </summary>
		public void SetSortOrder(int Value)
			=> E_UDecalComponent_SetSortOrder(this, Value);
		
		#endregion
		
		public static implicit operator IntPtr(UDecalComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator UDecalComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UDecalComponent>(PtrDesc);
		}}}
