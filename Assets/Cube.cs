using System.Collections;
using System.Collections.Generic;
using System.Numerics;
using UnityEngine;
using NetworkObjects;
using NetworkPlayer = NetworkObjects.NetworkPlayer;
using Quaternion = UnityEngine.Quaternion;
using Vector3 = UnityEngine.Vector3;

public class Cube : MonoBehaviour
{

    public string Address;
    private GameObject _cube;
    public Vector3 cubePos; 
    public float speed = 1.0f;

    // Start is called before the first frame update
    void Start()
    {
        _cube = GameObject.Find("NetworkClient");
        InstantiateCube(_cube,cubePos);
    }
    public void deleteCube()
    {
        Destroy(gameObject);
    }


    public void InstantiateCube(GameObject Cube,Vector3 position)
    {
        Instantiate(_cube, position, Quaternion.identity);
    }
    // Update is called once per frame
    void Update()
    {
       cubePos.x = this.transform.position.x;
       cubePos.y = this.transform.position.y;
       cubePos.z = this.transform.position.z;

        //if (_cube.GetComponent<NetworkPlayer>().id == Address)
        //{
        //    _cube.GetComponent<NetworkPlayer>().cubPos = cubePos;

        //    if (Input.GetKey(KeyCode.UpArrow))
        //    {
        //        //Debug.Log("Pressed");
        //        transform.Translate(Vector3.forward * Time.deltaTime * speed);
        //    }
        //    if (Input.GetKey(KeyCode.DownArrow))
        //    {
        //        //Debug.Log("Pressed");

        //        transform.Translate(-Vector3.forward * Time.deltaTime * speed);
        //    }
        //    if (Input.GetKey(KeyCode.LeftArrow))
        //    {
        //        // Debug.Log("Pressed");

        //        transform.Translate(Vector3.left * Time.deltaTime * speed);
        //    }
        //    if (Input.GetKey(KeyCode.RightArrow))
        //    {
        //        //Debug.Log("Pressed");

        //        transform.Translate(-Vector3.left * Time.deltaTime * speed);
        //    }
        //}

    }
}
