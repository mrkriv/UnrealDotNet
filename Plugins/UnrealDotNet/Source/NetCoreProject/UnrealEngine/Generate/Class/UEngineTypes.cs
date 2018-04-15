using System;
using System.Runtime.InteropServices;

// Source file D:\UE4\UE_4.19\Engine\Source\Runtime\Engine\Classes\Engine\EngineTypes.h:3430

namespace UnrealEngine
{
	public  partial class UEngineTypes : UObject
	{
		public UEngineTypes(IntPtr Adress)
			: base(Adress)
		{
		}

		public UEngineTypes(UObject Parent = null, string Name = "EngineTypes")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UEngineTypes(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UEngineTypes(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_UEngineTypes_ConvertToObjectType(IntPtr Self, byte CollisionChannel);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_UEngineTypes_ConvertToTraceType(IntPtr Self, byte CollisionChannel);
		
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// <para>Convert a collision channel to an object type. Note: performs a search of object types. </para>
		/// </summary>
		public EObjectTypeQuery ConvertToObjectType(ECollisionChannel CollisionChannel)
			=> (EObjectTypeQuery)E_UEngineTypes_ConvertToObjectType(this, (byte)CollisionChannel);
		
		
		/// <summary>
		/// <para>Convert a collision channel to a trace type. Note: performs a search of trace types. </para>
		/// </summary>
		public ETraceTypeQuery ConvertToTraceType(ECollisionChannel CollisionChannel)
			=> (ETraceTypeQuery)E_UEngineTypes_ConvertToTraceType(this, (byte)CollisionChannel);
		
		#endregion
		
		public static implicit operator IntPtr(UEngineTypes Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator UEngineTypes(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UEngineTypes>(PtrDesc);
		}}}
