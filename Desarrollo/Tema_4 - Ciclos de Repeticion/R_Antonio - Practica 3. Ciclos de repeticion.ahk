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
    Inicializar en Entero dia, mes, anual, indice = 1;
    //
    Mientras (indice <= 5)
    {
        Imprimir("Ingrese el dia");
        Leer(dia);
        Imprimir("Ingrese el mes");
        Leer(mes);
        Imprimir("Ingrese el año");
        Leer(anual);

        si (dia == 30 && (mes == 4 || mes == 6 || mes == 9 || mes == 11))
            { //resuelve meses de 30 dias
                dia = 1;
                mes++;
            }
        sino si (mes == 2)
            { //resuelve Febrero
                si ((anual%4 == 0 && anual%100 != 0) || anual%400 == 0) //para Año bisiestos
                    {
                        si (dia == 29)
                        {
                            dia = 1;
                            mes++;
                        }
                        sino 
                            dia++;
                    }
                sino //para Año no bisiesto
                    {
                        si (dia == 29)
                        {
                            dia = 1;
                            mes++;
                        }
                        sino 
                            dia++;
                    }
            }
        sino si (dia == 31)
        {   \\ Resuelve Dias de 31
            si (mes == 12) // Salto de Año
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
        
        Imprimir(anual, "/", mes , "/", dia);
    }
}




/*
2.	Dada tres fechas en formato día/mes/año determinar el número de días y el nombre del mes de dicha fecha, e imprimir por pantalla la fecha convertida a formato de día  “de” mes “de” año de cada una de las tres fechas leídas.

NOTA: utilice el ciclo para.
*/

