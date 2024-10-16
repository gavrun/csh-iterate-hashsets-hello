namespace csh_iterate_hashsets_hello;

using System;
using System.Collections.Generic;

public class RecursivePowerSetGenerator
{
    public static List<List<T>> RecursivePowerSet<T>(List<T> items)
    {
        // Начальный список подмножеств - копия исходных элементов
        List<List<T>> ps = new List<List<T>>();
        foreach (T item in items)
        {
            ps.Add(new List<T> { item });
        }

        // Проходим по каждому элементу списка
        foreach (T e in items)
        {
            // Удаляем элемент e из копии списка
            List<T> subsetWithoutE = new List<T>(items);
            subsetWithoutE.Remove(e);
            
            // Рекурсивно получаем все подмножества оставшихся элементов
            List<List<T>> recursiveSets = RecursivePowerSet(subsetWithoutE);
            
            // Добавляем их к текущему списку подмножеств
            ps.AddRange(recursiveSets);
        }

        return ps;
    }
}
