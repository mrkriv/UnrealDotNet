// This file was created automatically, do not modify the contents of this file.

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\Engine\EngineTypes.h:3348

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
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FComponentReference();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_FComponentReference_ComponentProperty_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FComponentReference_ComponentProperty_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_PROP_FComponentReference_OtherActor_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FComponentReference_OtherActor_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_FComponentReference_GetComponent(IntPtr self, IntPtr owningActor);
		
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
		public USceneComponent GetComponent(AActor owningActor)
			=> E_FComponentReference_GetComponent(this, owningActor);
		
		#endregion
		
		public static implicit operator IntPtr(FComponentReference self)
		{
			return self.NativePointer;
		}

		public static implicit operator FComponentReference(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FComponentReference(Adress, false);
		}}}
