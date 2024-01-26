namespace Exercicio2;

public class Students {
    public string Name { get; set; }
    public string Email{ get; set; }
    public int Room{ get; set; }

    public override string ToString() {
        return $"{Room}, {Name}, {Email}";
    }
}
