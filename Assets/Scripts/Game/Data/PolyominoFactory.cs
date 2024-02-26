using System;
using System.Collections.Generic;
using UnityEngine;

namespace ris.polyomino
{
  public class PolyominoFactory : MonoBehaviour
  {
    [Serializable]
    private struct PolyominoInfo
    {
      public PolyominoType type;
      public GameObject    prefab;
    }

    #region PARAMETERS
    [SerializeField] private List<PolyominoInfo> polyominoPrefabs;
    #endregion

    #region PROPERTIES
    public Dictionary<PolyominoType, GameObject> PolyominoPrefabs { get; private set; }
    #endregion

    #region LIFECYCLE
    protected void Awake()
    {
      PolyominoPrefabs = new Dictionary<PolyominoType, GameObject>();

      foreach (var info in polyominoPrefabs)
        PolyominoPrefabs.Add(info.type, info.prefab);
    }
    #endregion

    #region METHODS
    public bool TryGet(PolyominoType _type, out Polyomino _polyomino)
    {
      _polyomino = null;

      if (!PolyominoPrefabs.ContainsKey(_type))
        return false;

      DiContainerRef.Container.InstantiatePrefab(PolyominoPrefabs[_type]);

      return true;
    }
    #endregion
  }
}
