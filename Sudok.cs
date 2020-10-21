using System; 
  
class Sudo { 
  
    public static bool isSafe(int[, ] board, int row, int col, int num) 
    { 
        
        for (int d = 0; d < board.GetLength(0); d++) { 
 // se o número que estamos tentando
// lugar já está presente em
// essa linha, retorna false;
            if (board[row, d] == num) { 
                return false; 
            } 
        } 
  
// coluna tem os números únicos 
        for (int r = 0; r < board.GetLength(0); r++) { 
           // se o número que estamos tentando
// lugar já está presente em
// essa coluna, retorna falso;
            if (board[r, col] == num) { 
                return false; 
            } 
        } 
  
// quadrado correspondente tem
// número único 
        int sqrt = (int)Math.Sqrt(board.GetLength(0)); 
        int boxRowStart = row - row % sqrt; 
        int boxColStart = col - col % sqrt; 
  
        for (int r = boxRowStart; 
             r < boxRowStart + sqrt; r++) { 
            for (int d = boxColStart; 
                 d < boxColStart + sqrt; d++) { 
                if (board[r, d] == num) { 
                    return false; 
                } 
            } 
        } 
  
      // se não houver conflito, é seguro
        return true; 
    } 
  
    public static bool solveSudoku(int[, ] board, int n) 
    { 
        int row = -1; 
        int col = -1; 
        bool isEmpty = true; 
        for (int i = 0; i < n; i++) { 
            for (int j = 0; j < n; j++) { 
                if (board[i, j] == 0) { 
                    row = i; 
                    col = j; 
  
// ainda temos alguns restantes
// valores ausentes no Sudoku
                    isEmpty = false; 
                    break; 
                } 
            } 
            if (!isEmpty) { 
                break; 
            } 
        } 
  
// nenhum espaço vazio deixado 
        if (isEmpty) { 
            return true; 
        } 
  
// else para cada linha de retorno
        for (int num = 1; num <= n; num++) { 
            if (isSafe(board, row, col, num)) { 
                board[row, col] = num; 
                if (solveSudoku(board, n)) { 
                   
                    return true; 
                } 
                else { 
// substitua
                    board[row, col] = 0; 
                } 
            } 
        } 
        return false; 
    } 
  
    public static void print(int[, ] board, int N) 
    { 
       
        for (int r = 0; r < N; r++) { 
            for (int d = 0; d < N; d++) { 
                Console.Write(board[r, d]); 
                Console.Write(" "); 
            } 
            Console.Write("\n"); 
  
            if ((r + 1) % (int)Math.Sqrt(N) == 0) { 
                Console.Write(""); 
            } 
        } 
    } 
  
    
    public static void Main(String[] args) 
    { 
  
        int[, ] board = new int[, ] { 
            { 3, 0, 6, 5, 0, 8, 4, 0, 0 }, 
            { 5, 2, 0, 0, 0, 0, 0, 0, 0 }, 
            { 0, 8, 7, 0, 0, 0, 0, 3, 1 }, 
            { 0, 0, 3, 0, 1, 0, 0, 8, 0 }, 
            { 9, 0, 0, 8, 6, 3, 0, 0, 5 }, 
            { 0, 5, 0, 0, 9, 0, 6, 0, 0 }, 
            { 1, 3, 0, 0, 0, 0, 2, 5, 0 }, 
            { 0, 0, 0, 0, 0, 0, 0, 7, 4 }, 
            { 0, 0, 5, 2, 0, 6, 3, 0, 0 } 
        }; 
        int N = board.GetLength(0); 
  
        if (solveSudoku(board, N)) { 
            print(board, N); // mostrar solução
        } 
        else { 
            Console.Write("sem solução"); 
        } 
    } 
} 
  
