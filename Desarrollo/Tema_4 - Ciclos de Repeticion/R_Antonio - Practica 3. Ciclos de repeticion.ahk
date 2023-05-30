;   Practica 3

/*
1.	Lea el día, mes y año de una 5 fechas cualquiera e imprima la fecha del día siguiente
Ejemplo: si la fecha leída es 24/3/2023, entonces, la fecha del día siguiente es 25/3/2023.

NOTA: Tome en cuenta los siguientes elementos:
•	Los años bisiestos son múltiplos de 4.
•	Hay meses que tienen 30 ó 31 días
•	El cambio de año.
•	Utilice el ciclo mientras
*/

{
    Inicializar en Entero dia, mes, anual, indice = 1, diasFebrero;     
    Mientras (indice <= 5)
    {
        indice++;
        Imprimir("Ingrese el año");
        Leer(anual);
        si (anual < 1)
            Imprimir("Fecha fuera de rango");

        Imprimir("Ingrese el mes");
        Leer(mes);
        Imprimir("Ingrese el día");
        Leer(dia);
        si (dia < 1 || dia > 31 || mes > 12 || mes < 1)
            Imprimir("Fecha fuera de rango");

        si ((mes == 4 || mes == 6 || mes == 9 || mes == 11) )
            { //resuelve meses de 30 dias
                si (dia == 30) //Resuelve salto de mes
                {
                    dia = 1;
                    mes++;
                }
                sino si ( dia > 30)  //resuelve fuera de rango
                    Imprimir("Día fuera de rango");
                sino 
                    dia++;
            }
        sino si (mes == 2)
            { //resuelve Febrero
                
                si ((anual%4 == 0 && anual%100 != 0) || anual%400 == 0) //para Año bisiestos
                    diasFebrero = 29;
                sino //para Año no bisiesto
                    diasFebrero = 28;

                si (dia > diasFebrero)
                    Imprimir("Día Fuera de rango");
                sino si (dia == diasFebrero) //Resuelve salto de mes
                {
                    dia = 1;
                    mes++;
                }
                sino 
                    dia++;
            }
        sino si (dia == 31)
        {   \\ Resuelve Dias de 31
            si (mes == 12) // Resuelve Salto de Año
                {
                    anual++; mes = 1; dia = 1;
                }
            sino
                {
                    dia = 1; mes++;
                }
        }
        sino 
            dia++;
        
        Imprimir(dia, "/", mes , "/", anual);
    }
}


/*
2.	Dada tres fechas en formato día/mes/año determinar el número de días y el nombre del mes de dicha fecha, e imprimir por pantalla la fecha convertida a formato de día  “de” mes “de” año de cada una de las tres fechas leídas.

NOTA: utilice el ciclo para.
*/

{
    Inicializar en Cadena mesNombre = "";
    Inicializar en Entero dia, mes, anual, indice = 1, diasFebrero, iteracion;

    Para(iteracion = 1; iteracion <= 3; iteracion++)
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
