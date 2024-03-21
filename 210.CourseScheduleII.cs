public class Solution {
// Topological sort
    public int[] FindOrder(int numCourses, int[][] prerequisites) {
        var preqMap = new Dictionary<int,List<int>>();
        var indegree = new int[numCourses]; 
        for(int i=0;i<numCourses;i++){
            preqMap[i] = new List<int>();
        }

//[1,0] -> 1 is dependent on 0 , you should finish course zero first, that is represnted by 
// { 0, [1] }
// { 1, [] }
        foreach(var prerequisite in prerequisites){
            var course = prerequisite[0];
            var coursePreq = prerequisite[1];
            preqMap[coursePreq].Add(course);

            indegree[course]++;            

        }

        
        Queue<int> queue = new Queue<int>();

        for(int i =0; i<numCourses; i++)
        {
            if(indegree[i]==0)
               queue.Enqueue(i);
        }

        var courseOrder = new int [numCourses];
        int coursesCount=0;

// BFS
        while(queue.Count() != 0)
        {
            int currentCourse = queue.Dequeue();
            
            courseOrder[coursesCount++] = currentCourse;  

            foreach( int preqCourse in preqMap[currentCourse])
            {
                if(--indegree[preqCourse]== 0)
                    queue.Enqueue(preqCourse);
            }

        }
        
        return coursesCount == numCourses ? courseOrder : new int[0];
    }


        //     var preqMap = new Dictionary<int, List<int>>();
        //     var indegree = new int[numCourses];
        //     for (int i = 0; i < numCourses; i++)
        //     {
        //         preqMap[i] = new List<int>();
        //     }

        //     //[1,0] -> 1 is dependent on 0 , you should finish course zero, that is represnted by 
        //     // { 1, [0] }
        //     // { 0, [] }
        //     foreach (var prerequisite in prerequisites)
        //     {
        //         var course = prerequisite[0];
        //         var coursePreq = prerequisite[1];
        //         preqMap[coursePreq].Add(course);

        //         indegree[course]++;

        //     }


        //     Stack<int> queue = new Stack<int>();

        //     for (int i = 0; i < numCourses; i++)
        //     {
        //         if (indegree[i] == 0)
        //             queue.Push(i);
        //     }

        //     var courseOrder = new int[numCourses];
        //     int coursesCount = 0;

        //     while (queue.Count() != 0)
        //     {
        //         int currentCourse = queue.Pop();

        //         courseOrder[coursesCount++] = currentCourse;

        //         foreach (int preqCourse in preqMap[currentCourse])
        //         {
        //             if (--indegree[preqCourse] == 0)
        //                 queue.Push(preqCourse);
        //         }

        //     }

        //     return coursesCount == numCourses ? courseOrder : new int[0];
            
        // }
}      
