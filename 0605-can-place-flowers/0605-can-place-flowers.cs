public class Solution {
    public bool CanPlaceFlowers(int[] flowerbed, int n) {
        var isPrevFlower = false;
        var result = 0;
        for (var i=0; i<flowerbed.Length; i++) {
            if (flowerbed[i] == 0) {
                if (!isPrevFlower && (i == flowerbed.Length - 1 || flowerbed[i + 1] == 0)) {
                    isPrevFlower = true;
                    result++;
                }
                else {
                    isPrevFlower = false;
                }
            }
            else {
                isPrevFlower = true;
            }
        }
        return result >= n;
    }
}