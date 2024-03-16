public class Solution {
    public bool CanFinish(int numCourses, int[][] prerequisites) {

     var preqMap = new Dictionary<int, List<int>>();
     var visited = new HashSet<int>();
        
        for(int i=0;i<numCourses;i++){
            preqMap[i] = new List<int>();
        }


        foreach(var prerequisite in prerequisites){
            var course = prerequisite[0];
            var coursePreq = prerequisite[1];
            preqMap[course].Add(coursePreq);
        }

            foreach(var preq in preqMap.Keys){
                if(!dfs(preq))
                    return false;
                }

        bool dfs(int course){
            if(visited.Contains(course)){
                return false;
            }
            if(preqMap[course].Count == 0){
                return true;
            }
            visited.Add(course);
            foreach(var preq in preqMap[course]){
                if(!dfs(preq)){
                    return false;
                }
            }
            visited.Remove(course);
            preqMap[course] = new List<int>();
            return true;
        }
        return true;
    }
}
