using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AutoTexturer : MonoBehaviour
{
    public Material floorMaterial;
    public Material openWallMaterial;
    public Material singleWallMaterial;
    public Material iShapeWallMaterial;
    public Material lShapeWallMaterial;
    public Material uShapeWallMaterial;
    public Material emptyCeilingMaterial;
    public Material fluorescentCeilingMaterial;
    public Material lampCeilingMaterial;
    MeshRenderer mr;

    // Start is called before the first frame update
    void Start()
    {
        mr = gameObject.GetComponent<MeshRenderer>();

        // Texture everything based on its tag
        if (gameObject.CompareTag("Bouncy Floor"))
        {
            mr.material = floorMaterial;
        }
        else if (gameObject.CompareTag("Open Wall"))
        {
            mr.material = openWallMaterial;
        }
        else if (gameObject.CompareTag("Single Wall"))
        {
            mr.material = singleWallMaterial;
        }
        else if (gameObject.CompareTag("I-Shape Wall"))
        {
            mr.material = iShapeWallMaterial;
        }
        else if (gameObject.CompareTag("L-Shape Wall"))
        {
            mr.material = lShapeWallMaterial;
        }
        else if (gameObject.CompareTag("U-Shape Wall"))
        {
            mr.material = uShapeWallMaterial;
        }
        else if (gameObject.CompareTag("Empty Ceiling"))
        {
            mr.material = emptyCeilingMaterial;
        }
        else if (gameObject.CompareTag("Fluorescent Ceiling"))
        {
            mr.material = fluorescentCeilingMaterial;
        }
        else if (gameObject.CompareTag("Lamp Ceiling"))
        {
            mr.material = lampCeilingMaterial;
        }
    }
}
