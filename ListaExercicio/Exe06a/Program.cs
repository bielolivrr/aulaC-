﻿//PASSOS PARA RESOLVER O EXERCÍCIO
//1 - Criar um vetor de 1000 posições
//2 - Preencher o vetor com valores aleatórios
//3 - Imprimir o vetor na tela
//4 - Ordenar o vetor com o Bubble Sort

//Criar um vetor de valores inteiros
int[] vetor = new int[100];

//Gerar um valor randômico
Random r = new Random();

//Preencher o vetor com valores aleatórios
for (int i = 0; i < vetor.Length; i++)
{
    vetor[i] = r.Next(1000);
}

//Imprimir o vetor com valores aletatórios
for (int i = 0; i < vetor.Length; i++)
{
    Console.Write(vetor[i] + " ");
}

//Ordenar o vetor com o Bubble Sort
for (int i = 0; i < vetor.Length - 1; i++)
{
    //Trocar valores
    if (vetor[i] > vetor[i + 1])
    {
        int aux = vetor[i];
        vetor[i] = vetor[i + 1];
        vetor[i + 1] = aux;
    }
}

Console.WriteLine("\n");
//Imprimir o vetor com valores ordenados
for (int i = 0; i < vetor.Length; i++)
{
    Console.Write(vetor[i] + " ");
}