
using System; 
  
class Quikk { 
      
    /* Esta função leva o último elemento como pivô,
coloca o elemento pivô em sua posição correta
posição na matriz classificada, e coloca todos
menor (menor que o pivô) à esquerda de
pivô e todos os elementos maiores à direita
de pivô */
    static int partition(int []arr, int low, int high) 
    { 
        int pivot = arr[high];  
          
        //indice do menor elemento  
        int i = (low - 1);  
        for (int j = low; j < high; j++) 
        { 
            // se o elemento for menor que o pivo  
            
            if (arr[j] < pivot) 
            { 
                i++; 
  
            
                int temp = arr[i]; 
                arr[i] = arr[j]; 
                arr[j] = temp; 
            } 
        } 
  
        
        int temp1 = arr[i+1]; 
        arr[i+1] = arr[high]; 
        arr[high] = temp1; 
  
        return i+1; 
    } 
  
  
    // Funcão QuickSort
    
    static void quickSort(int []arr, int low, int high) 
    { 
        if (low < high) 
        { 
              
            
            int pi = partition(arr, low, high); 
  
            // Recursively sort elements before 
            // partition and after partition 
            quickSort(arr, low, pi-1); 
            quickSort(arr, pi+1, high); 
        } 
    } 
  
   
    static void printArray(int []arr, int n) 
    { 
        for (int i = 0; i < n; ++i) 
            Console.Write(arr[i] + " "); 
              
        Console.WriteLine(); 
    } 
  
  
    public static void Main() 
    { 
        int []arr = {10, 7, 8, 9, 1, 5,13,20,14,80,64,69,12}; 
        int n = arr.Length; 
        quickSort(arr, 0, n-1); 
        Console.WriteLine("sorted array "); 
        printArray(arr, n); 
    } 
} 
  
