public interface IControl {
    Object ValueObj();
    Type ValueType();
}

public class Control<T> : IControl where T : struct {
    public T Value;

    public Control() {
        Value = default(T);
    }

    public Control(T val) {
        Value = val;
    }

    public Object ValueObj() {
        return Value;
    }

    public Type ValueType() {
        return typeof(T);
    }
}
