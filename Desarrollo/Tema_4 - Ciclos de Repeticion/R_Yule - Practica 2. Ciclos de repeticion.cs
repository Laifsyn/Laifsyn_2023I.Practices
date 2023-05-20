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
    inicializar en entero a nota1 = 0, nota2 = 0, nota3 = 0, cont = 0;
    inicializar en flotante a promedio = 0;
    inicializar en cadena a nombre, NotaFinal;

    mientras (cont <= 20)
    {
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

    para (cont = 0; cont <= 20; cont = cont + 1)
    {
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
                  notaFinal = 'F'
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
    inicializar en entero horTrabajadas = 0, cont = 0;
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
        //{   Esta llave no va
          // si (salBruto<500) entonces 
          //   descuento = 0; // descuento ya vale 0
          // sino 
          si ((salBruto>=500) y (salBruto<=1000)) entonces
            descuento = 0.02;
          sino
              si (salBruto>1000) entonces
                descuento = 0.05;   
        //}
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

    para (cont = 0; cont <= 10, cont = cont + 1)
      {
         imprimir ("Ingrese su nombre: ");
           leer (nombre);
         imprimir ("Ingrese su salario: ");
           leer (salHora);
         imprimir ("Ingrese sus horas trabajadas: ");
           leer (horTrabajadas);

        salBruto = salHora * horTrabajadas;
        //{   Esta llave no va
          // si (salBruto<500) entonces 
          //   descuento = 0; // descuento ya vale 0
          // sino 
          si ((salBruto>=500) y (salBruto<=1000)) entonces
            descuento = 0.02;
          sino
              si (salBruto>1000) entonces
                descuento = 0.05;   
        //}
        descuentoSal = salBruto * descuento; 
        salNeto = salBruto - descuentoSal;
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
        imprimir ("Ingrese el primer numero: ");
          leer (num1);
        imprimir ("Ingrese el segundo numero: ");
          leer (num2);
        imprimir ("Ingrese el tercer numero: ");
          leer (num3);
        suma=num1+num2+num3;
        si (num1 + num2 <= 20) entonces
          imprimir ("El tercer numero es: ", num3);
        
        si (num2 != num3) entonces
          imprimir ("El primer numero es: ", num1);
        
        si (suma>50) entonces
          imprimir ("La suma de los tres numeros es: ", suma);

      cont = cont + 1;
      }
}

//Ciclo para
Algoritmo TresNumeros
{
   inicializar en entero a num1 = 0, num2 = 0, num3 = 0, cont = 0, suma;

      para(cont = 0; cont < 15; cont = cont + 1)
      {
        imprimir ("Ingrese el primer numero: ");
          leer (num1);
        imprimir ("Ingrese el segundo numero: ");
          leer (num2);
        imprimir ("Ingrese el tercer numero: ");
          leer (num3);
        suma=num1+num2+num3;
        si (num1 + num2 <= 20) entonces
          imprimir ("El tercer numero es: ", num3);
        
        si (num2 != num3) entonces
          imprimir ("El primer numero es: ", num1);
        
        si (suma>50) entonces
          imprimir ("La suma de los tres numeros es: ", suma);
      }
}


/*4.	Desarrolle algoritmo que permita leer 30 números distintos e imprima el mayor de ellos.*/

Algoritmo TreintaNumeros
{
  inicializar en entero a numero = 0, cont = 0, mayor = 0;
  mientras (cont <= 30)
    {
      imprimir ("Ingrese un numero: ");
        leer (numero);
      {
        si (numero > mayor) entonces
          mayor = numero;
      }
      cont = cont + 1;
    }
    imprimir ("El mayor de los numeros es: ", mayor);
}

// ciclo para
Algoritmo MayorTreintaNumeros
{
  inicializar en entero a numero = 0, cont = 0, mayor = 0;
  para (cont = 0; cont <= 30; cont = cont + 1)
    {
      imprimir ("Ingrese un numero: ");
        leer (numero);
      {
        si (numero > mayor) entonces
          mayor = numero;
      }
    }
    imprimir ("El mayor de los numeros es: ", mayor);
}

/*5.	Desarrolle un algoritmo que permita leer 30 números distintos e imprima el menor de ellos.*/

Algoritmo MenorTreintaNumeros
{
  inicializar en entero a numero = 0, cont = 0, menor = 0;
  mientras (cont <= 30)
  {
    imprimir ("Ingrese el numero: ");
      leer (numero);
      {
          si (numero < menor) entonces
            menor = numero;
      }
      cont = cont + 1;
  }
  imprimir ("El menor de los numeros: ", menor)
}

//Ciclo Para
Algoritmo MenorTreintaNumeros
{
  inicializar en entero a numero = 0, cont = 0, menor = 0;
  para (cont = 0; cont <= 30; cont = cont + 1)
  {
    imprimir ("Ingrese el numero: ");
      leer (numero);
      {
          si (numero==0) entonces
            menor = numero;
          sino
            si (numero < menor) entonces
            menor = numero;
      }
      cont = cont + 1;
  }
  imprimir ("El menor de los numeros: ", menor)
}


/*6.	Desarrolle un algoritmo que permita lea 10 veces tres números enteros cualquiera cada vez 
y almacenarlos en las variables A, B y C respectivamente. El algoritmo debe imprimir cual es el mayor y cual es el menor.
Recuerde constatar que los tres números introducidos por el teclado sean valores distintos. Presente un mensaje de alerta en caso
de que se detecte la introducción de números iguales.*/

Algoritmo Numeros10Veces
{
  inicializar en entero a A = 0, B = 0, C = 0, cont = 0, menor = 0, mayor = 0;
   
    mientras (cont < 10)
    {
      imprimir ("Ingrese el primer numero: ");
        leer (A);
      imprimir ("Ingrese el segundo numero: ");
        leer (B);
      imprimir ("Ingrese el tercer numero: ");
        leer (C);
      {
        si ((A == B) o (B == C)) entonces
          imprimir ("Usted intodujo dos numeros iguales: ");
          sino 
            si ((A < B) y (A < C)) entonces
              menor = A; 
            sino 
              si ((B < A) y (B < C)) entonces
                menor = B;
              sino 
                menor = C;
      }
      {
          Si ((A > B) y (A > C)) entonces
            mayor = A;
          sino
            si ((B > C) y (B > A)) entonces
              mayor = B;
            sino 
              mayor = C;
      }
    }
    cont = cont + 1;
}

//Ciclo para
Algoritmo Numeros10Veces
{
  inicializar en entero a A = 0, B = 0, C = 0, cont = 0, menor = 0, mayor = 0;
   
    para (cont = 0; cont <= 10; cont = cont + 1);
    {
      imprimir ("Ingrese el primer numero: ");
        leer (A);
      imprimir ("Ingrese el segundo numero: ");
        leer (B);
      imprimir ("Ingrese el tercer numero: ");
        leer (C);
      {
        si ((A == B) o (B == C)) entonces
          imprimir ("Usted intodujo dos numeros iguales: ");
          sino 
            si ((A < B) y (A < C)) entonces
              menor = A; 
            sino 
              si ((B < A) y (B < C)) entonces
                menor = B;
              sino 
                menor = C;
      }
      {
          Si ((A > B) y (A > C)) entonces
            mayor = A;
          sino
            si ((B > C) y (B > A)) entonces
              mayor = B;
            sino 
              mayor = C;
      }
    }
}

/*7.	Desarrolle un algoritmo que lea 20 veces cuatro números enteros cualquiera cada vez y a continuación imprima el mayor de los cuatro números introducidos y 
también el menor de ellos.*/

Algoritmo CuatroNumero20Veces
{
  inicializar en entero a num1 = 0, num2 = 0, num3 = 0, num4 = 0, menor = 0, mayor = 0, cont = 0;

  mientras (cont < 20)
  {
    imprimir ("Ingrese el primer numero: ");
      leer (num1);
    imprimir ("Ingrese el segundo numero: ");
      leer (num2);
    imprimir ("Ingrese el tercer numero: ");
      leer (num3);
    imprimir ("Ingrese el cuarto numero: ");
      leer (num4);
      
  }
}
