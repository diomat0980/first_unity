using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class controller : MonoBehaviour
{
    // ���α׷��� ����Ǵ� ������ ������ �Ʒ��� ����˴ϴ�.

    /*
    // ����? �Ǽ�? ���ڿ�? ����?
    // 4 byte ũ���� �޸� ������ �����˴ϴ�.
    
    // hp��� �޸� ������ ���� �����ؾ� �մϴ�.
    // ������ ���� �������� �ʰ� ���� �ϰ� �Ǹ� �⺻������ 0�� ���ϴ�.
    int hp = 100;
    */

    public int hp = 100;

    // int hp = 100;

    // ���ڿ� : ���ڰ� ���� �� ����Ǿ� �ִ� �����Դϴ�.
    public string name = "Kim Kyu Min";

    public float height = 175.6f;

    public char bloodType = 'B';

    // Start : ������ ����Ǿ��� �� �� �ѹ��� ȣ��Ǵ� �Լ��Դϴ�.
    // Start is called before the first frame update
    void Start()
    {
        hp = 300;

        //  ���� ������Ʈ�� �Ӽ��� �ʱ�ȭ�� �� ����մϴ�.
        print(hp);
        print(name);
        print(height);
        print(bloodType);
    }

    // Update : ������ ����Ǿ��� �� �� �����Ӹ��� ȣ��Ǵ� �Լ��Դϴ�.
    // Update is called once per frame
    void Update()
    {
        //  ���� ������Ʈ�� �Է��̳� ��ġ �̵��� �� �� ����մϴ�.
    }
}
