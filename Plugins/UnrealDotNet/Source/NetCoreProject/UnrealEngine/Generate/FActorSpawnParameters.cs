using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public partial class FActorSpawnParameters
	{
		private readonly IntPtr NativePointer;
		private readonly bool IsRef;
		
		public FActorSpawnParameters()
		{
			NativePointer = E_CreateStruct_FActorSpawnParameters();
			IsRef = false;
		}

		internal FActorSpawnParameters(IntPtr NativePointer, bool IsRef)
		{
			this.NativePointer = NativePointer;
			this.IsRef = IsRef;
		}

		
		#region DLLInmport
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern IntPtr E_CreateStruct_FActorSpawnParameters();
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_DeleteStruct(IntPtr Adress);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern AActor E_Struct_FActorSpawnParameters_Template_GET(IntPtr Ptr);
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_Struct_FActorSpawnParameters_Template_SET(IntPtr Ptr, AActor Value);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern AActor E_Struct_FActorSpawnParameters_Owner_GET(IntPtr Ptr);
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_Struct_FActorSpawnParameters_Owner_SET(IntPtr Ptr, AActor Value);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern APawn E_Struct_FActorSpawnParameters_Instigator_GET(IntPtr Ptr);
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern void E_Struct_FActorSpawnParameters_Instigator_SET(IntPtr Ptr, APawn Value);
		
		#if PACING
		[DllImport("DotUnrealExample.exe")]
		#else
		[DllImport("UE4Editor-UnrealDotNetRuntime")]
		#endif
		private static extern bool E_FActorSpawnParameters_IsRemoteOwned(FActorSpawnParameters Self);
		
		#endregion
		
		#region Property
		public AActor Template
		{
			get => E_Struct_FActorSpawnParameters_Template_GET(NativePointer);
			set => E_Struct_FActorSpawnParameters_Template_SET(NativePointer, value);
		}

		public AActor Owner
		{
			get => E_Struct_FActorSpawnParameters_Owner_GET(NativePointer);
			set => E_Struct_FActorSpawnParameters_Owner_SET(NativePointer, value);
		}

		public APawn Instigator
		{
			get => E_Struct_FActorSpawnParameters_Instigator_GET(NativePointer);
			set => E_Struct_FActorSpawnParameters_Instigator_SET(NativePointer, value);
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
