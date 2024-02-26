using UnityEngine;
using Zenject;

namespace ris
{
  public class MovementInstaller : MonoInstaller
  {
    [SerializeField] private GameObject movementPrefab;

    public override void InstallBindings()
    {
      Container
        .Bind<polyomino.PolyominoMovement>()
        .FromComponentInNewPrefab(movementPrefab)
        .AsSingle()
        .NonLazy();

      Container
        .Bind<RISInputActions>()
        .FromNew()
        .AsSingle()
        .OnInstantiated<RISInputActions>
          ((context, inputActions) => inputActions.Player.Enable())
        .NonLazy();
    }
  }
}
