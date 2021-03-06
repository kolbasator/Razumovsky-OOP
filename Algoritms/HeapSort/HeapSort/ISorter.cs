﻿using System;
using System.Collections.Generic;
using System.Text;

namespace HeapSort
{
    public interface ISorter
    {
        void Swap(List<int> arr, int firstIndex, int secondIndex);
        void Heapify(List<int> arr, int index);
        int[] HeapSort(int[] array);
        int ExtractMax(List<int> arr);
    }
}
