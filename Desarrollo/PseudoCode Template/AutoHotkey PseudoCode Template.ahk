#Requires AutoHotkey v2.0
#include %A_ScriptDir%\DI_PseudoCode.ahk
#include <UDF>
console.print("Hello")
main()

isInCharList(char, lista) {
    index := 0 ;
    while (index < lista.Length) {
        if (char == lista[index + 1])
            return index ;
        index++ ;
    }
    return -1 ;
}

main() {
    index := 0, cont_UserChar := 0, cont_u := 0, cont_Vocales := 0, cont_Consonantes := 0 ;
    cont_i := 0 ;
    listVowels := Array('a', 'e', 'i', 'o', 'u'), LETRAS := ArrayOfSize(20), UserChar := unset ;
    while (index < LETRAS.Length) {
        Escribir(index + 1, "-)Ingrese un caracter: ") ;
        Leer(&auxiliarVar) ;
        LETRAS[index + 1] := auxiliarVar
        index++ ;
    }

    index := 0 ;
    Escribir(index, "-)Ingrese un caracter a contar: ") ;
    Leer(&UserChar) ;  => UserChar = 'b'
    while (index < LETRAS.Length) {
        if (isInCharList(LETRAS[index + 1], listVowels) != -1) {
            cont_Vocales++ ;
            if (LETRAS[index + 1] == 'u')
                cont_u++ ;
            else if (LETRAS[index + 1] == 'i')
                cont_i++ ;
        } else
            cont_Consonantes++ ;

        if (LETRAS[index + 1] == UserChar) ; //Si (LETRAS[index] == 'b')
            cont_UserChar++ ;
        index++ ;
    }

    Imprimir("Total de Vocales: ", cont_Vocales) ;
    Imprimir("Total de Consonantes: ", cont_Consonantes) ;
    Imprimir("Total de caracteres u: ", cont_u) ;
    Imprimir("User:Total de caracteres ", UserChar, " : ", cont_UserChar) ;
    Imprimir("Porcentaje de i: ", Round( cont_i / LETRAS.Length * 100, 2), "%") ;
}

^r:: Reload
Leer(&var) {
    console.Leer(&var)
}