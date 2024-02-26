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
        .Bind<polyomino.PolyominoFactory>()
        .FromComponentInNewPrefab(factoryPrefab)
        .AsSingle()
        .NonLazy();
    }
  }
}