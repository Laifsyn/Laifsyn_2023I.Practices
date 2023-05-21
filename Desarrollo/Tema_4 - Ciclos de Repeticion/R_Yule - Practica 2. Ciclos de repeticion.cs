/* 1.	Escribir un algoritmo que lea el nombre y 3 notas de 20 estudiantes. El programa debe calcular e imprimir el promedio y nota final de cada   estudiante.
Recuerde que:
•	El promedio del estudiante es igual a la suma de sus notas entre la cantidad de notas.
•	La nota final del estudiante se establece de acuerdo a su promedio:
Promedio            Notas final
 100 a 91                     A
   90 a 81                     B
   80 a 71                     C
   70 a 61                     D
   61 a  0                      F */

Algoritmo MientrasPromedioFinal
{
    inicializar en entero a nota1 = 0, nota2 = 0, nota3 = 0, cont = 1;
    inicializar en flotante a promedio = 0;
    inicializar en cadena a nombre, NotaFinal;

    mientras (cont <= 20)
    {
      imprimir ("Ingrese el nombre del estudiante: ");
        leer (nombre);
       imprimir ("Inserte nota 1: ");
         leer (nota1);
       imprimir ("Inserte nota 2: ");
         leer (nota2);
        imprimir ("Inserte nota 3: ");
         leer (nota3);

    promedio = (nota1 + nota2 + nota3)/3.0;

    si (promedio >= 91) entonces
        notaFinal = 'A';

        sino si (promedio >= 81)
           notaFinal = 'B';

           sino si (promedio >= 71)
              notaFinal = 'C';

              sino si (promedio >= 61)
                notaFinal = 'D';

                sino 
                  notaFinal = 'F';
        imprimir ("El estudiante ", nombre," tiene promedio de: ", promedio, " y nota final de: ", notaFinal);
    }
}

/* Ciclo para */
Algoritmo MientrasPromedioFinal
{
    inicializar en entero a nota1 = 0, nota2 = 0, nota3 = 0, cont = 0;
    inicializar en flotante a promedio = 0;
    inicializar en cadena a nombre, NotaFinal;

    para (cont = 1; cont <= 20; cont = cont + 1)
    {
       imprimir ("Ingrese el nombre del estudiante: ");
        leer (nombre);
       imprimir ("Inserte nota 1: ");
         leer (nota1);
       imprimir ("Inserte nota 2: ");
         leer (nota2);
        imprimir ("Inserte nota 3: ");
         leer (nota3);

    promedio = (nota1 + nota2 + nota3)/3.0;

    si (promedio >= 91) entonces
        notaFinal = 'A';

        sino si (promedio >= 81)
           notaFinal = 'B';

           sino si (promedio >= 71)
              notaFinal = 'C';

              sino si (promedio >= 61)
                notaFinal = 'D';

                sino 
                  notaFinal = 'F';
        imprimir ("El estudiante ", nombre," tiene promedio de: ", promedio, " y nota final de: ", notaFinal);
    }
}


/* 2.	Desarrolle un algoritmo que lea el nombre, salario básico por hora y el número de horas trabajadas de 10 empleados. Calcular e imprimir el salario bruto, el descuento y el salario neto de cada empleado. Debe tener en cuenta para el calculo de el descuento lo siguiente:

»	Para el salario bruto menor a 500 no hay descuento.
»	Para el salario bruto entre 500 hasta 1,000 inclusive el porcentaje de la descuento es 2%.
»	Para un salario bruto mayor a 1,000 el porcentaje de descuento es 5%.
El programa debe imprimir el nombre del empleado, el salario bruto, el descuento y el salario neto de cada empleado. */

Algoritmo Salario
{
    inicializar en entero horTrabajadas = 0, cont = 1;
    inicializar en flotante a salHora = 0, salBruto = 0, salNeto = 0, descuento = 0, descuentoSal = 0;
    inicializar en cadena a nombre;

    mientras (cont <= 10)
      {
         imprimir ("Ingrese su nombre: ");
           leer (nombre);
         imprimir ("Ingrese su salario: ");
           leer (salHora);
         imprimir ("Ingrese sus horas trabajadas: ");
           leer (horTrabajadas);

        salBruto = salHora * horTrabajadas;
              si ((salBruto>=500) y (salBruto<=1000)) entonces
                descuento = 0.02;
              sino
                  si (salBruto>1000) entonces
                    descuento = 0.05;   
        descuentoSal = salBruto * descuento;
        salNeto = salBruto - descuentoSal;
        imprimir (nombre, " recibe un salario bruto de: ", salBruto, " que al recibir un descuento de: ", descuento, " tiene un salario neto de: ", salNeto);
        cont = cont + 1;
      }
}

