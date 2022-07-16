using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
    GameObject player;

    void Start() {
        this.player = GameObject.Find("cat");
    }

    void Update() {
        Vector3 playerPos = this.player.transform.position; // cat의 위치
        Vector3 cameraPos = transform.position;     // 카메라의 위치
        transform.position = new Vector3(cameraPos.x, playerPos.y, cameraPos.z);
    }
}
