#pragma once
// This file was created automatically, do not modify the contents of this file.

// ReSharper disable InvalidXmlDocComment
// ReSharper disable InconsistentNaming
// ReSharper disable CheckNamespace
// ReSharper disable MemberCanBePrivate.Global

PRAGMA_DISABLE_DEPRECATION_WARNINGS

#include "CoreMinimal.h"
#include "ManageEventSender.h"
#include "Runtime/Engine/Classes/Kismet/KismetMathLibrary.h"

// Source file C:\Program Files\Epic Games\UE_4.22\Engine\Source\Runtime\Engine\Classes\Kismet\KismetMathLibrary.h:132

extern "C"
{
	
	DOTNET_EXPORT INT_PTR E_NewObject_UKismetMathLibrary(UObject* Parent, char* Name)
	{
		return (INT_PTR)NewObject<UKismetMathLibrary>(Parent, FName(UTF8_TO_TCHAR(Name)));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Abs(UKismetMathLibrary* Self, float A)
	{
		auto _p0 = A;
		return Self->Abs(_p0);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Abs_Int(UKismetMathLibrary* Self, int32 A)
	{
		auto _p0 = A;
		return Self->Abs_Int(_p0);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Abs_Int64(UKismetMathLibrary* Self, int64 A)
	{
		auto _p0 = A;
		return Self->Abs_Int64(_p0);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Acos(UKismetMathLibrary* Self, float A)
	{
		auto _p0 = A;
		return Self->Acos(_p0);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Add_ByteByte(UKismetMathLibrary* Self, uint8 A, uint8 B)
	{
		auto _p0 = A;
		auto _p1 = B;
		return Self->Add_ByteByte(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Add_FloatFloat(UKismetMathLibrary* Self, float A, float B)
	{
		auto _p0 = A;
		auto _p1 = B;
		return Self->Add_FloatFloat(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Add_Int64Int64(UKismetMathLibrary* Self, int64 A, int64 B)
	{
		auto _p0 = A;
		auto _p1 = B;
		return Self->Add_Int64Int64(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Add_IntInt(UKismetMathLibrary* Self, int32 A, int32 B)
	{
		auto _p0 = A;
		auto _p1 = B;
		return Self->Add_IntInt(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Add_LinearColorLinearColor(UKismetMathLibrary* Self, INT_PTR A, INT_PTR B)
	{
		auto _p0 = *(FLinearColor*)A;
		auto _p1 = *(FLinearColor*)B;
		return (INT_PTR) new FLinearColor(Self->Add_LinearColorLinearColor(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Add_QuatQuat(UKismetMathLibrary* Self, INT_PTR A, INT_PTR B)
	{
		auto& _p0 = *(FQuat*)A;
		auto& _p1 = *(FQuat*)B;
		return (INT_PTR) new FQuat(Self->Add_QuatQuat(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Add_Vector2DFloat(UKismetMathLibrary* Self, INT_PTR A, float B)
	{
		auto _p0 = *(FVector2D*)A;
		auto _p1 = B;
		return (INT_PTR) new FVector2D(Self->Add_Vector2DFloat(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Add_Vector2DVector2D(UKismetMathLibrary* Self, INT_PTR A, INT_PTR B)
	{
		auto _p0 = *(FVector2D*)A;
		auto _p1 = *(FVector2D*)B;
		return (INT_PTR) new FVector2D(Self->Add_Vector2DVector2D(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Add_Vector4Vector4(UKismetMathLibrary* Self, INT_PTR A, INT_PTR B)
	{
		auto& _p0 = *(FVector4*)A;
		auto& _p1 = *(FVector4*)B;
		return (INT_PTR) new FVector4(Self->Add_Vector4Vector4(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Add_VectorFloat(UKismetMathLibrary* Self, INT_PTR A, float B)
	{
		auto _p0 = *(FVector*)A;
		auto _p1 = B;
		return (INT_PTR) new FVector(Self->Add_VectorFloat(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Add_VectorInt(UKismetMathLibrary* Self, INT_PTR A, int32 B)
	{
		auto _p0 = *(FVector*)A;
		auto _p1 = B;
		return (INT_PTR) new FVector(Self->Add_VectorInt(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Add_VectorVector(UKismetMathLibrary* Self, INT_PTR A, INT_PTR B)
	{
		auto _p0 = *(FVector*)A;
		auto _p1 = *(FVector*)B;
		return (INT_PTR) new FVector(Self->Add_VectorVector(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_And_Int64Int64(UKismetMathLibrary* Self, int64 A, int64 B)
	{
		auto _p0 = A;
		auto _p1 = B;
		return Self->And_Int64Int64(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_And_IntInt(UKismetMathLibrary* Self, int32 A, int32 B)
	{
		auto _p0 = A;
		auto _p1 = B;
		return Self->And_IntInt(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Asin(UKismetMathLibrary* Self, float A)
	{
		auto _p0 = A;
		return Self->Asin(_p0);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Atan(UKismetMathLibrary* Self, float A)
	{
		auto _p0 = A;
		return Self->Atan(_p0);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Atan2(UKismetMathLibrary* Self, float A, float B)
	{
		auto _p0 = A;
		auto _p1 = B;
		return Self->Atan2(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_BMax(UKismetMathLibrary* Self, uint8 A, uint8 B)
	{
		auto _p0 = A;
		auto _p1 = B;
		return Self->BMax(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_BMin(UKismetMathLibrary* Self, uint8 A, uint8 B)
	{
		auto _p0 = A;
		auto _p1 = B;
		return Self->BMin(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_BooleanAND(UKismetMathLibrary* Self, bool A, bool B)
	{
		auto _p0 = A;
		auto _p1 = B;
		return Self->BooleanAND(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_BooleanNAND(UKismetMathLibrary* Self, bool A, bool B)
	{
		auto _p0 = A;
		auto _p1 = B;
		return Self->BooleanNAND(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_BooleanNOR(UKismetMathLibrary* Self, bool A, bool B)
	{
		auto _p0 = A;
		auto _p1 = B;
		return Self->BooleanNOR(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_BooleanOR(UKismetMathLibrary* Self, bool A, bool B)
	{
		auto _p0 = A;
		auto _p1 = B;
		return Self->BooleanOR(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_BooleanXOR(UKismetMathLibrary* Self, bool A, bool B)
	{
		auto _p0 = A;
		auto _p1 = B;
		return Self->BooleanXOR(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_BreakColor(UKismetMathLibrary* Self, INT_PTR InColor, float R, float G, float B, float A)
	{
		auto _p0 = *(FLinearColor*)InColor;
		auto& _p1 = R;
		auto& _p2 = G;
		auto& _p3 = B;
		auto& _p4 = A;
		Self->BreakColor(_p0, _p1, _p2, _p3, _p4);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_BreakRandomStream(UKismetMathLibrary* Self, INT_PTR InRandomStream, int32 InitialSeed)
	{
		auto& _p0 = *(FRandomStream*)InRandomStream;
		auto& _p1 = InitialSeed;
		Self->BreakRandomStream(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_BreakRotator(UKismetMathLibrary* Self, INT_PTR InRot, float Roll, float Pitch, float Yaw)
	{
		auto _p0 = *(FRotator*)InRot;
		auto& _p1 = Roll;
		auto& _p2 = Pitch;
		auto& _p3 = Yaw;
		Self->BreakRotator(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_BreakRotIntoAxes(UKismetMathLibrary* Self, INT_PTR InRot, INT_PTR X, INT_PTR Y, INT_PTR Z)
	{
		auto& _p0 = *(FRotator*)InRot;
		auto& _p1 = *(FVector*)X;
		auto& _p2 = *(FVector*)Y;
		auto& _p3 = *(FVector*)Z;
		Self->BreakRotIntoAxes(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_BreakTransform(UKismetMathLibrary* Self, INT_PTR InTransform, INT_PTR Location, INT_PTR Rotation, INT_PTR Scale)
	{
		auto& _p0 = *(FTransform*)InTransform;
		auto& _p1 = *(FVector*)Location;
		auto& _p2 = *(FRotator*)Rotation;
		auto& _p3 = *(FVector*)Scale;
		Self->BreakTransform(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_BreakVector(UKismetMathLibrary* Self, INT_PTR InVec, float X, float Y, float Z)
	{
		auto _p0 = *(FVector*)InVec;
		auto& _p1 = X;
		auto& _p2 = Y;
		auto& _p3 = Z;
		Self->BreakVector(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_BreakVector2D(UKismetMathLibrary* Self, INT_PTR InVec, float X, float Y)
	{
		auto _p0 = *(FVector2D*)InVec;
		auto& _p1 = X;
		auto& _p2 = Y;
		Self->BreakVector2D(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_BreakVector4(UKismetMathLibrary* Self, INT_PTR InVec, float X, float Y, float Z, float W)
	{
		auto& _p0 = *(FVector4*)InVec;
		auto& _p1 = X;
		auto& _p2 = Y;
		auto& _p3 = Z;
		auto& _p4 = W;
		Self->BreakVector4(_p0, _p1, _p2, _p3, _p4);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_CInterpTo(UKismetMathLibrary* Self, INT_PTR Current, INT_PTR Target, float DeltaTime, float InterpSpeed)
	{
		auto _p0 = *(FLinearColor*)Current;
		auto _p1 = *(FLinearColor*)Target;
		auto _p2 = DeltaTime;
		auto _p3 = InterpSpeed;
		return (INT_PTR) new FLinearColor(Self->CInterpTo(_p0, _p1, _p2, _p3));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Clamp(UKismetMathLibrary* Self, int32 Value, int32 Min, int32 Max)
	{
		auto _p0 = Value;
		auto _p1 = Min;
		auto _p2 = Max;
		return Self->Clamp(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_ClampAngle(UKismetMathLibrary* Self, float AngleDegrees, float MinAngleDegrees, float MaxAngleDegrees)
	{
		auto _p0 = AngleDegrees;
		auto _p1 = MinAngleDegrees;
		auto _p2 = MaxAngleDegrees;
		return Self->ClampAngle(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_ClampAxes2D(UKismetMathLibrary* Self, INT_PTR A, float MinAxisVal, float MaxAxisVal)
	{
		auto _p0 = *(FVector2D*)A;
		auto _p1 = MinAxisVal;
		auto _p2 = MaxAxisVal;
		return (INT_PTR) new FVector2D(Self->ClampAxes2D(_p0, _p1, _p2));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_ClampAxis(UKismetMathLibrary* Self, float Angle)
	{
		auto _p0 = Angle;
		return Self->ClampAxis(_p0);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_ClampInt64(UKismetMathLibrary* Self, int64 Value, int64 Min, int64 Max)
	{
		auto _p0 = Value;
		auto _p1 = Min;
		auto _p2 = Max;
		return Self->ClampInt64(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_ClampVectorSize(UKismetMathLibrary* Self, INT_PTR A, float Min, float Max)
	{
		auto _p0 = *(FVector*)A;
		auto _p1 = Min;
		auto _p2 = Max;
		return (INT_PTR) new FVector(Self->ClampVectorSize(_p0, _p1, _p2));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_ComposeRotators(UKismetMathLibrary* Self, INT_PTR A, INT_PTR B)
	{
		auto _p0 = *(FRotator*)A;
		auto _p1 = *(FRotator*)B;
		return (INT_PTR) new FRotator(Self->ComposeRotators(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_ComposeTransforms(UKismetMathLibrary* Self, INT_PTR A, INT_PTR B)
	{
		auto& _p0 = *(FTransform*)A;
		auto& _p1 = *(FTransform*)B;
		return (INT_PTR) new FTransform(Self->ComposeTransforms(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Conv_BoolToByte(UKismetMathLibrary* Self, bool InBool)
	{
		auto _p0 = InBool;
		return Self->Conv_BoolToByte(_p0);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Conv_BoolToFloat(UKismetMathLibrary* Self, bool InBool)
	{
		auto _p0 = InBool;
		return Self->Conv_BoolToFloat(_p0);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Conv_BoolToInt(UKismetMathLibrary* Self, bool InBool)
	{
		auto _p0 = InBool;
		return Self->Conv_BoolToInt(_p0);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Conv_ByteToFloat(UKismetMathLibrary* Self, uint8 InByte)
	{
		auto _p0 = InByte;
		return Self->Conv_ByteToFloat(_p0);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Conv_ByteToInt(UKismetMathLibrary* Self, uint8 InByte)
	{
		auto _p0 = InByte;
		return Self->Conv_ByteToInt(_p0);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Conv_FloatToLinearColor(UKismetMathLibrary* Self, float InFloat)
	{
		auto _p0 = InFloat;
		return (INT_PTR) new FLinearColor(Self->Conv_FloatToLinearColor(_p0));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Conv_FloatToVector(UKismetMathLibrary* Self, float InFloat)
	{
		auto _p0 = InFloat;
		return (INT_PTR) new FVector(Self->Conv_FloatToVector(_p0));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Conv_IntToBool(UKismetMathLibrary* Self, int32 InInt)
	{
		auto _p0 = InInt;
		return Self->Conv_IntToBool(_p0);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Conv_IntToByte(UKismetMathLibrary* Self, int32 InInt)
	{
		auto _p0 = InInt;
		return Self->Conv_IntToByte(_p0);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Conv_IntToFloat(UKismetMathLibrary* Self, int32 InInt)
	{
		auto _p0 = InInt;
		return Self->Conv_IntToFloat(_p0);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Conv_IntToInt64(UKismetMathLibrary* Self, int32 InInt)
	{
		auto _p0 = InInt;
		return Self->Conv_IntToInt64(_p0);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Conv_IntToIntVector(UKismetMathLibrary* Self, int32 InInt)
	{
		auto _p0 = InInt;
		return (INT_PTR) new FIntVector(Self->Conv_IntToIntVector(_p0));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Conv_IntVectorToVector(UKismetMathLibrary* Self, INT_PTR InIntVector)
	{
		auto& _p0 = *(FIntVector*)InIntVector;
		return (INT_PTR) new FVector(Self->Conv_IntVectorToVector(_p0));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Conv_LinearColorToVector(UKismetMathLibrary* Self, INT_PTR InLinearColor)
	{
		auto _p0 = *(FLinearColor*)InLinearColor;
		return (INT_PTR) new FVector(Self->Conv_LinearColorToVector(_p0));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Conv_MatrixToRotator(UKismetMathLibrary* Self, INT_PTR InMatrix)
	{
		auto& _p0 = *(FMatrix*)InMatrix;
		return (INT_PTR) new FRotator(Self->Conv_MatrixToRotator(_p0));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Conv_MatrixToTransform(UKismetMathLibrary* Self, INT_PTR InMatrix)
	{
		auto& _p0 = *(FMatrix*)InMatrix;
		return (INT_PTR) new FTransform(Self->Conv_MatrixToTransform(_p0));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Conv_RotatorToTransform(UKismetMathLibrary* Self, INT_PTR InRotator)
	{
		auto& _p0 = *(FRotator*)InRotator;
		return (INT_PTR) new FTransform(Self->Conv_RotatorToTransform(_p0));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Conv_RotatorToVector(UKismetMathLibrary* Self, INT_PTR InRot)
	{
		auto _p0 = *(FRotator*)InRot;
		return (INT_PTR) new FVector(Self->Conv_RotatorToVector(_p0));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Conv_Vector2DToIntPoint(UKismetMathLibrary* Self, INT_PTR InVector2D)
	{
		auto _p0 = *(FVector2D*)InVector2D;
		return (INT_PTR) new FIntPoint(Self->Conv_Vector2DToIntPoint(_p0));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Conv_Vector2DToVector(UKismetMathLibrary* Self, INT_PTR InVector2D, float Z)
	{
		auto _p0 = *(FVector2D*)InVector2D;
		auto _p1 = Z;
		return (INT_PTR) new FVector(Self->Conv_Vector2DToVector(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Conv_Vector4ToQuaterion(UKismetMathLibrary* Self, INT_PTR InVec)
	{
		auto& _p0 = *(FVector4*)InVec;
		return (INT_PTR) new FQuat(Self->Conv_Vector4ToQuaterion(_p0));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Conv_Vector4ToRotator(UKismetMathLibrary* Self, INT_PTR InVec)
	{
		auto& _p0 = *(FVector4*)InVec;
		return (INT_PTR) new FRotator(Self->Conv_Vector4ToRotator(_p0));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Conv_Vector4ToVector(UKismetMathLibrary* Self, INT_PTR InVector4)
	{
		auto& _p0 = *(FVector4*)InVector4;
		return (INT_PTR) new FVector(Self->Conv_Vector4ToVector(_p0));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Conv_VectorToLinearColor(UKismetMathLibrary* Self, INT_PTR InVec)
	{
		auto _p0 = *(FVector*)InVec;
		return (INT_PTR) new FLinearColor(Self->Conv_VectorToLinearColor(_p0));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Conv_VectorToQuaterion(UKismetMathLibrary* Self, INT_PTR InVec)
	{
		auto _p0 = *(FVector*)InVec;
		return (INT_PTR) new FQuat(Self->Conv_VectorToQuaterion(_p0));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Conv_VectorToRotator(UKismetMathLibrary* Self, INT_PTR InVec)
	{
		auto _p0 = *(FVector*)InVec;
		return (INT_PTR) new FRotator(Self->Conv_VectorToRotator(_p0));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Conv_VectorToTransform(UKismetMathLibrary* Self, INT_PTR InLocation)
	{
		auto _p0 = *(FVector*)InLocation;
		return (INT_PTR) new FTransform(Self->Conv_VectorToTransform(_p0));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Conv_VectorToVector2D(UKismetMathLibrary* Self, INT_PTR InVector)
	{
		auto _p0 = *(FVector*)InVector;
		return (INT_PTR) new FVector2D(Self->Conv_VectorToVector2D(_p0));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_ConvertTransformToRelative(UKismetMathLibrary* Self, INT_PTR Transform, INT_PTR ParentTransform)
	{
		auto& _p0 = *(FTransform*)Transform;
		auto& _p1 = *(FTransform*)ParentTransform;
		return (INT_PTR) new FTransform(Self->ConvertTransformToRelative(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Cos(UKismetMathLibrary* Self, float A)
	{
		auto _p0 = A;
		return Self->Cos(_p0);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_CreateVectorFromYawPitch(UKismetMathLibrary* Self, float Yaw, float Pitch, float Length)
	{
		auto _p0 = Yaw;
		auto _p1 = Pitch;
		auto _p2 = Length;
		return (INT_PTR) new FVector(Self->CreateVectorFromYawPitch(_p0, _p1, _p2));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Cross_VectorVector(UKismetMathLibrary* Self, INT_PTR A, INT_PTR B)
	{
		auto _p0 = *(FVector*)A;
		auto _p1 = *(FVector*)B;
		return (INT_PTR) new FVector(Self->Cross_VectorVector(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_CrossProduct2D(UKismetMathLibrary* Self, INT_PTR A, INT_PTR B)
	{
		auto _p0 = *(FVector2D*)A;
		auto _p1 = *(FVector2D*)B;
		return Self->CrossProduct2D(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_DaysInMonth(UKismetMathLibrary* Self, int32 Year, int32 Month)
	{
		auto _p0 = Year;
		auto _p1 = Month;
		return Self->DaysInMonth(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_DaysInYear(UKismetMathLibrary* Self, int32 Year)
	{
		auto _p0 = Year;
		return Self->DaysInYear(_p0);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_DegAcos(UKismetMathLibrary* Self, float A)
	{
		auto _p0 = A;
		return Self->DegAcos(_p0);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_DegAsin(UKismetMathLibrary* Self, float A)
	{
		auto _p0 = A;
		return Self->DegAsin(_p0);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_DegAtan(UKismetMathLibrary* Self, float A)
	{
		auto _p0 = A;
		return Self->DegAtan(_p0);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_DegAtan2(UKismetMathLibrary* Self, float A, float B)
	{
		auto _p0 = A;
		auto _p1 = B;
		return Self->DegAtan2(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_DegCos(UKismetMathLibrary* Self, float A)
	{
		auto _p0 = A;
		return Self->DegCos(_p0);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_DegreesToRadians(UKismetMathLibrary* Self, float A)
	{
		auto _p0 = A;
		return Self->DegreesToRadians(_p0);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_DegSin(UKismetMathLibrary* Self, float A)
	{
		auto _p0 = A;
		return Self->DegSin(_p0);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_DegTan(UKismetMathLibrary* Self, float A)
	{
		auto _p0 = A;
		return Self->DegTan(_p0);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Distance2D(UKismetMathLibrary* Self, INT_PTR V1, INT_PTR V2)
	{
		auto _p0 = *(FVector2D*)V1;
		auto _p1 = *(FVector2D*)V2;
		return Self->Distance2D(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_DistanceSquared2D(UKismetMathLibrary* Self, INT_PTR V1, INT_PTR V2)
	{
		auto _p0 = *(FVector2D*)V1;
		auto _p1 = *(FVector2D*)V2;
		return Self->DistanceSquared2D(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Divide_ByteByte(UKismetMathLibrary* Self, uint8 A, uint8 B)
	{
		auto _p0 = A;
		auto _p1 = B;
		return Self->Divide_ByteByte(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Divide_FloatFloat(UKismetMathLibrary* Self, float A, float B)
	{
		auto _p0 = A;
		auto _p1 = B;
		return Self->Divide_FloatFloat(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Divide_Int64Int64(UKismetMathLibrary* Self, int64 A, int64 B)
	{
		auto _p0 = A;
		auto _p1 = B;
		return Self->Divide_Int64Int64(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Divide_IntInt(UKismetMathLibrary* Self, int32 A, int32 B)
	{
		auto _p0 = A;
		auto _p1 = B;
		return Self->Divide_IntInt(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Divide_LinearColorLinearColor(UKismetMathLibrary* Self, INT_PTR A, INT_PTR B)
	{
		auto _p0 = *(FLinearColor*)A;
		auto _p1 = *(FLinearColor*)B;
		return (INT_PTR) new FLinearColor(Self->Divide_LinearColorLinearColor(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Divide_Vector2DFloat(UKismetMathLibrary* Self, INT_PTR A, float B)
	{
		auto _p0 = *(FVector2D*)A;
		auto _p1 = B;
		return (INT_PTR) new FVector2D(Self->Divide_Vector2DFloat(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Divide_Vector2DVector2D(UKismetMathLibrary* Self, INT_PTR A, INT_PTR B)
	{
		auto _p0 = *(FVector2D*)A;
		auto _p1 = *(FVector2D*)B;
		return (INT_PTR) new FVector2D(Self->Divide_Vector2DVector2D(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Divide_Vector4Vector4(UKismetMathLibrary* Self, INT_PTR A, INT_PTR B)
	{
		auto& _p0 = *(FVector4*)A;
		auto& _p1 = *(FVector4*)B;
		return (INT_PTR) new FVector4(Self->Divide_Vector4Vector4(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Divide_VectorFloat(UKismetMathLibrary* Self, INT_PTR A, float B)
	{
		auto _p0 = *(FVector*)A;
		auto _p1 = B;
		return (INT_PTR) new FVector(Self->Divide_VectorFloat(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Divide_VectorInt(UKismetMathLibrary* Self, INT_PTR A, int32 B)
	{
		auto _p0 = *(FVector*)A;
		auto _p1 = B;
		return (INT_PTR) new FVector(Self->Divide_VectorInt(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Divide_VectorVector(UKismetMathLibrary* Self, INT_PTR A, INT_PTR B)
	{
		auto _p0 = *(FVector*)A;
		auto _p1 = *(FVector*)B;
		return (INT_PTR) new FVector(Self->Divide_VectorVector(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Dot_VectorVector(UKismetMathLibrary* Self, INT_PTR A, INT_PTR B)
	{
		auto _p0 = *(FVector*)A;
		auto _p1 = *(FVector*)B;
		return Self->Dot_VectorVector(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_DotProduct2D(UKismetMathLibrary* Self, INT_PTR A, INT_PTR B)
	{
		auto _p0 = *(FVector2D*)A;
		auto _p1 = *(FVector2D*)B;
		return Self->DotProduct2D(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_EqualEqual_BoolBool(UKismetMathLibrary* Self, bool A, bool B)
	{
		auto _p0 = A;
		auto _p1 = B;
		return Self->EqualEqual_BoolBool(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_EqualEqual_ByteByte(UKismetMathLibrary* Self, uint8 A, uint8 B)
	{
		auto _p0 = A;
		auto _p1 = B;
		return Self->EqualEqual_ByteByte(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_EqualEqual_FloatFloat(UKismetMathLibrary* Self, float A, float B)
	{
		auto _p0 = A;
		auto _p1 = B;
		return Self->EqualEqual_FloatFloat(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_EqualEqual_Int64Int64(UKismetMathLibrary* Self, int64 A, int64 B)
	{
		auto _p0 = A;
		auto _p1 = B;
		return Self->EqualEqual_Int64Int64(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_EqualEqual_IntInt(UKismetMathLibrary* Self, int32 A, int32 B)
	{
		auto _p0 = A;
		auto _p1 = B;
		return Self->EqualEqual_IntInt(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_EqualEqual_LinearColorLinearColor(UKismetMathLibrary* Self, INT_PTR A, INT_PTR B)
	{
		auto _p0 = *(FLinearColor*)A;
		auto _p1 = *(FLinearColor*)B;
		return Self->EqualEqual_LinearColorLinearColor(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_EqualEqual_NameName(UKismetMathLibrary* Self, char* A, char* B)
	{
		auto _p0 = ConvertFromManage_FName(A);
		auto _p1 = ConvertFromManage_FName(B);
		return Self->EqualEqual_NameName(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_EqualEqual_ObjectObject(UKismetMathLibrary* Self, UObject* A, UObject* B)
	{
		auto _p0 = A;
		auto _p1 = B;
		return Self->EqualEqual_ObjectObject(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_EqualEqual_QuatQuat(UKismetMathLibrary* Self, INT_PTR A, INT_PTR B, float Tolerance)
	{
		auto& _p0 = *(FQuat*)A;
		auto& _p1 = *(FQuat*)B;
		auto _p2 = Tolerance;
		return Self->EqualEqual_QuatQuat(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_EqualEqual_RotatorRotator(UKismetMathLibrary* Self, INT_PTR A, INT_PTR B, float ErrorTolerance)
	{
		auto _p0 = *(FRotator*)A;
		auto _p1 = *(FRotator*)B;
		auto _p2 = ErrorTolerance;
		return Self->EqualEqual_RotatorRotator(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_EqualEqual_TransformTransform(UKismetMathLibrary* Self, INT_PTR A, INT_PTR B)
	{
		auto& _p0 = *(FTransform*)A;
		auto& _p1 = *(FTransform*)B;
		return Self->EqualEqual_TransformTransform(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_EqualEqual_Vector2DVector2D(UKismetMathLibrary* Self, INT_PTR A, INT_PTR B, float ErrorTolerance)
	{
		auto _p0 = *(FVector2D*)A;
		auto _p1 = *(FVector2D*)B;
		auto _p2 = ErrorTolerance;
		return Self->EqualEqual_Vector2DVector2D(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_EqualEqual_Vector4Vector4(UKismetMathLibrary* Self, INT_PTR A, INT_PTR B, float ErrorTolerance)
	{
		auto& _p0 = *(FVector4*)A;
		auto& _p1 = *(FVector4*)B;
		auto _p2 = ErrorTolerance;
		return Self->EqualEqual_Vector4Vector4(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_EqualEqual_VectorVector(UKismetMathLibrary* Self, INT_PTR A, INT_PTR B, float ErrorTolerance)
	{
		auto _p0 = *(FVector*)A;
		auto _p1 = *(FVector*)B;
		auto _p2 = ErrorTolerance;
		return Self->EqualEqual_VectorVector(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_EqualExactly_Vector2DVector2D(UKismetMathLibrary* Self, INT_PTR A, INT_PTR B)
	{
		auto _p0 = *(FVector2D*)A;
		auto _p1 = *(FVector2D*)B;
		return Self->EqualExactly_Vector2DVector2D(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_EqualExactly_Vector4Vector4(UKismetMathLibrary* Self, INT_PTR A, INT_PTR B)
	{
		auto& _p0 = *(FVector4*)A;
		auto& _p1 = *(FVector4*)B;
		return Self->EqualExactly_Vector4Vector4(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_EqualExactly_VectorVector(UKismetMathLibrary* Self, INT_PTR A, INT_PTR B)
	{
		auto _p0 = *(FVector*)A;
		auto _p1 = *(FVector*)B;
		return Self->EqualExactly_VectorVector(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Exp(UKismetMathLibrary* Self, float A)
	{
		auto _p0 = A;
		return Self->Exp(_p0);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_FCeil(UKismetMathLibrary* Self, float A)
	{
		auto _p0 = A;
		return Self->FCeil(_p0);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_FCeil64(UKismetMathLibrary* Self, float A)
	{
		auto _p0 = A;
		return Self->FCeil64(_p0);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_FClamp(UKismetMathLibrary* Self, float Value, float Min, float Max)
	{
		auto _p0 = Value;
		auto _p1 = Min;
		auto _p2 = Max;
		return Self->FClamp(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_FFloor(UKismetMathLibrary* Self, float A)
	{
		auto _p0 = A;
		return Self->FFloor(_p0);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_FFloor64(UKismetMathLibrary* Self, float A)
	{
		auto _p0 = A;
		return Self->FFloor64(_p0);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_FindClosestPointOnLine(UKismetMathLibrary* Self, INT_PTR Point, INT_PTR LineOrigin, INT_PTR LineDirection)
	{
		auto _p0 = *(FVector*)Point;
		auto _p1 = *(FVector*)LineOrigin;
		auto _p2 = *(FVector*)LineDirection;
		return (INT_PTR) new FVector(Self->FindClosestPointOnLine(_p0, _p1, _p2));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_FindClosestPointOnSegment(UKismetMathLibrary* Self, INT_PTR Point, INT_PTR SegmentStart, INT_PTR SegmentEnd)
	{
		auto _p0 = *(FVector*)Point;
		auto _p1 = *(FVector*)SegmentStart;
		auto _p2 = *(FVector*)SegmentEnd;
		return (INT_PTR) new FVector(Self->FindClosestPointOnSegment(_p0, _p1, _p2));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_FindLookAtRotation(UKismetMathLibrary* Self, INT_PTR Start, INT_PTR Target)
	{
		auto& _p0 = *(FVector*)Start;
		auto& _p1 = *(FVector*)Target;
		return (INT_PTR) new FRotator(Self->FindLookAtRotation(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_FindNearestPointsOnLineSegments(UKismetMathLibrary* Self, INT_PTR Segment1Start, INT_PTR Segment1End, INT_PTR Segment2Start, INT_PTR Segment2End, INT_PTR Segment1Point, INT_PTR Segment2Point)
	{
		auto _p0 = *(FVector*)Segment1Start;
		auto _p1 = *(FVector*)Segment1End;
		auto _p2 = *(FVector*)Segment2Start;
		auto _p3 = *(FVector*)Segment2End;
		auto& _p4 = *(FVector*)Segment1Point;
		auto& _p5 = *(FVector*)Segment2Point;
		Self->FindNearestPointsOnLineSegments(_p0, _p1, _p2, _p3, _p4, _p5);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_FInterpEaseInOut(UKismetMathLibrary* Self, float A, float B, float Alpha, float Exponent)
	{
		auto _p0 = A;
		auto _p1 = B;
		auto _p2 = Alpha;
		auto _p3 = Exponent;
		return Self->FInterpEaseInOut(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_FInterpTo(UKismetMathLibrary* Self, float Current, float Target, float DeltaTime, float InterpSpeed)
	{
		auto _p0 = Current;
		auto _p1 = Target;
		auto _p2 = DeltaTime;
		auto _p3 = InterpSpeed;
		return Self->FInterpTo(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_FInterpTo_Constant(UKismetMathLibrary* Self, float Current, float Target, float DeltaTime, float InterpSpeed)
	{
		auto _p0 = Current;
		auto _p1 = Target;
		auto _p2 = DeltaTime;
		auto _p3 = InterpSpeed;
		return Self->FInterpTo_Constant(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_FixedTurn(UKismetMathLibrary* Self, float InCurrent, float InDesired, float InDeltaRate)
	{
		auto _p0 = InCurrent;
		auto _p1 = InDesired;
		auto _p2 = InDeltaRate;
		return Self->FixedTurn(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_FloatSpringInterp(UKismetMathLibrary* Self, float Current, float Target, INT_PTR SpringState, float Stiffness, float CriticalDampingFactor, float DeltaTime, float Mass)
	{
		auto _p0 = Current;
		auto _p1 = Target;
		auto& _p2 = *(FFloatSpringState*)SpringState;
		auto _p3 = Stiffness;
		auto _p4 = CriticalDampingFactor;
		auto _p5 = DeltaTime;
		auto _p6 = Mass;
		return Self->FloatSpringInterp(_p0, _p1, _p2, _p3, _p4, _p5, _p6);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_FMax(UKismetMathLibrary* Self, float A, float B)
	{
		auto _p0 = A;
		auto _p1 = B;
		return Self->FMax(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_FMin(UKismetMathLibrary* Self, float A, float B)
	{
		auto _p0 = A;
		auto _p1 = B;
		return Self->FMin(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_FMod(UKismetMathLibrary* Self, float Dividend, float Divisor, float Remainder)
	{
		auto _p0 = Dividend;
		auto _p1 = Divisor;
		auto& _p2 = Remainder;
		return Self->FMod(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Fraction(UKismetMathLibrary* Self, float A)
	{
		auto _p0 = A;
		return Self->Fraction(_p0);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_FTrunc(UKismetMathLibrary* Self, float A)
	{
		auto _p0 = A;
		return Self->FTrunc(_p0);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_FTrunc64(UKismetMathLibrary* Self, float A)
	{
		auto _p0 = A;
		return Self->FTrunc64(_p0);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_FTruncVector(UKismetMathLibrary* Self, INT_PTR InVector)
	{
		auto& _p0 = *(FVector*)InVector;
		return (INT_PTR) new FIntVector(Self->FTruncVector(_p0));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_GenericDivide_FloatFloat(UKismetMathLibrary* Self, float A, float B)
	{
		auto _p0 = A;
		auto _p1 = B;
		return Self->GenericDivide_FloatFloat(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_GenericPercent_FloatFloat(UKismetMathLibrary* Self, float A, float B)
	{
		auto _p0 = A;
		auto _p1 = B;
		return Self->GenericPercent_FloatFloat(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_GetAbs2D(UKismetMathLibrary* Self, INT_PTR A)
	{
		auto _p0 = *(FVector2D*)A;
		return (INT_PTR) new FVector2D(Self->GetAbs2D(_p0));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_GetAbsMax2D(UKismetMathLibrary* Self, INT_PTR A)
	{
		auto _p0 = *(FVector2D*)A;
		return Self->GetAbsMax2D(_p0);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_GetAxes(UKismetMathLibrary* Self, INT_PTR A, INT_PTR X, INT_PTR Y, INT_PTR Z)
	{
		auto _p0 = *(FRotator*)A;
		auto& _p1 = *(FVector*)X;
		auto& _p2 = *(FVector*)Y;
		auto& _p3 = *(FVector*)Z;
		Self->GetAxes(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_GetAzimuthAndElevation(UKismetMathLibrary* Self, INT_PTR InDirection, INT_PTR ReferenceFrame, float Azimuth, float Elevation)
	{
		auto _p0 = *(FVector*)InDirection;
		auto& _p1 = *(FTransform*)ReferenceFrame;
		auto& _p2 = Azimuth;
		auto& _p3 = Elevation;
		Self->GetAzimuthAndElevation(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_GetDirectionUnitVector(UKismetMathLibrary* Self, INT_PTR From, INT_PTR To)
	{
		auto _p0 = *(FVector*)From;
		auto _p1 = *(FVector*)To;
		return (INT_PTR) new FVector(Self->GetDirectionUnitVector(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_GetForwardVector(UKismetMathLibrary* Self, INT_PTR InRot)
	{
		auto _p0 = *(FRotator*)InRot;
		return (INT_PTR) new FVector(Self->GetForwardVector(_p0));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_GetMax2D(UKismetMathLibrary* Self, INT_PTR A)
	{
		auto _p0 = *(FVector2D*)A;
		return Self->GetMax2D(_p0);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_GetMaxElement(UKismetMathLibrary* Self, INT_PTR A)
	{
		auto _p0 = *(FVector*)A;
		return Self->GetMaxElement(_p0);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_GetMin2D(UKismetMathLibrary* Self, INT_PTR A)
	{
		auto _p0 = *(FVector2D*)A;
		return Self->GetMin2D(_p0);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_GetMinElement(UKismetMathLibrary* Self, INT_PTR A)
	{
		auto _p0 = *(FVector*)A;
		return Self->GetMinElement(_p0);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_GetPI(UKismetMathLibrary* Self)
	{
		return Self->GetPI();
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_GetPointDistanceToLine(UKismetMathLibrary* Self, INT_PTR Point, INT_PTR LineOrigin, INT_PTR LineDirection)
	{
		auto _p0 = *(FVector*)Point;
		auto _p1 = *(FVector*)LineOrigin;
		auto _p2 = *(FVector*)LineDirection;
		return Self->GetPointDistanceToLine(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_GetPointDistanceToSegment(UKismetMathLibrary* Self, INT_PTR Point, INT_PTR SegmentStart, INT_PTR SegmentEnd)
	{
		auto _p0 = *(FVector*)Point;
		auto _p1 = *(FVector*)SegmentStart;
		auto _p2 = *(FVector*)SegmentEnd;
		return Self->GetPointDistanceToSegment(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_GetReflectionVector(UKismetMathLibrary* Self, INT_PTR Direction, INT_PTR SurfaceNormal)
	{
		auto _p0 = *(FVector*)Direction;
		auto _p1 = *(FVector*)SurfaceNormal;
		return (INT_PTR) new FVector(Self->GetReflectionVector(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_GetRightVector(UKismetMathLibrary* Self, INT_PTR InRot)
	{
		auto _p0 = *(FRotator*)InRot;
		return (INT_PTR) new FVector(Self->GetRightVector(_p0));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_GetRotated2D(UKismetMathLibrary* Self, INT_PTR A, float AngleDeg)
	{
		auto _p0 = *(FVector2D*)A;
		auto _p1 = AngleDeg;
		return (INT_PTR) new FVector2D(Self->GetRotated2D(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_GetSlopeDegreeAngles(UKismetMathLibrary* Self, INT_PTR MyRightYAxis, INT_PTR FloorNormal, INT_PTR UpVector, float OutSlopePitchDegreeAngle, float OutSlopeRollDegreeAngle)
	{
		auto& _p0 = *(FVector*)MyRightYAxis;
		auto& _p1 = *(FVector*)FloorNormal;
		auto& _p2 = *(FVector*)UpVector;
		auto& _p3 = OutSlopePitchDegreeAngle;
		auto& _p4 = OutSlopeRollDegreeAngle;
		Self->GetSlopeDegreeAngles(_p0, _p1, _p2, _p3, _p4);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_GetTAU(UKismetMathLibrary* Self)
	{
		return Self->GetTAU();
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_GetUpVector(UKismetMathLibrary* Self, INT_PTR InRot)
	{
		auto _p0 = *(FRotator*)InRot;
		return (INT_PTR) new FVector(Self->GetUpVector(_p0));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_GetYawPitchFromVector(UKismetMathLibrary* Self, INT_PTR InVec, float Yaw, float Pitch)
	{
		auto _p0 = *(FVector*)InVec;
		auto& _p1 = Yaw;
		auto& _p2 = Pitch;
		Self->GetYawPitchFromVector(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Greater_ByteByte(UKismetMathLibrary* Self, uint8 A, uint8 B)
	{
		auto _p0 = A;
		auto _p1 = B;
		return Self->Greater_ByteByte(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Greater_FloatFloat(UKismetMathLibrary* Self, float A, float B)
	{
		auto _p0 = A;
		auto _p1 = B;
		return Self->Greater_FloatFloat(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Greater_Int64Int64(UKismetMathLibrary* Self, int64 A, int64 B)
	{
		auto _p0 = A;
		auto _p1 = B;
		return Self->Greater_Int64Int64(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Greater_IntInt(UKismetMathLibrary* Self, int32 A, int32 B)
	{
		auto _p0 = A;
		auto _p1 = B;
		return Self->Greater_IntInt(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_GreaterEqual_ByteByte(UKismetMathLibrary* Self, uint8 A, uint8 B)
	{
		auto _p0 = A;
		auto _p1 = B;
		return Self->GreaterEqual_ByteByte(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_GreaterEqual_FloatFloat(UKismetMathLibrary* Self, float A, float B)
	{
		auto _p0 = A;
		auto _p1 = B;
		return Self->GreaterEqual_FloatFloat(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_GreaterEqual_Int64Int64(UKismetMathLibrary* Self, int64 A, int64 B)
	{
		auto _p0 = A;
		auto _p1 = B;
		return Self->GreaterEqual_Int64Int64(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_GreaterEqual_IntInt(UKismetMathLibrary* Self, int32 A, int32 B)
	{
		auto _p0 = A;
		auto _p1 = B;
		return Self->GreaterEqual_IntInt(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_GreaterGreater_VectorRotator(UKismetMathLibrary* Self, INT_PTR A, INT_PTR B)
	{
		auto _p0 = *(FVector*)A;
		auto _p1 = *(FRotator*)B;
		return (INT_PTR) new FVector(Self->GreaterGreater_VectorRotator(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_GridSnap_Float(UKismetMathLibrary* Self, float Location, float GridSize)
	{
		auto _p0 = Location;
		auto _p1 = GridSize;
		return Self->GridSnap_Float(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_HSVToRGB(UKismetMathLibrary* Self, float H, float S, float V, float A)
	{
		auto _p0 = H;
		auto _p1 = S;
		auto _p2 = V;
		auto _p3 = A;
		return (INT_PTR) new FLinearColor(Self->HSVToRGB(_p0, _p1, _p2, _p3));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_HSVToRGB_Vector(UKismetMathLibrary* Self, INT_PTR HSV, INT_PTR RGB)
	{
		auto _p0 = *(FLinearColor*)HSV;
		auto& _p1 = *(FLinearColor*)RGB;
		Self->HSVToRGB_Vector(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_HSVToRGBLinear(UKismetMathLibrary* Self, INT_PTR HSV)
	{
		auto _p0 = *(FLinearColor*)HSV;
		return (INT_PTR) new FLinearColor(Self->HSVToRGBLinear(_p0));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Hypotenuse(UKismetMathLibrary* Self, float Width, float Height)
	{
		auto _p0 = Width;
		auto _p1 = Height;
		return Self->Hypotenuse(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_InRange_FloatFloat(UKismetMathLibrary* Self, float Value, float Min, float Max, bool InclusiveMin, bool InclusiveMax)
	{
		auto _p0 = Value;
		auto _p1 = Min;
		auto _p2 = Max;
		auto _p3 = InclusiveMin;
		auto _p4 = InclusiveMax;
		return Self->InRange_FloatFloat(_p0, _p1, _p2, _p3, _p4);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_InRange_Int64Int64(UKismetMathLibrary* Self, int64 Value, int64 Min, int64 Max, bool InclusiveMin, bool InclusiveMax)
	{
		auto _p0 = Value;
		auto _p1 = Min;
		auto _p2 = Max;
		auto _p3 = InclusiveMin;
		auto _p4 = InclusiveMax;
		return Self->InRange_Int64Int64(_p0, _p1, _p2, _p3, _p4);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_InRange_IntInt(UKismetMathLibrary* Self, int32 Value, int32 Min, int32 Max, bool InclusiveMin, bool InclusiveMax)
	{
		auto _p0 = Value;
		auto _p1 = Min;
		auto _p2 = Max;
		auto _p3 = InclusiveMin;
		auto _p4 = InclusiveMax;
		return Self->InRange_IntInt(_p0, _p1, _p2, _p3, _p4);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_InverseLerp(UKismetMathLibrary* Self, float A, float B, float Value)
	{
		auto _p0 = A;
		auto _p1 = B;
		auto _p2 = Value;
		return Self->InverseLerp(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_InverseTransformDirection(UKismetMathLibrary* Self, INT_PTR T, INT_PTR Direction)
	{
		auto& _p0 = *(FTransform*)T;
		auto _p1 = *(FVector*)Direction;
		return (INT_PTR) new FVector(Self->InverseTransformDirection(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_InverseTransformLocation(UKismetMathLibrary* Self, INT_PTR T, INT_PTR Location)
	{
		auto& _p0 = *(FTransform*)T;
		auto _p1 = *(FVector*)Location;
		return (INT_PTR) new FVector(Self->InverseTransformLocation(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_InverseTransformRotation(UKismetMathLibrary* Self, INT_PTR T, INT_PTR Rotation)
	{
		auto& _p0 = *(FTransform*)T;
		auto _p1 = *(FRotator*)Rotation;
		return (INT_PTR) new FRotator(Self->InverseTransformRotation(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_InvertTransform(UKismetMathLibrary* Self, INT_PTR T)
	{
		auto& _p0 = *(FTransform*)T;
		return (INT_PTR) new FTransform(Self->InvertTransform(_p0));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_IsLeapYear(UKismetMathLibrary* Self, int32 Year)
	{
		auto _p0 = Year;
		return Self->IsLeapYear(_p0);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_IsNearlyZero2D(UKismetMathLibrary* Self, INT_PTR A, float Tolerance)
	{
		auto& _p0 = *(FVector2D*)A;
		auto _p1 = Tolerance;
		return Self->IsNearlyZero2D(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_IsPointInBox(UKismetMathLibrary* Self, INT_PTR Point, INT_PTR BoxOrigin, INT_PTR BoxExtent)
	{
		auto _p0 = *(FVector*)Point;
		auto _p1 = *(FVector*)BoxOrigin;
		auto _p2 = *(FVector*)BoxExtent;
		return Self->IsPointInBox(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_IsPointInBoxWithTransform(UKismetMathLibrary* Self, INT_PTR Point, INT_PTR BoxWorldTransform, INT_PTR BoxExtent)
	{
		auto _p0 = *(FVector*)Point;
		auto& _p1 = *(FTransform*)BoxWorldTransform;
		auto _p2 = *(FVector*)BoxExtent;
		return Self->IsPointInBoxWithTransform(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_IsZero2D(UKismetMathLibrary* Self, INT_PTR A)
	{
		auto& _p0 = *(FVector2D*)A;
		return Self->IsZero2D(_p0);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Lerp(UKismetMathLibrary* Self, float A, float B, float Alpha)
	{
		auto _p0 = A;
		auto _p1 = B;
		auto _p2 = Alpha;
		return Self->Lerp(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Less_ByteByte(UKismetMathLibrary* Self, uint8 A, uint8 B)
	{
		auto _p0 = A;
		auto _p1 = B;
		return Self->Less_ByteByte(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Less_FloatFloat(UKismetMathLibrary* Self, float A, float B)
	{
		auto _p0 = A;
		auto _p1 = B;
		return Self->Less_FloatFloat(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Less_Int64Int64(UKismetMathLibrary* Self, int64 A, int64 B)
	{
		auto _p0 = A;
		auto _p1 = B;
		return Self->Less_Int64Int64(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Less_IntInt(UKismetMathLibrary* Self, int32 A, int32 B)
	{
		auto _p0 = A;
		auto _p1 = B;
		return Self->Less_IntInt(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_LessEqual_ByteByte(UKismetMathLibrary* Self, uint8 A, uint8 B)
	{
		auto _p0 = A;
		auto _p1 = B;
		return Self->LessEqual_ByteByte(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_LessEqual_FloatFloat(UKismetMathLibrary* Self, float A, float B)
	{
		auto _p0 = A;
		auto _p1 = B;
		return Self->LessEqual_FloatFloat(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_LessEqual_Int64Int64(UKismetMathLibrary* Self, int64 A, int64 B)
	{
		auto _p0 = A;
		auto _p1 = B;
		return Self->LessEqual_Int64Int64(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_LessEqual_IntInt(UKismetMathLibrary* Self, int32 A, int32 B)
	{
		auto _p0 = A;
		auto _p1 = B;
		return Self->LessEqual_IntInt(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_LessLess_VectorRotator(UKismetMathLibrary* Self, INT_PTR A, INT_PTR B)
	{
		auto _p0 = *(FVector*)A;
		auto _p1 = *(FRotator*)B;
		return (INT_PTR) new FVector(Self->LessLess_VectorRotator(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_LinearColor_Black(UKismetMathLibrary* Self)
	{
		return (INT_PTR) new FLinearColor(Self->LinearColor_Black());
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_LinearColor_Blue(UKismetMathLibrary* Self)
	{
		return (INT_PTR) new FLinearColor(Self->LinearColor_Blue());
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_LinearColor_Desaturated(UKismetMathLibrary* Self, INT_PTR InColor, float InDesaturation)
	{
		auto _p0 = *(FLinearColor*)InColor;
		auto _p1 = InDesaturation;
		return (INT_PTR) new FLinearColor(Self->LinearColor_Desaturated(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_LinearColor_Distance(UKismetMathLibrary* Self, INT_PTR C1, INT_PTR C2)
	{
		auto _p0 = *(FLinearColor*)C1;
		auto _p1 = *(FLinearColor*)C2;
		return Self->LinearColor_Distance(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_LinearColor_GetLuminance(UKismetMathLibrary* Self, INT_PTR InColor)
	{
		auto _p0 = *(FLinearColor*)InColor;
		return Self->LinearColor_GetLuminance(_p0);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_LinearColor_GetMax(UKismetMathLibrary* Self, INT_PTR InColor)
	{
		auto _p0 = *(FLinearColor*)InColor;
		return Self->LinearColor_GetMax(_p0);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_LinearColor_GetMin(UKismetMathLibrary* Self, INT_PTR InColor)
	{
		auto _p0 = *(FLinearColor*)InColor;
		return Self->LinearColor_GetMin(_p0);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_LinearColor_Gray(UKismetMathLibrary* Self)
	{
		return (INT_PTR) new FLinearColor(Self->LinearColor_Gray());
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_LinearColor_Green(UKismetMathLibrary* Self)
	{
		return (INT_PTR) new FLinearColor(Self->LinearColor_Green());
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_LinearColor_IsNearEqual(UKismetMathLibrary* Self, INT_PTR A, INT_PTR B, float Tolerance)
	{
		auto _p0 = *(FLinearColor*)A;
		auto _p1 = *(FLinearColor*)B;
		auto _p2 = Tolerance;
		return Self->LinearColor_IsNearEqual(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_LinearColor_Red(UKismetMathLibrary* Self)
	{
		return (INT_PTR) new FLinearColor(Self->LinearColor_Red());
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_LinearColor_Set(UKismetMathLibrary* Self, INT_PTR InOutColor, INT_PTR InColor)
	{
		auto& _p0 = *(FLinearColor*)InOutColor;
		auto _p1 = *(FLinearColor*)InColor;
		Self->LinearColor_Set(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_LinearColor_SetFromHSV(UKismetMathLibrary* Self, INT_PTR InOutColor, float H, float S, float V, float A)
	{
		auto& _p0 = *(FLinearColor*)InOutColor;
		auto _p1 = H;
		auto _p2 = S;
		auto _p3 = V;
		auto _p4 = A;
		Self->LinearColor_SetFromHSV(_p0, _p1, _p2, _p3, _p4);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_LinearColor_SetRandomHue(UKismetMathLibrary* Self, INT_PTR InOutColor)
	{
		auto& _p0 = *(FLinearColor*)InOutColor;
		Self->LinearColor_SetRandomHue(_p0);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_LinearColor_SetRGBA(UKismetMathLibrary* Self, INT_PTR InOutColor, float R, float G, float B, float A)
	{
		auto& _p0 = *(FLinearColor*)InOutColor;
		auto _p1 = R;
		auto _p2 = G;
		auto _p3 = B;
		auto _p4 = A;
		Self->LinearColor_SetRGBA(_p0, _p1, _p2, _p3, _p4);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_LinearColor_SetTemperature(UKismetMathLibrary* Self, INT_PTR InOutColor, float InTemperature)
	{
		auto& _p0 = *(FLinearColor*)InOutColor;
		auto _p1 = InTemperature;
		Self->LinearColor_SetTemperature(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_LinearColor_ToNewOpacity(UKismetMathLibrary* Self, INT_PTR InColor, float InOpacity)
	{
		auto _p0 = *(FLinearColor*)InColor;
		auto _p1 = InOpacity;
		return (INT_PTR) new FLinearColor(Self->LinearColor_ToNewOpacity(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_LinearColor_Transparent(UKismetMathLibrary* Self)
	{
		return (INT_PTR) new FLinearColor(Self->LinearColor_Transparent());
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_LinearColor_White(UKismetMathLibrary* Self)
	{
		return (INT_PTR) new FLinearColor(Self->LinearColor_White());
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_LinearColor_Yellow(UKismetMathLibrary* Self)
	{
		return (INT_PTR) new FLinearColor(Self->LinearColor_Yellow());
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_LinearColorLerp(UKismetMathLibrary* Self, INT_PTR A, INT_PTR B, float Alpha)
	{
		auto _p0 = *(FLinearColor*)A;
		auto _p1 = *(FLinearColor*)B;
		auto _p2 = Alpha;
		return (INT_PTR) new FLinearColor(Self->LinearColorLerp(_p0, _p1, _p2));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_LinearColorLerpUsingHSV(UKismetMathLibrary* Self, INT_PTR A, INT_PTR B, float Alpha)
	{
		auto _p0 = *(FLinearColor*)A;
		auto _p1 = *(FLinearColor*)B;
		auto _p2 = Alpha;
		return (INT_PTR) new FLinearColor(Self->LinearColorLerpUsingHSV(_p0, _p1, _p2));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_LinePlaneIntersection(UKismetMathLibrary* Self, INT_PTR LineStart, INT_PTR LineEnd, INT_PTR APlane, float T, INT_PTR Intersection)
	{
		auto& _p0 = *(FVector*)LineStart;
		auto& _p1 = *(FVector*)LineEnd;
		auto& _p2 = *(FPlane*)APlane;
		auto& _p3 = T;
		auto& _p4 = *(FVector*)Intersection;
		return Self->LinePlaneIntersection(_p0, _p1, _p2, _p3, _p4);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_LinePlaneIntersection_OriginNormal(UKismetMathLibrary* Self, INT_PTR LineStart, INT_PTR LineEnd, INT_PTR PlaneOrigin, INT_PTR PlaneNormal, float T, INT_PTR Intersection)
	{
		auto& _p0 = *(FVector*)LineStart;
		auto& _p1 = *(FVector*)LineEnd;
		auto _p2 = *(FVector*)PlaneOrigin;
		auto _p3 = *(FVector*)PlaneNormal;
		auto& _p4 = T;
		auto& _p5 = *(FVector*)Intersection;
		return Self->LinePlaneIntersection_OriginNormal(_p0, _p1, _p2, _p3, _p4, _p5);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Loge(UKismetMathLibrary* Self, float A)
	{
		auto _p0 = A;
		return Self->Loge(_p0);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_MakeBox(UKismetMathLibrary* Self, INT_PTR Min, INT_PTR Max)
	{
		auto _p0 = *(FVector*)Min;
		auto _p1 = *(FVector*)Max;
		return (INT_PTR) new FBox(Self->MakeBox(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_MakeBox2D(UKismetMathLibrary* Self, INT_PTR Min, INT_PTR Max)
	{
		auto _p0 = *(FVector2D*)Min;
		auto _p1 = *(FVector2D*)Max;
		return (INT_PTR) new FBox2D(Self->MakeBox2D(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_MakeColor(UKismetMathLibrary* Self, float R, float G, float B, float A)
	{
		auto _p0 = R;
		auto _p1 = G;
		auto _p2 = B;
		auto _p3 = A;
		return (INT_PTR) new FLinearColor(Self->MakeColor(_p0, _p1, _p2, _p3));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_MakePlaneFromPointAndNormal(UKismetMathLibrary* Self, INT_PTR Point, INT_PTR Normal)
	{
		auto _p0 = *(FVector*)Point;
		auto _p1 = *(FVector*)Normal;
		return (INT_PTR) new FPlane(Self->MakePlaneFromPointAndNormal(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_MakePulsatingValue(UKismetMathLibrary* Self, float InCurrentTime, float InPulsesPerSecond, float InPhase)
	{
		auto _p0 = InCurrentTime;
		auto _p1 = InPulsesPerSecond;
		auto _p2 = InPhase;
		return Self->MakePulsatingValue(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_MakeRandomStream(UKismetMathLibrary* Self, int32 InitialSeed)
	{
		auto _p0 = InitialSeed;
		return (INT_PTR) new FRandomStream(Self->MakeRandomStream(_p0));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_MakeRelativeTransform(UKismetMathLibrary* Self, INT_PTR A, INT_PTR RelativeTo)
	{
		auto& _p0 = *(FTransform*)A;
		auto& _p1 = *(FTransform*)RelativeTo;
		return (INT_PTR) new FTransform(Self->MakeRelativeTransform(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_MakeRotationFromAxes(UKismetMathLibrary* Self, INT_PTR Forward, INT_PTR Right, INT_PTR Up)
	{
		auto _p0 = *(FVector*)Forward;
		auto _p1 = *(FVector*)Right;
		auto _p2 = *(FVector*)Up;
		return (INT_PTR) new FRotator(Self->MakeRotationFromAxes(_p0, _p1, _p2));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_MakeRotator(UKismetMathLibrary* Self, float Roll, float Pitch, float Yaw)
	{
		auto _p0 = Roll;
		auto _p1 = Pitch;
		auto _p2 = Yaw;
		return (INT_PTR) new FRotator(Self->MakeRotator(_p0, _p1, _p2));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_MakeRotFromX(UKismetMathLibrary* Self, INT_PTR X)
	{
		auto& _p0 = *(FVector*)X;
		return (INT_PTR) new FRotator(Self->MakeRotFromX(_p0));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_MakeRotFromXY(UKismetMathLibrary* Self, INT_PTR X, INT_PTR Y)
	{
		auto& _p0 = *(FVector*)X;
		auto& _p1 = *(FVector*)Y;
		return (INT_PTR) new FRotator(Self->MakeRotFromXY(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_MakeRotFromXZ(UKismetMathLibrary* Self, INT_PTR X, INT_PTR Z)
	{
		auto& _p0 = *(FVector*)X;
		auto& _p1 = *(FVector*)Z;
		return (INT_PTR) new FRotator(Self->MakeRotFromXZ(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_MakeRotFromY(UKismetMathLibrary* Self, INT_PTR Y)
	{
		auto& _p0 = *(FVector*)Y;
		return (INT_PTR) new FRotator(Self->MakeRotFromY(_p0));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_MakeRotFromYX(UKismetMathLibrary* Self, INT_PTR Y, INT_PTR X)
	{
		auto& _p0 = *(FVector*)Y;
		auto& _p1 = *(FVector*)X;
		return (INT_PTR) new FRotator(Self->MakeRotFromYX(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_MakeRotFromYZ(UKismetMathLibrary* Self, INT_PTR Y, INT_PTR Z)
	{
		auto& _p0 = *(FVector*)Y;
		auto& _p1 = *(FVector*)Z;
		return (INT_PTR) new FRotator(Self->MakeRotFromYZ(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_MakeRotFromZ(UKismetMathLibrary* Self, INT_PTR Z)
	{
		auto& _p0 = *(FVector*)Z;
		return (INT_PTR) new FRotator(Self->MakeRotFromZ(_p0));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_MakeRotFromZX(UKismetMathLibrary* Self, INT_PTR Z, INT_PTR X)
	{
		auto& _p0 = *(FVector*)Z;
		auto& _p1 = *(FVector*)X;
		return (INT_PTR) new FRotator(Self->MakeRotFromZX(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_MakeRotFromZY(UKismetMathLibrary* Self, INT_PTR Z, INT_PTR Y)
	{
		auto& _p0 = *(FVector*)Z;
		auto& _p1 = *(FVector*)Y;
		return (INT_PTR) new FRotator(Self->MakeRotFromZY(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_MakeTransform(UKismetMathLibrary* Self, INT_PTR Location, INT_PTR Rotation, INT_PTR Scale)
	{
		auto _p0 = *(FVector*)Location;
		auto _p1 = *(FRotator*)Rotation;
		auto _p2 = *(FVector*)Scale;
		return (INT_PTR) new FTransform(Self->MakeTransform(_p0, _p1, _p2));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_MakeVector(UKismetMathLibrary* Self, float X, float Y, float Z)
	{
		auto _p0 = X;
		auto _p1 = Y;
		auto _p2 = Z;
		return (INT_PTR) new FVector(Self->MakeVector(_p0, _p1, _p2));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_MakeVector2D(UKismetMathLibrary* Self, float X, float Y)
	{
		auto _p0 = X;
		auto _p1 = Y;
		return (INT_PTR) new FVector2D(Self->MakeVector2D(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_MakeVector4(UKismetMathLibrary* Self, float X, float Y, float Z, float W)
	{
		auto _p0 = X;
		auto _p1 = Y;
		auto _p2 = Z;
		auto _p3 = W;
		return (INT_PTR) new FVector4(Self->MakeVector4(_p0, _p1, _p2, _p3));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_MapRangeClamped(UKismetMathLibrary* Self, float Value, float InRangeA, float InRangeB, float OutRangeA, float OutRangeB)
	{
		auto _p0 = Value;
		auto _p1 = InRangeA;
		auto _p2 = InRangeB;
		auto _p3 = OutRangeA;
		auto _p4 = OutRangeB;
		return Self->MapRangeClamped(_p0, _p1, _p2, _p3, _p4);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_MapRangeUnclamped(UKismetMathLibrary* Self, float Value, float InRangeA, float InRangeB, float OutRangeA, float OutRangeB)
	{
		auto _p0 = Value;
		auto _p1 = InRangeA;
		auto _p2 = InRangeB;
		auto _p3 = OutRangeA;
		auto _p4 = OutRangeB;
		return Self->MapRangeUnclamped(_p0, _p1, _p2, _p3, _p4);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Matrix_GetOrigin(UKismetMathLibrary* Self, INT_PTR InMatrix)
	{
		auto& _p0 = *(FMatrix*)InMatrix;
		return (INT_PTR) new FVector(Self->Matrix_GetOrigin(_p0));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Max(UKismetMathLibrary* Self, int32 A, int32 B)
	{
		auto _p0 = A;
		auto _p1 = B;
		return Self->Max(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_MaxInt64(UKismetMathLibrary* Self, int64 A, int64 B)
	{
		auto _p0 = A;
		auto _p1 = B;
		return Self->MaxInt64(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Min(UKismetMathLibrary* Self, int32 A, int32 B)
	{
		auto _p0 = A;
		auto _p1 = B;
		return Self->Min(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_MinInt64(UKismetMathLibrary* Self, int64 A, int64 B)
	{
		auto _p0 = A;
		auto _p1 = B;
		return Self->MinInt64(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_MirrorVectorByNormal(UKismetMathLibrary* Self, INT_PTR InVect, INT_PTR InNormal)
	{
		auto _p0 = *(FVector*)InVect;
		auto _p1 = *(FVector*)InNormal;
		return (INT_PTR) new FVector(Self->MirrorVectorByNormal(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Multiply_ByteByte(UKismetMathLibrary* Self, uint8 A, uint8 B)
	{
		auto _p0 = A;
		auto _p1 = B;
		return Self->Multiply_ByteByte(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Multiply_FloatFloat(UKismetMathLibrary* Self, float A, float B)
	{
		auto _p0 = A;
		auto _p1 = B;
		return Self->Multiply_FloatFloat(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Multiply_Int64Int64(UKismetMathLibrary* Self, int64 A, int64 B)
	{
		auto _p0 = A;
		auto _p1 = B;
		return Self->Multiply_Int64Int64(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Multiply_IntFloat(UKismetMathLibrary* Self, int32 A, float B)
	{
		auto _p0 = A;
		auto _p1 = B;
		return Self->Multiply_IntFloat(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Multiply_IntInt(UKismetMathLibrary* Self, int32 A, int32 B)
	{
		auto _p0 = A;
		auto _p1 = B;
		return Self->Multiply_IntInt(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Multiply_LinearColorFloat(UKismetMathLibrary* Self, INT_PTR A, float B)
	{
		auto _p0 = *(FLinearColor*)A;
		auto _p1 = B;
		return (INT_PTR) new FLinearColor(Self->Multiply_LinearColorFloat(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Multiply_LinearColorLinearColor(UKismetMathLibrary* Self, INT_PTR A, INT_PTR B)
	{
		auto _p0 = *(FLinearColor*)A;
		auto _p1 = *(FLinearColor*)B;
		return (INT_PTR) new FLinearColor(Self->Multiply_LinearColorLinearColor(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Multiply_QuatQuat(UKismetMathLibrary* Self, INT_PTR A, INT_PTR B)
	{
		auto& _p0 = *(FQuat*)A;
		auto& _p1 = *(FQuat*)B;
		return (INT_PTR) new FQuat(Self->Multiply_QuatQuat(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Multiply_RotatorFloat(UKismetMathLibrary* Self, INT_PTR A, float B)
	{
		auto _p0 = *(FRotator*)A;
		auto _p1 = B;
		return (INT_PTR) new FRotator(Self->Multiply_RotatorFloat(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Multiply_RotatorInt(UKismetMathLibrary* Self, INT_PTR A, int32 B)
	{
		auto _p0 = *(FRotator*)A;
		auto _p1 = B;
		return (INT_PTR) new FRotator(Self->Multiply_RotatorInt(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Multiply_Vector2DFloat(UKismetMathLibrary* Self, INT_PTR A, float B)
	{
		auto _p0 = *(FVector2D*)A;
		auto _p1 = B;
		return (INT_PTR) new FVector2D(Self->Multiply_Vector2DFloat(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Multiply_Vector2DVector2D(UKismetMathLibrary* Self, INT_PTR A, INT_PTR B)
	{
		auto _p0 = *(FVector2D*)A;
		auto _p1 = *(FVector2D*)B;
		return (INT_PTR) new FVector2D(Self->Multiply_Vector2DVector2D(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Multiply_Vector4Vector4(UKismetMathLibrary* Self, INT_PTR A, INT_PTR B)
	{
		auto& _p0 = *(FVector4*)A;
		auto& _p1 = *(FVector4*)B;
		return (INT_PTR) new FVector4(Self->Multiply_Vector4Vector4(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Multiply_VectorFloat(UKismetMathLibrary* Self, INT_PTR A, float B)
	{
		auto _p0 = *(FVector*)A;
		auto _p1 = B;
		return (INT_PTR) new FVector(Self->Multiply_VectorFloat(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Multiply_VectorInt(UKismetMathLibrary* Self, INT_PTR A, int32 B)
	{
		auto _p0 = *(FVector*)A;
		auto _p1 = B;
		return (INT_PTR) new FVector(Self->Multiply_VectorInt(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Multiply_VectorVector(UKismetMathLibrary* Self, INT_PTR A, INT_PTR B)
	{
		auto _p0 = *(FVector*)A;
		auto _p1 = *(FVector*)B;
		return (INT_PTR) new FVector(Self->Multiply_VectorVector(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_MultiplyByPi(UKismetMathLibrary* Self, float Value)
	{
		auto _p0 = Value;
		return Self->MultiplyByPi(_p0);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_NearlyEqual_FloatFloat(UKismetMathLibrary* Self, float A, float B, float ErrorTolerance)
	{
		auto _p0 = A;
		auto _p1 = B;
		auto _p2 = ErrorTolerance;
		return Self->NearlyEqual_FloatFloat(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_NearlyEqual_TransformTransform(UKismetMathLibrary* Self, INT_PTR A, INT_PTR B, float LocationTolerance, float RotationTolerance, float Scale3DTolerance)
	{
		auto& _p0 = *(FTransform*)A;
		auto& _p1 = *(FTransform*)B;
		auto _p2 = LocationTolerance;
		auto _p3 = RotationTolerance;
		auto _p4 = Scale3DTolerance;
		return Self->NearlyEqual_TransformTransform(_p0, _p1, _p2, _p3, _p4);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Negated2D(UKismetMathLibrary* Self, INT_PTR A)
	{
		auto& _p0 = *(FVector2D*)A;
		return (INT_PTR) new FVector2D(Self->Negated2D(_p0));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_NegateRotator(UKismetMathLibrary* Self, INT_PTR A)
	{
		auto _p0 = *(FRotator*)A;
		return (INT_PTR) new FRotator(Self->NegateRotator(_p0));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_NegateVector(UKismetMathLibrary* Self, INT_PTR A)
	{
		auto _p0 = *(FVector*)A;
		return (INT_PTR) new FVector(Self->NegateVector(_p0));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Normal(UKismetMathLibrary* Self, INT_PTR A, float Tolerance)
	{
		auto _p0 = *(FVector*)A;
		auto _p1 = Tolerance;
		return (INT_PTR) new FVector(Self->Normal(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Normal2D(UKismetMathLibrary* Self, INT_PTR A)
	{
		auto _p0 = *(FVector2D*)A;
		return (INT_PTR) new FVector2D(Self->Normal2D(_p0));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Normalize2D(UKismetMathLibrary* Self, INT_PTR A, float Tolerance)
	{
		auto& _p0 = *(FVector2D*)A;
		auto _p1 = Tolerance;
		Self->Normalize2D(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_NormalizeAxis(UKismetMathLibrary* Self, float Angle)
	{
		auto _p0 = Angle;
		return Self->NormalizeAxis(_p0);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_NormalizedDeltaRotator(UKismetMathLibrary* Self, INT_PTR A, INT_PTR B)
	{
		auto _p0 = *(FRotator*)A;
		auto _p1 = *(FRotator*)B;
		return (INT_PTR) new FRotator(Self->NormalizedDeltaRotator(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_NormalizeToRange(UKismetMathLibrary* Self, float Value, float RangeMin, float RangeMax)
	{
		auto _p0 = Value;
		auto _p1 = RangeMin;
		auto _p2 = RangeMax;
		return Self->NormalizeToRange(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_NormalSafe2D(UKismetMathLibrary* Self, INT_PTR A, float Tolerance)
	{
		auto _p0 = *(FVector2D*)A;
		auto _p1 = Tolerance;
		return (INT_PTR) new FVector2D(Self->NormalSafe2D(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Not_Int(UKismetMathLibrary* Self, int32 A)
	{
		auto _p0 = A;
		return Self->Not_Int(_p0);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Not_Int64(UKismetMathLibrary* Self, int64 A)
	{
		auto _p0 = A;
		return Self->Not_Int64(_p0);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Not_PreBool(UKismetMathLibrary* Self, bool A)
	{
		auto _p0 = A;
		return Self->Not_PreBool(_p0);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_NotEqual_BoolBool(UKismetMathLibrary* Self, bool A, bool B)
	{
		auto _p0 = A;
		auto _p1 = B;
		return Self->NotEqual_BoolBool(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_NotEqual_ByteByte(UKismetMathLibrary* Self, uint8 A, uint8 B)
	{
		auto _p0 = A;
		auto _p1 = B;
		return Self->NotEqual_ByteByte(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_NotEqual_FloatFloat(UKismetMathLibrary* Self, float A, float B)
	{
		auto _p0 = A;
		auto _p1 = B;
		return Self->NotEqual_FloatFloat(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_NotEqual_Int64Int64(UKismetMathLibrary* Self, int64 A, int64 B)
	{
		auto _p0 = A;
		auto _p1 = B;
		return Self->NotEqual_Int64Int64(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_NotEqual_IntInt(UKismetMathLibrary* Self, int32 A, int32 B)
	{
		auto _p0 = A;
		auto _p1 = B;
		return Self->NotEqual_IntInt(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_NotEqual_LinearColorLinearColor(UKismetMathLibrary* Self, INT_PTR A, INT_PTR B)
	{
		auto _p0 = *(FLinearColor*)A;
		auto _p1 = *(FLinearColor*)B;
		return Self->NotEqual_LinearColorLinearColor(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_NotEqual_NameName(UKismetMathLibrary* Self, char* A, char* B)
	{
		auto _p0 = ConvertFromManage_FName(A);
		auto _p1 = ConvertFromManage_FName(B);
		return Self->NotEqual_NameName(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_NotEqual_ObjectObject(UKismetMathLibrary* Self, UObject* A, UObject* B)
	{
		auto _p0 = A;
		auto _p1 = B;
		return Self->NotEqual_ObjectObject(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_NotEqual_QuatQuat(UKismetMathLibrary* Self, INT_PTR A, INT_PTR B, float ErrorTolerance)
	{
		auto& _p0 = *(FQuat*)A;
		auto& _p1 = *(FQuat*)B;
		auto _p2 = ErrorTolerance;
		return Self->NotEqual_QuatQuat(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_NotEqual_RotatorRotator(UKismetMathLibrary* Self, INT_PTR A, INT_PTR B, float ErrorTolerance)
	{
		auto _p0 = *(FRotator*)A;
		auto _p1 = *(FRotator*)B;
		auto _p2 = ErrorTolerance;
		return Self->NotEqual_RotatorRotator(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_NotEqual_Vector2DVector2D(UKismetMathLibrary* Self, INT_PTR A, INT_PTR B, float ErrorTolerance)
	{
		auto _p0 = *(FVector2D*)A;
		auto _p1 = *(FVector2D*)B;
		auto _p2 = ErrorTolerance;
		return Self->NotEqual_Vector2DVector2D(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_NotEqual_Vector4Vector4(UKismetMathLibrary* Self, INT_PTR A, INT_PTR B, float ErrorTolerance)
	{
		auto& _p0 = *(FVector4*)A;
		auto& _p1 = *(FVector4*)B;
		auto _p2 = ErrorTolerance;
		return Self->NotEqual_Vector4Vector4(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_NotEqual_VectorVector(UKismetMathLibrary* Self, INT_PTR A, INT_PTR B, float ErrorTolerance)
	{
		auto _p0 = *(FVector*)A;
		auto _p1 = *(FVector*)B;
		auto _p2 = ErrorTolerance;
		return Self->NotEqual_VectorVector(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_NotEqualExactly_Vector2DVector2D(UKismetMathLibrary* Self, INT_PTR A, INT_PTR B)
	{
		auto _p0 = *(FVector2D*)A;
		auto _p1 = *(FVector2D*)B;
		return Self->NotEqualExactly_Vector2DVector2D(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_NotEqualExactly_Vector4Vector4(UKismetMathLibrary* Self, INT_PTR A, INT_PTR B)
	{
		auto& _p0 = *(FVector4*)A;
		auto& _p1 = *(FVector4*)B;
		return Self->NotEqualExactly_Vector4Vector4(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_NotEqualExactly_VectorVector(UKismetMathLibrary* Self, INT_PTR A, INT_PTR B)
	{
		auto _p0 = *(FVector*)A;
		auto _p1 = *(FVector*)B;
		return Self->NotEqualExactly_VectorVector(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Or_Int64Int64(UKismetMathLibrary* Self, int64 A, int64 B)
	{
		auto _p0 = A;
		auto _p1 = B;
		return Self->Or_Int64Int64(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Or_IntInt(UKismetMathLibrary* Self, int32 A, int32 B)
	{
		auto _p0 = A;
		auto _p1 = B;
		return Self->Or_IntInt(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Percent_ByteByte(UKismetMathLibrary* Self, uint8 A, uint8 B)
	{
		auto _p0 = A;
		auto _p1 = B;
		return Self->Percent_ByteByte(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Percent_FloatFloat(UKismetMathLibrary* Self, float A, float B)
	{
		auto _p0 = A;
		auto _p1 = B;
		return Self->Percent_FloatFloat(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Percent_IntInt(UKismetMathLibrary* Self, int32 A, int32 B)
	{
		auto _p0 = A;
		auto _p1 = B;
		return Self->Percent_IntInt(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_PerlinNoise1D(UKismetMathLibrary* Self, float Value)
	{
		auto _p0 = Value;
		return Self->PerlinNoise1D(_p0);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_ProjectPointOnToPlane(UKismetMathLibrary* Self, INT_PTR Point, INT_PTR PlaneBase, INT_PTR PlaneNormal)
	{
		auto _p0 = *(FVector*)Point;
		auto _p1 = *(FVector*)PlaneBase;
		auto _p2 = *(FVector*)PlaneNormal;
		return (INT_PTR) new FVector(Self->ProjectPointOnToPlane(_p0, _p1, _p2));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_ProjectVectorOnToPlane(UKismetMathLibrary* Self, INT_PTR V, INT_PTR PlaneNormal)
	{
		auto _p0 = *(FVector*)V;
		auto _p1 = *(FVector*)PlaneNormal;
		return (INT_PTR) new FVector(Self->ProjectVectorOnToPlane(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_ProjectVectorOnToVector(UKismetMathLibrary* Self, INT_PTR V, INT_PTR Target)
	{
		auto _p0 = *(FVector*)V;
		auto _p1 = *(FVector*)Target;
		return (INT_PTR) new FVector(Self->ProjectVectorOnToVector(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Quat_AngularDistance(UKismetMathLibrary* Self, INT_PTR A, INT_PTR B)
	{
		auto& _p0 = *(FQuat*)A;
		auto& _p1 = *(FQuat*)B;
		return Self->Quat_AngularDistance(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Quat_EnforceShortestArcWith(UKismetMathLibrary* Self, INT_PTR A, INT_PTR B)
	{
		auto& _p0 = *(FQuat*)A;
		auto& _p1 = *(FQuat*)B;
		Self->Quat_EnforceShortestArcWith(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Quat_Euler(UKismetMathLibrary* Self, INT_PTR Q)
	{
		auto& _p0 = *(FQuat*)Q;
		return (INT_PTR) new FVector(Self->Quat_Euler(_p0));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Quat_Exp(UKismetMathLibrary* Self, INT_PTR Q)
	{
		auto& _p0 = *(FQuat*)Q;
		return (INT_PTR) new FQuat(Self->Quat_Exp(_p0));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Quat_GetAngle(UKismetMathLibrary* Self, INT_PTR Q)
	{
		auto& _p0 = *(FQuat*)Q;
		return Self->Quat_GetAngle(_p0);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Quat_GetAxisX(UKismetMathLibrary* Self, INT_PTR Q)
	{
		auto& _p0 = *(FQuat*)Q;
		return (INT_PTR) new FVector(Self->Quat_GetAxisX(_p0));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Quat_GetAxisY(UKismetMathLibrary* Self, INT_PTR Q)
	{
		auto& _p0 = *(FQuat*)Q;
		return (INT_PTR) new FVector(Self->Quat_GetAxisY(_p0));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Quat_GetAxisZ(UKismetMathLibrary* Self, INT_PTR Q)
	{
		auto& _p0 = *(FQuat*)Q;
		return (INT_PTR) new FVector(Self->Quat_GetAxisZ(_p0));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Quat_GetRotationAxis(UKismetMathLibrary* Self, INT_PTR Q)
	{
		auto& _p0 = *(FQuat*)Q;
		return (INT_PTR) new FVector(Self->Quat_GetRotationAxis(_p0));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Quat_Identity(UKismetMathLibrary* Self)
	{
		return (INT_PTR) new FQuat(Self->Quat_Identity());
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Quat_Inversed(UKismetMathLibrary* Self, INT_PTR Q)
	{
		auto& _p0 = *(FQuat*)Q;
		return (INT_PTR) new FQuat(Self->Quat_Inversed(_p0));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Quat_IsFinite(UKismetMathLibrary* Self, INT_PTR Q)
	{
		auto& _p0 = *(FQuat*)Q;
		return Self->Quat_IsFinite(_p0);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Quat_IsIdentity(UKismetMathLibrary* Self, INT_PTR Q, float Tolerance)
	{
		auto& _p0 = *(FQuat*)Q;
		auto _p1 = Tolerance;
		return Self->Quat_IsIdentity(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Quat_IsNonFinite(UKismetMathLibrary* Self, INT_PTR Q)
	{
		auto& _p0 = *(FQuat*)Q;
		return Self->Quat_IsNonFinite(_p0);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Quat_IsNormalized(UKismetMathLibrary* Self, INT_PTR Q)
	{
		auto& _p0 = *(FQuat*)Q;
		return Self->Quat_IsNormalized(_p0);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Quat_Log(UKismetMathLibrary* Self, INT_PTR Q)
	{
		auto& _p0 = *(FQuat*)Q;
		return (INT_PTR) new FQuat(Self->Quat_Log(_p0));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Quat_MakeFromEuler(UKismetMathLibrary* Self, INT_PTR Euler)
	{
		auto& _p0 = *(FVector*)Euler;
		return (INT_PTR) new FQuat(Self->Quat_MakeFromEuler(_p0));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Quat_Normalize(UKismetMathLibrary* Self, INT_PTR Q, float Tolerance)
	{
		auto& _p0 = *(FQuat*)Q;
		auto _p1 = Tolerance;
		Self->Quat_Normalize(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Quat_Normalized(UKismetMathLibrary* Self, INT_PTR Q, float Tolerance)
	{
		auto& _p0 = *(FQuat*)Q;
		auto _p1 = Tolerance;
		return (INT_PTR) new FQuat(Self->Quat_Normalized(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Quat_RotateVector(UKismetMathLibrary* Self, INT_PTR Q, INT_PTR V)
	{
		auto& _p0 = *(FQuat*)Q;
		auto& _p1 = *(FVector*)V;
		return (INT_PTR) new FVector(Self->Quat_RotateVector(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Quat_Rotator(UKismetMathLibrary* Self, INT_PTR Q)
	{
		auto& _p0 = *(FQuat*)Q;
		return (INT_PTR) new FRotator(Self->Quat_Rotator(_p0));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Quat_SetComponents(UKismetMathLibrary* Self, INT_PTR Q, float X, float Y, float Z, float W)
	{
		auto& _p0 = *(FQuat*)Q;
		auto _p1 = X;
		auto _p2 = Y;
		auto _p3 = Z;
		auto _p4 = W;
		Self->Quat_SetComponents(_p0, _p1, _p2, _p3, _p4);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Quat_SetFromEuler(UKismetMathLibrary* Self, INT_PTR Q, INT_PTR Euler)
	{
		auto& _p0 = *(FQuat*)Q;
		auto& _p1 = *(FVector*)Euler;
		Self->Quat_SetFromEuler(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Quat_Size(UKismetMathLibrary* Self, INT_PTR Q)
	{
		auto& _p0 = *(FQuat*)Q;
		return Self->Quat_Size(_p0);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Quat_SizeSquared(UKismetMathLibrary* Self, INT_PTR Q)
	{
		auto& _p0 = *(FQuat*)Q;
		return Self->Quat_SizeSquared(_p0);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Quat_UnrotateVector(UKismetMathLibrary* Self, INT_PTR Q, INT_PTR V)
	{
		auto& _p0 = *(FQuat*)Q;
		auto& _p1 = *(FVector*)V;
		return (INT_PTR) new FVector(Self->Quat_UnrotateVector(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Quat_VectorForward(UKismetMathLibrary* Self, INT_PTR Q)
	{
		auto& _p0 = *(FQuat*)Q;
		return (INT_PTR) new FVector(Self->Quat_VectorForward(_p0));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Quat_VectorRight(UKismetMathLibrary* Self, INT_PTR Q)
	{
		auto& _p0 = *(FQuat*)Q;
		return (INT_PTR) new FVector(Self->Quat_VectorRight(_p0));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Quat_VectorUp(UKismetMathLibrary* Self, INT_PTR Q)
	{
		auto& _p0 = *(FQuat*)Q;
		return (INT_PTR) new FVector(Self->Quat_VectorUp(_p0));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_RadiansToDegrees(UKismetMathLibrary* Self, float A)
	{
		auto _p0 = A;
		return Self->RadiansToDegrees(_p0);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_RandomBool(UKismetMathLibrary* Self)
	{
		return Self->RandomBool();
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_RandomBoolFromStream(UKismetMathLibrary* Self, INT_PTR Stream)
	{
		auto& _p0 = *(FRandomStream*)Stream;
		return Self->RandomBoolFromStream(_p0);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_RandomBoolWithWeight(UKismetMathLibrary* Self, float Weight)
	{
		auto _p0 = Weight;
		return Self->RandomBoolWithWeight(_p0);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_RandomBoolWithWeightFromStream(UKismetMathLibrary* Self, float Weight, INT_PTR RandomStream)
	{
		auto _p0 = Weight;
		auto& _p1 = *(FRandomStream*)RandomStream;
		return Self->RandomBoolWithWeightFromStream(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_RandomFloat(UKismetMathLibrary* Self)
	{
		return Self->RandomFloat();
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_RandomFloatFromStream(UKismetMathLibrary* Self, INT_PTR Stream)
	{
		auto& _p0 = *(FRandomStream*)Stream;
		return Self->RandomFloatFromStream(_p0);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_RandomFloatInRange(UKismetMathLibrary* Self, float Min, float Max)
	{
		auto _p0 = Min;
		auto _p1 = Max;
		return Self->RandomFloatInRange(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_RandomFloatInRangeFromStream(UKismetMathLibrary* Self, float Min, float Max, INT_PTR Stream)
	{
		auto _p0 = Min;
		auto _p1 = Max;
		auto& _p2 = *(FRandomStream*)Stream;
		return Self->RandomFloatInRangeFromStream(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_RandomInteger(UKismetMathLibrary* Self, int32 Max)
	{
		auto _p0 = Max;
		return Self->RandomInteger(_p0);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_RandomInteger64(UKismetMathLibrary* Self, int64 Max)
	{
		auto _p0 = Max;
		return Self->RandomInteger64(_p0);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_RandomInteger64InRange(UKismetMathLibrary* Self, int64 Min, int64 Max)
	{
		auto _p0 = Min;
		auto _p1 = Max;
		return Self->RandomInteger64InRange(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_RandomIntegerFromStream(UKismetMathLibrary* Self, int32 Max, INT_PTR Stream)
	{
		auto _p0 = Max;
		auto& _p1 = *(FRandomStream*)Stream;
		return Self->RandomIntegerFromStream(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_RandomIntegerInRange(UKismetMathLibrary* Self, int32 Min, int32 Max)
	{
		auto _p0 = Min;
		auto _p1 = Max;
		return Self->RandomIntegerInRange(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_RandomIntegerInRangeFromStream(UKismetMathLibrary* Self, int32 Min, int32 Max, INT_PTR Stream)
	{
		auto _p0 = Min;
		auto _p1 = Max;
		auto& _p2 = *(FRandomStream*)Stream;
		return Self->RandomIntegerInRangeFromStream(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_RandomPointInBoundingBox(UKismetMathLibrary* Self, INT_PTR Origin, INT_PTR BoxExtent)
	{
		auto _p0 = *(FVector*)Origin;
		auto _p1 = *(FVector*)BoxExtent;
		return (INT_PTR) new FVector(Self->RandomPointInBoundingBox(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_RandomRotator(UKismetMathLibrary* Self, bool bRoll)
	{
		auto _p0 = bRoll;
		return (INT_PTR) new FRotator(Self->RandomRotator(_p0));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_RandomRotatorFromStream(UKismetMathLibrary* Self, bool bRoll, INT_PTR Stream)
	{
		auto _p0 = bRoll;
		auto& _p1 = *(FRandomStream*)Stream;
		return (INT_PTR) new FRotator(Self->RandomRotatorFromStream(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_RandomUnitVector(UKismetMathLibrary* Self)
	{
		return (INT_PTR) new FVector(Self->RandomUnitVector());
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_RandomUnitVectorFromStream(UKismetMathLibrary* Self, INT_PTR Stream)
	{
		auto& _p0 = *(FRandomStream*)Stream;
		return (INT_PTR) new FVector(Self->RandomUnitVectorFromStream(_p0));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_RandomUnitVectorInConeInDegrees(UKismetMathLibrary* Self, INT_PTR ConeDir, float ConeHalfAngleInDegrees)
	{
		auto _p0 = *(FVector*)ConeDir;
		auto _p1 = ConeHalfAngleInDegrees;
		return (INT_PTR) new FVector(Self->RandomUnitVectorInConeInDegrees(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_RandomUnitVectorInConeInDegreesFromStream(UKismetMathLibrary* Self, INT_PTR ConeDir, float ConeHalfAngleInDegrees, INT_PTR Stream)
	{
		auto& _p0 = *(FVector*)ConeDir;
		auto _p1 = ConeHalfAngleInDegrees;
		auto& _p2 = *(FRandomStream*)Stream;
		return (INT_PTR) new FVector(Self->RandomUnitVectorInConeInDegreesFromStream(_p0, _p1, _p2));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_RandomUnitVectorInConeInRadians(UKismetMathLibrary* Self, INT_PTR ConeDir, float ConeHalfAngleInRadians)
	{
		auto _p0 = *(FVector*)ConeDir;
		auto _p1 = ConeHalfAngleInRadians;
		return (INT_PTR) new FVector(Self->RandomUnitVectorInConeInRadians(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_RandomUnitVectorInConeInRadiansFromStream(UKismetMathLibrary* Self, INT_PTR ConeDir, float ConeHalfAngleInRadians, INT_PTR Stream)
	{
		auto& _p0 = *(FVector*)ConeDir;
		auto _p1 = ConeHalfAngleInRadians;
		auto& _p2 = *(FRandomStream*)Stream;
		return (INT_PTR) new FVector(Self->RandomUnitVectorInConeInRadiansFromStream(_p0, _p1, _p2));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_RandomUnitVectorInEllipticalConeInDegrees(UKismetMathLibrary* Self, INT_PTR ConeDir, float MaxYawInDegrees, float MaxPitchInDegrees)
	{
		auto _p0 = *(FVector*)ConeDir;
		auto _p1 = MaxYawInDegrees;
		auto _p2 = MaxPitchInDegrees;
		return (INT_PTR) new FVector(Self->RandomUnitVectorInEllipticalConeInDegrees(_p0, _p1, _p2));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_RandomUnitVectorInEllipticalConeInDegreesFromStream(UKismetMathLibrary* Self, INT_PTR ConeDir, float MaxYawInDegrees, float MaxPitchInDegrees, INT_PTR Stream)
	{
		auto& _p0 = *(FVector*)ConeDir;
		auto _p1 = MaxYawInDegrees;
		auto _p2 = MaxPitchInDegrees;
		auto& _p3 = *(FRandomStream*)Stream;
		return (INT_PTR) new FVector(Self->RandomUnitVectorInEllipticalConeInDegreesFromStream(_p0, _p1, _p2, _p3));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_RandomUnitVectorInEllipticalConeInRadians(UKismetMathLibrary* Self, INT_PTR ConeDir, float MaxYawInRadians, float MaxPitchInRadians)
	{
		auto _p0 = *(FVector*)ConeDir;
		auto _p1 = MaxYawInRadians;
		auto _p2 = MaxPitchInRadians;
		return (INT_PTR) new FVector(Self->RandomUnitVectorInEllipticalConeInRadians(_p0, _p1, _p2));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_RandomUnitVectorInEllipticalConeInRadiansFromStream(UKismetMathLibrary* Self, INT_PTR ConeDir, float MaxYawInRadians, float MaxPitchInRadians, INT_PTR Stream)
	{
		auto& _p0 = *(FVector*)ConeDir;
		auto _p1 = MaxYawInRadians;
		auto _p2 = MaxPitchInRadians;
		auto& _p3 = *(FRandomStream*)Stream;
		return (INT_PTR) new FVector(Self->RandomUnitVectorInEllipticalConeInRadiansFromStream(_p0, _p1, _p2, _p3));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_ResetFloatSpringState(UKismetMathLibrary* Self, INT_PTR SpringState)
	{
		auto& _p0 = *(FFloatSpringState*)SpringState;
		Self->ResetFloatSpringState(_p0);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_ResetRandomStream(UKismetMathLibrary* Self, INT_PTR Stream)
	{
		auto& _p0 = *(FRandomStream*)Stream;
		Self->ResetRandomStream(_p0);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_ResetVectorSpringState(UKismetMathLibrary* Self, INT_PTR SpringState)
	{
		auto& _p0 = *(FVectorSpringState*)SpringState;
		Self->ResetVectorSpringState(_p0);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_RGBLinearToHSV(UKismetMathLibrary* Self, INT_PTR RGB)
	{
		auto _p0 = *(FLinearColor*)RGB;
		return (INT_PTR) new FLinearColor(Self->RGBLinearToHSV(_p0));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_RGBToHSV(UKismetMathLibrary* Self, INT_PTR InColor, float H, float S, float V, float A)
	{
		auto _p0 = *(FLinearColor*)InColor;
		auto& _p1 = H;
		auto& _p2 = S;
		auto& _p3 = V;
		auto& _p4 = A;
		Self->RGBToHSV(_p0, _p1, _p2, _p3, _p4);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_RGBToHSV_Vector(UKismetMathLibrary* Self, INT_PTR RGB, INT_PTR HSV)
	{
		auto _p0 = *(FLinearColor*)RGB;
		auto& _p1 = *(FLinearColor*)HSV;
		Self->RGBToHSV_Vector(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_RInterpTo(UKismetMathLibrary* Self, INT_PTR Current, INT_PTR Target, float DeltaTime, float InterpSpeed)
	{
		auto _p0 = *(FRotator*)Current;
		auto _p1 = *(FRotator*)Target;
		auto _p2 = DeltaTime;
		auto _p3 = InterpSpeed;
		return (INT_PTR) new FRotator(Self->RInterpTo(_p0, _p1, _p2, _p3));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_RInterpTo_Constant(UKismetMathLibrary* Self, INT_PTR Current, INT_PTR Target, float DeltaTime, float InterpSpeed)
	{
		auto _p0 = *(FRotator*)Current;
		auto _p1 = *(FRotator*)Target;
		auto _p2 = DeltaTime;
		auto _p3 = InterpSpeed;
		return (INT_PTR) new FRotator(Self->RInterpTo_Constant(_p0, _p1, _p2, _p3));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_RLerp(UKismetMathLibrary* Self, INT_PTR A, INT_PTR B, float Alpha, bool bShortestPath)
	{
		auto _p0 = *(FRotator*)A;
		auto _p1 = *(FRotator*)B;
		auto _p2 = Alpha;
		auto _p3 = bShortestPath;
		return (INT_PTR) new FRotator(Self->RLerp(_p0, _p1, _p2, _p3));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_RotateAngleAxis(UKismetMathLibrary* Self, INT_PTR InVect, float AngleDeg, INT_PTR Axis)
	{
		auto _p0 = *(FVector*)InVect;
		auto _p1 = AngleDeg;
		auto _p2 = *(FVector*)Axis;
		return (INT_PTR) new FVector(Self->RotateAngleAxis(_p0, _p1, _p2));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_RotatorFromAxisAndAngle(UKismetMathLibrary* Self, INT_PTR Axis, float Angle)
	{
		auto _p0 = *(FVector*)Axis;
		auto _p1 = Angle;
		return (INT_PTR) new FRotator(Self->RotatorFromAxisAndAngle(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Round(UKismetMathLibrary* Self, float A)
	{
		auto _p0 = A;
		return Self->Round(_p0);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Round64(UKismetMathLibrary* Self, float A)
	{
		auto _p0 = A;
		return Self->Round64(_p0);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_SeedRandomStream(UKismetMathLibrary* Self, INT_PTR Stream)
	{
		auto& _p0 = *(FRandomStream*)Stream;
		Self->SeedRandomStream(_p0);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_SelectColor(UKismetMathLibrary* Self, INT_PTR A, INT_PTR B, bool bPickA)
	{
		auto _p0 = *(FLinearColor*)A;
		auto _p1 = *(FLinearColor*)B;
		auto _p2 = bPickA;
		return (INT_PTR) new FLinearColor(Self->SelectColor(_p0, _p1, _p2));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_SelectFloat(UKismetMathLibrary* Self, float A, float B, bool bPickA)
	{
		auto _p0 = A;
		auto _p1 = B;
		auto _p2 = bPickA;
		return Self->SelectFloat(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_SelectInt(UKismetMathLibrary* Self, int32 A, int32 B, bool bPickA)
	{
		auto _p0 = A;
		auto _p1 = B;
		auto _p2 = bPickA;
		return Self->SelectInt(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_SelectObject(UKismetMathLibrary* Self, UObject* A, UObject* B, bool bSelectA)
	{
		auto _p0 = A;
		auto _p1 = B;
		auto _p2 = bSelectA;
		return ConvertToManage_ObjectPointerDescription(Self->SelectObject(_p0, _p1, _p2));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_SelectRotator(UKismetMathLibrary* Self, INT_PTR A, INT_PTR B, bool bPickA)
	{
		auto _p0 = *(FRotator*)A;
		auto _p1 = *(FRotator*)B;
		auto _p2 = bPickA;
		return (INT_PTR) new FRotator(Self->SelectRotator(_p0, _p1, _p2));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_SelectString(UKismetMathLibrary* Self, char* A, char* B, bool bPickA)
	{
		auto _p0 = ConvertFromManage_FString(A);
		auto _p1 = ConvertFromManage_FString(B);
		auto _p2 = bPickA;
		return ConvertToManage_StringWrapper(Self->SelectString(_p0, _p1, _p2));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_SelectTransform(UKismetMathLibrary* Self, INT_PTR A, INT_PTR B, bool bPickA)
	{
		auto& _p0 = *(FTransform*)A;
		auto& _p1 = *(FTransform*)B;
		auto _p2 = bPickA;
		return (INT_PTR) new FTransform(Self->SelectTransform(_p0, _p1, _p2));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_SelectVector(UKismetMathLibrary* Self, INT_PTR A, INT_PTR B, bool bPickA)
	{
		auto _p0 = *(FVector*)A;
		auto _p1 = *(FVector*)B;
		auto _p2 = bPickA;
		return (INT_PTR) new FVector(Self->SelectVector(_p0, _p1, _p2));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Set2D(UKismetMathLibrary* Self, INT_PTR A, float X, float Y)
	{
		auto& _p0 = *(FVector2D*)A;
		auto _p1 = X;
		auto _p2 = Y;
		Self->Set2D(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_SetRandomStreamSeed(UKismetMathLibrary* Self, INT_PTR Stream, int32 NewSeed)
	{
		auto& _p0 = *(FRandomStream*)Stream;
		auto _p1 = NewSeed;
		Self->SetRandomStreamSeed(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_SignOfFloat(UKismetMathLibrary* Self, float A)
	{
		auto _p0 = A;
		return Self->SignOfFloat(_p0);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_SignOfInteger(UKismetMathLibrary* Self, int32 A)
	{
		auto _p0 = A;
		return Self->SignOfInteger(_p0);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_SignOfInteger64(UKismetMathLibrary* Self, int64 A)
	{
		auto _p0 = A;
		return Self->SignOfInteger64(_p0);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Sin(UKismetMathLibrary* Self, float A)
	{
		auto _p0 = A;
		return Self->Sin(_p0);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Spherical2DToUnitCartesian(UKismetMathLibrary* Self, INT_PTR A)
	{
		auto _p0 = *(FVector2D*)A;
		return (INT_PTR) new FVector(Self->Spherical2DToUnitCartesian(_p0));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Sqrt(UKismetMathLibrary* Self, float A)
	{
		auto _p0 = A;
		return Self->Sqrt(_p0);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Square(UKismetMathLibrary* Self, float A)
	{
		auto _p0 = A;
		return Self->Square(_p0);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Subtract_ByteByte(UKismetMathLibrary* Self, uint8 A, uint8 B)
	{
		auto _p0 = A;
		auto _p1 = B;
		return Self->Subtract_ByteByte(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Subtract_FloatFloat(UKismetMathLibrary* Self, float A, float B)
	{
		auto _p0 = A;
		auto _p1 = B;
		return Self->Subtract_FloatFloat(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Subtract_Int64Int64(UKismetMathLibrary* Self, int64 A, int64 B)
	{
		auto _p0 = A;
		auto _p1 = B;
		return Self->Subtract_Int64Int64(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Subtract_IntInt(UKismetMathLibrary* Self, int32 A, int32 B)
	{
		auto _p0 = A;
		auto _p1 = B;
		return Self->Subtract_IntInt(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Subtract_LinearColorLinearColor(UKismetMathLibrary* Self, INT_PTR A, INT_PTR B)
	{
		auto _p0 = *(FLinearColor*)A;
		auto _p1 = *(FLinearColor*)B;
		return (INT_PTR) new FLinearColor(Self->Subtract_LinearColorLinearColor(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Subtract_QuatQuat(UKismetMathLibrary* Self, INT_PTR A, INT_PTR B)
	{
		auto& _p0 = *(FQuat*)A;
		auto& _p1 = *(FQuat*)B;
		return (INT_PTR) new FQuat(Self->Subtract_QuatQuat(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Subtract_Vector2DFloat(UKismetMathLibrary* Self, INT_PTR A, float B)
	{
		auto _p0 = *(FVector2D*)A;
		auto _p1 = B;
		return (INT_PTR) new FVector2D(Self->Subtract_Vector2DFloat(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Subtract_Vector2DVector2D(UKismetMathLibrary* Self, INT_PTR A, INT_PTR B)
	{
		auto _p0 = *(FVector2D*)A;
		auto _p1 = *(FVector2D*)B;
		return (INT_PTR) new FVector2D(Self->Subtract_Vector2DVector2D(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Subtract_Vector4Vector4(UKismetMathLibrary* Self, INT_PTR A, INT_PTR B)
	{
		auto& _p0 = *(FVector4*)A;
		auto& _p1 = *(FVector4*)B;
		return (INT_PTR) new FVector4(Self->Subtract_Vector4Vector4(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Subtract_VectorFloat(UKismetMathLibrary* Self, INT_PTR A, float B)
	{
		auto _p0 = *(FVector*)A;
		auto _p1 = B;
		return (INT_PTR) new FVector(Self->Subtract_VectorFloat(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Subtract_VectorInt(UKismetMathLibrary* Self, INT_PTR A, int32 B)
	{
		auto _p0 = *(FVector*)A;
		auto _p1 = B;
		return (INT_PTR) new FVector(Self->Subtract_VectorInt(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Subtract_VectorVector(UKismetMathLibrary* Self, INT_PTR A, INT_PTR B)
	{
		auto _p0 = *(FVector*)A;
		auto _p1 = *(FVector*)B;
		return (INT_PTR) new FVector(Self->Subtract_VectorVector(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Tan(UKismetMathLibrary* Self, float A)
	{
		auto _p0 = A;
		return Self->Tan(_p0);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_TInterpTo(UKismetMathLibrary* Self, INT_PTR Current, INT_PTR Target, float DeltaTime, float InterpSpeed)
	{
		auto& _p0 = *(FTransform*)Current;
		auto& _p1 = *(FTransform*)Target;
		auto _p2 = DeltaTime;
		auto _p3 = InterpSpeed;
		return (INT_PTR) new FTransform(Self->TInterpTo(_p0, _p1, _p2, _p3));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_ToDirectionAndLength2D(UKismetMathLibrary* Self, INT_PTR A, INT_PTR OutDir, float OutLength)
	{
		auto _p0 = *(FVector2D*)A;
		auto& _p1 = *(FVector2D*)OutDir;
		auto& _p2 = OutLength;
		Self->ToDirectionAndLength2D(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_ToRounded2D(UKismetMathLibrary* Self, INT_PTR A)
	{
		auto _p0 = *(FVector2D*)A;
		return (INT_PTR) new FVector2D(Self->ToRounded2D(_p0));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_ToSign2D(UKismetMathLibrary* Self, INT_PTR A)
	{
		auto _p0 = *(FVector2D*)A;
		return (INT_PTR) new FVector2D(Self->ToSign2D(_p0));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Transform_Determinant(UKismetMathLibrary* Self, INT_PTR Transform)
	{
		auto& _p0 = *(FTransform*)Transform;
		return Self->Transform_Determinant(_p0);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_TransformDirection(UKismetMathLibrary* Self, INT_PTR T, INT_PTR Direction)
	{
		auto& _p0 = *(FTransform*)T;
		auto _p1 = *(FVector*)Direction;
		return (INT_PTR) new FVector(Self->TransformDirection(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_TransformLocation(UKismetMathLibrary* Self, INT_PTR T, INT_PTR Location)
	{
		auto& _p0 = *(FTransform*)T;
		auto _p1 = *(FVector*)Location;
		return (INT_PTR) new FVector(Self->TransformLocation(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_TransformRotation(UKismetMathLibrary* Self, INT_PTR T, INT_PTR Rotation)
	{
		auto& _p0 = *(FTransform*)T;
		auto _p1 = *(FRotator*)Rotation;
		return (INT_PTR) new FRotator(Self->TransformRotation(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Vector_AddBounded(UKismetMathLibrary* Self, INT_PTR A, INT_PTR InAddVect, float InRadius)
	{
		auto& _p0 = *(FVector*)A;
		auto _p1 = *(FVector*)InAddVect;
		auto _p2 = InRadius;
		Self->Vector_AddBounded(_p0, _p1, _p2);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Vector_Assign(UKismetMathLibrary* Self, INT_PTR A, INT_PTR InVector)
	{
		auto& _p0 = *(FVector*)A;
		auto& _p1 = *(FVector*)InVector;
		Self->Vector_Assign(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Vector_Backward(UKismetMathLibrary* Self)
	{
		return (INT_PTR) new FVector(Self->Vector_Backward());
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Vector_BoundedToBox(UKismetMathLibrary* Self, INT_PTR InVect, INT_PTR InBoxMin, INT_PTR InBoxMax)
	{
		auto _p0 = *(FVector*)InVect;
		auto _p1 = *(FVector*)InBoxMin;
		auto _p2 = *(FVector*)InBoxMax;
		return (INT_PTR) new FVector(Self->Vector_BoundedToBox(_p0, _p1, _p2));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Vector_BoundedToCube(UKismetMathLibrary* Self, INT_PTR InVect, float InRadius)
	{
		auto _p0 = *(FVector*)InVect;
		auto _p1 = InRadius;
		return (INT_PTR) new FVector(Self->Vector_BoundedToCube(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Vector_ClampSize2D(UKismetMathLibrary* Self, INT_PTR A, float Min, float Max)
	{
		auto _p0 = *(FVector*)A;
		auto _p1 = Min;
		auto _p2 = Max;
		return (INT_PTR) new FVector(Self->Vector_ClampSize2D(_p0, _p1, _p2));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Vector_ClampSizeMax(UKismetMathLibrary* Self, INT_PTR A, float Max)
	{
		auto _p0 = *(FVector*)A;
		auto _p1 = Max;
		return (INT_PTR) new FVector(Self->Vector_ClampSizeMax(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Vector_ClampSizeMax2D(UKismetMathLibrary* Self, INT_PTR A, float Max)
	{
		auto _p0 = *(FVector*)A;
		auto _p1 = Max;
		return (INT_PTR) new FVector(Self->Vector_ClampSizeMax2D(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Vector_ComponentMax(UKismetMathLibrary* Self, INT_PTR A, INT_PTR B)
	{
		auto _p0 = *(FVector*)A;
		auto _p1 = *(FVector*)B;
		return (INT_PTR) new FVector(Self->Vector_ComponentMax(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Vector_ComponentMin(UKismetMathLibrary* Self, INT_PTR A, INT_PTR B)
	{
		auto _p0 = *(FVector*)A;
		auto _p1 = *(FVector*)B;
		return (INT_PTR) new FVector(Self->Vector_ComponentMin(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Vector_CosineAngle2D(UKismetMathLibrary* Self, INT_PTR A, INT_PTR B)
	{
		auto _p0 = *(FVector*)A;
		auto _p1 = *(FVector*)B;
		return Self->Vector_CosineAngle2D(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Vector_Distance(UKismetMathLibrary* Self, INT_PTR V1, INT_PTR V2)
	{
		auto _p0 = *(FVector*)V1;
		auto _p1 = *(FVector*)V2;
		return Self->Vector_Distance(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Vector_Distance2D(UKismetMathLibrary* Self, INT_PTR V1, INT_PTR V2)
	{
		auto _p0 = *(FVector*)V1;
		auto _p1 = *(FVector*)V2;
		return Self->Vector_Distance2D(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Vector_Distance2DSquared(UKismetMathLibrary* Self, INT_PTR V1, INT_PTR V2)
	{
		auto _p0 = *(FVector*)V1;
		auto _p1 = *(FVector*)V2;
		return Self->Vector_Distance2DSquared(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Vector_DistanceSquared(UKismetMathLibrary* Self, INT_PTR V1, INT_PTR V2)
	{
		auto _p0 = *(FVector*)V1;
		auto _p1 = *(FVector*)V2;
		return Self->Vector_DistanceSquared(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Vector_Down(UKismetMathLibrary* Self)
	{
		return (INT_PTR) new FVector(Self->Vector_Down());
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Vector_Forward(UKismetMathLibrary* Self)
	{
		return (INT_PTR) new FVector(Self->Vector_Forward());
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Vector_GetAbs(UKismetMathLibrary* Self, INT_PTR A)
	{
		auto _p0 = *(FVector*)A;
		return (INT_PTR) new FVector(Self->Vector_GetAbs(_p0));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Vector_GetAbsMax(UKismetMathLibrary* Self, INT_PTR A)
	{
		auto _p0 = *(FVector*)A;
		return Self->Vector_GetAbsMax(_p0);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Vector_GetAbsMin(UKismetMathLibrary* Self, INT_PTR A)
	{
		auto _p0 = *(FVector*)A;
		return Self->Vector_GetAbsMin(_p0);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Vector_GetProjection(UKismetMathLibrary* Self, INT_PTR A)
	{
		auto _p0 = *(FVector*)A;
		return (INT_PTR) new FVector(Self->Vector_GetProjection(_p0));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Vector_GetSignVector(UKismetMathLibrary* Self, INT_PTR A)
	{
		auto _p0 = *(FVector*)A;
		return (INT_PTR) new FVector(Self->Vector_GetSignVector(_p0));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Vector_HeadingAngle(UKismetMathLibrary* Self, INT_PTR A)
	{
		auto _p0 = *(FVector*)A;
		return Self->Vector_HeadingAngle(_p0);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Vector_IsNAN(UKismetMathLibrary* Self, INT_PTR A)
	{
		auto& _p0 = *(FVector*)A;
		return Self->Vector_IsNAN(_p0);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Vector_IsNearlyZero(UKismetMathLibrary* Self, INT_PTR A, float Tolerance)
	{
		auto& _p0 = *(FVector*)A;
		auto _p1 = Tolerance;
		return Self->Vector_IsNearlyZero(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Vector_IsNormal(UKismetMathLibrary* Self, INT_PTR A)
	{
		auto& _p0 = *(FVector*)A;
		return Self->Vector_IsNormal(_p0);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Vector_IsUniform(UKismetMathLibrary* Self, INT_PTR A, float Tolerance)
	{
		auto& _p0 = *(FVector*)A;
		auto _p1 = Tolerance;
		return Self->Vector_IsUniform(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Vector_IsUnit(UKismetMathLibrary* Self, INT_PTR A, float SquaredLenthTolerance)
	{
		auto& _p0 = *(FVector*)A;
		auto _p1 = SquaredLenthTolerance;
		return Self->Vector_IsUnit(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Vector_IsZero(UKismetMathLibrary* Self, INT_PTR A)
	{
		auto& _p0 = *(FVector*)A;
		return Self->Vector_IsZero(_p0);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Vector_Left(UKismetMathLibrary* Self)
	{
		return (INT_PTR) new FVector(Self->Vector_Left());
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Vector_MirrorByPlane(UKismetMathLibrary* Self, INT_PTR A, INT_PTR InPlane)
	{
		auto _p0 = *(FVector*)A;
		auto& _p1 = *(FPlane*)InPlane;
		return (INT_PTR) new FVector(Self->Vector_MirrorByPlane(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Vector_Normal2D(UKismetMathLibrary* Self, INT_PTR A, float Tolerance)
	{
		auto _p0 = *(FVector*)A;
		auto _p1 = Tolerance;
		return (INT_PTR) new FVector(Self->Vector_Normal2D(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Vector_Normalize(UKismetMathLibrary* Self, INT_PTR A, float Tolerance)
	{
		auto& _p0 = *(FVector*)A;
		auto _p1 = Tolerance;
		Self->Vector_Normalize(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Vector_NormalUnsafe(UKismetMathLibrary* Self, INT_PTR A)
	{
		auto& _p0 = *(FVector*)A;
		return (INT_PTR) new FVector(Self->Vector_NormalUnsafe(_p0));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Vector_One(UKismetMathLibrary* Self)
	{
		return (INT_PTR) new FVector(Self->Vector_One());
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Vector_ProjectOnToNormal(UKismetMathLibrary* Self, INT_PTR V, INT_PTR InNormal)
	{
		auto _p0 = *(FVector*)V;
		auto _p1 = *(FVector*)InNormal;
		return (INT_PTR) new FVector(Self->Vector_ProjectOnToNormal(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Vector_Reciprocal(UKismetMathLibrary* Self, INT_PTR A)
	{
		auto& _p0 = *(FVector*)A;
		return (INT_PTR) new FVector(Self->Vector_Reciprocal(_p0));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Vector_Right(UKismetMathLibrary* Self)
	{
		return (INT_PTR) new FVector(Self->Vector_Right());
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Vector_Set(UKismetMathLibrary* Self, INT_PTR A, float X, float Y, float Z)
	{
		auto& _p0 = *(FVector*)A;
		auto _p1 = X;
		auto _p2 = Y;
		auto _p3 = Z;
		Self->Vector_Set(_p0, _p1, _p2, _p3);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Vector_SnappedToGrid(UKismetMathLibrary* Self, INT_PTR InVect, float InGridSize)
	{
		auto _p0 = *(FVector*)InVect;
		auto _p1 = InGridSize;
		return (INT_PTR) new FVector(Self->Vector_SnappedToGrid(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Vector_ToDegrees(UKismetMathLibrary* Self, INT_PTR A)
	{
		auto _p0 = *(FVector*)A;
		return (INT_PTR) new FVector(Self->Vector_ToDegrees(_p0));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Vector_ToRadians(UKismetMathLibrary* Self, INT_PTR A)
	{
		auto _p0 = *(FVector*)A;
		return (INT_PTR) new FVector(Self->Vector_ToRadians(_p0));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Vector_UnitCartesianToSpherical(UKismetMathLibrary* Self, INT_PTR A)
	{
		auto _p0 = *(FVector*)A;
		return (INT_PTR) new FVector2D(Self->Vector_UnitCartesianToSpherical(_p0));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Vector_UnwindEuler(UKismetMathLibrary* Self, INT_PTR A)
	{
		auto& _p0 = *(FVector*)A;
		Self->Vector_UnwindEuler(_p0);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Vector_Up(UKismetMathLibrary* Self)
	{
		return (INT_PTR) new FVector(Self->Vector_Up());
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Vector_Zero(UKismetMathLibrary* Self)
	{
		return (INT_PTR) new FVector(Self->Vector_Zero());
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Vector2D_One(UKismetMathLibrary* Self)
	{
		return (INT_PTR) new FVector2D(Self->Vector2D_One());
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Vector2D_Unit45Deg(UKismetMathLibrary* Self)
	{
		return (INT_PTR) new FVector2D(Self->Vector2D_Unit45Deg());
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Vector2D_Zero(UKismetMathLibrary* Self)
	{
		return (INT_PTR) new FVector2D(Self->Vector2D_Zero());
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Vector2DInterpTo(UKismetMathLibrary* Self, INT_PTR Current, INT_PTR Target, float DeltaTime, float InterpSpeed)
	{
		auto _p0 = *(FVector2D*)Current;
		auto _p1 = *(FVector2D*)Target;
		auto _p2 = DeltaTime;
		auto _p3 = InterpSpeed;
		return (INT_PTR) new FVector2D(Self->Vector2DInterpTo(_p0, _p1, _p2, _p3));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Vector2DInterpTo_Constant(UKismetMathLibrary* Self, INT_PTR Current, INT_PTR Target, float DeltaTime, float InterpSpeed)
	{
		auto _p0 = *(FVector2D*)Current;
		auto _p1 = *(FVector2D*)Target;
		auto _p2 = DeltaTime;
		auto _p3 = InterpSpeed;
		return (INT_PTR) new FVector2D(Self->Vector2DInterpTo_Constant(_p0, _p1, _p2, _p3));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Vector4_Assign(UKismetMathLibrary* Self, INT_PTR A, INT_PTR InVector)
	{
		auto& _p0 = *(FVector4*)A;
		auto& _p1 = *(FVector4*)InVector;
		Self->Vector4_Assign(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Vector4_CrossProduct3(UKismetMathLibrary* Self, INT_PTR A, INT_PTR B)
	{
		auto& _p0 = *(FVector4*)A;
		auto& _p1 = *(FVector4*)B;
		return (INT_PTR) new FVector4(Self->Vector4_CrossProduct3(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Vector4_DotProduct(UKismetMathLibrary* Self, INT_PTR A, INT_PTR B)
	{
		auto& _p0 = *(FVector4*)A;
		auto& _p1 = *(FVector4*)B;
		return Self->Vector4_DotProduct(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Vector4_DotProduct3(UKismetMathLibrary* Self, INT_PTR A, INT_PTR B)
	{
		auto& _p0 = *(FVector4*)A;
		auto& _p1 = *(FVector4*)B;
		return Self->Vector4_DotProduct3(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Vector4_IsNAN(UKismetMathLibrary* Self, INT_PTR A)
	{
		auto& _p0 = *(FVector4*)A;
		return Self->Vector4_IsNAN(_p0);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Vector4_IsNearlyZero3(UKismetMathLibrary* Self, INT_PTR A, float Tolerance)
	{
		auto& _p0 = *(FVector4*)A;
		auto _p1 = Tolerance;
		return Self->Vector4_IsNearlyZero3(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Vector4_IsNormal3(UKismetMathLibrary* Self, INT_PTR A)
	{
		auto& _p0 = *(FVector4*)A;
		return Self->Vector4_IsNormal3(_p0);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Vector4_IsUnit3(UKismetMathLibrary* Self, INT_PTR A, float SquaredLenthTolerance)
	{
		auto& _p0 = *(FVector4*)A;
		auto _p1 = SquaredLenthTolerance;
		return Self->Vector4_IsUnit3(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Vector4_IsZero(UKismetMathLibrary* Self, INT_PTR A)
	{
		auto& _p0 = *(FVector4*)A;
		return Self->Vector4_IsZero(_p0);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Vector4_MirrorByVector3(UKismetMathLibrary* Self, INT_PTR Direction, INT_PTR SurfaceNormal)
	{
		auto& _p0 = *(FVector4*)Direction;
		auto& _p1 = *(FVector4*)SurfaceNormal;
		return (INT_PTR) new FVector4(Self->Vector4_MirrorByVector3(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Vector4_Negated(UKismetMathLibrary* Self, INT_PTR A)
	{
		auto& _p0 = *(FVector4*)A;
		return (INT_PTR) new FVector4(Self->Vector4_Negated(_p0));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Vector4_Normal3(UKismetMathLibrary* Self, INT_PTR A, float Tolerance)
	{
		auto& _p0 = *(FVector4*)A;
		auto _p1 = Tolerance;
		return (INT_PTR) new FVector4(Self->Vector4_Normal3(_p0, _p1));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Vector4_Normalize3(UKismetMathLibrary* Self, INT_PTR A, float Tolerance)
	{
		auto& _p0 = *(FVector4*)A;
		auto _p1 = Tolerance;
		Self->Vector4_Normalize3(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Vector4_NormalUnsafe3(UKismetMathLibrary* Self, INT_PTR A)
	{
		auto& _p0 = *(FVector4*)A;
		return (INT_PTR) new FVector4(Self->Vector4_NormalUnsafe3(_p0));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Vector4_Set(UKismetMathLibrary* Self, INT_PTR A, float X, float Y, float Z, float W)
	{
		auto& _p0 = *(FVector4*)A;
		auto _p1 = X;
		auto _p2 = Y;
		auto _p3 = Z;
		auto _p4 = W;
		Self->Vector4_Set(_p0, _p1, _p2, _p3, _p4);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Vector4_Size(UKismetMathLibrary* Self, INT_PTR A)
	{
		auto& _p0 = *(FVector4*)A;
		return Self->Vector4_Size(_p0);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Vector4_Size3(UKismetMathLibrary* Self, INT_PTR A)
	{
		auto& _p0 = *(FVector4*)A;
		return Self->Vector4_Size3(_p0);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Vector4_SizeSquared(UKismetMathLibrary* Self, INT_PTR A)
	{
		auto& _p0 = *(FVector4*)A;
		return Self->Vector4_SizeSquared(_p0);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Vector4_SizeSquared3(UKismetMathLibrary* Self, INT_PTR A)
	{
		auto& _p0 = *(FVector4*)A;
		return Self->Vector4_SizeSquared3(_p0);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Vector4_Zero(UKismetMathLibrary* Self)
	{
		return (INT_PTR) new FVector4(Self->Vector4_Zero());
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_VectorSpringInterp(UKismetMathLibrary* Self, INT_PTR Current, INT_PTR Target, INT_PTR SpringState, float Stiffness, float CriticalDampingFactor, float DeltaTime, float Mass)
	{
		auto _p0 = *(FVector*)Current;
		auto _p1 = *(FVector*)Target;
		auto& _p2 = *(FVectorSpringState*)SpringState;
		auto _p3 = Stiffness;
		auto _p4 = CriticalDampingFactor;
		auto _p5 = DeltaTime;
		auto _p6 = Mass;
		return (INT_PTR) new FVector(Self->VectorSpringInterp(_p0, _p1, _p2, _p3, _p4, _p5, _p6));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_VInterpTo(UKismetMathLibrary* Self, INT_PTR Current, INT_PTR Target, float DeltaTime, float InterpSpeed)
	{
		auto _p0 = *(FVector*)Current;
		auto _p1 = *(FVector*)Target;
		auto _p2 = DeltaTime;
		auto _p3 = InterpSpeed;
		return (INT_PTR) new FVector(Self->VInterpTo(_p0, _p1, _p2, _p3));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_VInterpTo_Constant(UKismetMathLibrary* Self, INT_PTR Current, INT_PTR Target, float DeltaTime, float InterpSpeed)
	{
		auto _p0 = *(FVector*)Current;
		auto _p1 = *(FVector*)Target;
		auto _p2 = DeltaTime;
		auto _p3 = InterpSpeed;
		return (INT_PTR) new FVector(Self->VInterpTo_Constant(_p0, _p1, _p2, _p3));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_VLerp(UKismetMathLibrary* Self, INT_PTR A, INT_PTR B, float Alpha)
	{
		auto _p0 = *(FVector*)A;
		auto _p1 = *(FVector*)B;
		auto _p2 = Alpha;
		return (INT_PTR) new FVector(Self->VLerp(_p0, _p1, _p2));
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_VSize(UKismetMathLibrary* Self, INT_PTR A)
	{
		auto _p0 = *(FVector*)A;
		return Self->VSize(_p0);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_VSize2D(UKismetMathLibrary* Self, INT_PTR A)
	{
		auto _p0 = *(FVector2D*)A;
		return Self->VSize2D(_p0);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_VSize2DSquared(UKismetMathLibrary* Self, INT_PTR A)
	{
		auto _p0 = *(FVector2D*)A;
		return Self->VSize2DSquared(_p0);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_VSizeSquared(UKismetMathLibrary* Self, INT_PTR A)
	{
		auto _p0 = *(FVector*)A;
		return Self->VSizeSquared(_p0);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_VSizeXY(UKismetMathLibrary* Self, INT_PTR A)
	{
		auto _p0 = *(FVector*)A;
		return Self->VSizeXY(_p0);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_VSizeXYSquared(UKismetMathLibrary* Self, INT_PTR A)
	{
		auto _p0 = *(FVector*)A;
		return Self->VSizeXYSquared(_p0);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Xor_Int64Int64(UKismetMathLibrary* Self, int64 A, int64 B)
	{
		auto _p0 = A;
		auto _p1 = B;
		return Self->Xor_Int64Int64(_p0, _p1);
	}

	DOTNET_EXPORT auto E_UKismetMathLibrary_Xor_IntInt(UKismetMathLibrary* Self, int32 A, int32 B)
	{
		auto _p0 = A;
		auto _p1 = B;
		return Self->Xor_IntInt(_p0, _p1);
	}

}
PRAGMA_ENABLE_DEPRECATION_WARNINGS
