// This file was created automatically, do not modify the contents of this file.

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.20\Engine\Source\Runtime\Engine\Classes\Engine\EngineTypes.h:3473

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
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UEngineTypes(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_UEngineTypes_ConvertToCollisionChannel(IntPtr self, byte traceType);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_UEngineTypes_ConvertToCollisionChannel_o1(IntPtr self, byte objectType);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_UEngineTypes_ConvertToObjectType(IntPtr self, byte collisionChannel);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_UEngineTypes_ConvertToTraceType(IntPtr self, byte collisionChannel);
		
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// <para>Convert a trace type to a collision channel. </para>
		/// </summary>
		public ECollisionChannel ConvertToCollisionChannel(ETraceTypeQuery traceType)
			=> (ECollisionChannel)E_UEngineTypes_ConvertToCollisionChannel(this, (byte)traceType);
		
		
		/// <summary>
		/// <para>Convert an object type to a collision channel. </para>
		/// </summary>
		public ECollisionChannel ConvertToCollisionChannel(EObjectTypeQuery objectType)
			=> (ECollisionChannel)E_UEngineTypes_ConvertToCollisionChannel_o1(this, (byte)objectType);
		
		
		/// <summary>
		/// <para>Convert a collision channel to an object type. Note: performs a search of object types. </para>
		/// </summary>
		public EObjectTypeQuery ConvertToObjectType(ECollisionChannel collisionChannel)
			=> (EObjectTypeQuery)E_UEngineTypes_ConvertToObjectType(this, (byte)collisionChannel);
		
		
		/// <summary>
		/// <para>Convert a collision channel to a trace type. Note: performs a search of trace types. </para>
		/// </summary>
		public ETraceTypeQuery ConvertToTraceType(ECollisionChannel collisionChannel)
			=> (ETraceTypeQuery)E_UEngineTypes_ConvertToTraceType(this, (byte)collisionChannel);
		
		#endregion
		
		public static implicit operator IntPtr(UEngineTypes self)
		{
			return self.NativePointer;
		}

		public static implicit operator UEngineTypes(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UEngineTypes>(PtrDesc);
		}}}
