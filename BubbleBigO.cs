using System; 
      
  
class BubbleOp 
{  
     
    static void bubbleSort(int []arr, int n) 
    { 
        int i, j, temp; 
        bool swapped; 
        for (i = 0; i < n - 1; i++)  
        { 
            swapped = false; 
            for (j = 0; j < n - i - 1; j++)  
            { 
                if (arr[j] > arr[j + 1])  
                { 
                    
                    temp = arr[j]; 
                    arr[j] = arr[j + 1]; 
                    arr[j + 1] = temp; 
                    swapped = true; 
                } 
            } 
  
            if (swapped == false) 
                break; 
        } 
    } 
  
   
    static void printArray(int []arr, int size) 
    { 
        int i; 
        for (i = 0; i < size; i++) 
            Console.Write(arr[i] + " "); 
        Console.WriteLine(); 
    } 
  
   
    public static void Main() 
    { 
        int []arr = {64, 34, 25, 12, 22, 11, 90,80,64,31,440}; 
        int n = arr.Length; 
        bubbleSort(arr,n); 
        Console.WriteLine("Array sorteado"); 
        printArray(arr,n); 
    } 
  
} 