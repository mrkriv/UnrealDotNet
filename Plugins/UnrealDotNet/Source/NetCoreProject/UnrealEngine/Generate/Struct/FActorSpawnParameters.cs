using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class FActorSpawnParameters : NativeStructWrapper
	{
		public FActorSpawnParameters() : base(E_CreateStruct_FActorSpawnParameters(), false)
		{
		}

		internal FActorSpawnParameters(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_CreateStruct_FActorSpawnParameters();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_PROP_FActorSpawnParameters_Instigator_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FActorSpawnParameters_Instigator_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern string E_PROP_FActorSpawnParameters_Name_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FActorSpawnParameters_Name_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_PROP_FActorSpawnParameters_Owner_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FActorSpawnParameters_Owner_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_PROP_FActorSpawnParameters_Template_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FActorSpawnParameters_Template_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_FActorSpawnParameters_IsRemoteOwned(FActorSpawnParameters Self);
		
		#endregion
		
		#region Property
		public APawn Instigator
		{
			get => E_PROP_FActorSpawnParameters_Instigator_GET(NativePointer);
			set => E_PROP_FActorSpawnParameters_Instigator_SET(NativePointer, value);
		}

		public string Name
		{
			get => E_PROP_FActorSpawnParameters_Name_GET(NativePointer);
			set => E_PROP_FActorSpawnParameters_Name_SET(NativePointer, value);
		}

		public AActor Owner
		{
			get => E_PROP_FActorSpawnParameters_Owner_GET(NativePointer);
			set => E_PROP_FActorSpawnParameters_Owner_SET(NativePointer, value);
		}

		public AActor Template
		{
			get => E_PROP_FActorSpawnParameters_Template_GET(NativePointer);
			set => E_PROP_FActorSpawnParameters_Template_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		public bool IsRemoteOwned()
			=> E_FActorSpawnParameters_IsRemoteOwned(this);
		
		#endregion
		
		public static implicit operator IntPtr(FActorSpawnParameters Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator FActorSpawnParameters(IntPtr Adress)
		{
			return Adress == IntPtr.Zero ? null : new FActorSpawnParameters(Adress, false);
		}}}
