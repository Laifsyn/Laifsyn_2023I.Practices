/* Escriba un algoritmo que lea 25 números enteros cualquiera e imprima la siguiente estadística:
Total de ceros leídos
Suma de los números negativos leídos
Promedio de los números de los positivos leídos */


Algoritmo NumerosEnteros
{
    inicializar en entero a cont=0, totCeros=0, contPos=0;
    inicializar en flotante a sumaPos=0, sumaNeg=0, num=0;
    mientras (cont<25)
        {
            escribir ("Entre un numero: ");
                leer (num);
            si (num==0)
                totCeros=totCeros+1;
            sino
                si(num<0)
                    sumaNeg=sumaNeg+num;
                sino 
                    {
                       contPos = contPos + 1;
                       sumaPos = sumaPos + num; //Estas es calculando el promedio
                    }
                cont = cont + 1;
        }
    escribir ("Total de Ceros= ", totCeros);
    escribir ("Suma de los negativos= ", sumaNeg);
    si (contPos!=0)
        escribir ("El promedio de los positivos= ", sumaPos/contPos);
    sino
        escribir ("No hay numeros positivos");
}


/* Ciclo Hacer-mientras */
Algoritmo NumerosEnteros
{
    inicializar en entero a cont=0, totCeros=0, contPos=0;
    inicializar en flotante a sumaPos=0, sumaNeg=0, num=0;
    hacer 
        {
            escribir ("Entre un numero: ");
            leer (num);
            si (num==0)
                totCeros = totCeros + 1; //Estética
            sino
                si(num<0)
                    sumaNeg = sumaNeg + num; //Estética
                sino 
                    {
                       contPos = contPos + 1;
                       sumaPos = sumaPos + num; //Estas es calculando el promedio
                    }
                cont = cont + 1;
        }
     mientras (cont<25)
    escribir ("Total de Ceros= ", totCeros);
    escribir ("Suma de los negativos= ", sumaNeg);
    si (contPos!=0)
        escribir ("El promedio de los positivos= ", sumaPos/contPos);
    sino
        escribir ("No hay numeros positivos");
}


/* Ciclo Para */
Algoritmo NumerosEnteros
{
    inicializar en entero a cont=0, totCeros=0, contPos=0;
    inicializar en flotante a sumaPos=0, sumaNeg=0, num=0;
    para (cont=0; cont<25; cont = cont + 1)
        {
            escribir ("Entre un numero: ");
                leer (num);
            si (num==0)
                totCeros=totCeros+1;
            sino
                si(num<0)
                    sumaNeg=sumaNeg+num;
                sino 
                    {
                       contPos = contPos + 1;
                       sumaPos = sumaPos + num; //Estas es calculando el promedio
                    }
        }
    escribir ("Total de Ceros= ", totCeros);
    escribir ("Suma de los negativos= ", sumaNeg);
    si (contPos!=0)
        escribir ("El promedio de los positivos= ", sumaPos/contPos);
    sino
        escribir ("No hay numeros positivos");
}



/* 2. Escriba un algoritmo que lea n cantidad de números enteros cualquiera e imprima la siguiente estadística:
Total de números leídos que son menores a 25.
Total de números leídos que se encuentran el rango de 25 y 75, inclusive.
Total de números leídos que son mayores a 75. */

Algoritmo EnterosRango
{
    inicializar en entero a cont=0, numero, cantidad, menor25 = 0, mayor75 = 0, total_rango = 0;

    // unset numero porque no es necesario inicializar en 0.
    // unset cantidad tiene la misma historia.
    imprimir ("Ingrese la cantidad de numeros que desea evaluar");
        leer (cantidad);
    mientras (cont < cantidad)
        {
            imprimir ("Ingrese el numero a evaluar ");
                leer(numero);
                {
                    si (numero < 25) entonces
                        menor25 = menor25 + 1;
                    sino si (numero <= 75) entonces
                        total_rango = total_rango + 1; 
                    sino
                        mayor75 = mayor75 + 1;
                }
            cont = cont + 1;
        }
    imprimir ("El total de numeros menores a 25 son = ", menor25);
    imprimir ("El total de numeros que se encuentran entre el rango de 25 a 75 son = ", total_rango);
    imprimir ("El total de numeros mayores a 75 son = ", mayor75);

}

