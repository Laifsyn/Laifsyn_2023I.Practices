/* 1.	Lea el día, mes y año de una 5 fechas cualquiera e imprima la fecha del día siguiente
Ejemplo: si la fecha leída es 24/3/2023, entonces, la fecha del día siguiente es 25/3/2023.

NOTA: Tome en cuenta los siguientes elementos:
•	Los años bisiestos son múltiplos de 4.
•	Hay meses que tienen 30 ó 31 días
•	El cambio de año.
•	Utilice el ciclo mientras */


Algoritmo CincoFechas
{
    inicializar en entero a dia = 0, mes = 0, year = 0, cont = 0, iden = 0;

    mientras (cont < 5)
    { 
        mientras (iden == 0)
        {
            imprimir ("Ingrese el día: ");
                leer (dia);
            si (dia <  1 || dia > 31) entonces
                imprimir ("Error: Ingrese un dia válido");
            sino 
                 iden = 1;
        }
        mientras (iden == 1)
        {
            imprimir ("Ingrese el mes: ");
                leer (mes);
            si (mes < 1  || mes > 12) entonces
                imprimir ("Error: Ingrese un mes correcto");
            sino 
                iden = 2;
        }
        mientras (iden == 2)
            {   
                imprimir ("Ingrese el año: ");
                leer (year);
            si (year < 1)
                imprimir ("Error: Ingrese un año válido");
            sino 
                iden = 0;
            }
        
        si (((mes == 2) y (dia > 28) y ((year %4) != 0)) o 
        ((mes == 2) y (dia > 29) y (year %4 == 0)) o 
        (((mes == 4) o (mes == 6) o (mes == 9) o (mes == 11)) y (dia > 30))
        )
            {
                imprimir ("Error: Usted introdujo una fecha incorrecta!")
                cont = cont - 1;
                iden = 3;
            }
        sino si (mes == 2) 
            {
                si (year %4 == 0)
                    si (dia == 29) entonces
                        {
                            mes = mes + 1;
                            dia = 1;
                        }
                    sino 
                        dia = dia + 1;
                sino
                    si (dia == 28) entonces
                        {
                            dia = 1;
                            mes = mes + 1;
                        }
                    sino    
                        dia = dia + 1;
            }
        sino si (mes == 1 || mes == 3 || mes == 5 || mes == 7 || mes == 8 || mes == 10) entonces
            si (dia == 31)
            {
                mes = mes + 1;
                dia = 1;
            }
            sino 
                dia = dia + 1;
        sino si (mes == 12) 
            si (dia == 31)
            {
                dia = 1;
                mes = 1;
                year = year + 1;
            }
            sino 
                dia = dia + 1;
        sino si ((dia == 30) y (mes == 4 || mes == 6 || mes == 9 || mes == 11)) entonces
                { 
                    mes = mes + 1;
                    dia = 1;
                }
            sino 
                dia = dia + 1;
            cont = cont + 1; 
        }
        si (iden == 0)
            imprimir (dia, " / ", mes, " / ",año);
        sino 
            iden = 0;
    }




/* 2.	Dada tres fechas en formato día/mes/año determinar el número de días y el nombre del mes de dicha fecha, e imprimir por pantalla 
la fecha convertida a formato de día  “de” mes “de” año de cada una de las tres fechas leídas.

NOTA: utilice el ciclo para. */
Algoritmo TresFechas
{
    inicializar en entero a dia = 0, mes = 0, year = 0, cont = 0, iden = 0;
    inicializar en cadena a mesN;
    para (cont = 1; cont <= 3; cont = cont + 1)
    {
         {
            imprimir ("Ingrese el día: ");
                leer (dia);
            si (dia <  1 || dia > 31) entonces
                imprimir ("Error: Ingrese un dia válido");
            sino 
                 iden = 1;
        }
        mientras (iden == 1)
        {
            imprimir ("Ingrese el mes: ");
                leer (mes);
            si (mes < 1  || mes > 12) entonces
                imprimir ("Error: Ingrese un mes correcto");
            sino 
                iden = 2;
        }
        mientras (iden == 2)
            imprimir ("Ingrese el año: ");
                leer (year);
            si (year < 1)
                imprimir ("Error: Ingrese un año válido");
            sino 
                iden = 0;
        
        si (((mes == 2) y (dia > 28) y ((year %4) != 0)) o ((mes == 2) y (dia > 29) y (year %4 == 0)) o ((mes == 4) o (mes == 6) o (mes == 9) o (mes == 11)) y dia > 30)
            {
                imprimir ("Error: Usted introdujo una fecha incorrecta!");
                cont = cont - 1;
                iden = 3;
            }
        sino
            si (mes == 1)
                mesN = 'Enero';
            sino si (mes == 2)
                    mesN = 'Febrero';
                sino si (mes == 3)
                    mesN = 'Marzo';
                    sino si (mes == 4)
                            mesN = 'Abril';
                        sino si (mes == 5)
                            mesN = 'Mayo';
                            sino si (mes == 6)
                                    mesN = 'Junio';
                                sino si (mes == 7)
                                        mesN = 'Julio';
                                    sino si (mes == 8)
                                            mesN = 'Agosto';
                                        sino si (mes == 9)
                                                mesN = 'Septiembre';
                                            sino si (mes == 10)
                                                    mesN = 'Octubre';
                                                sino si (mes == 11)
                                                        mesN = 'Noviembre';
                                                    sino si (mes == 12)
                                                            mesN = 'Diciembre';
        si (iden == 0)
            imprimir (dia, " de ", mesN, " de ",año);
        sino 
            iden = 0;
    }
}

