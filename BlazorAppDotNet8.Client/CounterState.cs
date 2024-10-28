using Fluxor;

namespace BlazorAppDotNet8.Client;


[FeatureState]
public class CounterState
{
    public int ClickCount { get; }

    private CounterState() { } // Required for creating initial state

    public CounterState(int clickCount)
    {
        ClickCount = clickCount;
    }
}


public class IncrementCounterAction { }


public static class Reducers
{
    [ReducerMethod]
    public static CounterState ReduceIncrementCounterAction(CounterState state, IncrementCounterAction action) =>
      new CounterState(clickCount: state.ClickCount + 1);
}