// Ciclo Para

Algoritmo Salario
{
    inicializar en entero horTrabajadas = 0, cont = 0;
    inicializar en flotante a salHora = 0, salBruto = 0, salNeto = 0, descuento = 0, descuentoSal = 0;
    inicializar en cadena a nombre;

    para (cont = 1; cont <= 10, cont = cont + 1)
      {
         imprimir ("Ingrese su nombre: ");
           leer (nombre);
         imprimir ("Ingrese su salario: ");
           leer (salHora);
         imprimir ("Ingrese sus horas trabajadas: ");
           leer (horTrabajadas);

        salBruto = salHora * horTrabajadas;
              si ((salBruto >= 500) y (salBruto <= 1000)) entonces
                descuento = 0.02;
              sino
                  si (salBruto > 1000) entonces
                    descuento = 0.05;   
        descuentoSal = salBruto * descuento;
        salNeto = salBruto - desceuntoSal;
        imprimir (nombre, " recibe un salario bruto de: ", salBruto, " que al recibir un descuento de: ", descuento, " tiene un salario neto de: ", salNeto);
      }
}


/*3.	Escribir un algoritmo que lea 15 veces tres números enteros cualquiera cada vez e imprima las siguientes estadísticas:
•	Imprima el tercer número si la suma del primero número más el segundo número es menor o igual a 20.
•	Imprima el primer número si el segundo número es diferente al tercer número.
•	Imprima la suma de los tres números si esta es mayor a 50. */

Algoritmo TresNumeros
{
   inicializar en entero a num1 = 0, num2 = 0, num3 = 0, cont = 0, suma;

      mientras (cont < 15)
      {
        imprimir ("Ingrese el primer número: ");
          leer (num1);
        imprimir ("Ingrese el segundo número: ");
          leer (num2);
        imprimir ("Ingrese el tercer número: ");
          leer (num3);
        suma = num1 + num2 + num3;
        si (num1 + num2 <= 20) entonces
          imprimir ("El tercer número es: ", num3);
        sino 
          si (num2 != num3) entonces
            imprimir ("El primer número es: ", num1);
          sino 
            si (suma>50) entonces
              imprimir ("La suma de los tres números es: ", suma);
      }
      cont = cont + 1;
}

//Ciclo para
Algoritmo TresNumeros
{
   inicializar en entero a num1 = 0, num2 = 0, num3 = 0, cont = 0, suma;

      para(cont = 0; cont < 15; cont = cont + 1)
      {
        imprimir ("Ingrese el primer número: ");
          leer (num1);
        imprimir ("Ingrese el segundo número: ");
          leer (num2);
        imprimir ("Ingrese el tercer número: ");
          leer (num3);
          suma = num1 + num2 + num3;
        si (num1 + num2 <= 20) entonces
          imprimir ("El tercer número es: ", num3);
        sino 
          si (num2 != num3) entonces
            imprimir ("El primer número es: ", num1);
          sino 
            si (suma>50) entonces
              imprimir ("La suma de los tres números es: ", suma);
      }
}



/*4.	Desarrolle algoritmo que permita leer 30 números distintos e imprima el mayor de ellos.*/

Algoritmo MayorTreintaNumeros
{
  inicializar en entero a numero = 0, cont = 1, mayor = 0;
  mientras (cont <= 30)
    {
      imprimir ("Ingrese un número: ");
        leer (numero);
        si ((cont == 1) o (numero > mayor)) entonces
          mayor = numero;
      cont = cont + 1;
    }
    imprimir ("El mayor de los números es: ", mayor);
}

// ciclo para
Algoritmo MayorTreintaNumeros
{
  inicializar en entero a numero = 0, cont = 0, mayor = 0;
  para (cont = 1; cont <= 30; cont = cont + 1)
    {
      imprimir ("Ingrese un número: ");
        leer (numero);
        si ((cont == 1) o (numero > mayor)) entonces
          mayor = numero;
    }
    imprimir ("El mayor de los números es: ", mayor);
}


