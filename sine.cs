public class Sine : UnitGen {
    public Sine(float freq = 1.0f, float phase = 0.0f) {
        Freq = new Control<float>(freq);
        Phase = new Control<float>(phase);
        Out = new Output<float>();
    }

    public Control<float> Freq;
    public Control<float> Phase;
    public Output<float> Out;

    public override Dictionary<string, IControl> Controls() {
        return new Dictionary<string, IControl>(){
            {"Freq", Freq},
            {"Phase", Phase},
        };
    }

    public override Dictionary<string, IOutput> Outputs() {
        return new Dictionary<string, IOutput>(){
            {"Out", Out},
        };
    }
}