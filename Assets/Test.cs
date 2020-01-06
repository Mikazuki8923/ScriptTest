using System.Collections;
using System.Collections.Generic;
using UnityEngine;
  
public class Boss {
    private int mp = 53;
    
    //Magic関数
    public void Magic(int a) {
        this.mp -= a - (a - 5);
        if (this.mp > 0) {
            Debug.Log("魔法攻撃をした。残りmpは" + this.mp + "。");
        } else {
            Debug.Log("MPが足りないため魔法が使えない。");
        }
    }
}



public class Test : MonoBehaviour
{

    // Use this for initialization
    void Start() {
      
        Boss lastboss = new Boss();
        for (int a = 6; a < 17; a++) {
            lastboss.Magic(a);
        }
        

        int[] array = new int[5];

        array[0] = 50;
        array[1] = 80;
        array[2] = 100;
        array[3] = 20;
        array[4] = 30;

        for (int i = 0; i < array.Length; i++)
        {
            Debug.Log(array[i]);
        }
        for (int h = array.Length - 1; h >= 0; h--)
        {
            Debug.Log(array[h]);
        }

    }

    // Update is called once per frame
    void Update()
    {
      

    }
}
