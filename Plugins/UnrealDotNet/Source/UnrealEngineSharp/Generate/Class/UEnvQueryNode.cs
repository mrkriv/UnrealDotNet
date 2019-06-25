// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\EnvironmentQuery\EnvQueryNode.h:14

namespace UnrealEngine
{
	public partial class UEnvQueryNode : UObject
	{
		public UEnvQueryNode(IntPtr adress)
			: base(adress)
		{
		}

		public UEnvQueryNode(UObject Parent = null, string Name = "EnvQueryNode")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UEnvQueryNode(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_UEnvQueryNode_VerNum_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UEnvQueryNode_VerNum_SET(IntPtr Ptr, int Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UEnvQueryNode(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_UEnvQueryNode_GetDescriptionDetails(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_UEnvQueryNode_GetDescriptionTitle(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UEnvQueryNode_UpdateNodeVersion(IntPtr self);
		
		#endregion
		
		#region Property
		public int VerNum
		{
			get => E_PROP_UEnvQueryNode_VerNum_GET(NativePointer);
			set => E_PROP_UEnvQueryNode_VerNum_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		public virtual string GetDescriptionDetails()
			=> E_UEnvQueryNode_GetDescriptionDetails(this);
		
		public virtual string GetDescriptionTitle()
			=> E_UEnvQueryNode_GetDescriptionTitle(this);
		
		public virtual void UpdateNodeVersion()
			=> E_UEnvQueryNode_UpdateNodeVersion(this);
		
		#endregion
		
		public static implicit operator IntPtr(UEnvQueryNode self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UEnvQueryNode(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UEnvQueryNode>(PtrDesc);
		}}}
