using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace encryption
{
    public class FourSquareEncryption
    {
        public static void Main(string[] args)
        {
            string inText = "abcdefghijklmnopqrstuvwxyz0123456789", keyOne, keyTwo, plainText, cipherText;
            int keyOneLength, keyTwoLength, inTextLength, k1l1 = 0, k1l2 = 0, k1len = 0, i1len = 0, k2l1 = 0, k2l2 = 0, k2len = 0, i2len = 0, q1l1 = 0, q1l2 = 0, q3l1 = 0, q3l2 = 0, q1len = 0, q3len = 0;
            char currentChar;
            
            char[][] quadOne = RectangularArrays.RectangularCharArray(6, 6);
            
            char[][] quadTwo = RectangularArrays.RectangularCharArray(6, 6);
            
            char[][] quadThree = RectangularArrays.RectangularCharArray(6, 6);
            
            char[][] quadFour = RectangularArrays.RectangularCharArray(6, 6);
            
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    quadOne[i][j] = '0';
                    quadTwo[i][j] = '0';
                    quadThree[i][j] = '0';
                    quadFour[i][j] = '0';
                }
            }
            
            Console.Write("Enter the encryption key one: ");
            keyOne = sc.nextLine();
            Console.Write("Enter the encryption key two: ");
            keyTwo = sc.nextLine();
            keyOneLength = keyOne.Length;
            keyTwoLength = keyTwo.Length;
            inTextLength = inText.Length;
           
            while (k1l1 < 6 && k1len < keyOneLength)
            {
                k1l2 = 0;
                while (k1l2 < 6 && k1len < keyOneLength)
                {
                    currentChar = keyOne[k1len];
                    int flag = 0;
                    for (int i = 0; i < 6; i++)
                    {
                        for (int j = 0; j < 6; j++)
                        {
                            if (quadFour[i][j] == currentChar)
                            {
                                flag = 1;
                            }
                        }
                    }
                    if (flag == 0)
                    {
                        quadFour[k1l1][k1l2] = currentChar;
                        k1l2++;
                    }
                    k1len++;
                }
                k1l1++;
            }
            --k1l1;
           
            while (k1l1 < 6 && i1len < inTextLength)
            {
                while (k1l2 < 6 && i1len < inTextLength)
                {
                    currentChar = inText[i1len];
                    int flag = 0;
                    for (int i = 0; i < 6; i++)
                    {
                        for (int j = 0; j < 6; j++)
                        {
                            if (quadFour[i][j] == currentChar)
                            {
                                flag = 1;
                            }
                        }
                    }
                    if (flag == 0)
                    {
                        quadFour[k1l1][k1l2] = currentChar;
                        k1l2++;
                    }
                    i1len++;
                }
                k1l1++;
                k1l2 = 0;
            }
           
            while (k2l1 < 6 && k2len < keyTwoLength)
            {
                k2l2 = 0;
                while (k2l2 < 6 && k2len < keyTwoLength)
                {
                    currentChar = keyTwo[k2len];
                    int flag = 0;
                    for (int i = 0; i < 6; i++)
                    {
                        for (int j = 0; j < 6; j++)
                        {
                            if (quadTwo[i][j] == currentChar)
                            {
                                flag = 1;
                            }
                        }
                    }
                    if (flag == 0)
                    {
                        quadTwo[k2l1][k2l2] = currentChar;
                        k2l2++;
                    }
                    k2len++;
                }
                k2l1++;
            }
            --k2l1;
            
            while (k2l1 < 6 && i2len < inTextLength)
            {
                while (k2l2 < 6 && i2len < inTextLength)
                {
                    currentChar = inText[i2len];
                    int flag = 0;
                    for (int i = 0; i < 6; i++)
                    {
                        for (int j = 0; j < 6; j++)
                        {
                            if (quadTwo[i][j] == currentChar)
                            {
                                flag = 1;
                            }
                        }
                    }
                    if (flag == 0)
                    {
                        quadTwo[k2l1][k2l2] = currentChar;
                        k2l2++;
                    }
                    i2len++;
                }
                k2l1++;
                k2l2 = 0;
            }

            while (q1l1 < 6 && q1len < inTextLength)
            {
                q1l2 = 0;
                while (q1l2 < 6 && q1len < inTextLength)
                {
                    currentChar = inText[q1len];
                    int flag = 0;
                    for (int i = 0; i < 6; i++)
                    {
                        for (int j = 0; j < 6; j++)
                        {
                            if (quadOne[i][j] == currentChar)
                            {
                                flag = 1;
                            }
                        }
                    }
                    if (flag == 0)
                    {
                        quadOne[q1l1][q1l2] = currentChar;
                        q1l2++;
                    }
                    q1len++;
                }
                q1l1++;
            }
            
            while (q3l1 < 6 && q3len < inTextLength)
            {
                q3l2 = 0;
            }
        }
    }
}
