using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Monster : MonoBehaviour
{
    protected int health;      // private : �� �ڽŸ� �����Ͽ� ����� �� �ִ�.
    protected int attack;      // public : �ܺο����� �����Ͽ� ����� �� �ִ�.
    public string name;  // protected : �� �ڽŰ� ����ϰ� �ִ� Ŭ���������� �����Ͽ� ����� �� �ִ�.


    public void Information()
    {
        print(health);
        print(attack);
        print(name);

    }
}

public class Memory : Monster
{

    // �ڵ� ���� : ���α׷��� ����Ǵ� �ڵ���� ����Ǵ� �����̴�.
    // ������ ���� : ���� ������ ���� ������ ����ȴ� �����̴�.
    // �� ���� : �������� ������ �޸𸮸� �����ϴ� �����̴�.
    // ���� ���� : ���� ������ �Լ��� �Ű� ����� ����Ǵ� �����̴�.

    public int value = 100;

    void Start()
    {
        
        health = 100;
        attack = 100;
        Information();

        int value = 250;    // <- ��������
        int area = 500; // �Լ� �ȿ��� �����Ǹ�, �Լ��� ����� �Ҹ��ϴ� �����̴�.


    }

    private void Update()
    {
        Move();
 //       Calculator(10, 24);
        print(Add(10, 10));
    }


    private void Move() // ������Ʈ�� �̵���Ű�� �Լ�
    {

        transform.position += new Vector3(1, 1, 0) * Time.deltaTime;

    }

    private void Calculator(int x, int y)
    {
        int temp = y + x;
        print(temp);
    }

    private int Add(int x, int y)
    {
        return x + y;
    }

 //   void : �ڷ����� �������� �ʴ´�.

}
