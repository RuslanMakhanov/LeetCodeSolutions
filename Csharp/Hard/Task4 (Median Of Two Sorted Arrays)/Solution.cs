public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        int[] mergedArray = new int [nums1.Length+nums2.Length];
        int a = 0, b = 0, c = 0;

        while (a < nums1.Length && b < nums2.Length){
            if (nums1[a] < nums2[b]){
                mergedArray[c++] = nums1[a++];
            }
            else{
                mergedArray[c++] = nums2[b++];
            }
        }
        while (a< nums1.Length){
            mergedArray[c++] = nums1[a++];
        }
        while (b< nums2.Length){
            mergedArray[c++] = nums2[b++];
        }
        int totalLength = mergedArray.Length;
        if (totalLength % 2 == 1){
            return mergedArray[totalLength / 2];
        }
        else{
            return (mergedArray[totalLength / 2 -1] + mergedArray[totalLength / 2]) /2.0;
        }

    }
}