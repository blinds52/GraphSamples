﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphSamples
{ 
    public class Common
    {
        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------        
        public static void Swap(ref int x, ref int y)
        {
            int z = x;
            x = y;
            y = z;
        }

        public static void Swap(int[] array, int leftIndx, int rightIndx)
        {
            int tempVal = array[leftIndx];
            array[leftIndx] = array[rightIndx];
            array[rightIndx] = tempVal;
        }

        public static void Swap(ref char x, ref char y)
        {
            char z = x;
            x = y;
            y = z;
        }

        public static int GetMedianPosition(int[] array, int stIndx, int endIndx)
        {
            int midIndx = stIndx + ((endIndx - stIndx) / 2);

            if (array[stIndx] >= array[midIndx] && array[midIndx] >= array[endIndx])
                return midIndx;
            if (array[midIndx] >= array[stIndx] && array[stIndx] >= array[endIndx])
                return stIndx;
            else
                return endIndx;
        }

        private int SwapAndGetMedianPosition(int[] nums, int leftIndx, int rightIndx)
        {
            int midIndx = leftIndx + (rightIndx - leftIndx) / 2;

            if (nums[rightIndx] > nums[leftIndx])
                Swap(nums, leftIndx, rightIndx);

            if (nums[rightIndx] > nums[midIndx])
                Swap(nums, rightIndx, midIndx);

            if (nums[midIndx] > nums[leftIndx])
                Swap(nums, leftIndx, midIndx);

            return midIndx;
        }

        static StringBuilder StrMessage = new StringBuilder();

        public static string DisplayArray(int[] array, string message)
        {
            StrMessage.Clear();
            StrMessage.AppendLine(message);

            for (int lpCnt = 0; lpCnt < array.Length; lpCnt++)
            {
                StrMessage.Append(array[lpCnt] + " ");
            }
            return StrMessage.ToString();
        }

        public static string DisplayMatrix(int[,] matrix, string message)
        {
            StrMessage.Clear();
            StrMessage.AppendLine(message);

            for (int lpRCnt = 0; lpRCnt < matrix.GetLowerBound(0); lpRCnt++)
            {
                for (int lpCCnt = 0; lpCCnt < matrix.GetLowerBound(1); lpCCnt++)
                {

                    StrMessage.Append(matrix[lpRCnt, lpCCnt] + " ");
                }
            }
            return StrMessage.ToString();
        }

        public static void ShowMatrixOnConsole<T>(T[,] matrix, string preMessage = "", string postMessage = "")
        {
            Console.WriteLine(Environment.NewLine + preMessage + Environment.NewLine);

            for (int lpRCnt = 0; lpRCnt < matrix.GetLength(0); lpRCnt++)
            {
                for (int lpCCnt = 0; lpCCnt < matrix.GetLength(1); lpCCnt++)
                {
                    Console.Write(string.Format(" {0}  ", matrix[lpRCnt, lpCCnt]));
                }

                Console.WriteLine();
            }

            Console.WriteLine(postMessage);
        }

        //----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

        public static void ShowArrayOnConsole(int[] array, int stIndx = 0, int endIndx = 0)
        {
            Console.Write("[");

            if (endIndx == 0)
                endIndx = array.Length;

            for (int lpCnt = stIndx; lpCnt < endIndx; lpCnt++)
            {
                Console.Write(array[lpCnt] + ", ");
            }

            Console.Write(array[endIndx] + "]");
        }

        public static bool IsSafe(int rIndx, int cIndx, int[,] visitMatrix, int val = 0)
        {
            return (rIndx >= 0 && rIndx < visitMatrix.GetLength(0) &&
                    cIndx >= 0 && cIndx < visitMatrix.GetLength(1) && visitMatrix[rIndx, cIndx] == val);
        }
    }
}
