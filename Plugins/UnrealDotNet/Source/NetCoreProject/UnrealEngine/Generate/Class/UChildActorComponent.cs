using System;
using System.Runtime.InteropServices;

namespace UnrealEngine
{
	public  partial class UChildActorComponent : USceneComponent
	{
		public UChildActorComponent(IntPtr Adress)
			: base(Adress)
		{
		}

		public UChildActorComponent(UObject Parent = null, string Name = "ChildActorComponent")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UChildActorComponent(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UChildActorComponent(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UChildActorComponent_CreateChildActor(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UChildActorComponent_DestroyChildActor(IntPtr Self);
		
		[DllImport(NativeManager.UnrealDotNetDLL, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_UChildActorComponent_GetChildActorName(IntPtr Self);
		
		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// <para>Create the child actor </para>
		/// </summary>
		public void CreateChildActor()
			=> E_UChildActorComponent_CreateChildActor(this);
		
		
		/// <summary>
		/// <para>Kill any currently present child actor </para>
		/// </summary>
		public void DestroyChildActor()
			=> E_UChildActorComponent_DestroyChildActor(this);
		
		public string GetChildActorName()
			=> E_UChildActorComponent_GetChildActorName(this);
		
		#endregion
		
		public static implicit operator IntPtr(UChildActorComponent Self)
		{
			return Self.NativePointer;
		}

		public static implicit operator UChildActorComponent(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UChildActorComponent>(PtrDesc);
		}}}
