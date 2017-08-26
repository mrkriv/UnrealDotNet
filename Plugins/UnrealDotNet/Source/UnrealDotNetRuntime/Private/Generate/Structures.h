#pragma once

#include "CoreMinimal.h"
#include "Math/Quat.h"
#include "Math/Rotator.h"
#include "Math/TransformVectorized.h"
#include "Math/Vector.h"
#include "Math/Vector2D.h"
#include "Math/Vector4.h"
#include "Math/Box.h"
#include "Math/Box2D.h"


extern "C"
{
	typedef struct
	{
		float X;
		float Y;
		float Z;
		float W;
	}
E_ST_FQuat, *E_ST_FQuat_REF;
}

FORCEINLINE E_ST_FQuat CONV_ST_FQuat_IN(FQuat In)
{
	E_ST_FQuat var;
	var.X = In.X;
	var.Y = In.Y;
	var.Z = In.Z;
	var.W = In.W;
	
	return var;
}

FORCEINLINE FQuat CONV_ST_FQuat_TO(E_ST_FQuat In)
{
	FQuat var;
	var.X = In.X;
	var.Y = In.Y;
	var.Z = In.Z;
	var.W = In.W;
	
	return var;
}


extern "C"
{
	typedef struct
	{
		float Pitch;
		float Yaw;
		float Roll;
	}
E_ST_FRotator, *E_ST_FRotator_REF;
}

FORCEINLINE E_ST_FRotator CONV_ST_FRotator_IN(FRotator In)
{
	E_ST_FRotator var;
	var.Pitch = In.Pitch;
	var.Yaw = In.Yaw;
	var.Roll = In.Roll;
	
	return var;
}

FORCEINLINE FRotator CONV_ST_FRotator_TO(E_ST_FRotator In)
{
	FRotator var;
	var.Pitch = In.Pitch;
	var.Yaw = In.Yaw;
	var.Roll = In.Roll;
	
	return var;
}


extern "C"
{
	typedef struct
	{
	}
E_ST_FTransform, *E_ST_FTransform_REF;
}

FORCEINLINE E_ST_FTransform CONV_ST_FTransform_IN(FTransform In)
{
	E_ST_FTransform var;
	
	return var;
}

FORCEINLINE FTransform CONV_ST_FTransform_TO(E_ST_FTransform In)
{
	FTransform var;
	
	return var;
}


extern "C"
{
	typedef struct
	{
		float X;
		float Y;
		float Z;
	}
E_ST_FVector, *E_ST_FVector_REF;
}

FORCEINLINE E_ST_FVector CONV_ST_FVector_IN(FVector In)
{
	E_ST_FVector var;
	var.X = In.X;
	var.Y = In.Y;
	var.Z = In.Z;
	
	return var;
}

FORCEINLINE FVector CONV_ST_FVector_TO(E_ST_FVector In)
{
	FVector var;
	var.X = In.X;
	var.Y = In.Y;
	var.Z = In.Z;
	
	return var;
}


extern "C"
{
	typedef struct
	{
		float X;
		float Y;
	}
E_ST_FVector2D, *E_ST_FVector2D_REF;
}

FORCEINLINE E_ST_FVector2D CONV_ST_FVector2D_IN(FVector2D In)
{
	E_ST_FVector2D var;
	var.X = In.X;
	var.Y = In.Y;
	
	return var;
}

FORCEINLINE FVector2D CONV_ST_FVector2D_TO(E_ST_FVector2D In)
{
	FVector2D var;
	var.X = In.X;
	var.Y = In.Y;
	
	return var;
}


extern "C"
{
	typedef struct
	{
		float X;
		float Y;
		float Z;
		float W;
	}
E_ST_FVector4, *E_ST_FVector4_REF;
}

FORCEINLINE E_ST_FVector4 CONV_ST_FVector4_IN(FVector4 In)
{
	E_ST_FVector4 var;
	var.X = In.X;
	var.Y = In.Y;
	var.Z = In.Z;
	var.W = In.W;
	
	return var;
}

FORCEINLINE FVector4 CONV_ST_FVector4_TO(E_ST_FVector4 In)
{
	FVector4 var;
	var.X = In.X;
	var.Y = In.Y;
	var.Z = In.Z;
	var.W = In.W;
	
	return var;
}


extern "C"
{
	typedef struct
	{
		FVector Min;
		FVector Max;
		uint8 IsValid;
	}
E_ST_FBox, *E_ST_FBox_REF;
}

FORCEINLINE E_ST_FBox CONV_ST_FBox_IN(FBox In)
{
	E_ST_FBox var;
	var.Min = In.Min;
	var.Max = In.Max;
	var.IsValid = In.IsValid;
	
	return var;
}

