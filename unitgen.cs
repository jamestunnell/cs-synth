using System.Text.Json;

public abstract class UnitGen : IBlock {
    public BlockInfo Info() {
        var ctrls = Controls();
        var outs = Outputs();
        var blockInfo = new BlockInfo();
        
        blockInfo.Controls = new ControlInfo[ctrls.Count];
        blockInfo.Outputs = new OutputInfo[outs.Count];

        int i = 0;
        foreach (KeyValuePair<string, IControl> pair in ctrls) {
            var ctrlInfo = new ControlInfo();

            ctrlInfo.Name = pair.Key;
            ctrlInfo.ValueType = pair.Value.ValueType().ToString();
            ctrlInfo.Value = pair.Value.ValueObj();

            blockInfo.Controls[i] = ctrlInfo;
            i++;
        }

        i = 0;
        foreach (KeyValuePair<string, IOutput> pair in outs) {
            var outInfo = new OutputInfo();

            outInfo.Name = pair.Key;
            outInfo.ValueType = pair.Value.ValueType().ToString();

            blockInfo.Outputs[i] = outInfo;
            i++;
        }

        return blockInfo;
    }

    public string ToJSON() {
        string jsonString = JsonSerializer.Serialize(Info());

        return jsonString;
    }

    override public string ToString() {
        return ToJSON();
    }

    public abstract Dictionary<string, IControl> Controls();
    public abstract Dictionary<string, IOutput> Outputs();
}
