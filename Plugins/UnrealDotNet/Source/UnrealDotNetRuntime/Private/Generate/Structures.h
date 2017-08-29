#pragma once

#include "CoreMinimal.h"
#include "Engine.h"
#include "Engine/World.h"
#include "Math/Quat.h"
#include "Math/Rotator.h"
#include "Math/TransformVectorized.h"
#include "Math/Vector.h"
#include "Math/Vector2D.h"
#include "Math/Vector4.h"
#include "GameFramework/Character.h"
#include "Math/Box.h"
#include "Math/Box2D.h"

extern "C"
{
	
	/*	FClassRedirect	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FClassRedirect() { return (INT_PTR) new FClassRedirect(); }
	
	DOTNET_EXPORT bool E_Struct_FClassRedirect_InstanceOnly_GET(INT_PTR Ptr) { return ((FClassRedirect*)Ptr)->InstanceOnly; }
	DOTNET_EXPORT void E_Struct_FClassRedirect_InstanceOnly_SET(INT_PTR Ptr, bool Value) { ((FClassRedirect*)Ptr)->InstanceOnly = Value; }
	
	
	/*	FFullyLoadedPackagesInfo	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FFullyLoadedPackagesInfo() { return (INT_PTR) new FFullyLoadedPackagesInfo(); }
	
	
	/*	FGameNameRedirect	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FGameNameRedirect() { return (INT_PTR) new FGameNameRedirect(); }
	
	
	/*	FLevelStreamingGCHelper	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FLevelStreamingGCHelper() { return (INT_PTR) new FLevelStreamingGCHelper(); }
	
	DOTNET_EXPORT void E_FLevelStreamingGCHelper_AddGarbageCollectorCallback(INT_PTR Self)
	{
		((FLevelStreamingGCHelper*)Self)->AddGarbageCollectorCallback();
	}

	DOTNET_EXPORT int32 E_FLevelStreamingGCHelper_GetNumLevelsPendingPurge(INT_PTR Self)
	{
		return ((FLevelStreamingGCHelper*)Self)->GetNumLevelsPendingPurge();
	}

	
	/*	FLevelStreamingStatus	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FLevelStreamingStatus() { return (INT_PTR) new FLevelStreamingStatus(); }
	
	
	/*	FNamedNetDriver	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FNamedNetDriver() { return (INT_PTR) new FNamedNetDriver(); }
	
	
	/*	FNetDriverDefinition	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FNetDriverDefinition() { return (INT_PTR) new FNetDriverDefinition(); }
	
	
	/*	FPluginRedirect	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FPluginRedirect() { return (INT_PTR) new FPluginRedirect(); }
	
	
	/*	FQuat	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FQuat() { return (INT_PTR) new FQuat(); }
	
	DOTNET_EXPORT float E_Struct_FQuat_X_GET(INT_PTR Ptr) { return ((FQuat*)Ptr)->X; }
	DOTNET_EXPORT void E_Struct_FQuat_X_SET(INT_PTR Ptr, float Value) { ((FQuat*)Ptr)->X = Value; }
	
	DOTNET_EXPORT float E_Struct_FQuat_Y_GET(INT_PTR Ptr) { return ((FQuat*)Ptr)->Y; }
	DOTNET_EXPORT void E_Struct_FQuat_Y_SET(INT_PTR Ptr, float Value) { ((FQuat*)Ptr)->Y = Value; }
	
	DOTNET_EXPORT float E_Struct_FQuat_Z_GET(INT_PTR Ptr) { return ((FQuat*)Ptr)->Z; }
	DOTNET_EXPORT void E_Struct_FQuat_Z_SET(INT_PTR Ptr, float Value) { ((FQuat*)Ptr)->Z = Value; }
	
	DOTNET_EXPORT float E_Struct_FQuat_W_GET(INT_PTR Ptr) { return ((FQuat*)Ptr)->W; }
	DOTNET_EXPORT void E_Struct_FQuat_W_SET(INT_PTR Ptr, float Value) { ((FQuat*)Ptr)->W = Value; }
	
	DOTNET_EXPORT INT_PTR E_OPER_FQuat_p(INT_PTR Self, INT_PTR Q)
	{
		auto _p0 = *(FQuat*)Q;
		return (INT_PTR) new FQuat(((FQuat*)Self)->operator+(_p0));
	}

	DOTNET_EXPORT bool E_FQuat_Equals(INT_PTR Self, INT_PTR Q, float Tolerance)
	{
		auto _p0 = *(FQuat*)Q;
		auto _p1 = Tolerance;
		return ((FQuat*)Self)->Equals(_p0, _p1);
	}

	DOTNET_EXPORT bool E_FQuat_IsIdentity(INT_PTR Self, float Tolerance)
	{
		auto _p0 = Tolerance;
		return ((FQuat*)Self)->IsIdentity(_p0);
	}

	DOTNET_EXPORT float E_OPER_FQuat_i(INT_PTR Self, INT_PTR Q)
	{
		auto _p0 = *(FQuat*)Q;
		return ((FQuat*)Self)->operator|(_p0);
	}

	DOTNET_EXPORT INT_PTR E_FQuat_MakeFromEuler(INT_PTR Self, INT_PTR Euler)
	{
		auto _p0 = *(FVector*)Euler;
		return (INT_PTR) new FQuat(((FQuat*)Self)->MakeFromEuler(_p0));
	}

	DOTNET_EXPORT INT_PTR E_FQuat_Euler(INT_PTR Self)
	{
		return (INT_PTR) new FVector(((FQuat*)Self)->Euler());
	}

	DOTNET_EXPORT void E_FQuat_Normalize(INT_PTR Self, float Tolerance)
	{
		auto _p0 = Tolerance;
		((FQuat*)Self)->Normalize(_p0);
	}

	DOTNET_EXPORT INT_PTR E_FQuat_GetNormalized(INT_PTR Self, float Tolerance)
	{
		auto _p0 = Tolerance;
		return (INT_PTR) new FQuat(((FQuat*)Self)->GetNormalized(_p0));
	}

	DOTNET_EXPORT bool E_FQuat_IsNormalized(INT_PTR Self)
	{
		return ((FQuat*)Self)->IsNormalized();
	}

	DOTNET_EXPORT float E_FQuat_Size(INT_PTR Self)
	{
		return ((FQuat*)Self)->Size();
	}

	DOTNET_EXPORT void E_FQuat_ToAxisAndAngle(INT_PTR Self, INT_PTR Axis, float Angle)
	{
		auto _p0 = *(FVector*)Axis;
		auto _p1 = Angle;
		((FQuat*)Self)->ToAxisAndAngle(_p0, _p1);
	}

	DOTNET_EXPORT void E_FQuat_ToSwingTwist(INT_PTR Self, INT_PTR InTwistAxis, INT_PTR OutSwing, INT_PTR OutTwist)
	{
		auto _p0 = *(FVector*)InTwistAxis;
		auto _p1 = *(FQuat*)OutSwing;
		auto _p2 = *(FQuat*)OutTwist;
		((FQuat*)Self)->ToSwingTwist(_p0, _p1, _p2);
	}

	DOTNET_EXPORT INT_PTR E_FQuat_RotateVector(INT_PTR Self, INT_PTR V)
	{
		auto _p0 = *(FVector*)V;
		return (INT_PTR) new FVector(((FQuat*)Self)->RotateVector(_p0));
	}

	DOTNET_EXPORT INT_PTR E_FQuat_Log(INT_PTR Self)
	{
		return (INT_PTR) new FQuat(((FQuat*)Self)->Log());
	}

	DOTNET_EXPORT void E_FQuat_EnforceShortestArcWith(INT_PTR Self, INT_PTR OtherQuat)
	{
		auto _p0 = *(FQuat*)OtherQuat;
		((FQuat*)Self)->EnforceShortestArcWith(_p0);
	}

	DOTNET_EXPORT INT_PTR E_FQuat_Rotator(INT_PTR Self)
	{
		return (INT_PTR) new FRotator(((FQuat*)Self)->Rotator());
	}

	DOTNET_EXPORT INT_PTR E_FQuat_FindBetween(INT_PTR Self, INT_PTR Vector1, INT_PTR Vector2)
	{
		auto _p0 = *(FVector*)Vector1;
		auto _p1 = *(FVector*)Vector2;
		return (INT_PTR) new FQuat(((FQuat*)Self)->FindBetween(_p0, _p1));
	}

	DOTNET_EXPORT float E_FQuat_Error(INT_PTR Self, INT_PTR Q1, INT_PTR Q2)
	{
		auto _p0 = *(FQuat*)Q1;
		auto _p1 = *(FQuat*)Q2;
		return ((FQuat*)Self)->Error(_p0, _p1);
	}

	DOTNET_EXPORT INT_PTR E_FQuat_FastLerp(INT_PTR Self, INT_PTR A, INT_PTR B, float Alpha)
	{
		auto _p0 = *(FQuat*)A;
		auto _p1 = *(FQuat*)B;
		auto _p2 = Alpha;
		return (INT_PTR) new FQuat(((FQuat*)Self)->FastLerp(_p0, _p1, _p2));
	}

	DOTNET_EXPORT INT_PTR E_FQuat_FastBilerp(INT_PTR Self, INT_PTR P00, INT_PTR P10, INT_PTR P01, INT_PTR P11, float FracX, float FracY)
	{
		auto _p0 = *(FQuat*)P00;
		auto _p1 = *(FQuat*)P10;
		auto _p2 = *(FQuat*)P01;
		auto _p3 = *(FQuat*)P11;
		auto _p4 = FracX;
		auto _p5 = FracY;
		return (INT_PTR) new FQuat(((FQuat*)Self)->FastBilerp(_p0, _p1, _p2, _p3, _p4, _p5));
	}

	DOTNET_EXPORT INT_PTR E_FQuat_Slerp_NotNormalized(INT_PTR Self, INT_PTR Quat1, INT_PTR Quat2, float Slerp)
	{
		auto _p0 = *(FQuat*)Quat1;
		auto _p1 = *(FQuat*)Quat2;
		auto _p2 = Slerp;
		return (INT_PTR) new FQuat(((FQuat*)Self)->Slerp_NotNormalized(_p0, _p1, _p2));
	}

	DOTNET_EXPORT INT_PTR E_FQuat_Squad(INT_PTR Self, INT_PTR quat1, INT_PTR tang1, INT_PTR quat2, INT_PTR tang2, float Alpha)
	{
		auto _p0 = *(FQuat*)quat1;
		auto _p1 = *(FQuat*)tang1;
		auto _p2 = *(FQuat*)quat2;
		auto _p3 = *(FQuat*)tang2;
		auto _p4 = Alpha;
		return (INT_PTR) new FQuat(((FQuat*)Self)->Squad(_p0, _p1, _p2, _p3, _p4));
	}

	DOTNET_EXPORT void E_FQuat_CalcTangents(INT_PTR Self, INT_PTR PrevP, INT_PTR P, INT_PTR NextP, float Tension, INT_PTR OutTan)
	{
		auto _p0 = *(FQuat*)PrevP;
		auto _p1 = *(FQuat*)P;
		auto _p2 = *(FQuat*)NextP;
		auto _p3 = Tension;
		auto _p4 = *(FQuat*)OutTan;
		((FQuat*)Self)->CalcTangents(_p0, _p1, _p2, _p3, _p4);
	}

	
	/*	FRotator	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FRotator() { return (INT_PTR) new FRotator(); }
	
	DOTNET_EXPORT float E_Struct_FRotator_Pitch_GET(INT_PTR Ptr) { return ((FRotator*)Ptr)->Pitch; }
	DOTNET_EXPORT void E_Struct_FRotator_Pitch_SET(INT_PTR Ptr, float Value) { ((FRotator*)Ptr)->Pitch = Value; }
	
	DOTNET_EXPORT float E_Struct_FRotator_Yaw_GET(INT_PTR Ptr) { return ((FRotator*)Ptr)->Yaw; }
	DOTNET_EXPORT void E_Struct_FRotator_Yaw_SET(INT_PTR Ptr, float Value) { ((FRotator*)Ptr)->Yaw = Value; }
	
	DOTNET_EXPORT float E_Struct_FRotator_Roll_GET(INT_PTR Ptr) { return ((FRotator*)Ptr)->Roll; }
	DOTNET_EXPORT void E_Struct_FRotator_Roll_SET(INT_PTR Ptr, float Value) { ((FRotator*)Ptr)->Roll = Value; }
	
	DOTNET_EXPORT INT_PTR E_OPER_FRotator_p(INT_PTR Self, INT_PTR R)
	{
		auto _p0 = *(FRotator*)R;
		return (INT_PTR) new FRotator(((FRotator*)Self)->operator+(_p0));
	}

	DOTNET_EXPORT INT_PTR E_OPER_FRotator_m(INT_PTR Self, float Scale)
	{
		auto _p0 = Scale;
		return (INT_PTR) new FRotator(((FRotator*)Self)->operator*(_p0));
	}

	DOTNET_EXPORT bool E_FRotator_IsNearlyZero(INT_PTR Self, float Tolerance)
	{
		auto _p0 = Tolerance;
		return ((FRotator*)Self)->IsNearlyZero(_p0);
	}

	DOTNET_EXPORT bool E_FRotator_IsZero(INT_PTR Self)
	{
		return ((FRotator*)Self)->IsZero();
	}

	DOTNET_EXPORT bool E_FRotator_Equals(INT_PTR Self, INT_PTR R, float Tolerance)
	{
		auto _p0 = *(FRotator*)R;
		auto _p1 = Tolerance;
		return ((FRotator*)Self)->Equals(_p0, _p1);
	}

	DOTNET_EXPORT INT_PTR E_FRotator_Add(INT_PTR Self, float DeltaPitch, float DeltaYaw, float DeltaRoll)
	{
		auto _p0 = DeltaPitch;
		auto _p1 = DeltaYaw;
		auto _p2 = DeltaRoll;
		return (INT_PTR) new FRotator(((FRotator*)Self)->Add(_p0, _p1, _p2));
	}

	DOTNET_EXPORT INT_PTR E_FRotator_Vector(INT_PTR Self)
	{
		return (INT_PTR) new FVector(((FRotator*)Self)->Vector());
	}

	DOTNET_EXPORT INT_PTR E_FRotator_Quaternion(INT_PTR Self)
	{
		return (INT_PTR) new FQuat(((FRotator*)Self)->Quaternion());
	}

	DOTNET_EXPORT INT_PTR E_FRotator_RotateVector(INT_PTR Self, INT_PTR V)
	{
		auto _p0 = *(FVector*)V;
		return (INT_PTR) new FVector(((FRotator*)Self)->RotateVector(_p0));
	}

	DOTNET_EXPORT void E_FRotator_Normalize(INT_PTR Self)
	{
		((FRotator*)Self)->Normalize();
	}

	DOTNET_EXPORT void E_FRotator_GetWindingAndRemainder(INT_PTR Self, INT_PTR Winding, INT_PTR Remainder)
	{
		auto _p0 = *(FRotator*)Winding;
		auto _p1 = *(FRotator*)Remainder;
		((FRotator*)Self)->GetWindingAndRemainder(_p0, _p1);
	}

	DOTNET_EXPORT float E_FRotator_ClampAxis(INT_PTR Self, float Angle)
	{
		auto _p0 = Angle;
		return ((FRotator*)Self)->ClampAxis(_p0);
	}

	DOTNET_EXPORT uint8 E_FRotator_CompressAxisToByte(INT_PTR Self, float Angle)
	{
		auto _p0 = Angle;
		return ((FRotator*)Self)->CompressAxisToByte(_p0);
	}

	DOTNET_EXPORT INT_PTR E_FRotator_MakeFromEuler(INT_PTR Self, INT_PTR Euler)
	{
		auto _p0 = *(FVector*)Euler;
		return (INT_PTR) new FRotator(((FRotator*)Self)->MakeFromEuler(_p0));
	}

	
	/*	FStatColorMapEntry	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FStatColorMapEntry() { return (INT_PTR) new FStatColorMapEntry(); }
	
	DOTNET_EXPORT float E_Struct_FStatColorMapEntry_In_GET(INT_PTR Ptr) { return ((FStatColorMapEntry*)Ptr)->In; }
	DOTNET_EXPORT void E_Struct_FStatColorMapEntry_In_SET(INT_PTR Ptr, float Value) { ((FStatColorMapEntry*)Ptr)->In = Value; }
	
	
	/*	FStatColorMapping	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FStatColorMapping() { return (INT_PTR) new FStatColorMapping(); }
	
	
	/*	FStructRedirect	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FStructRedirect() { return (INT_PTR) new FStructRedirect(); }
	
	
	/*	FTransform	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FTransform() { return (INT_PTR) new FTransform(); }
	
	DOTNET_EXPORT void E_FTransform_DiagnosticCheckNaN_Scale3D(INT_PTR Self)
	{
		((FTransform*)Self)->DiagnosticCheckNaN_Scale3D();
	}

	DOTNET_EXPORT INT_PTR E_FTransform_Inverse(INT_PTR Self)
	{
		return (INT_PTR) new FTransform(((FTransform*)Self)->Inverse());
	}

	DOTNET_EXPORT void E_FTransform_Blend(INT_PTR Self, INT_PTR Atom1, INT_PTR Atom2, float Alpha)
	{
		auto _p0 = *(FTransform*)Atom1;
		auto _p1 = *(FTransform*)Atom2;
		auto _p2 = Alpha;
		((FTransform*)Self)->Blend(_p0, _p1, _p2);
	}

	DOTNET_EXPORT void E_FTransform_BlendWith(INT_PTR Self, INT_PTR OtherAtom, float Alpha)
	{
		auto _p0 = *(FTransform*)OtherAtom;
		auto _p1 = Alpha;
		((FTransform*)Self)->BlendWith(_p0, _p1);
	}

	DOTNET_EXPORT INT_PTR E_OPER_FTransform_p(INT_PTR Self, INT_PTR Atom)
	{
		auto _p0 = *(FTransform*)Atom;
		return (INT_PTR) new FTransform(((FTransform*)Self)->operator+(_p0));
	}

	DOTNET_EXPORT bool E_FTransform_AnyHasNegativeScale(INT_PTR Self, INT_PTR InScale3D, INT_PTR InOtherScale3D)
	{
		auto _p0 = *(FVector*)InScale3D;
		auto _p1 = *(FVector*)InOtherScale3D;
		return ((FTransform*)Self)->AnyHasNegativeScale(_p0, _p1);
	}

	DOTNET_EXPORT void E_FTransform_RemoveScaling(INT_PTR Self, float Tolerance)
	{
		auto _p0 = Tolerance;
		((FTransform*)Self)->RemoveScaling(_p0);
	}

	DOTNET_EXPORT float E_FTransform_GetMaximumAxisScale(INT_PTR Self)
	{
		return ((FTransform*)Self)->GetMaximumAxisScale();
	}

	DOTNET_EXPORT INT_PTR E_FTransform_TransformFVector4(INT_PTR Self, INT_PTR V)
	{
		auto _p0 = *(FVector4*)V;
		return (INT_PTR) new FVector4(((FTransform*)Self)->TransformFVector4(_p0));
	}

	DOTNET_EXPORT INT_PTR E_FTransform_TransformPosition(INT_PTR Self, INT_PTR V)
	{
		auto _p0 = *(FVector*)V;
		return (INT_PTR) new FVector(((FTransform*)Self)->TransformPosition(_p0));
	}

	DOTNET_EXPORT INT_PTR E_FTransform_GetSafeScaleReciprocal(INT_PTR Self, INT_PTR InScale, float Tolerance)
	{
		auto _p0 = *(FVector*)InScale;
		auto _p1 = Tolerance;
		return (INT_PTR) new FVector(((FTransform*)Self)->GetSafeScaleReciprocal(_p0, _p1));
	}

	DOTNET_EXPORT INT_PTR E_FTransform_GetLocation(INT_PTR Self)
	{
		return (INT_PTR) new FVector(((FTransform*)Self)->GetLocation());
	}

	DOTNET_EXPORT INT_PTR E_FTransform_Rotator(INT_PTR Self)
	{
		return (INT_PTR) new FRotator(((FTransform*)Self)->Rotator());
	}

	DOTNET_EXPORT bool E_FTransform_ContainsNaN(INT_PTR Self)
	{
		return ((FTransform*)Self)->ContainsNaN();
	}

	DOTNET_EXPORT bool E_FTransform_AreRotationsEqual(INT_PTR Self, INT_PTR A, INT_PTR B, float Tolerance)
	{
		auto _p0 = *(FTransform*)A;
		auto _p1 = *(FTransform*)B;
		auto _p2 = Tolerance;
		return ((FTransform*)Self)->AreRotationsEqual(_p0, _p1, _p2);
	}

	DOTNET_EXPORT bool E_FTransform_RotationEquals(INT_PTR Self, INT_PTR Other, float Tolerance)
	{
		auto _p0 = *(FTransform*)Other;
		auto _p1 = Tolerance;
		return ((FTransform*)Self)->RotationEquals(_p0, _p1);
	}

	DOTNET_EXPORT void E_FTransform_Multiply(INT_PTR Self, INT_PTR OutTransform, INT_PTR A, INT_PTR B)
	{
		auto _p0 = *(FTransform*)OutTransform;
		auto _p1 = *(FTransform*)A;
		auto _p2 = *(FTransform*)B;
		((FTransform*)Self)->Multiply(&_p0, &_p1, &_p2);
	}

	DOTNET_EXPORT void E_FTransform_SetComponents(INT_PTR Self, INT_PTR InRotation, INT_PTR InTranslation, INT_PTR InScale3D)
	{
		auto _p0 = *(FQuat*)InRotation;
		auto _p1 = *(FVector*)InTranslation;
		auto _p2 = *(FVector*)InScale3D;
		((FTransform*)Self)->SetComponents(_p0, _p1, _p2);
	}

	DOTNET_EXPORT void E_FTransform_SetIdentity(INT_PTR Self)
	{
		((FTransform*)Self)->SetIdentity();
	}

	DOTNET_EXPORT INT_PTR E_FTransform_AddTranslations(INT_PTR Self, INT_PTR A, INT_PTR B)
	{
		auto _p0 = *(FTransform*)A;
		auto _p1 = *(FTransform*)B;
		return (INT_PTR) new FVector(((FTransform*)Self)->AddTranslations(_p0, _p1));
	}

	DOTNET_EXPORT void E_FTransform_SetTranslationAndScale3D(INT_PTR Self, INT_PTR NewTranslation, INT_PTR NewScale3D)
	{
		auto _p0 = *(FVector*)NewTranslation;
		auto _p1 = *(FVector*)NewScale3D;
		((FTransform*)Self)->SetTranslationAndScale3D(_p0, _p1);
	}

	DOTNET_EXPORT INT_PTR E_FTransform_GetRotation(INT_PTR Self)
	{
		return (INT_PTR) new FQuat(((FTransform*)Self)->GetRotation());
	}

	
	/*	FVector	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FVector() { return (INT_PTR) new FVector(); }
	
	DOTNET_EXPORT float E_Struct_FVector_X_GET(INT_PTR Ptr) { return ((FVector*)Ptr)->X; }
	DOTNET_EXPORT void E_Struct_FVector_X_SET(INT_PTR Ptr, float Value) { ((FVector*)Ptr)->X = Value; }
	
	DOTNET_EXPORT float E_Struct_FVector_Y_GET(INT_PTR Ptr) { return ((FVector*)Ptr)->Y; }
	DOTNET_EXPORT void E_Struct_FVector_Y_SET(INT_PTR Ptr, float Value) { ((FVector*)Ptr)->Y = Value; }
	
	DOTNET_EXPORT float E_Struct_FVector_Z_GET(INT_PTR Ptr) { return ((FVector*)Ptr)->Z; }
	DOTNET_EXPORT void E_Struct_FVector_Z_SET(INT_PTR Ptr, float Value) { ((FVector*)Ptr)->Z = Value; }
	
	DOTNET_EXPORT INT_PTR E_OPER_FVector_u(INT_PTR Self, INT_PTR V)
	{
		auto _p0 = *(FVector*)V;
		return (INT_PTR) new FVector(((FVector*)Self)->operator^(_p0));
	}

	DOTNET_EXPORT INT_PTR E_FVector_CrossProduct(INT_PTR Self, INT_PTR A, INT_PTR B)
	{
		auto _p0 = *(FVector*)A;
		auto _p1 = *(FVector*)B;
		return (INT_PTR) new FVector(((FVector*)Self)->CrossProduct(_p0, _p1));
	}

	DOTNET_EXPORT float E_OPER_FVector_i(INT_PTR Self, INT_PTR V)
	{
		auto _p0 = *(FVector*)V;
		return ((FVector*)Self)->operator|(_p0);
	}

	DOTNET_EXPORT float E_FVector_DotProduct(INT_PTR Self, INT_PTR A, INT_PTR B)
	{
		auto _p0 = *(FVector*)A;
		auto _p1 = *(FVector*)B;
		return ((FVector*)Self)->DotProduct(_p0, _p1);
	}

	DOTNET_EXPORT bool E_FVector_Equals(INT_PTR Self, INT_PTR V, float Tolerance)
	{
		auto _p0 = *(FVector*)V;
		auto _p1 = Tolerance;
		return ((FVector*)Self)->Equals(_p0, _p1);
	}

	DOTNET_EXPORT bool E_FVector_AllComponentsEqual(INT_PTR Self, float Tolerance)
	{
		auto _p0 = Tolerance;
		return ((FVector*)Self)->AllComponentsEqual(_p0);
	}

	DOTNET_EXPORT void E_FVector_Set(INT_PTR Self, float InX, float InY, float InZ)
	{
		auto _p0 = InX;
		auto _p1 = InY;
		auto _p2 = InZ;
		((FVector*)Self)->Set(_p0, _p1, _p2);
	}

	DOTNET_EXPORT float E_FVector_GetMax(INT_PTR Self)
	{
		return ((FVector*)Self)->GetMax();
	}

	DOTNET_EXPORT bool E_FVector_IsZero(INT_PTR Self)
	{
		return ((FVector*)Self)->IsZero();
	}

	DOTNET_EXPORT bool E_FVector_Normalize(INT_PTR Self, float Tolerance)
	{
		auto _p0 = Tolerance;
		return ((FVector*)Self)->Normalize(_p0);
	}

	DOTNET_EXPORT void E_FVector_ToDirectionAndLength(INT_PTR Self, INT_PTR OutDir, float OutLength)
	{
		auto _p0 = *(FVector*)OutDir;
		auto _p1 = OutLength;
		((FVector*)Self)->ToDirectionAndLength(_p0, _p1);
	}

	DOTNET_EXPORT INT_PTR E_FVector_GridSnap(INT_PTR Self, float GridSz)
	{
		auto _p0 = GridSz;
		return (INT_PTR) new FVector(((FVector*)Self)->GridSnap(_p0));
	}

	DOTNET_EXPORT INT_PTR E_FVector_GetClampedToSize(INT_PTR Self, float Min, float Max)
	{
		auto _p0 = Min;
		auto _p1 = Max;
		return (INT_PTR) new FVector(((FVector*)Self)->GetClampedToSize(_p0, _p1));
	}

	DOTNET_EXPORT void E_FVector_AddBounded(INT_PTR Self, INT_PTR V, float Radius)
	{
		auto _p0 = *(FVector*)V;
		auto _p1 = Radius;
		((FVector*)Self)->AddBounded(_p0, _p1);
	}

	DOTNET_EXPORT INT_PTR E_FVector_RotateAngleAxis(INT_PTR Self, float AngleDeg, INT_PTR Axis)
	{
		auto _p0 = AngleDeg;
		auto _p1 = *(FVector*)Axis;
		return (INT_PTR) new FVector(((FVector*)Self)->RotateAngleAxis(_p0, _p1));
	}

	DOTNET_EXPORT float E_FVector_CosineAngle2D(INT_PTR Self, INT_PTR B)
	{
		auto _p0 = *(FVector*)B;
		return ((FVector*)Self)->CosineAngle2D(_p0);
	}

	DOTNET_EXPORT INT_PTR E_FVector_ToOrientationRotator(INT_PTR Self)
	{
		return (INT_PTR) new FRotator(((FVector*)Self)->ToOrientationRotator());
	}

	DOTNET_EXPORT INT_PTR E_FVector_ToOrientationQuat(INT_PTR Self)
	{
		return (INT_PTR) new FQuat(((FVector*)Self)->ToOrientationQuat());
	}

	DOTNET_EXPORT void E_FVector_FindBestAxisVectors(INT_PTR Self, INT_PTR Axis1, INT_PTR Axis2)
	{
		auto _p0 = *(FVector*)Axis1;
		auto _p1 = *(FVector*)Axis2;
		((FVector*)Self)->FindBestAxisVectors(_p0, _p1);
	}

	DOTNET_EXPORT void E_FVector_UnwindEuler(INT_PTR Self)
	{
		((FVector*)Self)->UnwindEuler();
	}

	DOTNET_EXPORT INT_PTR E_FVector_UnitCartesianToSpherical(INT_PTR Self)
	{
		return (INT_PTR) new FVector2D(((FVector*)Self)->UnitCartesianToSpherical());
	}

	DOTNET_EXPORT void E_FVector_CreateOrthonormalBasis(INT_PTR Self, INT_PTR XAxis, INT_PTR YAxis, INT_PTR ZAxis)
	{
		auto _p0 = *(FVector*)XAxis;
		auto _p1 = *(FVector*)YAxis;
		auto _p2 = *(FVector*)ZAxis;
		((FVector*)Self)->CreateOrthonormalBasis(_p0, _p1, _p2);
	}

	DOTNET_EXPORT bool E_FVector_PointsAreSame(INT_PTR Self, INT_PTR P, INT_PTR Q)
	{
		auto _p0 = *(FVector*)P;
		auto _p1 = *(FVector*)Q;
		return ((FVector*)Self)->PointsAreSame(_p0, _p1);
	}

	DOTNET_EXPORT bool E_FVector_PointsAreNear(INT_PTR Self, INT_PTR Point1, INT_PTR Point2, float Dist)
	{
		auto _p0 = *(FVector*)Point1;
		auto _p1 = *(FVector*)Point2;
		auto _p2 = Dist;
		return ((FVector*)Self)->PointsAreNear(_p0, _p1, _p2);
	}

	DOTNET_EXPORT float E_FVector_PointPlaneDist(INT_PTR Self, INT_PTR Point, INT_PTR PlaneBase, INT_PTR PlaneNormal)
	{
		auto _p0 = *(FVector*)Point;
		auto _p1 = *(FVector*)PlaneBase;
		auto _p2 = *(FVector*)PlaneNormal;
		return ((FVector*)Self)->PointPlaneDist(_p0, _p1, _p2);
	}

	DOTNET_EXPORT bool E_FVector_Coplanar(INT_PTR Self, INT_PTR Base1, INT_PTR Normal1, INT_PTR Base2, INT_PTR Normal2, float ParallelCosineThreshold)
	{
		auto _p0 = *(FVector*)Base1;
		auto _p1 = *(FVector*)Normal1;
		auto _p2 = *(FVector*)Base2;
		auto _p3 = *(FVector*)Normal2;
		auto _p4 = ParallelCosineThreshold;
		return ((FVector*)Self)->Coplanar(_p0, _p1, _p2, _p3, _p4);
	}

	
	/*	FVector2D	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FVector2D() { return (INT_PTR) new FVector2D(); }
	
	DOTNET_EXPORT float E_Struct_FVector2D_X_GET(INT_PTR Ptr) { return ((FVector2D*)Ptr)->X; }
	DOTNET_EXPORT void E_Struct_FVector2D_X_SET(INT_PTR Ptr, float Value) { ((FVector2D*)Ptr)->X = Value; }
	
	DOTNET_EXPORT float E_Struct_FVector2D_Y_GET(INT_PTR Ptr) { return ((FVector2D*)Ptr)->Y; }
	DOTNET_EXPORT void E_Struct_FVector2D_Y_SET(INT_PTR Ptr, float Value) { ((FVector2D*)Ptr)->Y = Value; }
	
	DOTNET_EXPORT INT_PTR E_OPER_FVector2D_p(INT_PTR Self, INT_PTR V)
	{
		auto _p0 = *(FVector2D*)V;
		return (INT_PTR) new FVector2D(((FVector2D*)Self)->operator+(_p0));
	}

	DOTNET_EXPORT INT_PTR E_OPER_FVector2D_m(INT_PTR Self, float Scale)
	{
		auto _p0 = Scale;
		return (INT_PTR) new FVector2D(((FVector2D*)Self)->operator*(_p0));
	}

	DOTNET_EXPORT float E_OPER_FVector2D_i(INT_PTR Self, INT_PTR V)
	{
		auto _p0 = *(FVector2D*)V;
		return ((FVector2D*)Self)->operator|(_p0);
	}

	DOTNET_EXPORT float E_FVector2D_DotProduct(INT_PTR Self, INT_PTR A, INT_PTR B)
	{
		auto _p0 = *(FVector2D*)A;
		auto _p1 = *(FVector2D*)B;
		return ((FVector2D*)Self)->DotProduct(_p0, _p1);
	}

	DOTNET_EXPORT bool E_FVector2D_Equals(INT_PTR Self, INT_PTR V, float Tolerance)
	{
		auto _p0 = *(FVector2D*)V;
		auto _p1 = Tolerance;
		return ((FVector2D*)Self)->Equals(_p0, _p1);
	}

	DOTNET_EXPORT void E_FVector2D_Set(INT_PTR Self, float InX, float InY)
	{
		auto _p0 = InX;
		auto _p1 = InY;
		((FVector2D*)Self)->Set(_p0, _p1);
	}

	DOTNET_EXPORT float E_FVector2D_GetMax(INT_PTR Self)
	{
		return ((FVector2D*)Self)->GetMax();
	}

	DOTNET_EXPORT void E_FVector2D_Normalize(INT_PTR Self, float Tolerance)
	{
		auto _p0 = Tolerance;
		((FVector2D*)Self)->Normalize(_p0);
	}

	DOTNET_EXPORT bool E_FVector2D_IsNearlyZero(INT_PTR Self, float Tolerance)
	{
		auto _p0 = Tolerance;
		return ((FVector2D*)Self)->IsNearlyZero(_p0);
	}

	DOTNET_EXPORT void E_FVector2D_ToDirectionAndLength(INT_PTR Self, INT_PTR OutDir, float OutLength)
	{
		auto _p0 = *(FVector2D*)OutDir;
		auto _p1 = OutLength;
		((FVector2D*)Self)->ToDirectionAndLength(_p0, _p1);
	}

	DOTNET_EXPORT bool E_FVector2D_IsZero(INT_PTR Self)
	{
		return ((FVector2D*)Self)->IsZero();
	}

	DOTNET_EXPORT INT_PTR E_FVector2D_ClampAxes(INT_PTR Self, float MinAxisVal, float MaxAxisVal)
	{
		auto _p0 = MinAxisVal;
		auto _p1 = MaxAxisVal;
		return (INT_PTR) new FVector2D(((FVector2D*)Self)->ClampAxes(_p0, _p1));
	}

	DOTNET_EXPORT void E_FVector2D_DiagnosticCheckNaN(INT_PTR Self)
	{
		((FVector2D*)Self)->DiagnosticCheckNaN();
	}

	DOTNET_EXPORT INT_PTR E_FVector2D_SphericalToUnitCartesian(INT_PTR Self)
	{
		return (INT_PTR) new FVector(((FVector2D*)Self)->SphericalToUnitCartesian());
	}

	
	/*	FVector4	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FVector4() { return (INT_PTR) new FVector4(); }
	
	DOTNET_EXPORT float E_Struct_FVector4_X_GET(INT_PTR Ptr) { return ((FVector4*)Ptr)->X; }
	DOTNET_EXPORT void E_Struct_FVector4_X_SET(INT_PTR Ptr, float Value) { ((FVector4*)Ptr)->X = Value; }
	
	DOTNET_EXPORT float E_Struct_FVector4_Y_GET(INT_PTR Ptr) { return ((FVector4*)Ptr)->Y; }
	DOTNET_EXPORT void E_Struct_FVector4_Y_SET(INT_PTR Ptr, float Value) { ((FVector4*)Ptr)->Y = Value; }
	
	DOTNET_EXPORT float E_Struct_FVector4_Z_GET(INT_PTR Ptr) { return ((FVector4*)Ptr)->Z; }
	DOTNET_EXPORT void E_Struct_FVector4_Z_SET(INT_PTR Ptr, float Value) { ((FVector4*)Ptr)->Z = Value; }
	
	DOTNET_EXPORT float E_Struct_FVector4_W_GET(INT_PTR Ptr) { return ((FVector4*)Ptr)->W; }
	DOTNET_EXPORT void E_Struct_FVector4_W_SET(INT_PTR Ptr, float Value) { ((FVector4*)Ptr)->W = Value; }
	
	DOTNET_EXPORT INT_PTR E_OPER_FVector4_p(INT_PTR Self, INT_PTR V)
	{
		auto _p0 = *(FVector4*)V;
		return (INT_PTR) new FVector4(((FVector4*)Self)->operator+(_p0));
	}

	DOTNET_EXPORT bool E_FVector4_Equals(INT_PTR Self, INT_PTR V, float Tolerance)
	{
		auto _p0 = *(FVector4*)V;
		auto _p1 = Tolerance;
		return ((FVector4*)Self)->Equals(_p0, _p1);
	}

	DOTNET_EXPORT bool E_FVector4_IsUnit3(INT_PTR Self, float LengthSquaredTolerance)
	{
		auto _p0 = LengthSquaredTolerance;
		return ((FVector4*)Self)->IsUnit3(_p0);
	}

	DOTNET_EXPORT INT_PTR E_FVector4_ToOrientationRotator(INT_PTR Self)
	{
		return (INT_PTR) new FRotator(((FVector4*)Self)->ToOrientationRotator());
	}

	DOTNET_EXPORT INT_PTR E_FVector4_ToOrientationQuat(INT_PTR Self)
	{
		return (INT_PTR) new FQuat(((FVector4*)Self)->ToOrientationQuat());
	}

	DOTNET_EXPORT void E_FVector4_Set(INT_PTR Self, float InX, float InY, float InZ, float InW)
	{
		auto _p0 = InX;
		auto _p1 = InY;
		auto _p2 = InZ;
		auto _p3 = InW;
		((FVector4*)Self)->Set(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT float E_FVector4_Size3(INT_PTR Self)
	{
		return ((FVector4*)Self)->Size3();
	}

	DOTNET_EXPORT bool E_FVector4_ContainsNaN(INT_PTR Self)
	{
		return ((FVector4*)Self)->ContainsNaN();
	}

	DOTNET_EXPORT void E_FVector4_FindBestAxisVectors3(INT_PTR Self, INT_PTR Axis1, INT_PTR Axis2)
	{
		auto _p0 = *(FVector4*)Axis1;
		auto _p1 = *(FVector4*)Axis2;
		((FVector4*)Self)->FindBestAxisVectors3(_p0, _p1);
	}

	DOTNET_EXPORT void E_FVector4_DiagnosticCheckNaN(INT_PTR Self)
	{
		((FVector4*)Self)->DiagnosticCheckNaN();
	}

	
	/*	FWorldContext	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FWorldContext() { return (INT_PTR) new FWorldContext(); }
	
	DOTNET_EXPORT uint8 E_Struct_FWorldContext_TravelType_GET(INT_PTR Ptr) { return ((FWorldContext*)Ptr)->TravelType; }
	DOTNET_EXPORT void E_Struct_FWorldContext_TravelType_SET(INT_PTR Ptr, uint8 Value) { ((FWorldContext*)Ptr)->TravelType = Value; }
	
	DOTNET_EXPORT int32 E_Struct_FWorldContext_PIEInstance_GET(INT_PTR Ptr) { return ((FWorldContext*)Ptr)->PIEInstance; }
	DOTNET_EXPORT void E_Struct_FWorldContext_PIEInstance_SET(INT_PTR Ptr, int32 Value) { ((FWorldContext*)Ptr)->PIEInstance = Value; }
	
	DOTNET_EXPORT bool E_Struct_FWorldContext_RunAsDedicated_GET(INT_PTR Ptr) { return ((FWorldContext*)Ptr)->RunAsDedicated; }
	DOTNET_EXPORT void E_Struct_FWorldContext_RunAsDedicated_SET(INT_PTR Ptr, bool Value) { ((FWorldContext*)Ptr)->RunAsDedicated = Value; }
	
	DOTNET_EXPORT bool E_Struct_FWorldContext_bWaitingOnOnlineSubsystem_GET(INT_PTR Ptr) { return ((FWorldContext*)Ptr)->bWaitingOnOnlineSubsystem; }
	DOTNET_EXPORT void E_Struct_FWorldContext_bWaitingOnOnlineSubsystem_SET(INT_PTR Ptr, bool Value) { ((FWorldContext*)Ptr)->bWaitingOnOnlineSubsystem = Value; }
	
	DOTNET_EXPORT void E_FWorldContext_SetCurrentWorld(INT_PTR Self, UWorld* World)
	{
		auto _p0 = World;
		((FWorldContext*)Self)->SetCurrentWorld(_p0);
	}

	DOTNET_EXPORT UWorld* E_FWorldContext_World(INT_PTR Self)
	{
		return ((FWorldContext*)Self)->World();
	}

	
	/*	FBasedMovementInfo	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FBasedMovementInfo() { return (INT_PTR) new FBasedMovementInfo(); }
	
	DOTNET_EXPORT INT_PTR E_Struct_FBasedMovementInfo_Rotation_GET(INT_PTR Ptr) { return (INT_PTR) new FRotator(((FBasedMovementInfo*)Ptr)->Rotation); }
	DOTNET_EXPORT void E_Struct_FBasedMovementInfo_Rotation_SET(INT_PTR Ptr, INT_PTR Value) { ((FBasedMovementInfo*)Ptr)->Rotation = *(FRotator*)Value; }
	
	DOTNET_EXPORT bool E_Struct_FBasedMovementInfo_bServerHasBaseComponent_GET(INT_PTR Ptr) { return ((FBasedMovementInfo*)Ptr)->bServerHasBaseComponent; }
	DOTNET_EXPORT void E_Struct_FBasedMovementInfo_bServerHasBaseComponent_SET(INT_PTR Ptr, bool Value) { ((FBasedMovementInfo*)Ptr)->bServerHasBaseComponent = Value; }
	
	DOTNET_EXPORT bool E_Struct_FBasedMovementInfo_bRelativeRotation_GET(INT_PTR Ptr) { return ((FBasedMovementInfo*)Ptr)->bRelativeRotation; }
	DOTNET_EXPORT void E_Struct_FBasedMovementInfo_bRelativeRotation_SET(INT_PTR Ptr, bool Value) { ((FBasedMovementInfo*)Ptr)->bRelativeRotation = Value; }
	
	DOTNET_EXPORT bool E_Struct_FBasedMovementInfo_bServerHasVelocity_GET(INT_PTR Ptr) { return ((FBasedMovementInfo*)Ptr)->bServerHasVelocity; }
	DOTNET_EXPORT void E_Struct_FBasedMovementInfo_bServerHasVelocity_SET(INT_PTR Ptr, bool Value) { ((FBasedMovementInfo*)Ptr)->bServerHasVelocity = Value; }
	
	DOTNET_EXPORT bool E_FBasedMovementInfo_HasRelativeLocation(INT_PTR Self)
	{
		return ((FBasedMovementInfo*)Self)->HasRelativeLocation();
	}

	
	/*	FBox	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FBox() { return (INT_PTR) new FBox(); }
	
	DOTNET_EXPORT INT_PTR E_Struct_FBox_Min_GET(INT_PTR Ptr) { return (INT_PTR) new FVector(((FBox*)Ptr)->Min); }
	DOTNET_EXPORT void E_Struct_FBox_Min_SET(INT_PTR Ptr, INT_PTR Value) { ((FBox*)Ptr)->Min = *(FVector*)Value; }
	
	DOTNET_EXPORT INT_PTR E_Struct_FBox_Max_GET(INT_PTR Ptr) { return (INT_PTR) new FVector(((FBox*)Ptr)->Max); }
	DOTNET_EXPORT void E_Struct_FBox_Max_SET(INT_PTR Ptr, INT_PTR Value) { ((FBox*)Ptr)->Max = *(FVector*)Value; }
	
	DOTNET_EXPORT uint8 E_Struct_FBox_IsValid_GET(INT_PTR Ptr) { return ((FBox*)Ptr)->IsValid; }
	DOTNET_EXPORT void E_Struct_FBox_IsValid_SET(INT_PTR Ptr, uint8 Value) { ((FBox*)Ptr)->IsValid = Value; }
	
	DOTNET_EXPORT INT_PTR E_OPER_FBox_oc(INT_PTR Self, int32 Index)
	{
		auto _p0 = Index;
		return (INT_PTR) new FVector(((FBox*)Self)->operator[](_p0));
	}

	DOTNET_EXPORT float E_FBox_ComputeSquaredDistanceToPoint(INT_PTR Self, INT_PTR Point)
	{
		auto _p0 = *(FVector*)Point;
		return ((FBox*)Self)->ComputeSquaredDistanceToPoint(_p0);
	}

	DOTNET_EXPORT INT_PTR E_FBox_GetCenter(INT_PTR Self)
	{
		return (INT_PTR) new FVector(((FBox*)Self)->GetCenter());
	}

	DOTNET_EXPORT void E_FBox_GetCenterAndExtents(INT_PTR Self, INT_PTR center, INT_PTR Extents)
	{
		auto _p0 = *(FVector*)center;
		auto _p1 = *(FVector*)Extents;
		((FBox*)Self)->GetCenterAndExtents(_p0, _p1);
	}

	DOTNET_EXPORT INT_PTR E_FBox_GetClosestPointTo(INT_PTR Self, INT_PTR Point)
	{
		auto _p0 = *(FVector*)Point;
		return (INT_PTR) new FVector(((FBox*)Self)->GetClosestPointTo(_p0));
	}

	DOTNET_EXPORT float E_FBox_GetVolume(INT_PTR Self)
	{
		return ((FBox*)Self)->GetVolume();
	}

	DOTNET_EXPORT void E_FBox_Init(INT_PTR Self)
	{
		((FBox*)Self)->Init();
	}

	DOTNET_EXPORT INT_PTR E_FBox_InverseTransformBy(INT_PTR Self, INT_PTR M)
	{
		auto _p0 = *(FTransform*)M;
		return (INT_PTR) new FBox(((FBox*)Self)->InverseTransformBy(_p0));
	}

	DOTNET_EXPORT bool E_FBox_IsInside(INT_PTR Self, INT_PTR In)
	{
		auto _p0 = *(FVector*)In;
		return ((FBox*)Self)->IsInside(_p0);
	}

	DOTNET_EXPORT INT_PTR E_FBox_BuildAABB(INT_PTR Self, INT_PTR Origin, INT_PTR Extent)
	{
		auto _p0 = *(FVector*)Origin;
		auto _p1 = *(FVector*)Extent;
		return (INT_PTR) new FBox(((FBox*)Self)->BuildAABB(_p0, _p1));
	}

	
	/*	FBox2D	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FBox2D() { return (INT_PTR) new FBox2D(); }
	
	DOTNET_EXPORT INT_PTR E_Struct_FBox2D_Min_GET(INT_PTR Ptr) { return (INT_PTR) new FVector2D(((FBox2D*)Ptr)->Min); }
	DOTNET_EXPORT void E_Struct_FBox2D_Min_SET(INT_PTR Ptr, INT_PTR Value) { ((FBox2D*)Ptr)->Min = *(FVector2D*)Value; }
	
	DOTNET_EXPORT INT_PTR E_Struct_FBox2D_Max_GET(INT_PTR Ptr) { return (INT_PTR) new FVector2D(((FBox2D*)Ptr)->Max); }
	DOTNET_EXPORT void E_Struct_FBox2D_Max_SET(INT_PTR Ptr, INT_PTR Value) { ((FBox2D*)Ptr)->Max = *(FVector2D*)Value; }
	
	DOTNET_EXPORT bool E_Struct_FBox2D_bIsValid_GET(INT_PTR Ptr) { return ((FBox2D*)Ptr)->bIsValid; }
	DOTNET_EXPORT void E_Struct_FBox2D_bIsValid_SET(INT_PTR Ptr, bool Value) { ((FBox2D*)Ptr)->bIsValid = Value; }
	
	DOTNET_EXPORT INT_PTR E_OPER_FBox2D_oc(INT_PTR Self, int32 Index)
	{
		auto _p0 = Index;
		return (INT_PTR) new FVector2D(((FBox2D*)Self)->operator[](_p0));
	}

	DOTNET_EXPORT float E_FBox2D_ComputeSquaredDistanceToPoint(INT_PTR Self, INT_PTR Point)
	{
		auto _p0 = *(FVector2D*)Point;
		return ((FBox2D*)Self)->ComputeSquaredDistanceToPoint(_p0);
	}

	DOTNET_EXPORT INT_PTR E_FBox2D_ExpandBy(INT_PTR Self, float W)
	{
		auto _p0 = W;
		return (INT_PTR) new FBox2D(((FBox2D*)Self)->ExpandBy(_p0));
	}

	DOTNET_EXPORT float E_FBox2D_GetArea(INT_PTR Self)
	{
		return ((FBox2D*)Self)->GetArea();
	}

	DOTNET_EXPORT INT_PTR E_FBox2D_GetCenter(INT_PTR Self)
	{
		return (INT_PTR) new FVector2D(((FBox2D*)Self)->GetCenter());
	}

	DOTNET_EXPORT void E_FBox2D_GetCenterAndExtents(INT_PTR Self, INT_PTR center, INT_PTR Extents)
	{
		auto _p0 = *(FVector2D*)center;
		auto _p1 = *(FVector2D*)Extents;
		((FBox2D*)Self)->GetCenterAndExtents(_p0, _p1);
	}

	DOTNET_EXPORT INT_PTR E_FBox2D_GetClosestPointTo(INT_PTR Self, INT_PTR Point)
	{
		auto _p0 = *(FVector2D*)Point;
		return (INT_PTR) new FVector2D(((FBox2D*)Self)->GetClosestPointTo(_p0));
	}

	DOTNET_EXPORT void E_FBox2D_Init(INT_PTR Self)
	{
		((FBox2D*)Self)->Init();
	}

	DOTNET_EXPORT bool E_FBox2D_IsInside(INT_PTR Self, INT_PTR TestPoint)
	{
		auto _p0 = *(FVector2D*)TestPoint;
		return ((FBox2D*)Self)->IsInside(_p0);
	}

	
	/*	FDropNoteInfo	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FDropNoteInfo() { return (INT_PTR) new FDropNoteInfo(); }
	
	DOTNET_EXPORT INT_PTR E_Struct_FDropNoteInfo_Location_GET(INT_PTR Ptr) { return (INT_PTR) new FVector(((FDropNoteInfo*)Ptr)->Location); }
	DOTNET_EXPORT void E_Struct_FDropNoteInfo_Location_SET(INT_PTR Ptr, INT_PTR Value) { ((FDropNoteInfo*)Ptr)->Location = *(FVector*)Value; }
	
	DOTNET_EXPORT INT_PTR E_Struct_FDropNoteInfo_Rotation_GET(INT_PTR Ptr) { return (INT_PTR) new FRotator(((FDropNoteInfo*)Ptr)->Rotation); }
	DOTNET_EXPORT void E_Struct_FDropNoteInfo_Rotation_SET(INT_PTR Ptr, INT_PTR Value) { ((FDropNoteInfo*)Ptr)->Rotation = *(FRotator*)Value; }
	
	
	/*	FLevelViewportInfo	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FLevelViewportInfo() { return (INT_PTR) new FLevelViewportInfo(); }
	
	DOTNET_EXPORT INT_PTR E_Struct_FLevelViewportInfo_CamPosition_GET(INT_PTR Ptr) { return (INT_PTR) new FVector(((FLevelViewportInfo*)Ptr)->CamPosition); }
	DOTNET_EXPORT void E_Struct_FLevelViewportInfo_CamPosition_SET(INT_PTR Ptr, INT_PTR Value) { ((FLevelViewportInfo*)Ptr)->CamPosition = *(FVector*)Value; }
	
	DOTNET_EXPORT INT_PTR E_Struct_FLevelViewportInfo_CamRotation_GET(INT_PTR Ptr) { return (INT_PTR) new FRotator(((FLevelViewportInfo*)Ptr)->CamRotation); }
	DOTNET_EXPORT void E_Struct_FLevelViewportInfo_CamRotation_SET(INT_PTR Ptr, INT_PTR Value) { ((FLevelViewportInfo*)Ptr)->CamRotation = *(FRotator*)Value; }
	
	DOTNET_EXPORT float E_Struct_FLevelViewportInfo_CamOrthoZoom_GET(INT_PTR Ptr) { return ((FLevelViewportInfo*)Ptr)->CamOrthoZoom; }
	DOTNET_EXPORT void E_Struct_FLevelViewportInfo_CamOrthoZoom_SET(INT_PTR Ptr, float Value) { ((FLevelViewportInfo*)Ptr)->CamOrthoZoom = Value; }
	
	DOTNET_EXPORT bool E_Struct_FLevelViewportInfo_CamUpdated_GET(INT_PTR Ptr) { return ((FLevelViewportInfo*)Ptr)->CamUpdated; }
	DOTNET_EXPORT void E_Struct_FLevelViewportInfo_CamUpdated_SET(INT_PTR Ptr, bool Value) { ((FLevelViewportInfo*)Ptr)->CamUpdated = Value; }
	
	
	/*	FRepRootMotionMontage	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FRepRootMotionMontage() { return (INT_PTR) new FRepRootMotionMontage(); }
	
	DOTNET_EXPORT bool E_Struct_FRepRootMotionMontage_bIsActive_GET(INT_PTR Ptr) { return ((FRepRootMotionMontage*)Ptr)->bIsActive; }
	DOTNET_EXPORT void E_Struct_FRepRootMotionMontage_bIsActive_SET(INT_PTR Ptr, bool Value) { ((FRepRootMotionMontage*)Ptr)->bIsActive = Value; }
	
	DOTNET_EXPORT float E_Struct_FRepRootMotionMontage_Position_GET(INT_PTR Ptr) { return ((FRepRootMotionMontage*)Ptr)->Position; }
	DOTNET_EXPORT void E_Struct_FRepRootMotionMontage_Position_SET(INT_PTR Ptr, float Value) { ((FRepRootMotionMontage*)Ptr)->Position = Value; }
	
	DOTNET_EXPORT INT_PTR E_Struct_FRepRootMotionMontage_Rotation_GET(INT_PTR Ptr) { return (INT_PTR) new FRotator(((FRepRootMotionMontage*)Ptr)->Rotation); }
	DOTNET_EXPORT void E_Struct_FRepRootMotionMontage_Rotation_SET(INT_PTR Ptr, INT_PTR Value) { ((FRepRootMotionMontage*)Ptr)->Rotation = *(FRotator*)Value; }
	
	DOTNET_EXPORT bool E_Struct_FRepRootMotionMontage_bRelativePosition_GET(INT_PTR Ptr) { return ((FRepRootMotionMontage*)Ptr)->bRelativePosition; }
	DOTNET_EXPORT void E_Struct_FRepRootMotionMontage_bRelativePosition_SET(INT_PTR Ptr, bool Value) { ((FRepRootMotionMontage*)Ptr)->bRelativePosition = Value; }
	
	DOTNET_EXPORT bool E_Struct_FRepRootMotionMontage_bRelativeRotation_GET(INT_PTR Ptr) { return ((FRepRootMotionMontage*)Ptr)->bRelativeRotation; }
	DOTNET_EXPORT void E_Struct_FRepRootMotionMontage_bRelativeRotation_SET(INT_PTR Ptr, bool Value) { ((FRepRootMotionMontage*)Ptr)->bRelativeRotation = Value; }
	
	DOTNET_EXPORT void E_FRepRootMotionMontage_Clear(INT_PTR Self)
	{
		((FRepRootMotionMontage*)Self)->Clear();
	}

	DOTNET_EXPORT bool E_FRepRootMotionMontage_HasRootMotion(INT_PTR Self)
	{
		return ((FRepRootMotionMontage*)Self)->HasRootMotion();
	}

	
	/*	FScreenMessageString	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FScreenMessageString() { return (INT_PTR) new FScreenMessageString(); }
	
	DOTNET_EXPORT float E_Struct_FScreenMessageString_TimeToDisplay_GET(INT_PTR Ptr) { return ((FScreenMessageString*)Ptr)->TimeToDisplay; }
	DOTNET_EXPORT void E_Struct_FScreenMessageString_TimeToDisplay_SET(INT_PTR Ptr, float Value) { ((FScreenMessageString*)Ptr)->TimeToDisplay = Value; }
	
	DOTNET_EXPORT float E_Struct_FScreenMessageString_CurrentTimeDisplayed_GET(INT_PTR Ptr) { return ((FScreenMessageString*)Ptr)->CurrentTimeDisplayed; }
	DOTNET_EXPORT void E_Struct_FScreenMessageString_CurrentTimeDisplayed_SET(INT_PTR Ptr, float Value) { ((FScreenMessageString*)Ptr)->CurrentTimeDisplayed = Value; }
	
	DOTNET_EXPORT INT_PTR E_Struct_FScreenMessageString_TextScale_GET(INT_PTR Ptr) { return (INT_PTR) new FVector2D(((FScreenMessageString*)Ptr)->TextScale); }
	DOTNET_EXPORT void E_Struct_FScreenMessageString_TextScale_SET(INT_PTR Ptr, INT_PTR Value) { ((FScreenMessageString*)Ptr)->TextScale = *(FVector2D*)Value; }
	
	
	/*	FSimulatedRootMotionReplicatedMove	*/
	
	DOTNET_EXPORT INT_PTR E_CreateStruct_FSimulatedRootMotionReplicatedMove() { return (INT_PTR) new FSimulatedRootMotionReplicatedMove(); }
	
	DOTNET_EXPORT float E_Struct_FSimulatedRootMotionReplicatedMove_Time_GET(INT_PTR Ptr) { return ((FSimulatedRootMotionReplicatedMove*)Ptr)->Time; }
	DOTNET_EXPORT void E_Struct_FSimulatedRootMotionReplicatedMove_Time_SET(INT_PTR Ptr, float Value) { ((FSimulatedRootMotionReplicatedMove*)Ptr)->Time = Value; }
	
	DOTNET_EXPORT INT_PTR E_Struct_FSimulatedRootMotionReplicatedMove_RootMotion_GET(INT_PTR Ptr) { return (INT_PTR) new FRepRootMotionMontage(((FSimulatedRootMotionReplicatedMove*)Ptr)->RootMotion); }
	DOTNET_EXPORT void E_Struct_FSimulatedRootMotionReplicatedMove_RootMotion_SET(INT_PTR Ptr, INT_PTR Value) { ((FSimulatedRootMotionReplicatedMove*)Ptr)->RootMotion = *(FRepRootMotionMontage*)Value; }
	
}
