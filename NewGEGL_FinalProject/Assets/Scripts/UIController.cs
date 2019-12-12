using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class UIController : MonoBehaviour
{

    public UIItem menuItemPrefab;
    public Transform HeadPanel;
    public Transform WeaponsPanel;
    public Transform ShieldPanel;
 
    public void CreatePanelItem( BodyPart bodypart ,List<ItemSO> items)
    {
        foreach (ItemSO item in items)
        { 
            //int i = 0;
            if (bodypart == BodyPart.Head)
            {
                //Instantiate((GetComponent<item>().itemIcon), HeadPanel);
                //Instantiate((GetComponent<item>().itemNameText), HeadPanel);
                UIItem[] go = HeadPanel.GetComponentsInChildren<UIItem>();
                int i = ReturnIndex(go);
                if (go[i].isInitialized)
                {
                    i++;
                }
                go[i].itemData = item;
                go[i].podium = GetComponent<Podium>();
                go[i].Init(item);
            }

           else

            if (bodypart == BodyPart.Shield)
            {
                //Instantiate((GetComponent<item>().itemIcon), HandsPanel);
                //Instantiate((GetComponent<item>().itemNameText),HandsPanel);
                UIItem[] go = ShieldPanel.GetComponentsInChildren<UIItem>();
                int i = ReturnIndex(go);
                go[i].itemData = item;
                go[i].podium = GetComponent<Podium>();
                go[i].Init(item);
            }

            else

            if (bodypart == BodyPart.Weapons)
            {
                //Instantiate((GetComponent<item>().itemIcon), BodyPanel);
                //Instantiate((GetComponent<item>().itemNameText), BodyPanel);
                UIItem[] go = WeaponsPanel.GetComponentsInChildren<UIItem>();
                int i = ReturnIndex(go);
                if (go[i].isInitialized)
                {
                    i++;
                }
                go[i].itemData = item;
                go[i].podium = GetComponent<Podium>();
                go[i].Init(item);
            }
        }
    }

    int ReturnIndex(UIItem[] go)
    {
        for (int i = 0; i < go.Length; i++)
        {
            if (!go[i].isInitialized)
            {
                return i;
            }
        }

        return 0;
    }
}
