// using UnityEngine;
// public static class FindHelper {
//     public bool FindNearlyEnemy(Vector2 pos, Ally ally, float radius, out RoleEntity nearlyMonster) {
//         RoleEntity nearMonster = default;
//         float neaarlyDistance = radius * radius;
//         for (int i = 0; i < roleLen; i++) {
//             var ro = all_role[i];
//             if (ro.ally != ally) {
//                 Vector2 dir = (Vector2)ro.transform.position - pos;
//                 float Distance = dir.sqrMagnitude;
//                 if (Distance <= neaarlyDistance) {
//                     neaarlyDistance = Distance;
//                     nearMonster = ro;
//                 }
//             }
//         }
//         nearlyMonster = nearMonster;
//         if (nearMonster != default) {
//             return true;
//         }
//         return false;
//     }
// }