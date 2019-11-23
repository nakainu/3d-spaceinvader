using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class move : MonoBehaviour
{
  public GameObject Space_Invader;
  //  動かしたいプレイヤー
  bool right = false;
  //  右ボタンを押しているかの真偽値
  bool left = false;
  //  左ボタンを押しているかの真偽値
  bool front = false;
  //　上ボタンを押しているのかの真偽値
  bool back = false;
  //　下ボタンを押しているのかの真偽値


  // Use this for initialization
  void Start () {

  }

  // Update is called once per frame
  void Update () {
      if (right) {
          goright ();
  //          右に動かすためのメソッドを呼び出す
      }else if (left) {
          goleft ();
  //          左に動かすためのメソッドを呼び出す
      }else if (front) {
          gofront ();
  //          上に動かすためのメソッドを呼び出す
      }else if (back) {
          goback ();
  //          下に動かすためのメソッドを呼び出す
      } else {

      }
  }

  public void rPushDown(){
  //      右ボタンを押している間
      right = true;
  }

  public void rPushUp(){
  //      右ボタンを押すのをやめた時
      right = false;
  }

  public void lPushDown(){
  //      左ボタンを押している間
      left = true;
  }

  public void lPushUp(){
  //      左ボタンを押すのをやめた時
      left = false;
  }

  public void fPushDown(){
  //      上ボタンを押している間
      front = true;
  }

  public void fPushUp(){
  //      上ボタンを押すのをやめた時
      front = false;
  }

  public void bPushDown(){
  //      下ボタンを押している間
      back = true;
  }

  public void bPushUp(){
  //      下ボタンを押すのをやめた時
      back = false;
  }

  public void goright(){
      if (transform.position.x <= 5.0f) {
  //          プレイヤーの位置が5.0f以下の時
  //          ↑画面からはみ出さないための条件
          transform.position += new Vector3 (5.0f * Time.deltaTime, 0, 0);
  //          プレイヤーをx軸方向に秒速5.0fで動かす
      }
  }

  public void goleft(){
      if (transform.position.x >= -5.0f) {
  //          プレイヤーの位置が-5.0f以上の時
  //          ↑画面からはみ出さないための条件
          transform.position += new Vector3 (-5.0f * Time.deltaTime, 0, 0);
  //          プレイヤーをx軸方向に秒速-5.0fで動かす
      }
  }

  public void gofront(){
      if (transform.position.z <= 5.0f) {
  //          プレイヤーの位置が-5.0f以上の時
  //          ↑画面からはみ出さないための条件
          transform.position += new Vector3 (0, 0, 5.0f * Time.deltaTime);
  //          プレイヤーをx軸方向に秒速-5.0fで動かす
      }
  }

  public void goback(){
      if (transform.position.z >= -5.0f) {
  //          プレイヤーの位置が-5.0f以上の時
  //          ↑画面からはみ出さないための条件
          transform.position += new Vector3 (0, 0, -5.0f * Time.deltaTime);
  //          プレイヤーをx軸方向に秒速-5.0fで動かす
      }
  }

}
