using System;
using System.Runtime.InteropServices;

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Engine\EngineBaseTypes.h:421

namespace UnrealEngine
{
	public  partial class FActorTickFunction : FTickFunction
	{
		internal FActorTickFunction(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FActorTickFunction() :
			base(E_CreateStruct_FActorTickFunction(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FActorTickFunction();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_PROP_FActorTickFunction_Target_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FActorTickFunction_Target_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_FActorTickFunction_DiagnosticMessage(IntPtr Self);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// <para>AActor  that is the target of this tick </para>
		/// </summary>
		public AActor Target
		{
			get => E_PROP_FActorTickFunction_Target_GET(NativePointer);
			set => E_PROP_FActorTickFunction_Target_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// <para>Abstract function to describe this tick. Used to print messages about illegal cycles in the dependency graph </para>
		/// </summary>
		public virtual string DiagnosticMessage()
			=> E_FActorTickFunction_DiagnosticMessage(this);
		
		#endregion
		
		public static implicit operator IntPtr(FActorTickFunction Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FActorTickFunction(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FActorTickFunction(Adress, false);
		}}}
