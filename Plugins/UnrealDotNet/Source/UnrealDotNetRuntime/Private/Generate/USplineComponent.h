#pragma once

#include "CoreMinimal.h"
#include "Components/SplineComponent.h"

extern "C"
{
	DOTNET_EXPORT INT_PTR E_PROP_USplineComponent_DefaultUpVector_GET(INT_PTR Ptr) { return (INT_PTR) new FVector(((USplineComponent*)Ptr)->DefaultUpVector); }
	DOTNET_EXPORT void E_PROP_USplineComponent_DefaultUpVector_SET(INT_PTR Ptr, INT_PTR Value) { ((USplineComponent*)Ptr)->DefaultUpVector = *(FVector*)Value; }
	
	DOTNET_EXPORT void E_USplineComponent_UpdateSpline(INT_PTR Self)
	{
		((USplineComponent*)Self)->UpdateSpline();
	}

	DOTNET_EXPORT INT_PTR E_USplineComponent_GetScaleAtSplineInputKey(INT_PTR Self, float InKey)
	{
		auto _p0 = InKey;
		return (INT_PTR) new FVector(((USplineComponent*)Self)->GetScaleAtSplineInputKey(_p0));
	}

	DOTNET_EXPORT int32 E_USplineComponent_GetNumSplinePoints(INT_PTR Self)
	{
		return ((USplineComponent*)Self)->GetNumSplinePoints();
	}

	DOTNET_EXPORT void E_USplineComponent_SetDrawDebug(INT_PTR Self, bool bShow)
	{
		auto _p0 = bShow;
		((USplineComponent*)Self)->SetDrawDebug(_p0);
	}

	DOTNET_EXPORT void E_USplineComponent_SetClosedLoop(INT_PTR Self, bool bInClosedLoop, bool bUpdateSpline)
	{
		auto _p0 = bInClosedLoop;
		auto _p1 = bUpdateSpline;
		((USplineComponent*)Self)->SetClosedLoop(_p0, _p1);
	}

	DOTNET_EXPORT void E_USplineComponent_SetClosedLoopAtPosition(INT_PTR Self, bool bInClosedLoop, float Key, bool bUpdateSpline)
	{
		auto _p0 = bInClosedLoop;
		auto _p1 = Key;
		auto _p2 = bUpdateSpline;
		((USplineComponent*)Self)->SetClosedLoopAtPosition(_p0, _p1, _p2);
	}

	DOTNET_EXPORT bool E_USplineComponent_IsClosedLoop(INT_PTR Self)
	{
		return ((USplineComponent*)Self)->IsClosedLoop();
	}

	DOTNET_EXPORT void E_USplineComponent_AddPoint(INT_PTR Self, INT_PTR Point, bool bUpdateSpline)
	{
		auto _p0 = *(FSplinePoint*)Point;
		auto _p1 = bUpdateSpline;
		((USplineComponent*)Self)->AddPoint(_p0, _p1);
	}

	DOTNET_EXPORT void E_USplineComponent_RemoveSplinePoint(INT_PTR Self, int32 Index, bool bUpdateSpline)
	{
		auto _p0 = Index;
		auto _p1 = bUpdateSpline;
		((USplineComponent*)Self)->RemoveSplinePoint(_p0, _p1);
	}

	DOTNET_EXPORT void E_USplineComponent_AddSplineWorldPoint(INT_PTR Self, INT_PTR Position)
	{
		auto _p0 = *(FVector*)Position;
		((USplineComponent*)Self)->AddSplineWorldPoint(_p0);
	}

	DOTNET_EXPORT void E_USplineComponent_SetWorldLocationAtSplinePoint(INT_PTR Self, int32 PointIndex, INT_PTR InLocation)
	{
		auto _p0 = PointIndex;
		auto _p1 = *(FVector*)InLocation;
		((USplineComponent*)Self)->SetWorldLocationAtSplinePoint(_p0, _p1);
	}

	DOTNET_EXPORT INT_PTR E_USplineComponent_GetWorldLocationAtSplinePoint(INT_PTR Self, int32 PointIndex)
	{
		auto _p0 = PointIndex;
		return (INT_PTR) new FVector(((USplineComponent*)Self)->GetWorldLocationAtSplinePoint(_p0));
	}

	DOTNET_EXPORT void E_USplineComponent_GetLocalLocationAndTangentAtSplinePoint(INT_PTR Self, int32 PointIndex, INT_PTR LocalLocation, INT_PTR LocalTangent)
	{
		auto _p0 = PointIndex;
		auto _p1 = *(FVector*)LocalLocation;
		auto _p2 = *(FVector*)LocalTangent;
		((USplineComponent*)Self)->GetLocalLocationAndTangentAtSplinePoint(_p0, _p1, _p2);
	}

	DOTNET_EXPORT float E_USplineComponent_GetDistanceAlongSplineAtSplinePoint(INT_PTR Self, int32 PointIndex)
	{
		auto _p0 = PointIndex;
		return ((USplineComponent*)Self)->GetDistanceAlongSplineAtSplinePoint(_p0);
	}

	DOTNET_EXPORT float E_USplineComponent_GetSplineLength(INT_PTR Self)
	{
		return ((USplineComponent*)Self)->GetSplineLength();
	}

	DOTNET_EXPORT float E_USplineComponent_GetInputKeyAtDistanceAlongSpline(INT_PTR Self, float Distance)
	{
		auto _p0 = Distance;
		return ((USplineComponent*)Self)->GetInputKeyAtDistanceAlongSpline(_p0);
	}

	DOTNET_EXPORT INT_PTR E_USplineComponent_GetWorldRotationAtDistanceAlongSpline(INT_PTR Self, float Distance)
	{
		auto _p0 = Distance;
		return (INT_PTR) new FRotator(((USplineComponent*)Self)->GetWorldRotationAtDistanceAlongSpline(_p0));
	}

	DOTNET_EXPORT INT_PTR E_USplineComponent_GetWorldLocationAtTime(INT_PTR Self, float Time, bool bUseConstantVelocity)
	{
		auto _p0 = Time;
		auto _p1 = bUseConstantVelocity;
		return (INT_PTR) new FVector(((USplineComponent*)Self)->GetWorldLocationAtTime(_p0, _p1));
	}

	DOTNET_EXPORT INT_PTR E_USplineComponent_GetWorldRotationAtTime(INT_PTR Self, float Time, bool bUseConstantVelocity)
	{
		auto _p0 = Time;
		auto _p1 = bUseConstantVelocity;
		return (INT_PTR) new FRotator(((USplineComponent*)Self)->GetWorldRotationAtTime(_p0, _p1));
	}

	DOTNET_EXPORT float E_USplineComponent_FindInputKeyClosestToWorldLocation(INT_PTR Self, INT_PTR WorldLocation)
	{
		auto _p0 = *(FVector*)WorldLocation;
		return ((USplineComponent*)Self)->FindInputKeyClosestToWorldLocation(_p0);
	}

	DOTNET_EXPORT INT_PTR E_USplineComponent_FindScaleClosestToWorldLocation(INT_PTR Self, INT_PTR WorldLocation)
	{
		auto _p0 = *(FVector*)WorldLocation;
		return (INT_PTR) new FVector(((USplineComponent*)Self)->FindScaleClosestToWorldLocation(_p0));
	}

}
