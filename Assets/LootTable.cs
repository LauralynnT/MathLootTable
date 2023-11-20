using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class LootTable : MonoBehaviour
{
    [SerializeField] private List<string> ChestTypes = new List <string>();
    [SerializeField] private List<string> DropTypes = new List<string>();
    //[Header("Wood Chest")]
    //[SerializeField] private List<int> wCommon;
    //[SerializeField] private List<int> wUncommon;
    //[SerializeField] private List<int> wRare;
    //[SerializeField] private List<int> wEpic;
    //[SerializeField] private List<int> wLegendary;
    //[Header("Bronze Chest")]
    //[SerializeField] private List<int> bCommon;
    //[SerializeField] private List<int> bUncommon;
    //[SerializeField] private List<int> bRare;
    //[SerializeField] private List<int> bEpic;
    //[SerializeField] private List<int> bLegendary;
    //[Header("Silver Chest")]
    //[SerializeField] private List<int> sCommon;
    //[SerializeField] private List<int> sUncommon;
    //[SerializeField] private List<int> sRare;
    //[SerializeField] private List<int> sEpic;
    //[SerializeField] private List<int> sLegendary;
    //[Header("Gold Chest")]
    //[SerializeField] private List<int> gCommon;
    //[SerializeField] private List<int> gUncommon;
    //[SerializeField] private List<int> gRare;
    //[SerializeField] private List<int> gEpic;
    //[SerializeField] private List<int> gLegendary;
    //[Header("Platinum Chest")]
    //[SerializeField] private List<int> pCommon;
    //[SerializeField] private List<int> pUncommon;
    //[SerializeField] private List<int> pRare;
    //[SerializeField] private List<int> pEpic;
    //[SerializeField] private List<int> pLegendary;

    // Start is called before the first frame update
    void Start()
    {
        ChestTypes.Add("Wood");
        ChestTypes.Add("Bronze");
        ChestTypes.Add("Silver");
        ChestTypes.Add("Gold");
        ChestTypes.Add("Platinum");

        DropTypes.Add("Common");
        DropTypes.Add("Uncommon");
        DropTypes.Add("Rare");
        DropTypes.Add("Epic");
        DropTypes.Add("Legendary");
    }

    // Update is called once per frame
    void Update()
    {
        int wood = 200;
        int bronze = wood + 100;
        int silver = bronze + 50;
        int gold = silver + 25;
        int platinum = gold + 5;

        int wCommon = 100;
        int wUncommon = wCommon + 75;
        int wRare = wUncommon + 50;
        int wEpic =  wRare + 25;
        int wLegendary = wEpic + 1;

        int bCommon = 100;
        int bUncommon = bCommon + 75;
        int bRare = bUncommon + 50;
        int bEpic = bRare + 25;
        int bLegendary = bEpic + 1;

        int sCommon = 75;
        int sUncommon = sCommon + 50;
        int sRare = sUncommon + 25;
        int sEpic = sRare + 10;
        int sLegendary = sEpic + 5;

        int gCommon = 50;
        int gUncommon = gCommon + 25;
        int gRare = gUncommon + 10;
        int gEpic = gRare + 5;
        int gLegendary = gEpic + 1;

        int pCommon = 10;
        int pUncommon = pCommon + 25;
        int pRare = pUncommon + 5;
        int pEpic = pRare + 15;
        int pLegendary = pEpic + 10;

        if (Input.GetKeyUp(KeyCode.L))
        {
            int test = Random.Range(0, 379);
            if (test <= wood)
            {
                Debug.Log("Found: " + ChestTypes[0] + " Chest!");
                int woodType = Random.Range(0, 250);
                if (woodType <= wCommon)
                {
                    Debug.Log("Chest contains: One " + DropTypes[0] + " Item!");
                }
                else if (woodType > wCommon && woodType <= wUncommon)
                {
                    Debug.Log("Chest contains: One " + DropTypes[1] + " Item!");
                }
                else if (woodType > wUncommon && woodType <= wRare)
                {
                    Debug.Log("Chest contains: One " + DropTypes[2] + " Item!");
                }
                else if (woodType > wRare && woodType <= wEpic)
                {
                    Debug.Log("Chest contains: One " + DropTypes[3] + " Item!");
                }
                else if (woodType > wEpic && woodType <= wLegendary)
                {
                    Debug.Log("Chest contains: One  " + DropTypes[4] + " Item!");
                }
            }
            else if (test > wood && test <= bronze)
            {
                Debug.Log("Found: " + ChestTypes[1] + " Chest!");
                int bronzeType = Random.Range(0, 250);
                if (bronzeType <= bCommon)
                {
                    Debug.Log("Chest contains: One " + DropTypes[0] + " Item!");
                }
                else if (bronzeType > bCommon && bronzeType <= bUncommon)
                {
                    Debug.Log("Chest contains: One " + DropTypes[1] + " Item!");
                }
                else if (bronzeType > bUncommon && bronzeType <= bRare)
                {
                    Debug.Log("Chest contains: One " + DropTypes[2] + " Item!");
                }
                else if (bronzeType > bRare && bronzeType <= bEpic)
                {
                    Debug.Log("Chest contains: One " + DropTypes[3] + " Item!");
                }
                else if (bronzeType > bEpic && bronzeType <= bLegendary)
                {
                    Debug.Log("Chest contains: One  " + DropTypes[4] + " Item!");
                }
            }
            else if (test > bronze && test <= silver)
            {
                Debug.Log("Found: " + ChestTypes[2] + " Chest!");
                int silverType = Random.Range(0, 164);
                if (silverType <= sCommon)
                {
                    Debug.Log("Chest contains: One " + DropTypes[0] + " Item!");
                }
                else if (silverType > sCommon && silverType <= sUncommon)
                {
                    Debug.Log("Chest contains: One " + DropTypes[1] + " Item!");
                }
                else if (silverType > sUncommon && silverType <= sRare)
                {
                    Debug.Log("Chest contains: One  " + DropTypes[2] + " Item!");
                }
                else if (silverType > sRare && silverType <= sEpic)
                {
                    Debug.Log("Chest contains: One " + DropTypes[3] + " Item!");
                }
                else if (silverType > sEpic && silverType <= sLegendary)
                {
                    Debug.Log("Chest contains: One " + DropTypes[4] + " Item!");
                }
            }
            else if (test > silver && test <= gold)
            {
                Debug.Log("Found: " + ChestTypes[3] + " Chest!");
                int goldType = Random.Range(0, 90);
                if (goldType <= gCommon)
                {
                    Debug.Log("Chest contains: One " + DropTypes[0] + " Item!");
                }
                else if (goldType > gCommon && goldType <= gUncommon)
                {
                    Debug.Log("Chest contains: One  " + DropTypes[1] + " Item!");
                }
                else if (goldType > gUncommon && goldType <= gRare)
                {
                    Debug.Log("Chest contains: One " + DropTypes[2] + " Item!");
                }
                else if (goldType > gRare && goldType <= gEpic)
                {
                    Debug.Log("Chest contains: One " + DropTypes[3] + " Item!");
                }
                else if (goldType > gEpic && goldType <= gLegendary)
                {
                    Debug.Log("Chest contains: One " + DropTypes[4] + " Item!");
                }
            }
            else if (test > gold && test <= platinum)
            {
                Debug.Log("Found: " + ChestTypes[4] + " Chest!");
                int platinumType = Random.Range(0, 64);
                if (platinumType <= pCommon)
                {
                    Debug.Log("Chest contains: One " + DropTypes[0] + " Item!");
                }
                else if (platinumType > pCommon && platinumType <= pUncommon)
                {
                    Debug.Log("Chest contains: One " + DropTypes[1] + " Item!");
                }
                else if (platinumType > pUncommon && platinumType <= pRare)
                {
                    Debug.Log("Chest contains: One " + DropTypes[2] + " Item!");
                }
                else if (platinumType > pRare && platinumType <= pEpic)
                {
                    Debug.Log("Chest contains: One  " + DropTypes[3] + " Item!");
                }
                else if (platinumType > pEpic && platinumType <= pLegendary)
                {
                    Debug.Log("Chest contains: One " + DropTypes[4] + " Item!");
                }
            }
        }
    }
}
