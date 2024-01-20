using System;
using UnityEngine;
using UnityEngine.AddressableAssets;
using System.Collections.Generic;
using UnityEngine.ResourceManagement.AsyncOperations;
using System.Threading.Tasks;
public static class TempelateInfra {
    public static void LoadAll(TempelateContext tempCon) {
        {
            // AssetLabelReference labelReference = new AssetLabelReference();
            // labelReference.labelString = "TowerTM";
            const string lable="TowerTM";
            IList<TowerTM> all = Addressables.LoadAssetsAsync<TowerTM>(lable, null).WaitForCompletion();
            foreach(var tm in all){
                tempCon.Add_TowerTM(tm);
            }
        }
        {
            // const string lable=""
        }
    }
}