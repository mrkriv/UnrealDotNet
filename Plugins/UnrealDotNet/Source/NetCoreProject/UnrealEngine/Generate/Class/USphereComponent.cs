using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	
	/// <summary>
	/// Класс не может быть наследован в Вашем коде, используйте ManageSphereComponent
	/// <para>A sphere generally used for simple collision. Bounds are rendered as lines in the editor. </para>
	/// </summary>
	public  partial class USphereComponent : UShapeComponent
	{
		public USphereComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_PROP_USphereComponent_SphereRadius_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_USphereComponent_SphereRadius_SET(IntPtr Ptr, float Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_USphereComponent_GetScaledSphereRadius(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_USphereComponent_GetShapeScale(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern float E_USphereComponent_GetUnscaledSphereRadius(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_USphereComponent_InitSphereRadius(IntPtr Self, float InSphereRadius);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_USphereComponent_SetSphereRadius(IntPtr Self, float InSphereRadius, bool bUpdateOverlaps);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// <para>The radius of the sphere </para>
		/// </summary>
		protected float SphereRadius
		{
			get => E_PROP_USphereComponent_SphereRadius_GET(NativePointer);
			set => E_PROP_USphereComponent_SphereRadius_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		public float GetScaledSphereRadius()
			=> E_USphereComponent_GetScaledSphereRadius(this);
		
		public float GetShapeScale()
			=> E_USphereComponent_GetShapeScale(this);
		
		public float GetUnscaledSphereRadius()
			=> E_USphereComponent_GetUnscaledSphereRadius(this);
		
		public void InitSphereRadius(float InSphereRadius)
			=> E_USphereComponent_InitSphereRadius(this, InSphereRadius);
		
		
		/// <summary>
		/// <para>Change the sphere radius. This is the unscaled radius, before component scale is applied. </para>
		/// <para>@param	InSphereRadius: the new sphere radius </para>
		/// <para>@param	bUpdateOverlaps: if true and this shape is registered and collides, updates touching array for owner actor. </para>
		/// </summary>
		public void SetSphereRadius(float InSphereRadius, bool bUpdateOverlaps = true)
			=> E_USphereComponent_SetSphereRadius(this, InSphereRadius, bUpdateOverlaps);
		
		#endregion
		
		public static implicit operator IntPtr(USphereComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator USphereComponent(IntPtr Adress)
		{
			if (Adress == IntPtr.Zero)
				return null;
			return NativeManager.GetWrapper(Adress) as USphereComponent ?? new USphereComponent(Adress);
		}}}
