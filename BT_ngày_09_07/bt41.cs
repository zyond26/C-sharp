/*Bài tập 41. Viết chương trình đầy đủ để chạy đoạn code sau về List of List
List<List<string>> myList = new List<List<string>>(); 
myList.Add(new List<string> { "a", "b" }); 
myList.Add(new List<string> { "c", "d", "e" }); 
myList.Add(new List<string> { "qwerty", "asdf", "zxcv" }); 
myList.Add(new List<string> { "a", "b" }); 
// To iterate over it. 
foreach (List<string> subList in myList) 
 { 
        foreach (string item in subList) 
        { 
               Console.WriteLine(item); 
        } 
}

Chuyển cách duyệt foreach trên sang cách duyệt for theo chỉ số*/


using System;
using System.Collections.Generic;

class Program
{
    public static void Main()
    {
        List<List<string>> myList = new List<List<string>>();
        
        myList.Add(new List<string> { "a", "b" });
        myList.Add(new List<string> { "c", "d", "e" });
        myList.Add(new List<string> { "qwerty", "asdf", "zxcv" });
        myList.Add(new List<string> { "a", "b" });
        
        for (int i = 0; i < myList.Count; i++)
        {
            List<string> subList = myList[i];
            
            for (int j = 0; j < subList.Count; j++)
            {
                string item = subList[j];
                Console.WriteLine(item);
            }
        }
    }
}
