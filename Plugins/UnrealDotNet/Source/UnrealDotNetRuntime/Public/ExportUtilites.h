#pragma once

#ifndef DOTNET_EXPORT
# if defined(WIN32)
#   define DOTNET_EXPORT __declspec(dllexport)
# elif defined(__GNUC__)
#  define DOTNET_EXPORT __attribute__ ((visibility ("default")))
# endif
#endif

typedef struct ObjectPointerDescription
{
	INT_PTR Pointer;
	INT_PTR TypeName;
	int32 TypeNameLen;
}
ObjectPointerDescription;

typedef struct StringWrapper
{
	INT_PTR Pointer;
	int32 Len;
}
StringWrapper;

typedef struct TemplatePointerDescription
{
	INT_PTR Pointer;
	INT_PTR TypeName;
	int32 TypeNameLen;
}
TemplatePointerDescription;

typedef struct UClassWrapper
{
	INT_PTR Pointer;
	int32 Len;
} UClassWrapper;