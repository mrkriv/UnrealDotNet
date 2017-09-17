using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class UShapeComponent : UPrimitiveComponent
	{
		public UShapeComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public UShapeComponent(UObject Parent = null, string Name = "ShapeComponent")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UShapeComponent(Parent, Name);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_NewObject_UShapeComponent(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern byte E_PROP_UShapeComponent_bUseArchetypeBodySetup_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_UShapeComponent_bUseArchetypeBodySetup_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_UShapeComponent_UpdateBodySetup(IntPtr Self);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// <para>If the body setup can be shared (i.e. there have been no alterations compared to the CDO) </para>
		/// </summary>
		protected byte bUseArchetypeBodySetup
		{
			get => E_PROP_UShapeComponent_bUseArchetypeBodySetup_GET(NativePointer);
			set => E_PROP_UShapeComponent_bUseArchetypeBodySetup_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// <para>Update the body setup parameters based on shape information </para>
		/// </summary>
		public virtual void UpdateBodySetup()
			=> E_UShapeComponent_UpdateBodySetup(this);
		
		#endregion
		
		public static implicit operator IntPtr(UShapeComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator UShapeComponent(IntPtr Adress)
		{
			if (Adress == IntPtr.Zero)
				return null;
			return NativeManager.GetWrapper(Adress) as UShapeComponent ?? new UShapeComponent(Adress);
		}}}
