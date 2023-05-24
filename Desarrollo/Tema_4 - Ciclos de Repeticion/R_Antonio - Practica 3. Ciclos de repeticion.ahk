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
    
    Mientras (indice <= 5)
    {
        Imprimir("Ingrese el dia");
        Leer(dia);
        Imprimir("Ingrese el mes");
        Leer(mes);
        Imprimir("Ingrese el año");
        Leer(anual);
        si (dia > 31 || dia < 1 || mes > 12 || mes < 1 || anual < 1)
            Imprimir("Fecha fuera de rango");

        mes30 = (mes == 4 || mes == 6 || mes == 9 || mes == 11);
     ;//si (dia == 30 && mes30 )
        si (dia == 30 && (mes == 4 || mes == 6 || mes == 9 || mes == 11))
            { //resuelve meses de 30 dias
                si (dia == 30)
                dia = 1;
                mes++;
            }
        sino si (mes == 2)
            { //resuelve Febrero
                
                si ((anual%4 == 0 && anual%100 != 0) || anual%400 == 0) //para Año bisiestos
                    {
                        si (dia > 29)
                            Imprimir("Dia invalida");
                        sino si (dia == 29)
                        {
                            dia = 1;
                            mes++;
                        }
                        sino 
                            dia++;
                    }
                sino //para Año no bisiesto
                    {
                        si (dia > 28)
                            Imprimir("Dia invalido");
                        sino si (dia == 28)
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
        sino si (dia > 30)
            Imprimir("Dia invalido");
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
    Inicializar en Cadena fecha, fechaFinal = "", mes = "", temporal;
    Inicializar en Entero indice, leyoSlash=0, iteracion;

    Para(iteracion = 1; iteracion <= 3; iteracion++)
    {
        Imprimir("Ingrese la fecha dd/mm/yyyy");
        leer(fecha);

        Para(indice = 1; fecha[indice] != ""; indice++)
        {
            temporal = fecha[indice];
            si (temporal == "/")
                {
                    leyoSlash++;
                    temporal = " de ";
                }

            si (leyoSlash == 2) //Para esta altura ya tenemos los digitos de meses, asi que evaluamos el mes.
            {
                leyoSlash++; //Aumentamos para que que no llame este bloque de codigo cuando esté concatenando año.
                segun (mes) Hacer
                {
                    caso "1" :mes = "Enero"; detener;
                    caso "2" :mes = "Febrero"; detener;
                    caso "3" :mes = "Marzo"; detener;
                    caso "4" :mes = "Abril"; detener;
                    caso "5" :mes = "Mayo"; detener;
                    caso "6" :mes = "Junio"; detener;
                    caso "7" :mes = "Julio"; detener;
                    caso "8" :mes = "Agosto"; detener;
                    caso "9" :mes = "Septiembre"; detener;
                    caso "10":mes = "Octubre"; detener;
                    caso "11":mes = "Noviembre"; detener;
                    caso "12":mes = "Diciembre"; detener;
                    defecto: Imprimir("Mes inválido");
                }
                temporal = (mes, temporal) //Obtenemos algo como >"Noviembre", " de "<
            }
            // Porque estamos evaluando la parte de mes, no concatenamos nada en el resultado final
            si (leyoSlash == 1 && mes != "" && temporal != "0")  // Si resulta que mes está vacio, y el primer digito es 0, significa que tenemos algo como "08", asi que lo obviamos.
                mes = (mes, temporal);
            sino
                fechaFinal = (fechaFinal, temporal);
        }
        Imprimir("Fecha: ", fechaFinal);
    }


























}
