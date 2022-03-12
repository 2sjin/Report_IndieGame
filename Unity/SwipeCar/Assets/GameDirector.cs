using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour {
    GameObject car;
    GameObject flag;
    GameObject distance;

    void Start() {
        // 게임 오브젝트 불러오기
        this.car = GameObject.Find("car");
        this.flag = GameObject.Find("flag");
        this.distance = GameObject.Find("distance");
    }

    void Update() {
        // 자동차에서 깃발로 가기 위한 거리 계산
        float length = this.flag.transform.position.x - this.car.transform.position.x;
        
        // 텍스트 컴포넌트에 거리 출력
        this.distance.GetComponent<Text>().text = "목표 지점까지 " + length.ToString("F2") + "m";
    }

}
