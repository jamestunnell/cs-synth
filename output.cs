public interface IOutput {
    Type ValueType();
}

public class Output<T> : IOutput where T : struct {
    public T[] Values;

    public Output() {
        Values = new T[]{};
    }

    public Type ValueType() {
        return typeof(T);
    }
}
