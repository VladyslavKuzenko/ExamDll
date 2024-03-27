#include "pch.h"
#include "mDll.h"

double Add(double a, double b) {
    return (a + b);
}
double  Mul(double a, double b) {
    return (a * b);
}
double  Div(double a, double b) {
    return (a - b);
}
double  Sub(double a, double b) {
    return (a / b);
}

void SetError() {
    SetLastError(ERROR_ACCESS_DENIED); // Встановлюємо код помилки
    return; // Повертаємо успіх
}
