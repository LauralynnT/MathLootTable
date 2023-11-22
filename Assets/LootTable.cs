using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Unity.VisualScripting;
using UnityEngine;

public class LootTable : MonoBehaviour
{
    [SerializeField] private List<string> ChestTypes = new List <string>();
    [SerializeField] private List<string> DropTypes = new List<string>();

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
