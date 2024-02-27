using UnityEngine;
using Zenject;

namespace ris
{
  public class FactoryInstaller : MonoInstaller
  {
    [SerializeField] private GameObject factoryPrefab;
    public override void InstallBindings()
    {
      Container
        .Bind(typeof(polyomino.PolyominoFactory), typeof(polyomino.PolyominoSpawner))
        .FromComponentInNewPrefab(factoryPrefab)
        .AsSingle()
        .NonLazy();
    }
  }
}