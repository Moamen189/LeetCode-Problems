public class Solution {
    static bool CheckEquals(int[] arr1, int[] arr2){
        if(arr1.Length != arr2.Length){
            return false;
        }
        for(int i = 0; i < arr1.Length; i++){
            if(arr1[i] != arr2[i]){
                return false;
            }
        }
        return true;
    }
    static int[] CountOcurnces(string str)
    {
        int[] arr = new int[26];
        for (int i = 0; i < str.Length; i++)
        {
            arr[str[i] - 'a']++;
        }
        return arr;
    }
    public bool CloseStrings(string word1, string word2) 
    {
        if (word1.Length != word2.Length)
        {
            return false;
        }
        int[] array1 = CountOcurnces(word1);
        int[] array2 = CountOcurnces(word2);
        for (int i = 0; i < 26; i++)
        {
            if ((array1[i] > 0 && array2[i] == 0))
            {
                return false;
            }
            if ((array1[i] == 0 && array2[i] > 0))
            {
                return false;
            }
            }
        Array.Sort(array1);
        Array.Sort(array2);
        if (!CheckEquals(array1, array2))
        {
            return false;
        }
        return true;
    }
}