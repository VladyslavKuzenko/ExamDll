
extern "C" __declspec(dllexport) double Add(double a, double b);
extern "C" __declspec(dllexport) double Mul(double a, double b);
extern "C" __declspec(dllexport) double Div(double a, double b);
extern "C" __declspec(dllexport) double Sub(double a, double b);
//st-windows
//cd-linux
#pragma once

#ifdef MDLL_EXPORTS
#define MDLL_API __declspec(dllexport)
#else
#define MDLL_API __declspec(dllimport)
#endif
extern "C" MDLL_API void SetError();