#Requires AutoHotkey v2.0
#include <UDF>
#include %A_ScriptDir%\DI_PseudoCode.ahk
console.print("Hello")
main()

funcMultiplos(num)
{
    
    cont1 := 0, index := 0 ;
    while (index < num.Length) {
        if (Mod(num[index + 1], 3) = 0 and num[index + 1] >= 25 and num[index + 1] <= 75)
            Cont1++ ;
        index++ ;
    }
    return cont1 ;
}
funcPromedio(num)
{
    indice := 0 ;
    if (indice == 0)
    {
        Promedio := 0 ;
        cont1 := 0, cont2 := 0 ;
    }

    While (indice < num.Length)
    {
        if (Mod(num[indice + 1], 2) == 0)
        {
            Cont1 := cont1 + num[indice + 1] ;
            Cont2++ ;
        }
        indice++
    }
    Promedio := cont1 / cont2 ;
    Imprimir("El promedio de los números pares es de ", promedio) ;

}
funcRepeticion(num1, num2)
{
    cont1 := 0, indice := 0 ;
    while (indice < num1.Length) {
        if (num1[indice + 1] == num2)
            cont1++ ;
    indice++ ;
    }
    Imprimir("El numero ", num2, " se repite ", cont1, " veces")
}
main()
{

    num1 := ArrayWithPrint(15), indice := 0, num2 := unset, ubicacion := unset, mayor := unset ;
    Escribir("Ingrese un numero para buscar cuantas veces se repite: ") ;
    Leer(&num2) ;
    ;Para (indice=0; indice<25; indice++)
    While (indice < num1.Length)
    {
        Escribir("Ingrese un numero - ", indice, ": ") ;
        num1[indice + 1] := Random(22,35) ;
        if (indice == 0 || num1[indice + 1] > mayor)
        {
            mayor := num1[indice + 1] ;
            ubicacion := indice ;
            Imprimir(A_Tab, "nuevo Mayor:", mayor) ;
        }
        indice++ ;
    }
    Imprimir("El total de números repetidos son ", funcMultiplos(num1)) ;
    funcPromedio(num1) ;
    FuncRepeticion(num1, num2) ;
    Imprimir("El número mayor es: ", mayor, " y está ubicado en el vector: ", ubicacion) ;
}


^r:: Reload
Leer(&var?) {
    return console.Leer(&var)
}