using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class ZadaniaNaLekcje : MonoBehaviour
{
    
    
   

    void Start()
    {
        List<int> dane = new List<int> { 1, 3, 3, 1, 2, 2, 3, 1, 3, 2 };
        List<int> jedynki = new List<int>();
        List<int> dwojki = new List<int>();
        List<int> trojki = new List<int>();
       

        foreach(int i in dane)
        {
            

            if(i == 1)
            {
                jedynki.Add(i);          
            }
            else if(i == 2)
            {
                dwojki.Add(i);
            }
            else if(i == 3)
            {
                trojki.Add(i);
            }
        }






        


        Debug.Log("dane: " + dane.Count);
        Debug.Log("jedynki: " + jedynki.Count);
        Debug.Log("dwojki: " + dwojki.Count);
        Debug.Log("trojki: " + trojki.Count);
    }   

   
  
}
