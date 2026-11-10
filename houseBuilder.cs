using System;

class HouseBuilder {
    public string materialParede;
    public string materialTelhado;
    public int quantidadeJanelas;
    
    // build casita
    public HouseBuilder(string materialParede, string materialTelhado, int quantidadeJanelas) {
        this.materialParede = materialParede;
        this.materialTelhado = materialTelhado;
        this.quantidadeJanelas = quantidadeJanelas;
    }
    // Add janeulas
    public void AddWindow() {
        quantidadeJanelas += 1;
    }
    
    public int GetWindowsCount() {
        return quantidadeJanelas;
    }
}

class Program {
    static void Main() {
        HouseBuilder casa1 = new HouseBuilder("Tijolos", "Zinco", 4);
        Console.WriteLine(casa1.materialParede);
        Console.WriteLine(casa1.materialTelhado);
        Console.WriteLine(casa1.GetWindowsCount());
        casa1.AddWindow();
        Console.WriteLine(casa1.GetWindowsCount);
    }
}
