using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public float gravityMultiplier;
    Vector3 defaultGravity = new Vector3(0, -9.81f, 0);

    // Start is called before the first frame update
    void Start()
    {
        Physics.gravity = defaultGravity * gravityMultiplier;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