/*5.	Desarrolle un algoritmo que permita leer 30 números distintos e imprima el menor de ellos.*/

Algoritmo MenorTreintaNumeros
{
  inicializar en flotante a numero = 0, menor = 0;
  inicializar en entero a cont = 2;
  imprimir ("Ingrese el menor de sus números: ");
    leer (menor);
  mientras (cont <= 30)
  {
    imprimir ("Ingrese el número: ");
      leer (numero);
      {
          si (numero < menor) entonces
            menor = número;
      }
      cont = cont + 1;
  }
  imprimir ("El menor de los números: ", menor);
}

//Ciclo Para
Algoritmo MenorTreintaNumeros
{
  inicializar en entero a numero = 0, cont = 0, menor = 0;
  imprimir ("Ingrese el menor de sus números: ");
    leer (menor);
  para (cont = 2; cont <= 30; cont = cont + 1)
  {
    imprimir ("Ingrese el número: ");
      leer (numero);
      {
          si (numero==0) entonces
            menor = numero;
          sino
            si (numero < menor) entonces
            menor = numero;
      }
  }
  imprimir ("El menor de los números: ", menor);
}



/*6.	Desarrolle un algoritmo que permita lea 10 veces tres números enteros cualquiera cada vez 
y almacenarlos en las variables A, B y C respectivamente. El algoritmo debe imprimir cual es el mayor y cual es el menor.
Recuerde constatar que los tres números introducidos por el teclado sean valores distintos. Presente un mensaje de alerta en caso
de que se detecte la introducción de números iguales.*/

Algoritmo Numeros10Veces
{
  inicializar en entero a A = 0, B = 0, C = 0, cont = 1, menor = 0, mayor = 0;
   
    mientras (cont <= 10)
    {
      imprimir ("Ingrese el valor de A: ");
        leer (A);
      imprimir ("Ingrese el valor de B: ");
        leer (B);
      imprimir ("Ingrese el valor de C: ");
        leer (C);
      si ((A == B) o (B == C) o (C == A)) entonces
          imprimir ("Usted introdujo dos números iguales"); 
      {
          si ((A < B) y (A < C)) entonces
            menor = A; 
          si ((B < A) y (B < C)) entonces
            menor = B;
          sino 
            menor = C;
      }
      {
        Si ((A > B) y (A > C)) entonces
          mayor = A;
        si ((B > C) y (B > A)) entonces
          mayor = B;
        sino 
          mayor = C;
      }
      imprimir ("El número mayor es: ", mayor);
      imprimir ("El número menor es: ", menor);
      cont = cont + 1;
    }
}

//Ciclo para
Algoritmo Numeros10Veces
{
  inicializar en entero a A = 0, B = 0, C = 0, cont = 0, menor = 0, mayor = 0;
   
    para (cont = 1; cont <= 10; cont = cont + 1);
    {
      imprimir ("Ingrese el primer número: ");
        leer (A);
      imprimir ("Ingrese el segundo número: ");
        leer (B);
      imprimir ("Ingrese el tercer número: ");
        leer (C);
      si ((A == B) o (B == C) o (c == A)) entonces
          imprimir ("Usted introdujo dos números iguales");
      {
            si ((A < B) y (A < C)) entonces
              menor = A; 
            si ((B < A) y (B < C)) entonces
              menor = B;
            sino 
              menor = C;
      }
      {
          Si ((A > B) y (A > C)) entonces
            mayor = A;
          si ((B > C) y (B > A)) entonces
            mayor = B;
          sino 
            mayor = C;
      }
      imprimir ("El número mayor es: ", mayor);
      imprimir ("El número menor es: ", menor);
    }
}


/*7.	Desarrolle un algoritmo que lea 20 veces cuatro números enteros cualquiera cada vez y a continuación imprima el mayor de los cuatro números introducidos y 
también el menor de ellos.*/

