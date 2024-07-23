using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Camera_FollowPlayer_TestScript : MonoBehaviour
{

    public GameObject player;
    private Vector3 CameraPos = new Vector3(0, 10, -7);

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void LateUpdate()
    {
        transform.position = player.transform.position + CameraPos;
    }

}
