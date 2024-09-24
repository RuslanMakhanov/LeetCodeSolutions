public class Solution {
    public int[][] Construct2DArray(int[] original, int m, int n) {
          // If the length of the original array does not match m * n, return null
        if (original.Length != m * n) {
            return [];
        }

        int [][] arr_output = new int [m][];
        for (int a=0; a<m; a++){
            arr_output[a] = new int[n];
            for (int i = 0; i<n; i++){
                arr_output[a][i] = original[a*n+i];
            }
        }

        return arr_output; 
    }
}