Algoritmo CuatroNumeros20Veces
{
  inicializar en entero a num1 = 0, num2 = 0, num3 = 0, num4 = 0, menor = 0, mayor = 0, cont = 1;

  mientras (cont <= 20)
  {
    imprimir ("Ingrese el primer número: ");
      leer (num1);
    imprimir ("Ingrese el segundo número: ");
      leer (num2);
    imprimir ("Ingrese el tercer número: ");
      leer (num3);
    imprimir ("Ingrese el cuarto número: ");
      leer (num4);

      menor = num3;   mayor = num3;
        si (menor > num1) entonces
          menor = num1;
        si (menor > num2) entonces
          menor = num2;
        si (menor > num4) entonces
          menor = num4;
        si (mayor < num1) entonces
          mayor = num1;
        si (mayor < num2) entonces
          mayor = num2;
        si (mayor < num4) entonces
          mayor = num4;
      imprimir ("El número menor es: ", menor);
      imprimir ("El número mayor es: ", mayor);
      cont = cont + 1;
  }
}

//Ciclo para
Algoritmo CuatroNumeros20Veces
{
  inicializar en entero a num1 = 0, num2 = 0, num3 = 0, num4 = 0, menor = 0, mayor = 0, cont = 0;

  para (cont = 1; cont <= 20; cont = cont +1)
  {
    imprimir ("Ingrese el primer número: ");
      leer (num1);
    imprimir ("Ingrese el segundo número: ");
      leer (num2);
    imprimir ("Ingrese el tercer número: ");
      leer (num3);
    imprimir ("Ingrese el cuarto número: ");
      leer (num4);

    menor = num3;   mayor = num3;
        si (menor > num1) entonces
          menor = num1;
        si (menor > num2) entonces
          menor = num2;
        si (menor > num4) entonces
          menor = num4;
        si (mayor < num1) entonces
          mayor = num1;
        si (mayor < num2) entonces
          mayor = num2;
        si (mayor < num4) entonces
          mayor = num4;
      
      imprimir ("El número menor es: ", menor);
      imprimir ("El número mayor es: ", mayor);
  }
}


/* 8.	Escribir un algoritmo que realice las siguientes operaciones:
a.	Lea n número entero cualquiera.
b.	Si el número se encuentra en el rango de 20 a 45, imprima el cubo del número.
c.	Si el número es negativo, imprima su positivo.
d.	Si el número es múltiplo de 5, imprima el mensaje “El Número es Múltiplo de 5. */

Algoritmo NumeroCualquiera
{ 
  inicializar en entero a numero = 0, cont = 1, cantidad;
  imprimir ("Ingrese la cantidad de números a leer: ");
    leer (cantidad);
  
  mientras (cont <= cantidad)
  {
    imprimir ("Ingrese el número: ");
      leer (numero);
    si ((numero > 20) y (numero < 40)) entonces
      imprimir ("El cubo del número es: ", numero ^ 3);
    sino
      si (numero < 0) entonces
        imprimir ("El positivo del número es: ", -num);
      sino
        si (numero%5 == 0)
          imprimir ("El número es múltiplo de 5");
    cont = cont + 1;
  }
}

//Ciclo para
Algoritmo NumeroCualquiera
{ 
  inicializar en entero a numero = 0, cont = 0, cantidad;
  imprimir ("Ingrese la cantidad de números a leer: ");
    leer (cantidad);
  
  para (cont = 1; cont <= cantidad; cont = cont + 1)
  {
    imprimir ("Ingrese el número: ");
      leer (numero);
    si ((numero > 20) y (numero < 40)) entonces
      imprimir ("El cubo del número es: ", numero ^ 3);
    sino
      si (numero < 0) entonces
        imprimir ("El positivo del número es: ", -num);
      sino
        si (numero%5 == 0)
          imprimir ("El número es múltiplo de 5");
  }
}

/* 9.	Escriba un algoritmo que lea 15 veces cuatro números enteros cualquiera cada vez enteros cualquiera e imprima lo siguiente:

a.	El cuadrado del tercer número, si la suma de primero número más el cuarto número se encuentra en el rango de 10 a 25, inclusive.
b.	El segundo número, si el producto de los otros tres número es múltiplo de 3.
c.	La suma de los cubo de los cuatro números, se esta es menor a 100, de lo contrario imprimir el siguiente mensaje “La suma de los cubos es mayor a 100”.
 */

