using System;
using System.Runtime.InteropServices;

// Source file D:\ue4\UE_4.17\Engine\Source\Runtime\Engine\Classes\Engine\EngineTypes.h:3297

namespace UnrealEngine
{
	public  partial class FComponentReference : NativeStructWrapper
	{
		internal FComponentReference(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FComponentReference() :
			base(E_CreateStruct_FComponentReference(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FComponentReference();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_FComponentReference_ComponentProperty_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FComponentReference_ComponentProperty_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_PROP_FComponentReference_OtherActor_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FComponentReference_OtherActor_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_FComponentReference_GetComponent(IntPtr Self, IntPtr OwningActor);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// <para>Name of component property to use </para>
		/// </summary>
		public string ComponentProperty
		{
			get => E_PROP_FComponentReference_ComponentProperty_GET(NativePointer);
			set => E_PROP_FComponentReference_ComponentProperty_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Pointer to a different Actor that owns the Component. </para>
		/// </summary>
		public AActor OtherActor
		{
			get => E_PROP_FComponentReference_OtherActor_GET(NativePointer);
			set => E_PROP_FComponentReference_OtherActor_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// <para>Get the actual component pointer from this reference </para>
		/// </summary>
		public USceneComponent GetComponent(AActor OwningActor)
			=> E_FComponentReference_GetComponent(this, OwningActor);
		
		#endregion
		
		public static implicit operator IntPtr(FComponentReference Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FComponentReference(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FComponentReference(Adress, false);
		}}}
