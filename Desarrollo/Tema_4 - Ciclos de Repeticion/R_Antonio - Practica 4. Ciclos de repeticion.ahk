;   Practica 4

/*
1.	Elaborar un algoritmo que realice las siguientes operaciones:
    •	Lea el nombre del estudiante, el total de respuestas correctas, total de respuestas incorrectas y total de respuestas en blanco de 50 exámenes.
    •	Por cada estudiante el algoritmo debe imprimir el nombre del estudiante y su puntaje final, teniendo en cuenta que:
        o	Las respuestas correctas valen 4 puntos.
        o	Por cada respuesta incorrecta se descontará 1 punto.
        o	Por cada respuesta en blanco tendrá cero (0) puntos.

*/

{
    Inicializar en Entero noExamen, right, wrong, blanks;
    Inicializar en Cadena nombre
    Para(noExamen = 1; noExamen <= 50; noExamen++)
    {
        Imprimir("Ingrese el nombre");
        Leer(nombre);
        Imprimir("Ingrese las respuestas correctas");
        Leer(right);
        si (right < 0)
            Imprimir("Numero inválido");

        Imprimir("Ingrese respuestas incorrectas");
        Leer(wrong);
        si (wrong < 0)
            Imprimir("Numero inválido");

        Imprimir("Ingrese respuestas en blanco");
        Leer(blanks);
        si (blanks < 0)
            Imprimir("Numero inválido");

        Imprimir("Puntaje final de ", nombre, ":", right * 4 + wrong);
    }

}


/*
2.	Escriba un algoritmo que realice las siguientes operaciones:
    •	Lea la base, altura y los dos lados de 100 triángulos distinto
    •	Por cada triángulo leído el programa de imprimir su AREA y PERIMETRO.  

*/

{
    Inicializar en Flotante base, altura, lado1, lado2;
    Inicializar en Entero iteration = 1;
    mientras (iteration <= 100){
        Imprimir("Ingrese la longitud de la base");
        Leer(base);
        si (base <= 0)
            imprimir("Componente del triángulo no es positivo?");

        Imprimir("Ingrese la altura del triángulo");
        Leer(altura);
        si (altura <= 0)
            imprimir("Componente del triángulo no es positivo?");

        Imprimir("Ingrese la longitud de un lado del triángulo");
        Leer(lado1);
        si (lado1 <= 0)
            imprimir("Componente del triángulo no es positivo?");

        Imprimir("Ingrese la longitud del otro lado del triángulo");
        Leer(lado2);
        si (lado2 <= 0)
            imprimir("Componente del triángulo no es positivo?");

        Imprimir("Perímetro:", base+lado1+lado2);
        Imprimir("Área:"), base*altura/2;
        iteration++;
    }
}


/*
3.	Elabore un algoritmo para obtener el resultado del escrutinio de las elecciones de delegados, 
considere que hay 160 electores, y hay 3 candidato, todos los electores votaron, el elector debe declarar al ganador por mayoría simple.

*/

{
    Inicializar en Entero delegado1, delegado2, delegado3, mayor, suma;
    Inicializar en Cadena ganador;
    
    Imprimir("Ingrese Votos para Delegado 1");
    Leer(delegado1);
    si (delegado1 < 0)
        Imprimir("Cantidad de votos inválidos");
    
    Imprimir("Ingrese Votos para Delegado 2");
    Leer(delegado2);
    si (delegado2 < 0)
        Imprimir("Cantidad de votos inválidos");
    
    Imprimir("Ingrese Votos para Delegado 3");
    Leer(delegado3);
    si (delegado3 < 0)
        Imprimir("Cantidad de votos inválidos");
    suma = delegado1 + delegado2 + delegado3;
    si (suma != 160)
        Imprimir("Se esperan 160 votos, pero se contaron ", suma, " votos");

    si (delegado1 == delegado2 || delegado1 == delegado3 || delegado2 == delegado3 )
        imprimir("No todos los delegados tienen votos distintos. Es imposible determinar el ganador por mayoría simple.");
    mayor = delegado1;
    ganador = "Delegado 1";

    si (mayor < delegado2){
        mayor = delegado2;
        ganador = "Delegado 2";
    }
    
    si (mayor < delegado3){
        mayor = delegado3;
        ganador = "Delegado 3";
    }
    Imprimir("El ", ganador, " con ", mayor, " votos, gana las elecciones!");

}



/*
4.	Escriba un algoritmo que realice las siguientes operaciones:
    a.	Lea 5 veces tres números que denoten una fecha (día, mes, año). 
    b.	Por cada fecha leída, el programa debe comprobar que es una fecha válida.
        i.	Si es válida escribir la fecha cambiando el número del mes por su nombre. Ej. si se introduce 1 2 2006, se deberá imprimir “1 de febrero de 2006”.
        ii.	 Si no es válida escribir un mensaje de error. 

NOTA: Para validar la fecha debe contemplar las siguientes consideraciones:
•	El día, mes y año leído deben ser mayores a cero (0).
•	El día debe ser menor o igual 31
•	El mes debe ser menor o igual 12
•	Los años bisiestos son múltiplos de 4.
•	Si la fecha es 31 de diciembre
•	Los meses que tienen 30 días.
•	Los meses que tienen 31 días.
•	Las fechas invalidas no se toman en cuenta dentro de las 5 lecturas.

*/

{
    Inicializar en Cadena mesNombre = "";
    Inicializar en Entero dia, mes, anual, indice = 1, diasFebrero, iteracion;

    Para(iteracion = 1; iteracion <= 5; iteracion++)
    {
        indice++;
        Imprimir("Ingrese el día");
        Leer(dia);
        si (dia < 1 || dia > 31)
            Imprimir("Día fuera de rango");

        Imprimir("Ingrese el mes");
        Leer(mes);
        segun (mes) Hacer
        {
            caso 1 :mesNombre = "Enero"; detener;
            caso 2 :mesNombre = "Febrero"; detener;
            caso 3 :mesNombre = "Marzo"; detener;
            caso 4 :mesNombre = "Abril"; detener;
            caso 5 :mesNombre = "Mayo"; detener;
            caso 6 :mesNombre = "Junio"; detener;
            caso 7 :mesNombre = "Julio"; detener;
            caso 8 :mesNombre = "Agosto"; detener;
            caso 9 :mesNombre = "Septiembre"; detener;
            caso 10:mesNombre = "Octubre"; detener;
            caso 11:mesNombre = "Noviembre"; detener;
            caso 12:mesNombre = "Diciembre"; detener;
            defecto: Imprimir("Mes inválido");
        }

        Imprimir("Ingrese el año");
        Leer(anual);
        si (anual < 1)
            Imprimir("Año fuera de rango");
            
        si ((mes == 4 || mes == 6 || mes == 9 || mes == 11) && (dia > 30))
            Imprimir("Día fuera de rango");
        sino si (mes == 2)
            { //resuelve Febrero
                si ((anual%4 == 0 && anual%100 != 0) || anual%400 == 0) //para Año bisiestos
                    diasFebrero = 29;
                sino //para Año no bisiesto
                    diasFebrero = 28;

                si (dia > diasFebrero)
                    Imprimir("Día fuera de rango");
            }
        Imprimir("Fecha: ", dia, " de ", mesNombre, " de ", anual);
    }
}