Algoritmo CuatroNumeros15Veces
 {
  inicializar en entero a num1 = 0, num2 = 0, num3 = 0, num4 = 0, cont = 1, suma, sumaCubo;

  mientras (cont <= 15)
  {
    imprimir ("Ingrese el primer número: ");
      leer (num1);
    imprimir ("Ingrese el segundo número: ");
      leer (num2);
    imprimir ("Ingrese el tercer número: ");
      leer (num3);
    imprimir ("Ingrese el cuarto número: ");
      leer (num4);
      suma = num1 + num4;
    si (suma >= 10) y (suma <=25) entonces
      imprimir ("El cubo del tercer número es: ", num3 ^ 3);
    si ((num1 * num3 * num4)%3 == 0) entonces
      imprimir ("El segundo número es: ", num2);
    sumaCubo = num1^3 + num2^3 + num3^3 + num4^3;
    si (suma<100) 
      imprimir ("La suma de los cubos de los cuatro números es: ", sumaCubo);
    sino
      imprimir ("La suma de los cubos el mayor a 100");
      cont = cont + 1;
  }
 }

 //Ciclo Para
 Algoritmo CuatroNumeros15Veces
 {
  inicializar en entero a num1 = 0, num2 = 0, num3 = 0, num4 = 0, cont = 0, suma, sumaCubo;

  para (cont = 1; cont <= 15; cont = cont + 1)
  {
    imprimir ("Ingrese el primer número: ");
      leer (num1);
    imprimir ("Ingrese el segundo número: ");
      leer (num2);
    imprimir ("Ingrese el tercer número: ");
      leer (num3);
    imprimir ("Ingrese el cuarto número: ");
      leer (num4);
      suma = num1 + num4;
    si (suma >= 10) y (suma <=25) entonces
      imprimir ("El cubo del tercer número es: ", num3 ^ 3);
    si ((num1 * num3 * num4)%3 == 0) entonces
      imprimir ("El segundo número es: ", num2);
    sumaCubo = num1^3 + num2^3 + num3^3 + num4^3;
    si (suma<100) 
      imprimir ("La suma de los cubos de los cuatro números es: ", sumaCubo);
    sino
      imprimir ("La suma de los cubos es mayor a 100");
  }
 }


 /* 10.	Escriba un algoritmo que lea 30 números enteros cualquiera en imprima las siguientes estadísticas:
a.	Total de números leídos que son positivos.
b.	Suma de los números leídos que son negativos..
c.	Promedio de los números leídos que están dentro del rango de 17 a 24, inclusive.
*/

Algoritmo NumerosEnteros30
{
  inicializar en entero a num = 0, tot_pos = 0, suma_neg = 0, tot_rango = 0, suma_rango = 0, cont = 1;
  mientras (cont <= 30)
  {
    imprimir ("Ingrese el número: ");
      leer (num);
    si (num < 0) entonces
      suma_neg = suma_neg + num;
    sino  
      si (num > 0) entonces
        tot_pos = tot_pos + 1;
      sino 
        si ((num >= 17) y (num <= 24)) entonces
          tot_rango = tot_rango + 1;
          suma_rango = suma_rango + num;
    imprimir ("La suma de los números negativos leídos es: ", suma_neg);
    imprimir ("El total de números positivos leídos es de: ", tot_pos);
    si (tot_rango < 0) entonces 
      imprimir ("No se puede dividir entre cero");
    sino 
      imprimir ("El promedio de números leídos entre 17 y 24 es: ", suma_rango/tot_rango);
    cont = cont +1;
  }
}

//Ciclo Para
Algoritmo NumerosEnteros30
{
  inicializar en entero a num = 0, tot_pos = 0, suma_neg = 0, tot_rango = 0, suma_rango = 0, cont;
  para (cont = 1; cont <= 30, cont = cont + 1)
  {
    imprimir ("Ingrese el número: ");
      leer (num);
    si (num < 0) entonces
      suma_neg = suma_neg + num;
    sino  
      si (num > 0) entonces
        tot_pos = tot_pos + 1;
      sino 
        si ((num >= 17) y (num <= 24)) entonces
          tot_rango = tot_rango + 1;
          suma_rango = suma_rango + num;
    imprimir ("La suma de los números negativos leídos es: ", suma_neg);
    imprimir ("El total de números positivos leídos es de: ", tot_pos);
    si (tot_rango < 0) entonces 
      imprimir ("No se puede dividir entre cero");
    sino 
      imprimir ("El promedio de números leídos entre 17 y 24 es: ", suma_rango/tot_rango);
  }
}
