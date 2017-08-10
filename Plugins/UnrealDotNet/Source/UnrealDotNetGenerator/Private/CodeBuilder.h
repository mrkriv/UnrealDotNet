#pragma once

#include "CoreMinimal.h"

class FCodeBuilder
{
	FString Report;
	FString caheTab;

public:
	FORCEINLINE FCodeBuilder& Tab()
	{
		caheTab += '\t';
		return *this;
	}

	FORCEINLINE FCodeBuilder& Untab()
	{
		if(!caheTab.IsEmpty())
			caheTab.RemoveAt(caheTab.Len() - 1);

		return *this;
	}

	FORCEINLINE FCodeBuilder& Append(const FString& text)
	{
		Report += text;
		return *this;
	}

	template<typename... ArgTypes>
	FORCEINLINE FCodeBuilder& Append(const FString& text, ArgTypes... args)
	{
		Report += FString::Printf(*text, args...);
		return *this;
	}

	template<typename... ArgTypes>
	FORCEINLINE FCodeBuilder& AppendLine(const FString& text, ArgTypes... args)
	{
		Report += FString::Printf(*text, args...);
		return AppendLine();
	}

	FORCEINLINE FCodeBuilder& AppendLine(const FString& text)
	{
		Report += text;
		return AppendLine();
	}

	FORCEINLINE FCodeBuilder& AppendLine(const TCHAR* Line)
	{
		AppendLine(FString(Line));
		return *this;
	}

	FORCEINLINE FCodeBuilder& AppendLine()
	{
		Report += LINE_TERMINATOR + caheTab;
		return *this;
	}

	FORCEINLINE FCodeBuilder& OpenBrace()
	{
		return Append("{").Tab().AppendLine();
	}

	FORCEINLINE FCodeBuilder& CloseBrace()
	{
		return Untab().AppendLine().AppendLine("}");
	}

	FORCEINLINE void Clear()
	{
		Report.Reset();
		caheTab.Reset();
	}

	FORCEINLINE FCodeBuilder& operator+=(const FString& text)
	{
		Append(text);
		return *this;
	}

	FORCEINLINE FCodeBuilder& operator+=(const TCHAR* text)
	{
		Append(text);
		return *this;
	}

	FORCEINLINE const FString& ToString() const { return Report; }
};