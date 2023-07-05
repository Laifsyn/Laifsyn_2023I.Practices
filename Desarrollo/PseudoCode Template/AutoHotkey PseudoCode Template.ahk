#Requires AutoHotkey v2.0
#include <UDF>
#include %A_ScriptDir%\DI_PseudoCode.ahk
console.print("Hello")
main()

sumRange(matrix, row_i, col_i, row, col){
    sum := 0, index := unset ;
    while ( row_i <= row) {
        index := col_i ;
        while ( index <= col){
            sum += matrix[row_i + 1][index + 1] ;
            index++ ;
        }
        row_i++ ;
    }
    return sum ;
}

main(){
    MAT := ArrayWithPrint(4) ;
    Loop 4
       MAT[A_Index] := (ArrayWithPrint(4, A_Index "?"))
    Imprimir(ImprimirMatrizJSON(MAT,true))

    row := 0, col := 0, index := unset, auxiliarIndex := unset, suma := unset ;

    ;// Llenamos de valores a la matriz
    while (row < MAT.Length){
        col := 0
        while (col < MAT[1].Length){
            Escribir("Ingrese un número para [", row, "][", col,"]") ;
            MAT[row + 1][col + 1] := Leer() ;
            col++ ;
        }
        row++ ;
    }
    Imprimir(ImprimirMatrizJSON(MAT, true))
    ;//Imprimir la suma de cada fila
    index := 0 ;
    while ( index < MAT.Length ){
        Imprimir("Suma de la fila ", index, ": ", sumRange(MAT, index, 0, index, 3 )) ;
        index++ ;
    }

    ;//Imprimir la suma de cada columna
    index := 0 ;
    while ( index < MAT.Length ){
        Imprimir("Suma de la Columna ", index, ": ", sumRange(MAT, 0, index, 3, index )) ;
        index++ ;
    }

    ;//Imprimir la suma de todos los elementos de la matriz
    Imprimir("La suma de cada elemento de la matriz MAT: ", sumRange(MAT, 0, 0, 3, 3 )) ;

    ;//Imprimir la Suma de los impares en la diagonal Secundaria
    index := 0 ;
    suma := 0 ;
    auxiliarIndex := MAT.Length-1 ;
    while ( index < MAT.Length ){
        if (Mod(MAT[index + 1][auxiliarIndex + 1] , 2) == 1)
            suma += MAT[index + 1][auxiliarIndex + 1] ;
        index++ ;
        auxiliarIndex-- ;
    }
    Imprimir("La suma de la diagonal secundaria es: ", suma) ;

    ;//Imprimir los números de la diagonal Principal
    index := 0 ;
    Imprimir("Numeros de la diagonal principal:") ;
    while ( index < MAT.Length ){
        Imprimir(MAT[index + 1][index + 1]) ;
        index++ ;
    }

    ;//Imprimir el Mayor en la fila 2
    mayorIndex:=0 ;
    index := 1 ;
    while ( index < MAT[2].Length){
        if (MAT[2][mayorIndex + 1] < MAT[2][index + 1])
            mayorIndex := index ;
        index++ ;
    }
    Imprimir("En la fila 2, el mayor es " MAT[2][mayorIndex + 1]) ;
    
    ;//Imprimir  promedio de los almacenados en la columna 0
    Imprimir("Promedio de la columna 0: ", sumRange(MAT, 0, 0, 3, 3 ) / MAT.Length) ;

    ;//Imprimir Las repeticiones de un numero leído
    buscarNum := unset ;
    Escribir("Ingrese un número a buscar: ") ; 
    buscarNum := Leer() ;
    row := 0 ;
    col := 0 ;
    suma := 0 ;
    while (row < MAT.Length){
        col := 0 ;
        while (col < MAT[1].Length){
            if (buscarNum == MAT[row + 1][col + 1])
                suma++ ;
            col++ ;
        }
        row++ ;
    }
    Imprimir("Tu numero se repitió ", suma, " veces en el arreglo") ;

}

^r:: Reload
Leer(&var?) {
    return console.Leer(&var)
}