using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collectReviveItem : MonoBehaviour
{

public int itemCount=0;
 
void OnTriggerEnter(Collider col) {
    if(col.tag=="ReviveItem") {
      Destroy(col.gameObject);
      itemCount ++;
    }
}

public int getItemCount() {
  return itemCount;
}

public void setItemCount() {
  itemCount--;
}

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
