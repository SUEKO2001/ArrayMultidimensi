﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Array_Multidimensi
{
    class Program
    {
        int baris, kolom, baris2, kolom2;

        public void penjumlahan()
        {
            ////////////////////////////////////////////////////
            Console.WriteLine("Matriks A : \n");

            Console.Write("Masukan Baris : ");
            baris = int.Parse(Console.ReadLine());
            Console.Write("Masukan Kolom : ");
            kolom = int.Parse(Console.ReadLine());

            Console.WriteLine();

            int[,] arrayA = new int[baris, kolom];

            for (int i = 0; i < baris; i++)
            {
                for (int j = 0; j < kolom; j++)
                {
                    Console.Write("Masukkan Nilai Matriks ke-[{0}][{1}] : ", i, j);
                    arrayA[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("\n");

            for (int i = 0; i < baris; i++)
            {
                for (int j = 0; j < kolom; j++)
                {
                    Console.Write("{0}\t", arrayA[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            /////////////////////////////////////////////////////
            Console.WriteLine("Matriks B : \n");

            Console.Write("Masukan Baris : ");
            baris2 = int.Parse(Console.ReadLine());
            Console.Write("Masukan Kolom : ");
            kolom2 = int.Parse(Console.ReadLine());

            Console.WriteLine();

            int[,] arrayB = new int[baris2, kolom2];

            for (int i = 0; i < baris2; i++)
            {
                for (int j = 0; j < kolom2; j++)
                {
                    Console.Write("Masukkan Nilai Matriks ke-[{0}][{1}] : ", i, j);
                    arrayB[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("\n");

            for (int i = 0; i < baris2; i++)
            {
                for (int j = 0; j < kolom2; j++)
                {
                    Console.Write("{0}\t", arrayB[i, j]);
                }
                Console.WriteLine();
            }
            //////////////////////////////////////////////////////
            Console.WriteLine();
            if ((baris != baris2 && kolom != kolom2) || (baris != baris2 && kolom == kolom2) || (baris == baris2 && kolom != kolom2))
            {
                Console.Write("Besar Matriks Tidak Sama\n\n");
            }
            else
            {
                Console.WriteLine("\n");
                Console.WriteLine("Hasil Penjumlahan\n");
                for (int i = 0; i < baris; i++)
                {
                    for (int j = 0; j < kolom; j++)
                    {
                        int[,] arrayC = new int[baris, kolom];
                        arrayC[i, j] = arrayA[i, j] + arrayB[i, j];
                        Console.Write("{0}\t", arrayC[i, j]);
                    }
                    Console.WriteLine();
                }
            }
        }

        public void pengurangan()
        {
            ////////////////////////////////////////////////////
            Console.WriteLine("Matriks A : \n");

            Console.Write("Masukan Baris : ");
            baris = int.Parse(Console.ReadLine());
            Console.Write("Masukan Kolom : ");
            kolom = int.Parse(Console.ReadLine());

            Console.WriteLine();

            int[,] arrayA = new int[baris, kolom];

            for (int i = 0; i < baris; i++)
            {
                for (int j = 0; j < kolom; j++)
                {
                    Console.Write("Masukkan Nilai Matriks ke-[{0}][{1}] : ", i, j);
                    arrayA[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("\n");

            for (int i = 0; i < baris; i++)
            {
                for (int j = 0; j < kolom; j++)
                {
                    Console.Write("{0}\t", arrayA[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            /////////////////////////////////////////////////////
            Console.WriteLine("Matriks B : \n");

            Console.Write("Masukan Baris : ");
            baris2 = int.Parse(Console.ReadLine());
            Console.Write("Masukan Kolom : ");
            kolom2 = int.Parse(Console.ReadLine());

            Console.WriteLine();

            int[,] arrayB = new int[baris2, kolom2];

            for (int i = 0; i < baris2; i++)
            {
                for (int j = 0; j < kolom2; j++)
                {
                    Console.Write("Masukkan Nilai Matriks ke-[{0}][{1}] : ", i, j);
                    arrayB[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("\n");

            for (int i = 0; i < baris2; i++)
            {
                for (int j = 0; j < kolom2; j++)
                {
                    Console.Write("{0}\t", arrayB[i, j]);
                }
                Console.WriteLine();
            }
            //////////////////////////////////////////////////////
            Console.WriteLine();
            if ((baris != baris2 && kolom != kolom2) || (baris != baris2 && kolom == kolom2) || (baris == baris2 && kolom != kolom2))
            {
                Console.Write("Besar Matriks Tidak Sama\n");
            }
            else
            {
                Console.WriteLine("\n");
                Console.WriteLine("Hasil Pengurangann\n\n");
                for (int i = 0; i < baris; i++)
                {
                    for (int j = 0; j < kolom; j++)
                    {
                        int[,] arrayC = new int[baris, kolom];
                        arrayC[i, j] = arrayA[i, j] - arrayB[i, j];
                        Console.Write("{0}\t", arrayC[i, j]);
                    }
                    Console.WriteLine();
                }
            }
        }

        public void perkalian()
        {
            ////////////////////////////////////////////////////
            Console.WriteLine("Matriks A : \n");

            Console.Write("Masukan Baris : ");
            baris = int.Parse(Console.ReadLine());
            Console.Write("Masukan Kolom : ");
            kolom = int.Parse(Console.ReadLine());

            Console.WriteLine();

            int[,] arrayA = new int[baris, kolom];

            for (int i = 0; i < baris; i++)
            {
                for (int j = 0; j < kolom; j++)
                {
                    Console.Write("Masukkan Nilai Matriks ke-[{0}][{1}] : ", i, j);
                    arrayA[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("\n");

            for (int i = 0; i < baris; i++)
            {
                for (int j = 0; j < kolom; j++)
                {
                    Console.Write("{0}\t", arrayA[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            /////////////////////////////////////////////////////
            Console.WriteLine("Matriks B : \n");

            Console.Write("Masukan Baris : ");
            baris2 = int.Parse(Console.ReadLine());
            Console.Write("Masukan Kolom : ");
            kolom2 = int.Parse(Console.ReadLine());

            Console.WriteLine();

            int[,] arrayB = new int[baris2, kolom2];

            for (int i = 0; i < baris2; i++)
            {
                for (int j = 0; j < kolom2; j++)
                {
                    Console.Write("Masukkan Nilai Matriks ke-[{0}][{1}] : ", i, j);
                    arrayB[i, j] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("\n");

            for (int i = 0; i < baris2; i++)
            {
                for (int j = 0; j < kolom2; j++)
                {
                    Console.Write("{0}\t", arrayB[i, j]);
                }
                Console.WriteLine();
            }
            //////////////////////////////////////////////////////
            Console.WriteLine();
            if (kolom != baris2)
            {
                Console.WriteLine("Tidak Dapat Dikalikan");
            }
            else if (kolom2 > baris || kolom2 > kolom)
            {
                Console.WriteLine("Kolom 2 Terlalu Besar");
            }
            else
            {
                Console.WriteLine("\n");
                Console.WriteLine("Hasil Perkalian\n");
                int[,] arrayC = new int[baris, kolom2];
                for (int i = 0; i < baris; i++)
                {
                    for (int j = 0; j < kolom2; j++)
                    {
                        arrayC[i, j] = 0;
                        for (int k = 0; k < baris2; k++)
                        {
                            arrayC[i, j] += arrayA[i, j] * arrayB[k, j];
                        }
                        Console.Write("{0}\t", arrayC[i, j]);
                    }
                    Console.WriteLine();
                }
            }
        }

        static void Main(string[] args)
        {
            string ulang;
            Program hitung = new Program();

            do
            {
                Console.Clear();
                Console.WriteLine("PILIH MENU : ");
                Console.WriteLine("1. PENJUMLAHAN");
                Console.WriteLine("2. PENGURANGAN");
                Console.WriteLine("3. PERKALIAN");
                Console.WriteLine("4. EXIT");
                Console.Write("Masukkan Pilihan Anda : ");
                int pilih = int.Parse(Console.ReadLine());

                switch (pilih)
                {
                    case 1: hitung.penjumlahan(); break;
                    case 2: hitung.pengurangan(); break;
                    case 3: hitung.perkalian(); break;               
                    case 4: Environment.Exit(0); break;
                }
                Console.Write("Kembali Ke Menu Awal? (Y/T) ");
                ulang = Console.ReadLine();
                Console.WriteLine();
            } while (ulang.Equals("y") || ulang.Equals("Y"));
            if (ulang.Equals("N") || ulang.Equals("n"))
            {
                Environment.Exit(0);
            }
        }
    }
}