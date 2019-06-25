// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\DataProviders\AIDataProvider.h:25

namespace UnrealEngine
{
	public partial class FAIDataProviderValue : NativeStructWrapper
	{
		public FAIDataProviderValue(IntPtr NativePointer, bool IsRef = false) : base(NativePointer, IsRef)
		{
		}

		public FAIDataProviderValue() :
			base(E_CreateStruct_FAIDataProviderValue(), false)
		{
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_PROP_FAIDataProviderValue_DataBinding_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FAIDataProviderValue_DataBinding_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_FAIDataProviderValue_DataField_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_FAIDataProviderValue_DataField_SET(IntPtr Ptr, string Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_CreateStruct_FAIDataProviderValue();
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_FAIDataProviderValue_BindData(IntPtr self, IntPtr owner, int requestId);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_FAIDataProviderValue_IsDynamic(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_FAIDataProviderValue_ToString(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_FAIDataProviderValue_ValueToString(IntPtr self);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// (optional) provider for dynamic data binding
		/// </summary>
		public UAIDataProvider DataBinding
		{
			get => E_PROP_FAIDataProviderValue_DataBinding_GET(NativePointer);
			set => E_PROP_FAIDataProviderValue_DataBinding_SET(NativePointer, value);
		}

		
		/// <summary>
		/// name of provider's value property
		/// </summary>
		public string DataField
		{
			get => E_PROP_FAIDataProviderValue_DataField_GET(NativePointer);
			set => E_PROP_FAIDataProviderValue_DataField_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		
		/// <summary>
		/// bind data in provider and cache property for faster access
		/// </summary>
		public void BindData(UObject owner, int requestId)
			=> E_FAIDataProviderValue_BindData(this, owner, requestId);
		
		public bool IsDynamic()
			=> E_FAIDataProviderValue_IsDynamic(this);
		
		public override string ToString()
			=> E_FAIDataProviderValue_ToString(this);
		
		
		/// <summary>
		/// describe default data
		/// </summary>
		public virtual string ValueToString()
			=> E_FAIDataProviderValue_ValueToString(this);
		
		#endregion
		
		public static implicit operator IntPtr(FAIDataProviderValue self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator FAIDataProviderValue(IntPtr adress)
		{
			return adress == IntPtr.Zero ? null : new FAIDataProviderValue(adress, false);
		}}}
