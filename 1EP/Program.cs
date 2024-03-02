using System;

int opp, op1;
do
{
    Console.WriteLine("Seleccione una opción: \n1.Factorial y Raíz. \n2.Operaciones matematicas. \n3.Tabla de multiplicar. \n4.Adivina el número. \n5.Salir");
    opp = int.Parse(Console.ReadLine());

    switch (opp)
    {
        case 1:
            do
            {
                Console.WriteLine("Seleccione una opción: \n1.Calcular el factorial del número. \n2.Calcular la raíz cuadrada del número. \n3.Salir del programa. ");
                op1 = int.Parse(Console.ReadLine());

                switch (op1)
                {
                    case 1:

                        int num, n, fac = 1;
                        Console.Write("Ingrese un número: ");
                        num = int.Parse(Console.ReadLine());
                        n = num;

                        for (int i = 1; i <= n; i++)
                        {
                            fac = fac * n;
                            n = n - 1;
                        }

                        Console.WriteLine($"El factorial de {num} es {fac}");
                        break;

                    case 2:
                        Console.Write("Ingrese número: ");
                        double numero = double.Parse(Console.ReadLine());

                        double raiz_cuadrada = Math.Sqrt(numero);

                        Console.WriteLine($"La raíz cuadrada de {numero} es {raiz_cuadrada}");
                        break;
                    default:
                        Console.WriteLine("Ingresaste un opción invalida :(");
                        break;
                }
            } while (op1 != 3);
            break;
        case 2:
            Console.WriteLine("Ingrese el primer número a operar: ");
            double n1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo número a operar: ");
            double n2 = double.Parse(Console.ReadLine());
            double result;
            Console.WriteLine("Que operación desea hacer?: \n1.(+) \n2.(-) \n3.(*) \n4.(/)  ");
            int oper = int.Parse(Console.ReadLine());

            switch (oper)
            {
                case 1:
                    result = n1 + n2;
                    Console.WriteLine("El resultado de la suma es de: " + result);
                    break;
                case 2:
                    result = n1 - n2;
                    Console.WriteLine("El resultado de la resta es de: " + result);
                    break;
                case 3:
                    result = n1 * n2;
                    Console.WriteLine("El resultado de la multiplicación es de: " + result);
                    break;
                case 4:
                    result = n1 / n2;
                    Console.WriteLine("El resultado de la división es de: " + result);
                    break;
                default:
                    Console.WriteLine("Ingresaste un opción invalida :(");
                    break;
            }
            break;
        case 3:
            Console.WriteLine("Ingrese la tabla de multiplicar que desea imrpimir: ");
            int tab = int.Parse(Console.ReadLine());

            for (int x = 0; x <= 10; x++)
            {
                int r = tab * x;
                Console.WriteLine($"{tab} * {x} = {r}");
            }
            break;
        case 4:
            Console.WriteLine("¡Vamos a Jugar!");
            Console.WriteLine("¡Adivina el número secreto entre 1 y 100!");
            int inten = 0, numU;
            Random random = new Random();
            int numS = random.Next(1, 101); 
            do
            {
                inten++;
                Console.Write("Intenta adivinar el número : ");
                numU = int.Parse(Console.ReadLine());
                if (numU < numS)
                {
                    Console.WriteLine("El número que buscas es mayor. Vuelve a intentarlo.");
                }
                else if (numU > numS)
                {
                    Console.WriteLine("El número que buscas es menor. Vuelve a intentarlo.");
                }


            } while (numU != numS);
            Console.WriteLine("¡Felicidades has econtrado el número secreto!" + numS);
            Console.WriteLine("Intentos: " + inten);

            break;
        default:
            Console.WriteLine("Ingresaste un opción invalida :(");
            break;
    }
} while (opp != 5);
Console.WriteLine("Nos vemos. ");