FORCEINLINE FBox CONV_ST_FBox_TO(E_ST_FBox In)
{
	FBox var;
	var.Min = In.Min;
	var.Max = In.Max;
	var.IsValid = In.IsValid;
	
	return var;
}


extern "C"
{
	typedef struct
	{
		FVector2D Min;
		FVector2D Max;
		bool bIsValid;
	}
E_ST_FBox2D, *E_ST_FBox2D_REF;
}

FORCEINLINE E_ST_FBox2D CONV_ST_FBox2D_IN(FBox2D In)
{
	E_ST_FBox2D var;
	var.Min = In.Min;
	var.Max = In.Max;
	var.bIsValid = In.bIsValid;
	
	return var;
}

FORCEINLINE FBox2D CONV_ST_FBox2D_TO(E_ST_FBox2D In)
{
	FBox2D var;
	var.Min = In.Min;
	var.Max = In.Max;
	var.bIsValid = In.bIsValid;
	
	return var;
}


extern "C"
{
	
	/*	FQuat	*/
	
	DOTNET_EXPORT bool E_FQuat_Equals(E_ST_FQuat Self, E_ST_FQuat Q, float Tolerance)
	{
		auto _p0 = CONV_ST_FQuat_TO(Q);
		auto _p1 = Tolerance;
		return CONV_ST_FQuat_TO(Self).Equals(_p0, _p1);
	}

	DOTNET_EXPORT bool E_FQuat_IsIdentity(E_ST_FQuat Self, float Tolerance)
	{
		auto _p0 = Tolerance;
		return CONV_ST_FQuat_TO(Self).IsIdentity(_p0);
	}

	DOTNET_EXPORT E_ST_FQuat E_FQuat_MakeFromEuler(E_ST_FQuat Self, E_ST_FVector Euler)
	{
		auto _p0 = CONV_ST_FVector_TO(Euler);
		return CONV_ST_FQuat_IN(CONV_ST_FQuat_TO(Self).MakeFromEuler(_p0));
	}

	DOTNET_EXPORT E_ST_FVector E_FQuat_Euler(E_ST_FQuat Self)
	{
		return CONV_ST_FVector_IN(CONV_ST_FQuat_TO(Self).Euler());
	}

	DOTNET_EXPORT void E_FQuat_Normalize(E_ST_FQuat Self, float Tolerance)
	{
		auto _p0 = Tolerance;
		CONV_ST_FQuat_TO(Self).Normalize(_p0);
	}

	DOTNET_EXPORT E_ST_FQuat E_FQuat_GetNormalized(E_ST_FQuat Self, float Tolerance)
	{
		auto _p0 = Tolerance;
		return CONV_ST_FQuat_IN(CONV_ST_FQuat_TO(Self).GetNormalized(_p0));
	}

	DOTNET_EXPORT bool E_FQuat_IsNormalized(E_ST_FQuat Self)
	{
		return CONV_ST_FQuat_TO(Self).IsNormalized();
	}

	DOTNET_EXPORT float E_FQuat_Size(E_ST_FQuat Self)
	{
		return CONV_ST_FQuat_TO(Self).Size();
	}

	DOTNET_EXPORT void E_FQuat_ToAxisAndAngle(E_ST_FQuat Self, E_ST_FVector Axis, float Angle)
	{
		auto _p0 = CONV_ST_FVector_TO(Axis);
		auto _p1 = Angle;
		CONV_ST_FQuat_TO(Self).ToAxisAndAngle(_p0, _p1);
	}

	DOTNET_EXPORT void E_FQuat_ToSwingTwist(E_ST_FQuat Self, E_ST_FVector InTwistAxis, E_ST_FQuat OutSwing, E_ST_FQuat OutTwist)
	{
		auto _p0 = CONV_ST_FVector_TO(InTwistAxis);
		auto _p1 = CONV_ST_FQuat_TO(OutSwing);
		auto _p2 = CONV_ST_FQuat_TO(OutTwist);
		CONV_ST_FQuat_TO(Self).ToSwingTwist(_p0, _p1, _p2);
	}

	DOTNET_EXPORT E_ST_FVector E_FQuat_RotateVector(E_ST_FQuat Self, E_ST_FVector V)
	{
		auto _p0 = CONV_ST_FVector_TO(V);
		return CONV_ST_FVector_IN(CONV_ST_FQuat_TO(Self).RotateVector(_p0));
	}

	DOTNET_EXPORT E_ST_FQuat E_FQuat_Log(E_ST_FQuat Self)
	{
		return CONV_ST_FQuat_IN(CONV_ST_FQuat_TO(Self).Log());
	}

	DOTNET_EXPORT void E_FQuat_EnforceShortestArcWith(E_ST_FQuat Self, E_ST_FQuat OtherQuat)
	{
		auto _p0 = CONV_ST_FQuat_TO(OtherQuat);
		CONV_ST_FQuat_TO(Self).EnforceShortestArcWith(_p0);
	}

	DOTNET_EXPORT E_ST_FRotator E_FQuat_Rotator(E_ST_FQuat Self)
	{
		return CONV_ST_FRotator_IN(CONV_ST_FQuat_TO(Self).Rotator());
	}

	DOTNET_EXPORT E_ST_FQuat E_FQuat_FindBetween(E_ST_FQuat Self, E_ST_FVector Vector1, E_ST_FVector Vector2)
	{
		auto _p0 = CONV_ST_FVector_TO(Vector1);
		auto _p1 = CONV_ST_FVector_TO(Vector2);
		return CONV_ST_FQuat_IN(CONV_ST_FQuat_TO(Self).FindBetween(_p0, _p1));
	}

	DOTNET_EXPORT float E_FQuat_Error(E_ST_FQuat Self, E_ST_FQuat Q1, E_ST_FQuat Q2)
	{
		auto _p0 = CONV_ST_FQuat_TO(Q1);
		auto _p1 = CONV_ST_FQuat_TO(Q2);
		return CONV_ST_FQuat_TO(Self).Error(_p0, _p1);
	}

	DOTNET_EXPORT E_ST_FQuat E_FQuat_FastLerp(E_ST_FQuat Self, E_ST_FQuat A, E_ST_FQuat B, float Alpha)
	{
		auto _p0 = CONV_ST_FQuat_TO(A);
		auto _p1 = CONV_ST_FQuat_TO(B);
		auto _p2 = Alpha;
		return CONV_ST_FQuat_IN(CONV_ST_FQuat_TO(Self).FastLerp(_p0, _p1, _p2));
	}

	DOTNET_EXPORT E_ST_FQuat E_FQuat_FastBilerp(E_ST_FQuat Self, E_ST_FQuat P00, E_ST_FQuat P10, E_ST_FQuat P01, E_ST_FQuat P11, float FracX, float FracY)
	{
		auto _p0 = CONV_ST_FQuat_TO(P00);
		auto _p1 = CONV_ST_FQuat_TO(P10);
		auto _p2 = CONV_ST_FQuat_TO(P01);
		auto _p3 = CONV_ST_FQuat_TO(P11);
		auto _p4 = FracX;
		auto _p5 = FracY;
		return CONV_ST_FQuat_IN(CONV_ST_FQuat_TO(Self).FastBilerp(_p0, _p1, _p2, _p3, _p4, _p5));
	}

	DOTNET_EXPORT E_ST_FQuat E_FQuat_Slerp_NotNormalized(E_ST_FQuat Self, E_ST_FQuat Quat1, E_ST_FQuat Quat2, float Slerp)
	{
		auto _p0 = CONV_ST_FQuat_TO(Quat1);
		auto _p1 = CONV_ST_FQuat_TO(Quat2);
		auto _p2 = Slerp;
		return CONV_ST_FQuat_IN(CONV_ST_FQuat_TO(Self).Slerp_NotNormalized(_p0, _p1, _p2));
	}

	DOTNET_EXPORT E_ST_FQuat E_FQuat_Squad(E_ST_FQuat Self, E_ST_FQuat quat1, E_ST_FQuat tang1, E_ST_FQuat quat2, E_ST_FQuat tang2, float Alpha)
	{
		auto _p0 = CONV_ST_FQuat_TO(quat1);
		auto _p1 = CONV_ST_FQuat_TO(tang1);
		auto _p2 = CONV_ST_FQuat_TO(quat2);
		auto _p3 = CONV_ST_FQuat_TO(tang2);
		auto _p4 = Alpha;
		return CONV_ST_FQuat_IN(CONV_ST_FQuat_TO(Self).Squad(_p0, _p1, _p2, _p3, _p4));
	}

	DOTNET_EXPORT void E_FQuat_CalcTangents(E_ST_FQuat Self, E_ST_FQuat PrevP, E_ST_FQuat P, E_ST_FQuat NextP, float Tension, E_ST_FQuat OutTan)
	{
		auto _p0 = CONV_ST_FQuat_TO(PrevP);
		auto _p1 = CONV_ST_FQuat_TO(P);
		auto _p2 = CONV_ST_FQuat_TO(NextP);
		auto _p3 = Tension;
		auto _p4 = CONV_ST_FQuat_TO(OutTan);
		CONV_ST_FQuat_TO(Self).CalcTangents(_p0, _p1, _p2, _p3, _p4);
	}

	
	/*	FRotator	*/
	
	DOTNET_EXPORT bool E_FRotator_IsNearlyZero(E_ST_FRotator Self, float Tolerance)
	{
		auto _p0 = Tolerance;
		return CONV_ST_FRotator_TO(Self).IsNearlyZero(_p0);
	}

	DOTNET_EXPORT bool E_FRotator_IsZero(E_ST_FRotator Self)
	{
		return CONV_ST_FRotator_TO(Self).IsZero();
	}

	DOTNET_EXPORT bool E_FRotator_Equals(E_ST_FRotator Self, E_ST_FRotator R, float Tolerance)
	{
		auto _p0 = CONV_ST_FRotator_TO(R);
		auto _p1 = Tolerance;
		return CONV_ST_FRotator_TO(Self).Equals(_p0, _p1);
	}

	DOTNET_EXPORT E_ST_FRotator E_FRotator_Add(E_ST_FRotator Self, float DeltaPitch, float DeltaYaw, float DeltaRoll)
	{
		auto _p0 = DeltaPitch;
		auto _p1 = DeltaYaw;
		auto _p2 = DeltaRoll;
		return CONV_ST_FRotator_IN(CONV_ST_FRotator_TO(Self).Add(_p0, _p1, _p2));
	}

	DOTNET_EXPORT E_ST_FVector E_FRotator_Vector(E_ST_FRotator Self)
	{
		return CONV_ST_FVector_IN(CONV_ST_FRotator_TO(Self).Vector());
	}

	DOTNET_EXPORT E_ST_FQuat E_FRotator_Quaternion(E_ST_FRotator Self)
	{
		return CONV_ST_FQuat_IN(CONV_ST_FRotator_TO(Self).Quaternion());
	}

	DOTNET_EXPORT E_ST_FVector E_FRotator_RotateVector(E_ST_FRotator Self, E_ST_FVector V)
	{
		auto _p0 = CONV_ST_FVector_TO(V);
		return CONV_ST_FVector_IN(CONV_ST_FRotator_TO(Self).RotateVector(_p0));
	}

	DOTNET_EXPORT void E_FRotator_Normalize(E_ST_FRotator Self)
	{
		CONV_ST_FRotator_TO(Self).Normalize();
	}

	DOTNET_EXPORT void E_FRotator_GetWindingAndRemainder(E_ST_FRotator Self, E_ST_FRotator Winding, E_ST_FRotator Remainder)
	{
		auto _p0 = CONV_ST_FRotator_TO(Winding);
		auto _p1 = CONV_ST_FRotator_TO(Remainder);
		CONV_ST_FRotator_TO(Self).GetWindingAndRemainder(_p0, _p1);
	}

	DOTNET_EXPORT float E_FRotator_ClampAxis(E_ST_FRotator Self, float Angle)
	{
		auto _p0 = Angle;
		return CONV_ST_FRotator_TO(Self).ClampAxis(_p0);
	}

	DOTNET_EXPORT uint8 E_FRotator_CompressAxisToByte(E_ST_FRotator Self, float Angle)
	{
		auto _p0 = Angle;
		return CONV_ST_FRotator_TO(Self).CompressAxisToByte(_p0);
	}

	DOTNET_EXPORT E_ST_FRotator E_FRotator_MakeFromEuler(E_ST_FRotator Self, E_ST_FVector Euler)
	{
		auto _p0 = CONV_ST_FVector_TO(Euler);
		return CONV_ST_FRotator_IN(CONV_ST_FRotator_TO(Self).MakeFromEuler(_p0));
	}

	
	/*	FTransform	*/
	
	DOTNET_EXPORT void E_FTransform_DiagnosticCheckNaN_Scale3D(E_ST_FTransform Self)
	{
		CONV_ST_FTransform_TO(Self).DiagnosticCheckNaN_Scale3D();
	}

	
	/*	FVector	*/
	
	DOTNET_EXPORT E_ST_FVector E_FVector_CrossProduct(E_ST_FVector Self, E_ST_FVector A, E_ST_FVector B)
	{
		auto _p0 = CONV_ST_FVector_TO(A);
		auto _p1 = CONV_ST_FVector_TO(B);
		return CONV_ST_FVector_IN(CONV_ST_FVector_TO(Self).CrossProduct(_p0, _p1));
	}

	DOTNET_EXPORT float E_FVector_DotProduct(E_ST_FVector Self, E_ST_FVector A, E_ST_FVector B)
	{
		auto _p0 = CONV_ST_FVector_TO(A);
		auto _p1 = CONV_ST_FVector_TO(B);
		return CONV_ST_FVector_TO(Self).DotProduct(_p0, _p1);
	}

	DOTNET_EXPORT bool E_FVector_Equals(E_ST_FVector Self, E_ST_FVector V, float Tolerance)
	{
		auto _p0 = CONV_ST_FVector_TO(V);
		auto _p1 = Tolerance;
		return CONV_ST_FVector_TO(Self).Equals(_p0, _p1);
	}

	DOTNET_EXPORT bool E_FVector_AllComponentsEqual(E_ST_FVector Self, float Tolerance)
	{
		auto _p0 = Tolerance;
		return CONV_ST_FVector_TO(Self).AllComponentsEqual(_p0);
	}

	DOTNET_EXPORT void E_FVector_Set(E_ST_FVector Self, float InX, float InY, float InZ)
	{
		auto _p0 = InX;
		auto _p1 = InY;
		auto _p2 = InZ;
		CONV_ST_FVector_TO(Self).Set(_p0, _p1, _p2);
	}

	DOTNET_EXPORT float E_FVector_GetMax(E_ST_FVector Self)
	{
		return CONV_ST_FVector_TO(Self).GetMax();
	}

	DOTNET_EXPORT bool E_FVector_IsZero(E_ST_FVector Self)
	{
		return CONV_ST_FVector_TO(Self).IsZero();
	}

	DOTNET_EXPORT bool E_FVector_Normalize(E_ST_FVector Self, float Tolerance)
	{
		auto _p0 = Tolerance;
		return CONV_ST_FVector_TO(Self).Normalize(_p0);
	}

	DOTNET_EXPORT void E_FVector_ToDirectionAndLength(E_ST_FVector Self, E_ST_FVector OutDir, float OutLength)
	{
		auto _p0 = CONV_ST_FVector_TO(OutDir);
		auto _p1 = OutLength;
		CONV_ST_FVector_TO(Self).ToDirectionAndLength(_p0, _p1);
	}

	DOTNET_EXPORT E_ST_FVector E_FVector_GridSnap(E_ST_FVector Self, float GridSz)
	{
		auto _p0 = GridSz;
		return CONV_ST_FVector_IN(CONV_ST_FVector_TO(Self).GridSnap(_p0));
	}

	DOTNET_EXPORT E_ST_FVector E_FVector_GetClampedToSize(E_ST_FVector Self, float Min, float Max)
	{
		auto _p0 = Min;
		auto _p1 = Max;
		return CONV_ST_FVector_IN(CONV_ST_FVector_TO(Self).GetClampedToSize(_p0, _p1));
	}

	DOTNET_EXPORT void E_FVector_AddBounded(E_ST_FVector Self, E_ST_FVector V, float Radius)
	{
		auto _p0 = CONV_ST_FVector_TO(V);
		auto _p1 = Radius;
		CONV_ST_FVector_TO(Self).AddBounded(_p0, _p1);
	}

	DOTNET_EXPORT E_ST_FVector E_FVector_RotateAngleAxis(E_ST_FVector Self, float AngleDeg, E_ST_FVector Axis)
	{
		auto _p0 = AngleDeg;
		auto _p1 = CONV_ST_FVector_TO(Axis);
		return CONV_ST_FVector_IN(CONV_ST_FVector_TO(Self).RotateAngleAxis(_p0, _p1));
	}

	DOTNET_EXPORT float E_FVector_CosineAngle2D(E_ST_FVector Self, E_ST_FVector B)
	{
		auto _p0 = CONV_ST_FVector_TO(B);
		return CONV_ST_FVector_TO(Self).CosineAngle2D(_p0);
	}

	DOTNET_EXPORT E_ST_FRotator E_FVector_ToOrientationRotator(E_ST_FVector Self)
	{
		return CONV_ST_FRotator_IN(CONV_ST_FVector_TO(Self).ToOrientationRotator());
	}

	DOTNET_EXPORT E_ST_FQuat E_FVector_ToOrientationQuat(E_ST_FVector Self)
	{
		return CONV_ST_FQuat_IN(CONV_ST_FVector_TO(Self).ToOrientationQuat());
	}

	DOTNET_EXPORT void E_FVector_FindBestAxisVectors(E_ST_FVector Self, E_ST_FVector Axis1, E_ST_FVector Axis2)
	{
		auto _p0 = CONV_ST_FVector_TO(Axis1);
		auto _p1 = CONV_ST_FVector_TO(Axis2);
		CONV_ST_FVector_TO(Self).FindBestAxisVectors(_p0, _p1);
	}

	DOTNET_EXPORT void E_FVector_UnwindEuler(E_ST_FVector Self)
	{
		CONV_ST_FVector_TO(Self).UnwindEuler();
	}

	DOTNET_EXPORT E_ST_FVector2D E_FVector_UnitCartesianToSpherical(E_ST_FVector Self)
	{
		return CONV_ST_FVector2D_IN(CONV_ST_FVector_TO(Self).UnitCartesianToSpherical());
	}

	DOTNET_EXPORT void E_FVector_CreateOrthonormalBasis(E_ST_FVector Self, E_ST_FVector XAxis, E_ST_FVector YAxis, E_ST_FVector ZAxis)
	{
		auto _p0 = CONV_ST_FVector_TO(XAxis);
		auto _p1 = CONV_ST_FVector_TO(YAxis);
		auto _p2 = CONV_ST_FVector_TO(ZAxis);
		CONV_ST_FVector_TO(Self).CreateOrthonormalBasis(_p0, _p1, _p2);
	}

	DOTNET_EXPORT bool E_FVector_PointsAreSame(E_ST_FVector Self, E_ST_FVector P, E_ST_FVector Q)
	{
		auto _p0 = CONV_ST_FVector_TO(P);
		auto _p1 = CONV_ST_FVector_TO(Q);
		return CONV_ST_FVector_TO(Self).PointsAreSame(_p0, _p1);
	}

	DOTNET_EXPORT bool E_FVector_PointsAreNear(E_ST_FVector Self, E_ST_FVector Point1, E_ST_FVector Point2, float Dist)
	{
		auto _p0 = CONV_ST_FVector_TO(Point1);
		auto _p1 = CONV_ST_FVector_TO(Point2);
		auto _p2 = Dist;
		return CONV_ST_FVector_TO(Self).PointsAreNear(_p0, _p1, _p2);
	}

	DOTNET_EXPORT float E_FVector_PointPlaneDist(E_ST_FVector Self, E_ST_FVector Point, E_ST_FVector PlaneBase, E_ST_FVector PlaneNormal)
	{
		auto _p0 = CONV_ST_FVector_TO(Point);
		auto _p1 = CONV_ST_FVector_TO(PlaneBase);
		auto _p2 = CONV_ST_FVector_TO(PlaneNormal);
		return CONV_ST_FVector_TO(Self).PointPlaneDist(_p0, _p1, _p2);
	}

	DOTNET_EXPORT bool E_FVector_Coplanar(E_ST_FVector Self, E_ST_FVector Base1, E_ST_FVector Normal1, E_ST_FVector Base2, E_ST_FVector Normal2, float ParallelCosineThreshold)
	{
		auto _p0 = CONV_ST_FVector_TO(Base1);
		auto _p1 = CONV_ST_FVector_TO(Normal1);
		auto _p2 = CONV_ST_FVector_TO(Base2);
		auto _p3 = CONV_ST_FVector_TO(Normal2);
		auto _p4 = ParallelCosineThreshold;
		return CONV_ST_FVector_TO(Self).Coplanar(_p0, _p1, _p2, _p3, _p4);
	}

	
	/*	FVector2D	*/
	
	DOTNET_EXPORT float E_FVector2D_DotProduct(E_ST_FVector2D Self, E_ST_FVector2D A, E_ST_FVector2D B)
	{
		auto _p0 = CONV_ST_FVector2D_TO(A);
		auto _p1 = CONV_ST_FVector2D_TO(B);
		return CONV_ST_FVector2D_TO(Self).DotProduct(_p0, _p1);
	}

	DOTNET_EXPORT bool E_FVector2D_Equals(E_ST_FVector2D Self, E_ST_FVector2D V, float Tolerance)
	{
		auto _p0 = CONV_ST_FVector2D_TO(V);
		auto _p1 = Tolerance;
		return CONV_ST_FVector2D_TO(Self).Equals(_p0, _p1);
	}

	DOTNET_EXPORT void E_FVector2D_Set(E_ST_FVector2D Self, float InX, float InY)
	{
		auto _p0 = InX;
		auto _p1 = InY;
		CONV_ST_FVector2D_TO(Self).Set(_p0, _p1);
	}

	DOTNET_EXPORT float E_FVector2D_GetMax(E_ST_FVector2D Self)
	{
		return CONV_ST_FVector2D_TO(Self).GetMax();
	}

	DOTNET_EXPORT void E_FVector2D_Normalize(E_ST_FVector2D Self, float Tolerance)
	{
		auto _p0 = Tolerance;
		CONV_ST_FVector2D_TO(Self).Normalize(_p0);
	}

	DOTNET_EXPORT bool E_FVector2D_IsNearlyZero(E_ST_FVector2D Self, float Tolerance)
	{
		auto _p0 = Tolerance;
		return CONV_ST_FVector2D_TO(Self).IsNearlyZero(_p0);
	}

	DOTNET_EXPORT void E_FVector2D_ToDirectionAndLength(E_ST_FVector2D Self, E_ST_FVector2D OutDir, float OutLength)
	{
		auto _p0 = CONV_ST_FVector2D_TO(OutDir);
		auto _p1 = OutLength;
		CONV_ST_FVector2D_TO(Self).ToDirectionAndLength(_p0, _p1);
	}

	DOTNET_EXPORT bool E_FVector2D_IsZero(E_ST_FVector2D Self)
	{
		return CONV_ST_FVector2D_TO(Self).IsZero();
	}

	DOTNET_EXPORT E_ST_FVector2D E_FVector2D_ClampAxes(E_ST_FVector2D Self, float MinAxisVal, float MaxAxisVal)
	{
		auto _p0 = MinAxisVal;
		auto _p1 = MaxAxisVal;
		return CONV_ST_FVector2D_IN(CONV_ST_FVector2D_TO(Self).ClampAxes(_p0, _p1));
	}

	DOTNET_EXPORT void E_FVector2D_DiagnosticCheckNaN(E_ST_FVector2D Self)
	{
		CONV_ST_FVector2D_TO(Self).DiagnosticCheckNaN();
	}

	DOTNET_EXPORT E_ST_FVector E_FVector2D_SphericalToUnitCartesian(E_ST_FVector2D Self)
	{
		return CONV_ST_FVector_IN(CONV_ST_FVector2D_TO(Self).SphericalToUnitCartesian());
	}

	
	/*	FVector4	*/
	
	DOTNET_EXPORT bool E_FVector4_Equals(E_ST_FVector4 Self, E_ST_FVector4 V, float Tolerance)
	{
		auto _p0 = CONV_ST_FVector4_TO(V);
		auto _p1 = Tolerance;
		return CONV_ST_FVector4_TO(Self).Equals(_p0, _p1);
	}

	DOTNET_EXPORT bool E_FVector4_IsUnit3(E_ST_FVector4 Self, float LengthSquaredTolerance)
	{
		auto _p0 = LengthSquaredTolerance;
		return CONV_ST_FVector4_TO(Self).IsUnit3(_p0);
	}

	DOTNET_EXPORT E_ST_FRotator E_FVector4_ToOrientationRotator(E_ST_FVector4 Self)
	{
		return CONV_ST_FRotator_IN(CONV_ST_FVector4_TO(Self).ToOrientationRotator());
	}

	DOTNET_EXPORT E_ST_FQuat E_FVector4_ToOrientationQuat(E_ST_FVector4 Self)
	{
		return CONV_ST_FQuat_IN(CONV_ST_FVector4_TO(Self).ToOrientationQuat());
	}

	DOTNET_EXPORT void E_FVector4_Set(E_ST_FVector4 Self, float InX, float InY, float InZ, float InW)
	{
		auto _p0 = InX;
		auto _p1 = InY;
		auto _p2 = InZ;
		auto _p3 = InW;
		CONV_ST_FVector4_TO(Self).Set(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT float E_FVector4_Size3(E_ST_FVector4 Self)
	{
		return CONV_ST_FVector4_TO(Self).Size3();
	}

	DOTNET_EXPORT bool E_FVector4_ContainsNaN(E_ST_FVector4 Self)
	{
		return CONV_ST_FVector4_TO(Self).ContainsNaN();
	}

	DOTNET_EXPORT void E_FVector4_FindBestAxisVectors3(E_ST_FVector4 Self, E_ST_FVector4 Axis1, E_ST_FVector4 Axis2)
	{
		auto _p0 = CONV_ST_FVector4_TO(Axis1);
		auto _p1 = CONV_ST_FVector4_TO(Axis2);
		CONV_ST_FVector4_TO(Self).FindBestAxisVectors3(_p0, _p1);
	}

	DOTNET_EXPORT void E_FVector4_DiagnosticCheckNaN(E_ST_FVector4 Self)
	{
		CONV_ST_FVector4_TO(Self).DiagnosticCheckNaN();
	}

	
	/*	FBox	*/
	
	DOTNET_EXPORT float E_FBox_ComputeSquaredDistanceToPoint(E_ST_FBox Self, E_ST_FVector Point)
	{
		auto _p0 = CONV_ST_FVector_TO(Point);
		return CONV_ST_FBox_TO(Self).ComputeSquaredDistanceToPoint(_p0);
	}

	DOTNET_EXPORT E_ST_FVector E_FBox_GetCenter(E_ST_FBox Self)
	{
		return CONV_ST_FVector_IN(CONV_ST_FBox_TO(Self).GetCenter());
	}

	DOTNET_EXPORT void E_FBox_GetCenterAndExtents(E_ST_FBox Self, E_ST_FVector center, E_ST_FVector Extents)
	{
		auto _p0 = CONV_ST_FVector_TO(center);
		auto _p1 = CONV_ST_FVector_TO(Extents);
		CONV_ST_FBox_TO(Self).GetCenterAndExtents(_p0, _p1);
	}

	DOTNET_EXPORT E_ST_FVector E_FBox_GetClosestPointTo(E_ST_FBox Self, E_ST_FVector Point)
	{
		auto _p0 = CONV_ST_FVector_TO(Point);
		return CONV_ST_FVector_IN(CONV_ST_FBox_TO(Self).GetClosestPointTo(_p0));
	}

	DOTNET_EXPORT float E_FBox_GetVolume(E_ST_FBox Self)
	{
		return CONV_ST_FBox_TO(Self).GetVolume();
	}

	DOTNET_EXPORT void E_FBox_Init(E_ST_FBox Self)
	{
		CONV_ST_FBox_TO(Self).Init();
	}

	DOTNET_EXPORT E_ST_FBox E_FBox_InverseTransformBy(E_ST_FBox Self, E_ST_FTransform M)
	{
		auto _p0 = CONV_ST_FTransform_TO(M);
		return CONV_ST_FBox_IN(CONV_ST_FBox_TO(Self).InverseTransformBy(_p0));
	}

	DOTNET_EXPORT bool E_FBox_IsInside(E_ST_FBox Self, E_ST_FVector In)
	{
		auto _p0 = CONV_ST_FVector_TO(In);
		return CONV_ST_FBox_TO(Self).IsInside(_p0);
	}

	DOTNET_EXPORT E_ST_FBox E_FBox_BuildAABB(E_ST_FBox Self, E_ST_FVector Origin, E_ST_FVector Extent)
	{
		auto _p0 = CONV_ST_FVector_TO(Origin);
		auto _p1 = CONV_ST_FVector_TO(Extent);
		return CONV_ST_FBox_IN(CONV_ST_FBox_TO(Self).BuildAABB(_p0, _p1));
	}

	
	/*	FBox2D	*/
	
	DOTNET_EXPORT float E_FBox2D_ComputeSquaredDistanceToPoint(E_ST_FBox2D Self, E_ST_FVector2D Point)
	{
		auto _p0 = CONV_ST_FVector2D_TO(Point);
		return CONV_ST_FBox2D_TO(Self).ComputeSquaredDistanceToPoint(_p0);
	}

	DOTNET_EXPORT E_ST_FBox2D E_FBox2D_ExpandBy(E_ST_FBox2D Self, float W)
	{
		auto _p0 = W;
		return CONV_ST_FBox2D_IN(CONV_ST_FBox2D_TO(Self).ExpandBy(_p0));
	}

	DOTNET_EXPORT float E_FBox2D_GetArea(E_ST_FBox2D Self)
	{
		return CONV_ST_FBox2D_TO(Self).GetArea();
	}

	DOTNET_EXPORT E_ST_FVector2D E_FBox2D_GetCenter(E_ST_FBox2D Self)
	{
		return CONV_ST_FVector2D_IN(CONV_ST_FBox2D_TO(Self).GetCenter());
	}

	DOTNET_EXPORT void E_FBox2D_GetCenterAndExtents(E_ST_FBox2D Self, E_ST_FVector2D center, E_ST_FVector2D Extents)
	{
		auto _p0 = CONV_ST_FVector2D_TO(center);
		auto _p1 = CONV_ST_FVector2D_TO(Extents);
		CONV_ST_FBox2D_TO(Self).GetCenterAndExtents(_p0, _p1);
	}

	DOTNET_EXPORT E_ST_FVector2D E_FBox2D_GetClosestPointTo(E_ST_FBox2D Self, E_ST_FVector2D Point)
	{
		auto _p0 = CONV_ST_FVector2D_TO(Point);
		return CONV_ST_FVector2D_IN(CONV_ST_FBox2D_TO(Self).GetClosestPointTo(_p0));
	}

	DOTNET_EXPORT void E_FBox2D_Init(E_ST_FBox2D Self)
	{
		CONV_ST_FBox2D_TO(Self).Init();
	}

	DOTNET_EXPORT bool E_FBox2D_IsInside(E_ST_FBox2D Self, E_ST_FVector2D TestPoint)
	{
		auto _p0 = CONV_ST_FVector2D_TO(TestPoint);
		return CONV_ST_FBox2D_TO(Self).IsInside(_p0);
	}

}
