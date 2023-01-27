public class Solution {
    public string Interpret(string command) 
        => command.Replace("(al)", "al").Replace("()", "o");
}