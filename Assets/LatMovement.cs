using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEditor.Rendering;
using UnityEngine;

public class LatMovement : MonoBehaviour
{
    // Start is called before the first frame update

    Material mat;
    float distance;
    [Range(0f, 0.5f)]
    public float moveSpeed = 0.2f;
    //public float deadZone = -45;

    void Start()
    {
        mat = GetComponent<Renderer>().material;
    }

    // Update is called once per frame
    void Update()
    {
        distance = Time.deltaTime * moveSpeed;
        mat.SetTextureOffset("_Maintex", Vector2.right * distance);
        // if(transform.position.x < deadZone){
        //     Debug.Log("Pipe deleted");
        //     Destroy(gameObject);
        // }   
    }
}
