// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

using System;
using System.Runtime.InteropServices;

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\AIModule\Classes\EnvironmentQuery\EnvQueryTest.h:60

namespace UnrealEngine
{
	public partial class UEnvQueryTest : UEnvQueryNode
	{
		public UEnvQueryTest(IntPtr adress)
			: base(adress)
		{
		}

		public UEnvQueryTest(UObject Parent = null, string Name = "EnvQueryTest")
			: base(IntPtr.Zero)
		{
			NativePointer = E_NewObject_UEnvQueryTest(Parent, Name);
			NativeManager.AddNativeWrapper(NativePointer, this);
		}

		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_PROP_UEnvQueryTest_bDefineReferenceValue_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UEnvQueryTest_bDefineReferenceValue_SET(IntPtr Ptr, bool Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_UEnvQueryTest_BoolValue_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UEnvQueryTest_BoolValue_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_UEnvQueryTest_FloatValueMax_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UEnvQueryTest_FloatValueMax_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_UEnvQueryTest_FloatValueMin_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UEnvQueryTest_FloatValueMin_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern byte E_PROP_UEnvQueryTest_NormalizationType_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UEnvQueryTest_NormalizationType_SET(IntPtr Ptr, byte Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_UEnvQueryTest_ReferenceValue_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UEnvQueryTest_ReferenceValue_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_UEnvQueryTest_ScoreClampMax_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UEnvQueryTest_ScoreClampMax_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_UEnvQueryTest_ScoreClampMin_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UEnvQueryTest_ScoreClampMin_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_PROP_UEnvQueryTest_ScoringFactor_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UEnvQueryTest_ScoringFactor_SET(IntPtr Ptr, IntPtr Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_PROP_UEnvQueryTest_TestComment_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UEnvQueryTest_TestComment_SET(IntPtr Ptr, string Value);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern int E_PROP_UEnvQueryTest_TestOrder_GET(IntPtr Ptr);
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_PROP_UEnvQueryTest_TestOrder_SET(IntPtr Ptr, int Value);
		
		#region DLLInmport
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_NewObject_UEnvQueryTest(IntPtr Parent, string Name);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UEnvQueryTest_CanRunAsFinalCondition(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_UEnvQueryTest_DescribeBoolTestParams(IntPtr self, string conditionDesc);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern StringWrapper E_UEnvQueryTest_DescribeFloatTestParams(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern ObjectPointerDescription E_UEnvQueryTest_GetItemActor(IntPtr self, IntPtr queryInstance, int itemIndex);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UEnvQueryTest_GetItemLocation(IntPtr self, IntPtr queryInstance, int itemIndex);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern IntPtr E_UEnvQueryTest_GetItemRotation(IntPtr self, IntPtr queryInstance, int itemIndex);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UEnvQueryTest_GetWorkOnFloatValues(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UEnvQueryTest_IsFiltering(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern bool E_UEnvQueryTest_IsScoring(IntPtr self);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UEnvQueryTest_NormalizeItemScores(IntPtr self, IntPtr queryInstance);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UEnvQueryTest_RunTest(IntPtr self, IntPtr queryInstance);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UEnvQueryTest_SetWorkOnFloatValues(IntPtr self, bool bWorkOnFloats);
		
		[DllImport(NativeManager.UnrealDotNetDll, CallingConvention = CallingConvention.Cdecl)]
		private static extern void E_UEnvQueryTest_UpdatePreviewData(IntPtr self);
		
		#endregion
		
		#region Property
		
		/// <summary>
		/// When set to true enables usage of ReferenceValue. It's false by default
		/// </summary>
		public bool bDefineReferenceValue
		{
			get => E_PROP_UEnvQueryTest_bDefineReferenceValue_GET(NativePointer);
			set => E_PROP_UEnvQueryTest_bDefineReferenceValue_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Desired boolean value of the test for scoring to occur or filtering test to pass.
		/// </summary>
		public FAIDataProviderBoolValue BoolValue
		{
			get => E_PROP_UEnvQueryTest_BoolValue_GET(NativePointer);
			set => E_PROP_UEnvQueryTest_BoolValue_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Maximum limit (inclusive) of valid values for the raw test value. Higher values will be discarded as invalid.
		/// </summary>
		public FAIDataProviderFloatValue FloatValueMax
		{
			get => E_PROP_UEnvQueryTest_FloatValueMax_GET(NativePointer);
			set => E_PROP_UEnvQueryTest_FloatValueMax_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Minimum limit (inclusive) of valid values for the raw test value. Lower values will be discarded as invalid.
		/// </summary>
		public FAIDataProviderFloatValue FloatValueMin
		{
			get => E_PROP_UEnvQueryTest_FloatValueMin_GET(NativePointer);
			set => E_PROP_UEnvQueryTest_FloatValueMin_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Specifies how to determine value span used to normalize scores
		/// </summary>
		public EEQSNormalizationType NormalizationType
		{
			get => (EEQSNormalizationType)E_PROP_UEnvQueryTest_NormalizationType_GET(NativePointer);
			set => E_PROP_UEnvQueryTest_NormalizationType_SET(NativePointer, (byte)value);
		}

		
		/// <summary>
		/// When specified gets used to normalize test's results in such a way that the closer a value is to ReferenceValue
		/// <para>the higher normalized result it will produce. Value farthest from ReferenceValue will be normalized </para>
		/// to 0, and all the other values in between will get normalized linearly with the distance to ReferenceValue.
		/// </summary>
		public FAIDataProviderFloatValue ReferenceValue
		{
			get => E_PROP_UEnvQueryTest_ReferenceValue_GET(NativePointer);
			set => E_PROP_UEnvQueryTest_ReferenceValue_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Maximum value to use to normalize the raw test value before applying scoring formula.
		/// </summary>
		public FAIDataProviderFloatValue ScoreClampMax
		{
			get => E_PROP_UEnvQueryTest_ScoreClampMax_GET(NativePointer);
			set => E_PROP_UEnvQueryTest_ScoreClampMax_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Minimum value to use to normalize the raw test value before applying scoring formula.
		/// </summary>
		public FAIDataProviderFloatValue ScoreClampMin
		{
			get => E_PROP_UEnvQueryTest_ScoreClampMin_GET(NativePointer);
			set => E_PROP_UEnvQueryTest_ScoreClampMin_SET(NativePointer, value);
		}

		
		/// <summary>
		/// The weight (factor) by which to multiply the normalized score after the scoring equation is applied.
		/// </summary>
		public FAIDataProviderFloatValue ScoringFactor
		{
			get => E_PROP_UEnvQueryTest_ScoringFactor_GET(NativePointer);
			set => E_PROP_UEnvQueryTest_ScoringFactor_SET(NativePointer, value);
		}

		
		/// <summary>
		/// Optional comment or explanation about what this test is for.  Useful when the purpose of tests may not be clear,
		/// <para>especially when there are multiple tests of the same type. </para>
		/// </summary>
		public string TestComment
		{
			get => E_PROP_UEnvQueryTest_TestComment_GET(NativePointer);
			set => E_PROP_UEnvQueryTest_TestComment_SET(NativePointer, value);
		}

		public int TestOrder
		{
			get => E_PROP_UEnvQueryTest_TestOrder_GET(NativePointer);
			set => E_PROP_UEnvQueryTest_TestOrder_SET(NativePointer, value);
		}

		#endregion
		
		#region ExternMethods
		public bool CanRunAsFinalCondition()
			=> E_UEnvQueryTest_CanRunAsFinalCondition(this);
		
		public string DescribeBoolTestParams(string conditionDesc)
			=> E_UEnvQueryTest_DescribeBoolTestParams(this, conditionDesc);
		
		public string DescribeFloatTestParams()
			=> E_UEnvQueryTest_DescribeFloatTestParams(this);
		
		
		/// <summary>
		/// helper: get actor from item
		/// </summary>
		public AActor GetItemActor(FEnvQueryInstance queryInstance, int itemIndex)
			=> E_UEnvQueryTest_GetItemActor(this, queryInstance, itemIndex);
		
		
		/// <summary>
		/// helper: get location of item
		/// </summary>
		public FVector GetItemLocation(FEnvQueryInstance queryInstance, int itemIndex)
			=> E_UEnvQueryTest_GetItemLocation(this, queryInstance, itemIndex);
		
		
		/// <summary>
		/// helper: get location of item
		/// </summary>
		public FRotator GetItemRotation(FEnvQueryInstance queryInstance, int itemIndex)
			=> E_UEnvQueryTest_GetItemRotation(this, queryInstance, itemIndex);
		
		public bool GetWorkOnFloatValues()
			=> E_UEnvQueryTest_GetWorkOnFloatValues(this);
		
		public bool IsFiltering()
			=> E_UEnvQueryTest_IsFiltering(this);
		
		public bool IsScoring()
			=> E_UEnvQueryTest_IsScoring(this);
		
		
		/// <summary>
		/// normalize scores in range
		/// </summary>
		public void NormalizeItemScores(FEnvQueryInstance queryInstance)
			=> E_UEnvQueryTest_NormalizeItemScores(this, queryInstance);
		
		
		/// <summary>
		/// Function that does the actual work
		/// </summary>
		public virtual void RunTest(FEnvQueryInstance queryInstance)
			=> E_UEnvQueryTest_RunTest(this, queryInstance);
		
		
		/// <summary>
		/// samples of scoring function to show on graph in editor
		/// </summary>
		public void SetWorkOnFloatValues(bool bWorkOnFloats)
			=> E_UEnvQueryTest_SetWorkOnFloatValues(this, bWorkOnFloats);
		
		
		/// <summary>
		/// update preview list
		/// </summary>
		public void UpdatePreviewData()
			=> E_UEnvQueryTest_UpdatePreviewData(this);
		
		#endregion
		
		public static implicit operator IntPtr(UEnvQueryTest self)
		{
			return self?.NativePointer ?? IntPtr.Zero;
		}

		public static implicit operator UEnvQueryTest(ObjectPointerDescription PtrDesc)
		{
			return NativeManager.GetWrapper<UEnvQueryTest>(PtrDesc);
		}}}
