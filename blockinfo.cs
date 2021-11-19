public struct BlockInfo {
    public ControlInfo[] Controls {get; set;}
    public OutputInfo[] Outputs {get; set;}
}

public struct ControlInfo {
    public string Name {get; set;}
    public Object Value {get; set;}
    public string ValueType {get; set;}
}

public struct OutputInfo {
    public string Name {get; set;}
    public string ValueType {get; set;}
}
