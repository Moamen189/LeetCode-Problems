public class Solution {
    public double Average(int[] salary) {
        double AvgSalary = 0;
        
       Array.Sort(salary);
        
        for(int i = 1; i <= salary.Length-2; i++){
            AvgSalary += salary[i];
        }
        
        return AvgSalary / (salary.Length-2);
        
        
        
        
    }
}