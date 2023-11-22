using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class LootTable : MonoBehaviour
{
    [SerializeField] private List<string> ChestTypes = new List <string>();
    [SerializeField] private List<string> DropTypes = new List<string>();
    [SerializeField] private int wood;
    [SerializeField] private int bronze;
    [SerializeField] private int silver;
    [SerializeField] private int gold;
    [SerializeField] private int platinum;
    [Header ("Wood Chest")]
    [SerializeField] private int wCommon;
    [SerializeField] private int wUncommon;
    [SerializeField] private int wRare;
    [SerializeField] private int wEpic;
    [SerializeField] private int wLegendary;
    [Header ("Bronze Chest")]
    [SerializeField] private int bCommon;
    [SerializeField] private int bUncommon;
    [SerializeField] private int bRare;
    [SerializeField] private int bEpic;
    [SerializeField] private int bLegendary;
    [Header ("Silver Chest")]
    [SerializeField] private int sCommon;
    [SerializeField] private int sUncommon;
    [SerializeField] private int sRare;
    [SerializeField] private int sEpic;
    [SerializeField] private int sLegendary;
    [Header ("Gold Chest")]
    [SerializeField] private int gCommon;
    [SerializeField] private int gUncommon;
    [SerializeField] private int gRare;
    [SerializeField] private int gEpic;
    [SerializeField] private int gLegendary;
    [Header ("Platinum Chest")]
    [SerializeField] private int pCommon;
    [SerializeField] private int pUncommon;
    [SerializeField] private int pRare;
    [SerializeField] private int pEpic;
    [SerializeField] private int pLegendary;

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
        wood = 200;
        bronze = wood + 100;
        silver = bronze + 50;
        gold = silver + 25;
        platinum = gold + 5;

        wCommon = 100;
        wUncommon = wCommon + 75;
        wRare = wUncommon + 50;
        wEpic =  wRare + 25;
        wLegendary = wEpic + 1;

        bCommon = 100;
        bUncommon = bCommon + 75;
        bRare = bUncommon + 50;
        bEpic = bRare + 25;
        bLegendary = bEpic + 1;

        sCommon = 75;
        sUncommon = sCommon + 50;
        sRare = sUncommon + 25;
        sEpic = sRare + 10;
        sLegendary = sEpic + 5;

        gCommon = 50;
        gUncommon = gCommon + 25;
        gRare = gUncommon + 10;
        gEpic = gRare + 5;
        gLegendary = gEpic + 1;

        pCommon = 10;
        pUncommon = pCommon + 25;
        pRare = pUncommon + 5;
        pEpic = pRare + 15;
        pLegendary = pEpic + 10;

        if (Input.GetKeyUp(KeyCode.Space))
        {
            int test = Random.Range(0, 379);
            if (test <= wood)
            {
                int woodType = Random.Range(0, 250);
                if (woodType <= wCommon)
                {
                    Debug.Log("Found: " + ChestTypes[0] + " Chest! \nChest contains: One " + DropTypes[0] + " Item!");
                }
                else if (woodType > wCommon && woodType <= wUncommon)
                {
                    Debug.Log("Found: " + ChestTypes[0] + " Chest! \nChest contains: One " + DropTypes[1] + " Item!");
                }
                else if (woodType > wUncommon && woodType <= wRare)
                {
                    Debug.Log("Found: " + ChestTypes[0] + " Chest! \nChest contains: One " + DropTypes[2] + " Item!");
                }
                else if (woodType > wRare && woodType <= wEpic)
                {
                    Debug.Log("Found: " + ChestTypes[0] + " Chest! \nChest contains: One " + DropTypes[3] + " Item!");
                }
                else if (woodType > wEpic && woodType <= wLegendary)
                {
                    Debug.Log("Found: " + ChestTypes[0] + " Chest! \nChest contains: One  " + DropTypes[4] + " Item!");
                }
            }
            else if (test > wood && test <= bronze)
            {
                int bronzeType = Random.Range(0, 250);
                if (bronzeType <= bCommon)
                {
                    Debug.Log("Found: " + ChestTypes[1] + " Chest! \nChest contains: One " + DropTypes[0] + " Item!");
                }
                else if (bronzeType > bCommon && bronzeType <= bUncommon)
                {
                    Debug.Log("Found: " + ChestTypes[1] + " Chest! \nChest contains: One " + DropTypes[1] + " Item!");
                }
                else if (bronzeType > bUncommon && bronzeType <= bRare)
                {
                    Debug.Log("Found: " + ChestTypes[1] + " Chest! \nChest contains: One " + DropTypes[2] + " Item!");
                }
                else if (bronzeType > bRare && bronzeType <= bEpic)
                {
                    Debug.Log("Found: " + ChestTypes[1] + " Chest! \nChest contains: One " + DropTypes[3] + " Item!");
                }
                else if (bronzeType > bEpic && bronzeType <= bLegendary)
                {
                    Debug.Log("Found: " + ChestTypes[1] + " Chest! \nChest contains: One  " + DropTypes[4] + " Item!");
                }
            }
            else if (test > bronze && test <= silver)
            {
                int silverType = Random.Range(0, 164);
                if (silverType <= sCommon)
                {
                    Debug.Log("Found: " + ChestTypes[2] + " Chest! \nChest contains: One " + DropTypes[0] + " Item!");
                }
                else if (silverType > sCommon && silverType <= sUncommon)
                {
                    Debug.Log("Found: " + ChestTypes[2] + " Chest! \nChest contains: One " + DropTypes[1] + " Item!");
                }
                else if (silverType > sUncommon && silverType <= sRare)
                {
                    Debug.Log("Found: " + ChestTypes[2] + " Chest! \nChest contains: One  " + DropTypes[2] + " Item!");
                }
                else if (silverType > sRare && silverType <= sEpic)
                {
                    Debug.Log("Found: " + ChestTypes[2] + " Chest! \nChest contains: One " + DropTypes[3] + " Item!");
                }
                else if (silverType > sEpic && silverType <= sLegendary)
                {
                    Debug.Log("Found: " + ChestTypes[2] + " Chest! \nChest contains: One " + DropTypes[4] + " Item!");
                }
            }
            else if (test > silver && test <= gold)
            {
                int goldType = Random.Range(0, 90);
                if (goldType <= gCommon)
                {
                    Debug.Log("Found: " + ChestTypes[3] + " Chest! \nChest contains: One " + DropTypes[0] + " Item!");
                }
                else if (goldType > gCommon && goldType <= gUncommon)
                {
                    Debug.Log("Found: " + ChestTypes[3] + " Chest! \nChest contains: One  " + DropTypes[1] + " Item!");
                }
                else if (goldType > gUncommon && goldType <= gRare)
                {
                    Debug.Log("Found: " + ChestTypes[3] + " Chest! \nChest contains: One " + DropTypes[2] + " Item!");
                }
                else if (goldType > gRare && goldType <= gEpic)
                {
                    Debug.Log("Found: " + ChestTypes[3] + " Chest! \nChest contains: One " + DropTypes[3] + " Item!");
                }
                else if (goldType > gEpic && goldType <= gLegendary)
                {
                    Debug.Log("Found: " + ChestTypes[3] + " Chest! \nChest contains: One " + DropTypes[4] + " Item!");
                }
            }
            else if (test > gold && test <= platinum)
            {
                int platinumType = Random.Range(0, 64);
                if (platinumType <= pCommon)
                {
                    Debug.Log("Found: " + ChestTypes[4] + " Chest! \nChest contains: One " + DropTypes[0] + " Item!");
                }
                else if (platinumType > pCommon && platinumType <= pUncommon)
                {
                    Debug.Log("Found: " + ChestTypes[4] + " Chest! \nChest contains: One " + DropTypes[1] + " Item!");
                }
                else if (platinumType > pUncommon && platinumType <= pRare)
                {
                    Debug.Log("Found: " + ChestTypes[4] + " Chest! \nChest contains: One " + DropTypes[2] + " Item!");
                }
                else if (platinumType > pRare && platinumType <= pEpic)
                {
                    Debug.Log("Found: " + ChestTypes[4] + " Chest! \nChest contains: One  " + DropTypes[3] + " Item!");
                }
                else if (platinumType > pEpic && platinumType <= pLegendary)
                {
                    Debug.Log("Found: " + ChestTypes[4] + " Chest! \nChest contains: One " + DropTypes[4] + " Item!");
                }
            }
        }
    }
}
