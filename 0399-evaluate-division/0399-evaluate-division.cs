public class Solution 
{
    private readonly Dictionary<string, List<(string neg, double res)>> _graph = new();

    public double[] CalcEquation(
        IList<IList<string>> equations,
        double[] values,
        IList<IList<string>> queries) {
            var i = 0;
            foreach(var equation in equations){
                var divident = equation[0];
                var divisor = equation[1];

                _graph[divident] = _graph.GetValueOrDefault(divident, new List<(string, double)>());
                _graph[divident].Add((divisor, values[i]));

                _graph[divisor] = _graph.GetValueOrDefault(divisor, new List<(string, double)>());
                _graph[divisor].Add((divident, 1 / values[i]));

                i += 1;
            }

            var result = new double[queries.Count];
            for(var j = 0; j<queries.Count; j++){
                var visit = new HashSet<string>();
                if(queries[j][0] == queries[j][1] && _graph.ContainsKey(queries[j][0])){
                    result[j] = 1;
                    continue;
                }
                result[j] = DFS(queries[j][0], queries[j][1], 1.0, visit);
            }
            return result.ToArray();
    }

    private double DFS(string start, string dest, double inter, HashSet<string> visit){
        if(!_graph.ContainsKey(start)){
            return -1;
        }

        var temp = new List<double>();

        visit.Add(start);
        foreach(var (neg, res) in _graph[start]){
            if(neg == dest){
                return inter * res;
            }

            if(!visit.Contains(neg)){
                temp.Add(DFS(neg, dest, inter * res, visit));
            }
            else{
                temp.Add(-1);
            }
        }
        visit.Remove(start);

        if(temp.Any(x=>x != -1)){
            return temp.First(x=>x != -1);
        }

        return -1;
    }
}