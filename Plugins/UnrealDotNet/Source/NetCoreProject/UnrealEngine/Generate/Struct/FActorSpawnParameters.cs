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
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern IntPtr E_CreateStruct_FActorSpawnParameters();
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_DeleteStruct(IntPtr Adress);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern string E_PROP_FActorSpawnParameters_Name_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FActorSpawnParameters_Name_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern AActor E_PROP_FActorSpawnParameters_Template_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FActorSpawnParameters_Template_SET(IntPtr Ptr, AActor Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern AActor E_PROP_FActorSpawnParameters_Owner_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FActorSpawnParameters_Owner_SET(IntPtr Ptr, AActor Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern APawn E_PROP_FActorSpawnParameters_Instigator_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FActorSpawnParameters_Instigator_SET(IntPtr Ptr, APawn Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern ULevel E_PROP_FActorSpawnParameters_OverrideLevel_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern void E_PROP_FActorSpawnParameters_OverrideLevel_SET(IntPtr Ptr, ULevel Value);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl, CharSet = CharSet.Unicode)]
		private static extern bool E_FActorSpawnParameters_IsRemoteOwned(FActorSpawnParameters Self);
		
		#endregion
		
		#region Property
		public string Name
		{
			get => E_PROP_FActorSpawnParameters_Name_GET(NativePointer);
			set => E_PROP_FActorSpawnParameters_Name_SET(NativePointer, value);
		}

		public AActor Template
		{
			get => E_PROP_FActorSpawnParameters_Template_GET(NativePointer);
			set => E_PROP_FActorSpawnParameters_Template_SET(NativePointer, value);
		}

		public AActor Owner
		{
			get => E_PROP_FActorSpawnParameters_Owner_GET(NativePointer);
			set => E_PROP_FActorSpawnParameters_Owner_SET(NativePointer, value);
		}

		public APawn Instigator
		{
			get => E_PROP_FActorSpawnParameters_Instigator_GET(NativePointer);
			set => E_PROP_FActorSpawnParameters_Instigator_SET(NativePointer, value);
		}

		public ULevel OverrideLevel
		{
			get => E_PROP_FActorSpawnParameters_OverrideLevel_GET(NativePointer);
			set => E_PROP_FActorSpawnParameters_OverrideLevel_SET(NativePointer, value);
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
