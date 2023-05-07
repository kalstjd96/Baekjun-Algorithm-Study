using System;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "TaxSquareData", menuName = "ScriptableObjects/TaxManagerScriptableObject", order = 1)]
public class TaxManagerScriptableObject : ScriptableObject
{
    public List<TaxCarData>[] carDatas;

    public GameObject[] carArray;
    public GameObject[] house;

    //최초에 한번만 진행
    public void SetData()
    {
        carDatas = new List<TaxCarData>[carArray.Length];
        for (int i = 0; i < carDatas.Length; i++)
            carDatas[i] = new List<TaxCarData>();

        for (int i = 0; i < carArray.Length; i++)
            SetCarData(carArray[i], carArray[i].transform.position, i);
    }

    #region 이지하우스 관리
    //집은 고정된 위치에서 Active On/Off만 진행
    //수정 필요!!
    public struct TaxHouseData
    {
        public TaxHouseData(GameObject houseObj, Vector3 houseLoc)
        {
            this.houseObj = houseObj;
            this.houseLoc = houseLoc;
        }
        public GameObject houseObj;
        public Vector3 houseLoc;
    }

    #endregion

    #region 이지카 관리
    /// <summary>
    /// 운전 후 길거리에 놓아도 재접속하게 되면 차고지에 위치하게 하기 위함
    /// </summary>
    public struct TaxCarData
    {
        public TaxCarData(GameObject carObj, Vector3 carLoc)
        {
            this.carObj = carObj;
            this.carLoc = carLoc;
        }
        public GameObject carObj;
        public Vector3 carLoc;
        
    }

    void SetCarData(GameObject carObj, Vector3 carLoc, int index)
    {
        carDatas[index].Add(new TaxCarData(carObj, carLoc));
    }

    public TaxCarData GetCarData(int index)
    {
        return this.carDatas[index][this.carDatas[index].Count -1];
    }

    public int GetLength()
    {
        return this.carDatas.Length;
    }

    #endregion

}
