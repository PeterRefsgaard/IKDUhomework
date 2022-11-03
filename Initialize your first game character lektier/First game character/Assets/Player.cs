using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour

{
    public string Name = "Jack";
    private int Level = 3;
    


    // Start is called before the first frame update
    void Start()
    {
        /// Calls values for level and character name, {0} is a placeholder for the first value which is name and {1} is the placeholder for the value Level
        Debug.LogFormat("Current name and level of character is {0} and {1}", Name, Level);
       

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