/* Hacer mientras */
Algoritmo EnterosRango
{
    inicializar en entero a cont=0, numero, cantidad, menor25 = 0, mayor75 = 0, total_rango = 0;

    // unset numero porque no es necesario inicializar en 0.
    // unset cantidad tiene la misma historia.
    imprimir ("Ingrese la cantidad de numeros que desea evaluar");
        leer (cantidad);
    hacer
        {
            imprimir ("Ingrese el numero a evaluar ");
                leer(numero);
                {
                    si (numero < 25) entonces
                        menor25 = menor25 + 1;
                    sino si (numero <= 75) entonces
                        total_rango = total_rango + 1; 
                    sino
                        mayor75 = mayor75 + 1;
                }
            cont = cont + 1;
        }
        mientras (cont < cantidad);    // Si entiendes porqué no ``(cont <= cantidad)``?
            imprimir ("El total de numeros menores a 25 son = ", menor25);
            imprimir ("El total de numeros que se encuentran entre el rango de 25 a 75 son = ", total_rango);
            imprimir ("El total de numeros mayores a 75 son = ", mayor75);
        
}

/* Para*/
Algoritmo EnterosRango
{
    inicializar en entero a cont, numero, cantidad, menor25 = 0, mayor75 = 0, total_rango = 0;

    // unset cont solo para que sepas que no es necesario asignarle valor debido al Para() definido abajo.
    // unset numero tiene similar historia.
    // unset cantidad tiene similar historia.
    imprimir ("Ingrese la cantidad de numeros que desea evaluar");
        leer (cantidad);
    para (cont = 0; cont < cantidad; cont = cont + 1) 
        {
            imprimir ("Ingrese el numero a evaluar ");
                leer(numero);
                {
                    si (numero < 25) entonces
                        menor25 = menor25 + 1;
                    sino si (numero <= 75) entonces
                        total_rango = total_rango + 1; 
                    sino 
                        mayor75 = mayor75 + 1;
                }
        }
    imprimir ("El total de numeros menores a 25 son = ", menor25);
    imprimir ("El total de numeros que se encuentran entre el rango de 25 a 75 son = ", total_rango);
    imprimir ("El total de numeros mayores a 75 son = ", mayor75);

}

/* 3. Escriba un algoritmo que imprima la tabla del 7. Donde el multiplicador debe ir de 1 hasta 10. 
Ejemplo de la salida.
7 *  1 =   7
7 *  2 = 14
  .     .      .
7 * 10 = 70 */

Algoritmo MientrasTablaDel7
{
    inicializar en entero a multiplicador = 1;


    mientras (multiplicador <= 10)
        {
            imprimir ("La tabla del número 7= ");
            imprimir (7, " x ", multiplicador," = ", 7 * multiplicador);
            multiplicador = multiplicador + 1;
        }
}

/* HacerMientras */
Algoritmo HacerMientrasTablaDel7
{
    inicializar en entero a multiplicador = 1;

    hacer
        {
            imprimir ("La tabla del número 7= ");
            imprimir (7, " x ", multiplicador," = ", 7 * multiplicador);
            multiplicador = multiplicador + 1;
        }
    mientras (multiplicador <= 10);
}

/* Para */
Algoritmo TablaDel7
{
    inicializar en entero a multiplicador = 0, multiplicando = 0;

    para (multiplicador = 1; multiplicador <= 10; multiplicando++) // <= Estética. pero En Java > miVar++; < segun el profe
        {
            imprimir ("La tabla del número 7= ");
            imprimir (7, " x ", multiplicador," = ", 7 * multiplicador);
        }
}



/* 4. Escribir un algoritmo que imprima las tablas de multiplicar de 4, 5, 6, 7 y 8. Donde el multiplicador debe ir de 1 hasta 10. */
Algoritmo HacerMientrasTablasDel4Al8
{
    inicializar en entero a multiplicando=4, multiplicador=1;
    hacer
    {
        multiplicador = 1;
        escribir ("Tabla Numero: ", multiplicando);
        Mientras (multiplicador <=10)
            {
                escribir (multiplicando, " * ", multiplicador, " = ", multiplicando * multiplicador);
                multiplicador = multiplicador +1;
            }
        multiplicando++; // <= Estética
    }
    mientras (multiplicando <=8);
}


    
/* Ciclo Mientras */
Algoritmo MientrasTablasDel4Al8
{
    inicializar en entero a multiplicando=4, multiplicador=1;
    Mientras (multiplicando<=8)
    multiplicando = 4; 
    {
        multiplicador = 1;
        escribir ("Tabla Numero: ", multiplicando);
        Mientras (multiplicador <=10)
            {
                escribir (multiplicando, " * ", multiplicador, " = ", multiplicando * multiplicador);
                multiplicador = multiplicador +1;
            }
        multiplicando++; // <= Estética
    }
}

/* Ciclo Para */
Algoritmo tablas
{
    inicializar en entero a multiplicando=4, multiplicador=1;
    para (multiplicando=4; multiplicando<=8; multiplicando = multiplicando + 1)
    {
        escribir ("Tabla Número: ", multiplicando);
        para (multiplicador=1; multiplicador <=10; multiplicador = multiplicador +1 );
            escribir (multiplicando, " * ", multiplicador, " = ", multiplicando * multiplicador);
    }
}