using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class boss {
    private int mp = 53;　

    //魔法攻撃用の関数
    public void Magic(int a) {
        
        for (int non = this.mp - a; non > -a; non -= a) {

            if (non >= 0) {
                Debug.Log("魔法攻撃をした。残りMPは" + non + "。");
            } else {
                Debug.Log("MPが足りないため魔法が使えない。");
            }
        }


    }
}


public class Test : MonoBehaviour
{

    // Use this for initialization
    
    

    void Start()  {
        int[] array = new int[5];

        array[0] = 50;
        array[1] = 30;
        array[2] = 80;
        array[3] = 60;
        array[4] = 120;

        //順番に表示
        for(int i = 0; i < array.Length; i++) {  
            Debug.Log(array [i]);　　　　
        }
      
        //逆順に表示
        for(int h = array.Length - 1; h >= 0; h--) {
            Debug.Log(array[h]);
        }


        boss lastboss = new boss();
        lastboss.Magic(5);
       
        



    }

    // Update is called once per frame
    void Update()
    {

    }
}

