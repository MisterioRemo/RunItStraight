using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Zenject;

namespace ris.polyomino
{
  public class PolyominoSpawner : MonoBehaviour
  {
    #region PARAMETERS
    private Vector3 spawnPosition;

    [Inject] private PolyominoFactory  factory;
    [Inject] private PolyominoMovement movement;
    #endregion

    void Start()
    {
    }

    void Update()
    {
    }

    #region INTERFACE
    public Polyomino Spawn()
    {
      if (factory.TryGet(PolyominoType.Monomino, out Polyomino polyomino))
        movement.ActivePolyomino = polyomino;

      return polyomino;
    }
    #endregion
  }
}
