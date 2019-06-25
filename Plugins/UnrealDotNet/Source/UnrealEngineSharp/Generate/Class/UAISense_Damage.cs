// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\Perception\AISense_Damage.h:56

namespace UnrealEngine
{
	public partial class UAISense_Damage : UAISense
	{
		public UAISense_Damage(IntPtr adress)
			: base(adress)
		{
		}

		public UAISense_Damage(UObject Parent = null, string Name = "AISense_Damage")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UAISense_Damage(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UAISense_Damage(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAISense_Damage_RegisterEvent(IntPtr self, IntPtr @event);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UAISense_Damage_ReportDamageEvent(IntPtr self, IntPtr worldContextObject, IntPtr damagedActor, IntPtr instigator, float damageAmount, IntPtr eventLocation, IntPtr hitLocation);
		
		#endregion
		
		#region ExternMethods
		public void RegisterEvent(FAIDamageEvent @event)
			=> E_UAISense_Damage_RegisterEvent(this, @event);
		
		
		/// <summary>
		/// EventLocation will be reported as Instigator's location at the moment of event happening
		/// </summary>
		public void ReportDamageEvent(UObject worldContextObject, AActor damagedActor, AActor instigator, float damageAmount, FVector eventLocation, FVector hitLocation)
			=> E_UAISense_Damage_ReportDamageEvent(this, worldContextObject, damagedActor, instigator, damageAmount, eventLocation, hitLocation);
		
		#endregion
		
		public static implicit operator IntPtr(UAISense_Damage self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UAISense_Damage(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UAISense_Damage>(PtrDesc);
		}}}
