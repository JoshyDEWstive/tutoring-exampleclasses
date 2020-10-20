using System;

public class Class1
{
    public void TestProgram() {

        int length = 10;

        for (int i = 0; i < length; i++) {
            Console.WriteLine(i);
        }


        int[] arrayInt = { 8, 5, 6, 2 };
        
        length = arrayInt.Length;

        for (int i = 0; i < length; i++) {
            int value = arrayInt[i];
            Console.WriteLine(value);
        }


	}
}
