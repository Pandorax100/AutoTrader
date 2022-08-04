namespace Pandorax.AutoTrader.Utils;

#pragma warning disable CA1716 // Identifiers should not match keywords
public struct Optional<T>
#pragma warning restore CA1716 // Identifiers should not match keywords
{
    private readonly T _value;

    public Optional(T value)
    {
        _value = value;
        IsSpecified = true;
    }

    public readonly bool IsSpecified { get; }

    public readonly T Value
    {
        get
        {
            if (!IsSpecified)
            {
                throw new InvalidOperationException("This property is not specified");
            }
            return _value;
        }
    }

    public static implicit operator Optional<T>(T value) => new Optional<T>(value);
    public static explicit operator T(Optional<T> value) => value!.Value;

    public override int GetHashCode() => IsSpecified && _value is not null ? _value.GetHashCode() : 0;

    public readonly T GetValueOrDefault() => _value;

    public readonly T GetValueOrDefault(T defaultValue) =>
        IsSpecified ? _value : defaultValue;
}
