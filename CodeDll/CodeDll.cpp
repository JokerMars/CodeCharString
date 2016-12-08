// CodeDll.cpp : Defines the exported functions for the DLL application.
//

#include "stdafx.h"
#include <stdio.h>

extern "C" __declspec(dllexport)
void outputAscii(char * str)
{
	printf("%s\n", str);
}

extern "C" __declspec(dllexport)
void outputUnicode(LPCWSTR name)
{
	printf("%ws\n", name);
}

