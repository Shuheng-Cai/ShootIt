using System;
using System.Collections.Generic;
using System.Linq;

public class StateFactory
{
    private Dictionary<string, Type> _NameForm = new Dictionary<string, Type>();

    public StateFactory()
    {
        Register<YellowState>();
        Register<BlueState>();
    }

    public void Register<T>() where T : FormState
    {
        _NameForm[typeof(T).Name] = typeof(T);
    }

    public FormState Create(string name, params object[] args)
    {
        if (_NameForm.TryGetValue(name, out var type))
        {
            foreach (var ctor in type.GetConstructors())
            {
                var parameters = ctor.GetParameters();
                if (parameters.Length == args.Length &&
                    parameters.Select(p => p.ParameterType).SequenceEqual(args.Select(a => a.GetType())))
                {
                    return (FormState)ctor.Invoke(args);
                }
            }
            throw new Exception($"No matching constructor found for {name}");
        }
        throw new Exception($"State {name} not registered!");
    }
}
