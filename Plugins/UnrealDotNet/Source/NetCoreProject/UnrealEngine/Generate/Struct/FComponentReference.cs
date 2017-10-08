using System;
using System.Runtime.InteropServices;

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
		private static extern ObjectPointerDescription E_FComponentReference_GetComponent(IntPtr Self, IntPtr OwningActor);
		
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
