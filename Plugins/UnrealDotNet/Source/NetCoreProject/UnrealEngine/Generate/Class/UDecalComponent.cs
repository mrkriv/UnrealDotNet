using System;
using System.Runtime.InteropServices;

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
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UDecalComponent(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UDecalComponent_GetTransformIncludingDecalSize(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UDecalComponent_LifeSpanCallback(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UDecalComponent_PushSelectionToProxy(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UDecalComponent_SetLifeSpan(IntPtr Self, float LifeSpan);
		
		#endregion
		
		#region ExternMethods
		public FTransform GetTransformIncludingDecalSize()
			=> E_UDecalComponent_GetTransformIncludingDecalSize(this);
		
		
		/// <summary>
		/// <para>Called when the life span of the decal has been exceeded </para>
		/// </summary>
		protected void LifeSpanCallback()
			=> E_UDecalComponent_LifeSpanCallback(this);
		
		
		/// <summary>
		/// <para>Pushes new selection state to the render thread primitive proxy </para>
		/// </summary>
		public void PushSelectionToProxy()
			=> E_UDecalComponent_PushSelectionToProxy(this);
		
		public void SetLifeSpan(float LifeSpan)
			=> E_UDecalComponent_SetLifeSpan(this, LifeSpan);
		
		#endregion
		
		public static implicit operator IntPtr(UDecalComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator UDecalComponent(IntPtr Adress)
		{
			if (Adress == IntPtr.Zero)
				return null;
			return NativeManager.GetWrapper(Adress) as UDecalComponent ?? new UDecalComponent(Adress);
		}
}
}
