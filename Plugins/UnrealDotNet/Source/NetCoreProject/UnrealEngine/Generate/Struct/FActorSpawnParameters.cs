using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class FActorSpawnParameters : NativeStructWrapper
	{
		internal FActorSpawnParameters(IntPtr NativePointer, bool IsRef) : base(NativePointer, IsRef)
		{
		}

		public FActorSpawnParameters() :
			base(E_CreateStruct_FActorSpawnParameters(), false)
		{
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FActorSpawnParameters();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_FActorSpawnParameters_Name_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FActorSpawnParameters_Name_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_FActorSpawnParameters_SpawnCollisionHandlingOverride_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FActorSpawnParameters_SpawnCollisionHandlingOverride_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FActorSpawnParameters_IsRemoteOwned(IntPtr Self);
		
		#endregion
		
		#region Property
		public string Name
		{
			get => E_PROP_FActorSpawnParameters_Name_GET(NativePointer);
			set => E_PROP_FActorSpawnParameters_Name_SET(NativePointer, value);
		}

		
		/// <summary>
		/// <para>Method for resolving collisions at the spawn point. Undefined means no override, use the actor's setting. </para>
		/// </summary>
		public ESpawnActorCollisionHandlingMethod SpawnCollisionHandlingOverride
		{
			get => (ESpawnActorCollisionHandlingMethod)E_PROP_FActorSpawnParameters_SpawnCollisionHandlingOverride_GET(NativePointer);
			set => E_PROP_FActorSpawnParameters_SpawnCollisionHandlingOverride_SET(NativePointer, (byte)value);
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
