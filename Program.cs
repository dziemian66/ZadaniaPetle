namespace ZadaniaPetle
{
    class Programm
    {
        static void Main(string[] args)
        {
            
            //1
            Console.WriteLine("1. Liczby pierwsze");
            for(int i = 0; i < 100; i++)
            {
                for(int l = 2; l <= i; l++)
                {
                    if (i == l)
                    {
                        Console.WriteLine($"Znalazłem liczbę pierwszą: {i}");
                    }
                    if (i % l == 0)
                    {
                        break;
                    }
                }
            }

            //2
            int a = 0;

            Console.WriteLine("2. Liczby parzyste");
            do
            {
                if (a % 2 == 0)
                {
                    Console.WriteLine($"Liczba parzysta: {a}");
                }
                a++;
            } while (a <= 1000);
            
            //3
            Console.WriteLine("3. Ciąg Fibonacciego");
            int value1 = 0;
            int value2 = 1;
            int value3 = 0;

            Console.WriteLine(" " + value1);
            Console.WriteLine(" " + value2);
            for (int i = 0; i < 20; i++)
            {
                value3 = value2;
                value2 = value1 + value2;
                value1 = value3;
                Console.WriteLine(" " + value2);
            }

            //4
            uint value4;
            uint value5 = 1;
            int b = 1;

            Console.WriteLine("4. Piramida liczb");
            UInt32.TryParse(Console.ReadLine(), out value4);
            while (b < value4)
            {
                for(int k = 0; k < b; k++)
                {
                    if (value5 <= value4)
                    {
                        Console.Write(" " + value5);
                        value5++;
                    }
                    else
                    {
                        b = (int)value4;
                        break;
                    }
                }
                Console.WriteLine();
                b++;
            }
            

            //5
            Console.WriteLine("5. Trzecia potęga");
            for(int i = 1; i <= 20; i++)
            {
                Console.WriteLine(i * i * i);
            }

            //6
            double sum = 0;

            Console.WriteLine("6. Suma według wzoru");
            for(int i = 1; i <= 20; i++)
            {
                sum = sum + 1/(double)i;
            }
            Console.WriteLine(sum);
            
            

            //7
            uint diagonal;
            uint value6;
            uint value7 = 1;
            bool top = true;

            Console.WriteLine("7. Narysuj diament");

            UInt32.TryParse(Console.ReadLine(), out diagonal);
            value6 = diagonal / 2;
            for (int i = 0; i < diagonal; i++)
            {
                if (i == diagonal / 2)
                {
                    top = false;
                } 
                  for (int m = 0; m < value6; m++)
                  {
                        Console.Write(" ");
                  }
                  for (int k = 0; k < value7; k++)
                  {
                        Console.Write("*");
                  }
                  if(top)
                  {
                      if (i != diagonal / 2)
                      {
                          value7 += 2;
                      }
                      if (value6 > 0)
                      {
                          value6--;
                      }
                   }
                   else
                   {
                      value6++;
                      if (value7 > 1)
                      {
                          value7 -= 2;
                      }
                   }              
                Console.WriteLine();
            }
           
            //8 
            string text;
            string newText = "";

            Console.WriteLine("8. Odwróć kolejność");
            text = Console.ReadLine();

            for (int i = 0; i < text.Length; i++)
            {
                    Console.Write(text[(text.Length - 1) - i]);
            }
            Console.WriteLine(newText);
             
            //9
            int decimalNumber;
            string binaryNumber = "";
            int value8;

            Console.WriteLine("9. Zmień na liczbę binarną");            
            Int32.TryParse(Console.ReadLine(), out decimalNumber);
            while(decimalNumber > 0)
            {
                value8 = decimalNumber % 2;
                decimalNumber /= 2;
                binaryNumber = Convert.ToString(value8) + binaryNumber;

            }
            Console.WriteLine(binaryNumber);
            
            //10
            int value9;

            int value10;
            int greaterValue;
            int lessValue;
            int sumLessValue = 0;
            int sumGreaterValue = 0;
            int multipleOfLessNumber = 0;
            int multipleOfGreaterNumber = 0;
            int j = 0;

            Console.WriteLine("10. Najmniejsza wspólna wielokrotność");
            Int32.TryParse(Console.ReadLine(), out value9);
            Int32.TryParse(Console.ReadLine(), out value10);

            if (value9 > value10)
            {
                greaterValue = value9;
                lessValue = value10;
            }
            else
            {
                greaterValue = value10;
                lessValue = value9;
            }
         
            while (sumLessValue < (greaterValue * lessValue))
            {
                while (sumLessValue <= sumGreaterValue )
                {
                    sumLessValue = sumLessValue + lessValue;

                    multipleOfLessNumber++;
                    if(sumLessValue== sumGreaterValue)
                    {
                        break;
                    }
                }
                if (sumLessValue == sumGreaterValue)
                {
                    break;
                }
                sumGreaterValue = sumGreaterValue + greaterValue;
                multipleOfGreaterNumber++;
            }

            Console.WriteLine($"Wielokrotność {multipleOfLessNumber} liczby {lessValue}");
            Console.WriteLine($"Wielokrotność {multipleOfGreaterNumber} liczby {greaterValue}");
        }
    }
}
