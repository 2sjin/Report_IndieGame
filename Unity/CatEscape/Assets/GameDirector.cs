using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameDirector : MonoBehaviour
{
    GameObject hpGauge;

    void Start() {
        // HP 게이지 가져오기
        this.hpGauge = GameObject.Find("hpGauge");
    }

    public void DecreaseHp() {
        // HP 감소
        this.hpGauge.GetComponent<Image>().fillAmount -= 0.1f;
    }
}
