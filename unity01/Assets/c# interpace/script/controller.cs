using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour
{
    // 프로그램이 실행되는 순서는 위에서 아래로 실행됩니다.

    /*
    // 정수? 실수? 문자열? 문자?
    // 4 byte 크기의 메모리 공간이 생성됩니다.
    
    // hp라는 메모리 공간에 값을 저장해야 합니다.
    // 변수에 값을 저장하지 않고 선언만 하게 되면 기본값으로 0이 들어갑니다.
    int hp = 100;
    */

    public int hp = 100;

    // int hp = 100;

    // 문자열 : 문자가 여러 개 연결되어 있는 문자입니다.
    public string name = "Kim Kyu Min";

    public float height = 175.6f;

    public char bloodType = 'B';

    // Start : 게임이 실행되었을 때 단 한번만 호출되는 함수입니다.
    // Start is called before the first frame update
    void Start()
    {
        hp = 300;

        //  게임 오브젝트의 속성을 초기화할 떄 사용합니다.
        print(hp);
        print(name);
        print(height);
        print(bloodType);
    }

    // Update : 게임이 실행되었을 떄 매 프레임마다 호출되는 함수입니다.
    // Update is called once per frame
    void Update()
    {
        //  게임 오브젝트의 입력이나 위치 이동을 할 때 사용합니다.
    }
}
