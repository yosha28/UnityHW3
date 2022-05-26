using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CylindrControler : MonoBehaviour
{
    [SerializeField]
   private Vector3 moveCube = new Vector3(0, 2, 4);
    [SerializeField]
    private Vector3 rotateCube = new Vector3(0, 0, 0);
    private float rotate = 90f;
    // Start is called before the first frame update
    void Start()
    {
        Debug.Log("Start");
    }

    // Update is called once per frame
    void Update()
    {
      //  transform.position = new Vector3(0,2, 4);
       // Debug.Log("Update"+Time.deltaTime);
    }
    void FixedUpdate()
    {
        transform.position = transform.position + moveCube * Time.fixedDeltaTime;
        transform.Rotate(rotateCube,rotate*Time.fixedDeltaTime);

        Debug.Log("FixedUpdate"+ Time.deltaTime);
    }
    void Awake()
    {
        Debug.Log("Awake" + Time.deltaTime);
    }
}
