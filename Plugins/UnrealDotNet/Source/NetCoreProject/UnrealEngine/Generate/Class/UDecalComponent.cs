using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// A material that is rendered onto the surface of a mesh. A kind of 'bumper sticker' for a model.
	/// @see https://docs.unrealengine.com/latest/INT/Engine/Actors/DecalActor
	/// @see UDecalActor
	/// </summary>
	public partial class UDecalComponent : USceneComponent
	{
		public UDecalComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UDecalComponent_PushSelectionToProxy(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UDecalComponent_SetLifeSpan(IntPtr Self, float LifeSpan);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern int E_UDecalComponent_GetNumMaterials(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_UDecalComponent_GetTransformIncludingDecalSize(IntPtr Self);
		
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// Pushes new selection state to the render thread primitive proxy
		/// </summary>
		public void PushSelectionToProxy()
			=> E_UDecalComponent_PushSelectionToProxy(NativePointer);
		
		public void SetLifeSpan(float LifeSpan)
			=> E_UDecalComponent_SetLifeSpan(NativePointer, LifeSpan);
		
		public int GetNumMaterials()
			=> E_UDecalComponent_GetNumMaterials(NativePointer);
		
		public FTransform GetTransformIncludingDecalSize()
			=> E_UDecalComponent_GetTransformIncludingDecalSize(NativePointer);
		
		#endregion
		
		public static implicit operator IntPtr(UDecalComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator UDecalComponent(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new UDecalComponent(Adress);
		}}}
