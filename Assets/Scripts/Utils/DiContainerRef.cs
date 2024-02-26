using Zenject;

namespace ris
{
  public static class DiContainerRef
  {
    private static DiContainer diContainer;

    public static DiContainer Container { get => diContainer;
                                          set => diContainer ??= value;
                                        }
  }
}
