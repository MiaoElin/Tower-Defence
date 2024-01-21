using System.Collections.Generic;
using UnityEngine.AddressableAssets;
using UnityEngine.ResourceManagement.AsyncOperations;
using UnityEngine;
public static class AssetsInfra {
    public static void LoadAll(AssetsContext con) {
        {
            const string lable = "Entities";
            IList<GameObject> all = Addressables.LoadAssetsAsync<GameObject>(lable, null).WaitForCompletion();
            foreach (var tm in all) {
                con.Add_Entity(tm.name, tm);
            }
        }
        {
            const string lable = "Panels";
            IList<GameObject> all = Addressables.LoadAssetsAsync<GameObject>(lable, null).WaitForCompletion();
            foreach (var tm in all) {
                con.Add_Panel(tm.name, tm);
            }
        }

    }
}