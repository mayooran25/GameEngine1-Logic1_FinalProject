using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class UIController : MonoBehaviour
{

    public GameObject menuItemPrefab;
    public Transform HeadPanel;
    public Transform FeetPanel;
    public Transform WeaponsPanel;
    public Transform HandsPanel;
    public Transform BodyPanel;
 
    public void CreatePanelItem( BodyPart bodypart ,List<ItemSO> items)
    {
        foreach (ItemSO item in items)
        {
           if (bodypart == BodyPart.Head)
            {
                //Instantiate((GetComponent<item>().itemIcon), HeadPanel);
                //Instantiate((GetComponent<item>().itemNameText), HeadPanel);
                GameObject go = Instantiate(menuItemPrefab, HeadPanel);
                go.GetComponent<item>().Init(item);
            }

           else

            if (bodypart == BodyPart.Feet)
            { 
                //Instantiate((GetComponent<item>().itemIcon),FeetPanel);
                //Instantiate((GetComponent<item>().itemNameText), FeetPanel);
                GameObject go = Instantiate(menuItemPrefab, FeetPanel);
                go.GetComponent<item>().Init(item);
            }

           else

            if (bodypart == BodyPart.Hands)
            {
                //Instantiate((GetComponent<item>().itemIcon), HandsPanel);
                //Instantiate((GetComponent<item>().itemNameText),HandsPanel);
                GameObject go = Instantiate(menuItemPrefab, HandsPanel);
                go.GetComponent<item>().Init(item);
            }

            else

            if (bodypart == BodyPart.Body)
            {
                //Instantiate((GetComponent<item>().itemIcon), BodyPanel);
                //Instantiate((GetComponent<item>().itemNameText), BodyPanel);
                GameObject go = Instantiate(menuItemPrefab, BodyPanel);
                go.GetComponent<item>().Init(item);
            }

            else

            if (bodypart == BodyPart.Weapons)
            {
                //Instantiate((GetComponent<item>().itemIcon), WeaponsPanel);
                //Instantiate((GetComponent<item>().itemNameText), WeaponsPanel);
                GameObject go = Instantiate(menuItemPrefab, WeaponsPanel);
                go.GetComponent<item>().Init(item);
            }
        }
    }









}
